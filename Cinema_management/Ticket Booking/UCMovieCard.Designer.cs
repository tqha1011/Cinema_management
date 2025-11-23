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
            this.panelPoster = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = false;
            this.lbTitle.Location = new System.Drawing.Point(13, 268);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(215, 39);
            this.lbTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lbTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbTitle.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Values.Text = "Tên phim";
            // 
            // panelPoster
            // 
            this.panelPoster.Location = new System.Drawing.Point(0, 0);
            this.panelPoster.Name = "panelPoster";
            this.panelPoster.Size = new System.Drawing.Size(230, 262);
            this.panelPoster.TabIndex = 2;
            // 
            // UCMovieCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelPoster);
            this.Controls.Add(this.lbTitle);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UCMovieCard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(230, 340);
            ((System.ComponentModel.ISupportInitialize)(this.panelPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel lbTitle;
        private Krypton.Toolkit.KryptonPanel panelPoster;
    }
}
