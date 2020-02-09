using System;
using System.IO;
using System.Text;
using Fiesta.FileFormats.Quest.Conditions;
using Fiesta.FileFormats.Quest.Conditions.EndCondition;
using Fiesta.FileFormats.Quest.Daily;
using Fiesta.FileFormats.Quest.Texts;
using static Fiesta.StringHelper;
using Action = Fiesta.FileFormats.Quest.Actions.Action;
using Reward = Fiesta.FileFormats.Quest.Rewards.Reward;

namespace Fiesta.FileFormats.Quest
{
	//TODO: Possibly merge QuestTitle and QuestDescription
    public class Quest
    {
        public static int Count = 1;
        public static uint HighestID = 0;

        public uint QuestSize;
        public uint ID { get; set; }
        public Title Title { get; set; }
        public Description Description { get; set; }
        public byte Region { get; set; }
        public QuestType QuestType { get; set; }
        public bool IsRepeatAble { get; set; }
        public bool IsDailyQuest { get; set; }
        public DailyType DailyType { get; set; }
        public StartCondition StartCondition { get; set; }
        public EndCondition EndCondition { get; set; }
        public byte NumOfActions { get; set; }
        public Action[] Actions { get; set; }
        public Reward[] Rewards { get; set; }
        public ushort StartScriptSize { get; set; }
        public ushort DoingScriptSize { get; set; }
        public ushort EndScriptSize { get; set; }
        public byte[] Unk1;
        public string StartScript { get; set; }
        public string DoingScript { get; set; }
        public string EndScript { get; set; }

        public Quest()
        {
            
        }

        public Quest(BinaryReader reader)
        {
            QuestSize			= reader.ReadUInt32() - 4;
            ID					= reader.ReadUInt32();
            if (ID > HighestID) HighestID = ID;
			var titleID			= reader.ReadUInt32();
            Title				= new Title(titleID, "");
            var descriptionID	= reader.ReadUInt32();
			Description			= new Description(descriptionID, "");

            //TODO: Figure out what this is
            Region = reader.ReadByte();

            QuestType		= (QuestType)reader.ReadByte();
            IsRepeatAble	= reader.ReadBoolean();
            IsDailyQuest	= reader.ReadBoolean();
            DailyType		= (DailyType)reader.ReadByte();

            StartCondition = new StartCondition(reader);
            EndCondition   = new EndCondition(reader);

            NumOfActions = (byte)reader.ReadInt32();

            Actions = new Action[10];
            for (var i = 0; i < 10; i++)
            {
                Actions[i] = new Action(reader);
            }

            Rewards = new Reward[12];
            for (var i = 0; i < 12; i++)
            {
                Rewards[i] = new Reward(reader);
            }

            StartScriptSize = reader.ReadUInt16();
            EndScriptSize   = reader.ReadUInt16();
            DoingScriptSize = reader.ReadUInt16();

            Unk1 = new byte[14];
            Unk1 = reader.ReadBytes(14);

            StartScript = Encoding.ASCII.GetString(reader.ReadBytes(StartScriptSize));
            DoingScript = Encoding.ASCII.GetString(reader.ReadBytes(DoingScriptSize));
            EndScript   = Encoding.ASCII.GetString(reader.ReadBytes(EndScriptSize));
        }

        public void Save(BinaryWriter writer)
        {
			writer.Write(QuestSize + 4);
			writer.Write(ID);
			writer.Write(Title.ID);
			writer.Write(Description.ID);
			writer.Write(Region);
			writer.Write((byte)QuestType);
			writer.Write(IsRepeatAble);
			writer.Write(IsDailyQuest);
			writer.Write((byte)DailyType);

			StartCondition.Save(writer);
			EndCondition.Save(writer);

			writer.Write((int)NumOfActions);

			for (int i = 0; i < 10; i++)
			{
				Actions[i].Save(writer);
			}

			for (int i = 0; i < 12; i++)
			{
				Rewards[i].Save(writer);
			}

			writer.Write(StartScriptSize);
			writer.Write(EndScriptSize);
			writer.Write(DoingScriptSize);

			writer.Write(Unk1);

			writer.Write(GetBytes(StartScript, StartScriptSize));
			writer.Write(GetBytes(DoingScript, DoingScriptSize));
			writer.Write(GetBytes(EndScript, EndScriptSize));
		}

        public static Quest GetCopy(Quest q)
        {
            var copy = new Quest
            {
                QuestSize = q.QuestSize,
                ID = q.ID,
                Title = Title.GetCopy(q.Title),
                Description = Description.GetCopy(q.Description),
                Region = q.Region,
                QuestType = q.QuestType,
                IsRepeatAble = q.IsRepeatAble,
                IsDailyQuest = q.IsDailyQuest,
                DailyType = q.DailyType,
                StartCondition = StartCondition.GetCopy(q.StartCondition),
                EndCondition = EndCondition.GetCopy(q.EndCondition),
                NumOfActions = q.NumOfActions,
                Actions = new Action[10],
                Rewards = new Reward[12],
                StartScriptSize = q.StartScriptSize,
                DoingScriptSize = q.DoingScriptSize,
                EndScriptSize = q.EndScriptSize,
                Unk1 = new byte[14],
                StartScript = string.Copy(q.StartScript),
                DoingScript = string.Copy(q.DoingScript),
                EndScript = string.Copy(q.EndScript)
            };

            Array.Copy(q.Actions, 0, copy.Actions, 0, q.Actions.Length);
            Array.Copy(q.Rewards, 0, copy.Rewards, 0, q.Rewards.Length);
            Array.Copy(q.Unk1, 0, copy.Unk1, 0, q.Unk1.Length);

            return copy;
        }
	}
}