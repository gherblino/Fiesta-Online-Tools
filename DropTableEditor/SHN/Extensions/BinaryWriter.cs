using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropTableEditor.SHN.Extensions
{
    public static class BinaryWriterExtensions
    {
        public static void WriteString(this BinaryWriter writer, string str, int length)
        {
            if (length == -1)
            {
                writer.Write(Encoding.Default.GetBytes(str));
                writer.Write((byte)0);
                return;
            }

            writer.Write(Encoding.Default.GetBytes(str));

            for (int i = str.Length; i < length; i++)
            {
                writer.Write((byte)0x00);
            }
        }
    }
}
