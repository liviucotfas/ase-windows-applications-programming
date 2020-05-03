namespace NumericTextBoxUserControlSample
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
            this.btnGetUserControlValue = new System.Windows.Forms.Button();
            this.ucNumericTextBox = new NumericTextBoxUserControlSample.NumericTextBoxCompositeControl();
            this.numericTextBoxUserControl1 = new NumericTextBoxUserControlSample.NumericTextBoxCompositeControl();
            this.numericTextBox1 = new NumericTextBoxUserControlSample.NumericTextBoxExtendedControl();
            this.SuspendLayout();
            // 
            // btnGetUserControlValue
            // 
            this.btnGetUserControlValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGetUserControlValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetUserControlValue.ForeColor = System.Drawing.Color.White;
            this.btnGetUserControlValue.Location = new System.Drawing.Point(116, 102);
            this.btnGetUserControlValue.Name = "btnGetUserControlValue";
            this.btnGetUserControlValue.Size = new System.Drawing.Size(159, 23);
            this.btnGetUserControlValue.TabIndex = 1;
            this.btnGetUserControlValue.Text = "Get UserControl Value";
            this.btnGetUserControlValue.UseVisualStyleBackColor = false;
            this.btnGetUserControlValue.Click += new System.EventHandler(this.btnGetUserControlValue_Click);
            // 
            // ucNumericTextBox
            // 
            this.ucNumericTextBox.Location = new System.Drawing.Point(12, 66);
            this.ucNumericTextBox.Name = "ucNumericTextBox";
            this.ucNumericTextBox.Size = new System.Drawing.Size(398, 21);
            this.ucNumericTextBox.TabIndex = 0;
            // 
            // numericTextBoxUserControl1
            // 
            this.numericTextBoxUserControl1.Location = new System.Drawing.Point(12, 66);
            this.numericTextBoxUserControl1.Name = "numericTextBoxUserControl1";
            this.numericTextBoxUserControl1.Size = new System.Drawing.Size(398, 21);
            this.numericTextBoxUserControl1.TabIndex = 0;
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.Location = new System.Drawing.Point(12, 26);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(398, 20);
            this.numericTextBox1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 143);
            this.Controls.Add(this.numericTextBox1);
            this.Controls.Add(this.btnGetUserControlValue);
            this.Controls.Add(this.ucNumericTextBox);
            this.Name = "MainForm";
            this.Text = "NumericTextBox UserControl Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private NumericTextBoxCompositeControl ucNumericTextBox;
		private System.Windows.Forms.Button btnGetUserControlValue;
		private NumericTextBoxCompositeControl numericTextBoxUserControl1;
		private NumericTextBoxExtendedControl numericTextBox1;
	}
}

