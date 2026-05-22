# Pixel Pulse Technical Plan

## 1. Architecture Overview
- **Engine**: Unity 2022.3 LTS for rapid audio‑visual sync and cross‑platform tooling.
- **Subsystems**:
  - **Audio Manager** – low‑latency playback, beat‑synchronization, calibration.
  - **Timing Manager** – deterministic clock, tolerance windows, frame‑delta compensation.
  - **Chart Loader** – JSON parser → Note objects, lane mapping.
  - **Input System** – tap input, hold detection, optional flick input.
  - **UI Layer** – lane overlay, combo HUD, result screen, calibration UI.
  - **Data Layer** – local persistence (PlayerPrefs + JSON), remote SDK stubs for leaderboard, missions.
  - **Analytics** – Telemetry SDK, event logging for retention metrics.
- **Build Pipeline**: Unity -> Gradle -> Android AAB/APK.

## 2. Engine Choice Justification
- Unity offers built‑in audio graph with minimal latency, essential for rhythm games.
- Rich asset pipeline simplifies pixel art and shader creation.
- Long‑term support via LTS release, large community, and CI tooling.

## 3. Data Flow (Textual Diagram)
1. **Launch** → Fetch latest launch config JSON.
2. **Chart Load** → Read chart file → Instantiate Note objects along lane prefabs.
3. **Audio Sync** → Play music clip → Hook beat timestamps to Timing Manager.
4. **Game Loop** → Monitor input → Timing Manager compares to beat → Update Score.
5. **UI Update** → Pass metrics to HUD (combo, grade, streak).
6. **Result** → Persist run data → Upload telemetry.

## 4. Build Pipeline
- **Local Development**: Unity Editor → `File → Build Settings → Android`.
- **CI**: GitHub Actions – Unity Build Automation action, run unit tests, generate artifacts.
- **Artifacts**: Debug APK, Minified AAB, Build logs.

## 5. CI & Testing Strategy
- **Unit Tests**: TimingManager, ScoreCalculator, ChartParser.
- **Integration Test**: Headless Unity Play Mode test runs a short chart, asserts no crashes.
- **Gradle Unit Tests**: JVM tests for data models.
- **Performance Test**: Profiling script limits frame time ≤16.6 ms on target device family.
- **Artifacts**: Publish test reports, coverage to GitHub.

## 6. Version Control Layout
```
Pixel‑Pulse
├── docs/            # Design docs
├── assets/          # Art & audio
├── Scenes/          # Unity scenes
├── Scripts/         # C# source
├── ProjectSettings/ # Unity config
├── Tests/           # Unit & integration tests
├── README.md
├── CONTRIBUTING.md
├── .github/         # GitHub actions folders
└── ...
```

## 7. Risk Mitigation
- **Audio‑Timing Drift**: Fixed frame‑rate timing loop, per‑frame latency compensation.
- **Device Fragmentation**: Target API 21+, continuous performance testing on 4‑GB device.
- **Build Size**: Use Gradle AAB split, strip unused resources, enable ProGuard.
- **CI Build Time**: Cache Unity assets, use pre‑downloaded license key.

## 8. Future Extensions
- Additional input modes (swipe, hold, flick).
- Adaptive difficulty via telemetry.
- Leaderboard & cloud sync.
- Expand track library via backend.
