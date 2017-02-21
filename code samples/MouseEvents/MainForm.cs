using System;
using System.Windows.Forms;

namespace MouseEvents
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			lbl.Text = "";
			txt.Text = "";
		}

		private void lbl_MouseEnter(object sender, EventArgs e)
		{
			lbl.Text = "MouseEnter";
			TextBoxDraw("###Label MouseEnter");
		}

		private void lbl_MouseHover(object sender, EventArgs e)
		{
			lbl.Text = "MouseHover";
			TextBoxDraw("###Label MouseHover");
		}

		private void lbl_MouseLeave(object sender, EventArgs e)
		{
			lbl.Text = "MouseLeave";
			TextBoxDraw("###Label MouseLeave");
		}

		private void lbl_MouseDown(object sender, MouseEventArgs e)
		{
			lbl.Text = "MouseDown";
			var str = "###Label MouseDown";
			str += Environment.NewLine + "Button:  " + e.Button;
			str += Environment.NewLine + "Clicks:  " + e.Clicks;
			str += Environment.NewLine + "Delta:  " + e.Delta;
			str += Environment.NewLine + "X:  " + e.X;
			str += Environment.NewLine + "Y:  " + e.Y;
			TextBoxDraw(str);
		}

		private void lbl_MouseMove(object sender, MouseEventArgs e)
		{
			lbl.Text = "MouseMove";
			var str = "###Label MouseMove";
			str += Environment.NewLine + "Button:  " + e.Button;
			str += Environment.NewLine + "Clicks:  " + e.Clicks;
			str += Environment.NewLine + "Delta:  " + e.Delta;
			str += Environment.NewLine + "X:  " + e.X;
			str += Environment.NewLine + "Y:  " + e.Y;
			TextBoxDraw(str);
		}

		private void lbl_MouseUp(object sender, MouseEventArgs e)
		{
			lbl.Text = "MouseUp";
			var str = "###Label MouseUp";
			str += Environment.NewLine + "Button:  " + e.Button;
			str += Environment.NewLine + "Clicks:  " + e.Clicks;
			str += Environment.NewLine + "Delta:  " + e.Delta;
			str += Environment.NewLine + "X:  " + e.X;
			str += Environment.NewLine + "Y:  " + e.Y;
			TextBoxDraw(str);
		}

		private void lbl_MouseWheel(object sender, MouseEventArgs e)
		{
			lbl.Text = "MouseWheel";
			var str = "###Label MouseWheel";
			str += Environment.NewLine + "Button:  " + e.Button;
			str += Environment.NewLine + "Clicks:  " + e.Clicks;
			str += Environment.NewLine + "Delta:  " + e.Delta;
			str += Environment.NewLine + "X:  " + e.X;
			str += Environment.NewLine + "Y:  " + e.Y;
			TextBoxDraw(str);
		}

		private void lbl_Click(object sender, EventArgs e)
		{
			lbl.Text = "Click";
			TextBoxDraw("###Label Click");
		}

		private void lbl_DoubleClick(object sender, EventArgs e)
		{
			lbl.Text = "DoubleClick";
			TextBoxDraw("###Label DoubleClick");
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			TextBoxDraw("###Form MouseEnter");
		}

		protected override void OnMouseHover(EventArgs e)
		{
			base.OnMouseHover(e);
			TextBoxDraw("###Form MouseHover");
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			TextBoxDraw("###Form MouseLeave");
		}

		private void TextBoxDraw(string str)
		{
			txt.AppendText(Environment.NewLine + str);
		}
	}
}
