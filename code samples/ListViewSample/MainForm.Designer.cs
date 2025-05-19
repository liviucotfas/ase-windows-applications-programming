namespace ListViewSample
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Children", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Adults", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lvParticipants = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            imgListLarge = new System.Windows.Forms.ImageList(components);
            imgListSmall = new System.Windows.Forms.ImageList(components);
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnAdd = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            tbLastName = new System.Windows.Forms.TextBox();
            tbFirstName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            btnDetails = new System.Windows.Forms.Button();
            btnList = new System.Windows.Forms.Button();
            btnLargeIcon = new System.Windows.Forms.Button();
            btnSmallIcon = new System.Windows.Forms.Button();
            btnTiles = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lvParticipants
            // 
            lvParticipants.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvParticipants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvParticipants.FullRowSelect = true;
            lvParticipants.GridLines = true;
            listViewGroup1.Header = "Children";
            listViewGroup1.Name = "children";
            listViewGroup2.Header = "Adults";
            listViewGroup2.Name = "adults";
            lvParticipants.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] { listViewGroup1, listViewGroup2 });
            lvParticipants.LargeImageList = imgListLarge;
            lvParticipants.Location = new System.Drawing.Point(14, 209);
            lvParticipants.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvParticipants.Name = "lvParticipants";
            lvParticipants.Size = new System.Drawing.Size(801, 269);
            lvParticipants.SmallImageList = imgListSmall;
            lvParticipants.TabIndex = 53;
            lvParticipants.UseCompatibleStateImageBehavior = false;
            lvParticipants.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Last Name";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "First Name";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Birth Date";
            columnHeader3.Width = 120;
            // 
            // imgListLarge
            // 
            imgListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imgListLarge.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imgListLarge.ImageStream");
            imgListLarge.TransparentColor = System.Drawing.Color.Transparent;
            imgListLarge.Images.SetKeyName(0, "adult.png");
            imgListLarge.Images.SetKeyName(1, "child.png");
            // 
            // imgListSmall
            // 
            imgListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imgListSmall.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imgListSmall.ImageStream");
            imgListSmall.TransparentColor = System.Drawing.Color.Transparent;
            imgListSmall.Images.SetKeyName(0, "adult.png");
            imgListSmall.Images.SetKeyName(1, "child.png");
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
            groupBox1.TabIndex = 52;
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
            dtpBirthDate.CustomFormat = "yyyy.MM.dd HH:mm";
            dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new System.Drawing.Point(545, 33);
            dtpBirthDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new System.Drawing.Size(233, 23);
            dtpBirthDate.TabIndex = 5;
            // 
            // btnDetails
            // 
            btnDetails.Location = new System.Drawing.Point(14, 175);
            btnDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new System.Drawing.Size(88, 27);
            btnDetails.TabIndex = 54;
            btnDetails.Text = "Details";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnList
            // 
            btnList.Location = new System.Drawing.Point(108, 175);
            btnList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnList.Name = "btnList";
            btnList.Size = new System.Drawing.Size(88, 27);
            btnList.TabIndex = 55;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnLargeIcon
            // 
            btnLargeIcon.Location = new System.Drawing.Point(203, 175);
            btnLargeIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLargeIcon.Name = "btnLargeIcon";
            btnLargeIcon.Size = new System.Drawing.Size(88, 27);
            btnLargeIcon.TabIndex = 56;
            btnLargeIcon.Text = "LargeIcon";
            btnLargeIcon.UseVisualStyleBackColor = true;
            btnLargeIcon.Click += btnLargeIcon_Click;
            // 
            // btnSmallIcon
            // 
            btnSmallIcon.Location = new System.Drawing.Point(298, 175);
            btnSmallIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSmallIcon.Name = "btnSmallIcon";
            btnSmallIcon.Size = new System.Drawing.Size(88, 27);
            btnSmallIcon.TabIndex = 57;
            btnSmallIcon.Text = "SmallIcon";
            btnSmallIcon.UseVisualStyleBackColor = true;
            btnSmallIcon.Click += btnSmallIcon_Click;
            // 
            // btnTiles
            // 
            btnTiles.Location = new System.Drawing.Point(392, 175);
            btnTiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnTiles.Name = "btnTiles";
            btnTiles.Size = new System.Drawing.Size(88, 27);
            btnTiles.TabIndex = 58;
            btnTiles.Text = "Tile";
            btnTiles.UseVisualStyleBackColor = true;
            btnTiles.Click += btnTiles_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(827, 493);
            Controls.Add(btnTiles);
            Controls.Add(btnSmallIcon);
            Controls.Add(btnLargeIcon);
            Controls.Add(btnList);
            Controls.Add(btnDetails);
            Controls.Add(lvParticipants);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "WinAppProgramming Run";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvParticipants;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.ImageList imgListSmall;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button btnDetails;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Button btnLargeIcon;
		private System.Windows.Forms.Button btnSmallIcon;
		private System.Windows.Forms.Button btnTiles;
		private System.Windows.Forms.ImageList imgListLarge;
	}
}

