using System.Drawing;
using System.Windows.Forms;
using PieChartGraphicsSample.Entities;

namespace PieChartGraphicsSample
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			PieChartCategory[] pieCategories = {
				new PieChartCategory("Gold", 20, Color.Red),
				new PieChartCategory("Stocks", 15, Color.Blue),
				new PieChartCategory("Bonds", 35, Color.Magenta),
				new PieChartCategory("ETFs", 15, Color.YellowGreen),
				new PieChartCategory("Options", (float) 7.5, Color.Tomato),
				new PieChartCategory("Cash", (float) 7.5, Color.Beige)
			};

			pieChartControl.Data = pieCategories;
		}
	}
}
