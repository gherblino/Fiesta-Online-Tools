using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Fiesta.FileFormats.Player;
using Fiesta.FileFormats.Quest.Daily;
using Fiesta.FileFormats.Quest.Rewards.Values;
using Fiesta.FileFormats.Quest.Texts;

namespace Fiesta.FileFormats.Quest.Conditions
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StartCondition
    {
        public bool IsWaitListView { get; set; }
        public bool IsWaitListProgress { get; set; }
        public byte Unk2 { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsInstantAccept { get; set; }
        public bool NeedsLevel { get; set; }
        public byte LevelMin { get; set; }
        public byte LevelMax { get; set; }
        public bool NeedsNPC { get; set; }
        public NPC NPC { get; set; }
        public bool NeedsItem { get; set; }
        public Item Item { get; set; }
        public bool NeedsLocation { get; set; }
        public ushort Location { get; set; }
        public uint LocationX { get; set; }
        public uint LocationY { get; set; }
        public uint LocationRange { get; set; }
        public int Unk3 { get; set; }
        public bool NeedsPreviousQuest { get; set; }
        public byte Unk4 { get; set; }
        public ushort PreviousQuestID { get; set; }
        public bool NeedsRace { get; set; }
        public Race Race { get; set; }
        public bool NeedsClass { get; set; }
        public Class Class { get; set; }
        public bool NeedsGender { get; set; }
        public Gender Gender { get; set; }
        public bool NeedsDate { get; set; }
        public DateMode DateMode { get; set; }
        public long DateStart { get; set; }
        public long DateEnd { get; set; }
        public int Unk5 { get; set; }

        public StartCondition()
        {

        }

        public StartCondition(BinaryReader reader)
        {
            IsWaitListView = reader.ReadBoolean();
            IsWaitListProgress = reader.ReadBoolean();
            
            //TODO: Figure out this part
            Unk2 = reader.ReadByte();

            IsEnabled = reader.ReadBoolean();
            IsInstantAccept = reader.ReadBoolean();
            NeedsLevel = reader.ReadBoolean();
            LevelMin = reader.ReadByte();
            LevelMax = reader.ReadByte();
            NeedsNPC = reader.ReadBoolean();

			ushort NPCID = reader.ReadUInt16();
			NPC = new NPC(NPCID, "", "");

			NeedsItem = reader.ReadBoolean();
            Item = new Item(reader);
            NeedsLocation = reader.ReadBoolean();
            Location = reader.ReadUInt16();
            LocationX = reader.ReadUInt32();
            LocationY = reader.ReadUInt32();
            LocationRange = reader.ReadUInt32();
            
            //TODO: Figure out this part
            Unk3 = reader.ReadInt32();

			NeedsPreviousQuest = reader.ReadBoolean();

            //TODO: Figure out this part
            Unk4 = reader.ReadByte();

            PreviousQuestID = reader.ReadUInt16();
            NeedsRace = reader.ReadBoolean();
            Race = (Race)reader.ReadByte();
            NeedsClass = reader.ReadBoolean();
            Class = (Class)reader.ReadByte();
            NeedsGender = reader.ReadBoolean();
            Gender = (Gender)reader.ReadByte();
            NeedsDate = reader.ReadBoolean();
            DateMode = (DateMode)reader.ReadByte();
            DateStart = reader.ReadInt64();
            DateEnd = reader.ReadInt64();

            //TODO: Figure out this part
            Unk5 = reader.ReadInt32();
        }

        public void Save(BinaryWriter writer)
        {
	        writer.Write(IsWaitListView);
	        writer.Write(IsWaitListProgress);
	        writer.Write(Unk2);
	        writer.Write(IsEnabled);
	        writer.Write(IsInstantAccept);
	        writer.Write(NeedsLevel);
	        writer.Write(LevelMin);
	        writer.Write(LevelMax);
	        writer.Write(NeedsNPC);
			writer.Write(NPC.ID);
			writer.Write(NeedsItem);

			Item.Save(writer);

			writer.Write(NeedsLocation);
			writer.Write(Location);
			writer.Write(LocationX);
			writer.Write(LocationY);
			writer.Write(LocationRange);
			writer.Write(Unk3);
			writer.Write(NeedsPreviousQuest);
			writer.Write(Unk4);
			writer.Write(PreviousQuestID);
			writer.Write(NeedsRace);
			writer.Write((byte)Race);
			writer.Write(NeedsClass);
			writer.Write((byte)Class);
			writer.Write(NeedsGender);
			writer.Write((byte)Gender);
			writer.Write(NeedsDate);
			writer.Write((byte)DateMode);
			writer.Write(DateStart);
			writer.Write(DateEnd);
			writer.Write(Unk5);
        }

        public static StartCondition GetCopy(StartCondition sc)
        {
            return new StartCondition
            {
                IsWaitListView = sc.IsWaitListView,
                IsWaitListProgress = sc.IsWaitListProgress,
                Unk2 = sc.Unk2,
                IsEnabled = sc.IsEnabled,
                IsInstantAccept = sc.IsInstantAccept,
                NeedsLevel = sc.NeedsLevel,
                LevelMin = sc.LevelMin,
                LevelMax = sc.LevelMax,
                NeedsNPC = sc.NeedsNPC,
                NPC = NPC.GetCopy(sc.NPC),
                NeedsItem = sc.NeedsItem,
                Item = Item.GetCopy(sc.Item),
                NeedsLocation = sc.NeedsLocation,
                Location = sc.Location,
                LocationX = sc.LocationX,
                LocationY = sc.LocationY,
                LocationRange = sc.LocationRange,
                Unk3 = sc.Unk3,
                NeedsPreviousQuest = sc.NeedsPreviousQuest,
                Unk4 = sc.Unk4,
                PreviousQuestID = sc.PreviousQuestID,
                NeedsRace = sc.NeedsRace,
                Race = sc.Race,
                NeedsClass = sc.NeedsClass,
                Class = sc.Class,
                NeedsGender = sc.NeedsGender,
                Gender = sc.Gender,
                NeedsDate = sc.NeedsDate,
                DateMode = sc.DateMode,
                DateStart = sc.DateStart,
                DateEnd = sc.DateEnd,
                Unk5 = sc.Unk5
            };
        }
	}
}
