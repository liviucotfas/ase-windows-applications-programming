namespace TranslateWebService
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
			this.btnTranslate = new System.Windows.Forms.Button();
			this.lbCountry = new System.Windows.Forms.Label();
			this.txtIp = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnTranslate
			// 
			this.btnTranslate.Location = new System.Drawing.Point(197, 69);
			this.btnTranslate.Name = "btnTranslate";
			this.btnTranslate.Size = new System.Drawing.Size(75, 23);
			this.btnTranslate.TabIndex = 0;
			this.btnTranslate.Text = "Find Country";
			this.btnTranslate.UseVisualStyleBackColor = true;
			this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
			// 
			// lbCountry
			// 
			this.lbCountry.AutoSize = true;
			this.lbCountry.Location = new System.Drawing.Point(12, 46);
			this.lbCountry.Name = "lbCountry";
			this.lbCountry.Size = new System.Drawing.Size(19, 13);
			this.lbCountry.TabIndex = 1;
			this.lbCountry.Text = "....";
			// 
			// txtIp
			// 
			this.txtIp.Location = new System.Drawing.Point(61, 11);
			this.txtIp.Name = "txtIp";
			this.txtIp.Size = new System.Drawing.Size(211, 20);
			this.txtIp.TabIndex = 2;
			this.txtIp.Text = "194.102.208.81";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(19, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ip:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 99);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtIp);
			this.Controls.Add(this.lbCountry);
			this.Controls.Add(this.btnTranslate);
			this.Name = "Form1";
			this.Text = "Ip2Country";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnTranslate;
		private System.Windows.Forms.Label lbCountry;
		private System.Windows.Forms.TextBox txtIp;
		private System.Windows.Forms.Label label2;
	}
}

