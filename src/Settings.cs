using ModSettings;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace FireAddons
{
	internal class FireAddonsSettings : JsonModSettings
	{
		[Section("Lantern")]
		[Name("Use Lantern to start fire")]
		[Description("Suggested value: yes")]
		public bool lanternUse = true;

		[Name("Lantern: time to light fire")]
		[Description("Suggested value 5 for 'mechanical'; 0 for 'accelerated'.")]
		[Slider(0, 40)]
		public int lanternStartFire = 5;

		[Name("Lantern: time to light torch")]
		[Description("Suggested value 5 for 'mechanical'; 0 for 'accelerated'.")]
		[Slider(0, 40)]
		public int lanternStartTorch = 5;

		[Name("Lantern: fire start chance modification")]
		[Description("Suggested value -10 for 'mechanical'; +20 for 'accelerated'.")]
		[Slider(-100, 30)]
		public int lanternPenalty = -5;

		[Name("Lantern: degredation")]
		[Description("Suggested value 0 for 'mechanical'; any positive for 'accelerated'.")]
		[Slider(0, 20)]
		public int lanternDegredation = 0;


		[Section("Lenses modifiers")]
		[Name("Lenses: time to light fire")]
		[Description("Default: 10.")]
		[Slider(0, 40)]
		public int lensesStartFire = 10;

		[Name("Lenses: time to light torch")]
		[Description("Default: 10.")]
		[Slider(0, 40)]
		public int lensesStartTorch = 10;

		[Name("Lenses: fire start chance modification")]
		[Description("Default: 10.")]
		[Slider(-100, 30)]
		public int lensesPenalty = -5;

		[Name("Lenses: degredation")]
		[Description("Default: 0.")]
		[Slider(0, 20)]
		public int lensesDegredation = 0;


		[Section("Firestriker modifiers")]
		[Name("Firestriker: time to light fire")]
		[Description("Default: 3.")]
		[Slider(0, 40)]
		public int firestrikerStartFire = 3;

		[Name("Firestriker: time to light torch")]
		[Description("Default: 3.")]
		[Slider(0, 40)]
		public int firestrikerStartTorch = 3;

		[Name("Firestriker: fire start chance modification")]
		[Description("Default: 20.")]
		[Slider(-100, 30)]
		public int firestrikerPenalty = 0;

		[Name("Firestriker: degredation")]
		[Description("Default: 2.")]
		[Slider(0, 20)]
		public int firestrikerDegredation = 2;


		[Section("Flint")]
		[Name("Flint: crafting enabled")]
		public bool flintEnable = true;

		[Name("Flint: resmelt enabled")]
		[Description("Allow re-smelting flints steel as repair process.")]
		public bool flintSmeltEnable = true;

		[Name("Flint: time to light fire")]
		[Description("Default: 4.")]
		[Slider(0, 40)]
		public int flintStartFire = 4;

		[Name("Flint: time to light torch")]
		[Description("Default: 4.")]
		[Slider(0, 40)]
		public int flintStartTorch = 4;

		[Name("Flint: fire start chance modification")]
		[Description("Default: -10.")]
		[Slider(-100, 50)]
		public int flintPenalty = -10;

		[Name("Flint: degredation")]
		[Description("Suggested value 1.")]
		[Slider(0f, 20f)]
		public int flintDegredation = 1;


		[Section("Matches StartingChance modifiers")]
		[Name("Cardboard Matches: fire start chance modification")]
		[Description("Default: 5.")]
		[Slider(-100, 50)]
		public int PackMatchesPenalty = 5;

		[Name("Wood Matches: fire start chance modification")]
		[Description("Default: 10.")]
		[Slider(-100, 50)]
		public int WoodMatchesPenalty = 10;


		[Section("Torch/Flares StartingChance modifiers")]
		[Name("Torch as Starter: fire start chance modification")]
		[Description("Default: 10.")]
		[Slider(-100, 50)]
		public int TorchStarterPenalty = 10;

		[Name("Torch as Fuel: fire start chance modification")]
		[Description("Default: -10.")]
		[Slider(-50, 50)]
		public int TorchFuelPenalty = -10;

		[Name("Flare: fire start chance modification")]
		[Description("Default: 10.")]
		[Slider(-100, 50)]
		public int FlareAPenalty = 10;

		[Name("Marine Flare: fire start chance modification")]
		[Description("Default: 10.")]
		[Slider(-100, 50)]
		public int BlueFlarePenalty = 10;


		[Section("Fuel StartingChance modifiers")]
		[Name("BookA: fire start chance modification")]
		[Description("Default: 30.")]
		[Slider(-50, 50)]
		public int BookAPenalty = 30;

		[Name("Firelog: fire start chance modification")]
		[Description("Default: -3.")]
		[Slider(-50, 50)]
		public int FirelogPenalty = -3;

		[Name("Hardwood: fire start chance modification")]
		[Description("Default: -5.")]
		[Slider(-50, 50)]
		public int HardwoodPenalty = -5;

		[Name("Reclaimed Wood: fire start chance modification")]
		[Description("Default: -10.")]
		[Slider(-50, 50)]
		public int ReclaimedWoodBPenalty = -10;

		[Name("Softwood: fire start chance modification")]
		[Description("Default: 10.")]
		[Slider(-50, 50)]
		public int SoftwoodPenalty = 10;

		[Name("Stick: fire start chance modification")]
		[Description("Default: 10.")]
		[Slider(-50, 50)]
		public int StickPenalty = 10;


		[Section("Accelerant StartingChance modifiers")]
		//[Name("Accelerant: fire start chance modification")]
		//[Description("Affects all accelerant types. Default: 40.")]
		//[Slider(0, 100)]
		//public int AccelerantPenalty = 40;
		//
		[Name("AccelerantGunpowder: fire start chance modification")]
		[Description("Affects Gunpowder. Default: 40.")]
		[Slider(0, 100)]
		public int AccelerantGunpowderPenalty = 40;

		[Name("AccelerantLiquids: fire start chance modification")]
		[Description("Affects Accelerant AND Lamp Oil. Default: 40.")]
		[Slider(0, 100)]
		public int AccelerantKerosenePenalty = 40;

		//[Name("AccelerantMedium: fire start chance modification")]
		//[Description("Affects all accelerant types. Default: 40.")]
		//[Slider(0, 100)]
		//public int AccelerantMediumPenalty = 40;

		//[Name("Lanturn Fuel: fire start chance modification")]
		//[Description("Affects all accelerant types. Default: 40.")]
		//[Slider(0, 100)]
		//public int LampFuelPenalty = 40;

		//[Name("Gunpowder: fire start chance modification")]
		//[Description("Affects all accelerant types. Default: 40.")]
		//[Slider(0, 100)]
		//public int GunpowderPenalty = 40;


		[Section("Tinder")]
		[Name("Tinder as Fuel")]
		[Description("Use tinder as fuel (not during starting fire). Vanilla: no, suggested yes.")]
		public bool tinderAsFuel = true;

		[Name("Tinder fuel time")]
		[Description("In minutes. Vanilla: 0, suggested 1-2.")]
		[Slider(0, 30)]
		public int tinderFuel = 2;

		[Name("Tinder fuel temperature")]
		[Description("Increase of temp in Celsius. Vanilla: 0, suggested 3-5.")]
		[Slider(0, 30)]
		public int tinderFueldeg = 5;

		[Name("Tinder fire start modifications")]
		[Description("Chance fire start values for tinders. Vanilla: no, suggested: yes.")]
		public bool tinderMatters = true;

		[Name("Tinder Plug: fire start modification")]
		[Description("Suggested value 1.")]
		[Slider(-40, 40)]
		public int tinderBonusPlug = -5;

		[Name("Newsprint: fire start modification")]
		[Description("Suggested value 2.")]
		[Slider(-40, 40)]
		public int tinderBonusNewsprint = 0;

		[Name("Newsprint Roll: fire start modification")]
		[Description("Suggested value 3.")]
		[Slider(-40, 40)]
		public int tinderBonusNewsprintRoll = 5;

		[Name("Paper Stack: fire start modification")]
		[Description("Suggested value 2.")]
		[Slider(-40, 40)]
		public int tinderBonusPaper = 0;

		[Name("Cash: fire start modification")]
		[Description("Suggested value 2.")]
		[Slider(-40, 40)]
		public int tinderBonusCash = -5;

		[Name("Bark: fire start modification")]
		[Description("Suggested value 5.")]
		[Slider(-40, 40)]
		public int tinderBonusBark = 10;

		[Name("Cattail Head: fire start modification")]
		[Description("Suggested value 1.")]
		[Slider(-40, 40)]
		public int tinderBonusCattail = 5;

		//[Name("TinderPile010: fire start modification")]
		//[Description("Suggested value 1.")]
		//[Slider(-40, 40)]
		//public int tinderBonusTinderPile010 = 5;


		[Section("Embers")]
		[Name("Reworked embers (smoldering fuel)")]
		[Description("Enable reworked embers (smoldering fuel) system - see Readme on github for exact details.")]
		public bool embersSystem = true;

		[Name("Embers max time")]
		[Description("Maximum time embers will last, in hours.")]
		[Slider(0f, 12f)]
		public float embersTime = 8f;

		[Name("Burnout temperature")]
		[Description("Temperature above which fuel will be burning out from ember store. See next setting.")]
		[Slider(20, 50)]
		public int embersBunoutTemp = 30;

		[Name("Burnout ratio")]
		[Description("Ratio of ember (max) time is removed (burnt) in one hour, at 80C. Burnt embers will extend burning time of fire.")]
		[Slider(0.1f, 1f, NumberFormat = "{0:F2}")]
		public float embersBunoutRatio = 0.5f;

		[Name("Fuel to embers ratio")]
		[Description("Fraction of fuel is transfered to embers on fuel add. Used with next settings.")]
		[Slider(0.05f, 0.5f, NumberFormat = "{0:F2}")]
		public float embersFuelRatio = 0.2f;

		[Name("Fuel to embers exchange")]
		[Description("Multiplier of above fraction, to be added to ember timer.")]
		[Slider(1f, 5f)]
		public float embersFuelEx = 2f;

		[Name("Water fire cooldown")]
		[Description("Amount of deg, fire will cooldown per 250ml of water. NOTE: in 'Add Fuel' it will show as can/pot as water directly can't be used.")]
		[Slider(1, 30)]
		public int waterTempRemoveDeg = 15;

		[Name("Prevent cooking while in ember state")]
		[Description("Will disable cooking/boiling while stove/campfire is in 'ember state' when new ember/smoldering mechanic is used. Setting this to false, will make new mechanic useless and they will only 'extend burn time' (yet this ability was requiesed). Recommended: true.")]
		public bool embersSystemNoCooking = true;

		[Name("Use Charcoal as fuel")]
		[Description("Allow using charcal as fuel. Set to false if other mod is adding charcoal as fuel")]
		public bool burnCharcoal = true;

		[Name("... burn time")]
		[Description("Recommended 20 min.")]
		[Slider(5, 40)]
		public int burnCharcoalTime = 20;

		[Name("... temp increase")]
		[Description("Recommended 5 deg")]
		[Slider(0, 15)]
		public int burnCharcoalTemp = 5;

		protected override void OnChange(FieldInfo field, object oldValue, object newValue)
		{
			RefreshFields();
		}

		internal void RefreshFields()
		{
			if (lanternUse)
			{

				SetFieldVisible(nameof(lanternStartFire), true);
				SetFieldVisible(nameof(lanternStartTorch), true);
				SetFieldVisible(nameof(lanternPenalty), true);
				SetFieldVisible(nameof(lanternDegredation), true);

			}
			else
			{
				SetFieldVisible(nameof(lanternStartFire), false);
				SetFieldVisible(nameof(lanternStartTorch), false);
				SetFieldVisible(nameof(lanternPenalty), false);
				SetFieldVisible(nameof(lanternDegredation), false);
			}
			if (tinderAsFuel)
			{
				SetFieldVisible(nameof(tinderFuel), true);
				SetFieldVisible(nameof(tinderFueldeg), true);
			}
			else
			{
				SetFieldVisible(nameof(tinderFuel), false);
				SetFieldVisible(nameof(tinderFueldeg), false);
			}
			if (tinderMatters)
			{
				SetFieldVisible(nameof(tinderBonusPlug), true);
				SetFieldVisible(nameof(tinderBonusPaper), true);
				SetFieldVisible(nameof(tinderBonusNewsprintRoll), true);
				SetFieldVisible(nameof(tinderBonusNewsprint), true);
				SetFieldVisible(nameof(tinderBonusCattail), true);
				SetFieldVisible(nameof(tinderBonusCash), true);
				SetFieldVisible(nameof(tinderBonusBark), true);
			}
			else
			{
				SetFieldVisible(nameof(tinderBonusPlug), false);
				SetFieldVisible(nameof(tinderBonusPaper), false);
				SetFieldVisible(nameof(tinderBonusNewsprintRoll), false);
				SetFieldVisible(nameof(tinderBonusNewsprint), false);
				SetFieldVisible(nameof(tinderBonusCattail), false);
				SetFieldVisible(nameof(tinderBonusCash), false);
				SetFieldVisible(nameof(tinderBonusBark), false);

			}
			if (flintEnable)
			{
				SetFieldVisible(nameof(flintSmeltEnable), true);
				SetFieldVisible(nameof(flintDegredation), true);
				SetFieldVisible(nameof(flintStartFire), true);
				SetFieldVisible(nameof(flintStartTorch), true);
				SetFieldVisible(nameof(flintPenalty), true);
			}
			else
			{
				SetFieldVisible(nameof(flintSmeltEnable), false);
				SetFieldVisible(nameof(flintDegredation), true);
				SetFieldVisible(nameof(flintStartFire), true);
				SetFieldVisible(nameof(flintStartTorch), true);
				SetFieldVisible(nameof(flintPenalty), true);
			}
			if (embersSystem)
			{
				SetFieldVisible(nameof(embersTime), true);
				SetFieldVisible(nameof(embersBunoutTemp), true);
				SetFieldVisible(nameof(embersBunoutRatio), true);
				SetFieldVisible(nameof(embersFuelRatio), true);
				SetFieldVisible(nameof(embersFuelEx), true);
				SetFieldVisible(nameof(waterTempRemoveDeg), true);
				SetFieldVisible(nameof(embersSystemNoCooking), true);
			}
			else
			{
				SetFieldVisible(nameof(embersTime), false);
				SetFieldVisible(nameof(embersBunoutTemp), false);
				SetFieldVisible(nameof(embersBunoutRatio), false);
				SetFieldVisible(nameof(embersFuelRatio), false);
				SetFieldVisible(nameof(embersFuelEx), false);
				SetFieldVisible(nameof(waterTempRemoveDeg), false);
				SetFieldVisible(nameof(embersSystemNoCooking), false);

			}
			if (burnCharcoal)
			{
				SetFieldVisible(nameof(burnCharcoalTime), true);
				SetFieldVisible(nameof(burnCharcoalTemp), true);
			}
			else
			{
				SetFieldVisible(nameof(burnCharcoalTime), false);
				SetFieldVisible(nameof(burnCharcoalTemp), false);
			}
		}
	}
	internal static class Settings
	{
		public static FireAddonsSettings options;
		public static void OnLoad()
		{
			options = new FireAddonsSettings();
			options.RefreshFields();
			options.AddToModSettings("Fire Addons Settings");
		}
	}
}