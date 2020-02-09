using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DropTableEditor.Models
{
    public class Mob
    {
        public BindingList<MobDropGroupEntry> DropGroups { get; set; }
        public string InxName { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public byte MobLevel { get; set; }
        public int MinCen { get; set; }
        public int MaxCen { get; set; }
        public decimal CenRate { get; set; }
    }
}
