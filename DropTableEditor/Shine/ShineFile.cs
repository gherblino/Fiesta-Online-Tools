using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropTableEditor.Shine
{
    public class ShineFile
    {
        public DataSet DataSet { get; set; }
        public string FilePath { get; set; }
        public List<string> ColumnTypes;

        private ShineReader reader { get; set; }
        private ShineWriter writer { get; set; }

        public ShineFile(string filePath)
        {
            FilePath = filePath;
            ColumnTypes = new List<string>();
            reader = new ShineReader(FilePath);
            writer = new ShineWriter(FilePath);
        }

        public async void ReadFile()
        {
            DataSet = await reader.Read();
            ColumnTypes = reader.ColumnTypes;
        }

        public async void SaveFile()
        {
            await writer.WriteToFile(DataSet.Tables[0], ColumnTypes);
        }
    }
}
