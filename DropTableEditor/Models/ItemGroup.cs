using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropTableEditor.Models
{
    public class ItemGroup
    {
        public string Index { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public int[] Upgrades = new int[16];
        public int Checksum { get { return Minimum + Maximum + Upgrades.Sum(); } }
        public BindingList<string> Items { get; set; }

        public ItemGroup(string index)
        {
            Index = index;
            Minimum = 1;
            Maximum = 1;
            Upgrades[0] = 1000;
            Items = new BindingList<string>();
        }

        public ItemGroup(DataRow groupRow)
        {
            Index = groupRow["ItemGroupIdx"].ToString();
            Minimum = Convert.ToInt32(groupRow["MinQtty"]);
            Maximum = Convert.ToInt32(groupRow["MaxQtty"]);

            for(int i = 0; i < 16; i++)
            {
                Upgrades[i] = Convert.ToInt32(groupRow[string.Format("Upgrade{0}", i.ToString("D2"))]);
            }

            Items = new BindingList<string>();
        }
    }
}
