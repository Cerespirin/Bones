using RimWorld;
using Verse;

namespace Cerespirin.Bones
{
	public static class BoneUtility
	{
		public static ThingDef GetBoneProductFor(Pawn pawn)
		{
			ThingDef specialBoneProduct = pawn.def.GetModExtension<BoneProductExt>()?.boneDef;

			if (specialBoneProduct != null)
			{
				return specialBoneProduct;
			}
			else
			{
				return MyDefOf.Bones_Bone;
			}
		}
	}
}
