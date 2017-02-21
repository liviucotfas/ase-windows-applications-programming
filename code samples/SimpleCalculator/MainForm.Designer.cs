namespace SimpleCalculator
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
			this.tbValue1 = new System.Windows.Forms.TextBox();
			this.tbValue2 = new System.Windows.Forms.TextBox();
			this.tbSum = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbValue1
			// 
			this.tbValue1.Location = new System.Drawing.Point(34, 12);
			this.tbValue1.Name = "tbValue1";
			this.tbValue1.Size = new System.Drawing.Size(156, 20);
			this.tbValue1.TabIndex = 0;
			// 
			// tbValue2
			// 
			this.tbValue2.Location = new System.Drawing.Point(34, 77);
			this.tbValue2.Name = "tbValue2";
			this.tbValue2.Size = new System.Drawing.Size(156, 20);
			this.tbValue2.TabIndex = 1;
			// 
			// tbSum
			// 
			this.tbSum.Location = new System.Drawing.Point(34, 152);
			this.tbSum.Name = "tbSum";
			this.tbSum.ReadOnly = true;
			this.tbSum.Size = new System.Drawing.Size(156, 20);
			this.tbSum.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(106, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(13, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "+";
			// 
			// btnCalculate
			// 
			this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnCalculate.Location = new System.Drawing.Point(75, 113);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 4;
			this.btnCalculate.Text = "=";
			this.btnCalculate.UseVisualStyleBackColor = false;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(221, 183);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbSum);
			this.Controls.Add(this.tbValue2);
			this.Controls.Add(this.tbValue1);
			this.Name = "MainForm";
			this.Text = "Simple Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbValue1;
		private System.Windows.Forms.TextBox tbValue2;
		private System.Windows.Forms.TextBox tbSum;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCalculate;
	}
}

