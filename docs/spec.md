# Pixel Pulse - Game Specification
**Document Type:** Game Planning Standard Spec  
**Project:** Pixel Pulse  
**Platform:** Android (phone-first)  
**Monetization Model:** Free-to-play (cosmetics + optional song content + ads)  
**Version:** v0.1 (Foundational Spec)  
**Date:** May 22, 2026

---

## 1. Vision

Pixel Pulse is a fast, one-thumb rhythm-tap game where players synchronize taps to energetic tracks while the playfield reacts like a living equalizer.  
The fantasy is “I can feel and control the beat.” Sessions are short, replayable, and skill-forward, with fair scoring and strong audiovisual feedback.

---

## 2. Assumptions (No Existing Documentation)

- No prior design, tech, or art pipeline exists.
- Team is starting from zero with mobile-first constraints.
- Initial launch scope targets Android only.
- Music rights for launch tracks are secured or sourced from royalty-safe libraries.
- Backend can be lightweight at launch (leaderboards/events), with room to scale.

---

## 3. Game Planning Standard Q&A (Core Product Questions)

## Q1) What is the core fantasy?
**Answer:** Becoming “locked in” with music and feeling mastery through precise timing. Every successful tap should feel like performing live, not just passing obstacles.

## Q2) What is the 10-second hook?
**Answer:** Within 10 seconds, the player sees pulsing neon lanes, hears a beat drop, taps 3-5 notes, and triggers satisfying hit effects + combo text. Immediate “I get it, this feels good.”

## Q3) What are the retention loops?
**Answer:**
- **Moment loop (seconds):** Hear beat -> tap -> get timing grade -> build combo -> chase perfect streak.
- **Run loop (1-3 min):** Finish song segment -> score rank -> unlock rewards/missions -> retry for higher rank.
- **Daily loop (5-10 min):** Daily challenge song + streak reward + rotating mission set.
- **Long loop (weeks):** Account level, cosmetic unlock track, seasonal pass, leaderboard climb, limited-time events.

## Q4) What is target session length?
**Answer:** 3-8 minutes average; quick retry design supports 30-90 second “micro-sessions.”

## Q5) Skill vs luck balance?
**Answer:** ~90% skill / 10% variance. Outcomes are primarily timing accuracy and pattern reading. Variance comes from selected song patterns and minor procedural visual modifiers, never hidden RNG affecting score fairness.

## Q6) How is fairness guaranteed?
**Answer:**
- Deterministic note charts per song/difficulty.
- Visible timing windows and consistent scoring formulas.
- Device audio/input calibration tool.
- No pay-to-win stat boosts.
- Leaderboards segmented by mode/difficulty/version.
- Anti-cheat checks for impossible timing distributions.

## Q7) How does difficulty ramp?
**Answer:**
- Tutorial: single-lane quarter beats.
- Early: add off-beat notes + short holds.
- Mid: lane alternation, syncopation, denser BPM.
- Late: multi-pattern memory, deceptive rhythms, endurance density.
- Optional modifiers (Hardcore, Mirror, No-HUD) for experts.

## Q8) What is the distinctive mechanic?
**Answer:** **Pulse Shift** - lanes phase-shift visually on measure transitions while note timing stays musically true. Players must maintain rhythm confidence through controlled visual displacement, creating unique tension without fake difficulty.

## Q9) What is art scope?
**Answer:** Stylized neon-pixel aesthetic with modular UI skins, reactive backgrounds, and effect packs. Scope avoids heavy character animation; invests in high-impact shader/VFX and clear readability.

## Q10) What is the audio plan?
**Answer:** Beat-first production with strict chart-sync pipeline:
- 12-20 launch tracks across BPM/style bands.
- Manual + assisted beat mapping tooling.
- Hit sounds layered by timing grade.
- Low-latency audio path and per-device calibration.
- Ongoing content drops (weekly/biweekly).

## Q11) What is monetization?
**Answer:** Ethical F2P:
- Cosmetic themes, trails, hit effects, profile flair.
- Optional song packs / season pass.
- Rewarded ads for revive/reward multipliers (non-competitive modes only).
- Interstitials limited and never during core flow.
- No gameplay advantage purchases.

## Q12) What are key technical constraints?
**Answer:**
- Stable 60 FPS on mid-tier Android (4GB RAM class).
- End-to-end input/audio latency compensation.
- APK/AAB size budget with streamed/pack-delivered audio.
- Offline play for owned songs; online required for leaderboards/events.
- Telemetry-first architecture for tuning charts and retention.

