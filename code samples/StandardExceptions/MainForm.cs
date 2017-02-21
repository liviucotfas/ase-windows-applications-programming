using System;
using System.Globalization;
using System.Windows.Forms;

namespace StandardExceptions
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			try
			{
				int value1 = int.Parse(tbValue1.Text);
				int value2 = int.Parse(tbValue2.Text);

				tbResult.Text = (value1/value2).ToString(CultureInfo.InvariantCulture);

				//Throwing an exception:
				//throw new NotImplementedException();
			}
			catch (FormatException ex)
			{
				MessageBox.Show(ex.Message);

				//Rethrowing the exception
				//throw; //Handled by Program.Application_ThreadException
			}
			catch (DivideByZeroException ex)
			{
				MessageBox.Show(ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
