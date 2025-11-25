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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucMovieCard1 = new Cinema_management.Ticket_Booking.UCMovieCard();
            ((System.ComponentModel.ISupportInitialize)(this.panelMM)).BeginInit();
            this.panelMM.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMovieManagement
            // 
            this.lblMovieManagement.Location = new System.Drawing.Point(68, 54);
            this.lblMovieManagement.Name = "lblMovieManagement";
            this.lblMovieManagement.Size = new System.Drawing.Size(317, 42);
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
            this.txtSearchMovie.Location = new System.Drawing.Point(86, 143);
            this.txtSearchMovie.Name = "txtSearchMovie";
            this.txtSearchMovie.Size = new System.Drawing.Size(300, 36);
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
            this.dtpSearchDate.Location = new System.Drawing.Point(452, 143);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.ShowCheckBox = true;
            this.dtpSearchDate.Size = new System.Drawing.Size(191, 36);
            this.dtpSearchDate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.dtpSearchDate.StateCommon.Border.Rounding = 10F;
            this.dtpSearchDate.TabIndex = 6;
            // 
            // panelMM
            // 
            this.panelMM.Controls.Add(this.lblMovieManagement);
            this.panelMM.Controls.Add(this.txtSearchMovie);
            this.panelMM.Controls.Add(this.pictureBox1);
            this.panelMM.Controls.Add(this.dtpSearchDate);
            this.panelMM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMM.Location = new System.Drawing.Point(0, 0);
            this.panelMM.Name = "panelMM";
            this.panelMM.Padding = new System.Windows.Forms.Padding(20);
            this.panelMM.Size = new System.Drawing.Size(900, 179);
            this.panelMM.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelMM.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.ucMovieCard1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 179);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 40, 40, 40);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 431);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema_management.Properties.Resources.lucide__search;
            this.pictureBox1.Location = new System.Drawing.Point(56, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ucMovieCard1
            // 
            this.ucMovieCard1.BackColor = System.Drawing.Color.White;
            this.ucMovieCard1.Location = new System.Drawing.Point(60, 50);
            this.ucMovieCard1.Margin = new System.Windows.Forms.Padding(10);
            this.ucMovieCard1.Name = "ucMovieCard1";
            this.ucMovieCard1.Padding = new System.Windows.Forms.Padding(10);
            this.ucMovieCard1.Size = new System.Drawing.Size(230, 340);
            this.ucMovieCard1.TabIndex = 0;
            // 
            // UCPhimDangChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelMM);
            this.Name = "UCPhimDangChieu";
            this.Size = new System.Drawing.Size(900, 610);
            ((System.ComponentModel.ISupportInitialize)(this.panelMM)).EndInit();
            this.panelMM.ResumeLayout(false);
            this.panelMM.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblMovieManagement;
        private Krypton.Toolkit.KryptonTextBox txtSearchMovie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonDateTimePicker dtpSearchDate;
        private Krypton.Toolkit.KryptonPanel panelMM;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UCMovieCard ucMovieCard1;
    }
}
