using System;
using System.ComponentModel;
using System.IO;
using Fiesta.FileFormats.Player;

namespace Fiesta.FileFormats.Quest.Conditions.EndCondition
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class EndCondition
    {
        public bool IsInstantHandIn { get; set; }
        public bool NeedsLevel { get; set; }
        public byte Level { get; set; }
        public byte Unk6 { get; set; }
        public NPCMobList[] NPCMobLists { get; set; }
        public ItemList[] ItemLists { get; set; }
        public bool NeedsLocation { get; set; }
        public ushort Location { get; set; }
        public uint LocationX { get; set; }
        public uint LocationY { get; set; }
        public uint LocationRange { get; set; }
        public int Unk7 { get; set; }
        public bool NeedsScenario { get; set; }
        public ushort ScenarioID { get; set; }   //TODO: Figure out if this is another enum
        public bool NeedsRace { get; set; }
        public Race Race { get; set; }
        public bool NeedsClass { get; set; }
        public Class Class { get; set; }
        public bool HasTimeLimit { get; set; }
        public ushort TimeLimit { get; set; }
        public byte Unk8 { get; set; }

        public EndCondition()
        {
            
        }

        public EndCondition(BinaryReader reader)
        {
            IsInstantHandIn	= reader.ReadBoolean();
            NeedsLevel		= reader.ReadBoolean();
            Level			= reader.ReadByte();

            //TODO: Figure this out
            Unk6 = reader.ReadByte();

            NPCMobLists = new NPCMobList[5];
            for (int i = 0; i < 5; i++)
            {
                NPCMobLists[i] = new NPCMobList(reader);
            }

            ItemLists = new ItemList[5];
            for (int i = 0; i < 5; i++)
            {
                ItemLists[i] = new ItemList(reader);
            }

            NeedsLocation	= reader.ReadBoolean();
            Location		= reader.ReadUInt16();
            LocationX		= reader.ReadUInt32();
            LocationY		= reader.ReadUInt32();
            LocationRange	= reader.ReadUInt32();

            //TODO: Figure this out
            Unk7 = reader.ReadInt32();

            NeedsScenario	= reader.ReadBoolean();
            ScenarioID		= reader.ReadUInt16();
            NeedsRace		= reader.ReadBoolean();
            Race			= (Race)reader.ReadByte();
            NeedsClass		= reader.ReadBoolean();
            Class			= (Class)reader.ReadByte();
            HasTimeLimit	= reader.ReadBoolean();
            TimeLimit		= reader.ReadUInt16();

            //TODO: Figure this out
            Unk8 = reader.ReadByte();
        }

        public void Save(BinaryWriter writer)
        {
			writer.Write(IsInstantHandIn);
			writer.Write(NeedsLevel);
			writer.Write(Level);
			writer.Write(Unk6);

			for (int i = 0; i < 5; i++)
			{
				NPCMobLists[i].Save(writer);
			}

			for (int i = 0; i < 5; i++)
			{
				ItemLists[i].Save(writer);
			}

			writer.Write(NeedsLocation);
			writer.Write(Location);
			writer.Write(LocationX);
			writer.Write(LocationY);
			writer.Write(LocationRange);
			writer.Write(Unk7);
			writer.Write(NeedsScenario);
			writer.Write(ScenarioID);
			writer.Write(NeedsRace);
			writer.Write((byte)Race);
			writer.Write(NeedsClass);
			writer.Write((byte)Class);
			writer.Write(HasTimeLimit);
			writer.Write(TimeLimit);
			writer.Write(Unk8);
        }

        public static EndCondition GetCopy(EndCondition ec)
        {
            EndCondition copy = new EndCondition
            {
                IsInstantHandIn = ec.IsInstantHandIn,
                NeedsLevel = ec.NeedsLevel,
                Level = ec.Level,
                Unk6 = ec.Unk6,
                NPCMobLists = new NPCMobList[5],
                ItemLists = new ItemList[5],
                NeedsLocation = ec.NeedsLocation,
                Location = ec.Location,
                LocationX = ec.LocationX,
                LocationY = ec.LocationY,
                LocationRange = ec.LocationRange,
                Unk7 = ec.Unk7,
                NeedsScenario = ec.NeedsScenario,
                ScenarioID = ec.ScenarioID,
                NeedsRace = ec.NeedsRace,
                Race = ec.Race,
                NeedsClass = ec.NeedsClass,
                Class = ec.Class,
                HasTimeLimit = ec.HasTimeLimit,
                TimeLimit = ec.TimeLimit,
                Unk8 = ec.Unk8
            };

            Array.Copy(ec.NPCMobLists, 0, copy.NPCMobLists, 0, ec.NPCMobLists.Length);
            Array.Copy(ec.ItemLists, 0, copy.ItemLists, 0, ec.ItemLists.Length);

            return copy;
        }
    }
}
