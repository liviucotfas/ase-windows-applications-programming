namespace DragDropSample
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tbText = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(16, 143);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(255, 176);
            this.richTextBox.TabIndex = 9;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(16, 94);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker_MouseDown);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(16, 54);
            this.numericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(256, 22);
            this.numericUpDown.TabIndex = 7;
            this.numericUpDown.Value = new decimal(new int[] {
            123456,
            0,
            0,
            0});
            this.numericUpDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.numericUpDown_MouseDown);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(16, 15);
            this.tbText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(255, 22);
            this.tbText.TabIndex = 6;
            this.tbText.Text = "This is a test message";
            this.tbText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbText_MouseDown);
            // 
            // listBox
            // 
            this.listBox.AllowDrop = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(293, 15);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(223, 308);
            this.listBox.TabIndex = 5;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.listBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 342);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.listBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "DragDrop Sample";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.NumericUpDown numericUpDown;
		private System.Windows.Forms.TextBox tbText;
		private System.Windows.Forms.ListBox listBox;
	}
}

