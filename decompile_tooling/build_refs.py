#!/usr/bin/env python3
"""
Build an AI-reference corpus that combines:
- Game IL2CPP dump corpus (already extracted into .cs files + index.json)
- S1API from a Thunderstore package (zip/folder), decompiled to .cs via ilspycmd

Outputs:
refs_root/
  game/               (optional copy or pointer-only; we merge index regardless)
  s1api/
    raw/              (copied dll/xml/pdb as found)
    decompiled/       (ilspycmd output, one folder per dll)
    index.json        (symbols extracted from decompiled sources)
  deps/               (optional: copied key deps like HarmonyLib.dll if present)
  index.json          (combined index: game + s1api)

Notes:
- Script tries hard to find S1API DLLs from Thunderstore layouts.
- Decompilation requires ilspycmd installed and available on PATH.
"""

from __future__ import annotations

import argparse
import json
import os
import re
import shutil
import subprocess
import sys
import tempfile
import zipfile
from dataclasses import dataclass, asdict
from pathlib import Path
from typing import Dict, List, Optional, Tuple


# -------------------------
# Utilities
# -------------------------

def die(msg: str, code: int = 1) -> None:
    print(f"[ERROR] {msg}", file=sys.stderr)
    sys.exit(code)


def ensure_dir(p: Path) -> None:
    p.mkdir(parents=True, exist_ok=True)


def is_zip_path(p: Path) -> bool:
    return p.is_file() and p.suffix.lower() == ".zip"


def extract_zip(zip_path: Path, dst: Path) -> None:
    ensure_dir(dst)
    with zipfile.ZipFile(zip_path, "r") as zf:
        zf.extractall(dst)


def which(cmd: str) -> Optional[str]:
    return shutil.which(cmd)


def run(cmd: List[str], cwd: Optional[Path] = None) -> None:
    # Print a readable command
    pretty = " ".join([f'"{c}"' if " " in c else c for c in cmd])
    print(f"[RUN] {pretty}")
    subprocess.run(cmd, cwd=str(cwd) if cwd else None, check=True)


# -------------------------
# Finding S1API in Thunderstore package
# -------------------------

S1API_DLL_RE = re.compile(r"^S1API(\..+)?\.dll$", re.IGNORECASE)
COMMON_DEP_DLLS = {
    "HarmonyLib.dll",
    "0Harmony.dll",  # sometimes
}


def find_candidate_dlls(root: Path) -> List[Path]:
    # Search recursively for dlls; ignore "obj/bin" style build output if present
    dlls: List[Path] = []
    for p in root.rglob("*.dll"):
        low = str(p).lower()
        if any(seg in low for seg in ("/obj/", "\\obj\\", "/bin/", "\\bin\\")):
            continue
        dlls.append(p)
    return dlls


def classify_dlls(dlls: List[Path]) -> Tuple[List[Path], List[Path]]:
    s1api: List[Path] = []
    deps: List[Path] = []
    for p in dlls:
        name = p.name
        if S1API_DLL_RE.match(name) or "s1api" in name.lower():
            s1api.append(p)
        elif name in COMMON_DEP_DLLS:
            deps.append(p)
    # Prefer shorter paths (usually the actual install path) if duplicates exist
    s1api.sort(key=lambda x: (len(str(x)), str(x)))
    deps.sort(key=lambda x: (len(str(x)), str(x)))
    # De-dupe by filename keeping the shortest path
    def dedupe_by_name(paths: List[Path]) -> List[Path]:
        best: Dict[str, Path] = {}
        for p in paths:
            k = p.name.lower()
            if k not in best:
                best[k] = p
        return list(best.values())
    return dedupe_by_name(s1api), dedupe_by_name(deps)


# -------------------------
# Decompile using ilspycmd
# -------------------------

def find_ilspycmd(user_path: Optional[str]) -> str:
    if user_path:
        p = Path(user_path)
        if p.exists():
            return str(p)
        die(f"--ilspycmd was provided but does not exist: {user_path}")

    found = which("ilspycmd")
    if found:
        return found

    # Windows sometimes installs as ilspycmd.exe
    found = which("ilspycmd.exe")
    if found:
        return found

    die(
        "Could not find 'ilspycmd' on PATH.\n\n"
        "Install it (one-time) with:\n"
        "  dotnet tool install -g ilspycmd\n\n"
        "Then ensure your dotnet tools directory is on PATH and re-run.\n"
        "You can also pass --ilspycmd /full/path/to/ilspycmd."
    )
    raise RuntimeError("unreachable")


def decompile_dll(ilspycmd: str, dll_path: Path, out_dir: Path) -> None:
    """
    ILSpy cmd options vary a bit across versions; this uses the common pattern:
      ilspycmd -p -o <out_dir> <dll_path>
    If it fails, the error message should be clear and you can adjust args.
    """
    ensure_dir(out_dir)
    cmd = [ilspycmd, "-p", "-o", str(out_dir), str(dll_path)]
    run(cmd)


