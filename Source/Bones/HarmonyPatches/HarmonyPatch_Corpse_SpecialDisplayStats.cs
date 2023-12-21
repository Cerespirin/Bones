using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using Verse;

namespace Cerespirin.Bones
{
	[HarmonyPatch(typeof(Corpse), nameof(Corpse.SpecialDisplayStats))]
	public static class HarmonyPatch_Corpse_SpecialDisplayStats
	{
		public static IEnumerable<StatDrawEntry> Postfix(IEnumerable<StatDrawEntry> entries, Corpse __instance)
		{
			foreach (StatDrawEntry entry in entries)
			{
				yield return entry;
			}
			StatDef BoneAmount = MyDefOf.BoneAmount;
			float pawnBoneCount = __instance.InnerPawn.GetStatValue(BoneAmount);
			yield return new StatDrawEntry(BoneAmount.category, BoneAmount, pawnBoneCount, StatRequest.For(__instance.InnerPawn));
		}
	}
}
