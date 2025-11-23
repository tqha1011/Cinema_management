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
            this.pnLogin = new Krypton.Toolkit.KryptonPanel();
            this.ucLogin1 = new Cinema_management.UCLogin();
            this.pbPoster = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnPoster)).BeginInit();
            this.pnPoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnLogin)).BeginInit();
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPoster
            // 
            this.pnPoster.Controls.Add(this.pbPoster);
            this.pnPoster.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPoster.Location = new System.Drawing.Point(0, 0);
            this.pnPoster.Name = "pnPoster";
            this.pnPoster.Size = new System.Drawing.Size(430, 444);
            this.pnPoster.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.pnPoster.TabIndex = 0;
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.ucLogin1);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLogin.Location = new System.Drawing.Point(430, 0);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(548, 444);
            this.pnLogin.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnLogin.TabIndex = 1;
            // 
            // ucLogin1
            // 
            this.ucLogin1.BackColor = System.Drawing.Color.White;
            this.ucLogin1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucLogin1.Location = new System.Drawing.Point(27, 21);
            this.ucLogin1.Name = "ucLogin1";
            this.ucLogin1.Size = new System.Drawing.Size(490, 400);
            this.ucLogin1.TabIndex = 0;
            // 
            // pbPoster
            // 
            this.pbPoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPoster.Location = new System.Drawing.Point(0, 0);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(430, 444);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPoster.TabIndex = 0;
            this.pbPoster.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 444);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pnPoster);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In To Your Account";
            ((System.ComponentModel.ISupportInitialize)(this.pnPoster)).EndInit();
            this.pnPoster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnLogin)).EndInit();
            this.pnLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnPoster;
        private Krypton.Toolkit.KryptonPictureBox pbPoster;
        private Krypton.Toolkit.KryptonPanel pnLogin;
        private UCLogin ucLogin1;
    }
}