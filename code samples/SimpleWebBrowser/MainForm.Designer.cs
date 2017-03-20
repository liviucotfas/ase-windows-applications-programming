namespace SimpleWebBrowser
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
			this.tsNavigation = new System.Windows.Forms.ToolStrip();
			this.btnBack = new System.Windows.Forms.ToolStripButton();
			this.btnFwd = new System.Windows.Forms.ToolStripButton();
			this.btnReload = new System.Windows.Forms.ToolStripButton();
			this.btnHome = new System.Windows.Forms.ToolStripButton();
			this.tbAddress = new System.Windows.Forms.ToolStripTextBox();
			this.btnGo = new System.Windows.Forms.ToolStripButton();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.pbLoad = new System.Windows.Forms.ToolStripProgressBar();
			this.wb = new System.Windows.Forms.WebBrowser();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ctxMenuBtnBack = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxMenuBtnReload = new System.Windows.Forms.ToolStripMenuItem();
			this.msMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsNavigation.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.msMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsNavigation
			// 
			this.tsNavigation.BackColor = System.Drawing.Color.DarkGray;
			this.tsNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnFwd,
            this.btnReload,
            this.btnHome,
            this.tbAddress,
            this.btnGo});
			this.tsNavigation.Location = new System.Drawing.Point(0, 24);
			this.tsNavigation.Name = "tsNavigation";
			this.tsNavigation.Size = new System.Drawing.Size(663, 25);
			this.tsNavigation.TabIndex = 0;
			this.tsNavigation.Text = "toolStrip1";
			// 
			// btnBack
			// 
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(52, 22);
			this.btnBack.Text = "Back";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFwd
			// 
			this.btnFwd.Image = ((System.Drawing.Image)(resources.GetObject("btnFwd.Image")));
			this.btnFwd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFwd.Name = "btnFwd";
			this.btnFwd.Size = new System.Drawing.Size(49, 22);
			this.btnFwd.Text = "Fwd";
			this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
			// 
			// btnReload
			// 
			this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
			this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(63, 22);
			this.btnReload.Text = "Reload";
			this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
			// 
			// btnHome
			// 
			this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
			this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(23, 22);
			this.btnHome.Text = "Home";
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// tbAddress
			// 
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(250, 25);
			this.tbAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddress_KeyDown);
			// 
			// btnGo
			// 
			this.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
			this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(26, 22);
			this.btnGo.Text = "Go";
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbLoad});
			this.statusStrip.Location = new System.Drawing.Point(0, 272);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(663, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip1";
			// 
			// pbLoad
			// 
			this.pbLoad.Name = "pbLoad";
			this.pbLoad.Size = new System.Drawing.Size(100, 16);
			// 
			// wb
			// 
			this.wb.ContextMenuStrip = this.contextMenuStrip;
			this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wb.IsWebBrowserContextMenuEnabled = false;
			this.wb.Location = new System.Drawing.Point(0, 49);
			this.wb.MinimumSize = new System.Drawing.Size(20, 20);
			this.wb.Name = "wb";
			this.wb.ScriptErrorsSuppressed = true;
			this.wb.Size = new System.Drawing.Size(663, 223);
			this.wb.TabIndex = 2;
			this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wb_DocumentCompleted);
			this.wb.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wb_Navigated);
			this.wb.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.wb_Navigating);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuBtnBack,
            this.ctxMenuBtnReload});
			this.contextMenuStrip.Name = "contextMenuStrip1";
			this.contextMenuStrip.Size = new System.Drawing.Size(111, 48);
			// 
			// ctxMenuBtnBack
			// 
			this.ctxMenuBtnBack.Name = "ctxMenuBtnBack";
			this.ctxMenuBtnBack.Size = new System.Drawing.Size(110, 22);
			this.ctxMenuBtnBack.Text = "Back";
			this.ctxMenuBtnBack.Click += new System.EventHandler(this.ctxMenuBtnBack_Click);
			// 
			// ctxMenuBtnReload
			// 
			this.ctxMenuBtnReload.Name = "ctxMenuBtnReload";
			this.ctxMenuBtnReload.Size = new System.Drawing.Size(110, 22);
			this.ctxMenuBtnReload.Text = "Reload";
			this.ctxMenuBtnReload.Click += new System.EventHandler(this.ctxMenuBtnReload_Click);
			// 
			// msMain
			// 
			this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.msMain.Location = new System.Drawing.Point(0, 0);
			this.msMain.Name = "msMain";
			this.msMain.Size = new System.Drawing.Size(663, 24);
			this.msMain.TabIndex = 3;
			this.msMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 294);
			this.Controls.Add(this.wb);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.tsNavigation);
			this.Controls.Add(this.msMain);
			this.MainMenuStrip = this.msMain;
			this.Name = "MainForm";
			this.Text = "SimpleWebBrowser";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tsNavigation.ResumeLayout(false);
			this.tsNavigation.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.contextMenuStrip.ResumeLayout(false);
			this.msMain.ResumeLayout(false);
			this.msMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsNavigation;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.ToolStripProgressBar pbLoad;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnFwd;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripTextBox tbAddress;
        private System.Windows.Forms.ToolStripButton btnGo;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem ctxMenuBtnReload;
		private System.Windows.Forms.ToolStripMenuItem ctxMenuBtnBack;
	}
}

