using System;
using System.ComponentModel;
using Fiesta.FileFormats.Player;
using Fiesta.FileFormats.Quest;
using Fiesta.FileFormats.Quest.Daily;

namespace QuestEditor
{
    public partial class QuestEditor
    {
		/**
		 * Initializes Quest Components in the editor
		 */
		private void InitializeQuestComponents()
		{
			if (QuestListBox.SelectedItem == null)
			{
				return;
			}

			if (SelectedQuest != null)
			{
				StoreData();
			}

			SelectedQuest = (Quest)QuestListBox.SelectedItem;

			// CurrentQuest is not of type Quest
			if (SelectedQuest == null)
			{
				ShowError("Incorrect Quest", "An incorrect quest was found!");
				Environment.Exit(0);
			}

			/****************************************************************************************************/
			/**************************************** Base Info section *****************************************/
			/****************************************************************************************************/
			IsEnabledBox.DataSource = new BindingList<string> { "True", "False" };
			IsEnabledBox.SelectedItem = SelectedQuest.StartCondition.IsEnabled ? "True" : "False";

			IDBox.Text = SelectedQuest.ID.ToString();
			TitleBox.Text = SelectedQuest.Title.ID.ToString();
			DescriptionBox.Text = SelectedQuest.Description.ID.ToString();
			DescriptionLabel.Text = SelectedQuest.Description.Text;
			RegionBox.Text = SelectedQuest.Region.ToString();
			QuestTypeBox.DataSource = Enum.GetValues(typeof(QuestType));
			QuestTypeBox.SelectedItem = SelectedQuest.QuestType;

			IsRepeatableBox.DataSource = new BindingList<string> { "True", "False" };
			IsRepeatableBox.SelectedItem = SelectedQuest.IsRepeatAble ? "True" : "False";

			IsDailyQuestBox.DataSource = new BindingList<string> { "True", "False" };
			IsDailyQuestBox.SelectedItem = SelectedQuest.IsDailyQuest ? "True" : "False";
			DailyQuestTypeBox.DataSource = Enum.GetValues(typeof(DailyType));
			DailyQuestTypeBox.SelectedItem = SelectedQuest.DailyType;

			/****************************************************************************************************/
			/**************************************** Start Info section ****************************************/
			/****************************************************************************************************/
			StartIsInstantAcceptBox.DataSource = new BindingList<string> { "True", "False" };
			StartIsInstantAcceptBox.SelectedItem = SelectedQuest.StartCondition.IsInstantAccept ? "True" : "False";

			StartIsWaitListViewBox.DataSource = new BindingList<string> { "True", "False" };
			StartIsWaitListViewBox.SelectedItem = SelectedQuest.StartCondition.IsWaitListView ? "True" : "False";

			StartIsWaitListProgressBox.DataSource = new BindingList<string> { "True", "False" };
			StartIsWaitListProgressBox.SelectedItem = SelectedQuest.StartCondition.IsWaitListProgress ? "True" : "False";

			StartNeedsLevelBox.DataSource = new BindingList<string> { "True", "False" };
			StartNeedsLevelBox.SelectedItem = SelectedQuest.StartCondition.NeedsLevel ? "True" : "False";
			StartMinLevelBox.Text = SelectedQuest.StartCondition.LevelMin.ToString();
			StartMaxLevelBox.Text = SelectedQuest.StartCondition.LevelMax.ToString();

			StartNeedsNPCBox.DataSource = new BindingList<string> { "True", "False" };
			StartNeedsNPCBox.SelectedItem = SelectedQuest.StartCondition.NeedsNPC ? "True" : "False";
			StartNPCIDBox.Text = SelectedQuest.StartCondition.NPC.ID.ToString();

			StartNeedsItemBox.DataSource = new BindingList<string> { "True", "False" };
			StartNeedsItemBox.SelectedItem = SelectedQuest.StartCondition.NeedsItem ? "True" : "False";
			StartItemIDBox.Text = SelectedQuest.StartCondition.Item.ID.ToString();
			StartItemLotBox.Text = SelectedQuest.StartCondition.Item.Lot.ToString();

			StartNeedsLevelBox.DataSource = new BindingList<string> { "True", "False" };
			StartNeedsLevelBox.SelectedItem = SelectedQuest.StartCondition.NeedsLevel ? "True" : "False";
			StartMaxLevelBox.Text = SelectedQuest.StartCondition.LevelMax.ToString();

			StartNeedsLocationBox.DataSource = new BindingList<string> { "True", "False" };
			StartNeedsLocationBox.SelectedItem = SelectedQuest.StartCondition.NeedsLocation ? "True" : "False";
			StartLocationBox.Text = SelectedQuest.StartCondition.Location.ToString();
			StartXBox.Text = SelectedQuest.StartCondition.LocationX.ToString();
			StartYBox.Text = SelectedQuest.StartCondition.LocationY.ToString();
			StartRangeBox.Text = SelectedQuest.StartCondition.LocationRange.ToString();
			StartUnkBox.Text = SelectedQuest.StartCondition.Unk3.ToString();

			StartNeedsQuestBox.DataSource = new BindingList<string> { "True", "False" };
			StartNeedsQuestBox.SelectedItem = SelectedQuest.StartCondition.NeedsPreviousQuest ? "True" : "False";
			StartPreviousQuestBox.Text = SelectedQuest.StartCondition.PreviousQuestID.ToString();

			StartNeedsRaceBox.DataSource = new BindingList<string> { "True", "False" };
			StartNeedsRaceBox.SelectedItem = SelectedQuest.StartCondition.NeedsRace ? "True" : "False";
			StartRaceBox.DataSource = Enum.GetValues(typeof(Race));
			StartRaceBox.Text = SelectedQuest.StartCondition.Race.ToString();

			StartNeedsClassBox.DataSource = new BindingList<string> { "True", "False" };
			StartNeedsClassBox.SelectedItem = SelectedQuest.StartCondition.NeedsClass ? "True" : "False";
			StartClassBox.DataSource = Enum.GetValues(typeof(Class));
			StartClassBox.Text = SelectedQuest.StartCondition.Class.ToString();

			StartNeedsGenderBox.DataSource = new BindingList<string> { "True", "False" };
			StartNeedsGenderBox.SelectedItem = SelectedQuest.StartCondition.NeedsGender ? "True" : "False";
			StartGenderBox.DataSource = Enum.GetValues(typeof(Gender));
			StartGenderBox.Text = SelectedQuest.StartCondition.Gender.ToString();

			StartNeedsDateBox.DataSource = new BindingList<string> { "True", "False" };
			StartNeedsDateBox.SelectedItem = SelectedQuest.StartCondition.NeedsDate ? "True" : "False";
			StartDateModeBox.DataSource = Enum.GetValues(typeof(DateMode));
			StartDateModeBox.Text = SelectedQuest.StartCondition.DateMode.ToString();

			/****************************************************************************************************/
			/**************************************** End Info section ******************************************/
			/****************************************************************************************************/
			EndIsInstantHandInBox.DataSource = new BindingList<string> { "True", "False" };
			EndIsInstantHandInBox.SelectedItem = SelectedQuest.EndCondition.IsInstantHandIn ? "True" : "False";

			EndNeedsLevelBox.DataSource = new BindingList<string> { "True", "False" };
			EndNeedsLevelBox.SelectedItem = SelectedQuest.EndCondition.NeedsLevel ? "True" : "False";
			EndLevelBox.Text = SelectedQuest.EndCondition.Level.ToString();

			EndNeedsLocationBox.DataSource = new BindingList<string> { "True", "False" };
			EndNeedsLocationBox.SelectedItem = SelectedQuest.EndCondition.NeedsLocation ? "True" : "False";
			EndLocationBox.Text = SelectedQuest.EndCondition.Location.ToString();
			EndXBox.Text = SelectedQuest.EndCondition.LocationX.ToString();
			EndYBox.Text = SelectedQuest.EndCondition.LocationY.ToString();
			EndRangeBox.Text = SelectedQuest.EndCondition.LocationRange.ToString();
			EndUnkBox.Text = SelectedQuest.EndCondition.Unk7.ToString();

			EndNeedsScenarioBox.DataSource = new BindingList<string> { "True", "False" };
			EndNeedsScenarioBox.SelectedItem = SelectedQuest.EndCondition.NeedsScenario ? "True" : "False";
			EndScenarioIDBox.Text = SelectedQuest.EndCondition.ScenarioID.ToString();

			EndNeedsRaceBox.DataSource = new BindingList<string> { "True", "False" };
			EndNeedsRaceBox.SelectedItem = SelectedQuest.EndCondition.NeedsRace ? "True" : "False";
			EndRaceBox.DataSource = Enum.GetValues(typeof(Race));
			EndRaceBox.Text = SelectedQuest.EndCondition.Race.ToString();

			EndNeedsClassBox.DataSource = new BindingList<string> { "True", "False" };
			EndNeedsClassBox.SelectedItem = SelectedQuest.EndCondition.NeedsClass ? "True" : "False";
			EndClassBox.DataSource = Enum.GetValues(typeof(Class));
			EndClassBox.Text = SelectedQuest.EndCondition.Class.ToString();

			EndHasTimeLimitBox.DataSource = new BindingList<string> { "True", "False" };
			EndHasTimeLimitBox.SelectedItem = SelectedQuest.EndCondition.HasTimeLimit ? "True" : "False";
			EndTimeLimitBox.Text = SelectedQuest.EndCondition.TimeLimit.ToString();

			/****************************************************************************************************/
			/******************************************** Script Tabs *******************************************/
			/****************************************************************************************************/
			StartScriptBox.Text = SelectedQuest.StartScript;
			ActiveScriptBox.Text = SelectedQuest.DoingScript;
			EndScriptBox.Text = SelectedQuest.EndScript;
		}

