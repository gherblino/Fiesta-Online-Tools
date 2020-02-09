using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Fiesta.FileFormats.Quest
{
    public class QuestData
    {
        public short Header { get; set; }
        public short Total => (short) Quests.Count;
        public BindingList<Quest> Quests { get; set ;}

        public static QuestData Load(string path)
        {
            var qd = new QuestData
            {
                Quests = new BindingList<Quest>()
            };

            using (var memoryStream = new MemoryStream(File.ReadAllBytes(path)))
            using (var binaryReader = new BinaryReader(memoryStream))
            {
                qd.Header = binaryReader.ReadInt16();

                if (qd.Header != 6)
                {
                    throw new Exception($"Incorrect header! Expected: 6 and got: {qd.Header})");
                }

                var total = binaryReader.ReadInt16();

                for (var i = 0; i < total; i++)
                {
                    qd.Quests.Add(new Quest(binaryReader));
                    Quest.Count++;
                }
            }

            return qd;
        }

        public void Save(string path, string fileName)
        {
			using (var writer = new BinaryWriter(File.Open(path + Path.DirectorySeparatorChar + fileName, FileMode.Create)))
	        {
		        writer.Write(Header);
		        writer.Write(Total);

		        foreach (var q in Quests)
		        {
			        q.Save(writer);
		        }
	        }

	        MessageBox.Show($"{fileName} has successfully been saved.");
        }
	}
}
