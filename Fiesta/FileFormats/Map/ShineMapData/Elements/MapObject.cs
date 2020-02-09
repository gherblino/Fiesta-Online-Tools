using System;
using System.ComponentModel;

namespace Fiesta.FileFormats.Map.ShineMapData.Elements
{
	public class MapObject : MapElement
	{
		public BindingList<Position> Positions { get; set; }

		public MapObject(string path) : base(path)
		{
			Positions = new BindingList<Position>();
		}

		public MapObject(string[] contents, int linePos)
		{
			Positions = new BindingList<Position>();

			string[] path = contents[linePos].Trim().Split(' ');

			if (path.Length != 2)
			{
				throw new System.Exception($"Please make sure there are only two arguments in line {linePos}! You have {path.Length} arguments!");
			}

			Path = path[0];

			if (!int.TryParse(path[1], out int total))
			{
				throw new System.Exception($"Please make sure the amount of files is a number ({path[1]})!");
			}

			for (int i = 0; i < total; i++)
			{
				linePos++;
				Positions.Add(new Position(contents[linePos].Trim().Split(' '), linePos));
			}
		}
	}
}
