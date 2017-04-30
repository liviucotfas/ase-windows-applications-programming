namespace BarChartGraphicsSample.Entities
{
	public class BarChartValue
	{
		public object X { get; set; }
		public float Y { get; set; }

		public BarChartValue(object x, float y)
		{
			X = x;
			Y = y;
		}
	}
}
