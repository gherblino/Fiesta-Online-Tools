using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropTableEditor.Models
{
    public class MobDropGroupEntry
    {
        public ItemGroup Group { get; set; }
        public decimal DropRate { get; set; }
        public int UpGradeMin { get; set; }
        public int UpGradeMax { get; set; }

        public MobDropGroupEntry(ItemGroup group, decimal dropRate, int upGradeMin, int upGradeMax)
        {
            Group = group;
            DropRate = dropRate;
            UpGradeMin = upGradeMin;
            UpGradeMax = upGradeMax;
        }
    }
}
