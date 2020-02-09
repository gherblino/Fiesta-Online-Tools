using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Fiesta.FileFormats.Quest.Conditions.EndCondition
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class NPCMobList
    {
        public bool NeedsNPCMob { get; set; }
        public byte Unk9 { get; set; }
		public ushort NPCMobID { get; set; }
		public NPCMobAction NPCMobAction { get; set; }
        public byte NPCMobCount { get; set; }
        public byte Target { get; set; } //TODO: Check if there is an enum for this available
        public byte Unk10 { get; set; }

        public NPCMobList(BinaryReader reader)
        {
            NeedsNPCMob = reader.ReadBoolean();

            //TODO: Figure this out
            Unk9 = reader.ReadByte();

            NPCMobID = reader.ReadUInt16();

            NPCMobAction = (NPCMobAction)reader.ReadByte();
            NPCMobCount = reader.ReadByte();
            Target = reader.ReadByte();

            //TODO: Figure this out
            Unk10 = reader.ReadByte();
        }

        public void Save(BinaryWriter writer)
        {
			writer.Write(NeedsNPCMob);
			writer.Write(Unk9);
			writer.Write(NPCMobID);
			writer.Write((byte)NPCMobAction);
			writer.Write(NPCMobCount);
			writer.Write(Target);
			writer.Write(Unk10);
        }
    }
}