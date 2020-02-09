using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fiesta.FileFormats.Quest.Conditions.EndCondition
{
    public enum NPCMobAction : byte
    {
        RewardObject = 0x0,
        Kill = 0x1,
        Find = 0x2,
        Conversation = 0x3
    }
}
