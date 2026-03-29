namespace DataBindingDataGridViewDialog
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
			groupBox1 = new System.Windows.Forms.GroupBox();
			btnAdd = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			tbLastName = new System.Windows.Forms.TextBox();
			tbFirstName = new System.Windows.Forms.TextBox();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			btnEdit = new System.Windows.Forms.Button();
			btnDelete = new System.Windows.Forms.Button();
			dgvParticipants = new System.Windows.Forms.DataGridView();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvParticipants).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			groupBox1.Controls.Add(btnAdd);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(tbLastName);
			groupBox1.Controls.Add(tbFirstName);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(dtpBirthDate);
			groupBox1.Location = new System.Drawing.Point(14, 14);
			groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			groupBox1.Size = new System.Drawing.Size(802, 137);
			groupBox1.TabIndex = 59;
			groupBox1.TabStop = false;
			groupBox1.Text = "New Participant";
			// 
			// btnAdd
			// 
			btnAdd.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
			btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnAdd.ForeColor = System.Drawing.Color.White;
			btnAdd.Location = new System.Drawing.Point(584, 88);
			btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new System.Drawing.Size(195, 27);
			btnAdd.TabIndex = 52;
			btnAdd.Text = "Add Participant";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(44, 39);
			label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(63, 15);
			label1.TabIndex = 1;
			label1.Text = "Last Name";
			// 
			// tbLastName
			// 
			tbLastName.Location = new System.Drawing.Point(119, 36);
			tbLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			tbLastName.Name = "tbLastName";
			tbLastName.Size = new System.Drawing.Size(233, 23);
			tbLastName.TabIndex = 0;
			// 
			// tbFirstName
			// 
			tbFirstName.Location = new System.Drawing.Point(119, 83);
			tbFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			tbFirstName.Name = "tbFirstName";
			tbFirstName.Size = new System.Drawing.Size(233, 23);
			tbFirstName.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(44, 88);
			label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(64, 15);
			label2.TabIndex = 3;
			label2.Text = "First Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(470, 39);
			label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(59, 15);
			label3.TabIndex = 4;
			label3.Text = "Birth Date";
			// 
			// dtpBirthDate
			// 
			dtpBirthDate.Location = new System.Drawing.Point(545, 33);
			dtpBirthDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			dtpBirthDate.Name = "dtpBirthDate";
			dtpBirthDate.Size = new System.Drawing.Size(233, 23);
			dtpBirthDate.TabIndex = 5;
			// 
			// btnEdit
			// 
			btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			btnEdit.Location = new System.Drawing.Point(624, 448);
			btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new System.Drawing.Size(88, 27);
			btnEdit.TabIndex = 61;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnDelete
			// 
			btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			btnDelete.Location = new System.Drawing.Point(729, 448);
			btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new System.Drawing.Size(88, 27);
			btnDelete.TabIndex = 62;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// dgvParticipants
			// 
			dgvParticipants.AllowUserToAddRows = false;
			dgvParticipants.AllowUserToDeleteRows = false;
			dgvParticipants.AllowUserToOrderColumns = true;
			dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvParticipants.Location = new System.Drawing.Point(15, 159);
			dgvParticipants.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			dgvParticipants.Name = "dgvParticipants";
			dgvParticipants.ReadOnly = true;
			dgvParticipants.Size = new System.Drawing.Size(800, 282);
			dgvParticipants.TabIndex = 63;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(826, 488);
			Controls.Add(dgvParticipants);
			Controls.Add(btnDelete);
			Controls.Add(btnEdit);
			Controls.Add(groupBox1);
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			Name = "MainForm";
			Text = "WinAppProgramming Run";
			Load += MainForm_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvParticipants).EndInit();
			ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvParticipants;
    }
}

