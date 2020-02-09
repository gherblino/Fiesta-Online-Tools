using System.ComponentModel;
using System.IO;

namespace Fiesta.FileFormats.Quest.Rewards.Values
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Abstate
    {
        public uint KeepTime;
        public ushort ID;
        public ushort Strength;

        public Abstate()
        {
	        KeepTime = 0;
	        ID = 0;
	        Strength = 0;
        }

        public Abstate(BinaryReader reader)
        {
            KeepTime = reader.ReadUInt32();
            ID = reader.ReadUInt16();
            Strength = reader.ReadUInt16();
        }

        public void Save(BinaryWriter writer)
        {
	        writer.Write(KeepTime);
	        writer.Write(ID);
	        writer.Write(Strength);
        }
	}
}
