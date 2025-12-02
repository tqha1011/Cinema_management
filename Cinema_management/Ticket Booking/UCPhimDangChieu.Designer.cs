namespace Cinema_management.Ticket_Booking
{
    partial class UCPhimDangChieu
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
            this.lblMovieManagement = new Krypton.Toolkit.KryptonLabel();
            this.txtSearchMovie = new Krypton.Toolkit.KryptonTextBox();
            this.dtpSearchDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.panelMM = new Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowPanelMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.ucMovieCard1 = new Cinema_management.Ticket_Booking.UCMovieCard();
            ((System.ComponentModel.ISupportInitialize)(this.panelMM)).BeginInit();
            this.panelMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowPanelMovies.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMovieManagement
            // 
            this.lblMovieManagement.Location = new System.Drawing.Point(91, 68);
            this.lblMovieManagement.Margin = new System.Windows.Forms.Padding(4);
            this.lblMovieManagement.Name = "lblMovieManagement";
            this.lblMovieManagement.Size = new System.Drawing.Size(421, 55);
            this.lblMovieManagement.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblMovieManagement.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieManagement.TabIndex = 1;
            this.lblMovieManagement.Values.Text = "Now Showing Movie";
            // 
            // txtSearchMovie
            // 
            this.txtSearchMovie.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtSearchMovie.CueHint.CueHintText = "Search movie...";
            this.txtSearchMovie.CueHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMovie.Location = new System.Drawing.Point(115, 179);
            this.txtSearchMovie.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchMovie.Name = "txtSearchMovie";
            this.txtSearchMovie.Size = new System.Drawing.Size(400, 44);
            this.txtSearchMovie.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txtSearchMovie.StateCommon.Border.Rounding = 10F;
            this.txtSearchMovie.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMovie.TabIndex = 4;
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpSearchDate.CalendarTodayDate = new System.DateTime(2025, 10, 28, 0, 0, 0, 0);
            this.dtpSearchDate.CustomFormat = "dd/MM/yyyy";
            this.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchDate.Location = new System.Drawing.Point(603, 179);
            this.dtpSearchDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(255, 43);
            this.dtpSearchDate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.dtpSearchDate.StateCommon.Border.Rounding = 10F;
            this.dtpSearchDate.TabIndex = 6;
            this.dtpSearchDate.ValueChanged += new System.EventHandler(this.dtpSearchDate_ValueChanged);
            // 
            // panelMM
            // 
            this.panelMM.Controls.Add(this.lblMovieManagement);
            this.panelMM.Controls.Add(this.txtSearchMovie);
            this.panelMM.Controls.Add(this.pictureBox1);
            this.panelMM.Controls.Add(this.dtpSearchDate);
            this.panelMM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMM.Location = new System.Drawing.Point(0, 0);
            this.panelMM.Margin = new System.Windows.Forms.Padding(4);
            this.panelMM.Name = "panelMM";
            this.panelMM.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panelMM.Size = new System.Drawing.Size(1200, 224);
            this.panelMM.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelMM.TabIndex = 9;
            this.panelMM.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMM_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema_management.Properties.Resources.lucide__search;
            this.pictureBox1.Location = new System.Drawing.Point(75, 179);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // flowPanelMovies
            // 
            this.flowPanelMovies.AutoScroll = true;
            this.flowPanelMovies.Controls.Add(this.ucMovieCard1);
            this.flowPanelMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelMovies.Location = new System.Drawing.Point(0, 224);
            this.flowPanelMovies.Margin = new System.Windows.Forms.Padding(4);
            this.flowPanelMovies.Name = "flowPanelMovies";
            this.flowPanelMovies.Padding = new System.Windows.Forms.Padding(67, 50, 53, 50);
            this.flowPanelMovies.Size = new System.Drawing.Size(1200, 538);
            this.flowPanelMovies.TabIndex = 10;
            // 
            // ucMovieCard1
            // 
            this.ucMovieCard1.BackColor = System.Drawing.Color.White;
            this.ucMovieCard1.Location = new System.Drawing.Point(80, 62);
            this.ucMovieCard1.MaPhim = 0;
            this.ucMovieCard1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.ucMovieCard1.Name = "ucMovieCard1";
            this.ucMovieCard1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.ucMovieCard1.Size = new System.Drawing.Size(307, 425);
            this.ucMovieCard1.TabIndex = 0;
            // 
            // UCPhimDangChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowPanelMovies);
            this.Controls.Add(this.panelMM);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCPhimDangChieu";
            this.Size = new System.Drawing.Size(1200, 762);
            ((System.ComponentModel.ISupportInitialize)(this.panelMM)).EndInit();
            this.panelMM.ResumeLayout(false);
            this.panelMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowPanelMovies.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblMovieManagement;
        private Krypton.Toolkit.KryptonTextBox txtSearchMovie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonDateTimePicker dtpSearchDate;
        private Krypton.Toolkit.KryptonPanel panelMM;
        private System.Windows.Forms.FlowLayoutPanel flowPanelMovies;
        private UCMovieCard ucMovieCard1;
    }
}
