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
            this.components = new System.ComponentModel.Container();
            this.lblMovieManagement = new Krypton.Toolkit.KryptonLabel();
            this.txtSearchMovie = new Krypton.Toolkit.KryptonTextBox();
            this.dtpSearchDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.panelMM = new Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowPanelMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelMM)).BeginInit();
            this.panelMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMovieManagement
            // 
            this.lblMovieManagement.Location = new System.Drawing.Point(81, 56);
            this.lblMovieManagement.Name = "lblMovieManagement";
            this.lblMovieManagement.Size = new System.Drawing.Size(374, 56);
            this.lblMovieManagement.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.lblMovieManagement.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieManagement.TabIndex = 1;
            this.lblMovieManagement.Values.Text = "Now Showing Movie";
            // 
            // txtSearchMovie
            // 
            this.txtSearchMovie.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtSearchMovie.CueHint.CueHintText = "Search movie...";
            this.txtSearchMovie.CueHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMovie.Location = new System.Drawing.Point(127, 139);
            this.txtSearchMovie.Multiline = true;
            this.txtSearchMovie.Name = "txtSearchMovie";
            this.txtSearchMovie.Size = new System.Drawing.Size(330, 52);
            this.txtSearchMovie.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSearchMovie.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.txtSearchMovie.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtSearchMovie.StateCommon.Border.Width = 4;
            this.txtSearchMovie.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMovie.TabIndex = 4;
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpSearchDate.CalendarTodayDate = new System.DateTime(2025, 10, 28, 0, 0, 0, 0);
            this.dtpSearchDate.CustomFormat = "dd/MM/yyyy";
            this.dtpSearchDate.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchDate.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.dtpSearchDate.Location = new System.Drawing.Point(485, 146);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dtpSearchDate.Size = new System.Drawing.Size(191, 45);
            this.dtpSearchDate.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.dtpSearchDate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.dtpSearchDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dtpSearchDate.StateCommon.Border.Width = 3;
            this.dtpSearchDate.StateCommon.Content.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelMM.Location = new System.Drawing.Point(25, 25);
            this.panelMM.Name = "panelMM";
            this.panelMM.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.panelMM.Size = new System.Drawing.Size(850, 203);
            this.panelMM.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelMM.TabIndex = 9;
            this.panelMM.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMM_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema_management.Properties.Resources.lucide__search;
            this.pictureBox1.Location = new System.Drawing.Point(81, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // flowPanelMovies
            // 
            this.flowPanelMovies.AutoScroll = true;
            this.flowPanelMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelMovies.Location = new System.Drawing.Point(25, 228);
            this.flowPanelMovies.Name = "flowPanelMovies";
            this.flowPanelMovies.Padding = new System.Windows.Forms.Padding(50, 40, 40, 40);
            this.flowPanelMovies.Size = new System.Drawing.Size(850, 357);
            this.flowPanelMovies.TabIndex = 10;
            // 
            // kryptonCustomPaletteBase1
            // 
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.kryptonCustomPaletteBase1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // UCPhimDangChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowPanelMovies);
            this.Controls.Add(this.panelMM);
            this.Name = "UCPhimDangChieu";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Size = new System.Drawing.Size(900, 610);
            ((System.ComponentModel.ISupportInitialize)(this.panelMM)).EndInit();
            this.panelMM.ResumeLayout(false);
            this.panelMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblMovieManagement;
        private Krypton.Toolkit.KryptonTextBox txtSearchMovie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonDateTimePicker dtpSearchDate;
        private Krypton.Toolkit.KryptonPanel panelMM;
        private System.Windows.Forms.FlowLayoutPanel flowPanelMovies;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        //private UCMovieCard ucMovieCard1;
    }
}
