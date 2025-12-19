namespace Cinema_management.Ticket_Booking
{
    partial class UCMovieCard
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
            this.lbTitle = new Krypton.Toolkit.KryptonLabel();
            this.picPoster = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = false;
            this.lbTitle.Location = new System.Drawing.Point(17, 407);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(322, 88);
            this.lbTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lbTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbTitle.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Values.Text = "Tên phim";
            this.lbTitle.Click += new System.EventHandler(this.UCMovieCard_Click);
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(0, 0);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(356, 400);
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // UCMovieCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picPoster);
            this.Controls.Add(this.lbTitle);
            this.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Name = "UCMovieCard";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Size = new System.Drawing.Size(356, 511);
            this.Load += new System.EventHandler(this.UCMovieCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel lbTitle;
        private Krypton.Toolkit.KryptonPictureBox picPoster;
    }
}
