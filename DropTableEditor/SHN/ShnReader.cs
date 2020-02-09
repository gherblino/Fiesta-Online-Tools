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
    internal class ShnReader
        : IDisposable
    {
        private byte[] Buffer;
        private string filePath;
        private BinaryReader reader;
        private DataTable table;
        private uint initialRowCount;
        private uint initialColumnCount;
        private uint initialRowLength;

        public ShnReader(string filePath, ref DataTable table)
        {
            this.filePath = filePath;
            Buffer = File.ReadAllBytes(filePath);
            reader = new BinaryReader(new MemoryStream(Buffer));
            this.table = table;
        }

        public void ReadFile(out uint dataHeader)
        {
            reader.BaseStream.Position = 0x20;
            Buffer = reader.ReadBytes(reader.ReadInt32() - 0x24);
            ShnCrypter.Crypt(Buffer, 0, Buffer.Length);
            reader = new BinaryReader(new MemoryStream(Buffer));

            readHeaderInfo(out dataHeader);
            parseData();
        }

        private void readHeaderInfo(out uint dataHeader)
        {
            dataHeader = reader.ReadUInt32();
            initialRowCount = reader.ReadUInt32();
            initialRowLength = reader.ReadUInt32();
            initialColumnCount = reader.ReadUInt32();
        }

        private void parseData()
        {
            foreach (var column in ReadColumns())
            {
                table.Columns.Add(column);
            }

            foreach (var row in ReadRows())
            {
                table.Rows.Add(row);
            }
        }

        /// <summary>
        /// Sets the position in the stream to the beginning and
        /// reads 32 bytes.
        /// </summary>
        /// <returns></returns>
        public byte[] ReadHeader()
        {
            reader.BaseStream.Position = 0;
            return reader.ReadBytes(32);
        }

        /// <summary>
        /// Creates and returns any ShnColumn objects found in the given file.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<ShnColumn> ReadColumns()
        {
            for (int i = 0; i < initialColumnCount; i++)
            {
                var name = reader.ReadString(0x30);
                var type = reader.ReadInt32();
                var length = reader.ReadInt32();
                var column = new ShnColumn(name, type, length);

                yield return column;
            }
        }

        /// <summary>
        /// Creates and returns any DataRow objects found in the given file.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<DataRow> ReadRows()
        {
            for (int i = 0; i < initialRowCount; i++)
            {
                var row = table.NewRow();
                var rowLength = reader.ReadUInt16();

                foreach (var column in table.Columns.Cast<ShnColumn>())
                {
                    row[column] = ReadCell(column);
                }

                yield return row;
            }
        }

        private object ReadCell(ShnColumn column)
        {
            switch (column.Type.DataType.FullName)
            {
                case "System.Byte":
                    return reader.ReadByte();

                case "System.UInt16":
                    return reader.ReadUInt16();

                case "System.UInt32":
                    return reader.ReadUInt32();

                case "System.Single":
                    return reader.ReadSingle();

                case "System.String":
                    {
                        // Unknown Length
                        if (column.Type.TypeId == 26)
                            return reader.ReadStringUntilZero();

                        return reader.ReadString(column.Length);
                    }

                case "System.Int16":
                    return reader.ReadInt16();

                case "System.SByte":
                    return reader.ReadSByte();

                case "System.Int32":
                    return reader.ReadInt32();

                default:
                    Console.WriteLine("Unhandled TypeID: {0}", column.Type.TypeId);
                    return reader.ReadStringUntilZero();
            }
        }

        public void Dispose()
        {
            reader.Dispose();
        }
    }
}
