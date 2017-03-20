using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SimpleWebBrowser
{
	public partial class MainForm : Form
	{
		// Constructor
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Text = "MyWebBrowser";
			Size = new Size(600, 400);
			wb.GoHome();
		}

		#region WebBrowser Events
		private void wb_Navigating(object sender, WebBrowserNavigatingEventArgs e)
		{
			pbLoad.MarqueeAnimationSpeed = 80;
			pbLoad.Style = ProgressBarStyle.Marquee;
		}

		private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			pbLoad.MarqueeAnimationSpeed = 0;
			pbLoad.Style = ProgressBarStyle.Blocks;
		}

		private void wb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			pbLoad.MarqueeAnimationSpeed = 0;
			pbLoad.Style = ProgressBarStyle.Blocks;
		}
		#endregion

		#region MenuStrip Events
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.InitialDirectory = "c:\\";
			openFileDialog1.Filter = "txt files (*.html)|*.html|All files (*.*)|*.*";
			openFileDialog1.FilterIndex = 2;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				GoToUrl(openFileDialog1.FileName);
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Version 1.00", "About");
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "html files (*.html)|*.html|All files (*.*)|*.*";
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.RestoreDirectory = true;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				//Other file methods http://msdn.microsoft.com/en-us/library/system.io.file.createtext.aspx
				using (StreamWriter sr = File.CreateText(saveFileDialog.FileName))
				{
					sr.Write(wb.DocumentText);
					//sr.Close(); //already called by Dispose
				}
			}

			//A different approach: call wb.ShowSaveAsDialog();
		}
		#endregion

		#region ToolStrip Events
		private void btnBack_Click(object sender, EventArgs e)
		{
			wb.GoBack();
		}

		private void btnFwd_Click(object sender, EventArgs e)
		{
			wb.GoForward();
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			wb.Refresh();
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			wb.GoHome();
		}

		private void GoToUrl(string url)
		{
			Cursor.Current = Cursors.WaitCursor;
			try
			{
				wb.Navigate(url);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			Cursor.Current = Cursors.Default;
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			GoToUrl(tbAddress.Text);
		}

		private void tbAddress_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return) GoToUrl(tbAddress.Text);
		}
		#endregion

		private void ctxMenuBtnBack_Click(object sender, EventArgs e)
		{
			wb.GoBack();
		}

		private void ctxMenuBtnReload_Click(object sender, EventArgs e)
		{
			wb.Refresh();
		}
	}
}
