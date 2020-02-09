using System.ComponentModel;
using System.IO;
using Fiesta.FileFormats.ActionInfo.Types;
using Fiesta.FileFormats.ActionInfo.Types.Effect;
using Fiesta.FileFormats.ActionInfo.Types.Sound;
using static Fiesta.StringHelper;

namespace Fiesta.FileFormats.ActionInfo
{
	public class ActionInfoSet
	{
		public static uint Total;
		public BindingList<ActionInfo> ActionInfoData;

		public static ActionInfoSet Load(string path)
		{
			var ais = new ActionInfoSet();

			using (var memoryStream = new MemoryStream(File.ReadAllBytes(path)))
			using (var binaryReader = new BinaryReader(memoryStream))
			{
				Total = binaryReader.ReadUInt32();
				ais.ActionInfoData = new BindingList<ActionInfo>();

				for (var i = 0; i < Total; i++)
				{
					var id = binaryReader.ReadUInt16();
					var inxName = GetStringFromBytes(binaryReader.ReadBytes(33));
					var actionName = GetStringFromBytes(binaryReader.ReadBytes(33));
					var weaponDemand = (WeaponDemand)binaryReader.ReadUInt32();
					var aniInx = GetStringFromBytes(binaryReader.ReadBytes(36));
					var eventCode = binaryReader.ReadUInt32();
					var weaponType = (WeaponType)binaryReader.ReadUInt32();
					var effect = new Effect(binaryReader);
					var sound = new Sound(binaryReader);

					ais.ActionInfoData.Add(new ActionInfo(id, inxName, actionName, weaponDemand, aniInx, eventCode, weaponType, effect, sound));
				}
			}

			return ais;
		}

		public void Save(string path)
		{
			using (var writer = new BinaryWriter(File.Open(path, FileMode.Create)))
			{
				writer.Write(Total);
				foreach (var ai in ActionInfoData)
				{
					writer.Write(ai.ID);
					writer.Write(GetBytes(ai.InxName, 33));
					writer.Write(GetBytes(ai.ActionName, 33));
					writer.Write((uint)ai.WeaponDemand);
					writer.Write(GetBytes(ai.AniInx, 36));
					writer.Write(ai.EventCode);
					writer.Write((uint)ai.WeaponType);

					writer.Write(GetBytes(ai.Effect.EffectFiles.String1, 33));
					writer.Write(GetBytes(ai.Effect.EffectFiles.String2, 33));
					writer.Write(GetBytes(ai.Effect.EffectFiles.String3, 34));

					writer.Write(ai.Effect.EffectPosition.X);
					writer.Write(ai.Effect.EffectPosition.Y);
					writer.Write(ai.Effect.EffectPosition.Z);

					writer.Write(ai.Effect.EffectNotes.X);
					writer.Write(ai.Effect.EffectNotes.Y);
					writer.Write(ai.Effect.EffectNotes.Z);

					writer.Write(ai.Effect.EffectKeep.X);
					writer.Write(ai.Effect.EffectKeep.Y);
					writer.Write(ai.Effect.EffectKeep.Z);

					writer.Write(ai.Effect.EffectDirection.X);
					writer.Write(ai.Effect.EffectDirection.Y);
					writer.Write(ai.Effect.EffectDirection.Z);

					writer.Write(GetBytes(ai.Sound.SoundFiles.FirstFile, 33));
					writer.Write(GetBytes(ai.Sound.SoundFiles.SecondFile, 35));

					writer.Write(ai.Sound.SoundPosition.X);
					writer.Write(ai.Sound.SoundPosition.Y);

					writer.Write(ai.Sound.SoundNotes.X);
					writer.Write(ai.Sound.SoundNotes.Y);
					
					writer.Write(ai.Sound.SoundRandomPlay);
				}
			}
		}
	}
}
