# Bones and Chitin
Adds bone as a new woody materials.

## Gameplay Notes
Bone has very similar properties to wood. It is better for sharp weapons and heat insulation compared to wood's blunt weapons and cold insulation. Anything that can be refueled with wood (kitchens, smithies, wood-fired generators) can now take bone. Knives can now be made of woody materials. Bone can be mixed in when refining chemfuel from wood.

Thrumbone is obtained from butchering thrumbos. It makes excellent sharp weapons, high-health and fast-opening doors, and beautiful sculptures; you'll probably have a hard time deciding what to use this rare material for!

## Mod Extensions
This mod exposes a ModExtension so that other modders (like you!) can add your own bone defs. To use it, just add the following code (or similar) to your patch file:

```xml
<Operation Class="PatchOperationFindMod">
  <mods>
    <li>Bones</li>
  </mods>
  <match Class="PatchOperationAddModExtension">
    <xpath>Defs/ThingDef[defName="YOUR_TARGET_HERE"]</xpath>
    <value>
      <li Class = "Cerespirin.Bones.BoneProductExt">
        <boneDef>YOUR_BONE_DEF_HERE</boneDef>
      </li>
    </value>
  </match>
</Operation>
```
