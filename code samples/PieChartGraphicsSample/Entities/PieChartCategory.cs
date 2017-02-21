using System.Drawing;

namespace PieChartGraphicsSample.Entities
{
	public class PieChartCategory
	{
		public string Description { get; set; }

		public float Percentage { get; set; }

		public Color Color { get; set; }

		public PieChartCategory(string description, float percent, Color color)
		{
			Description = description;
			Percentage = percent;
			Color = color;
		}
	}
}
