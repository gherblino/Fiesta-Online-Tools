using System.ComponentModel;
using System.IO;
using static Fiesta.StringHelper;

namespace Fiesta.FileFormats.ActionInfo.Types.Sound
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Sound
	{
		public Files SoundFiles { get; set; }
		public Position SoundPosition { get; set; }
		public Notes SoundNotes { get; set; }
		public int SoundRandomPlay { get; set; }

		public Sound()
		{
			SoundFiles = new Files("-", "-");
			SoundPosition = new Position(0, 0);
			SoundNotes = new Notes(0, 0);
			SoundRandomPlay = 0;
		}

		public Sound(BinaryReader binaryReader)
		{
			SoundFiles = new Files(GetStringFromBytes(binaryReader.ReadBytes(33)), GetStringFromBytes(binaryReader.ReadBytes(35)));
			SoundPosition  = new Position(binaryReader.ReadUInt32(), binaryReader.ReadUInt32());
			SoundNotes = new Notes(binaryReader.ReadUInt32(), binaryReader.ReadUInt32());
			SoundRandomPlay = binaryReader.ReadInt32();
		}

		public override string ToString()
		{
			return "";
		}
	}
}
