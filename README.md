
---

## Contents Overview

### `refs/game/`
- Generated from **Il2CppDumper** output (`ScriptDump.cs`)
- One file per top-level type
- Namespace-mirrored folder structure

These files are **signatures only**:
- Method bodies are mostly empty
- Types, fields, and relationships are accurate

Use this when:
- Writing Harmony patches
- Calling native game APIs
- Verifying what S1API wraps internally

---

### `refs/s1api/`
- Decompiled from **Thunderstore S1API releases**
- Represents the public modding layer most mods interact with

#### `raw/`
- Exact assemblies as distributed
- Useful for version tracking and re-decompilation

#### `decompiled/`
- Decompiled C# sources (via `ilspycmd`)
- Organized per-assembly
- Intended for reading real logic and abstractions

---

### `refs/deps/`
- Common supporting libraries (e.g. Harmony)
- Included for reference only

---

## Unified Symbol Index

### `refs/index.json`

This file merges:
- Game symbols (IL2CPP dump)
- S1API symbols (decompiled)

Each entry includes:
- Corpus (`game` or `s1api`)
- Namespace
- Type name
- Kind (class / struct / enum / interface)
- File path

This enables:
- Fast symbol lookup
- AI grounding against real APIs
- Future tooling or IDE integration

---

## Intended Workflow

1. Regenerate refs when:
   - The game updates
   - S1API updates
2. Point your AI coding agent at this repository (read-only)
3. Develop mods using:
   - S1API where possible
   - Native game APIs when needed
4. Validate against real symbols, not guesses

---

## Versioning Notes

This repository is tied to:
- A specific **Schedule 1 game build**
- A specific **S1API release**

Version mismatches may result in missing members or runtime errors.

(Exact version mappings to be documented.)

---

## What This Repo Is Not

- ❌ A mod template
- ❌ A tutorial
- ❌ A runtime dependency
- ❌ A guarantee of API stability

It is intentionally **low-level and descriptive**.

---

## Future Documentation

- Game ↔ S1API version mapping  
- Loader details (MelonLoader specifics)  
- Known IL2CPP limitations  
- Recommended AI agent usage patterns  
- Automated rebuild instructions  

---

## Legal / Disclaimer

- Decompiled output is for personal research and modding
- No ownership of original game code is claimed
- Follow Schedule 1’s EULA and modding policies

---

## Maintenance Notes

All generated content should be treated as **disposable**.

If something looks wrong:
- Re-dump
- Re-decompile
- Re-index

Do not manually edit generated files.
