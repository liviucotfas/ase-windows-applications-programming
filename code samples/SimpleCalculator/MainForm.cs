using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			var value1 = int.Parse(tbValue1.Text);
			var value2 = int.Parse(tbValue2.Text);

			var sum = value1 + value2;
			tbSum.Text = sum.ToString();
		}
	}
}
