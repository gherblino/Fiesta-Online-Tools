using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Fiesta.FileFormats.ActionInfo.Types.Effect
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Direction
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }

		public Direction(int x, int y, int z)
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
