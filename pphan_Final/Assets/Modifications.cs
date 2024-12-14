/*
MODIFICATIONS FOR THE FINAL:
1. Directional Light (pink colour, 0.8 intensity, 88 size)
2. Fog (white colour, 0.018 density)
3. Skybox (Procedural, Gloomy Sky Material: High Quality Sun, 0.08 Sun Size, 8 Sun Size Convergence, 1.8 Atmosphere Thickness, 
Dark Gray Sky Tint, Black Ground, 1.8 Exposure)
4. Obstacle prefab (Set Empty as Parent with Capsule Head, Cylinder Tail, Cube Fins, and their corresponding materials)
5. AtomicMissleHead, AtomicMissleTail, AtomicMissleFins and AtomicMissleFins (1) are children of the Empty Object called 
Obstacle that is "Set as Default Parent" in the Hierarchy.
6. Created 3 Materials for the AtomicMissleHead, AtomicMissleTail, AtomicMissleFins objects of Obstacle prefab with 3 set of Textures.
7. Added a particle system for the Obstacle with Duration, Start Lifetime and Start Speed of 8; Start Color is Dark Red. Max Particles are 888.
Emission's Rate over Time is 88; Rate over Distance is 8. Shape is Sphere. Color over Lifetime is Gold. 
8. Powerup's light colour is light yellow, intensity is 3, and range is 16; Shadow Type is Soft Shadow.
9. Left wall was used to create a Wall prefab, and a prefab variant was made and replaced the right wall.
10. Left wall's tint colour is navy blue, and right wall's tint colour is purple.
 */