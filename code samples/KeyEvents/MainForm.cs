using System;
using System.Windows.Forms;

namespace KeyEVents
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		#region Methods
		private void KeyMsgBox(string str, KeyEventArgs e)
		{
			txtMsg.AppendText(str + " event." + "\r\n");
			txtMsg.AppendText("\t" + "KeyCode name: " + e.KeyCode + "\r\n");
			txtMsg.AppendText("\t" + "KeyCode key code: " + (int)e.KeyCode +"\r\n");
			txtMsg.AppendText("\t" + "KeyData name: " + e.KeyData + "\r\n");
			txtMsg.AppendText("\t" + "KeyData key code: " + (int)e.KeyData +"\r\n");
			txtMsg.AppendText("\t" + "KeyValue: " + e.KeyValue + "\r\n");
			txtMsg.AppendText("\t" + "Handled: " + e.Handled + "\r\n");
			txtMsg.AppendText("\r\n");
		}
		#endregion

		#region Events
		private void txtInput_KeyDown(object sender, KeyEventArgs e)
		{
			KeyMsgBox("KeyDown", e);
		}

		private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
		{
			var keyChar = e.KeyChar;

			txtMsg.AppendText("KeyPress event." + "\r\n");
			txtMsg.AppendText("\t" + "KeyChar: " + keyChar + "\r\n");
			txtMsg.AppendText("\t" + "KeyChar Code: " + (int)keyChar + "\r\n");
			txtMsg.AppendText("\t" + "Handled: " + e.Handled + "\r\n");
			txtMsg.AppendText("\r\n");

			//  Fill in the Upper and Lower labels
			lblUpper.Text = keyChar.ToString().ToUpper();
			lblLower.Text = keyChar.ToString().ToLower();

			//  Change $ to #
			if (keyChar.ToString() == "$")
			{
				txtInput.AppendText("#");
				e.Handled = true;
			}
		}

		private void txtInput_KeyUp(object sender, KeyEventArgs e)
		{
			KeyMsgBox("KeyUp", e);
		}

		private void btnReset_Click(object sender, System.EventArgs e)
		{
			txtMsg.Text = "";
			txtInput.Text = "";
			lblUpper.Text = "";
			lblLower.Text = "";
		}

		private void txtInput_TextChanged(object sender, EventArgs e)
		{

		}
		#endregion
	}
}