# -------------------------
# Build a symbol index from decompiled .cs sources
# -------------------------

NAMESPACE_RE = re.compile(r"^\s*namespace\s+([A-Za-z_][\w\.]*)\s*$")
TYPE_RE = re.compile(r"^\s*(?:public|private|protected|internal|static|abstract|sealed|partial|\s)+\s*(class|struct|interface|enum)\s+([A-Za-z_]\w*)")
TYPE_RE_FALLBACK = re.compile(r"^\s*(class|struct|interface|enum)\s+([A-Za-z_]\w*)")


@dataclass
class SymbolInfo:
    corpus: str            # "game" or "s1api"
    kind: str              # class/struct/interface/enum
    namespace: str
    name: str
    file: str              # relative to refs_root


def index_cs_tree(cs_root: Path, refs_root: Path, corpus: str) -> List[SymbolInfo]:
    symbols: List[SymbolInfo] = []
    for cs in cs_root.rglob("*.cs"):
        try:
            lines = cs.read_text(encoding="utf-8", errors="replace").splitlines()
        except Exception:
            continue

        current_ns = ""
        for line in lines:
            stripped = line.strip()
            mns = NAMESPACE_RE.match(stripped)
            if mns:
                current_ns = mns.group(1)
                continue

            mt = TYPE_RE.match(stripped) or TYPE_RE_FALLBACK.match(stripped)
            if mt:
                kind = mt.group(1)
                name = mt.group(2)
                rel = cs.resolve().relative_to(refs_root.resolve())
                symbols.append(SymbolInfo(
                    corpus=corpus,
                    kind=kind,
                    namespace=current_ns or "__global__",
                    name=name,
                    file=str(rel).replace("\\", "/"),
                ))
    # Stable ordering
    symbols.sort(key=lambda s: (s.namespace, s.name, s.kind, s.file))
    return symbols


def write_index(path: Path, symbols: List[SymbolInfo], extra: Dict) -> None:
    data = {
        "symbol_count": len(symbols),
        "symbols": [asdict(s) for s in symbols],
        **extra
    }
    path.write_text(json.dumps(data, indent=2), encoding="utf-8")


def merge_indices(game_index_path: Optional[Path], s1api_index_path: Path, out_path: Path) -> None:
    combined_symbols: List[dict] = []
    meta: Dict = {"sources": {}}

    if game_index_path and game_index_path.exists():
        game = json.loads(game_index_path.read_text(encoding="utf-8", errors="replace"))
        # Try to normalize both possible formats (your earlier extractor vs this one)
        if "symbols" in game:
            for s in game["symbols"]:
                # Your game index may not include corpus; add it
                if "corpus" not in s:
                    s["corpus"] = "game"
                combined_symbols.append(s)
        meta["sources"]["game_index"] = str(game_index_path)

    s1api = json.loads(s1api_index_path.read_text(encoding="utf-8", errors="replace"))
    for s in s1api.get("symbols", []):
        combined_symbols.append(s)
    meta["sources"]["s1api_index"] = str(s1api_index_path)

    # Stable ordering
    combined_symbols.sort(key=lambda s: (s.get("corpus",""), s.get("namespace",""), s.get("name",""), s.get("kind",""), s.get("file","")))

    out = {
        "symbol_count": len(combined_symbols),
        "symbols": combined_symbols,
        **meta
    }
    out_path.write_text(json.dumps(out, indent=2), encoding="utf-8")


# -------------------------
# Main
# -------------------------

