using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CleanFiles.Config;
using Newtonsoft.Json;
using Folder = CleanFiles.Config.Folder;

namespace CleanFiles
{
	public partial class CleanFiles : Form
	{
		public string CurrentPath;
		public string Settings;
		public JSONConfig Config;
		public Data Data;
		public ArrayList ToBeDeleted;

		public CleanFiles()
		{
			InitializeComponent();
		}

		private void CleanFiles_Load(object sender, EventArgs e)
		{
			LogBox.SelectionStart = LogBox.Text.Length;
			LogBox.ScrollToCaret();
			MarkButton.Enabled = false;
			CleanButton.Enabled = false;

			CurrentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +
						   Path.DirectorySeparatorChar;
			Settings = "Configuration.json";

			if (!File.Exists(CurrentPath + Settings))
			{
				GenerateJSONConfig(CurrentPath + Settings);
			}

			Config = JsonConvert.DeserializeObject<JSONConfig>(File.ReadAllText(CurrentPath + Settings));
			ToBeDeleted = new ArrayList();
		}

		private void UpdateButton()
		{
			MarkButton.Enabled = (IsCleaningClient.Checked || IsCleaningServer.Checked);
		}

		private void IsCleaningClient_CheckedChanged(object sender, EventArgs e)
		{
			CleanButton.Enabled = false;
			if (IsCleaningServer.Enabled)
			{
				IsCleaningServer.Checked = (!IsCleaningClient.Checked && IsCleaningServer.Checked);
			}

			UpdateButton();
		}

		private void IsCleaningServer_CheckedChanged(object sender, EventArgs e)
		{
			CleanButton.Enabled = false;
			if (IsCleaningClient.Enabled)
			{
				IsCleaningClient.Checked = (!IsCleaningServer.Checked && IsCleaningClient.Checked);
			}

			UpdateButton();
		}

		private void GenerateJSONConfig(string path)
		{
			var temp = File.Create(path);
			temp.Close();
			using (var file = new StreamWriter(path))
			{
				file.WriteLine(DefaultSettings.GetDefaultSettings());
				MessageBox.Show(
					Settings + @" was not found! The file has now been added and loaded with the default settings.");
			}
		}

		private void MarkButton_Click(object sender, EventArgs e)
		{
			LogBox.Text = string.Empty;
			Data = IsCleaningClient.Checked ? Config.ClientSettings : Config.ServerSettings;

			// First cleans current directory and then carries on to the sub folders
			StartCleaning();
			CleanManager("", Data.Folders);

			if (ToBeDeleted == null || ToBeDeleted.Count == 0)
			{
				LogBox.AppendText("Nothing has been marked.");
				return;
			}

			CleanButton.Enabled = ToBeDeleted != null && ToBeDeleted.Count > 0;
		}

		//TODO: Rename this method as it is not a manager technically
		private void CleanManager(string path, IEnumerable<Folder> folders)
		{
			var temp = path;
			foreach (var folder in folders)
			{
				temp += folder.FolderName + Path.DirectorySeparatorChar;

				folder.data.Files = folder.data.Files.ConvertAll(d => d.ToLower());
				StartCleaning(temp, folder);

				// Checks if there are sub folders, and if so, recursively calls CleanManager for the sub folders
				if (folder.data.Folders != null && folder.data.Folders.Count > 0)
				{
					CleanManager(temp, folder.data.Folders);
				}

				// Reset path
				temp = path;
			}
		}

		private void StartCleaning()
		{
			try
			{
				var files = Directory.GetFiles(CurrentPath, "*", SearchOption.TopDirectoryOnly);

				if (files.Length == 0)
				{
					return;
				}

				MarkFiles(files);
			}
			catch (Exception ex)
			{
				LogBox.AppendText(ex.ToString());
			}
		}

		private void StartCleaning(string path, Folder folder)
		{
			if (!Directory.Exists(path))
			{
				MessageBox.Show($@"Please check your Configuration.json file! \nPath: \{path}\ does not exist.");
				return;
			}

			try
			{
				var files = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly);

				if (files.Length == 0)
				{
					return;
				}

				MarkFiles(path, files, folder);
			}
			catch (Exception ex)
			{
				LogBox.AppendText(ex.ToString());
			}
		}

		private void MarkFiles(IEnumerable<string> files)
		{
			Data.Files = Data.Files.ConvertAll(d => d.ToLower());

			foreach (var file in files)
			{
				if (!Data.Files.Contains(Path.GetFileName(file.ToLower())))
				{
					AddDeletedFile(file, string.Empty);
				}
			}
		}

		private void MarkFiles(string path, IEnumerable<string> files, Folder folder)
		{
			foreach (var file in files)
			{
				if (!folder.data.Files.Contains(Path.GetFileName(file.ToLower())))
				{
					AddDeletedFile(file, path);
				}
			}
		}

		private void AddDeletedFile(string file, string path)
		{
			ToBeDeleted.Add(path + Path.GetFileName(file));

			if (ToBeDeleted.Count == 1)
			{
				LogBox.AppendText("The following files have been marked for deletion:" + Environment.NewLine +
								  Environment.NewLine);
			}

			@LogBox.AppendText(path + Path.GetFileName(file) + Environment.NewLine);
		}

		private void CleanButton_Click(object sender, EventArgs e)
		{
			LogBox.Text = string.Empty;

			if (ToBeDeleted == null || ToBeDeleted.Count == 0)
			{
				LogBox.AppendText("There is nothing to be deleted.");
			}
			else
			{
				var dialogResult =
					MessageBox.Show(@"Are you sure you would like to deleted the selected files?", @"Confirmation",
						MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					DeleteFiles();
				}
			}

            ToBeDeleted?.Clear();
            CleanButton.Enabled = false;
		}

		private void DeleteFiles()
		{
			ProgressBar.Maximum = ToBeDeleted.Count;
			ProgressBar.Step = 1;
			ProgressBar.Value = 0;

			foreach (string file in ToBeDeleted)
            {
                if (!File.Exists(file)) continue;

                // File exists
                try
                {
                    File.Delete(file);
                    LogBox.AppendText(file + " has been deleted." + Environment.NewLine);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show($@"Please close {Path.GetFileName(file)} before trying to delete it!");
                    LogBox.AppendText(@Path.GetFileName(file) + " has not been deleted." + Environment.NewLine);
                }
                finally
                {
                    ProgressBar.Increment(1);
                }
            }

			MessageBox.Show(@"The deletion has been completed.");
			ProgressBar.Value = ProgressBar.Maximum;
		}
	}
}