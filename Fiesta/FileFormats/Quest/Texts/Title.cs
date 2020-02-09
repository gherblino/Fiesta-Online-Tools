using System.ComponentModel;

namespace Fiesta.FileFormats.Quest.Texts
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Title
	{
		public uint ID { get; set; }
		public string Text { get; set; }

		public Title(uint id, string text)
		{
			ID = id;
			Text = string.Copy(text);
		}

        public static Title GetCopy(Title title)
        {
            return new Title(title.ID, title.Text);
        }
	}
}
