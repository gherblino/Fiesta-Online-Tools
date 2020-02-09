using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Fiesta.FileFormats.Map.ShineMapData.Elements;
using static Fiesta.StringHelper;

namespace Fiesta.FileFormats.Map.ShineMapData
{
	public class SHMD
	{
		public string Header;

		public MainMapElement Sky { get; set; }
		public MainMapElement Water { get; set; }
		public MainMapElement GroundObject { get; set; }

		public GlobalLight GlobalLight { get; set; }
		public Fog Fog { get; set; }
		public BackGroundColor BackGroundColor { get; set; }
		public Frustum Frustum { get; set; }

		public BindingList<MapObject> MapObjects { get; set; }

		public DirectionLightAmbient DirectionLightAmbient { get; set; }
		public DirectionLightDiffuse DirectionLightDiffuse { get; set; }

		public static SHMD Load(string path)
		{
			SHMD shmd = new SHMD();
	
			int linePos = 0;

			string[] contents = File.ReadAllLines(path);

			// Check header
			shmd.Header = contents[linePos].Trim();
			if (shmd.Header != "shmd0_5")
			{
				throw new System.Exception($"Incorrect header ({shmd.Header})! Please make sure that the header is \"shmd0_5\".");
			}

			linePos++;

			// Check Sky
			shmd.Sky = new MainMapElement("Sky", contents, linePos);
			linePos += shmd.Sky.MapElements.Count + 1;

			// Check Water
			shmd.Water = new MainMapElement("Water", contents, linePos);
			linePos += shmd.Water.MapElements.Count + 1;

			// Check GroundObject
			shmd.GroundObject = new MainMapElement("GroundObject", contents, linePos);
			linePos += shmd.GroundObject.MapElements.Count + 1;

			// Check GlobalLight
			shmd.GlobalLight = new GlobalLight(contents[linePos].Trim().Split(' '), linePos);
			linePos++;

			// Check Fog
			shmd.Fog = new Fog(contents[linePos].Trim().Split(' '), linePos);
			linePos++;

			// Check BackGroundColor
			shmd.BackGroundColor = new BackGroundColor(contents[linePos].Trim().Split(' '), linePos);
			linePos++;

			// Check Frustum
			shmd.Frustum = new Frustum(contents[linePos].Trim().Split(' '), linePos);
			linePos++;

			shmd.MapObjects = new BindingList<MapObject>();
			while (contents[linePos].Trim() != "DataObjectLoadingEnd")
			{
				MapObject mo = new MapObject(contents, linePos);
				shmd.MapObjects.Add(mo);
				linePos += mo.Positions.Count + 1;
			}
			linePos++;

			shmd.DirectionLightAmbient = new DirectionLightAmbient(contents[linePos].Trim().Split(' '), linePos);
			linePos++;

			shmd.DirectionLightDiffuse = new DirectionLightDiffuse(contents[linePos].Trim().Split(' '), linePos);
			linePos++;

			MessageBox.Show("Successfully loaded the SHMD file!");
			return shmd;
		}

		public void Save(string path)
		{
			using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
			{
				// Write Header
				writer.Write(GetBytes($"{Header}\n"));

				// Write Sky information
				writer.Write(GetBytes($"Sky {Sky.MapElements.Count}\n"));
				foreach (MapElement me in Sky.MapElements)
				{
					writer.Write(GetBytes($"{me.Path}\n"));
				}

				// Write Water information
				writer.Write(GetBytes($"Water {Water.MapElements.Count}\n"));
				foreach (MapElement me in Water.MapElements)
				{
					writer.Write(GetBytes(me.Path + "\n"));
				}

				// Write GroundObject information
				writer.Write(GetBytes($"GroundObject {GroundObject.MapElements.Count}\n"));
				foreach (MapElement me in GroundObject.MapElements)
				{
					writer.Write(GetBytes(me.Path + "\n"));
				}

				// Write GlobalLight
				writer.Write(GetBytes($"GlobalLight {GetStringFromFloat(GlobalLight.Color.Red)} {GetStringFromFloat(GlobalLight.Color.Green)} {GetStringFromFloat(GlobalLight.Color.Blue)}\n"));

				// Write Fog
				writer.Write(GetBytes($"Fog {GetStringFromFloat(Fog.FogDepth)} {GetStringFromFloat(Fog.Color.Red)} {GetStringFromFloat(Fog.Color.Green)} {GetStringFromFloat(Fog.Color.Blue)} \n"));


				// Write BackGroundColor
				writer.Write(GetBytes($"BackGroundColor {GetStringFromFloat(BackGroundColor.Color.Red)} {GetStringFromFloat(BackGroundColor.Color.Green)} {GetStringFromFloat(BackGroundColor.Color.Blue)} \n"));

				// Write Frustum
				writer.Write(GetBytes($"Frustum {GetStringFromFloat(Frustum.FrustumFar)}\n"));

				// Write MapObjects
				foreach (MapObject mo in MapObjects)
				{
					writer.Write(GetBytes($"{mo.Path} {mo.Positions.Count}\n"));
					foreach (Position p in mo.Positions)
					{
						writer.Write(GetBytes($"{GetStringFromFloat(p.X)} {GetStringFromFloat(p.Y)} {GetStringFromFloat(p.Z)} {GetStringFromFloat(p.Unk)} {GetStringFromFloat(p.Yaw)} {GetStringFromFloat(p.Pitch)} {GetStringFromFloat(p.Roll)} {GetStringFromFloat(p.Scale)}\n"));
					}
				}

				// Write end of MapObjects
				writer.Write(GetBytes("DataObjectLoadingEnd\n"));

				// Write DirectionLightAmbient
				writer.Write(GetBytes($"DirectionLightAmbient {GetStringFromFloat(DirectionLightAmbient.Color.Red)} {GetStringFromFloat(DirectionLightAmbient.Color.Green)} {GetStringFromFloat(DirectionLightAmbient.Color.Blue)}\n"));

				// Write DirectionLightDiffuse
				writer.Write(GetBytes($"DirectionLightDiffuse {GetStringFromFloat(DirectionLightDiffuse.Color.Red)} {GetStringFromFloat(DirectionLightDiffuse.Color.Green)} {GetStringFromFloat(DirectionLightDiffuse.Color.Blue)}\n"));
			}

			MessageBox.Show($"{Path.GetFileName(path)} has successfully been saved!");
		}
	}
}
