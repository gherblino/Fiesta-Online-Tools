using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Fiesta.FileFormats.Map.AreaInfoData;
using Fiesta.FileFormats.Map.ShineBlockInfo;
using Fiesta.FileFormats.Map.ShineBlockData;
using Fiesta.FileFormats.Map.ShineMapData;

namespace Fiesta.FileFormats.Map
{
	public class MapBlockInformation
	{
		public uint MapXSize;
		public uint MapYSize;
		public uint BlockXSize;
		public uint BlockYSize;
		public uint XByte;
		public uint UIRealOneSideDataSize;
		public uint UIOneSideBlockCount;

		public AID AID;
		public bool HasAID;
		public SHBD SHAB;
		public bool HasSHAB;
		public SHBD SHBD;
		public bool HasSHBD;
		public SHMD SHMD;
		public bool HasSHMD;
		public MapDoorArray SBI;
		public bool HasSBI;

		public static MapBlockInformation Load(string folderPath, string mapInx)
		{
			var mbi = new MapBlockInformation();

			var baseFilePath = folderPath + Path.DirectorySeparatorChar + mapInx;

			// Loads SHBD file if it exists and sets MapBlockInformation
			if (File.Exists(baseFilePath + ".shbd"))
			{
				mbi.HasSHBD = true;
				mbi.SHBD = SHBD.Load(baseFilePath + ".shbd");
				var x = (uint)mbi.SHBD.XSize;
				var y = (uint)mbi.SHBD.YSize;

				mbi.BlockXSize = 8 * x;
				mbi.BlockYSize = y;
				mbi.MapXSize = 5000 * x / 0x64;
				mbi.XByte = x;
				mbi.MapYSize = 625 * mbi.BlockYSize / 0x64;
				mbi.UIRealOneSideDataSize = x;
				mbi.UIOneSideBlockCount = y;
			}
			else
			{
				throw new Exception($"{baseFilePath}.shbd was not found!");
			}

			// Loads SHAB file if it exists
			if (File.Exists(baseFilePath + ".shab"))
			{
				mbi.HasSHAB = true;
				mbi.SHAB = SHBD.Load(baseFilePath + ".shab");
			}

			// Loads MapDoorArray file if it exists
			if (File.Exists(baseFilePath + ".sbi"))
			{
				//TODO: Figure out what BlockYSize is, maybe actual in game size?
//				mbi.SBI = MapDoorArray.Load(baseFilePath + ".sbi", mbi.BlockYSize);
				mbi.SBI = MapDoorArray.Load(baseFilePath + ".sbi");
				mbi.HasSBI = true;
			}

			if (File.Exists(baseFilePath + ".aid"))
			{
				mbi.HasAID = true;
				mbi.AID = AID.Load(baseFilePath + ".aid");
			}

			if (File.Exists(baseFilePath + ".shmd"))
			{
				mbi.HasSHMD = true;
				mbi.SHMD = SHMD.Load(baseFilePath + ".shmd");
			}

			return mbi;
		}

		public static MapBlockInformation LoadSBI(string folderPath, string mapInx)
		{
			var mbi = new MapBlockInformation();

			var baseFilePath = folderPath + Path.DirectorySeparatorChar + mapInx;

			// Loads SHBD file if it exists and sets MapBlockInformation
			if (File.Exists(baseFilePath + ".shbd"))
			{
				mbi.HasSHBD = true;
				mbi.SHBD = SHBD.Load(baseFilePath + ".shbd");
				var x = (uint)mbi.SHBD.XSize;
				var y = (uint)mbi.SHBD.YSize;

				mbi.BlockXSize = 8 * x;
				mbi.BlockYSize = y;
				mbi.MapXSize = 5000 * x / 0x64;
				mbi.XByte = x;
				mbi.MapYSize = 625 * mbi.BlockYSize / 0x64;
				mbi.UIRealOneSideDataSize = x;
				mbi.UIOneSideBlockCount = y;
			}
			else
			{
				MessageBox.Show($"{baseFilePath}.shbd was not found!");
				Environment.Exit(0);
			}

			// Loads MapDoorArray file if it exists
			if (File.Exists(baseFilePath + ".sbi"))
			{
				//TODO: Figure out what BlockYSize is, maybe actual in game size?
				//				mbi.SBI = MapDoorArray.Load(baseFilePath + ".sbi", mbi.BlockYSize);
				mbi.SBI = MapDoorArray.Load(baseFilePath + ".sbi");
				mbi.HasSBI = true;
			}
			return mbi;
		}
	}
}
