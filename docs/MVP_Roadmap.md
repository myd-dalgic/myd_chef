# MVP Roadmap - Exact Build Order

## Phase 1 - XR Sandbox Foundation
1. Create Unity project for Quest 3
2. Install XR Interaction Toolkit
3. Configure action-based input
4. Create floating glove hand prefabs
5. Set up direct hand grabbing
6. Add sample rigidbody props
7. Tune grab, release, throw feel

**Exit:** Hands and object interaction feel good.

## Phase 2 - First Vertical Slice: Drink Dispenser
1. Create simple service counter scene
2. Add customer spawn point
3. Add order thought bubble UI
4. Create cup prefab
5. Create dispenser prefab
6. Implement lever interaction
7. Detect cup position under nozzle
8. Fill cup over time
9. Add serving tray
10. Add bell interaction
11. Validate filled cup on tray when bell rings
12. Spawn next customer after success

**Exit:** Endless soda-only loop works.

## Phase 3 - Grill Station
1. Add burger patty and hotdog prefabs
2. Add grill placement zones
3. Implement cooking progress
4. Implement raw/cooked/burnt visuals
5. Add burger/hotdog assembly rules
6. Extend order validation

**Exit:** Burger and hotdog orders work.

## Phase 4 - Fryer Station
1. Add fries ingredient prefab
2. Add fryer basket interaction
3. Implement lower/raise basket logic
4. Implement fries cooking progression
5. Add cooked fries transfer logic
6. Add burnt fries logic
7. Extend order validation

**Exit:** All menu items playable.

## Phase 5 - Ruined Food Rule
1. Create floor collision layer
2. Detect food-floor contact
3. Mark dropped food as ruined
4. Add ruined visual feedback
5. Reject ruined food during validation

**Exit:** Dropping food matters.

## Phase 6 - Fire Hazard
1. Add overcook-to-fire thresholds
2. Spawn local fire VFX
3. Disable station use while on fire
4. Add extinguisher tool
5. Add spray detection and extinguish progress
6. Add feedback audio/haptics

**Exit:** Player can recover from fire.

## Phase 7 - Machine Breakdown System
1. Add random breakdown trigger
2. Break dispenser first
3. Add sparks and failure state
4. Add hammer/crowbar tool
5. Implement impact-based repair logic
6. Apply same pattern to fryer

**Exit:** Physical repair loop works.

## Phase 8 - Endless Chaos Tuning
1. Track completed orders
2. Increase order complexity slowly
3. Increase breakdown chance gradually
4. Increase hazard frequency carefully
5. Tune for comedy, not frustration

**Exit:** Endless loop scales gently.

## Phase 9 - Polish
1. Add haptics pass
2. Add sound layering
3. Improve readability of warnings
4. Optimize rigidbodies and VFX
5. Performance test on Quest 3

**Exit:** Stable MVP demo ready.

---

# Scope Guardrails
Do NOT add these to MVP:
- multiple simultaneous customers
- co-op
- complex customer AI
- large restaurant walking space
- recipe customization
- economy systems
- upgrades
- hand-tracking-only controls
- narrative campaign
