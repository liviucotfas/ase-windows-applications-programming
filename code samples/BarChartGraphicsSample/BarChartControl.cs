using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BarChartGraphicsSample.Entities;

namespace BarChartGraphicsSample
{
	public partial class BarChartControl : UserControl
	{
		#region Properties
		private BarChartValue[] _data;
		public BarChartValue[] Data
		{
			get { return _data; }
			set
			{
				if (_data == value)
					return;

				_data = value;

				//trigger the Paint event
				Invalidate();
			}
		}
		#endregion

		public BarChartControl()
		{
			InitializeComponent();

			//redraws the chart if the control is resized
			ResizeRedraw = true;

			//default data
			Data = new[]
			{
				new BarChartValue("2015", 30), 
				new BarChartValue("2016", 80),
				new BarChartValue("2017", 40)
			};
		}

		private void BarChartControl_Paint(object sender, PaintEventArgs e)
		{
			//get the drawing context
			Graphics graphics = e.Graphics;
			//get the drawing area
			Rectangle clipRectangle = e.ClipRectangle;

			//determine the width and the height
			float width = clipRectangle.Width;
			float height = clipRectangle.Height;

			var barWidth = width / Data.Length;
			var maxBarHeight = height * 0.9;
			var scalingFactor = maxBarHeight / Data.Max(x=>x.Y);
			
			for (int i = 0; i < Data.Length; i++)
			{
				Brush b = new SolidBrush(Color.Red);

				var barHeight = (float) (Data[i].Y * scalingFactor);

				graphics.FillRectangle(b, i * barWidth, height - barHeight, 0.8f * barWidth, barHeight);
			}
		}	
	}
}
