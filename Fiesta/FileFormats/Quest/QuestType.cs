using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fiesta.FileFormats.Quest
{
    public enum QuestType : byte
    {
        Normal = 0x0,
        Story = 0x1,
        Class = 0x2,
        Event = 0x3,
        InstanceDungeon = 0x4,
        NormalParty = 0x5,
        Epic = 0x6,
        EpicParty = 0x7,
        Raid = 0x8,
        Chaos = 0x9,
        Daily = 0xA,
        MaxQuestType = 0xB
    }
}
