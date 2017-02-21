namespace ClockUserControlSample
{
    partial class ClockUserControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmTimp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmTimp
            // 
            this.tmTimp.Enabled = true;
            this.tmTimp.Interval = 1000;
            this.tmTimp.Tick += new System.EventHandler(this.tmTimp_Tick);
            // 
            // Ceas
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name = "ClockUserControl";
            this.Size = new System.Drawing.Size(274, 263);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CLockUserControl_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmTimp;
    }
}
