using System;
using System.ComponentModel;
using Fiesta.FileFormats.Map.AreaInfoData;

//TODO: Refactor this and group stuff together
namespace MapBlockEditor
{
    partial class MapBlockEditor
    {
	    private void InitializeAID()
	    {
		    AIDListBox.DisplayMember = "Name";
		    AIDListBox.ValueMember = "Name";
		    AIDListBox.DataSource = MBI.AID.Data;
		    AIDPropertyGrid.ExpandAllGridItems();
		}

	    private void AIDListBox_SelectedIndexChanged(object sender, EventArgs e)
	    {
		    if (AIDListBox.SelectedItem == null)
		    {
			    return;
		    }

		    var aid = (AreaInfoData)AIDListBox.SelectedItem;
		    aid.PropertyChanged += AID_PropertyChanged;

		    AIDPropertyGrid.SelectedObject = aid;
		    AIDPropertyGrid.ExpandAllGridItems();
	    }

	    private void AID_PropertyChanged(object sender, PropertyChangedEventArgs e)
	    {
		    AIDPropertyGrid.Refresh();
	    }
	}
}
