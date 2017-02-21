namespace SerializableCustomCollectionEvents
{
    partial class Editare
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
            this.btnSalvare = new System.Windows.Forms.Button();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.lblPren = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvare
            // 
            this.btnSalvare.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvare.Location = new System.Drawing.Point(196, 81);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(75, 23);
            this.btnSalvare.TabIndex = 48;
            this.btnSalvare.Text = "Salveaza";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.BtnSalvareClick);
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(71, 45);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(200, 20);
            this.tbPrenume.TabIndex = 45;
            // 
            // lblPren
            // 
            this.lblPren.AutoSize = true;
            this.lblPren.Location = new System.Drawing.Point(16, 49);
            this.lblPren.Name = "lblPren";
            this.lblPren.Size = new System.Drawing.Size(52, 13);
            this.lblPren.TabIndex = 44;
            this.lblPren.Text = "Prenume:";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(71, 12);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(200, 20);
            this.tbNume.TabIndex = 43;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(16, 16);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(38, 13);
            this.lblNume.TabIndex = 42;
            this.lblNume.Text = "Nume:";
            // 
            // Editare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 113);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.lblPren);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.lblNume);
            this.Name = "Editare";
            this.Text = "Editare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label lblPren;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lblNume;
    }
}