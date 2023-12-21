using RimWorld;
using Verse;

namespace Cerespirin.Bones
{
	[DefOf]
	public static class MyDefOf
	{
		static MyDefOf() => DefOfHelper.EnsureInitializedInCtor(typeof(MyDefOf));

		public static StatDef BoneAmount;
		public static ThingDef Bones_Bone;
	}
}
