using System;
using System.ComponentModel;
using System.Globalization;

namespace Fiesta.FileFormats.Map.ShineMapData.Elements
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Frustum
	{
		public decimal FrustumFar { get; set; }

		public Frustum(string[] contents, int linePos)
		{
			if (contents.Length != 2)
			{
				throw new System.Exception($"Please make sure there are only two arguments in line {linePos}! You have {contents.Length} arguments!");
			}

			if (contents[0] != "Frustum")
			{
				throw new System.Exception($"Please make sure you have a proper Frustum header ({contents[0]})!");
			}

			if ((!decimal.TryParse(contents[1],	out decimal result)))
			{
				throw new System.Exception($"Please make sure the Frustum value in line {linePos} is a number ({contents[1]})!");
			}

			FrustumFar = result > 20000 ? 20000 : result;
		}

		public override string ToString()
		{
			return "";
		}
	}
}