---

## 4. Target Audience

- Rhythm game fans wanting mobile-friendly precision play.
- Casual players who enjoy short music sessions.
- Competitive players motivated by rank, score optimization, and consistency.

**Age rating target:** Everyone 10+ / equivalent regional standards.

---

## 5. Core Design Pillars

1. **Feel the Beat:** Audio-visual sync must feel excellent on first interaction.
2. **Fair Skill Expression:** Better timing always means better outcomes.
3. **Fast Restart, Fast Flow:** Retries are instant; friction is minimized.
4. **Readable Intensity:** Spectacle never compromises note clarity.

---

## 6. Core Gameplay

## 6.1 Controls
- Primary input: tap (one-thumb viable).
- Secondary inputs (higher difficulties): hold notes, directional flick notes.
- Optional left/right handed UI offset mode.

## 6.2 Timing Windows (initial tuning)
- Perfect: +/-30 ms  
- Great: +/-60 ms  
- Good: +/-90 ms  
- Miss: >90 ms  
(Per-song adjustments prohibited for fairness; only global tuning patches.)

## 6.3 Scoring Model
- Base score per note x accuracy multiplier.
- Combo multiplier scales progressively, capped to prevent runaway.
- Miss resets combo but not run completion in standard mode.
- Grade bands: C / B / A / S / SS / SSS.

## 6.4 Game Modes (Launch)
- **Arcade:** Standard song play, ranked.
- **Daily Pulse:** Rotating daily chart with fixed conditions.
- **Zen Practice:** No fail state, section looping, slowed playback.
- **Event Mode (limited):** Modifier-based seasonal challenges.

---

## 7. Progression & Retention Systems

## 7.1 Meta Progression
- Player level from XP earned per run.
- Unlock cosmetics and currency milestones.
- Song mastery stars per difficulty.

## 7.2 Mission System
- Daily: 3 rotating tasks (e.g., “Hit 200 Perfects”).
- Weekly: 5 longer tasks tied to mode variety.
- Seasonal: milestone chain with premium/standard tracks.

## 7.3 Streaks
- Daily play streak rewards light but meaningful.
- Missed day protection token (earnable) reduces frustration.

## 7.4 Social/Competition
- Friend leaderboard + global leaderboard.
- Ghost replay lines (timing traces) for self-improvement.
- Weekly percentile badge rewards.

---

## 8. Difficulty & Content Structure

## 8.1 Song Difficulty Tiers
- Easy (1-3), Normal (4-6), Hard (7-9), Expert (10-12), Master (13+)
- Every launch song must ship with at least 3 difficulties.

## 8.2 Ramp Strategy
- First 15 minutes: guaranteed success path to A-rank on Easy.
- First hour: introduce hold and flick gradually.
- Day 1-3: mission prompts nudge player to Normal/Hard attempts.

## 8.3 Failure Design
- No abrupt early punishment in early tiers.
- Clear post-run feedback: heatmap of misses + timing bias (“early”/“late”).

---

## 9. UX/UI Requirements

- First-time flow under 45 seconds to first playable chart.
- One-tap retry from results screen.
- Minimal HUD mode for advanced players.
- Colorblind-safe note palettes.
- Haptic feedback toggles with battery-aware defaults.

---

## 10. Art Direction & Asset Scope

## 10.1 Style
- Neon pixel-futurist visuals with clean geometric silhouettes.
- High contrast lanes, reactive backgrounds, CRT-inspired accents.

## 10.2 Launch Asset Scope (MVP+)
- 4 lane themes
- 6 note/hit effect sets
- 20 profile badges
- 12 background variants (reactive shader-driven)
- UI pack for shop, missions, progression, results

## 10.3 Production Constraints
- Reusable VFX modules over bespoke per-song art.
- Performance budgeted shaders only; fallback for low-end devices.

---

## 11. Audio Plan

## 11.1 Music Content
- Launch catalog: 12-20 tracks, 90-180 BPM spread.
- Genre spread: EDM, synthwave, chiptune, pop-electro hybrids.
- Track length target: 90-150 seconds (mobile session fit).

## 11.2 Charting Pipeline
- BPM grid + beat marker ingestion.
- Designer pass for musicality and hand-feel.
- Automated validation for impossible transitions.
- QA sync pass across representative devices.

## 11.3 Runtime Audio
- Latency calibration wizard at first launch (skippable, re-openable).
- Dynamic ducking of SFX under dense moments.
- Per-hit layered feedback by timing grade.

---

