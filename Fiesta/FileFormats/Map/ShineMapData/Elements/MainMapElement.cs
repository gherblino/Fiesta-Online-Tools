using System;
using System.ComponentModel;

namespace Fiesta.FileFormats.Map.ShineMapData.Elements
{
	public class MainMapElement
	{
		public BindingList<MapElement> MapElements;

		public MainMapElement(string type, string[] contents, int linePos)
		{
			string[] mme = contents[linePos].Trim().Split(' ');

			if (mme.Length != 2)
			{
				throw new System.Exception($"Please make sure there are only two arguments in line {linePos}! You have {mme.Length} arguments!");
			}

			linePos++;

			if (mme[0] != type)
			{
				throw new System.Exception($"Please make sure you have a proper {type} header ({mme[0]})!");
			}

			if (!int.TryParse(mme[1], out int total))
			{
				throw new System.Exception($"Please make sure the amount of files is a number ({mme[1]})!");
			}

			MapElements = new BindingList<MapElement>();

			for (int i = 0; i < total; i++)
			{
				MapElements.Add(new MapElement()
				{
					Path = contents[linePos]
				});

				linePos++;
			}
		}

		public override string ToString()
		{
			return "";
		}
	}
}
