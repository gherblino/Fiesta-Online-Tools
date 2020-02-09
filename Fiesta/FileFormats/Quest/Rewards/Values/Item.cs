using System.ComponentModel;
using System.IO;

namespace Fiesta.FileFormats.Quest.Rewards.Values
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Item
    {
        public ushort ID { get; set; }
        public ushort Lot { get; set; }

        public Item() : this(0, 0)
        {
        }

        public Item(ushort id, ushort lot)
        {
            ID = id;
            Lot = lot;
        }

        public Item(BinaryReader reader)
        {
            ID = reader.ReadUInt16();
            Lot = reader.ReadUInt16();
        }

        public void Save(BinaryWriter writer)
        {
			writer.Write(ID);
			writer.Write(Lot);
        }

        public static Item GetCopy(Item item)
        {
            return new Item(item.ID, item.Lot);
        }
    }
}
