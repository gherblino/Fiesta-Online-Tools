using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropTableEditor.SHN
{
    public static class ShnCrypter
    {
        internal static void Crypt(byte[] data, int startIndex, int length)
        {
            if (((startIndex < 0) | (length < 1)) | ((startIndex + length) > data.Length))
            {
                throw new IndexOutOfRangeException();
            }

            byte xorBy = (byte)length;
            for (int i = length - 1; i >= 0; i--)
            {
                data[i] = (byte)(data[i] ^ xorBy);
                byte xorByNext = (byte)i;
                xorByNext = (byte)(xorByNext & (byte)15);
                xorByNext = (byte)(xorByNext + (byte)85);
                xorByNext = (byte)(xorByNext ^ ((byte)(((byte)i) * (byte)11)));
                xorByNext = (byte)(xorByNext ^ xorBy);
                xorByNext = (byte)(xorByNext ^ (byte)170);
                xorBy = xorByNext;
            }
        }
    }
}
