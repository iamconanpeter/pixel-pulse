# Pixel Pulse MVP Task List

## 1. Project Setup (Priority: High, Effort: 2h)
- Initialize Git repository under `projects/pixel-pulse`.
- Add standard `.gitignore` for Android/Unity projects.
- Create base Unity project (or Godot) named `PixelPulse`.
- Configure project settings: package name `com.conan.pixelpulse`, min SDK 21, target SDK 34.
- Set up CI workflow (GitHub Actions) for lint, unit tests, and build.

## 2. Core Engine & Architecture (Priority: High, Effort: 8h)
- Choose Unity (v2022.3 LTS) for rapid UI and audio pipeline.
- Implement deterministic timing manager (C#) handling beat sync and input latency compensation.
- Build chart loader that parses JSON chart files into in‑game note objects.
- Create audio subsystem wrapper to play music tracks with low latency and expose calibration API.
- Develop UI overlay for lane rendering, note prompts, scoring HUD.

## 3. Gameplay MVP Features (Priority: High, Effort: 20h)
- **Arcade Mode**
  - Implement song selection screen with 6 launch tracks.
  - Load charts, start music, spawn notes along 4 lanes.
  - Capture tap input, evaluate timing windows (Perfect/Great/Good/Miss).
  - Apply combo multiplier and scoring algorithm.
  - Show result screen with grade, combo, and basic stats.
- **Daily Pulse Mode**
  - Create daily challenge selector (placeholder data).
  - Store daily seed locally; ensure deterministic chart.
- **Calibration Tool**
  - Simple latency calibration UI (play click, user taps, compute offset).

## 4. Art & Audio Assets (Priority: Medium, Effort: 12h)
- Design neon‑pixel lane theme (4 variants) and basic note sprite.
- Create hit effect particle prefab (Perfect/Great).
- Source or compose 6 royalty‑free music tracks (90‑150 s, varied BPM).
- Implement audio import pipeline and chart‑to‑audio sync verification.

## 5. Persistence & Backend Stubs (Priority: Medium, Effort: 6h)
- Local save system for player XP, cosmetic unlocks, daily mission state.
- Stubbed leaderboard API (local high‑score list) with future remote sync hook.
- Simple mission system JSON loader (daily tasks, completion flags).

## 6. Testing & QA (Priority: High, Effort: 8h)
- Write unit tests for timing manager, scoring calculator, chart parser.
- Configure Gradle/Unity test runner to execute on CI.
- Add integration test script that runs a short chart and asserts no crashes.
- Manual QA checklist: latency calibration works, UI responsive, 60 FPS on mid‑tier device.

## 7. Build & Release Pipeline (Priority: High, Effort: 4h)
- Define `./gradlew assembleDebug` task (Unity Export → Android Gradle).
- GitHub Actions steps:
  1. Checkout
  2. Setup Unity
  3. Run unit tests
  4. Build debug APK
  5. Upload artifact
- Verify build size < 150 MB.

## 8. Documentation (Priority: Low, Effort: 2h)
- Update `README.md` with project overview, build instructions, and contribution guide.
- Populate `docs/spec.md` and `docs/technical-plan.md` with final content (already generated).
- Add `CONTRIBUTING.md` outlining coding standards.

## 9. Repository Preparation & Push (Priority: High, Effort: 1h)
- Commit all files with clear messages per task.
- Tag initial MVP commit `v0.1‑mvp`.
- Push to GitHub under `iamconanpeter/pixel-pulse`.

## 10. Post‑Push Validation (Priority: High, Effort: 1h)
- Clone repo on a fresh machine, run `./gradlew test assembleDebug`.
- Ensure CI reports all checks passed.
- Verify APK installs and runs on a test Android device.

**Total Estimated Effort:** ~64 hours (~8 working days).
