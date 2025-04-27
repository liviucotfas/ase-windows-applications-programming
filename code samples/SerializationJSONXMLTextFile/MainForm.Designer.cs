namespace SerializationJSONXMLTextFile
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
            btnAdd = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            tbLastName = new System.Windows.Forms.TextBox();
            tbFirstName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            lvParticipants = new System.Windows.Forms.ListView();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            groupBox1 = new System.Windows.Forms.GroupBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnSerializeJSON = new System.Windows.Forms.ToolStripMenuItem();
            btnDeserializeJSON = new System.Windows.Forms.ToolStripMenuItem();
            xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnSerializeXML = new System.Windows.Forms.ToolStripMenuItem();
            btnDeserializeXML = new System.Windows.Forms.ToolStripMenuItem();
            jSONSerializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnSerializeJSONLegacy = new System.Windows.Forms.ToolStripMenuItem();
            btnDeserializeJSONLegacy = new System.Windows.Forms.ToolStripMenuItem();
            textFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnTextFile = new System.Windows.Forms.ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(668, 117);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(223, 35);
            btnAdd.TabIndex = 52;
            btnAdd.Text = "Add Participant";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(51, 52);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Last Name";
            // 
            // tbLastName
            // 
            tbLastName.Location = new System.Drawing.Point(136, 48);
            tbLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new System.Drawing.Size(265, 27);
            tbLastName.TabIndex = 0;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new System.Drawing.Point(136, 111);
            tbFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new System.Drawing.Size(265, 27);
            tbFirstName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(51, 117);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(537, 52);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "Birth Date";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new System.Drawing.Point(623, 45);
            dtpBirthDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new System.Drawing.Size(265, 27);
            dtpBirthDate.TabIndex = 5;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "First Name";
            columnHeader2.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Last Name";
            columnHeader1.Width = 150;
            // 
            // lvParticipants
            // 
            lvParticipants.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvParticipants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvParticipants.FullRowSelect = true;
            lvParticipants.GridLines = true;
            lvParticipants.Location = new System.Drawing.Point(16, 251);
            lvParticipants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lvParticipants.Name = "lvParticipants";
            lvParticipants.Size = new System.Drawing.Size(925, 353);
            lvParticipants.TabIndex = 60;
            lvParticipants.UseCompatibleStateImageBehavior = false;
            lvParticipants.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Birth Date";
            columnHeader3.Width = 120;
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
            groupBox1.Location = new System.Drawing.Point(16, 58);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Size = new System.Drawing.Size(927, 183);
            groupBox1.TabIndex = 59;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Participant";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, xMLToolStripMenuItem, jSONSerializationToolStripMenuItem, textFileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(959, 30);
            menuStrip1.TabIndex = 61;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnSerializeJSON, btnDeserializeJSON });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            fileToolStripMenuItem.Text = "JSON Serialization";
            // 
            // btnSerializeJSON
            // 
            btnSerializeJSON.Name = "btnSerializeJSON";
            btnSerializeJSON.Size = new System.Drawing.Size(224, 26);
            btnSerializeJSON.Text = "Serialize";
            btnSerializeJSON.Click += btnSerializeJSON_Click;
            // 
            // btnDeserializeJSON
            // 
            btnDeserializeJSON.Name = "btnDeserializeJSON";
            btnDeserializeJSON.Size = new System.Drawing.Size(224, 26);
            btnDeserializeJSON.Text = "Deserialize";
            btnDeserializeJSON.Click += btnDeserializeJSON_Click;
            // 
            // xMLToolStripMenuItem
            // 
            xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnSerializeXML, btnDeserializeXML });
            xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            xMLToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            xMLToolStripMenuItem.Text = "XML Serialization";
            // 
            // btnSerializeXML
            // 
            btnSerializeXML.Name = "btnSerializeXML";
            btnSerializeXML.Size = new System.Drawing.Size(165, 26);
            btnSerializeXML.Text = "Serialize";
            btnSerializeXML.Click += btnSerializeXML_Click;
            // 
            // btnDeserializeXML
            // 
            btnDeserializeXML.Name = "btnDeserializeXML";
            btnDeserializeXML.Size = new System.Drawing.Size(165, 26);
            btnDeserializeXML.Text = "Deserialize";
            btnDeserializeXML.Click += btnDeserializeXML_Click;
            // 
            // jSONSerializationToolStripMenuItem
            // 
            jSONSerializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnSerializeJSONLegacy, btnDeserializeJSONLegacy });
            jSONSerializationToolStripMenuItem.Name = "jSONSerializationToolStripMenuItem";
            jSONSerializationToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            jSONSerializationToolStripMenuItem.Text = "JSON Serialization (legacy)";
            // 
            // btnSerializeJSONLegacy
            // 
            btnSerializeJSONLegacy.Name = "btnSerializeJSONLegacy";
            btnSerializeJSONLegacy.Size = new System.Drawing.Size(224, 26);
            btnSerializeJSONLegacy.Text = "Serialize";
            btnSerializeJSONLegacy.Click += btnSerializeJSON_Click;
            // 
            // btnDeserializeJSONLegacy
            // 
            btnDeserializeJSONLegacy.Name = "btnDeserializeJSONLegacy";
            btnDeserializeJSONLegacy.Size = new System.Drawing.Size(224, 26);
            btnDeserializeJSONLegacy.Text = "Deserialize";
            btnDeserializeJSONLegacy.Click += btnDeserializeJSON_Click;
            // 
            // textFileToolStripMenuItem
            // 
            textFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnTextFile });
            textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            textFileToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            textFileToolStripMenuItem.Text = "TextFile";
            // 
            // btnTextFile
            // 
            btnTextFile.Name = "btnTextFile";
            btnTextFile.Size = new System.Drawing.Size(135, 26);
            btnTextFile.Text = "Export";
            btnTextFile.Click += btnTextFile_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(959, 625);
            Controls.Add(lvParticipants);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "WinAppProgramming Run";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvParticipants;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnSerializeJSON;
		private System.Windows.Forms.ToolStripMenuItem btnDeserializeJSON;
		private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnTextFile;
		private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnSerializeXML;
		private System.Windows.Forms.ToolStripMenuItem btnDeserializeXML;
		private System.Windows.Forms.ToolStripMenuItem jSONSerializationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnSerializeJSONLegacy;
		private System.Windows.Forms.ToolStripMenuItem btnDeserializeJSONLegacy;
	}
}

