namespace Fiesta.FileFormats.Map.AreaInfoData.AreaData
{
	public class AE_Circle : IAreaData
	{
		public float Radius { get; set; }

		public AE_Circle(float centerX, float centerY, float radius) : base(centerX, centerY)
		{
			Radius = radius;
		}
	}
}