## 12. Monetization Design

## 12.1 Revenue Streams
- Cosmetic shop (themes, trails, flairs).
- Season pass (cosmetics + song unlock path).
- Optional song packs.
- Rewarded ads for bonus currency/retry in non-ranked contexts.

## 12.2 Rules
- No purchasable score multipliers in ranked play.
- No paywall blocking core progression.
- Starter content must sustain first 7 days without purchase.

## 12.3 Economy (initial)
- Soft currency earned through play/missions.
- Premium currency for direct cosmetic purchase.
- Transparent pricing and duplicate protection for bundles.

---

## 13. Technical Specification (Android)

## 13.1 Platform Targets
- Android 10+ baseline.
- 60 FPS target, 120 FPS optional on capable devices.
- RAM target: stable on 4 GB devices.

## 13.2 Engine & Architecture
- Unity or Godot (final decision based on audio latency tests).
- Deterministic timing layer separate from render frame.
- Data-driven charts (JSON/binary) for hotfix-friendly tuning.

## 13.3 Performance Budgets
- Frame time: <=16.6 ms at 60 FPS.
- Input processing budget: <=2 ms/frame.
- Audio decode/stream without frame hitching.

## 13.4 Networking
- Offline core play supported.
- Online required for:
  - Leaderboards
  - Event sync
  - Cloud save and anti-cheat verification

## 13.5 Security / Integrity
- Signed score submissions with server-side validation.
- Basic tamper detection and abnormal timing pattern flags.
- Versioned chart hashes to prevent spoofing.

---

## 14. Telemetry & KPIs

## 14.1 Core Metrics
- D1/D7/D30 retention
- Session length + sessions/day
- First-song completion rate
- Retry rate within 60 seconds of result screen
- Accuracy distribution and fail points by song/difficulty
- Conversion rates: cosmetic, pass, pack, rewarded ad opt-in

## 14.2 Funnel Events
- Install -> tutorial start -> first tap -> first clear -> first retry -> first mission claim -> day-2 return.

---

## 15. Live Ops Plan

- Weekly: new missions + featured song rotation.
- Biweekly or monthly: content drop (song/cosmetics/event modifier).
- Seasonal (8-10 weeks): themed pass + leaderboard reset + event mode twist.
- Community beats: score challenges and creator spotlight charts (post-launch phase).

---

## 16. QA Strategy

- Device matrix across low/mid/high Android tiers.
- Latency regression suite after every audio/input change.
- Chart validation: readability, hand strain, impossible patterns.
- Monetization fairness checks before each release.
- Soak test for long sessions and thermal throttling behavior.

---

## 17. Risks & Mitigations

- **Risk:** Per-device latency inconsistency.  
  **Mitigation:** Calibration wizard + known-device presets + telemetry correction recommendations.

- **Risk:** Content burnout from small catalog.  
  **Mitigation:** Short tracks, difficulty variants, daily modifiers, rapid live-ops cadence.

- **Risk:** Visual noise hurts readability.  
  **Mitigation:** Strict note contrast rules, effect intensity slider, competitive minimal mode.

- **Risk:** Perceived monetization pressure.  
  **Mitigation:** Cosmetics-first economy, transparent rewards, non-intrusive ads.

---

## 18. MVP Scope (First Playable)

- 6 songs, 3 difficulties each
- Arcade + Daily Pulse modes
- Core scoring/combo/grades
- Calibration tool
- Basic progression + daily missions
- One leaderboard
- Cosmetic shop skeleton
- Full analytics instrumentation

---

## 19. Post-MVP Expansion

- Additional gesture types and advanced modifiers
- Full season pass framework
- Friend systems and challenge links
- Creator/community chart ecosystem (curated)
- Tablet-optimized layout

---

## 20. Acceptance Criteria (Launch Readiness)

- 95%+ first-song completion in onboarding cohort.
- Median frame rate >=58 FPS on target mid-tier devices.
- Timing calibration completion >=60% among first-time users.
- Crash-free sessions >=99.5%.
- No pay-to-win vectors in ranked modes.
- D1 retention target met by soft-launch benchmark.

---

## 21. Appendix: Initial Build Checklist

1. Input/timing prototype with synthetic metronome track  
2. Chart format + loader implementation  
3. Tutorial and first 3-minute user journey  
4. Result screen with timing breakdown  
5. Daily mission backend stub + local fallback  
6. Telemetry event schema lock  
7. Storefront scaffolding for cosmetics and song packs  
8. Device latency test harness and QA protocol
