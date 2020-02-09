using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SyncFiles
{
    public partial class Sync : Form
    {
        public string CurrentPath;
        public string RessystemPath;
        public string ShinePath;

        public Sync()
        {
            InitializeComponent();
		}

        private void Sync_Load(object sender, EventArgs e)
        {
            CurrentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + Path.DirectorySeparatorChar;
            RessystemPath = CurrentPath  + "ressystem";
            ShinePath = CurrentPath + "Shine";
        }

        private void selectRessystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
	        var openFileDialog = new FolderBrowserDialog();
	        var result = openFileDialog.ShowDialog();

	        if (result == DialogResult.OK)
	        {
		        RessystemPath = openFileDialog.SelectedPath;
				LogBox.AppendText("Path to ressystem has been set to: " + RessystemPath);
	        }
        }

        private void selectShineToolStripMenuItem_Click(object sender, EventArgs e)
        {
	        var openFileDialog = new FolderBrowserDialog();
	        var result = openFileDialog.ShowDialog();

	        if (result == DialogResult.OK)
	        {
		        ShinePath = openFileDialog.SelectedPath;
		        LogBox.AppendText("Path to Shine has been set to: " + ShinePath);
	        }
        }

		private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
