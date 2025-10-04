using HarmonyLib;
using RimWorld;
using RimWorld.SketchGen;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using Verse;

namespace Cerespirin.Bones
{
	[HarmonyPatch(typeof(SketchGenUtility), nameof(SketchGenUtility.IsStuffAllowed))]
	public static class HarmonyPatch_SketchGenUtility_IsStuffAllowed
	{
		public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
		{
			FieldInfo targetField = AccessTools.Field(typeof(ThingDefOf), nameof(ThingDefOf.WoodLog));
			byte state = 0;

			foreach (CodeInstruction instruction in instructions) 
			{
				if (state == 0 && instruction.opcode == OpCodes.Ldsfld && (FieldInfo)instruction.operand == targetField)
				{
					instruction.opcode = OpCodes.Call;
					instruction.operand = AccessTools.Method(typeof(BoneUtility), nameof(BoneUtility.IsWoody));
					state = 1;
				}
				else if (state == 1 && instruction.opcode == OpCodes.Bne_Un_S)
				{
					instruction.opcode = OpCodes.Brfalse_S;
					state = 2;
				}
				yield return instruction;
			}
			if (state < 2)
			{
				Log.Error("[Bones] HarmonyPatch_SketchGenUtility_IsStuffAllowed: unable to find injection point. This was likely due to a mod incompatibility; please report this to the mod author.");
			}
		}
	}
}
