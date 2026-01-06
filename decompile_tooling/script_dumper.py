#!/usr/bin/env python3
"""
Il2CppDumper ScriptDump.cs -> folder/file structure extractor

What it does:
- Reads Il2CppDumper's ScriptDump.cs (signatures-only C# dump)
- Splits it into one .cs file per *top-level* type, placed under a namespace folder tree:
    out/Namespace/Like/This/TypeName.cs
- Writes an index.json with symbols + where they landed.

Works great as an "AI agent reference corpus" even for IL2CPP mainline builds.
"""

from __future__ import annotations

import argparse
import json
import re
from dataclasses import dataclass, asdict
from pathlib import Path
from typing import Optional, List, Dict, Tuple


# --- Parsing helpers ---------------------------------------------------------

NAMESPACE_RE = re.compile(r"^\s*namespace\s+([A-Za-z_][\w\.]*)\s*$")
TYPE_RE = re.compile(
    r"^\s*(?:public|private|protected|internal|static|abstract|sealed|partial|\s)+\s*"
    r"(class|struct|interface|enum)\s+([A-Za-z_]\w*(?:<[^>]+>)?)"
)
# Some dumps omit access modifiers:
TYPE_RE_FALLBACK = re.compile(r"^\s*(class|struct|interface|enum)\s+([A-Za-z_]\w*(?:<[^>]+>)?)")


def count_braces(line: str) -> int:
    """Net brace delta for a line, ignoring braces inside strings (best-effort)."""
    # Very lightweight string skipping; good enough for ScriptDump style.
    in_str = False
    esc = False
    delta = 0
    for ch in line:
        if in_str:
            if esc:
                esc = False
            elif ch == "\\":
                esc = True
            elif ch == '"':
                in_str = False
            continue
        else:
            if ch == '"':
                in_str = True
                continue
            if ch == "{":
                delta += 1
            elif ch == "}":
                delta -= 1
    return delta


def safe_type_filename(type_name: str) -> str:
    """
    Convert 'Foo<T>' into a filesystem-safe name.
    """
    # Replace generic params with something stable.
    name = type_name.strip()
    name = re.sub(r"<\s*", "_of_", name)
    name = re.sub(r"\s*,\s*", "_and_", name)
    name = name.replace(">", "")
    # Remove any remaining illegal path characters
    name = re.sub(r'[<>:"/\\|?*\x00-\x1F]', "_", name)
    return name


@dataclass
class SymbolInfo:
    kind: str
    namespace: str
    name: str
    file: str
    start_line: int
    end_line: int


# --- Main extraction ---------------------------------------------------------

