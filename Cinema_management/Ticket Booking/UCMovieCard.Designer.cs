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
            this.picPoster = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.lbTitle = new Krypton.Toolkit.KryptonWrapLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.kryptonTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(2, 2);
            this.picPoster.Margin = new System.Windows.Forms.Padding(2);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(201, 240);
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.AutoSize = true;
            this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroup1.Location = new System.Drawing.Point(10, 10);
            this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonTableLayoutPanel1);
            this.kryptonGroup1.Panel.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.kryptonGroup1.Size = new System.Drawing.Size(247, 431);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(90)))), ((int)(((byte)(48)))));
            this.kryptonGroup1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonGroup1.StateCommon.Border.ColorAngle = 90F;
            this.kryptonGroup1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear33;
            this.kryptonGroup1.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup1.StateCommon.Border.Width = 5;
            this.kryptonGroup1.TabIndex = 2;
            // 
            // kryptonTableLayoutPanel1
            // 
            this.kryptonTableLayoutPanel1.ColumnCount = 1;
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel1.Controls.Add(this.picPoster, 0, 0);
            this.kryptonTableLayoutPanel1.Controls.Add(this.lbTitle, 0, 1);
            this.kryptonTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel1.Location = new System.Drawing.Point(10, 20);
            this.kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            this.kryptonTableLayoutPanel1.RowCount = 2;
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel1.Size = new System.Drawing.Size(205, 369);
            this.kryptonTableLayoutPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonTableLayoutPanel1.TabIndex = 3;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            this.lbTitle.Location = new System.Drawing.Point(3, 254);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(199, 108);
            this.lbTitle.StateCommon.Font = new System.Drawing.Font("Nunito", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbTitle.Text = "Thám tử lừng danh conan phần 1";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCMovieCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonGroup1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UCMovieCard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(267, 451);
            this.Load += new System.EventHandler(this.UCMovieCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.kryptonTableLayoutPanel1.ResumeLayout(false);
            this.kryptonTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonPictureBox picPoster;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Krypton.Toolkit.KryptonWrapLabel lbTitle;
    }
}
