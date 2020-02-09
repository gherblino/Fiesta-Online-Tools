using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fiesta.FileFormats.Quest.Daily
{
    public enum DateMode : byte
    {
        YearTerm = 0x0,
        MonthTerm = 0x1,
        DateTerm = 0x2,
        Period = 0x3
    }
}
