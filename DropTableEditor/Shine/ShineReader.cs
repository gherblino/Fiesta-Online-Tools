using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DropTableEditor.Shine
{
    internal class ShineReader
    {
        private string[] lines;
        public List<string> ColumnTypes = new List<string>();

        public ShineReader(string path)
        {
            lines = File.ReadAllLines(path);
        }

        public Task<DataSet> Read()
        {
            return Task.Factory.StartNew(() =>
            {
                var dataSet = new DataSet();

                foreach (var line in lines)
                {

                    var str = Regex.Replace(line, "\t+", "\t");
                    var args = str.Split('\t');

                    switch (args[0].ToLower())
                    {
                        case "#table":
                            var table = new DataTable(args[1]);
                            dataSet.Tables.Add(table);
                            break;

                        case "#columntype":
                            ColumnTypes.Add(string.Join("\t", args.Skip(1)));
                            break;

                        case "#columnname":
                            foreach (var arg in args.Skip(1))
                            {
                                dataSet.Tables.Cast<DataTable>().Last().Columns.Add(new DataColumn(arg));
                            }
                            break;

                        case "#record":
                            var row = dataSet.Tables.Cast<DataTable>().Last().NewRow();
                            row.ItemArray = args.Skip(1).ToArray();
                            dataSet.Tables.Cast<DataTable>().Last().Rows.Add(row);
                            break;
                    }
                }
                return dataSet;
            });

        }
    }
}
