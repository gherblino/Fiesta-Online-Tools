using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fiesta.FileFormats.Quest.Daily
{
    public enum DailyType : byte
    {
        None = 0x0,
        Day = 0x1,
        Week = 0x2,
        Month = 0x3,
        Year = 0x4,
        Max = 0x5
    }
}
