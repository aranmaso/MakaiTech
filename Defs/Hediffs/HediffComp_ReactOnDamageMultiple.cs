using System;
using RimWorld;
using Verse.AI;
using Verse;

namespace MakaiTech
{
	public class HediffComp_ReactOnDamageMultiple : HediffComp
	{
		public HediffCompProperties_ReactOnDamageMultiple Props
		{
			get
			{
				return (HediffCompProperties_ReactOnDamageMultiple)this.props;
			}
		}
		public override void Notify_PawnPostApplyDamage(DamageInfo dinfo, float totalDamageDealt)
		{
			if (this.Props.damageDefIncoming == dinfo.Def)
			{
				this.React();
			}
			if (this.Props.damageDefIncoming2 == dinfo.Def)
			{
				this.React2();
			}
			if (this.Props.damageDefIncoming3 == dinfo.Def)
			{
				this.React3();
			}
			if (this.Props.damageDefIncoming4 == dinfo.Def)
			{
				this.React4();
			}
			if (this.Props.damageDefIncoming5 == dinfo.Def)
			{
				this.React5();
			}
			if (this.Props.damageDefIncoming6 == dinfo.Def)
			{
				this.React6();
			}
			if (this.Props.damageDefIncoming7 == dinfo.Def)
			{
				this.React7();
			}
			if (this.Props.damageDefIncoming8 == dinfo.Def)
			{
				this.React8();
			}
			if (this.Props.damageDefIncoming9 == dinfo.Def)
			{
				this.React9();
			}
			if (this.Props.damageDefIncoming10 == dinfo.Def)
			{
				this.React10();
			}
			if (this.Props.DamageArmorCategoryDef == dinfo.Def.armorCategory)
			{
					this.React11();
			}
			if (this.Props.DamageArmorCategoryDef2 == dinfo.Def.armorCategory)
			{
					this.React12();
			}
			if (this.Props.DamageArmorCategoryDef3 == dinfo.Def.armorCategory)
			{
					this.React13();
			}
		}
		private void React()
		{
			if (this.Props.createHediff != null)
			{
				BodyPartRecord part = this.parent.Part;
				if (this.Props.createHediffOn != null)
				{
					part = this.parent.pawn.RaceProps.body.AllParts.FirstOrFallback((BodyPartRecord p) => p.def == this.Props.createHediffOn, null);
					this.parent.pawn.health.AddHediff(this.Props.createHediff, part, null, null);
				}
				else
				{
					this.parent.pawn.health.AddHediff(this.Props.createHediff, null, null, null);
				}
			}
			if (this.Props.vomit)
			{
				this.parent.pawn.jobs.StartJob(JobMaker.MakeJob(JobDefOf.Vomit), JobCondition.InterruptForced, null, true, true, null, null, false, false);
			}
		}
		private void React2()
		{
			if (this.Props.createHediff2 != null)
			{
				BodyPartRecord part = this.parent.Part;
				if (this.Props.createHediffOn2 != null)
				{
					part = this.parent.pawn.RaceProps.body.AllParts.FirstOrFallback((BodyPartRecord p) => p.def == this.Props.createHediffOn2, null);
					this.parent.pawn.health.AddHediff(this.Props.createHediff2, part, null, null);
				}
				else
				{
					this.parent.pawn.health.AddHediff(this.Props.createHediff2, null, null, null);
				}
			}
			if (this.Props.vomit)
			{
				this.parent.pawn.jobs.StartJob(JobMaker.MakeJob(JobDefOf.Vomit), JobCondition.InterruptForced, null, true, true, null, null, false, false);
			}
		}
		private void React3()
		{
			if (this.Props.createHediff3 != null)
			{
				BodyPartRecord part = this.parent.Part;
				if (this.Props.createHediffOn3 != null)
				{
					part = this.parent.pawn.RaceProps.body.AllParts.FirstOrFallback((BodyPartRecord p) => p.def == this.Props.createHediffOn3, null);
					this.parent.pawn.health.AddHediff(this.Props.createHediff3, part, null, null);
				}
				else
				{
					this.parent.pawn.health.AddHediff(this.Props.createHediff3, null, null, null);
				}
			}
			if (this.Props.vomit)
			{
				this.parent.pawn.jobs.StartJob(JobMaker.MakeJob(JobDefOf.Vomit), JobCondition.InterruptForced, null, true, true, null, null, false, false);
			}
		}
		private void React4()
		{
			if (this.Props.createHediff4 != null)
			{
				BodyPartRecord part = this.parent.Part;
				if (this.Props.createHediffOn4 != null)
				{
					part = this.parent.pawn.RaceProps.body.AllParts.FirstOrFallback((BodyPartRecord p) => p.def == this.Props.createHediffOn4, null);
					this.parent.pawn.health.AddHediff(this.Props.createHediff4, part, null, null);
				}
				else
				{
					this.parent.pawn.health.AddHediff(this.Props.createHediff4, null, null, null);
				}
			}
			if (this.Props.vomit)
			{
				this.parent.pawn.jobs.StartJob(JobMaker.MakeJob(JobDefOf.Vomit), JobCondition.InterruptForced, null, true, true, null, null, false, false);
			}
		}
		private void React5()
		{
			if (this.Props.createHediff5 != null)
			{
				BodyPartRecord part = this.parent.Part;
				if (this.Props.createHediffOn5 != null)
				{
					part = this.parent.pawn.RaceProps.body.AllParts.FirstOrFallback((BodyPartRecord p) => p.def == this.Props.createHediffOn5, null);
					this.parent.pawn.health.AddHediff(this.Props.createHediff5, part, null, null);
				}
				else
				{
					this.parent.pawn.health.AddHediff(this.Props.createHediff5, null, null, null);
				}
			}
			if (this.Props.vomit)
			{
				this.parent.pawn.jobs.StartJob(JobMaker.MakeJob(JobDefOf.Vomit), JobCondition.InterruptForced, null, true, true, null, null, false, false);
			}
		}
		private void React6()
		{
			if (this.Props.createHediff6 != null)
			{
				BodyPartRecord part = this.parent.Part;
				if (this.Props.createHediffOn6 != null)
				{
					part = this.parent.pawn.RaceProps.body.AllParts.FirstOrFallback((BodyPartRecord p) => p.def == this.Props.createHediffOn6, null);
					this.parent.pawn.health.AddHediff(this.Props.createHediff6, part, null, null);
				}
				else
				{
					this.parent.pawn.health.AddHediff(this.Props.createHediff6, null, null, null);
				}
			}
			if (this.Props.vomit)
			{
				this.parent.pawn.jobs.StartJob(JobMaker.MakeJob(JobDefOf.Vomit), JobCondition.InterruptForced, null, true, true, null, null, false, false);
			}
		}
		private void React7()
		{
			if (this.Props.createHediff7 != null)
			{
				BodyPartRecord part = this.parent.Part;
				if (this.Props.createHediffOn7 != null)
				{
					part = this.parent.pawn.RaceProps.body.AllParts.FirstOrFallback((BodyPartRecord p) => p.def == this.Props.createHediffOn7, null);
					this.parent.pawn.health.AddHediff(this.Props.createHediff7, part, null, null);
				}
				else
				{
					this.parent.pawn.health.AddHediff(this.Props.createHediff7, null, null, null);
				}
			}
			if (this.Props.vomit)
			{
				this.parent.pawn.jobs.StartJob(JobMaker.MakeJob(JobDefOf.Vomit), JobCondition.InterruptForced, null, true, true, null, null, false, false);
			}
		}
		private void React8()
		{
			if (this.Props.createHediff8 != null)
			{
				BodyPartRecord part = this.parent.Part;
				if (this.Props.createHediffOn8 != null)
				{
					part = this.parent.pawn.RaceProps.body.AllParts.FirstOrFallback((BodyPartRecord p) => p.def == this.Props.createHediffOn8, null);
					this.parent.pawn.health.AddHediff(this.Props.createHediff8, part, null, null);
				}
				else
				{
					this.parent.pawn.health.AddHediff(this.Props.createHediff8, null, null, null);
				}
			}
			if (this.Props.vomit)
			{
				this.parent.pawn.jobs.StartJob(JobMaker.MakeJob(JobDefOf.Vomit), JobCondition.InterruptForced, null, true, true, null, null, false, false);
			}
		}
		private void React9()
		{
			if (this.Props.createHediff9 != null)
			{
				BodyPartRecord part = this.parent.Part;
				if (this.Props.createHediffOn9 != null)
				{
					part = this.parent.pawn.RaceProps.body.AllParts.FirstOrFallback((BodyPartRecord p) => p.def == this.Props.createHediffOn9, null);
					this.parent.pawn.health.AddHediff(this.Props.createHediff9, part, null, null);
				}
				else
				{
					this.parent.pawn.health.AddHediff(this.Props.createHediff9, null, null, null);
				}
			}
			if (this.Props.vomit)
			{
				this.parent.pawn.jobs.StartJob(JobMaker.MakeJob(JobDefOf.Vomit), JobCondition.InterruptForced, null, true, true, null, null, false, false);
			}
		}
		private void React10()
		{
			if (this.Props.createHediff10 != null)
			{
				BodyPartRecord part = this.parent.Part;
				if (this.Props.createHediffOn10 != null)
				{
					part = this.parent.pawn.RaceProps.body.AllParts.FirstOrFallback((BodyPartRecord p) => p.def == this.Props.createHediffOn10, null);
					this.parent.pawn.health.AddHediff(this.Props.createHediff10, part, null, null);
				}
				else
				{
					this.parent.pawn.health.AddHediff(this.Props.createHediff10, null, null, null);
				}
			}
			if (this.Props.vomit)
			{
				this.parent.pawn.jobs.StartJob(JobMaker.MakeJob(JobDefOf.Vomit), JobCondition.InterruptForced, null, true, true, null, null, false, false);
			}
		}

