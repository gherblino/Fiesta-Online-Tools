using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropTableEditor.Shine
{
    public class ShineWriter
    {
        private string filePath;

        public ShineWriter(string filePath)
        {
            this.filePath = filePath;
        }

        public Task WriteToFile(DataTable dataTable, List<string> columnTypes)
        {
            return Task.Factory.StartNew(() =>
            {
                var lines = new List<string>();
                lines.Add("#Ignore\t\\o042");
                lines.Add("#Exchange\t#\t\\x20");
                lines.Add("#Delimiter\t\\x20\n");
                lines.Add("#Table\t" + dataTable.TableName);
                lines.Add("#ColumnType\t" + string.Join("\t", columnTypes).Trim());

                var columnNames = "#ColumnName\t";
                foreach (var column in dataTable.Columns.Cast<DataColumn>())
                {
                    columnNames += column.ColumnName + "\t";
                }
                lines.Add(columnNames.Trim());

                foreach (var row in dataTable.Rows.Cast<DataRow>())
                {
                    lines.Add("#Record\t" + string.Join("\t", row.ItemArray).Trim());
                }

                lines.Add("#End");

                File.Delete(filePath);
                File.WriteAllLines(filePath, lines.ToArray());
            });
        }
    }
}