def main() -> None:
    ap = argparse.ArgumentParser(description="Build combined AI refs: IL2CPP game dump + S1API Thunderstore package.")
    ap.add_argument("--refs-root", required=True, help="Root output folder for refs (e.g. ./refs)")
    ap.add_argument("--game-index", required=False, help="Path to your existing game index.json (from IL2CPP dump extractor).")
    ap.add_argument("--game-corpus-dir", required=False,
                    help="Optional: path to your game corpus folder (so we can copy it into refs/game). If omitted, we only merge the index.")
    ap.add_argument("--thunderstore", required=True, help="Path to Thunderstore package (.zip) OR extracted folder.")
    ap.add_argument("--ilspycmd", required=False, help="Optional explicit path to ilspycmd executable.")
    ap.add_argument("--decompile", action="store_true", help="Actually run ilspycmd decompilation. If omitted, we only copy raw dlls/docs.")
    args = ap.parse_args()

    refs_root = Path(args.refs_root).expanduser().resolve()
    ensure_dir(refs_root)

    # Optionally copy game corpus under refs/game
    if args.game_corpus_dir:
        game_src = Path(args.game_corpus_dir).expanduser().resolve()
        game_dst = refs_root / "game"
        if game_dst.exists():
            print(f"[INFO] refs/game already exists, not overwriting: {game_dst}")
        else:
            print(f"[INFO] Copying game corpus -> {game_dst}")
            shutil.copytree(game_src, game_dst)

    game_index_path = Path(args.game_index).expanduser().resolve() if args.game_index else None

    # Load / prepare thunderstore input (zip or folder)
    ts_input = Path(args.thunderstore).expanduser().resolve()
    if not ts_input.exists():
        die(f"Thunderstore path does not exist: {ts_input}")

    with tempfile.TemporaryDirectory(prefix="s1api_ts_") as tmp:
        tmp_root = Path(tmp).resolve()
        if is_zip_path(ts_input):
            print(f"[INFO] Extracting Thunderstore zip: {ts_input}")
            extract_zip(ts_input, tmp_root)
            ts_root = tmp_root
        else:
            ts_root = ts_input

        # Find DLLs
        dlls = find_candidate_dlls(ts_root)
        s1api_dlls, dep_dlls = classify_dlls(dlls)

        if not s1api_dlls:
            die(
                "Could not find any S1API DLLs in the Thunderstore package.\n"
                "I searched recursively for *.dll and matched names like S1API.dll / S1API.*.dll.\n"
                f"Thunderstore root searched: {ts_root}"
            )

        # Prepare output structure
        s1api_root = refs_root / "s1api"
        raw_dir = s1api_root / "raw"
        dec_dir = s1api_root / "decompiled"
        ensure_dir(raw_dir)
        ensure_dir(dec_dir)

        deps_root = refs_root / "deps"
        ensure_dir(deps_root)

        # Copy raw S1API dll/xml/pdb
        def copy_sidecars(dll_path: Path, dst_dir: Path) -> None:
            ensure_dir(dst_dir)
            for ext in [".dll", ".xml", ".pdb", ".mdb"]:
                cand = dll_path.with_suffix(ext)
                if cand.exists():
                    shutil.copy2(cand, dst_dir / cand.name)

        print("[INFO] Copying raw S1API assemblies/docs...")
        for d in s1api_dlls:
            copy_sidecars(d, raw_dir)

        if dep_dlls:
            print("[INFO] Copying common dependency DLLs (if present)...")
            dep_out = deps_root / "raw"
            ensure_dir(dep_out)
            for d in dep_dlls:
                copy_sidecars(d, dep_out)

        # Decompile (optional)
        if args.decompile:
            ilspycmd = find_ilspycmd(args.ilspycmd)
            print(f"[INFO] Using ilspycmd: {ilspycmd}")

            for dll in s1api_dlls:
                out = dec_dir / dll.stem
                if out.exists() and any(out.rglob("*.cs")):
                    print(f"[INFO] Decompile output already exists, skipping: {out}")
                    continue
                print(f"[INFO] Decompiling: {dll.name}")
                try:
                    decompile_dll(ilspycmd, dll, out)
                except subprocess.CalledProcessError as e:
                    die(
                        f"ilspycmd failed while decompiling {dll}.\n"
                        "Your ilspycmd version may use different flags.\n"
                        "Try running `ilspycmd --help` and adjust the command in decompile_dll().\n"
                        f"Original error: {e}"
                    )

        # Build S1API index from decompiled sources (if any)
        s1api_symbols: List[SymbolInfo] = []
        if any(dec_dir.rglob("*.cs")):
            print("[INFO] Building S1API symbol index from decompiled .cs files...")
            s1api_symbols = index_cs_tree(dec_dir, refs_root, corpus="s1api")
        else:
            print("[WARN] No decompiled .cs files found under refs/s1api/decompiled.")
            print("       Run again with --decompile (and ensure ilspycmd is installed).")

        s1api_index_path = s1api_root / "index.json"
        write_index(
            s1api_index_path,
            s1api_symbols,
            extra={
                "thunderstore_source": str(ts_input),
                "raw_dir": str(raw_dir.relative_to(refs_root)).replace("\\", "/"),
                "decompiled_dir": str(dec_dir.relative_to(refs_root)).replace("\\", "/"),
                "s1api_dlls": [str(p) for p in s1api_dlls],
            }
        )

        # Merge indices
        combined_index_path = refs_root / "index.json"
        merge_indices(game_index_path, s1api_index_path, combined_index_path)

        print("\n[DONE]")
        print(f"  S1API raw:        {raw_dir}")
        print(f"  S1API decompiled: {dec_dir}")
        print(f"  S1API index:      {s1api_index_path}")
        print(f"  Combined index:   {combined_index_path}")
        if game_index_path:
            print(f"  Game index used:  {game_index_path}")
        else:
            print("  Game index:       (none provided; combined index contains only S1API)")


if __name__ == "__main__":
    main()
