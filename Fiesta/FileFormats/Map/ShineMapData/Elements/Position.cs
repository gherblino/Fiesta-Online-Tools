using System;
using System.ComponentModel;
using System.Globalization;

namespace Fiesta.FileFormats.Map.ShineMapData.Elements
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Position
	{
		public decimal X { get; set; }
		public decimal Y { get; set; }
		public decimal Z { get; set; }
		public decimal Unk { get; set; }
		public decimal Yaw { get; set; }
		public decimal Pitch { get; set; }
		public decimal Roll { get; set; }
		public decimal Scale { get; set; }

		public Position()
		{
			X = Y = Z = Unk = Yaw = Pitch = Roll = 0;
			Scale = 1;
		}

		public Position(string[] contents, int linePos)
		{
			if (contents.Length != 8)
			{
				throw new System.Exception($"Please make sure there are only eight arguments in line {linePos}! You have {contents.Length} arguments!");

			}
			X = ParseFloat(contents, linePos, 0);
			Y = ParseFloat(contents, linePos, 1);
			Z = ParseFloat(contents, linePos, 2);
			Unk = ParseFloat(contents, linePos, 3);
			Yaw = ParseFloat(contents, linePos, 4);
			Pitch =  ParseFloat(contents, linePos, 5);
			Roll = ParseFloat(contents, linePos, 6);
			Scale = ParseFloat(contents, linePos, 7);
		}

		public decimal ParseFloat(string[] contents, int linePos, int n)
		{
			if (!decimal.TryParse(contents[n], out decimal input))
			{
				throw new System.Exception($"Please make sure there are only numbers in line {linePos} ({contents[n].Replace('.', ',')})!");
			}

			return input;
		}

		public override string ToString()
		{
			return "";
		}
	}
}
