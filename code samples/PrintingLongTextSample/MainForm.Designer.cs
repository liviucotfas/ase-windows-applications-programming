namespace PrintingSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.btnPageSetup = new System.Windows.Forms.Button();
            this.btnPrintDialog = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // txtDocument
            // 
            this.txtDocument.AccessibleDescription = "TextBox to contain text for printing";
            this.txtDocument.AccessibleName = "TextBox for printing";
            this.txtDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDocument.Location = new System.Drawing.Point(16, 53);
            this.txtDocument.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocument.Multiline = true;
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDocument.Size = new System.Drawing.Size(532, 334);
            this.txtDocument.TabIndex = 12;
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.AccessibleDescription = "Button with text \"Page Setup\"";
            this.btnPageSetup.AccessibleName = "Page Setup button";
            this.btnPageSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPageSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageSetup.ForeColor = System.Drawing.Color.White;
            this.btnPageSetup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPageSetup.Location = new System.Drawing.Point(343, 14);
            this.btnPageSetup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(117, 28);
            this.btnPageSetup.TabIndex = 11;
            this.btnPageSetup.Text = "Page &Setup";
            this.btnPageSetup.UseVisualStyleBackColor = false;
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            // 
            // btnPrintDialog
            // 
            this.btnPrintDialog.AccessibleDescription = "Button with text \"Print Dialog\"";
            this.btnPrintDialog.AccessibleName = "Print Dialog button";
            this.btnPrintDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrintDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDialog.ForeColor = System.Drawing.Color.White;
            this.btnPrintDialog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrintDialog.Location = new System.Drawing.Point(215, 14);
            this.btnPrintDialog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintDialog.Name = "btnPrintDialog";
            this.btnPrintDialog.Size = new System.Drawing.Size(117, 28);
            this.btnPrintDialog.TabIndex = 10;
            this.btnPrintDialog.Text = "Print &Dialog";
            this.btnPrintDialog.UseVisualStyleBackColor = false;
            this.btnPrintDialog.Click += new System.EventHandler(this.btnPrintDialog_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.AccessibleDescription = "Button with text \"Print Preview\"";
            this.btnPrintPreview.AccessibleName = "Print Preview button";
            this.btnPrintPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrintPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreview.ForeColor = System.Drawing.Color.White;
            this.btnPrintPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrintPreview.Location = new System.Drawing.Point(16, 14);
            this.btnPrintPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(191, 28);
            this.btnPrintPreview.TabIndex = 9;
            this.btnPrintPreview.Text = "Print &Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = false;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog1";
            this.printPreviewDialog.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 399);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.btnPageSetup);
            this.Controls.Add(this.btnPrintDialog);
            this.Controls.Add(this.btnPrintPreview);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Printing Sample";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.TextBox txtDocument;
		internal System.Windows.Forms.Button btnPageSetup;
		internal System.Windows.Forms.Button btnPrintDialog;
		internal System.Windows.Forms.Button btnPrintPreview;
		private System.Windows.Forms.PrintDialog printDialog;
		private System.Drawing.Printing.PrintDocument printDocument;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}

