using System.ComponentModel;
using System.IO;
using Fiesta.FileFormats.Quest.Rewards.Values;

namespace Fiesta.FileFormats.Quest.Conditions.EndCondition
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ItemList
    {
        public bool NeedsItem { get; set; }
        public byte ItemType { get; set; }
        public Item Item { get; set; }

        public ItemList(BinaryReader reader)
        {
            NeedsItem = reader.ReadBoolean();
            ItemType = reader.ReadByte();
            Item = new Item(reader);
        }

        public void Save(BinaryWriter writer)
        {
			writer.Write(NeedsItem);
			writer.Write(ItemType);
			
			Item.Save(writer);
        }
    }
}
