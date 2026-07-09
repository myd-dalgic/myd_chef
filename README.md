# Equator Studios - VR Cooking Chaos (GitHub Starter Pack)

This repository is a **GitHub-ready starter package** for a Meta Quest 3 VR cooking / restaurant simulation project built with **Unity** and **XR Interaction Toolkit**.

It includes:

- Comprehensive GDD
- Technical roadmap
- MVP build order
- Unity C# architecture suggestions
- Starter script skeletons
- Unity `.gitignore`

> Note: This is **not a full playable Unity project yet**. It is a **production-ready planning + architecture starter repo** that you can import into your own Unity project and expand.

---

## Project Summary

- **Studio:** Equator Studios
- **Genre:** VR Cooking / Restaurant Simulation
- **Platform:** Meta Quest 3
- **Engine:** Unity
- **Toolkit:** XR Interaction Toolkit
- **Mode:** Single-player only
- **Vibe:** Comical, chaotic, physics-heavy, cartoonish
- **Avatar:** Floating VR gloves / hands

---

## Core Design Rules

1. No timers
2. No levels
3. Endless mode
4. One customer at a time
5. Physics-driven interaction
6. Dropped food becomes invalid
7. Fires must be extinguished physically
8. Broken machines must be repaired by hitting them with a tool

---

## Suggested Unity Folder Usage

Copy the `Assets/Scripts` contents into your Unity project.

Recommended Unity package setup:

- XR Interaction Toolkit
- Input System
- URP (optional, recommended for Quest workflow)
- TextMeshPro

---

## Documents

- [`docs/GDD.md`](docs/GDD.md)
- [`docs/MVP_Roadmap.md`](docs/MVP_Roadmap.md)

---

## Suggested Next Steps

1. Create a new Unity Quest 3 project
2. Import XR Interaction Toolkit
3. Add these scripts into `Assets/Scripts`
4. Build the drink dispenser vertical slice first
5. Then add grill, fryer, fire, and repair systems

---

## License

Internal studio use unless you choose another license.
