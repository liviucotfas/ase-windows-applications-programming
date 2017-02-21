using System.ComponentModel;
using System.Windows.Forms;

namespace MouseEvents
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			this.btnReset = new System.Windows.Forms.Button();
			this.lbl = new System.Windows.Forms.Label();
			this.txt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.ForeColor = System.Drawing.Color.White;
			this.btnReset.Location = new System.Drawing.Point(237, 9);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 0;
			this.btnReset.Text = "&Reset";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// lbl
			// 
			this.lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl.Location = new System.Drawing.Point(12, 9);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(200, 81);
			this.lbl.TabIndex = 1;
			this.lbl.Click += new System.EventHandler(this.lbl_Click);
			this.lbl.DoubleClick += new System.EventHandler(this.lbl_DoubleClick);
			this.lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
			this.lbl.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
			this.lbl.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
			this.lbl.MouseHover += new System.EventHandler(this.lbl_MouseHover);
			this.lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseMove);
			this.lbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
			this.lbl.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseWheel);
			// 
			// txt
			// 
			this.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt.Location = new System.Drawing.Point(12, 109);
			this.txt.Multiline = true;
			this.txt.Name = "txt";
			this.txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt.Size = new System.Drawing.Size(300, 421);
			this.txt.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 544);
			this.Controls.Add(this.txt);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.btnReset);
			this.Name = "MainForm";
			this.Text = "Mouse Events";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnReset;
		private Label lbl;
		private TextBox txt;
	}
}

