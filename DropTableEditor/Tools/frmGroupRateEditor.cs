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
    public partial class frmGroupRateEditor : frmParent
    {
        public decimal Value { get; set; }

        public frmGroupRateEditor()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            GroupName = txtGroupName.Text;
            Value = nudValue.Value;
        }
    }
}