def extract_from_scriptdump(scriptdump_path: Path, out_dir: Path) -> List[SymbolInfo]:
    text = scriptdump_path.read_text(encoding="utf-8", errors="replace")
    lines = text.splitlines()

    out_dir.mkdir(parents=True, exist_ok=True)

    symbols: List[SymbolInfo] = []

    current_namespace = ""  # global namespace
    ns_target_depth: Optional[int] = None  # brace depth *inside* current namespace block

    brace_depth = 0

    capturing = False
    cap_kind = ""
    cap_name = ""
    cap_namespace = ""
    cap_start_depth = 0
    cap_start_line = 0
    cap_lines: List[str] = []

    def flush_capture(end_line: int):
        nonlocal capturing, cap_kind, cap_name, cap_namespace, cap_start_depth, cap_start_line, cap_lines

        if not capturing:
            return

        ns_path = Path(*([p for p in cap_namespace.split(".") if p] or ["__global__"]))
        type_file = safe_type_filename(cap_name) + ".cs"
        dest_dir = out_dir / ns_path
        dest_dir.mkdir(parents=True, exist_ok=True)
        dest_path = dest_dir / type_file

        dest_path.write_text("\n".join(cap_lines) + "\n", encoding="utf-8")

        symbols.append(
            SymbolInfo(
                kind=cap_kind,
                namespace=cap_namespace,
                name=cap_name,
                file=str(dest_path.relative_to(out_dir)).replace("\\", "/"),
                start_line=cap_start_line,
                end_line=end_line,
            )
        )

        capturing = False
        cap_kind = ""
        cap_name = ""
        cap_namespace = ""
        cap_start_depth = 0
        cap_start_line = 0
        cap_lines = []

    # We treat "top-level type" as: type starts when brace_depth == (ns_target_depth or 0)
    # i.e. inside a namespace block, top-level depth is ns_target_depth; otherwise it's 0.
    for i, line in enumerate(lines, start=1):
        stripped = line.strip()

        # Detect namespace lines BEFORE applying brace delta (ScriptDump usually has "namespace X" then "{")
        if not capturing:
            mns = NAMESPACE_RE.match(stripped)
            if mns:
                current_namespace = mns.group(1)
                # We'll set ns_target_depth once we see the opening '{' that enters the namespace
                # i.e., when brace depth increments after the line containing "{"
                # Many dumps have '{' on the next line; handled below.
                ns_target_depth = None

        # Decide if we should start capturing a top-level type here
        if not capturing:
            # Determine current top-level depth
            top_level_depth = ns_target_depth if ns_target_depth is not None else (0 if current_namespace == "" else None)

            # If we're inside a namespace but haven't seen its '{' yet, don't start capturing types.
            # (Because we don't know the correct depth.)
            if current_namespace != "" and ns_target_depth is None:
                top_level_depth = None

            # Type declaration detection
            mtype = TYPE_RE.match(stripped) or TYPE_RE_FALLBACK.match(stripped)
            if mtype and top_level_depth is not None and brace_depth == top_level_depth:
                cap_kind = mtype.group(1)
                cap_name = mtype.group(2)
                cap_namespace = current_namespace
                cap_start_depth = brace_depth
                cap_start_line = i
                capturing = True
                cap_lines = []

        # Append lines if capturing
        if capturing:
            cap_lines.append(line)

        # Apply brace delta
        delta = count_braces(line)
        old_depth = brace_depth
        brace_depth += delta

        # If we just entered a namespace, set ns_target_depth
        # Pattern: namespace line encountered earlier, then when we see brace_depth increase by 1 from old_depth
        # and ns_target_depth is None and current_namespace non-empty.
        if current_namespace != "" and ns_target_depth is None:
            # If the line has an opening brace that increased depth, consider that the namespace open
            if delta > 0 and "{" in line:
                # After the namespace '{', top-level types occur at the *new* brace_depth
                ns_target_depth = brace_depth

        # If we left the namespace block, reset namespace.
        if current_namespace != "" and ns_target_depth is not None:
            # When brace_depth drops below ns_target_depth, the namespace ended.
            if brace_depth < ns_target_depth:
                current_namespace = ""
                ns_target_depth = None

        # End capture when we return to the starting depth (i.e., type block closed)
        if capturing and brace_depth == cap_start_depth and i > cap_start_line:
            flush_capture(end_line=i)

    # Flush if file ended mid-capture (rare)
    if capturing:
        flush_capture(end_line=len(lines))

    return symbols


def write_index(symbols: List[SymbolInfo], out_dir: Path, source_file: Path):
    index = {
        "source": str(source_file),
        "symbol_count": len(symbols),
        "symbols": [asdict(s) for s in symbols],
        "by_namespace": {},
    }

    by_ns: Dict[str, List[Dict]] = {}
    for s in symbols:
        by_ns.setdefault(s.namespace or "__global__", []).append(
            {"kind": s.kind, "name": s.name, "file": s.file}
        )
    # Sort for stable diffs
    for ns, items in by_ns.items():
        items.sort(key=lambda x: (x["name"], x["kind"]))
    index["by_namespace"] = dict(sorted(by_ns.items(), key=lambda kv: kv[0]))

    (out_dir / "index.json").write_text(json.dumps(index, indent=2), encoding="utf-8")


def find_scriptdump(il2cppdumper_out: Path) -> Path:
    candidates = [
        il2cppdumper_out / "ScriptDump.cs",
        il2cppdumper_out / "dump.cs",
        il2cppdumper_out / "scriptdump.cs",
    ]
    for c in candidates:
        if c.exists():
            return c

    # fallback: search shallow
    for c in il2cppdumper_out.rglob("*.cs"):
        if c.name.lower() in {"scriptdump.cs", "dump.cs"}:
            return c

    raise FileNotFoundError(
        f"Couldn't find ScriptDump.cs (or dump.cs) under: {il2cppdumper_out}"
    )


def main():
    ap = argparse.ArgumentParser(
        description="Extract Il2CppDumper ScriptDump.cs into a namespace/type folder structure."
    )
    ap.add_argument(
        "--in",
        dest="in_dir",
        required=True,
        help="Path to Il2CppDumper output folder (contains ScriptDump.cs and/or DummyDll).",
    )
    ap.add_argument(
        "--out",
        dest="out_dir",
        required=True,
        help="Output folder where extracted .cs files + index.json will be written.",
    )
    args = ap.parse_args()

    in_dir = Path(args.in_dir).expanduser().resolve()
    out_dir = Path(args.out_dir).expanduser().resolve()

    scriptdump = find_scriptdump(in_dir)
    symbols = extract_from_scriptdump(scriptdump, out_dir)
    write_index(symbols, out_dir, scriptdump)

    print(f"ScriptDump: {scriptdump}")
    print(f"Extracted {len(symbols)} top-level symbols into: {out_dir}")
    print(f"Wrote index: {out_dir / 'index.json'}")


if __name__ == "__main__":
    main()
