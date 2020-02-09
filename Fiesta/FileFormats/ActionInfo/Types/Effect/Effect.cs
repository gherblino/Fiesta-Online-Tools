using System.ComponentModel;
using System.IO;
using static Fiesta.StringHelper;

namespace Fiesta.FileFormats.ActionInfo.Types.Effect
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Effect
	{
		public Files EffectFiles { get; set; }
		public Position EffectPosition { get; set; }
		public Notes EffectNotes { get; set; }
		public Keep EffectKeep { get; set; }
		public Direction EffectDirection { get; set; }

		public Effect()
		{
			EffectFiles = new Files("-", "-", "-");
			EffectPosition = new Position(0, 0, 0);
			EffectNotes = new Notes(0, 0, 0);
			EffectKeep = new Keep(0, 0, 0);
			EffectDirection = new Direction(0, 0,0);
		}

		public Effect(BinaryReader binaryReader)
		{
			EffectFiles = new Files(GetStringFromBytes(binaryReader.ReadBytes(33)), GetStringFromBytes(binaryReader.ReadBytes(33)), GetStringFromBytes(binaryReader.ReadBytes(34)));
			EffectPosition = new Position(binaryReader.ReadUInt32(), binaryReader.ReadUInt32(), binaryReader.ReadUInt32());
			EffectNotes = new Notes(binaryReader.ReadUInt32(), binaryReader.ReadUInt32(), binaryReader.ReadUInt32());
			EffectKeep = new Keep(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
			EffectDirection = new Direction(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
		}

		public override string ToString()
		{
			return "";
		}
	}
}
