namespace PieChartGraphicsSample
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
			this.pieChartControl = new PieChartControl();
			this.SuspendLayout();
			// 
			// pieChartControl1
			// 
			this.pieChartControl.BackColor = System.Drawing.Color.White;
			this.pieChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pieChartControl.Location = new System.Drawing.Point(0, 0);
			this.pieChartControl.Name = "pieChartControl";
			this.pieChartControl.Size = new System.Drawing.Size(456, 351);
			this.pieChartControl.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(456, 351);
			this.Controls.Add(this.pieChartControl);
			this.Name = "MainForm";
			this.Text = "PieChart Sample";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private PieChartControl pieChartControl;
	}
}

