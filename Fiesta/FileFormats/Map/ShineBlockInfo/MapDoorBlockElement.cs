using System;
using System.Drawing;
using System.IO;
using Fiesta.FileFormats.Map.ShineBlockData;

namespace Fiesta.FileFormats.Map.ShineBlockInfo
{
	public class MapDoorBlockElement
	{
		public string BlockName { get; set; }
		public uint StartX { get; set; }
		public uint StartY { get; set; }
		public uint EndX { get; set; }
		public uint EndY { get; set; }
		public uint DataSize; // ((EndX - StartX + 1) / 8) * (EndY - StartY + 1)
//		public uint DataSize { get; set; } // ((EndX - StartX + 1) / 8) * (EndY - StartY + 1)
		public uint Address;
//		public uint Address { get; set; }

		public byte[] Data;
		public Bitmap Bitmap;

		private Color _color;
		public Color Color
		{
			get => _color;
			set
			{
				if (Bitmap != null)
					SetColor(_color, value);
				_color = value;
			}
		}
		public bool IsVisible { get; set; }

		public MapDoorBlockElement(string blockName, uint startX, uint startY, uint endX, uint endY, uint dataSize,
			uint address, Color color)
		{
			BlockName = blockName;
			StartX = startX;
			StartY = startY;
			EndX = endX;
			EndY = endY;
			DataSize = dataSize;
			Address = address;
			Color = color;
			IsVisible = true;
		}

		public MapDoorBlockElement(string blockName, uint startX, uint startY, uint endX, uint endY, Color color)
		{
			BlockName = blockName;
			StartX = startX;
			StartY = startY;
			EndX = endX;
			EndY = endY;
			DataSize = CalculateDataSize();
			Color = color;
			IsVisible = true;
		}

		public void SetBitmap()
		{
			SetBitmap(Color.Red);
		}

		public void SetBitmap(Bitmap input)
		{
			Bitmap = input;
		}

		public void SetBitmap(Color color)
		{
			Bitmap = SHBD.Load(Data, false, (int) (EndX - StartX), (int) (EndY - StartY))
				.Import(Data, color, GetWidth() / 8, GetHeight());
			Bitmap.MakeTransparent(Bitmap.GetPixel(0, 0));
		}

		public void SetData()
		{
			var width = GetWidth() / 8;
			var height = GetHeight();
			Data = SHBD.GetBytes(Bitmap, width, height, Color);

			// Already took into account the *2
			if (Data.Length == GetWidth() / 4 * GetHeight())
			{
				return;
			}

			// Add extra irrelevant data to the end
			var temp = Data;
			Array.Resize(ref temp, GetWidth() / 4 * GetHeight());
			Data = temp;
		}

		public void SetColor(Color c1, Color c2)
		{
			for (var y = 0; y < Bitmap.Height; y++)
			{
				for (var x = 0; x < Bitmap.Width; x++)
				{
					var pixel = Bitmap.GetPixel(x, y);

					// We replace the color
					if (pixel.ToArgb().Equals(c1.ToArgb()))
					{
						Bitmap.SetPixel(x, y, c2);
					}
				}
			}
		}

		public void InitializeColor(Color color)
		{
			for (var y = 0; y < Bitmap.Height; y++)
			{
				for (var x = 0; x < Bitmap.Width; x++)
				{
					var pixel = Bitmap.GetPixel(x, y);

					// If the pixel color is white, we set it to input color, else we make it white
					if (pixel.ToArgb().Equals(Color.White.ToArgb()))
					{
						Bitmap.SetPixel(x, y, color);
					}
					else
					{
						Bitmap.SetPixel(x, y, Color.FromName("ffffffff"));
					}
				}
			}
		}

		public int GetWidth()
		{
			return (int) (EndX - StartX + 1);
		}

		public int GetHeight()
		{
			return (int) (EndY - StartY + 1);
		}

		public uint CalculateDataSize()
		{
			return (uint) (GetWidth() / 8 * GetHeight());
		}

		public void Export(BinaryWriter writer)
		{
			writer.Write(StringHelper.GetBytes(BlockName, 32));
			writer.Write(StartX);
			writer.Write(StartY);
			writer.Write(EndX);
			writer.Write(EndY);
			writer.Write(DataSize);
			writer.Write(Address);
		}

		public void ExportDoor(BinaryWriter writer)
		{
			SetData();
			writer.Write(Data);
		}
	}
}