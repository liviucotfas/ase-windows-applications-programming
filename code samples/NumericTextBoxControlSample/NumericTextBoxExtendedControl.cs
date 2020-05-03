using System.Windows.Forms;

namespace NumericTextBoxUserControlSample
{
    public class NumericTextBoxExtendedControl : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
			base.OnKeyPress(e);

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
