using BarChartGraphicsSample.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarChartGraphicsSample
{
	public partial class BarChartControl : Control
	{
		#region Properties
		private BarChartValue[] _data;
		public BarChartValue[] Data
		{
			get { return _data; }
			set
			{
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

			//determine the width of the bars
			var barWidth = clipRectangle.Width / Data.Length;
			//compute the maximum bar height
			var maxBarHeight = clipRectangle.Height * 0.9;
			//compute the scaling factor based on the maximum value that we want to represent
			var scalingFactor = maxBarHeight / Data.Max(x => x.Value);

			Brush redBrush = new SolidBrush(Color.Red);

			for (int i = 0; i < Data.Length; i++)
			{
				var barHeight = Data[i].Value * scalingFactor;

				graphics.FillRectangle(
					redBrush,
					i * barWidth,
					(float)(clipRectangle.Height - barHeight),
					(float)(0.8 * barWidth),
					(float)barHeight);
			}
		}
	}
}
