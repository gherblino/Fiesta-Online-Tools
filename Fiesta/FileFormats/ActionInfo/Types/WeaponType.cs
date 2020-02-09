using System;

namespace Fiesta.FileFormats.ActionInfo.Types
{
	public enum WeaponType : UInt32
	{
		None = 0x0,
		Sword = 0x1,
		Bow = 0x2,
		Staff = 0x3,
		Axe = 0x4,
		Mace = 0x5,
		Spike = 0x6,
		Fist = 0x7,
		Body = 0x8,
		Stone = 0x9,
		Crossbow = 0xA,
		Wand = 0xB,
		Spear = 0xC,
		Hammer = 0xD,
		Special = 0xE,
		ProductionTool = 0xF,
		InvisibleHammer = 0x10,
		DualSword = 0x11,
		Claws = 0x12,
		Blade = 0x13,
		WT_RANGE_PY = 0x14,
		TwoHandedSword = 0x15,
		MAX_WEAPONTYPEENUM = 0x16
	}
}