namespace SerializableCustomCollectionEvents
{
    partial class BonComanda
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BonComanda));
			this.tbData = new System.Windows.Forms.TextBox();
			this.tbOra = new System.Windows.Forms.TextBox();
			this.lblData = new System.Windows.Forms.Label();
			this.lblOra = new System.Windows.Forms.Label();
			this.epNume = new System.Windows.Forms.ErrorProvider(this.components);
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnSalvare = new System.Windows.Forms.Button();
			this.cbMasina = new System.Windows.Forms.ComboBox();
			this.lblMasina = new System.Windows.Forms.Label();
			this.tbPrenume = new System.Windows.Forms.TextBox();
			this.lblPren = new System.Windows.Forms.Label();
			this.tbNume = new System.Windows.Forms.TextBox();
			this.lblNume = new System.Windows.Forms.Label();
			this.tpVizComenzi = new System.Windows.Forms.TabPage();
			this.btnRestaureaza = new System.Windows.Forms.Button();
			this.btnSalveaza = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.lvComenzi = new System.Windows.Forms.ListView();
			this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chMasina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripOrderCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.epNume)).BeginInit();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tpVizComenzi.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbData
			// 
			this.tbData.Location = new System.Drawing.Point(380, 59);
			this.tbData.Name = "tbData";
			this.tbData.ReadOnly = true;
			this.tbData.Size = new System.Drawing.Size(87, 20);
			this.tbData.TabIndex = 11;
			// 
			// tbOra
			// 
			this.tbOra.Location = new System.Drawing.Point(507, 59);
			this.tbOra.Name = "tbOra";
			this.tbOra.ReadOnly = true;
			this.tbOra.Size = new System.Drawing.Size(87, 20);
			this.tbOra.TabIndex = 12;
			// 
			// lblData
			// 
			this.lblData.AutoSize = true;
			this.lblData.Location = new System.Drawing.Point(347, 63);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(30, 13);
			this.lblData.TabIndex = 13;
			this.lblData.Text = "Data";
			// 
			// lblOra
			// 
			this.lblOra.AutoSize = true;
			this.lblOra.Location = new System.Drawing.Point(480, 63);
			this.lblOra.Name = "lblOra";
			this.lblOra.Size = new System.Drawing.Size(24, 13);
			this.lblOra.TabIndex = 14;
			this.lblOra.Text = "Ora";
			// 
			// epNume
			// 
			this.epNume.ContainerControl = this;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tpVizComenzi);
			this.tabControl.Location = new System.Drawing.Point(12, 85);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(623, 203);
			this.tabControl.TabIndex = 27;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnSalvare);
			this.tabPage1.Controls.Add(this.cbMasina);
			this.tabPage1.Controls.Add(this.lblMasina);
			this.tabPage1.Controls.Add(this.tbPrenume);
			this.tabPage1.Controls.Add(this.lblPren);
			this.tabPage1.Controls.Add(this.tbNume);
			this.tabPage1.Controls.Add(this.lblNume);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(615, 177);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Adauga Comanda";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnSalvare
			// 
			this.btnSalvare.Location = new System.Drawing.Point(203, 131);
			this.btnSalvare.Name = "btnSalvare";
			this.btnSalvare.Size = new System.Drawing.Size(75, 23);
			this.btnSalvare.TabIndex = 41;
			this.btnSalvare.Text = "Adauga";
			this.btnSalvare.UseVisualStyleBackColor = true;
			this.btnSalvare.Click += new System.EventHandler(this.BtnSalvareClick1);
			// 
			// cbMasina
			// 
			this.cbMasina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMasina.FormattingEnabled = true;
			this.cbMasina.Items.AddRange(new object[] {
            "BMW",
            "Dacia",
            "Ferrari",
            "Ford ",
            "Lada",
            "Mercedes",
            "Skoda"});
			this.cbMasina.Location = new System.Drawing.Point(78, 94);
			this.cbMasina.Name = "cbMasina";
			this.cbMasina.Size = new System.Drawing.Size(200, 21);
			this.cbMasina.Sorted = true;
			this.cbMasina.TabIndex = 39;
			// 
			// lblMasina
			// 
			this.lblMasina.AutoSize = true;
			this.lblMasina.Location = new System.Drawing.Point(23, 98);
			this.lblMasina.Name = "lblMasina";
			this.lblMasina.Size = new System.Drawing.Size(44, 13);
			this.lblMasina.TabIndex = 38;
			this.lblMasina.Text = "Masina:";
			// 
			// tbPrenume
			// 
			this.tbPrenume.Location = new System.Drawing.Point(78, 60);
			this.tbPrenume.Name = "tbPrenume";
			this.tbPrenume.Size = new System.Drawing.Size(200, 20);
			this.tbPrenume.TabIndex = 30;
			// 
			// lblPren
			// 
			this.lblPren.AutoSize = true;
			this.lblPren.Location = new System.Drawing.Point(23, 64);
			this.lblPren.Name = "lblPren";
			this.lblPren.Size = new System.Drawing.Size(52, 13);
			this.lblPren.TabIndex = 29;
			this.lblPren.Text = "Prenume:";
			// 
			// tbNume
			// 
			this.tbNume.Location = new System.Drawing.Point(78, 27);
			this.tbNume.Name = "tbNume";
			this.tbNume.Size = new System.Drawing.Size(200, 20);
			this.tbNume.TabIndex = 28;
			// 
			// lblNume
			// 
			this.lblNume.AutoSize = true;
			this.lblNume.Location = new System.Drawing.Point(23, 31);
			this.lblNume.Name = "lblNume";
			this.lblNume.Size = new System.Drawing.Size(38, 13);
			this.lblNume.TabIndex = 27;
			this.lblNume.Text = "Nume:";
			// 
			// tpVizComenzi
			// 
			this.tpVizComenzi.Controls.Add(this.btnRestaureaza);
			this.tpVizComenzi.Controls.Add(this.btnSalveaza);
			this.tpVizComenzi.Controls.Add(this.btnDelete);
			this.tpVizComenzi.Controls.Add(this.btnEdit);
			this.tpVizComenzi.Controls.Add(this.lvComenzi);
			this.tpVizComenzi.Location = new System.Drawing.Point(4, 22);
			this.tpVizComenzi.Name = "tpVizComenzi";
			this.tpVizComenzi.Padding = new System.Windows.Forms.Padding(3);
			this.tpVizComenzi.Size = new System.Drawing.Size(615, 177);
			this.tpVizComenzi.TabIndex = 1;
			this.tpVizComenzi.Text = "Vizalizare comenzi";
			this.tpVizComenzi.UseVisualStyleBackColor = true;
			// 
			// btnRestaureaza
			// 
			this.btnRestaureaza.Location = new System.Drawing.Point(531, 144);
			this.btnRestaureaza.Name = "btnRestaureaza";
			this.btnRestaureaza.Size = new System.Drawing.Size(75, 23);
			this.btnRestaureaza.TabIndex = 4;
			this.btnRestaureaza.Text = "Restaureaza";
			this.btnRestaureaza.UseVisualStyleBackColor = true;
			this.btnRestaureaza.Click += new System.EventHandler(this.BtnRestaureazaClick);
			// 
			// btnSalveaza
			// 
			this.btnSalveaza.Location = new System.Drawing.Point(531, 113);
			this.btnSalveaza.Name = "btnSalveaza";
			this.btnSalveaza.Size = new System.Drawing.Size(75, 23);
			this.btnSalveaza.TabIndex = 3;
			this.btnSalveaza.Text = "Salveaza";
			this.btnSalveaza.UseVisualStyleBackColor = true;
			this.btnSalveaza.Click += new System.EventHandler(this.BtnSalveazaClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(531, 43);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(531, 14);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// lvComenzi
			// 
			this.lvComenzi.AllowColumnReorder = true;
			this.lvComenzi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNume,
            this.chPrenume,
            this.chMasina});
			this.lvComenzi.FullRowSelect = true;
			this.lvComenzi.GridLines = true;
			this.lvComenzi.Location = new System.Drawing.Point(3, 3);
			this.lvComenzi.Name = "lvComenzi";
			this.lvComenzi.Size = new System.Drawing.Size(518, 171);
			this.lvComenzi.TabIndex = 0;
			this.lvComenzi.UseCompatibleStateImageBehavior = false;
			this.lvComenzi.View = System.Windows.Forms.View.Details;
			// 
			// chNume
			// 
			this.chNume.Text = "Nume";
			// 
			// chPrenume
			// 
			this.chPrenume.Text = "Prenume";
			// 
			// chMasina
			// 
			this.chMasina.Text = "Masina";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripOrderCount});
			this.statusStrip1.Location = new System.Drawing.Point(0, 298);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(643, 22);
			this.statusStrip1.TabIndex = 28;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripOrderCount
			// 
			this.toolStripOrderCount.Name = "toolStripOrderCount";
			this.toolStripOrderCount.Size = new System.Drawing.Size(13, 17);
			this.toolStripOrderCount.Text = "0";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(643, 24);
			this.menuStrip1.TabIndex = 29;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(643, 25);
			this.toolStrip1.TabIndex = 30;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(95, 17);
			this.toolStripStatusLabel1.Text = "Numar comenzi:";
			// 
			// BonComanda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(643, 320);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.lblOra);
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.tbOra);
			this.Controls.Add(this.tbData);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "BonComanda";
			this.Text = "Bon comanda- Dealer Auto";
			this.Load += new System.EventHandler(this.Form1Load);
			((System.ComponentModel.ISupportInitialize)(this.epNume)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tpVizComenzi.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbOra;
        private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.ErrorProvider epNume;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.ComboBox cbMasina;
        private System.Windows.Forms.Label lblMasina;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label lblPren;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TabPage tpVizComenzi;
        private System.Windows.Forms.ListView lvComenzi;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chPrenume;
        private System.Windows.Forms.ColumnHeader chMasina;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRestaureaza;
        private System.Windows.Forms.Button btnSalveaza;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripOrderCount;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
	}
}

