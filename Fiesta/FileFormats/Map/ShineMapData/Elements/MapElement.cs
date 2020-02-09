namespace Fiesta.FileFormats.Map.ShineMapData.Elements
{
	public class MapElement
	{
		public string Path { get; set; }

		public MapElement()
		{
			Path = "New Path";
		}

		public MapElement(string path)
		{
			Path = path;
		}

		public override string ToString()
		{
			return Path;
		}
	}
}
