using System.Drawing;

namespace PieChartGraphicsSample.Entities
{
	public class PieChartCategory
	{
		public string Label { get; set; }

		public float Percentage { get; set; }

		public Color Color { get; set; }

		public PieChartCategory(string label, float percent, Color color)
		{
			Label = label;
			Percentage = percent;
			Color = color;
		}
	}
}
