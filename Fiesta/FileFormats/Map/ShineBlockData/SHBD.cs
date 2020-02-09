using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Fiesta.FileFormats.Map.ShineBlockData
{
	public class SHBD
	{
		public int XSize;
		public int YSize;
		public byte[] Data;
		public Bitmap Bitmap;

		public static SHBD Load(string path)
		{
			return Load(File.ReadAllBytes(path));
		}

		public static SHBD Load(byte[] data)
		{
			return Load(data, true, 0, 0);
		} 

		public static SHBD Load(byte[] data, bool readHeader, int xSize, int ySize)
		{
			var shbd = new SHBD();

			using (var memoryStream = new MemoryStream(data))
			using (var binaryReader = new BinaryReader(memoryStream))
			{
				if (readHeader)
				{
					shbd.XSize = binaryReader.ReadInt32();
					shbd.YSize = binaryReader.ReadInt32();
				}
				else
				{
					shbd.XSize = xSize;
					shbd.YSize = ySize;
				}

				shbd.Data = binaryReader.ReadBytes(shbd.XSize * shbd.YSize);
			}

			return shbd;
		}

		public static SHBD Load(int xSize, int ySize, Bitmap bitmap)
		{
			SHBD shbd = new SHBD
			{
				XSize = xSize / 8,
				YSize = ySize,
				Bitmap = bitmap
			};

			return shbd;
		}

		public void SetBitmap()
		{
			Bitmap = Import();
		}

		public Bitmap Import()
		{
			return Import(Data, Color.Black, XSize, YSize);
		}

		public Bitmap Import(byte[] data, Color blockColor, int xSize, int ySize)
		{
			var output = new Bitmap(xSize * 8, ySize);
			var pos = 0;
			for (var y = ySize - 1; y >= 0; y--)
			{
				for (var x = 0; x < xSize; x++)
				{
					byte input = data[pos];

					for (var i = 0; i < 8; i++)
					{
						output.SetPixel(x * 8 + i, y, (input & (byte)Math.Pow(2, i)) == 0 ? Color.White : blockColor);
					}

					pos++;
				}
			}
			return output;
		}

		private static byte BitsToByte(BitArray bits)
		{
			var bytes = new byte[1];
			bits.CopyTo(bytes, 0);

			return bytes[0];
		}

		private static bool GetBitFromPixel(Bitmap data, int x, int y)
		{
            if (data.GetPixel(x, y).Name.Equals("ffffffff"))
            {
                return false;
            }

			data.SetPixel(x, y, Color.White);
			return true;
		}

		//TODO: Use this for performance boost: https://davidthomasbernal.com/blog/2008/03/13/c-image-processing-performance-unsafe-vs-safe-code-part-i
		public static byte[] Export(Bitmap bitmap, int xSize, int ySize)
		{
			using (var memoryStream = new MemoryStream())
			using (var binaryWriter = new BinaryWriter(memoryStream))
			{
				binaryWriter.Write(xSize);
				binaryWriter.Write(ySize);

				for (var y = ySize - 1; y >= 0; y--)
				{
					for (var x = 0; x < xSize; x++)
					{
						var bits = new BitArray(8);

						for (var i = 0; i < 8; i++)
						{
							bits[i] = GetBitFromPixel(bitmap, x * 8 + i, y);
						}

						binaryWriter.Write(BitsToByte(bits));
					}
				}
				
				return memoryStream.ToArray();
			}
		}

//		private static bool GetBitFromPixel2(Bitmap data, int x, int y, Color color)
//		{
//			return !data.GetPixel(x, y).Name.Equals("ffffffff");
//		}

		private static bool RGBEqual(Color c1, Color c2)
		{
			return c1.R == c2.R && c1.G == c2.G && c1.B == c2.B;
		}

		public static byte[] GetBytes(Bitmap bitmap, int xSize, int ySize, Color color)
		{
			using (var memoryStream = new MemoryStream())
			using (var binaryWriter = new BinaryWriter(memoryStream))
			{
				for (var y = ySize - 1; y >= 0; y--)
				{
					for (var x = 0; x < xSize; x++)
					{
						var bits = new BitArray(8);

						for (var i = 0; i < 8; i++)
						{
							bits[i] = RGBEqual(bitmap.GetPixel(x * 8 + i, y), color);
						}

						binaryWriter.Write(BitsToByte(bits));
					}
				}

				return memoryStream.ToArray();
			}
		}

		public void Export(string path, Bitmap bitmap, int xSize, int ySize)
		{
			File.WriteAllBytes(path, Export(bitmap, xSize, ySize));
		}
	}
}