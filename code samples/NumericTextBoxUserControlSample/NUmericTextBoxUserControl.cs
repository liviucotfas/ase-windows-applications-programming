using System.Windows.Forms;

namespace NumericTextBoxUserControlSample
{
	public partial class NumericTextBoxUserControl : UserControl
	{
		#region Properties
		/// <summary>
		/// Override the virtual Text property defined in the Control class to return the value in the TextBox
		/// </summary>
		public override string Text
		{ 
			get
			{
				return tbNumericValue.Text;
			}
			set
			{
				tbNumericValue.Text = value;
			}
		}

		//TODO Add a Int32 property for accessing the numeric value in the TextBox

		#endregion
		public NumericTextBoxUserControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Allow only digits and BackSpace
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A KeyPressEventArgs that contains the event data.</param>
		private void NumericTextBoxUserControl_KeyPress(object sender, KeyPressEventArgs e)
		{
			OnKeyPress(e);

			if (char.IsDigit(e.KeyChar))
			{
				// Digits are OK
			}
			else if (e.KeyChar == (char)Keys.Back)
			{
				// Backspace key is OK
			}
			else
			{
				// Consume this invalid key
				e.Handled = true;
			}
		}
	}
}
