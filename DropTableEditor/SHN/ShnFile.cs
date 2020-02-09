using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DropTableEditor.SHN
{
    public class ShnFile
    {
        /// <summary>
        /// The location of the file on this computer.
        /// </summary>
        public string FilePath { get; set; }
        public DataTable Table;         // Contains the file's columns & rows.

        private ShnReader reader;       // Used to read data from the file.
        private ShnWriter writer;       // Used to write data to the file.
        private uint dataHeader;          // Header of the file.
        private byte[] baseHeader;

        /// <summary>
        /// Creates a new SHN instance without any rows or columns.
        /// </summary>
        public ShnFile()
        {
            Table = new DataTable(Path.GetFileName(FilePath));
        }

        /// <summary>
        /// Reads data from a file stream and parses data accordingly.
        /// </summary>
        /// <param name="filePath">Which file to read from.</param>
        public ShnFile(string filePath) : this()
        {
            FilePath = filePath;
            reader = new ShnReader(FilePath, ref Table);
            writer = new ShnWriter(FilePath, Table);
        }

        /// <summary>
        /// Writes data to the path set in the FilePath property.
        /// If the file is not found, one is created.
        /// </summary>
        /// <returns>A boolean value indicating whether the save process was a success.</returns>
        public Task<bool> Save()
        {
            return Task.Factory.StartNew(() =>
            {
                writer.SaveFile(dataHeader, baseHeader);

                return true;
            });
        }

        /// <summary>
        /// Reads data from the path set in the <see cref="FilePath"/> property.
        /// </summary>
        /// <returns>A boolean value indicating whether the read process was a success.</returns>
        /// <exception cref="FileNotFoundException"></exception>
        public Task<bool> Open()
        {
            return Task.Factory.StartNew(() =>
            {
                baseHeader = reader.ReadHeader();
                reader.ReadFile(out dataHeader);

                return true;
            });
        }
    }
}