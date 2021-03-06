# Deferred Engine For Monogame

by https://twitter.com/kosmonautgames

Feedback -> http://community.monogame.net/t/deferred-engine-playground-download/8180

![Alt text](http://i.imgur.com/vcGEtr0.png "emissive materials")


Features:
- G-buffer creation with support for physically based materials ( albedo, normal, roughness, metallic, mask)
- Cook-Torrance specular shading and Oren-Nayar diffuse shading for point lights
- light and mesh frustum culling
- deferred point lights and environment mapping
- dynamically updating point light shadows depending on scene changes
- screen space ambient occlusion
- EXPERIMENTAL: screen space emissive materials
- EXPERIMENTAL: screen space reflections

Controls:
- " ^ " / the key above TAB : debug console with suggestions (tab to autocomplete)
- Space: Go into editor mode 
  - R / T: Change transformation gizmos between translation and rotation
  - Del : Delete object
  - Insert : Copy object
- WASD : move the camera
- right mouse drag : rotate the camera
- L : Spawn new point light
- C : Update environment cubemap for current camera position
- F1 : Cycle through render targets (albedo, normals, depth etc.)


How to manipulate the scene
- See the Main / MainLogic.cs for details. Manipulate and add scene objects in Initialize() and Update();

Notes:

This solution provides a basic 3d deferred rendering engine implemented in Monogame. You will need to have Monogame (3.6.0187 or newer) installed and Visual Studio 2013+ to compile.

This is not intended to be an engine used for custom programs / games, but rather a playground which makes it easy to understand and implement custom shaders.

The sample scene contains the Sponza Atrium (from Crytek), the Stanford Dragon (http://www.cc.gatech.edu/projects/large_models/) and Daft Punk Helmets (by Anders Lejczak - http://www.colacola.se/expo_daft.htm)

