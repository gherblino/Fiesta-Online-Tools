using System.ComponentModel;

namespace Fiesta.FileFormats.ActionInfo.Types.Effect
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Position
	{
		public uint X { get; set; }
		public uint Y { get; set; }
		public uint Z { get; set; }

		public Position(uint x, uint y, uint z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public override string ToString()
		{
			return "";
		}
	}
}