		/**********************************************************************************************/
		/*************************************** Default editor ***************************************/
		/**********************************************************************************************/

		private void SearchBox_TextChanged(object sender, EventArgs e)
		{
			UpdateList();
		}

		private void SearchOptions_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateList();
		}

        public void UpdateSelectedQuest()
        {
            InitializeQuests();
            UpdateEnabled(((Quest)QuestListBox.SelectedItem).StartCondition.IsEnabled);
            RewardDataGridView.DataSource = SelectedQuest.Rewards;
            RewardDataGridView.Rows[0].Selected = true;
            RewardDataGridView.CurrentCell = RewardDataGridView.Rows[0].Cells[0];
        }

		private void QuestListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateSelectedQuest();
		}

		/**********************************************************************************************/
        /*************************************** Base Info ********************************************/
		/**********************************************************************************************/
		private void UpdateEnabled(bool value)
		{
			EnableQuestComponents(value);

			if (value)
			{
				UpdateQuestComponents();
			}
		}

		private void IsEnabledBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateEnabled(IsEnabledBox.GetItemText(IsEnabledBox.SelectedItem) == "True");
		}

		private void UpdateDaily(bool value)
		{
			if (!HasSelected)
				value = false;

			DailyQuestTypeLabel.Enabled = value;
			DailyQuestTypeBox.Enabled = value;
		}

		private void IsDailyQuestBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateDaily(IsDailyQuestBox.GetItemText(IsDailyQuestBox.SelectedItem) == "True");
		}

		/**********************************************************************************************/
		/*************************************** Start Info *******************************************/
		/**********************************************************************************************/
		private void UpdateStartLevel(bool value)
		{
			if (!HasSelected)
				value = false;

			StartMinLevelLabel.Enabled = value;
			StartMinLevelBox.Enabled = value;
			StartMaxLevelLabel.Enabled = value;
			StartMaxLevelBox.Enabled = value;
		}

		private void StartNeedsLevelBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateStartLevel(StartNeedsLevelBox.GetItemText(StartNeedsLevelBox.SelectedItem) == "True");
		}

		private void UpdateStartNPC(bool value)
		{
			if (!HasSelected)
				value = false;

			StartNPCIDLabel.Enabled = value;
			StartNPCIDBox.Enabled = value;
		}

		private void StartNeedsNPCBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateStartNPC(StartNeedsNPCBox.GetItemText(StartNeedsNPCBox.SelectedItem) == "True");
		}

		private void UpdateStartItem(bool value)
		{
			if (!HasSelected)
				value = false;

			StartItemIDLabel.Enabled = value;
			StartItemIDBox.Enabled = value;
			StartItemLotLabel.Enabled = value;
			StartItemLotBox.Enabled = value;
		}

		private void StartNeedsItemBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateStartItem(StartNeedsItemBox.GetItemText(StartNeedsItemBox.SelectedItem) == "True");
		}

		private void UpdateStartLocation(bool value)
		{
			if (!HasSelected)
				value = false;

			StartLocationLabel.Enabled = value;
			StartLocationBox.Enabled = value;
			StartXLabel.Enabled = value;
			StartXBox.Enabled = value;
			StartYLabel.Enabled = value;
			StartYBox.Enabled = value;
			StartRangeLabel.Enabled = value;
			StartRangeBox.Enabled = value;
			StartUnkLabel.Enabled = value;
			StartUnkBox.Enabled = value;
		}

		private void StartNeedsLocationBox_SelectionChangeCommitted(object sStarter, EventArgs e)
		{
			UpdateStartLocation(StartNeedsLocationBox.GetItemText(StartNeedsLocationBox.SelectedItem) == "True");
		}

		private void UpdateStartPreviousQuest(bool value)
		{
			if (!HasSelected)
				value = false;

			StartPreviousQuestLabel.Enabled = value;
			StartPreviousQuestBox.Enabled = value;
		}

		private void StartNeedsQuestBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateStartPreviousQuest(StartNeedsQuestBox.GetItemText(StartNeedsQuestBox.SelectedItem) == "True");
		}

		private void UpdateStartRace(bool value)
		{
			if (!HasSelected)
				value = false;

			StartRaceLabel.Enabled = value;
			StartRaceBox.Enabled = value;
		}

		private void StartNeedsRaceBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateStartRace(StartNeedsRaceBox.GetItemText(StartNeedsRaceBox.SelectedItem) == "True");
		}

		private void UpdateStartClass(bool value)
		{
			if (!HasSelected)
				value = false;

			StartClassLabel.Enabled = value;
			StartClassBox.Enabled = value;
		}

		private void StartNeedsClassBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateStartClass(StartNeedsClassBox.GetItemText(StartNeedsClassBox.SelectedItem) == "True");
		}

		private void UpdateStartGender(bool value)
		{
			if (!HasSelected)
				value = false;

			StartGenderLabel.Enabled = value;
			StartGenderBox.Enabled = value;
		}

		private void StartNeedsGenderBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateStartGender(StartNeedsGenderBox.GetItemText(StartNeedsGenderBox.SelectedItem) == "True");
		}

		private void UpdateStartDate(bool value)
		{
			if (!HasSelected)
				value = false;

			StartDateModeLabel.Enabled = value;
			StartDateModeBox.Enabled = value;
			StartDateStartLabel.Enabled = value;
			StartDateStartBox.Enabled = value;
			StartDateEndLabel.Enabled = value;
			StartDateEndBox.Enabled = value;
		}

		private void StartNeedsDateBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateStartDate(StartNeedsDateBox.GetItemText(StartNeedsDateBox.SelectedItem) == "True");
		}

		/**********************************************************************************************/
		/*************************************** End Info *********************************************/
		/**********************************************************************************************/
		private void UpdateEndLevel(bool value)
		{
			if (!HasSelected)
				value = false;

			EndLevelLabel.Enabled = value;
			EndLevelBox.Enabled = value;
		}

		private void EndNeedsLevelBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateEndLevel(EndNeedsLevelBox.GetItemText(EndNeedsLevelBox.SelectedItem) == "True");
		}

		private void UpdateEndLocation(bool value)
		{
			if (!HasSelected)
				value = false;

			EndLocationLabel.Enabled = value;
			EndLocationBox.Enabled = value;
			EndXLabel.Enabled = value;
			EndXBox.Enabled = value;
			EndYLabel.Enabled = value;
			EndYBox.Enabled = value;
			EndRangeLabel.Enabled = value;
			EndRangeBox.Enabled = value;
			EndUnkLabel.Enabled = value;
			EndUnkBox.Enabled = value;
		}

		private void EndNeedsLocationBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateEndLocation(EndNeedsLocationBox.GetItemText(EndNeedsLocationBox.SelectedItem) == "True");
		}

		private void UpdateEndScenario(bool value)
		{
			if (!HasSelected)
				value = false;

			EndScenarioIDLabel.Enabled = value;
			EndScenarioIDBox.Enabled = value;
		}

		private void EndNeedsScenarioBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateEndScenario(EndNeedsScenarioBox.GetItemText(EndNeedsScenarioBox.SelectedItem) == "Trye");
		}

		private void UpdateEndRace(bool value)
		{
			if (!HasSelected)
				value = false;

			EndRaceLabel.Enabled = value;
			EndRaceBox.Enabled = value;
		}

		private void EndNeedsRaceBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateEndRace(EndNeedsRaceBox.GetItemText(EndNeedsRaceBox.SelectedItem) == "True");
		}

		private void UpdateEndClass(bool value)
		{
			if (!HasSelected)
				value = false;

			EndClassLabel.Enabled = value;
			EndClassBox.Enabled = value;
		}

		private void EndNeedsClassBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateEndClass(EndNeedsClassBox.GetItemText(EndNeedsClassBox.SelectedItem) == "True");
		}

		private void UpdateEndTimeLimit(bool value)
		{
			if (!HasSelected)
				value = false;

			EndTimeLimitLabel.Enabled = value;
			EndTimeLimitBox.Enabled = value;
		}

		private void EndHasTimeLimitBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateEndTimeLimit(EndHasTimeLimitBox.GetItemText(EndHasTimeLimitBox.SelectedItem) == "True");
		}
	}
}