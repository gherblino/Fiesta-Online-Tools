using DropTableEditor.SHN.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropTableEditor.SHN
{
    internal class ShnWriter
    {
        private byte[] Buffer { get; set; }
        private string filePath { get; set; }
        private DataTable table { get; set; }

        public ShnWriter(string filePath, DataTable table)
        {
            this.filePath = filePath;
            this.table = table;
        }

        public void SaveFile(uint dataHeader, byte[] baseHeader)
        {
            var stream = new MemoryStream();
            using (var writer = new BinaryWriter(stream))
            {
                writer.Write(dataHeader);
                writer.Write(table.Rows.Count);
                writer.Write(GetDefaultRecLen());
                writer.Write(table.Columns.Count);

                for (int i = 0; i < table.Columns.Count; i++)
                {
                    var column = (ShnColumn)table.Columns[i];
                    if (column.ColumnName.Contains("UnkCol"))
                    {
                        writer.Write(new byte[0x30]);
                    }
                    else
                    {
                        writer.WriteString(column.ColumnName, 0x30);
                    }

                    writer.Write(column.Type.TypeId);
                    writer.Write(column.Length);
                }

                writeRows(writer);
                var sourceArray = stream.GetBuffer();
                var destinationArray = new byte[stream.Length];
                Array.Copy(sourceArray, destinationArray, stream.Length);

                ShnCrypter.Crypt(destinationArray, 0, destinationArray.Length);

                using (var w = new BinaryWriter(File.Create(filePath)))
                {
                    w.Write(baseHeader.ToArray());
                    w.Write(destinationArray.Length + 0x24);
                    w.Write(destinationArray);
                }
            }
        }

        private void writeRows(BinaryWriter writer)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                long position = writer.BaseStream.Position;
                writer.Write((ushort)0);

                for (int x = 0; x < table.Columns.Count; x++)
                {
                    var value = row.ItemArray[x];
                    value = value ?? "0";

                    var col = (ShnColumn)table.Columns[x];
                    switch (col.Type.TypeId)
                    {
                        case 1:
                            if (value is string)
                            {
                                value = byte.Parse((string)value);
                            }
                            writer.Write((byte)value);
                            break;

                        case 2:
                            if (value is string)
                            {
                                value = ushort.Parse((string)value);
                            }
                            writer.Write((ushort)value);
                            break;

                        case 3:
                            if (value is string)
                            {
                                value = uint.Parse((string)value);
                            }
                            writer.Write((uint)value);
                            break;

                        case 5:
                            if (value is string)
                            {
                                value = float.Parse((string)value);
                            }
                            writer.Write((float)value);
                            break;

                        case 9:
                            if (String.IsNullOrWhiteSpace(value.ToString()))
                            {
                                writer.WriteString(value.ToString(), col.Length);
                            }
                            else
                            {
                                writer.WriteString((string)value, col.Length);
                            }
                            break;

                        case 11:
                            if (value is string)
                            {
                                value = uint.Parse((string)value);
                            }
                            writer.Write((uint)value);
                            break;

                        case 12:
                            if (value is string)
                            {
                                value = byte.Parse((string)value);
                            }
                            writer.Write((byte)value);
                            break;

                        case 13:
                            if (value is string)
                            {
                                value = short.Parse((string)value);
                            }
                            writer.Write((short)value);
                            break;

                        case 0x10:
                            if (value is string)
                            {
                                value = byte.Parse((string)value);
                            }
                            writer.Write((byte)value);
                            break;

                        case 0x12:
                            if (value is string)
                            {
                                value = uint.Parse((string)value);
                            }
                            writer.Write((uint)value);
                            break;

                        case 20:
                            if (value is string)
                            {
                                value = sbyte.Parse((string)value);
                            }
                            writer.Write((sbyte)value);
                            break;

                        case 0x15:
                            if (value is string)
                            {
                                value = short.Parse((string)value);
                            }
                            writer.Write((short)value);
                            break;

                        case 0x16:
                            if (value is string)
                            {
                                value = int.Parse((string)value);
                            }
                            writer.Write((int)value);
                            break;

                        case 0x18:
                            writer.WriteString((string)value, col.Length);
                            break;

                        case 0x1a:
                            writer.WriteString((string)value, -1);
                            break;

                        case 0x1b:
                            if (value is string)
                            {
                                value = uint.Parse((string)value);
                            }
                            writer.Write((uint)value);
                            break;
                    }
                }

                long offset = writer.BaseStream.Position;
                long length = offset - position;
                writer.BaseStream.Seek(position, SeekOrigin.Begin);
                writer.Write((ushort)length);
                writer.BaseStream.Seek(offset, SeekOrigin.Begin);
            }
        }

        public uint GetDefaultRecLen()
        {
            uint start = 2;
            foreach (ShnColumn col in table.Columns)
            {
                start += (uint)col.Length;
            }

            return start;
        }
    }
}
