namespace NumericTextBoxUserControlSample
{
	partial class NumericTextBoxUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbNumericValue = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tbNumericValue
			// 
			this.tbNumericValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbNumericValue.Location = new System.Drawing.Point(0, 0);
			this.tbNumericValue.MaxLength = 10;
			this.tbNumericValue.Name = "tbNumericValue";
			this.tbNumericValue.Size = new System.Drawing.Size(237, 20);
			this.tbNumericValue.TabIndex = 0;
			this.tbNumericValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBoxUserControl_KeyPress);
			// 
			// NumericTextBoxUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tbNumericValue);
			this.Name = "NumericTextBoxUserControl";
			this.Size = new System.Drawing.Size(237, 21);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbNumericValue;
	}
}
