using System;
using System.Drawing;
using System.Windows.Forms;
using PieChartGraphicsSample.Entities;

namespace PieChartGraphicsSample
{
	public partial class PieChartControl : UserControl
	{
		#region Properties
		private PieChartCategory[] _data;
		public PieChartCategory[] Data {
			get { return _data; }
			set
			{
				if(_data == value)
					return;

				_data = value;

				//trigger the Paint event
				Invalidate();
			}
		}
		#endregion

		public PieChartControl()
		{
			InitializeComponent();

			//redraws the chart if the control is resized
			ResizeRedraw = true;

			//default data
			Data = new[]
			{
				new PieChartCategory("Category 1", 20, Color.Red),
				new PieChartCategory("Category 2", 80, Color.Blue)
			};
		}

		private void PieChartControl_Paint(object sender, PaintEventArgs e)
		{
			//width reserved for displaying the legend
			int legendWidth = 150;

			//get the drawing context
			Graphics graphics = e.Graphics;
			//get the drawing area
			Rectangle clipRectangle = e.ClipRectangle;
			
			//compute the maximum radius
			float radius = Math.Min(clipRectangle.Height, clipRectangle.Width - legendWidth) / (float)2;

			//determine the center of the pie
			int xCenter = (clipRectangle.Width - legendWidth) / 2;
			int yCenter = clipRectangle.Height / 2;

			//determine the x and y coordinate of the pie
			float x = xCenter - radius;
			float y = yCenter - radius;

			//determine the width and the height
			float width = radius * 2;
			float height = radius * 2;

			//draw the pie sectors
			float percent1 = 0;
			float percent2 = 0;
			for (int i = 0; i < Data.Length; i++)
			{
				if (i >= 1)
					percent1 += Data[i - 1].Percentage;

				percent2 += Data[i].Percentage;

				float angle1 = percent1 / 100 * 360;
				float angle2 = percent2 / 100 * 360;

				Brush b = new SolidBrush(Data[i].Color);

				graphics.FillPie(b, x, y, width, height, angle1, angle2 - angle1);
			}

			//draw the pie contour
			Pen pen = new Pen(Color.Black);
			graphics.DrawEllipse(pen, x, y, width, height);

			//draw the chart legend
			float xpos = x + width + 20;
			float ypos = y;
			for (int i = 0; i < Data.Length; i++)
			{
				Brush b = new SolidBrush(Data[i].Color);

				graphics.FillRectangle(b, xpos, ypos, 30, 30);
				graphics.DrawRectangle(pen, xpos, ypos, 30, 30);

				Brush b2 = new SolidBrush(Color.Black);

				graphics.DrawString(
					Data[i].Label + ": " + Data[i].Percentage + "%", 
					Font, 
					b2,
					xpos + 35, 
					ypos + 12);

				ypos += 35;
			}
		}
	}
}
