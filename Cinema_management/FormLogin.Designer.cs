namespace Cinema_management
{
    partial class FormLogin
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
            this.pnPoster = new Krypton.Toolkit.KryptonPanel();
            this.pbPoster = new Krypton.Toolkit.KryptonPictureBox();
            this.panelUC = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pnPoster)).BeginInit();
            this.pnPoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUC)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPoster
            // 
            this.pnPoster.Controls.Add(this.pbPoster);
            this.pnPoster.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPoster.Location = new System.Drawing.Point(0, 0);
            this.pnPoster.Name = "pnPoster";
            this.pnPoster.Size = new System.Drawing.Size(400, 474);
            this.pnPoster.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.pnPoster.TabIndex = 0;
            // 
            // pbPoster
            // 
            this.pbPoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPoster.Location = new System.Drawing.Point(0, 0);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(400, 474);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPoster.TabIndex = 0;
            this.pbPoster.TabStop = false;
            // 
            // panelUC
            // 
            this.panelUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUC.Location = new System.Drawing.Point(400, 0);
            this.panelUC.Name = "panelUC";
            this.panelUC.Size = new System.Drawing.Size(578, 474);
            this.panelUC.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelUC.TabIndex = 1;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 474);
            this.Controls.Add(this.panelUC);
            this.Controls.Add(this.pnPoster);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in to your account";
            ((System.ComponentModel.ISupportInitialize)(this.pnPoster)).EndInit();
            this.pnPoster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnPoster;
        private Krypton.Toolkit.KryptonPictureBox pbPoster;
        private Krypton.Toolkit.KryptonPanel panelUC;
    }
}