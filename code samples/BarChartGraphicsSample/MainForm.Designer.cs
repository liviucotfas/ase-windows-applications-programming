namespace BarChartGraphicsSample
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
			this.barChartControl = new BarChartGraphicsSample.BarChartControl();
			this.SuspendLayout();
			// 
			// barChartControl
			// 
			this.barChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.barChartControl.Location = new System.Drawing.Point(0, 0);
			this.barChartControl.Name = "barChartControl";
			this.barChartControl.Size = new System.Drawing.Size(739, 365);
			this.barChartControl.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(739, 365);
			this.Controls.Add(this.barChartControl);
			this.Name = "MainForm";
			this.Text = "BarChart Sample";
			this.ResumeLayout(false);

		}

		#endregion

		private BarChartControl barChartControl;
	}
}

