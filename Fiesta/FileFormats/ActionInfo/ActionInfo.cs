using System.ComponentModel;
using Fiesta.FileFormats.ActionInfo.Types;
using Fiesta.FileFormats.ActionInfo.Types.Effect;
using Fiesta.FileFormats.ActionInfo.Types.Sound;

namespace Fiesta.FileFormats.ActionInfo
{
	public class ActionInfo
	{
		[DisplayName("ID")]
		[Description("The ID of the action.")]
		public ushort ID { get; set; }

		[DisplayName("Name")]
		[Description("The name of the action.")]
		public string ActionName { get; set; }

		[DisplayName("Index Name")]
		[Description("The value that needs to be in the column \"SwingAction\" in ActiveSkillViewInfo.shn, if you want to use it for a skill.\nIf not, it can be anything (preferably matching the action name).")]
		public string InxName { get; set; }

		[DisplayName("Animation Index")]
		[Description("The name of the corresponding animation (.kf) file in reschar.")]
		public string AniInx { get; set; }

		[DisplayName("WeaponDemand")]
		[Description("The weapon you need to have equiped in order to perform the effect.")]
		public WeaponDemand WeaponDemand { get; set; }

		[DisplayName("Event Code")]
		[Description("The value that defines the idle animations. It is used by NPCViewInfo.shn only, and it must match the Event Code in the animation.")]
		public uint EventCode { get; set; }

		[DisplayName("Weapon Type")]
		[Description("Unk.")]
		public WeaponType WeaponType { get; set; }

		[DisplayName("Effect Data")]
		[Description("Information regarding the effect.")]
		public Effect Effect { get; set; }

		[DisplayName("Sound Data")]
		[Description("Information regarding the sound.")]
		public Sound Sound { get; set; }

		public ActionInfo(ushort id, string inxName, string actionName, WeaponDemand weaponDemand, string aniInx, uint eventCode, WeaponType weaponType, Effect effect, Sound sound)
		{
			ID = id;
			InxName = inxName;
			ActionName = actionName;
			WeaponDemand = weaponDemand;
			AniInx = aniInx;
			EventCode = eventCode;
			WeaponType = weaponType;
			Effect = effect;
			Sound = sound;
		}
	}
}
