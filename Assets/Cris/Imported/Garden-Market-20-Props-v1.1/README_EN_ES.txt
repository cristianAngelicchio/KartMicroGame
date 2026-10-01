GARDEN MARKET | 20 LOW-POLY PROPS | v1.1
By Shapita - https://shapita.itch.io

CONTENTS
20 independent GLB files and 20 FBX files. Editable Blender library, studio layout and composed demo scene. Flat-color materials are embedded; no image textures are needed.
Total geometry for one of each prop: 15,296 triangles. Per-model counts: manifest.json.

GETTING STARTED
Unzip first. In Blender 4.5 or later, open Garden_Market_Library.blend for the grid library, or Garden_Market_Demo.blend for the assembled example. Select an object and press Alt+G to move its origin to world zero. Individual GLB/FBX files are already exported around the origin.
To import an individual file in Blender: File > Import > glTF 2.0 or FBX. In other software, use its supported glTF/FBX import workflow and check scale/materials with the free sample first. World units are meters; Blender uses Z-up and GLB uses its standard Y-up conversion.
Each prop is a joined static mesh with multiple flat-color material slots. Change those material colors to customize it. Mesh islands can be separated in Blender Edit Mode using Separate > By Loose Parts; no procedural modifiers are required.

LIMITS
No rigging, animations, colliders, LODs, texture atlas or curated texture-paint UV layout. No native game-engine project or engine certification. FBX material appearance can vary with the importer. Not prepared or tested for physical printing. Some props contain overlapping mesh islands by design.
The demo includes a plain presentation floor, camera and lights; these are not counted among the 20 props. Delete or hide them for your own scene.

VALIDATION
All 40 interchange files were reimported in Blender 4.5.10. Checks verify triangle counts, finite coordinates and nonzero-area faces. See validation.json. Rendered previews were inspected by an AI agent. No Unity/Unreal/Godot runtime validation is claimed.

AI DISCLOSURE
Model design and procedural Blender scripting were generated with AI assistance. Geometry was exported and tested in Blender. Previews are actual geometry renders, not generated illustrations. Text is AI-assisted. No third-party textures or models are included.

SUPPORT
Report file problems in the itch.io product comments with the filename, software/version and steps to reproduce. This purchase does not include custom modeling or guaranteed future updates. See LICENSE.txt for commercial usage terms.

GUIA EN ESPANOL
Descomprime el ZIP. Abre Garden_Market_Library.blend para ver los 20 objetos, o Garden_Market_Demo.blend para la escena armada. Los archivos individuales estan en GLB/ y FBX/. Las unidades son metros. Puedes cambiar los colores desde los materiales del objeto.
Para importar en Blender: Archivo > Importar > glTF 2.0 o FBX. En otro programa, prueba primero la muestra gratuita. No se incluyen animaciones, colisiones, LODs ni proyectos nativos de motores. No son archivos preparados para impresion 3D.
Los 40 archivos se reabrieron y comprobaron en Blender; no se afirma validacion en Unity, Unreal ni Godot. Los modelos y textos se crearon con asistencia de IA. Las imagenes muestran los modelos reales.
Puedes utilizar el pack en juegos y otros proyectos comerciales. No puedes revender los modelos como recursos independientes. Consulta LICENSE.txt. Para problemas, indica archivo y version de tu programa en los comentarios del producto.


V1.1 (2026-09-24): CORRECTIONS / CORRECCIONES
1. Colours: materials stored their hex colours without sRGB-to-linear conversion, so the pack
   rendered washed out. All 20 props now use the intended colours.
2. 01_Awning_Stall, 02_Display_Table, 04_Garden_Bench: the low stretcher bar floated between the
   legs, and the middle top boards had nothing underneath. Each now has end rails joining the
   stretcher to the legs (H-frame) and two rails under the top boards; the stall also has a
   front rail holding its front boards.
3. GLB, FBX, all three Blender files, preview images and the free sample were regenerated.
   Total for one of each prop: 15,296 triangles. Khronos glTF Validator: 0 errors, 0 warnings.
1. Colores corregidos (antes se veian destenidos). 2. En el puesto, la mesa y la banca el
   travesano flotaba y las tablas centrales no tenian apoyo; ahora tienen largueros. 3. Se
   regeneraron GLB, FBX, archivos Blender, imagenes y muestra.
