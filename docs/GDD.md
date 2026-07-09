# Game Design Document - Equator Studios VR Cooking Chaos

## 1. Vision
A stress-free VR restaurant simulation where the challenge comes from physical chaos, recoverable mistakes, and comedic hazards instead of time pressure.

## 2. Pillars
- Stress-free play
- Physics-first comedy
- Readable chaos
- Tactile VR interactions
- Low NPC complexity, high object complexity

## 3. Platform
- Meta Quest 3
- Unity
- XR Interaction Toolkit

## 4. Player Avatar
- Floating VR gloves/hands only
- No full body avatar

## 5. Core Loop
1. Customer appears at window
2. Customer displays order via thought bubble
3. Player prepares food/drink
4. Chaos may occur: fire, machine failure, ruined food
5. Player places order on serving tray
6. Player rings bell
7. Order validates
8. Customer leaves if correct
9. Next customer appears

## 6. Hard Rules
- No timers
- No levels
- Endless mode only
- Customers arrive one at a time
- Customer waits forever
- Food dropped on floor is ruined
- Fires must be extinguished physically
- Broken machines are fixed by hitting them with a repair tool

## 7. Menu Scope
### MVP Menu
- French fries
- Soda
- Burger
- Hotdog

## 8. Stations
### Fryer Station
- Accepts fries
- Cooks over time
- Can burn and catch fire
- Can break down randomly

### Drink Dispenser
- Fill cup by pulling lever
- Can break down randomly
- Needs physical repair when broken

### Grill Station
- Cooks burger patties and hotdogs
- Can overcook and cause fire

## 9. Hazards
### Overcooking / Fire
- Food transitions from raw -> cooked -> burnt -> on fire
- Fire disables normal station use until extinguished

### Machine Breakdown
- Drink dispenser and fryer can break
- Sparks VFX and failure audio indicate broken state
- Repair requires heavy tool hits above a force threshold

## 10. Customer Design
### Customer Flow
- Spawn at service window
- Show order bubble
- Wait patiently
- Leave only after correct order is served and bell is rung

### No advanced AI required
- No pathfinding needed in MVP
- Customers can use fixed arrival and departure animations or simple spawn/despawn flow

## 11. Food State Model
Recommended states:
- Raw
- Cooking
- Cooked
- Burnt
- OnFire
- Ruined
- Served

## 12. Machine State Model
Recommended states:
- Working
- Broken
- Repairing

## 13. Order Validation Rule
Validation happens only when the bell is rung. This keeps the game readable and supports playful tray clutter before submission.

## 14. Interaction Verbs
- Grab
- Release
- Throw
- Push
- Pull
- Spray
- Hit
- Ring
- Place
- Flip

## 15. Art Direction
- Cartoonish
- Bright color language
- Highly readable machine status
- Exaggerated props and hand silhouettes

## 16. Audio Direction
- Comedic, chunky impacts
- Strong station feedback sounds
- Clear fire/break warning audio
- Customer reaction stingers

## 17. Success Criteria for MVP
- Playable endless loop
- One customer at a time
- 4 menu items
- Bell-based order validation
- At least one fire event
- At least one repair event
- Runs on Quest 3 with stable VR interaction

## 18. Asset Checklist Summary
### Environment
- Counter
- Customer window
- Shelves
- Floor
- Tool rack
- Signage

### Machines
- Fryer
- Fryer basket
- Grill
- Drink dispenser
- Bell
- Serving tray

### Food
- Fries states
- Burger patty states
- Burger assembled
- Hotdog states
- Hotdog assembled
- Empty cup
- Filled cup
- Buns

### Tools
- Fire extinguisher
- Hammer
- Crowbar
- Spatula/tongs

### VFX
- Fire
- Sparks
- Spray foam
- Steam
- Smoke

### UI
- Thought bubble
- Food icons
- Warning indicators

## 19. Technical Recommendations
- Use ScriptableObjects for food, orders, recipes, and stations
- Use event-driven communication between systems
- Keep physical interaction separate from game rules
- Build one vertical slice first: soda dispenser loop

## 20. Future Expansion Ideas
- More recipes
- Cosmetic kitchen themes
- More machine types
- Achievement system
- Endless score progression
