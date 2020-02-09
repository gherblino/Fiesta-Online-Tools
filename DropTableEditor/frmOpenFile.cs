using DropTableEditor.Shine;
using DropTableEditor.SHN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropTableEditor
{
    public partial class frmOpenFile : Form
    {
        public ShnFile MobInfo { get; set; }
        public ShnFile ItemInfoServer { get; set; }
        public ShineFile ItemDropGroup { get; set; }
        public ShineFile ItemDropTable { get; set; }

        public frmOpenFile()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                MobInfo = new ShnFile(txtMobInfo.Text);
                ItemInfoServer = new ShnFile(txtItemInfoServer.Text);
                ItemDropGroup = new ShineFile(txtDropGroup.Text);
                ItemDropTable = new ShineFile(txtDropTable.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to open file");
            }
        }

        private string openFileDialog()
        {
            using (var dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    return dlg.FileName;
                }
                return "error";
            }
        }

        private void btnBrowseDropTable_Click(object sender, EventArgs e)
        {
            txtDropTable.Text = openFileDialog();
        }

        private void btnBrowseDropGroup_Click(object sender, EventArgs e)
        {
            txtDropGroup.Text = openFileDialog();
        }

        private void btnBrowseItemInfoServer_Click(object sender, EventArgs e)
        {
            txtItemInfoServer.Text = openFileDialog();
        }

        private void btnBrowseMobInfo_Click(object sender, EventArgs e)
        {
            txtMobInfo.Text = openFileDialog();
        }
    }
}
