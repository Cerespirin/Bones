using RimWorld;
using Verse;

namespace Cerespirin.Bones
{
	public static class BoneUtility
	{
		public static ThingDef GetBoneProductFor(Pawn pawn) => pawn.def.GetModExtension<BoneProductExt>()?.boneDef ?? MyDefOf.Bones_Bone;

		public static bool IsWoody(this ThingDef stuff) => stuff.stuffProps.categories.Contains(StuffCategoryDefOf.Woody);
	}
}
