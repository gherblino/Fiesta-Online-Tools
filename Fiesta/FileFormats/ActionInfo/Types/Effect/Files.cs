using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace Fiesta.FileFormats.ActionInfo.Types.Effect
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Files
	{
		public string String1 { get; set; }
		public string String2 { get; set; }
		public string String3 { get; set; }

		public Files(string string1, string string2, string string3)
		{
			String1 = string1;
			String2 = string2;
			String3 = string3;
		}

		public override string ToString()
		{
			return "";
		}
	}
}
