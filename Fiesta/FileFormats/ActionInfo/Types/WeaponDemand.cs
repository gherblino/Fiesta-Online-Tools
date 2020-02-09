using System;

namespace Fiesta.FileFormats.ActionInfo.Types
{
	public enum WeaponDemand : UInt32
	{
		None = 0x0,
		Sword = 0x1,
		TwoHandSword = 0x2,
		Axe = 0x4,
		Bow = 0x8,
		CrossBow = 0x10,
		Hammer = 0x20,
		Mace = 0x40,
		Staff = 0x80,
		Wand = 0x100,
		MiningTool = 0x200,
		LumberingTool = 0x400,
		HerbingTool = 0x800,
		InvincibleHammer = 0x10000,
		DualSword = 0x20000,
		Claws = 0x40000,
		Blade = 0x60000,
		All = 0xFFFFFFFF
	}
}
