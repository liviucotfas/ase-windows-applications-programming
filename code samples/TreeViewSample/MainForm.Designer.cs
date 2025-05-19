using System.Windows.Forms;

namespace TreeViewSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tvw = new TreeView();
            imgList = new ImageList(components);
            cb = new CheckBox();
            btnCollapseAll = new Button();
            btnCollapse = new Button();
            btnExpandAll = new Button();
            btnExpand = new Button();
            btnToggle = new Button();
            btnSelected = new Button();
            SuspendLayout();
            // 
            // tvw
            // 
            tvw.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tvw.BackColor = System.Drawing.SystemColors.Window;
            tvw.ForeColor = System.Drawing.Color.DarkRed;
            tvw.HideSelection = false;
            tvw.HotTracking = true;
            tvw.ImageIndex = 0;
            tvw.ImageList = imgList;
            tvw.Location = new System.Drawing.Point(0, 0);
            tvw.Margin = new Padding(4, 3, 4, 3);
            tvw.Name = "tvw";
            tvw.SelectedImageIndex = 0;
            tvw.Size = new System.Drawing.Size(524, 492);
            tvw.TabIndex = 0;
            tvw.BeforeExpand += tvw_BeforeExpand;
            // 
            // imgList
            // 
            imgList.ColorDepth = ColorDepth.Depth32Bit;
            imgList.ImageStream = (ImageListStreamer)resources.GetObject("imgList.ImageStream");
            imgList.TransparentColor = System.Drawing.Color.Transparent;
            imgList.Images.SetKeyName(0, "closedFolder.png");
            imgList.Images.SetKeyName(1, "file.png");
            imgList.Images.SetKeyName(2, "jpgFile.png");
            imgList.Images.SetKeyName(3, "openFolder.png");
            imgList.Images.SetKeyName(4, "pdfFile.png");
            imgList.Images.SetKeyName(5, "textFile.png");
            // 
            // cb
            // 
            cb.Anchor = AnchorStyles.Bottom;
            cb.Location = new System.Drawing.Point(217, 512);
            cb.Margin = new Padding(4, 3, 4, 3);
            cb.Name = "cb";
            cb.Size = new System.Drawing.Size(94, 23);
            cb.TabIndex = 1;
            cb.Text = "Show Files";
            cb.CheckedChanged += cb_CheckedChanged;
            // 
            // btnCollapseAll
            // 
            btnCollapseAll.Anchor = AnchorStyles.Bottom;
            btnCollapseAll.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            btnCollapseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCollapseAll.ForeColor = System.Drawing.Color.White;
            btnCollapseAll.Location = new System.Drawing.Point(346, 591);
            btnCollapseAll.Margin = new Padding(4, 3, 4, 3);
            btnCollapseAll.Name = "btnCollapseAll";
            btnCollapseAll.Size = new System.Drawing.Size(121, 29);
            btnCollapseAll.TabIndex = 7;
            btnCollapseAll.Text = "Colla&pse All";
            btnCollapseAll.UseVisualStyleBackColor = false;
            btnCollapseAll.Click += btnCollapseAll_Click;
            // 
            // btnCollapse
            // 
            btnCollapse.Anchor = AnchorStyles.Bottom;
            btnCollapse.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            btnCollapse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCollapse.ForeColor = System.Drawing.Color.White;
            btnCollapse.Location = new System.Drawing.Point(346, 555);
            btnCollapse.Margin = new Padding(4, 3, 4, 3);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new System.Drawing.Size(121, 29);
            btnCollapse.TabIndex = 6;
            btnCollapse.Text = "&Collapse";
            btnCollapse.UseVisualStyleBackColor = false;
            btnCollapse.Click += btnCollapse_Click;
            // 
            // btnExpandAll
            // 
            btnExpandAll.Anchor = AnchorStyles.Bottom;
            btnExpandAll.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            btnExpandAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnExpandAll.ForeColor = System.Drawing.Color.White;
            btnExpandAll.Location = new System.Drawing.Point(204, 591);
            btnExpandAll.Margin = new Padding(4, 3, 4, 3);
            btnExpandAll.Name = "btnExpandAll";
            btnExpandAll.Size = new System.Drawing.Size(121, 29);
            btnExpandAll.TabIndex = 5;
            btnExpandAll.Text = "Expand &All";
            btnExpandAll.UseVisualStyleBackColor = false;
            btnExpandAll.Click += btnExpandAll_Click;
            // 
            // btnExpand
            // 
            btnExpand.Anchor = AnchorStyles.Bottom;
            btnExpand.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            btnExpand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnExpand.ForeColor = System.Drawing.Color.White;
            btnExpand.Location = new System.Drawing.Point(204, 555);
            btnExpand.Margin = new Padding(4, 3, 4, 3);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new System.Drawing.Size(121, 29);
            btnExpand.TabIndex = 4;
            btnExpand.Text = "&Expand";
            btnExpand.UseVisualStyleBackColor = false;
            btnExpand.Click += btnExpand_Click;
            // 
            // btnToggle
            // 
            btnToggle.Anchor = AnchorStyles.Bottom;
            btnToggle.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnToggle.ForeColor = System.Drawing.Color.White;
            btnToggle.Location = new System.Drawing.Point(63, 591);
            btnToggle.Margin = new Padding(4, 3, 4, 3);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new System.Drawing.Size(121, 29);
            btnToggle.TabIndex = 3;
            btnToggle.Text = "&Toggle";
            btnToggle.UseVisualStyleBackColor = false;
            btnToggle.Click += btnToggle_Click;
            // 
            // btnSelected
            // 
            btnSelected.Anchor = AnchorStyles.Bottom;
            btnSelected.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            btnSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSelected.ForeColor = System.Drawing.Color.White;
            btnSelected.Location = new System.Drawing.Point(63, 555);
            btnSelected.Margin = new Padding(4, 3, 4, 3);
            btnSelected.Name = "btnSelected";
            btnSelected.Size = new System.Drawing.Size(121, 29);
            btnSelected.TabIndex = 2;
            btnSelected.Text = "&Selected Node";
            btnSelected.UseVisualStyleBackColor = false;
            btnSelected.Click += btnSelected_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(525, 633);
            Controls.Add(tvw);
            Controls.Add(cb);
            Controls.Add(btnSelected);
            Controls.Add(btnToggle);
            Controls.Add(btnExpand);
            Controls.Add(btnExpandAll);
            Controls.Add(btnCollapse);
            Controls.Add(btnCollapseAll);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "File Explorer";
            Load += MainForm_Load;
            ResumeLayout(false);

        }

        #endregion

        TreeView tvw;
		CheckBox cb;
		private ImageList imgList;
		private Button btnSelected;
		private Button btnToggle;
		private Button btnExpand;
		private Button btnExpandAll;
		private Button btnCollapse;
		private Button btnCollapseAll;
	}
}

