using System;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel;
using System.IO;
using Fiesta.FileFormats.Quest;
using Fiesta.FileFormats.Quest.Daily;
using Fiesta.FileFormats.Player;
using Fiesta.FileFormats.Quest.Rewards;

namespace QuestEditor
{
	public partial class QuestEditor : Form
	{
		public QuestData QuestData;
		public Quest SelectedQuest;
        public BindingSource BindingSource;
		public string Path;
		public string FileName;
		public bool HasSelected;

		public QuestEditor()
		{
			InitializeComponent();
			QuestListBox.DisplayMember = "ID";
			QuestListBox.ValueMember = "ID";
			EnableComponents(false);
		}

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = @"SHN File (*.shn)|*.shn"
			};

			if (openFileDialog.ShowDialog() != DialogResult.OK) return;

			Path = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
			FileName = System.IO.Path.GetFileName(openFileDialog.FileName);

			HasSelected = true;

			QuestData = QuestData.Load(Path + System.IO.Path.DirectorySeparatorChar + FileName);

            BindingSource = new BindingSource {DataSource = QuestData.Quests};

            QuestListBox.DataSource = BindingSource;
            EnableComponents(true);
			UpdateSelectedQuest();
		}

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var saveFileDialog = new SaveFileDialog
			{
				Filter = @"SHN File (*.shn)|*.shn",
				Title = @"Save SHN file"
			};

			if (saveFileDialog.ShowDialog() != DialogResult.OK || saveFileDialog.FileName == "") return;

			using (var fs = (FileStream) saveFileDialog.OpenFile())
			{
				Path = System.IO.Path.GetDirectoryName(saveFileDialog.FileName);
				FileName = System.IO.Path.GetFileName(saveFileDialog.FileName);
				fs.Close();
				Save();
			}
		}

		private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QuestData = null;
			SelectedQuest = null;
			Path = null;
			FileName = null;
			HasSelected = false;
			QuestListBox.DataSource = new BindingList<Quest>();
			RewardDataGridView.DataSource = null;
			RewardDataGridView.Rows.Clear();
			EnableComponents(false);
		}

		private void DeleteAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QuestData.Quests.Clear();
			CleanAll();
		}

		/**
		 * Sets the 
		 */
		private void EnableComponents(bool value)
		{
			// Tool strip menu
			SaveToolStripMenuItem.Enabled = HasSelected && value;
			SaveAsToolStripMenuItem.Enabled = HasSelected && value;
			CloseToolStripMenuItem.Enabled = HasSelected && value;
			EditToolStripMenuItem.Enabled = HasSelected && value;
			DeleteAllToolStripMenuItem.Enabled = HasSelected && value;

			// Quest list
			SearchBox.Enabled = HasSelected && value;
			QuestListBox.Enabled = HasSelected && value;

			// Filter options
			SearchOptions.Enabled = HasSelected && value;
			CompareOptions.Enabled = HasSelected && value;

			EnableQuestComponents(value);
			ClearRewardBoxes();
		}

		private void EnableQuestComponents(bool value)
		{
			// Base info
			IsEnabledLabel.Enabled = HasSelected;
			IsEnabledBox.Enabled = HasSelected;
			IDLabel.Enabled = HasSelected && value;
			IDBox.Enabled = HasSelected && value;
			TitleLabel.Enabled = HasSelected && value;
			TitleBox.Enabled = HasSelected && value;
			DescriptionLabel.Enabled = HasSelected && value;
			DescriptionBox.Enabled = HasSelected && value;
			RegionLabel.Enabled = HasSelected && value;
			RegionBox.Enabled = HasSelected && value;
			QuestTypeLabel.Enabled = HasSelected && value;
			QuestTypeBox.Enabled = HasSelected && value;
			IsRepeatableLabel.Enabled = HasSelected && value;
			IsRepeatableBox.Enabled = HasSelected && value;
			IsDailyQuestLabel.Enabled = HasSelected && value;
			IsDailyQuestBox.Enabled = HasSelected && value;
			DailyQuestTypeLabel.Enabled = HasSelected && value;
			DailyQuestTypeBox.Enabled = HasSelected && value;

			// Save info
			StartIsInstantAcceptLabel.Enabled = HasSelected && value;
			StartIsInstantAcceptBox.Enabled = HasSelected && value;
			StartIsWaitListViewLabel.Enabled = HasSelected && value;
			StartIsWaitListViewBox.Enabled = HasSelected && value;
			StartIsWaitListProgressLabel.Enabled = HasSelected && value;
			StartIsWaitListProgressBox.Enabled = HasSelected && value;
			StartNeedsLevelLabel.Enabled = HasSelected && value;
			StartNeedsLevelBox.Enabled = HasSelected && value;
			StartMinLevelLabel.Enabled = HasSelected && value;
			StartMinLevelBox.Enabled = HasSelected && value;
			StartMaxLevelLabel.Enabled = HasSelected && value;
			StartMaxLevelBox.Enabled = HasSelected && value;
			StartNeedsNPCLabel.Enabled = HasSelected && value;
			StartNeedsNPCBox.Enabled = HasSelected && value;
			StartNPCIDLabel.Enabled = HasSelected && value;
			StartNPCIDBox.Enabled = HasSelected && value;
			StartNeedsItemLabel.Enabled = HasSelected && value;
			StartNeedsItemBox.Enabled = HasSelected && value;
			StartItemIDLabel.Enabled = HasSelected && value;
			StartItemIDBox.Enabled = HasSelected && value;
			StartItemLotLabel.Enabled = HasSelected && value;
			StartItemLotBox.Enabled = HasSelected && value;
			StartNeedsLocationLabel.Enabled = HasSelected && value;
			StartNeedsLocationBox.Enabled = HasSelected && value;
			StartLocationLabel.Enabled = HasSelected && value;
			StartLocationBox.Enabled = HasSelected && value;
			StartXLabel.Enabled = HasSelected && value;
			StartXBox.Enabled = HasSelected && value;
			StartYLabel.Enabled = HasSelected && value;
			StartYBox.Enabled = HasSelected && value;
			StartRangeLabel.Enabled = HasSelected && value;
			StartRangeBox.Enabled = HasSelected && value;
			StartUnkLabel.Enabled = HasSelected && value;
			StartUnkBox.Enabled = HasSelected && value;
			StartNeedsQuestLabel.Enabled = HasSelected && value;
			StartNeedsQuestBox.Enabled = HasSelected && value;
			StartPreviousQuestLabel.Enabled = HasSelected && value;
			StartPreviousQuestBox.Enabled = HasSelected && value;
			StartNeedsRaceLabel.Enabled = HasSelected && value;
			StartNeedsRaceBox.Enabled = HasSelected && value;
			StartRaceLabel.Enabled = HasSelected && value;
			StartRaceBox.Enabled = HasSelected && value;
			StartNeedsClassLabel.Enabled = HasSelected && value;
			StartNeedsClassBox.Enabled = HasSelected && value;
			StartClassLabel.Enabled = HasSelected && value;
			StartClassBox.Enabled = HasSelected && value;
			StartNeedsGenderLabel.Enabled = HasSelected && value;
			StartNeedsGenderBox.Enabled = HasSelected && value;
			StartGenderLabel.Enabled = HasSelected && value;
			StartGenderBox.Enabled = HasSelected && value;
			StartNeedsDateLabel.Enabled = HasSelected && value;
			StartNeedsDateBox.Enabled = HasSelected && value;
			StartDateModeLabel.Enabled = HasSelected && value;
			StartDateModeBox.Enabled = HasSelected && value;
			StartDateStartLabel.Enabled = HasSelected && value;
			StartDateStartBox.Enabled = HasSelected && value;
			StartDateEndLabel.Enabled = HasSelected && value;
			StartDateEndBox.Enabled = HasSelected && value;

			// End info
			EndIsInstantHandInLabel.Enabled = HasSelected && value;
			EndIsInstantHandInBox.Enabled = HasSelected && value;
			EndNeedsLevelLabel.Enabled = HasSelected && value;
			EndNeedsLevelBox.Enabled = HasSelected && value;
			EndLevelLabel.Enabled = HasSelected && value;
			EndLevelBox.Enabled = HasSelected && value;
			EndNeedsLocationLabel.Enabled = HasSelected && value;
			EndNeedsLocationBox.Enabled = HasSelected && value;
			EndLocationLabel.Enabled = HasSelected && value;
			EndLocationBox.Enabled = HasSelected && value;
			EndXLabel.Enabled = HasSelected && value;
			EndXBox.Enabled = HasSelected && value;
			EndYLabel.Enabled = HasSelected && value;
			EndYBox.Enabled = HasSelected && value;
			EndRangeLabel.Enabled = HasSelected && value;
			EndRangeBox.Enabled = HasSelected && value;
			EndUnkLabel.Enabled = HasSelected && value;
			EndUnkBox.Enabled = HasSelected && value;
			EndNeedsScenarioLabel.Enabled = HasSelected && value;
			EndNeedsScenarioBox.Enabled = HasSelected && value;
			EndScenarioIDLabel.Enabled = HasSelected && value;
			EndScenarioIDBox.Enabled = HasSelected && value;
			EndNeedsRaceLabel.Enabled = HasSelected && value;
			EndNeedsRaceBox.Enabled = HasSelected && value;
			EndRaceLabel.Enabled = HasSelected && value;
			EndRaceBox.Enabled = HasSelected && value;
			EndNeedsClassLabel.Enabled = HasSelected && value;
			EndNeedsClassBox.Enabled = HasSelected && value;
			EndClassLabel.Enabled = HasSelected && value;
			EndClassBox.Enabled = HasSelected && value;
			EndHasTimeLimitLabel.Enabled = HasSelected && value;
			EndHasTimeLimitBox.Enabled = HasSelected && value;
			EndTimeLimitLabel.Enabled = HasSelected && value;
			EndTimeLimitBox.Enabled = HasSelected && value;

			// Scripts
			StartScriptBox.Enabled = HasSelected && value;
			ActiveScriptBox.Enabled = HasSelected && value;
			EndScriptBox.Enabled = HasSelected && value;
		}

		private void InitializeQuests()
		{
			InitializeQuestComponents();
			UpdateQuestComponents();

			RewardDataGridView.SelectionChanged -= RewardDataGridView_SelectionChanged;
			// Set Use column of Reward
			useDataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(RewardUse));
			useDataGridViewTextBoxColumn.ValueType = typeof(RewardUse);

			// Set Type column of Reward
			typeDataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(RewardType));
			typeDataGridViewTextBoxColumn.ValueType = typeof(RewardType);

			RewardDataGridView.DataSource = SelectedQuest.Rewards;
			RewardDataGridView.SelectionChanged += RewardDataGridView_SelectionChanged;

			InitializeRewardBoxes();
		}

		private void UpdateQuestComponents()
		{
			// Update bindings for Base Info
			UpdateDaily(SelectedQuest.IsDailyQuest);
			UpdateStartLevel(SelectedQuest.StartCondition.NeedsLevel);
			UpdateStartNPC(SelectedQuest.StartCondition.NeedsNPC);
			UpdateStartItem(SelectedQuest.StartCondition.NeedsItem);
			UpdateStartLevel(SelectedQuest.StartCondition.NeedsLevel);
			UpdateStartLocation(SelectedQuest.StartCondition.NeedsLocation);
			UpdateStartPreviousQuest(SelectedQuest.StartCondition.NeedsPreviousQuest);
			UpdateStartRace(SelectedQuest.StartCondition.NeedsRace);
			UpdateStartClass(SelectedQuest.StartCondition.NeedsClass);
			UpdateStartGender(SelectedQuest.StartCondition.NeedsGender);
			UpdateStartDate(SelectedQuest.StartCondition.NeedsDate);

			// Update bindings for End Info
			UpdateEndLevel(SelectedQuest.EndCondition.NeedsLevel);
			UpdateEndLocation(SelectedQuest.EndCondition.NeedsLocation);
			UpdateEndScenario(SelectedQuest.EndCondition.NeedsScenario);
			UpdateEndRace(SelectedQuest.EndCondition.NeedsRace);
			UpdateEndClass(SelectedQuest.EndCondition.NeedsClass);
			UpdateEndTimeLimit(SelectedQuest.EndCondition.HasTimeLimit);
		}

		private void UpdateList()
		{
			if (!HasSelected)
			{
				return;
			}

			if (string.IsNullOrEmpty(SearchBox.Text))
			{
				QuestListBox.DataSource = QuestData.Quests;
			}

			else if (!string.IsNullOrEmpty(SearchOptions.Text))
			{
				ushort filter;
				switch (SearchOptions.Text ?? string.Empty)
				{
					case "ID":
						if (!ushort.TryParse(SearchBox.Text, out filter))
						{
							ShowWarning("Please give a correct input! (numeric ID between 0 and 65535)",
								"Incorrect input");
							SearchBox.Text = string.Empty;
						}

						switch (CompareOptions.Text ?? string.Empty)
						{
							case "Contains":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => q.ID.ToString().Contains(filter.ToString())).ToList();
								break;

							case "Not contains":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => !q.ID.ToString().Contains(filter.ToString())).ToList();
								break;

							case "Equals":
								QuestListBox.DataSource = QuestData.Quests.Where(q => q.ID == filter).ToList();
								break;

							case "Not equals":
								QuestListBox.DataSource = QuestData.Quests.Where(q => q.ID != filter).ToList();
								break;

							case "Larger than":
								QuestListBox.DataSource = QuestData.Quests.Where(q => q.ID > filter).ToList();
								break;

							case "Smaller than":
								QuestListBox.DataSource = QuestData.Quests.Where(q => q.ID < filter).ToList();
								break;
						}

						break;

					case "Title":
						switch (CompareOptions.Text ?? string.Empty)
						{
							case "Contains":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => q.Title.Text.Contains(SearchBox.Text)).ToList();
								break;

							case "Not contains":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => !q.Title.Text.Contains(SearchBox.Text)).ToList();
								break;

							case "Equals":
								QuestListBox.DataSource =
									QuestData.Quests.Where(q => q.Title.Text == SearchBox.Text).ToList();
								break;

							case "Not equals":
								QuestListBox.DataSource =
									QuestData.Quests.Where(q => q.Title.Text != SearchBox.Text).ToList();
								break;
						}

						break;

					case "Description":
						switch (CompareOptions.Text ?? string.Empty)
						{
							case "Contains":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => q.Description.Text.Contains(SearchBox.Text)).ToList();
								break;

							case "Not contains":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => !q.Description.Text.Contains(SearchBox.Text)).ToList();
								break;

							case "Equals":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => q.Description.Text == SearchBox.Text).ToList();
								break;

							case "Not equals":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => q.Description.Text != SearchBox.Text).ToList();
								break;
						}

						break;

					case "NPC ID":
						if (!ushort.TryParse(SearchBox.Text, out filter))
						{
							ShowWarning("Please give a correct input! (numeric ID smaller than 65536)",
								"Incorrect input");
							SearchBox.Text = string.Empty;
						}

						switch (CompareOptions.Text ?? string.Empty)
						{
							case "Contains":
								QuestListBox.DataSource = QuestData.Quests.Where(q =>
									q.StartCondition.NPC.ID.ToString().Contains(filter.ToString())).ToList();
								break;

							case "Not contains":
								QuestListBox.DataSource = QuestData.Quests.Where(q =>
									!q.StartCondition.NPC.ID.ToString().Contains(filter.ToString())).ToList();
								break;

							case "Equals":
								QuestListBox.DataSource = QuestData.Quests.Where(q => q.StartCondition.NPC.ID == filter)
									.ToList();
								break;

							case "Not equals":
								QuestListBox.DataSource = QuestData.Quests.Where(q => q.StartCondition.NPC.ID != filter)
									.ToList();
								break;

							case "Larger than":
								QuestListBox.DataSource = QuestData.Quests.Where(q => q.StartCondition.NPC.ID > filter)
									.ToList();
								break;

							case "Smaller than":
								QuestListBox.DataSource = QuestData.Quests.Where(q => q.StartCondition.NPC.ID < filter)
									.ToList();
								break;
						}

						break;

					case "NPC InxName":
						switch (CompareOptions.Text ?? string.Empty)
						{
							case "Contains":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => q.StartCondition.NPC.InxName.Contains(SearchBox.Text)).ToList();
								break;

							case "Not contains":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => !q.StartCondition.NPC.InxName.Contains(SearchBox.Text)).ToList();
								break;

							case "Equals":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => q.StartCondition.NPC.InxName == SearchBox.Text).ToList();
								break;

							case "Not equals":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => q.StartCondition.NPC.InxName != SearchBox.Text).ToList();
								break;
						}

						break;

					case "NPC Name":
						switch (CompareOptions.Text ?? string.Empty)
						{
							case "Contains":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => q.StartCondition.NPC.Name.Contains(SearchBox.Text)).ToList();
								break;

							case "Not contains":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => !q.StartCondition.NPC.Name.Contains(SearchBox.Text)).ToList();
								break;

							case "Equals":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => q.StartCondition.NPC.Name == SearchBox.Text).ToList();
								break;

							case "Not equals":
								QuestListBox.DataSource = QuestData.Quests
									.Where(q => q.StartCondition.NPC.Name != SearchBox.Text).ToList();
								break;
						}

						break;

					default:
						QuestListBox.DataSource = QuestData.Quests;
						break;
				}
			}
		}

		private void CleanAll()
		{
			StartScriptBox.Clear();
			ActiveScriptBox.Clear();
			EndScriptBox.Clear();
		}

		private void StoreRewards()
		{
			if (RewardDataGridView?.CurrentCell == null || SelectedQuest == null)
			{
				return;
			}

			var index = RewardDataGridView.CurrentCell.RowIndex;
			var qr = SelectedQuest.Rewards[index];

			switch (qr.Type)
			{
				case RewardType.Exp:
					qr.Value.Exp = (uint) ExpRewardBox.GetValue();
					break;

				case RewardType.Money:
					qr.Value.Money = (uint) MoneyRewardBox.GetValue();
					break;

				case RewardType.Item:
					qr.Value.Item.ID = (ushort) ItemIDRewardBox.GetValue();
					qr.Value.Item.Lot = (ushort) ItemLotRewardBox.GetValue();
					break;

				case RewardType.Abstate:
					qr.Value.Abstate.KeepTime = (uint) AbstateTimeRewardBox.GetValue();
					qr.Value.Abstate.ID = (ushort) AbstateIDRewardBox.GetValue();
					qr.Value.Abstate.Strength = (ushort) AbstateStrengthRewardBox.GetValue();
					break;

				case RewardType.Fame:
					qr.Value.Fame = (uint) FameRewardBox.GetValue();
					break;

				case RewardType.Pet:
					qr.Value.PetID = (uint) PetIDRewardBox.GetValue();
					break;

				case RewardType.MiniHouse:
					qr.Value.MiniHouseID = (byte) MiniHouseIDRewardBox.GetValue();
					break;

				case RewardType.Title:
					qr.Value.CharacterTitle.Type = (CharacterTitleType) TitleTypeRewardComboBox.SelectedIndex;
					qr.Value.CharacterTitle.ElementNo = (ushort) ElementNoRewardBox.GetValue();
					break;

				case RewardType.KillPoint:
					qr.Value.KillPoint = (uint) KillPointRewardBox.GetValue();
					break;

				default:
					return;
			}
		}

		private void StoreData()
		{
			// Base info
			SelectedQuest.StartCondition.IsEnabled = IsEnabledBox.Text == @"True";
			SelectedQuest.ID = (uint) IDBox.GetValue();
			SelectedQuest.Title.ID = (uint) TitleBox.GetValue();
			SelectedQuest.Description.ID = (uint) DescriptionBox.GetValue();
			SelectedQuest.Region = Convert.ToByte(RegionBox.GetValue());
			SelectedQuest.QuestType = (QuestType) QuestTypeBox.SelectedIndex;
			SelectedQuest.IsRepeatAble = IsRepeatableBox.Text == @"True";
			SelectedQuest.IsDailyQuest = IsDailyQuestBox.Text == @"True";
			SelectedQuest.DailyType = (DailyType) DailyQuestTypeBox.SelectedIndex;

			// Start info
			SelectedQuest.StartCondition.IsInstantAccept = StartIsInstantAcceptBox.Text == @"True";
			SelectedQuest.StartCondition.IsWaitListView = StartIsWaitListViewBox.Text == @"True";
			SelectedQuest.StartCondition.IsWaitListProgress = StartIsWaitListProgressBox.Text == @"True";
			SelectedQuest.StartCondition.NeedsLevel = StartNeedsLevelBox.Text == @"True";
			SelectedQuest.StartCondition.LevelMin = (byte) StartMinLevelBox.GetValue();
			SelectedQuest.StartCondition.LevelMax = (byte) StartMaxLevelBox.GetValue();
			SelectedQuest.StartCondition.NeedsNPC = StartNeedsNPCBox.Text == @"True";
			SelectedQuest.StartCondition.NPC.ID = (ushort) StartNPCIDBox.GetValue();
			SelectedQuest.StartCondition.NeedsItem = StartNeedsItemBox.Text == @"True";
			SelectedQuest.StartCondition.Item.ID = (ushort) StartItemIDBox.GetValue();
			SelectedQuest.StartCondition.Item.Lot = (ushort) StartItemLotBox.GetValue();
			SelectedQuest.StartCondition.NeedsLocation = StartNeedsLocationBox.Text == @"True";
			SelectedQuest.StartCondition.Location = (ushort) StartLocationBox.GetValue();
			SelectedQuest.StartCondition.LocationX = (uint) StartXBox.GetValue();
			SelectedQuest.StartCondition.LocationY = (uint) StartYBox.GetValue();
			SelectedQuest.StartCondition.LocationRange = (uint) StartRangeBox.GetValue();
			SelectedQuest.StartCondition.Unk3 = (int) StartUnkBox.GetValue();
			SelectedQuest.StartCondition.NeedsPreviousQuest = StartNeedsQuestBox.Text == @"True";
			SelectedQuest.StartCondition.PreviousQuestID = (ushort) StartPreviousQuestBox.GetValue();
			SelectedQuest.StartCondition.NeedsRace = StartNeedsRaceBox.Text == @"True";
			SelectedQuest.StartCondition.Race = (Race) StartRaceBox.SelectedIndex;
			SelectedQuest.StartCondition.NeedsClass = StartNeedsClassBox.Text == @"True";
			SelectedQuest.StartCondition.Class = (Class) StartClassBox.SelectedIndex;
			SelectedQuest.StartCondition.NeedsGender = StartNeedsGenderBox.Text == @"True";
			SelectedQuest.StartCondition.Gender = (Gender) StartGenderBox.SelectedIndex;
			SelectedQuest.StartCondition.NeedsDate = StartNeedsDateBox.Text == @"True";
			SelectedQuest.StartCondition.DateMode = (DateMode) StartDateModeBox.SelectedIndex;
			SelectedQuest.StartCondition.DateStart = (long) StartDateStartBox.GetValue();
			SelectedQuest.StartCondition.DateEnd = (long) StartDateEndBox.GetValue();

			// End info
			SelectedQuest.EndCondition.IsInstantHandIn = EndIsInstantHandInBox.Text == @"True";
			SelectedQuest.EndCondition.NeedsLevel = EndNeedsLevelBox.Text == @"True";
			SelectedQuest.EndCondition.Level = (byte) EndLevelBox.GetValue();
			SelectedQuest.EndCondition.NeedsLocation = EndNeedsLocationBox.Text == @"True";
			SelectedQuest.EndCondition.Location = (ushort) EndLocationBox.GetValue();
			SelectedQuest.EndCondition.LocationX = (uint) EndXBox.GetValue();
			SelectedQuest.EndCondition.LocationY = (uint) EndYBox.GetValue();
			SelectedQuest.EndCondition.LocationRange = (uint) EndRangeBox.GetValue();
			SelectedQuest.EndCondition.Unk7 = (int) EndUnkBox.GetValue();
			SelectedQuest.EndCondition.NeedsScenario = EndNeedsScenarioBox.Text == @"True";
			SelectedQuest.EndCondition.ScenarioID = (ushort) EndScenarioIDBox.GetValue();
			SelectedQuest.EndCondition.NeedsRace = EndNeedsRaceBox.Text == @"True";
			SelectedQuest.EndCondition.Race = (Race) EndRaceBox.SelectedIndex;
			SelectedQuest.EndCondition.NeedsClass = EndNeedsClassBox.Text == @"True";
			SelectedQuest.EndCondition.Class = (Class) EndClassBox.SelectedIndex;
			SelectedQuest.EndCondition.HasTimeLimit = EndHasTimeLimitBox.Text == @"True";
			SelectedQuest.EndCondition.TimeLimit = (ushort) EndTimeLimitBox.GetValue();

			// Scripts
			SelectedQuest.StartScript = StartScriptBox.Text;
			SelectedQuest.StartScriptSize = (ushort) (StartScriptBox.Text.Length + 1);

			SelectedQuest.DoingScript = ActiveScriptBox.Text;
			SelectedQuest.DoingScriptSize = (ushort) (ActiveScriptBox.Text.Length + 1);

			SelectedQuest.EndScript = EndScriptBox.Text;
			SelectedQuest.EndScriptSize = (ushort) (EndScriptBox.Text.Length + 1);

			// Rewards
			StoreRewards();
		}

		private void Save()
		{
			StoreData();

			QuestData.Save(Path, FileName);
		}

		private static void ShowWarning(string text, string title)
		{
			MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private static void ShowError(string text, string title)
		{
			MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		//TODO: Make it so it does not wipe entire input, but rather just blocks character
		private void IDBox_KeyDown(object sender, KeyEventArgs e)
		{
			
		}

		private void RewardDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{

		}

		//TODO: Figure out whether the tradeoff is worth it
		private void RewardDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
//			if (RewardDataGridView.EditingControl is DataGridViewComboBoxEditingControl editingControl)
//				editingControl.DroppedDown = true;
		}

		private void InitializeRewardBoxes()
		{
			if (SelectedQuest == null || RewardDataGridView.CurrentRow == null || RewardDataGridView.CurrentRow.Index >= RewardDataGridView.Rows.Count - 1)
				return;

			var index = RewardDataGridView.CurrentCell.RowIndex;
			var qrv = SelectedQuest.Rewards[index].Value;

			ExpRewardBox.Text = qrv.Exp.ToString();
			MoneyRewardBox.Text = qrv.Money.ToString();
			ItemIDRewardBox.Text = qrv.Item.ID.ToString();
			ItemLotRewardBox.Text = qrv.Item.Lot.ToString();
			AbstateIDRewardBox.Text = qrv.Abstate.ID.ToString();
			AbstateStrengthRewardBox.Text = qrv.Abstate.Strength.ToString();
			AbstateTimeRewardBox.Text = qrv.Abstate.KeepTime.ToString();
			FameRewardBox.Text = qrv.Fame.ToString();
			PetIDRewardBox.Text = qrv.PetID.ToString();
			MiniHouseIDRewardBox.Text = qrv.MiniHouseID.ToString();
			TitleTypeRewardComboBox.Text = qrv.CharacterTitle.Type.ToString();
			ElementNoRewardBox.Text = qrv.CharacterTitle.ElementNo.ToString();
			KillPointRewardBox.Text = qrv.KillPoint.ToString();
		}

		/**
		 * Clears the reward tab completely
		 */
		private void ClearRewardBoxes()
		{
			ExpRewardLabel.Enabled = false;
			ExpRewardBox.Enabled = false;
			ExpRewardBox.Text = @"0";
			MoneyRewardLabel.Enabled = false;
			MoneyRewardBox.Text = @"0";
			MoneyRewardBox.Enabled = false;
			ItemIDRewardLabel.Enabled = false;
			ItemIDRewardBox.Text = @"0";
			ItemIDRewardBox.Enabled = false;
			ItemLotRewardLabel.Enabled = false;
			ItemLotRewardBox.Text = @"0";
			ItemLotRewardBox.Enabled = false;
			AbstateIDRewardLabel.Enabled = false;
			AbstateIDRewardBox.Text = @"0";
			AbstateIDRewardBox.Enabled = false;
			AbstateStrengthRewardLabel.Enabled = false;
			AbstateStrengthRewardBox.Text = @"0";
			AbstateStrengthRewardBox.Enabled = false;
			AbstateTimeRewardLabel.Enabled = false;
			AbstateTimeRewardBox.Text = @"0";
			AbstateTimeRewardBox.Enabled = false;
			FameRewardLabel.Enabled = false;
			FameRewardBox.Text = @"0";
			FameRewardBox.Enabled = false;
			PetIDRewardLabel.Enabled = false;
			PetIDRewardBox.Text = @"0";
			PetIDRewardBox.Enabled = false;
			MiniHouseIDRewardLabel.Enabled = false;
			MiniHouseIDRewardBox.Text = @"0";
			MiniHouseIDRewardBox.Enabled = false;
			TitleTypeRewardLabel.Enabled = false;
			TitleTypeRewardComboBox.Text = ((CharacterTitleType)0).ToString();
			TitleTypeRewardComboBox.Enabled = false;
			ElementNoRewardLabel.Enabled = false;
			ElementNoRewardBox.Text = @"0";
			ElementNoRewardBox.Enabled = false;
			KillPointRewardLabel.Enabled = false;
			KillPointRewardBox.Text = @"0";
			KillPointRewardBox.Enabled = false;
		}

		/**
		 * Calls ClearRewardBoxes() and initiates the reward tab depending on the QuestRewardType of CurrentQuest
		 */
		//TODO: Make it so it fills in all the data from the QuestReward instead of just the selected option
		private void UpdateRewardBoxes()
		{
			ClearRewardBoxes();

			if (SelectedQuest == null || RewardDataGridView.CurrentRow == null)
			{
				return;
			}

			var index = RewardDataGridView.CurrentCell.RowIndex;
			var qr = SelectedQuest.Rewards[index];

			// If the current reward is disabled, we do nothing besides disable the controls
			if (qr.Use == RewardUse.Unused)
			{
				return;
			}

			switch (qr.Type)
			{
				case RewardType.Exp:
					ExpRewardLabel.Enabled = true;
					ExpRewardBox.Enabled = true;
					ExpRewardBox.Text = qr.Value.Exp.ToString();
					break;

				case RewardType.Money:
					MoneyRewardLabel.Enabled = true;
					MoneyRewardBox.Enabled = true;
					MoneyRewardBox.Text = qr.Value.Money.ToString();
					break;

				case RewardType.Item:
					ItemIDRewardLabel.Enabled = true;
					ItemIDRewardBox.Text = qr.Value.Item.ID.ToString();
					ItemIDRewardBox.Enabled = true;
					ItemLotRewardLabel.Enabled = true;
					ItemLotRewardBox.Text = qr.Value.Item.Lot.ToString();
					ItemLotRewardBox.Enabled = true;
					break;

				case RewardType.Abstate:
					AbstateIDRewardLabel.Enabled = true;
					AbstateTimeRewardBox.Text = qr.Value.Abstate.KeepTime.ToString();
					AbstateIDRewardBox.Enabled = true;
					AbstateStrengthRewardLabel.Enabled = true;
					AbstateIDRewardBox.Text = qr.Value.Abstate.ID.ToString();
					AbstateStrengthRewardBox.Enabled = true;
					AbstateTimeRewardLabel.Enabled = true;
					AbstateStrengthRewardBox.Text = qr.Value.Abstate.Strength.ToString();
					AbstateTimeRewardBox.Enabled = true;
					break;

				case RewardType.Fame:
					FameRewardLabel.Enabled = true;
					FameRewardBox.Text = qr.Value.Fame.ToString();
					FameRewardBox.Enabled = true;
					break;

				case RewardType.Pet:
					PetIDRewardLabel.Enabled = true;
					PetIDRewardBox.Text = qr.Value.PetID.ToString();
					PetIDRewardBox.Enabled = true;
					break;

				case RewardType.MiniHouse:
					MiniHouseIDRewardLabel.Enabled = true;
					MiniHouseIDRewardBox.Text = qr.Value.MiniHouseID.ToString();
					MiniHouseIDRewardBox.Enabled = true;
					break;

				case RewardType.Title:
					TitleTypeRewardLabel.Enabled = true;
					TitleTypeRewardComboBox.Text = qr.Value.CharacterTitle.Type.ToString();
					TitleTypeRewardComboBox.Enabled = true;
					ElementNoRewardLabel.Enabled = true;
					ElementNoRewardBox.Text = qr.Value.CharacterTitle.ElementNo.ToString();
					ElementNoRewardBox.Enabled = true;
					break;

				case RewardType.KillPoint:
					KillPointRewardLabel.Enabled = true;
					KillPointRewardBox.Text = qr.Value.KillPoint.ToString();
					KillPointRewardBox.Enabled = true;
					break;

				default:
					return;
			}
		}

		//TODO: Fix storing data after switching "tabs"
		private void RewardDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			UpdateRewardBoxes();
			StoreRewards();
		}

		private void RewardDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			UpdateRewardBoxes();
			RewardDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
		}

        private void DuplicateSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var copy = Quest.GetCopy(SelectedQuest);
            copy.ID = Quest.HighestID + 1;
            Quest.HighestID++;
            QuestData.Quests.Add(copy);
            QuestListBox.SelectedIndex = QuestData.Total - 1;
            SelectedQuest = copy;
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            SelectedQuest.ID = (uint) IDBox.GetValue();
            BindingSource.ResetBindings(false);
        }
    }
}