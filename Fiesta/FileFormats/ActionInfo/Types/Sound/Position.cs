using System.ComponentModel;

namespace Fiesta.FileFormats.ActionInfo.Types.Sound
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Position
	{
		public uint X { get; set; }
		public uint Y { get; set; }

		public Position(uint x, uint y)
		{
			X = x;
			Y = y;
		}

		public override string ToString()
		{
			return "";
		}
	}
}
