using System;
using System.ComponentModel;

namespace Fiesta.FileFormats.Map.ShineMapData.Elements
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class DirectionLightDiffuse
	{
		public Color Color { get; set; }

		public DirectionLightDiffuse(string[] contents, int linePos)
		{
			Color = new Color();

			if (contents.Length != 4)
			{
				throw new System.Exception($"Please make sure there are only 4 arguments in line {linePos}! You have {contents.Length} arguments!");
			}

			if (contents[0] != "DirectionLightDiffuse")
			{
				throw new System.Exception($"Please make sure you have a proper BackGroundColor header ({contents[0]})!");
			}

			Color = Color.TryParse(contents[1], contents[2], contents[3]);
		}

		public override string ToString()
		{
			return "";
		}
	}
}
