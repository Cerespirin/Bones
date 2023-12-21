using HarmonyLib;
using Verse;

namespace Cerespirin.Bones
{
	[StaticConstructorOnStartup]
	static class MyStaticConstructor
	{
		static MyStaticConstructor()
		{
			Harmony harmony = new Harmony("rimworld.cerespirin.bones");
			harmony.PatchAll();
		}
	}
}
