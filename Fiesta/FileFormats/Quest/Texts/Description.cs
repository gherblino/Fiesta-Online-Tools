using System.ComponentModel;

namespace Fiesta.FileFormats.Quest.Texts
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Description
	{
		public uint ID { get; set; }
		public string Text { get; set; }

		public Description(uint id, string text)
		{
			ID = id;
			Text = string.Copy(text);
		}
        

        public static Description GetCopy(Description description)
        {
            return new Description(description.ID, description.Text);
        }
	}
}
