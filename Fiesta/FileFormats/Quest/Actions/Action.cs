using System.ComponentModel;
using System.IO;

namespace Fiesta.FileFormats.Quest.Actions
{
    //TODO: Figure out how this class works exactly
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Action
    {
        public TypeIf IfType { get; set; }
        public uint IfTarget { get; set; }
        public TypeThen ThenType { get; set; }
        public uint ThenTarget { get; set; }
        public uint ThenPercent { get; set; }
        public uint ThenCountMin { get; set; }
        public uint ThenCountMax { get; set; }
        public TargetType ActionTargetType { get; set; }

        public Action(BinaryReader reader)
        {
            IfType = (TypeIf)reader.ReadInt32();
            IfTarget = reader.ReadUInt32();
            ThenType = (TypeThen)reader.ReadInt32();
            ThenTarget = reader.ReadUInt32();
            ThenPercent = reader.ReadUInt32();
            ThenCountMin = reader.ReadUInt32();
            ThenCountMax = reader.ReadUInt32();
            ActionTargetType = (TargetType)reader.ReadInt32();
        }

        public void Save(BinaryWriter writer)
        {
	        writer.Write((int)IfType);
	        writer.Write(IfTarget);
	        writer.Write((int)ThenType);
	        writer.Write(ThenTarget);
	        writer.Write(ThenPercent);
	        writer.Write(ThenCountMin);
	        writer.Write(ThenCountMax);
	        writer.Write((int)ActionTargetType);
        }
    }
}
