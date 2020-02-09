using System.ComponentModel;

namespace Fiesta.FileFormats.ActionInfo.Types.Sound
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Files
	{
		public string FirstFile { get; set; }
		public string SecondFile { get; set; }

		public Files(string firstFile, string secondFile)
		{
			FirstFile = firstFile;
			SecondFile = secondFile;
		}

		public override string ToString()
		{
			return "";
		}
	}
}
