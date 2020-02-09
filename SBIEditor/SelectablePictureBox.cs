using System;
using System.Windows.Forms;
using Fiesta.FileFormats.Map.ShineBlockInfo;

//TODO: Move this and NumberBox to a separate project? Maybe move this to a separate project?
namespace SBIEditor
{
	internal sealed class SelectablePictureBox : PictureBox
	{
		public MapDoorBlockElement MBE { get; set; }
		public int CurrentX;
		public int CurrentY;

		public event EventHandler UpdatedLocation;
		public event EventHandler UpdatedSelected;

		public SelectablePictureBox()
		{
			SetStyle(ControlStyles.Selectable, true);
			TabStop = true;
			Cursor = Cursors.Hand;
			DoubleBuffered = true;
			BackgroundImageLayout = ImageLayout.Stretch;
		}

		public SelectablePictureBox(MapDoorBlockElement mbe) : this()
		{
			MBE = mbe;
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			UpdatedSelected?.Invoke(this, null);
			Focus();

			CurrentX = e.X;
			CurrentY = e.Y;
		}

		//TODO: Fix and make it so it takes the zoom scale into account
		protected override void OnMouseMove(MouseEventArgs e)
		{
			var x = e.X;
			var y = e.Y;
			
			base.OnMouseMove(e);

			if (MouseButtons.Left != e.Button) return;

			var dx = (x - CurrentX);
			var dy = (y - CurrentY);

			Top			+= dy;
			Left		+= dx;

			MBE.StartX	+= (uint)dx;
			MBE.EndX	+= (uint)dx;
			MBE.StartY	-= (uint)dy;
			MBE.EndY	-= (uint)dy;
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);

			UpdatedLocation?.Invoke(this, null);
			Focus();
		}

		protected override void OnEnter(EventArgs e)
		{
			base.OnEnter(e);
			Invalidate();
		}

		protected override void OnLeave(EventArgs e)
		{
			base.OnLeave(e);
			Invalidate();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);

			if (!Focused) return;

			var rc = ClientRectangle;
			rc.Inflate(-2, -2);
			ControlPaint.DrawFocusRectangle(pe.Graphics, rc);
		}
	}
}
