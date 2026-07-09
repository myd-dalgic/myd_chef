# Unity XR Setup Notes

## Recommended Packages
- XR Interaction Toolkit
- Input System
- TextMeshPro
- URP (optional but recommended)

## Player Rig Best Practices
- Use action-based XR rig
- Use floating glove meshes instead of full body
- Prefer direct hand interaction for gameplay
- Avoid relying on ray interaction for core cooking mechanics

## Tool Feel Best Practices
### Hammer / Crowbar
- Add custom attach transform
- Tune rigidbody mass for impact feel
- Use velocity threshold for valid repair hits
- Add short haptics on strong impact

### Fire Extinguisher
- Trigger starts continuous spray
- Use particle/raycast cone for extinguish detection
- Add looping spray audio and continuous haptics

## Quest 3 Optimization Notes
- Keep collider shapes simple
- Pool VFX and spawned props
- Avoid too many active rigidbodies at once
- Bake lighting where possible
- Minimize transparent overdraw
