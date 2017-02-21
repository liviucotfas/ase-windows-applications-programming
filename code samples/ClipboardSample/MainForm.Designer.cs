namespace ClipboardSample
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbPasteObject = new System.Windows.Forms.TextBox();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.PasteFilesButton = new System.Windows.Forms.Button();
			this.lvFiles = new System.Windows.Forms.ListBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.WindowsExplorerLinkLabel = new System.Windows.Forms.LinkLabel();
			this.Label1 = new System.Windows.Forms.Label();
			this.tbCopyObject = new System.Windows.Forms.TextBox();
			this.PasteTextButton = new System.Windows.Forms.Button();
			this.CopyTextButton = new System.Windows.Forms.Button();
			this.tbPaste = new System.Windows.Forms.TextBox();
			this.tbCopy = new System.Windows.Forms.TextBox();
			this.PasteRTFButton = new System.Windows.Forms.Button();
			this.CopyRTFButton = new System.Windows.Forms.Button();
			this.rtbPaste = new System.Windows.Forms.RichTextBox();
			this.rtbCopy = new System.Windows.Forms.RichTextBox();
			this.PasteHTMLButton = new System.Windows.Forms.Button();
			this.CopyHTMLButton = new System.Windows.Forms.Button();
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.clearClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wbPasteHtml = new System.Windows.Forms.WebBrowser();
			this.PasteObjectButton = new System.Windows.Forms.Button();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.CopyObjectButton = new System.Windows.Forms.Button();
			this.wbCopyHtml = new System.Windows.Forms.WebBrowser();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.PasteImageButton = new System.Windows.Forms.Button();
			this.CopyImageButton = new System.Windows.Forms.Button();
			this.pbPaste = new System.Windows.Forms.PictureBox();
			this.pbCopy = new System.Windows.Forms.PictureBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GroupBox4.SuspendLayout();
			this.MenuStrip1.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPaste)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCopy)).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbPasteObject
			// 
			this.tbPasteObject.BackColor = System.Drawing.SystemColors.MenuBar;
			this.tbPasteObject.Location = new System.Drawing.Point(392, 21);
			this.tbPasteObject.Multiline = true;
			this.tbPasteObject.Name = "tbPasteObject";
			this.tbPasteObject.Size = new System.Drawing.Size(139, 75);
			this.tbPasteObject.TabIndex = 15;
			// 
			// GroupBox4
			// 
			this.GroupBox4.Controls.Add(this.PasteFilesButton);
			this.GroupBox4.Controls.Add(this.lvFiles);
			this.GroupBox4.Controls.Add(this.Label2);
			this.GroupBox4.Controls.Add(this.WindowsExplorerLinkLabel);
			this.GroupBox4.Controls.Add(this.Label1);
			this.GroupBox4.Location = new System.Drawing.Point(13, 561);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(551, 134);
			this.GroupBox4.TabIndex = 8;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Working with Files";
			// 
			// PasteFilesButton
			// 
			this.PasteFilesButton.Location = new System.Drawing.Point(175, 34);
			this.PasteFilesButton.Name = "PasteFilesButton";
			this.PasteFilesButton.Size = new System.Drawing.Size(75, 23);
			this.PasteFilesButton.TabIndex = 18;
			this.PasteFilesButton.Text = "Paste Files";
			this.PasteFilesButton.Click += new System.EventHandler(this.PasteFilesButton_Click);
			// 
			// lvFiles
			// 
			this.lvFiles.FormattingEnabled = true;
			this.lvFiles.Location = new System.Drawing.Point(307, 16);
			this.lvFiles.Name = "lvFiles";
			this.lvFiles.Size = new System.Drawing.Size(222, 108);
			this.lvFiles.TabIndex = 3;
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(32, 39);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(124, 51);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Copy some files and click on the Paste Files button";
			// 
			// WindowsExplorerLinkLabel
			// 
			this.WindowsExplorerLinkLabel.AutoSize = true;
			this.WindowsExplorerLinkLabel.Location = new System.Drawing.Point(61, 18);
			this.WindowsExplorerLinkLabel.Name = "WindowsExplorerLinkLabel";
			this.WindowsExplorerLinkLabel.Size = new System.Drawing.Size(92, 13);
			this.WindowsExplorerLinkLabel.TabIndex = 1;
			this.WindowsExplorerLinkLabel.TabStop = true;
			this.WindowsExplorerLinkLabel.Text = "Windows Explorer";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(31, 18);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(33, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Open";
			// 
			// tbCopyObject
			// 
			this.tbCopyObject.BackColor = System.Drawing.SystemColors.MenuBar;
			this.tbCopyObject.Location = new System.Drawing.Point(30, 21);
			this.tbCopyObject.Multiline = true;
			this.tbCopyObject.Name = "tbCopyObject";
			this.tbCopyObject.Size = new System.Drawing.Size(139, 75);
			this.tbCopyObject.TabIndex = 14;
			// 
			// PasteTextButton
			// 
			this.PasteTextButton.Location = new System.Drawing.Point(308, 237);
			this.PasteTextButton.Name = "PasteTextButton";
			this.PasteTextButton.Size = new System.Drawing.Size(75, 23);
			this.PasteTextButton.TabIndex = 13;
			this.PasteTextButton.Text = "Paste Text";
			this.PasteTextButton.Click += new System.EventHandler(this.PasteTextButton_Click);
			// 
			// CopyTextButton
			// 
			this.CopyTextButton.Location = new System.Drawing.Point(176, 237);
			this.CopyTextButton.Name = "CopyTextButton";
			this.CopyTextButton.Size = new System.Drawing.Size(75, 23);
			this.CopyTextButton.TabIndex = 12;
			this.CopyTextButton.Text = "Copy Text";
			this.CopyTextButton.Click += new System.EventHandler(this.CopyTextButton_Click);
			// 
			// tbPaste
			// 
			this.tbPaste.Location = new System.Drawing.Point(392, 211);
			this.tbPaste.Multiline = true;
			this.tbPaste.Name = "tbPaste";
			this.tbPaste.Size = new System.Drawing.Size(139, 75);
			this.tbPaste.TabIndex = 11;
			// 
			// tbCopy
			// 
			this.tbCopy.Location = new System.Drawing.Point(30, 211);
			this.tbCopy.Multiline = true;
			this.tbCopy.Name = "tbCopy";
			this.tbCopy.Size = new System.Drawing.Size(139, 75);
			this.tbCopy.TabIndex = 10;
			// 
			// PasteRTFButton
			// 
			this.PasteRTFButton.Location = new System.Drawing.Point(306, 139);
			this.PasteRTFButton.Name = "PasteRTFButton";
			this.PasteRTFButton.Size = new System.Drawing.Size(75, 23);
			this.PasteRTFButton.TabIndex = 9;
			this.PasteRTFButton.Text = "Paste RTF";
			this.PasteRTFButton.Click += new System.EventHandler(this.PasteRTFButton_Click);
			// 
			// CopyRTFButton
			// 
			this.CopyRTFButton.Location = new System.Drawing.Point(174, 139);
			this.CopyRTFButton.Name = "CopyRTFButton";
			this.CopyRTFButton.Size = new System.Drawing.Size(75, 23);
			this.CopyRTFButton.TabIndex = 8;
			this.CopyRTFButton.Text = "Copy RTF";
			this.CopyRTFButton.Click += new System.EventHandler(this.CopyRTFButton_Click);
			// 
			// rtbPaste
			// 
			this.rtbPaste.Location = new System.Drawing.Point(391, 117);
			this.rtbPaste.Name = "rtbPaste";
			this.rtbPaste.Size = new System.Drawing.Size(139, 77);
			this.rtbPaste.TabIndex = 7;
			this.rtbPaste.Text = "";
			// 
			// rtbCopy
			// 
			this.rtbCopy.Location = new System.Drawing.Point(30, 117);
			this.rtbCopy.Name = "rtbCopy";
			this.rtbCopy.Size = new System.Drawing.Size(139, 76);
			this.rtbCopy.TabIndex = 6;
			this.rtbCopy.Text = "";
			// 
			// PasteHTMLButton
			// 
			this.PasteHTMLButton.Location = new System.Drawing.Point(306, 52);
			this.PasteHTMLButton.Name = "PasteHTMLButton";
			this.PasteHTMLButton.Size = new System.Drawing.Size(75, 23);
			this.PasteHTMLButton.TabIndex = 5;
			this.PasteHTMLButton.Text = "Paste HTML";
			this.PasteHTMLButton.Click += new System.EventHandler(this.PasteHTMLButton_Click);
			// 
			// CopyHTMLButton
			// 
			this.CopyHTMLButton.Location = new System.Drawing.Point(174, 52);
			this.CopyHTMLButton.Name = "CopyHTMLButton";
			this.CopyHTMLButton.Size = new System.Drawing.Size(75, 23);
			this.CopyHTMLButton.TabIndex = 4;
			this.CopyHTMLButton.Text = "Copy HTML";
			this.CopyHTMLButton.Click += new System.EventHandler(this.CopyHTMLButton_Click);
			// 
			// MenuStrip1
			// 
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearClipboardToolStripMenuItem});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(580, 24);
			this.MenuStrip1.TabIndex = 9;
			this.MenuStrip1.Text = "MenuStrip1";
			// 
			// clearClipboardToolStripMenuItem
			// 
			this.clearClipboardToolStripMenuItem.Name = "clearClipboardToolStripMenuItem";
			this.clearClipboardToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
			this.clearClipboardToolStripMenuItem.Text = "&Clear Clipboard";
			this.clearClipboardToolStripMenuItem.Click += new System.EventHandler(this.clearClipboardToolStripMenuItem_Click);
			// 
			// wbPasteHtml
			// 
			this.wbPasteHtml.Location = new System.Drawing.Point(392, 20);
			this.wbPasteHtml.Name = "wbPasteHtml";
			this.wbPasteHtml.Size = new System.Drawing.Size(138, 76);
			this.wbPasteHtml.TabIndex = 3;
			// 
			// PasteObjectButton
			// 
			this.PasteObjectButton.Location = new System.Drawing.Point(308, 47);
			this.PasteObjectButton.Name = "PasteObjectButton";
			this.PasteObjectButton.Size = new System.Drawing.Size(75, 23);
			this.PasteObjectButton.TabIndex = 17;
			this.PasteObjectButton.Text = "Paste Object";
			this.PasteObjectButton.Click += new System.EventHandler(this.PasteObjectButton_Click);
			// 
			// GroupBox3
			// 
			this.GroupBox3.Controls.Add(this.PasteObjectButton);
			this.GroupBox3.Controls.Add(this.CopyObjectButton);
			this.GroupBox3.Controls.Add(this.tbPasteObject);
			this.GroupBox3.Controls.Add(this.tbCopyObject);
			this.GroupBox3.Location = new System.Drawing.Point(12, 443);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(554, 111);
			this.GroupBox3.TabIndex = 7;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Working with Objects";
			// 
			// CopyObjectButton
			// 
			this.CopyObjectButton.Location = new System.Drawing.Point(176, 47);
			this.CopyObjectButton.Name = "CopyObjectButton";
			this.CopyObjectButton.Size = new System.Drawing.Size(75, 23);
			this.CopyObjectButton.TabIndex = 16;
			this.CopyObjectButton.Text = "Copy Object";
			this.CopyObjectButton.Click += new System.EventHandler(this.CopyObjectButton_Click);
			// 
			// wbCopyHtml
			// 
			this.wbCopyHtml.Location = new System.Drawing.Point(29, 20);
			this.wbCopyHtml.Name = "wbCopyHtml";
			this.wbCopyHtml.Size = new System.Drawing.Size(139, 78);
			this.wbCopyHtml.TabIndex = 2;
			// 
			// GroupBox2
			// 
			this.GroupBox2.Controls.Add(this.PasteTextButton);
			this.GroupBox2.Controls.Add(this.CopyTextButton);
			this.GroupBox2.Controls.Add(this.tbPaste);
			this.GroupBox2.Controls.Add(this.tbCopy);
			this.GroupBox2.Controls.Add(this.PasteRTFButton);
			this.GroupBox2.Controls.Add(this.CopyRTFButton);
			this.GroupBox2.Controls.Add(this.rtbPaste);
			this.GroupBox2.Controls.Add(this.rtbCopy);
			this.GroupBox2.Controls.Add(this.PasteHTMLButton);
			this.GroupBox2.Controls.Add(this.CopyHTMLButton);
			this.GroupBox2.Controls.Add(this.wbPasteHtml);
			this.GroupBox2.Controls.Add(this.wbCopyHtml);
			this.GroupBox2.Location = new System.Drawing.Point(12, 140);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(555, 296);
			this.GroupBox2.TabIndex = 6;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Working with Text";
			// 
			// PasteImageButton
			// 
			this.PasteImageButton.Location = new System.Drawing.Point(307, 63);
			this.PasteImageButton.Name = "PasteImageButton";
			this.PasteImageButton.Size = new System.Drawing.Size(75, 23);
			this.PasteImageButton.TabIndex = 3;
			this.PasteImageButton.Text = "Paste Image";
			this.PasteImageButton.Click += new System.EventHandler(this.PasteImageButton_Click);
			// 
			// CopyImageButton
			// 
			this.CopyImageButton.Location = new System.Drawing.Point(175, 63);
			this.CopyImageButton.Name = "CopyImageButton";
			this.CopyImageButton.Size = new System.Drawing.Size(75, 23);
			this.CopyImageButton.TabIndex = 2;
			this.CopyImageButton.Text = "Copy Image";
			this.CopyImageButton.Click += new System.EventHandler(this.CopyImageButton_Click);
			// 
			// pbPaste
			// 
			this.pbPaste.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pbPaste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbPaste.Location = new System.Drawing.Point(389, 20);
			this.pbPaste.Name = "pbPaste";
			this.pbPaste.Size = new System.Drawing.Size(140, 55);
			this.pbPaste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbPaste.TabIndex = 1;
			this.pbPaste.TabStop = false;
			// 
			// pbCopy
			// 
			this.pbCopy.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pbCopy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbCopy.Location = new System.Drawing.Point(28, 20);
			this.pbCopy.Name = "pbCopy";
			this.pbCopy.Size = new System.Drawing.Size(140, 56);
			this.pbCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbCopy.TabIndex = 0;
			this.pbCopy.TabStop = false;
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.PasteImageButton);
			this.GroupBox1.Controls.Add(this.CopyImageButton);
			this.GroupBox1.Controls.Add(this.pbPaste);
			this.GroupBox1.Controls.Add(this.pbCopy);
			this.GroupBox1.Location = new System.Drawing.Point(13, 25);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(554, 108);
			this.GroupBox1.TabIndex = 5;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Working with Images";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(580, 705);
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.MenuStrip1);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Name = "MainForm";
			this.Text = "Clipboard Sample";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPaste)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCopy)).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.TextBox tbPasteObject;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.Button PasteFilesButton;
		internal System.Windows.Forms.ListBox lvFiles;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.LinkLabel WindowsExplorerLinkLabel;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox tbCopyObject;
		internal System.Windows.Forms.Button PasteTextButton;
		internal System.Windows.Forms.Button CopyTextButton;
		internal System.Windows.Forms.TextBox tbPaste;
		internal System.Windows.Forms.TextBox tbCopy;
		internal System.Windows.Forms.Button PasteRTFButton;
		internal System.Windows.Forms.Button CopyRTFButton;
		internal System.Windows.Forms.RichTextBox rtbPaste;
		internal System.Windows.Forms.RichTextBox rtbCopy;
		internal System.Windows.Forms.Button PasteHTMLButton;
		internal System.Windows.Forms.Button CopyHTMLButton;
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem clearClipboardToolStripMenuItem;
		internal System.Windows.Forms.WebBrowser wbPasteHtml;
		internal System.Windows.Forms.Button PasteObjectButton;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Button CopyObjectButton;
		internal System.Windows.Forms.WebBrowser wbCopyHtml;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Button PasteImageButton;
		internal System.Windows.Forms.Button CopyImageButton;
		internal System.Windows.Forms.PictureBox pbPaste;
		internal System.Windows.Forms.PictureBox pbCopy;
		internal System.Windows.Forms.GroupBox GroupBox1;
	}
}

