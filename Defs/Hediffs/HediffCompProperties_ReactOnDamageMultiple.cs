using System;
using System.Collections.Generic;
using Verse;
using RimWorld;

namespace MakaiTech
{
	// Token: 0x020002B5 RID: 693
	public class HediffCompProperties_ReactOnDamageMultiple : HediffCompProperties
	{
		// Token: 0x06001300 RID: 4864 RVA: 0x0006E03F File Offset: 0x0006C23F
		public HediffCompProperties_ReactOnDamageMultiple()
		{
			this.compClass = typeof(HediffComp_ReactOnDamageMultiple);
		}

		// Token: 0x04000E66 RID: 3686
		public DamageDef damageDefIncoming;
		public DamageDef damageDefIncoming2;
		public DamageDef damageDefIncoming3;
		public DamageDef damageDefIncoming4;
		public DamageDef damageDefIncoming5;
		public DamageDef damageDefIncoming6;
		public DamageDef damageDefIncoming7;
		public DamageDef damageDefIncoming8;
		public DamageDef damageDefIncoming9;
		public DamageDef damageDefIncoming10;
		public DamageArmorCategoryDef DamageArmorCategoryDef;
		public DamageArmorCategoryDef DamageArmorCategoryDef2;
		public DamageArmorCategoryDef DamageArmorCategoryDef3;

		public bool skipIfAlreadyExists;
		public bool skipIfAlreadyExists2;
		public bool skipIfAlreadyExists3;

		// Token: 0x04000E67 RID: 3687
		public BodyPartDef createHediffOn;
		public BodyPartDef createHediffOn2;
		public BodyPartDef createHediffOn3;
		public BodyPartDef createHediffOn4;
		public BodyPartDef createHediffOn5;
		public BodyPartDef createHediffOn6;
		public BodyPartDef createHediffOn7;
		public BodyPartDef createHediffOn8;
		public BodyPartDef createHediffOn9;
		public BodyPartDef createHediffOn10;
		public BodyPartDef createHediffOn11;
		public BodyPartDef createHediffOn12;
		public BodyPartDef createHediffOn13;

		// Token: 0x04000E68 RID: 3688
		public HediffDef createHediff;
		public HediffDef createHediff2;
		public HediffDef createHediff3;
		public HediffDef createHediff4;
		public HediffDef createHediff5;
		public HediffDef createHediff6;
		public HediffDef createHediff7;
		public HediffDef createHediff8;
		public HediffDef createHediff9;
		public HediffDef createHediff10;
		public HediffDef createHediff11;
		public HediffDef createHediff12;
		public HediffDef createHediff13;

		public float SeverityPerHit1;
		public float SeverityPerHit2;
		public float SeverityPerHit3;

		// Token: 0x04000E69 RID: 3689
		public bool vomit;
	}
}
