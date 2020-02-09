using System.ComponentModel;
using System.IO;
using Fiesta.FileFormats.Quest.Rewards.Values;

namespace Fiesta.FileFormats.Quest.Rewards
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Reward
    {
        public RewardUse Use { get; set; }
        public RewardType Type { get; set; }
        public Value Value { get; set; }

        public Reward(BinaryReader reader)
        {
            Use = (RewardUse)reader.ReadByte();
            Type = (RewardType)reader.ReadByte();
            Value = new Value(Type, reader);
        }

        public void Save(BinaryWriter writer)
        {
			writer.Write((byte)Use);
			writer.Write((byte)Type);

			Value.Save(Type, writer);
        }
    }
}
