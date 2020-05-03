using System;
using System.Windows.Forms;

namespace NumericTextBoxUserControlSample
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnGetUserControlValue_Click(object sender, EventArgs e)
		{
			MessageBox.Show(ucNumericTextBox.Text);
		}
	}
}
