using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace NumericTextBoxUserControlSample
{
	public partial class NumericTextBoxCompositeControl : UserControl
	{
        #region Properties
        /// <summary>
        /// Override the virtual Text property defined in the Control class to return the value in the TextBox
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [AllowNull]
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
        public NumericTextBoxCompositeControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Allow only digits and BackSpace
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A KeyPressEventArgs that contains the event data.</param>
		private void tbNumericValue_KeyPress(object sender, KeyPressEventArgs e)
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

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			tbNumericValue.Text = string.Empty;	
		}
	}
}
