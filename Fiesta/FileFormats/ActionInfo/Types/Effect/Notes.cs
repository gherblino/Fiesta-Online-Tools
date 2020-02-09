using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace Fiesta.FileFormats.ActionInfo.Types.Effect
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Notes
	{
		public uint X { get; set; }
		public uint Y { get; set; }
		public uint Z { get; set; }

		public Notes(uint x, uint y, uint z)
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
