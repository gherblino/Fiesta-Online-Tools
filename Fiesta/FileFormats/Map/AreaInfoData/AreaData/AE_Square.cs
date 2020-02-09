namespace Fiesta.FileFormats.Map.AreaInfoData.AreaData
{
	public class AE_Square : IAreaData
	{
		public float RadiusU { get; set; }
		public float RadiusV { get; set; }
		public float Angle   { get; set; }

		public AE_Square(float centerX, float centerY, float radiusU, float radiusV, float angle) : base(centerX, centerY)
		{
			RadiusU = radiusU;
			RadiusV = radiusV;
			Angle = angle;
		}
	}
}
