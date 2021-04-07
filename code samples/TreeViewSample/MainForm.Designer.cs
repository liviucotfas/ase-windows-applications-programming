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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tvw = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.cb = new System.Windows.Forms.CheckBox();
            this.btnCollapseAll = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExpandAll = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvw
            // 
            this.tvw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvw.BackColor = System.Drawing.SystemColors.Window;
            this.tvw.ForeColor = System.Drawing.Color.DarkRed;
            this.tvw.HideSelection = false;
            this.tvw.HotTracking = true;
            this.tvw.ImageIndex = 0;
            this.tvw.ImageList = this.imgList;
            this.tvw.Location = new System.Drawing.Point(0, 0);
            this.tvw.Name = "tvw";
            this.tvw.SelectedImageIndex = 0;
            this.tvw.Size = new System.Drawing.Size(450, 427);
            this.tvw.TabIndex = 0;
            this.tvw.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvw_BeforeExpand);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "closedFolder.png");
            this.imgList.Images.SetKeyName(1, "file.png");
            this.imgList.Images.SetKeyName(2, "pdfFile.png");
            this.imgList.Images.SetKeyName(3, "textFile.png");
            this.imgList.Images.SetKeyName(4, "jpgFile.png");
            this.imgList.Images.SetKeyName(5, "openFolder.png");
            // 
            // cb
            // 
            this.cb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cb.Location = new System.Drawing.Point(186, 444);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(81, 20);
            this.cb.TabIndex = 1;
            this.cb.Text = "Show Files";
            this.cb.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCollapseAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCollapseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapseAll.ForeColor = System.Drawing.Color.White;
            this.btnCollapseAll.Location = new System.Drawing.Point(297, 512);
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.Size = new System.Drawing.Size(104, 25);
            this.btnCollapseAll.TabIndex = 7;
            this.btnCollapseAll.Text = "Colla&pse All";
            this.btnCollapseAll.UseVisualStyleBackColor = false;
            this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCollapse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCollapse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapse.ForeColor = System.Drawing.Color.White;
            this.btnCollapse.Location = new System.Drawing.Point(297, 481);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(104, 25);
            this.btnCollapse.TabIndex = 6;
            this.btnCollapse.Text = "&Collapse";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExpandAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExpandAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandAll.ForeColor = System.Drawing.Color.White;
            this.btnExpandAll.Location = new System.Drawing.Point(175, 512);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(104, 25);
            this.btnExpandAll.TabIndex = 5;
            this.btnExpandAll.Text = "Expand &All";
            this.btnExpandAll.UseVisualStyleBackColor = false;
            this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExpand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpand.ForeColor = System.Drawing.Color.White;
            this.btnExpand.Location = new System.Drawing.Point(175, 481);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(104, 25);
            this.btnExpand.TabIndex = 4;
            this.btnExpand.Text = "&Expand";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.ForeColor = System.Drawing.Color.White;
            this.btnToggle.Location = new System.Drawing.Point(54, 512);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(104, 25);
            this.btnToggle.TabIndex = 3;
            this.btnToggle.Text = "&Toggle";
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnSelected
            // 
            this.btnSelected.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelected.ForeColor = System.Drawing.Color.White;
            this.btnSelected.Location = new System.Drawing.Point(54, 481);
            this.btnSelected.Name = "btnSelected";
            this.btnSelected.Size = new System.Drawing.Size(104, 25);
            this.btnSelected.TabIndex = 2;
            this.btnSelected.Text = "&Selected Node";
            this.btnSelected.UseVisualStyleBackColor = false;
            this.btnSelected.Click += new System.EventHandler(this.btnSelected_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 549);
            this.Controls.Add(this.tvw);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.btnSelected);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.btnExpandAll);
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.btnCollapseAll);
            this.Name = "MainForm";
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

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

