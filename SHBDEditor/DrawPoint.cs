using System.Drawing;

namespace SHBDEditor
{
	public class DrawPoint
	{
		public float X;
		public float Y;
		public Color color;
		public float brushSize;

		public DrawPoint(float x, float y, Color color, float brushSize)
		{
			X = x;
			Y = y;
			this.color = color;
			this.brushSize = brushSize;
		}
	}
}
