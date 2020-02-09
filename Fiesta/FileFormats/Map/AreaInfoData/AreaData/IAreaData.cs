using System.ComponentModel;

namespace Fiesta.FileFormats.Map.AreaInfoData.AreaData
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class IAreaData : ExpandableObjectConverter
	{
		public float CenterX { get; set; }
		public float CenterY { get; set; }

		public IAreaData(float centerX, float centerY)
		{
			CenterX = centerX;
			CenterY = centerY;
		}

		public override string ToString()
		{
			return "";
		}
	}
}
