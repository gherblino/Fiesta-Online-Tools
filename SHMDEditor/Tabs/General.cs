using System.ComponentModel;
using Fiesta.FileFormats.Map.ShineMapData.Elements;

namespace SHMDEditor.Tabs
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class General
	{
		[DisplayName("Header")]
		public string Header { get; set; }

		[DisplayName("GlobalLight")]
		public GlobalLight GlobalLight { get; set; }

		[DisplayName("Fog")]
		public Fog Fog { get; set; }

		[DisplayName("BackGroundColor")]
		public BackGroundColor BackGroundColor { get; set; }

		[DisplayName("Frustum")]
		public Frustum Frustum { get; set; }

		[DisplayName("DirectionLightAmbient")]
		public DirectionLightAmbient DirectionLightAmbient { get; set; }

		[DisplayName("DirectionLightDiffuse")]
		public DirectionLightDiffuse DirectionLightDiffuse { get; set; }

		public General(string header, GlobalLight globalLight, Fog fog, BackGroundColor backGroundColor, Frustum frustum, DirectionLightAmbient directionLightAmbient, DirectionLightDiffuse directionLightDiffuse)
		{
			Header = header;
			GlobalLight = globalLight;
			Fog = fog;
			BackGroundColor = backGroundColor;
			Frustum = frustum;
			DirectionLightAmbient = directionLightAmbient;
			DirectionLightDiffuse = directionLightDiffuse;
		}
	}
}
