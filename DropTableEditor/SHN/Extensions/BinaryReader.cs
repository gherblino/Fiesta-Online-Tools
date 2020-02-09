using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropTableEditor.SHN.Extensions
{
    public static class BinaryReaderExtensions
    {
        public static string ReadString(this BinaryReader reader, int length)
        {
            string str = "";
            byte character;
            for (int i = 0; i < length; i++)
            {
                if ((character = reader.ReadByte()) != 0)
                {
                    str += (char)character;
                }
            }

            return str;
        }

        public static string ReadStringUntilZero(this BinaryReader reader)
        {
            string str = "";
            while (reader.PeekChar() != 0)
            {
                str += (char)reader.ReadByte();
            }

            return str;
        }

    }
}
