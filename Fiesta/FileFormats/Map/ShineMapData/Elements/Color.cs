using System;
using System.ComponentModel;

namespace Fiesta.FileFormats.Map.ShineMapData.Elements
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Color
	{
		public decimal Red { get; set; }
		public decimal Green { get; set; }
		public decimal Blue { get; set; }

		public static Color TryParse(string red, string green, string blue)
		{
			Color color = new Color();

			if (!decimal.TryParse(red, out decimal temp))
			{
				throw new System.Exception($"Please make sure the red value is a number ({red})!");
			}

			color.Red = temp;

			if (!decimal.TryParse(green, out temp))
			{
				throw new System.Exception($"Please make sure the green value is a number ({green})!");
			}

			color.Green = temp;

			if (!decimal.TryParse(blue, out temp))
			{
				throw new System.Exception($"Please make sure the blue value is a number ({blue})!");
			}

			color.Blue = temp;

			return color;
		}

		public override string ToString()
		{
			return "";
		}
	}
}
