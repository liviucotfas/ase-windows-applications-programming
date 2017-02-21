namespace StandardExceptions
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
			this.btnCalculate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.tbValue2 = new System.Windows.Forms.TextBox();
			this.tbValue1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCalculate
			// 
			this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnCalculate.Location = new System.Drawing.Point(390, 26);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 9;
			this.btnCalculate.Text = "=";
			this.btnCalculate.UseVisualStyleBackColor = false;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(182, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "/";
			// 
			// tbResult
			// 
			this.tbResult.Location = new System.Drawing.Point(485, 28);
			this.tbResult.Name = "tbResult";
			this.tbResult.ReadOnly = true;
			this.tbResult.Size = new System.Drawing.Size(156, 20);
			this.tbResult.TabIndex = 7;
			// 
			// tbValue2
			// 
			this.tbValue2.Location = new System.Drawing.Point(214, 28);
			this.tbValue2.Name = "tbValue2";
			this.tbValue2.Size = new System.Drawing.Size(156, 20);
			this.tbValue2.TabIndex = 6;
			this.tbValue2.Text = "0";
			// 
			// tbValue1
			// 
			this.tbValue1.Location = new System.Drawing.Point(6, 28);
			this.tbValue1.Name = "tbValue1";
			this.tbValue1.Size = new System.Drawing.Size(156, 20);
			this.tbValue1.TabIndex = 5;
			this.tbValue1.Text = "aaaa";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbValue1);
			this.groupBox1.Controls.Add(this.btnCalculate);
			this.groupBox1.Controls.Add(this.tbValue2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbResult);
			this.groupBox1.Location = new System.Drawing.Point(12, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(654, 65);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "FormatException, DivisonByZeroException";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 77);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Standard Exceptions";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbResult;
		private System.Windows.Forms.TextBox tbValue2;
		private System.Windows.Forms.TextBox tbValue1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

