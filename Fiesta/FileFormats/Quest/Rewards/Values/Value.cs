using Fiesta.FileFormats.Player;
using System.ComponentModel;
using System.IO;

namespace Fiesta.FileFormats.Quest.Rewards.Values
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Value
    {
	    public byte[] Unk;
	    public uint Exp;
        public uint Money;
        public Item Item;
        public Abstate Abstate;
        public uint Fame;
        public uint PetID;
        public byte MiniHouseID;
        public CharacterTitle CharacterTitle;
        public uint KillPoint;
        public byte[] Rest;

        public void Initialize()
        {
	        Exp = 0;
	        Money = 0;
	        Item = new Item();
			Abstate = new Abstate();
			Fame = 0;
			PetID = 0;
			MiniHouseID = 0;
			CharacterTitle = new CharacterTitle();
			KillPoint = 0;
        }

        public Value(RewardType qrt, BinaryReader reader)
        {
			Initialize();

	        Unk = reader.ReadBytes(2);

	        switch (qrt)
	        {
				case RewardType.Exp:
					Exp = reader.ReadUInt32();
					Rest = reader.ReadBytes(4);
					break;

				case RewardType.Money:
					Money = reader.ReadUInt32();
					Rest = reader.ReadBytes(4);
					break;

				case RewardType.Item:
					Item = new Item(reader);
					Rest = reader.ReadBytes(4);
					break;

				case RewardType.Abstate:
					Abstate = new Abstate(reader);
					break;

				case RewardType.Fame:
					Fame = reader.ReadUInt32();
					Rest = reader.ReadBytes(4);
					break;

				case RewardType.Pet:
					PetID = reader.ReadUInt32();
					Rest = reader.ReadBytes(4);
					break;

				case RewardType.MiniHouse:
					MiniHouseID = reader.ReadByte();
					Rest = reader.ReadBytes(7);
					break;

				case RewardType.Title:
					CharacterTitle = new CharacterTitle(reader);
					Rest = reader.ReadBytes(4);
					break;

				case RewardType.KillPoint:
					KillPoint = reader.ReadUInt32();
					Rest = reader.ReadBytes(4);
					break;

				default:
					return;
			}
        }

        public void Save(RewardType qrt, BinaryWriter writer)
        {
			writer.Write(Unk);

			switch (qrt)
			{
				case RewardType.Exp:
					writer.Write(Exp);
					break;

				case RewardType.Money:
					writer.Write(Money);
					break;

				case RewardType.Item:
					Item.Save(writer);
					break;

				case RewardType.Abstate:
					Abstate.Save(writer);
					break;

				case RewardType.Fame:
					writer.Write(Fame);
					break;

				case RewardType.Pet:
					writer.Write(PetID);
					break;

				case RewardType.MiniHouse:
					writer.Write(MiniHouseID);
					break;

				case RewardType.Title:
					CharacterTitle.Save(writer);
					break;

				case RewardType.KillPoint:
					writer.Write(KillPoint);
					break;

				default:
					return;
			}

			writer.Write(Rest);
		}
    }
}
