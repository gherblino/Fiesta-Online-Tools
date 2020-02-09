using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Fiesta.FileFormats.Map.ShineBlockInfo
{
	public class MapDoorArray
	{
		public uint TotalHeadCount;
		public List<MapDoorBlockElement> Doors;
		public byte[] BlockBuffer;

		public static MapDoorArray Load(string path)
		{
			var sbi = new MapDoorArray();

			using (var binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
			{
				sbi.TotalHeadCount = binaryReader.ReadUInt32();
				sbi.Doors = new List<MapDoorBlockElement>();

				if (sbi.TotalHeadCount >= 32)
				{
					throw new Exception($"There are too many doors! ({sbi.TotalHeadCount})");
				}

				uint totalDataSize = 0;
				for (var i = 0; i < sbi.TotalHeadCount; i++)
				{
					var blockName = Encoding.UTF8.GetString(binaryReader.ReadBytes(32));
					blockName = blockName.Substring(0, blockName.IndexOf('\0'));

					var startX = binaryReader.ReadUInt32();
					var startY = binaryReader.ReadUInt32();
					var endX = binaryReader.ReadUInt32();
					var endY = binaryReader.ReadUInt32();
					var dataSize = binaryReader.ReadUInt32();
					var address = binaryReader.ReadUInt32();

					sbi.Doors.Add(new MapDoorBlockElement(blockName, startX, startY, endX, endY, dataSize, address,
						Color.Red));

					if (endX < startX)
					{
						throw new Exception(
							$"End X cannot be smaller than Start X for door {i} ({sbi.Doors[i].BlockName})!\nStart X = {startX}\nEnd X = {endX}");
					}

					if (endY < startY)
					{
						throw new Exception(
							$"End Y cannot be smaller than Start Y for door {i} ({sbi.Doors[i].BlockName})!\nStart Y = {startY}\nEnd Y = {endY}");
					}

					if (sbi.Doors[i].GetWidth() % 8 != 0)
					{
						throw new Exception($"Byte alignment error at door {i} ({sbi.Doors[i].BlockName})");
					}

					var size = sbi.Doors[i].GetHeight() * (sbi.Doors[i].GetWidth() / 8);

					if (size != sbi.Doors[i].DataSize)
					{
						throw new Exception(
							$"Length error at door {i} ({sbi.Doors[i].BlockName}): expected: {sbi.Doors[i].DataSize}, got: {size}");
					}

//					uint height = (endY - startY + 1);

//					sbi.Doors[i].StartY = blockYSize - startY - height;
//					sbi.Doors[i].EndY = sbi.Doors[i].StartY + height;

					totalDataSize += (2 * dataSize);
				}

				sbi.BlockBuffer = binaryReader.ReadBytes((int) totalDataSize);

				for (var i = 0; i < sbi.TotalHeadCount; i++)
				{
					var door = sbi.Doors[i];
					var size = (int)door.DataSize * 2;
					door.Data = new byte[size];

					Buffer.BlockCopy(sbi.BlockBuffer, (int)door.Address, door.Data, 0, size);
					door.SetBitmap();
				}
			}

			return sbi;
		}

		public void Export(string path)
		{
			using (var binaryWriter = new BinaryWriter(File.Create(path)))
			{
				binaryWriter.Write(Doors.Count);

				foreach (var door in Doors)
				{
					door.Export(binaryWriter);
				}

				foreach (var door in Doors)
				{
					door.ExportDoor(binaryWriter);
				}
			}
		}

		public void UpdateDoors()
		{
			for (var i = 0; i < TotalHeadCount; i++)
			{
				var current = Doors[i];

				// First element
				if (i == 0)
				{
					current.Address = 0;
				}
				// Rest
				else
				{
					var previous = Doors[i - 1];
					current.Address = previous.Address + previous.DataSize * 2;
				}
			}
		}
	}
}
