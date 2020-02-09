using System;
using System.ComponentModel;
using System.Globalization;

namespace Fiesta.FileFormats.Map.ShineMapData.Elements
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Fog
	{
		public decimal FogDepth { get; set; }
		public Color Color { get; set; }

		public Fog(string[] values, int linePos)
		{
			Color = new Color();

			if (values.Length != 5)
			{
				throw new System.Exception($"Please make sure there are only 5 arguments in line {linePos}! You have {values.Length} arguments!");
			}

			if (values[0] != "Fog")
			{
				throw new System.Exception($"Please make sure you have a proper GlobalLight header ({values[0]})!");
			}

			if (!decimal.TryParse(values[1], out decimal result))
			{
				throw new System.Exception($"Please make sure you have a proper value for FlogDepth in line {linePos} ({values[1]})!");
			}
			FogDepth = result;

			Color = Color.TryParse(values[2], values[3], values[4]);
		}

		public override string ToString()
		{
			return "";
		}
	}
}