		private void React11()
		{
			if (this.Props.createHediff11 != null)
			{	
				if (this.Props.skipIfAlreadyExists && (this.parent.pawn.health.hediffSet.HasHediff(this.Props.createHediff12,false) || this.parent.pawn.health.hediffSet.HasHediff(this.Props.createHediff13,false)))
				{
					return;
				}
				if (this.parent.pawn.health.hediffSet.HasHediff(this.Props.createHediff11, false))
				{
					this.parent.pawn.health.hediffSet.GetFirstHediffOfDef(this.Props.createHediff11, false).Severity += this.Props.SeverityPerHit1;
				}
				BodyPartRecord part = this.parent.Part;
				if (this.Props.createHediffOn11 != null)
				{
					part = this.parent.pawn.RaceProps.body.AllParts.FirstOrFallback((BodyPartRecord p) => p.def == this.Props.createHediffOn11, null);
					this.parent.pawn.health.AddHediff(this.Props.createHediff11, part, null, null);
				}
				else
                {
				this.parent.pawn.health.AddHediff(this.Props.createHediff11, null, null, null);
				}	
			}
			if (this.Props.vomit)
			{
				this.parent.pawn.jobs.StartJob(JobMaker.MakeJob(JobDefOf.Vomit), JobCondition.InterruptForced, null, true, true, null, null, false, false);
			}
		}
		private void React12()
		{
			if (this.Props.createHediff12 != null)
			{
				if (this.Props.skipIfAlreadyExists && (this.parent.pawn.health.hediffSet.HasHediff(this.Props.createHediff11, false) || this.parent.pawn.health.hediffSet.HasHediff(this.Props.createHediff13, false)))
				{
					return;
				}
				if (this.parent.pawn.health.hediffSet.HasHediff(this.Props.createHediff12, false))
                {
					this.parent.pawn.health.hediffSet.GetFirstHediffOfDef(this.Props.createHediff12, false).Severity += this.Props.SeverityPerHit2;
				}
				BodyPartRecord part = this.parent.Part;
				if (this.Props.createHediffOn12 != null)
				{
					part = this.parent.pawn.RaceProps.body.AllParts.FirstOrFallback((BodyPartRecord p) => p.def == this.Props.createHediffOn12, null);
					this.parent.pawn.health.AddHediff(this.Props.createHediff12, part, null, null);
				}
				else
				{
					this.parent.pawn.health.AddHediff(this.Props.createHediff12, null, null, null);
				}
			}
			if (this.Props.vomit)
			{
				this.parent.pawn.jobs.StartJob(JobMaker.MakeJob(JobDefOf.Vomit), JobCondition.InterruptForced, null, true, true, null, null, false, false);
			}
		}
		private void React13()
		{
			if (this.Props.createHediff13 != null)
			{
				if (this.Props.skipIfAlreadyExists && (this.parent.pawn.health.hediffSet.HasHediff(this.Props.createHediff11, false) || this.parent.pawn.health.hediffSet.HasHediff(this.Props.createHediff12, false)))
				{
					return;
				}
				if (this.parent.pawn.health.hediffSet.HasHediff(this.Props.createHediff13, false))
				{
					this.parent.pawn.health.hediffSet.GetFirstHediffOfDef(this.Props.createHediff13, false).Severity += this.Props.SeverityPerHit3;
				}
				BodyPartRecord part = this.parent.Part;
				if (this.Props.createHediffOn13 != null)
				{
					part = this.parent.pawn.RaceProps.body.AllParts.FirstOrFallback((BodyPartRecord p) => p.def == this.Props.createHediffOn13, null);
					this.parent.pawn.health.AddHediff(this.Props.createHediff13, part, null, null);
				}
				else
				{
					this.parent.pawn.health.AddHediff(this.Props.createHediff13, null, null, null);
				}
			}
			if (this.Props.vomit)
			{
				this.parent.pawn.jobs.StartJob(JobMaker.MakeJob(JobDefOf.Vomit), JobCondition.InterruptForced, null, true, true, null, null, false, false);
			}
		}
	}	
}
