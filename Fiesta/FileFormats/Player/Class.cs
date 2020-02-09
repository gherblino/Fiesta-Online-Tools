using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fiesta.FileFormats.Player
{
    public enum Class : byte
    {
        None = 0x0,
        Fighter = 0x1,
        CleverFighter = 0x2,
        Warrior = 0x3,
        Gladiator = 0x4,
        Knight = 0x5,
        Cleric = 0x6,
        HighCleric = 0x7,
        Paladin = 0x8,
        HolyKnight = 0x9,
        Guardian = 0xA,
        Archer = 0xB,
        HawkArcher = 0xC,
        Scout = 0xD,
        SharpShooter = 0xE,
        Ranger = 0xF,
        Mage = 0x10,
        WizMage = 0x11,
        Enchanter = 0x12,
        Warlock = 0x13,
        Wizard = 0x14,
        Joker = 0x15,
        Chaser = 0x16,
        Cruel = 0x17,
        Closer = 0x18,
        Assassin = 0x19,
        Sentinel = 0x1A,
        Savior = 0x1B
    }
}
