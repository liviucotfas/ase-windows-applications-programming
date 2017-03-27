namespace ValidationCustomExceptions
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
			this.components = new System.ComponentModel.Container();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.tbSSN = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
			this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
			this.SuspendLayout();
			// 
			// tbLastName
			// 
			this.tbLastName.Location = new System.Drawing.Point(102, 31);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(200, 20);
			this.tbLastName.TabIndex = 0;
			this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
			this.tbLastName.Validated += new System.EventHandler(this.tbLastName_Validated);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Last Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "First Name";
			// 
			// tbFirstName
			// 
			this.tbFirstName.Location = new System.Drawing.Point(102, 72);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(200, 20);
			this.tbFirstName.TabIndex = 2;
			this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
			this.tbFirstName.Validated += new System.EventHandler(this.tbFirstName_Validated);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Birth Date";
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Location = new System.Drawing.Point(102, 113);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
			this.dtpBirthDate.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(413, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "SSN";
			// 
			// rbFemale
			// 
			this.rbFemale.AutoSize = true;
			this.rbFemale.Location = new System.Drawing.Point(74, 3);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(59, 17);
			this.rbFemale.TabIndex = 7;
			this.rbFemale.TabStop = true;
			this.rbFemale.Text = "Female";
			this.rbFemale.UseVisualStyleBackColor = true;
			// 
			// rbMale
			// 
			this.rbMale.AutoSize = true;
			this.rbMale.Checked = true;
			this.rbMale.Location = new System.Drawing.Point(3, 3);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(48, 17);
			this.rbMale.TabIndex = 8;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Male";
			this.rbMale.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(413, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Gender";
			// 
			// tbSSN
			// 
			this.tbSSN.Location = new System.Drawing.Point(466, 73);
			this.tbSSN.Name = "tbSSN";
			this.tbSSN.Size = new System.Drawing.Size(200, 20);
			this.tbSSN.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbMale);
			this.panel1.Controls.Add(this.rbFemale);
			this.panel1.Location = new System.Drawing.Point(466, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(144, 24);
			this.panel1.TabIndex = 11;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Controls.Add(this.tbLastName);
			this.groupBox1.Controls.Add(this.tbSSN);
			this.groupBox1.Controls.Add(this.tbFirstName);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.dtpBirthDate);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(687, 154);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "New Participant";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(540, 110);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(126, 23);
			this.btnAdd.TabIndex = 52;
			this.btnAdd.Text = "Add Participant";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Location = new System.Drawing.Point(12, 177);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(687, 204);
			this.listView1.TabIndex = 51;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// epFirstName
			// 
			this.epFirstName.ContainerControl = this;
			// 
			// epLastName
			// 
			this.epLastName.ContainerControl = this;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 393);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "WinAppProgramming Run";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton rbFemale;
		private System.Windows.Forms.RadioButton rbMale;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbSSN;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ErrorProvider epFirstName;
		private System.Windows.Forms.ErrorProvider epLastName;
	}
}

