# Agent Instructions — Graphics Showcase (Unreal)

An Unreal Engine sample for Meta Quest demonstrating a Vulkan subpass-based tonemapping technique that outperforms traditional post-process tonemapping. Also ships as an APK on the Horizon Store.

## Source-of-truth files (read these first, do not duplicate their contents in this file)

For setup, build steps, engine version, and project layout, read:

- `README.md` — official setup, in-app controls, and recent update history
- `GraphicsShowcase.uproject` — Unreal engine association, enabled plugins, target platforms
- `Config/` — UE config files (`DefaultEngine.ini`, etc.)
- `Source/GraphicsShowcase/` — C++ module
- `.gitattributes` — Git LFS configuration
- `LICENSE` — license terms

## Quest / Horizon-specific notes

- Requires the Meta fork of Unreal Engine (`Oculus-VR/UnrealEngine`, `oculus-5.6` branch per README). The prebuilt Epic Games Launcher engine will NOT work — do not recommend that path.
- Recently migrated (22 Dec 2025) to the OpenXR backend. Do not reintroduce code paths that assume the legacy Oculus plugin XR pipeline.
- 04 Dec 2025 update bumped the project to UE 5.6; older UE versions are no longer supported.
- `TargetPlatforms` in the `.uproject` is `Android` only — packaging for Win64 is not configured here even though the `OculusXR` plugin lists Win64 as a supported platform.
- Direct ZIP download is explicitly unsupported (LFS-managed assets won't fetch).

## Meta Quest tooling

This repository is part of the Meta Quest / Horizon OS ecosystem (a sample, library, template, or related project — the bespoke intro above describes which). Use that intro and the source-of-truth files it references for project-specific decisions; don't restate or invent facts from memory.

When the user asks anything about Quest device behavior, build / deploy / debug / capture flows, on-device performance, or Horizon OS APIs, reach for these tools instead of generic Unreal answers:

- **`hzdb`** — Quest-aware ADB wrapper (device list, install / launch / stop, logs, screenshots, Perfetto traces, on-device docs search). Already wired up as an MCP server via `.mcp.json`, `.vscode/mcp.json`, and `.cursor/mcp.json`. Also runnable directly: `npx -y @meta-quest/hzdb <subcommand>`.
- **Meta Quest Agentic Tools** — the full skill set, including Unreal-specific skills: [github.com/meta-quest/agentic-tools](https://github.com/meta-quest/agentic-tools). Install per your client (Claude Code: `/plugin install meta-vr@meta-quest`; Gemini CLI: `gemini extensions install https://github.com/meta-quest/agentic-tools`; Cursor / VS Code: install the **Meta Horizon** extension from the Marketplace).

A few behavior expectations:

- **Read this repo's files first.** Before answering anything project-specific, read `README.md` and whichever source-of-truth files the intro above points at. Don't restate their contents in chat — quote or link instead.
- **Use `hzdb` for device-side work.** Anything that touches an attached Quest (install, launch, logs, screenshot, capture, manifest inspection) goes through `hzdb`, not raw `adb`.
- **Check live Horizon OS docs before answering API questions.** `hzdb docs search "..."` queries the live docs; training data on Horizon OS APIs goes stale fast.
- **Don't fabricate SDK / engine versions.** If a version isn't visible in this repo's files, say so rather than guessing.
