using System.Collections.Generic;
using Verse;

namespace Cerespirin.Bones
{
	public class BoneProductExt : DefModExtension
	{
		public ThingDef boneDef;

		public override IEnumerable<string> ConfigErrors()
		{
			foreach (string error in base.ConfigErrors())
			{
				yield return error;
			}
			if (boneDef == null)
			{
				yield return "null boneDef";
			}
			yield break;
		}
	}
}
