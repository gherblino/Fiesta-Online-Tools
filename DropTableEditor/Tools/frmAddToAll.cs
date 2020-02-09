using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropTableEditor.Tools
{
    public partial class frmAddToAll : frmParent
    {
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public decimal DropRate { get; set; }

        public frmAddToAll()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GroupName = txtGroup.Text;
            MinLevel = Convert.ToInt32(nudMinLevel.Value);
            MaxLevel = Convert.ToInt32(nudMaxLevel.Value);
            DropRate = Convert.ToInt32(nudDropRate.Value);
        }

        private void nudMinLevel_ValueChanged(object sender, EventArgs e)
        {
            nudMaxLevel.Minimum = nudMinLevel.Value;
        }
    }
}
