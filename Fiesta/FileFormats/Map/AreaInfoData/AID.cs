using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Fiesta.FileFormats.Map.AreaInfoData.AreaData;
using static Fiesta.StringHelper;

namespace Fiesta.FileFormats.Map.AreaInfoData
{
	public class AID
	{
		public uint TotalDataCount;
		public BindingList<AreaInfoData> Data;

		public static AID Load(string path)
		{
			var aid = new AID();

			using (var binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
			{
				aid.TotalDataCount = binaryReader.ReadUInt32();
				aid.Data = new BindingList<AreaInfoData>();

				for (var i = 0; i < aid.TotalDataCount; i++)
				{
					var name = Encoding.UTF8.GetString(binaryReader.ReadBytes(32));
					name = name.Substring(0, name.IndexOf('\0'));

					var nAreaType = (AreaType)binaryReader.ReadInt32();

					if (nAreaType == AreaType.Circle)
					{
						var centerX = binaryReader.ReadSingle();
						var centerY = binaryReader.ReadSingle();
						var radius  = binaryReader.ReadSingle();

						aid.Data.Add(new AreaInfoData(name, nAreaType, new AE_Circle(centerX, centerY, radius)));
					}

					else if (nAreaType == AreaType.Square)
					{
						var centerX = binaryReader.ReadSingle();
						var centerY = binaryReader.ReadSingle();
						var radiusU = binaryReader.ReadSingle();
						var radiusV = binaryReader.ReadSingle();
						var angle   = binaryReader.ReadSingle();
						
						aid.Data.Add(new AreaInfoData(name, nAreaType, new AE_Square(centerX, centerY, radiusU, radiusV, angle)));
					}
					else
					{
						throw new System.Exception($"nAreaData is corrupt! Please check area {i} ({name}) with nAreaType {nAreaType}.");
					}
				}
			}

			MessageBox.Show($"{Path.GetFileName(path)} successfully loaded!");
			return aid;
		}

		public void Save(string path, string fileName)
		{
			using (var writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
			{
				writer.Write(TotalDataCount);
				foreach (var aid in Data)
				{
					writer.Write(GetBytes(aid.Name, 32));

					writer.Write((int)aid.nAreaType);
					if (aid.nAreaType == AreaType.Circle)
					{
						var circle = (AE_Circle)aid.Data;
						writer.Write(circle.CenterX);
						writer.Write(circle.CenterY);
						writer.Write(circle.Radius);
					}
					else if (aid.nAreaType == AreaType.Square)
					{
						var square = (AE_Square)aid.Data;
						writer.Write(square.CenterX);
						writer.Write(square.CenterY);
						writer.Write(square.RadiusU);
						writer.Write(square.RadiusV);
						writer.Write(square.Angle);
					}
				}
			}

			MessageBox.Show($"{fileName} has successfully been saved.");
		}
	}
}