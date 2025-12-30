# Midnight Survival Shooter

DEMO: [https://youtu.be/1dQSaE7-rxs](https://youtu.be/jWRlB6ChbkQ)

Midnight Survival is a simple 3D top-down survival game where the player must stay alive against waves of glowing toy-like enemies inside a stylized bedroom environment. The game focuses on quick action, movement, and basic shooting mechanics.

## Highlights
- Wave-based progression driven by `GameStateManager` with configurable round data and timed transitions.
- Universal Render Pipeline (URP) lighting profile with flashlight + facelight setup for readability on low-end hardware.
- Modern Unity Input System with `PlayerInput.inputactions` ready to rebind in the inspector.
- Cinemachine target group camera rig, addressable-ready content, profiler/graph overlays, and utility packages (Graphy, Smart Hierarchy, UniTask).
- Scene flow split into Menu and Game scenes to mirror a production-ready boot path.

## Requirements
- Unity **2022.3.47f1** (LTS). Open the folder with Unity Hub; Hub will offer to install the exact version if missing.
- Render pipeline: URP 14 (installed via `com.unity.render-pipelines.universal` in `Packages/manifest.json`).
- Tested platforms: Editor and standalone desktop builds.

## Getting Started
1. Clone or download this repository.
2. In Unity Hub, add the project folder and open it with **2022.3.47f1**.
3. Open `Assets/SurvivalShooter/Scenes/Menu/Menu.unity` (or `Scenes/Game/Game.unity` to jump straight into gameplay) and press Play.
4. Input is configured through the Unity Input System action asset at `Assets/SurvivalShooter/Settings/Input/PlayerInput.inputactions`; adjust bindings there if needed.

## Building
1. Open **File → Build Settings…**.
2. Add the Menu and Game scenes from `Assets/SurvivalShooter/Scenes/` to the Scenes In Build list (Menu first, Game second).
3. Choose your target platform and click **Build** (or **Build And Run**). URP assets and quality settings are stored under `Assets/SurvivalShooter/Profiles/`.

## Project Layout
- `Assets/SurvivalShooter/Scenes/` – Menu, Intro, and Game scenes.
- `Assets/SurvivalShooter/Scripts/Managers/GameStateManager.cs` – Orchestrates match flow, enemy waves, and restart timing.
- `Assets/SurvivalShooter/Settings/Input/PlayerInput.inputactions` – Input System bindings and action maps.
- `Assets/SurvivalShooter/Prefabs/` – Player, enemies, spawners, and HUD prefabs.
- `Packages/manifest.json` – Package dependencies (Cinemachine, URP, Input System, Addressables, Graphy, UniTask, Smart Hierarchy).

## Development Notes
- Enemy waves: adjust round configs on the `GameStateManager` in the Game scene; each `EnemyRoundConfig` defines spawner settings and quotas.
- Cameras: a Cinemachine Target Group tracks spawned player avatars for smooth framing; tune weights/radii in the inspector.
- Profiling: Graphy HUD is included for frame and memory stats; enable/disable it in scene or via scripting as needed.
- Tests: Unity Test Framework is enabled (`com.unity.test-framework`). Add Play Mode or Edit Mode tests under `Assets/Tests` if you create coverage.

## License and Credits
- Project code and assets here are licensed under the MIT License.
