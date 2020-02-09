using System.IO;

namespace Fiesta.FileFormats.Player
{
    public class CharacterTitle
    {
        public CharacterTitleType Type;
        public ushort ElementNo; //TODO: Figure out wtfook this is (possibly an enum?)

		//TODO: Better to clean it up?
        public CharacterTitle()
        {
			Type = (CharacterTitleType)0;
			ElementNo = 0;
        }

        public CharacterTitle(BinaryReader reader)
        {
            Type = (CharacterTitleType)reader.ReadUInt16();
            ElementNo = reader.ReadUInt16();
        }

        public void Save(BinaryWriter writer)
        {
	        writer.Write((ushort)Type);
	        writer.Write(ElementNo);
        }
	}
}
