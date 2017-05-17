namespace BarChartGraphicsSample.Entities
{
	public class BarChartValue
	{
		public string Label { get; set; }
		public float Value { get; set; }

		public BarChartValue(string label, float value)
		{
			Label = label;
			Value = value;
		}
	}
}
