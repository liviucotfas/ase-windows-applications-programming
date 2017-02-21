using System;
using System.Windows.Forms;
using ClipboardSample.Entities;
using ClipboardSample.Properties;

namespace ClipboardSample
{
	public partial class MainForm : Form
	{
		#region Attributes

		private string _stringHtml;
		private string _stringRtf;
		private string _stringPlainText;
		private readonly Participant _participant;

		#endregion
		
		public MainForm()
		{
			InitializeComponent();

			_participant = new Participant("LastName1", "FirstName1", DateTime.Now);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			//Load the picture from My.Resources
			pbCopy.Image = Resources.Sunset;

			//Load some text into the web brower
			_stringHtml = "<HTML><BODY>This is <B>HTML</B></BODY></HTML>";
			wbCopyHtml.DocumentText = _stringHtml;

			//Load some text in the rich text box
			_stringRtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{" +
			             "\\f0\\fswiss\\fcharset0 Arial;}}\\viewkind4\\uc1\\pard\\f0\\fs20\\ul\\b\\fs24 " +
			             "This\\ulnone\\b0  \\fs20 is \\fs36 RTF!\\par}";
			rtbCopy.Rtf = _stringRtf;

			//Load some text in the plain text box
			_stringPlainText = "This is plain text";
			tbCopy.Text = _stringPlainText;

			//Display the participant
			tbCopyObject.Text = _participant.ToString();
		}

		#region Events
		private void CopyImageButton_Click(object sender, EventArgs e)
		{
			//Copy the picture from the picture box onto the clipboard
			Clipboard.SetImage(pbCopy.Image);
		}

		private void PasteImageButton_Click(object sender, EventArgs e)
		{
			//If image exists in the clipboard, paste it into the picture box
			if (Clipboard.ContainsImage())
			{
				pbPaste.Image = Clipboard.GetImage();
			}
			else
			{
				MessageBox.Show("Clipboard does not contain an image");
			}
		}

		private void CopyHTMLButton_Click(object sender, EventArgs e)
		{
			//Copy HTML from web browser onto the clipboard
			Clipboard.SetText(wbCopyHtml.DocumentText, TextDataFormat.Html);
		}

		private void PasteHTMLButton_Click(object sender, EventArgs e)
		{
			//If clipboard has HTML, paste it into the web browser control
			if (Clipboard.ContainsText(TextDataFormat.Html))
			{
				wbPasteHtml.DocumentText = Clipboard.GetText(TextDataFormat.Html);
			}
			else
			{
				MessageBox.Show("Clipboard does not contain any HTML");
			}
		}

		private void CopyRTFButton_Click(object sender, EventArgs e)
		{
			//Copy text from rich text box onto the clipboard
			Clipboard.SetText(rtbCopy.Rtf, TextDataFormat.Rtf);
		}

		private void PasteRTFButton_Click(object sender, EventArgs e)
		{
			//If clipboard has rich text, paste it into the rich text box
			if (Clipboard.ContainsText(TextDataFormat.Rtf))
			{
				rtbPaste.Rtf = Clipboard.GetText(TextDataFormat.Rtf);
			}
			else
			{
				MessageBox.Show("Clipboard does not contain any rich text");
			}
		}

		private void CopyTextButton_Click(object sender, EventArgs e)
		{
			//Copy text from text box onto the clipboard
			Clipboard.SetText(tbCopy.Text);
		}

		private void PasteTextButton_Click(object sender, EventArgs e)
		{
			//If clipboard has text, paste it into the text box
			if (Clipboard.ContainsText())
			{
				tbPaste.Text = Clipboard.GetText();
			}
			else
			{
				MessageBox.Show("Clipboard does not contain any text");
			}
		}

		private void CopyObjectButton_Click(object sender, EventArgs e)
		{
			//Copy Participant object onto the clipboard
			Clipboard.SetData("ClipboardSample.Participant", _participant);
		}

		private void PasteObjectButton_Click(object sender, EventArgs e)
		{
			//If Clipboard has a Participant object, get it, assign in to another object, and load 
			//the values of the properties of this object into a text box
			if (Clipboard.ContainsData("ClipboardSample.Participant"))
			{
				var tempPixel = (Participant) Clipboard.GetData("ClipboardSample.Participant");
				tbPasteObject.Text = tempPixel.ToString();
			}
			else
			{
				MessageBox.Show("Clipboard does not contain a ClipboardSample.Participant object");
			}
		}

		private void PasteFilesButton_Click(object sender, EventArgs e)
		{
			//If Clipboard has a File Drop List, paste the names of all files in this list in a list box
			if (Clipboard.ContainsFileDropList())
			{
				var fileDropList = Clipboard.GetFileDropList();
				foreach (var fileName in fileDropList)
				{
					lvFiles.Items.Add(fileName);
				}
			}
			else
			{
				MessageBox.Show("Clipboard does not contain a file drop list");
			}
		}

		private void clearClipboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Clear the clipboard
			Clipboard.Clear();
		}
		#endregion
	}
}