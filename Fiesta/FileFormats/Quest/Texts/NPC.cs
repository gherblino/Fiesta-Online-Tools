using System.ComponentModel;

namespace Fiesta.FileFormats.Quest.Texts
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class NPC
	{
		public ushort ID { get; set; }
		public string InxName { get; set; }
		public string Name { get; set; }

		public NPC(ushort id, string inxName, string name)
		{
			ID = id;
			InxName = string.Copy(inxName);
			Name = string.Copy(name);
		}

        public static NPC GetCopy(NPC npc)
        {
            return new NPC(npc.ID, npc.InxName, npc.Name);
        }
	}
}
