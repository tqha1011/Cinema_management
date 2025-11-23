namespace Cinema_management
{
    partial class UCMovies
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
            Krypton.Toolkit.IconSpec iconSpec1 = new Krypton.Toolkit.IconSpec();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMovies));
            Krypton.Toolkit.IconSpec iconSpec2 = new Krypton.Toolkit.IconSpec();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMovieManagement = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.dgvMM = new Krypton.Toolkit.KryptonDataGridView();
            this.MovieName = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Genre = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.AgeRating = new Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            this.Duration = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.editBtn = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.delBtn = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnSearch = new Krypton.Toolkit.KryptonPanel();
            this.txbSearchMovie = new Krypton.Toolkit.KryptonTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnSearchDate = new Krypton.Toolkit.KryptonPanel();
            this.dtpSearchDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMM)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).BeginInit();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnSearchDate)).BeginInit();
            this.pnSearchDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonButton1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 120);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.lblMovieManagement);
            this.flowLayoutPanel1.Controls.Add(this.kryptonLabel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(745, 87);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblMovieManagement
            // 
            this.lblMovieManagement.Location = new System.Drawing.Point(3, 3);
            this.lblMovieManagement.Name = "lblMovieManagement";
            this.lblMovieManagement.Size = new System.Drawing.Size(308, 42);
            this.lblMovieManagement.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblMovieManagement.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieManagement.TabIndex = 0;
            this.lblMovieManagement.Values.Text = "Movie Management";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 51);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(444, 33);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Manage your cinema\'s movie collection";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(754, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(259, 58);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 10F;
            this.kryptonButton1.StateCommon.Border.Width = 0;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 10F;
            this.kryptonButton1.StatePressed.Border.Width = 0;
            this.kryptonButton1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.Rounding = 10F;
            this.kryptonButton1.StateTracking.Border.Width = 0;
            this.kryptonButton1.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 2;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Image = global::Cinema_management.Properties.Resources.material_symbols__add_rounded;
            this.kryptonButton1.Values.Text = "Add New Movie";
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroup1.Location = new System.Drawing.Point(20, 140);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.dgvMM);
            this.kryptonGroup1.Size = new System.Drawing.Size(1016, 528);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.kryptonGroup1.StateCommon.Border.Rounding = 15F;
            this.kryptonGroup1.TabIndex = 6;
            // 
            // dgvMM
            // 
            this.dgvMM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieName,
            this.Genre,
            this.AgeRating,
            this.Duration,
            this.editBtn,
            this.delBtn});
            this.dgvMM.Location = new System.Drawing.Point(0, 87);
            this.dgvMM.Name = "dgvMM";
            this.dgvMM.RowHeadersVisible = false;
            this.dgvMM.RowHeadersWidth = 62;
            this.dgvMM.RowTemplate.Height = 40;
            this.dgvMM.Size = new System.Drawing.Size(1181, 468);
            this.dgvMM.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvMM.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvMM.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvMM.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.LightGray;
            this.dgvMM.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dgvMM.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvMM.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMM.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.dgvMM.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dgvMM.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.LightGray;
            this.dgvMM.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dgvMM.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMM.TabIndex = 0;
            this.dgvMM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_CellContentClick);
            // 
            // MovieName
            // 
            this.MovieName.HeaderText = "Movie Name";
            this.MovieName.MinimumWidth = 8;
            this.MovieName.Name = "MovieName";
            this.MovieName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MovieName.Width = 300;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 8;
            this.Genre.Name = "Genre";
            this.Genre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Genre.Width = 200;
            // 
            // AgeRating
            // 
            this.AgeRating.DropDownWidth = 121;
            this.AgeRating.HeaderText = "AgeRating";
            this.AgeRating.Items.Add("P");
            this.AgeRating.Items.Add("K");
            this.AgeRating.Items.Add("T13");
            this.AgeRating.Items.Add("T16");
            this.AgeRating.Items.Add("T18");
            this.AgeRating.MinimumWidth = 8;
            this.AgeRating.Name = "AgeRating";
            this.AgeRating.Width = 150;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration (min)";
            this.Duration.MinimumWidth = 8;
            this.Duration.Name = "Duration";
            this.Duration.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Duration.Width = 250;
            // 
            // editBtn
            // 
            this.editBtn.HeaderText = "Edit";
            iconSpec1.Alignment = Krypton.Toolkit.IconSpec.IconAlignment.Left;
            iconSpec1.Icon = ((System.Drawing.Image)(resources.GetObject("iconSpec1.Icon")));
            this.editBtn.IconSpecs.Add(iconSpec1);
            this.editBtn.MinimumWidth = 8;
            this.editBtn.Name = "editBtn";
            this.editBtn.Text = "Edit";
            this.editBtn.UseColumnTextForButtonValue = true;
            this.editBtn.Width = 130;
            // 
            // delBtn
            // 
            this.delBtn.HeaderText = "Delete";
            iconSpec2.Alignment = Krypton.Toolkit.IconSpec.IconAlignment.Left;
            iconSpec2.Icon = ((System.Drawing.Image)(resources.GetObject("iconSpec2.Icon")));
            this.delBtn.IconSpecs.Add(iconSpec2);
            this.delBtn.MinimumWidth = 8;
            this.delBtn.Name = "delBtn";
            this.delBtn.Text = "Delete";
            this.delBtn.UseColumnTextForButtonValue = true;
            this.delBtn.Width = 130;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.pnSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnSearchDate, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 140);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1016, 87);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.txbSearchMovie);
            this.pnSearch.Controls.Add(this.pictureBox1);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearch.Location = new System.Drawing.Point(3, 3);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(394, 54);
            this.pnSearch.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnSearch.TabIndex = 0;
            // 
            // txbSearchMovie
            // 
            this.txbSearchMovie.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txbSearchMovie.CueHint.CueHintText = "Search movie...";
            this.txbSearchMovie.CueHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchMovie.Location = new System.Drawing.Point(59, 10);
            this.txbSearchMovie.Name = "txbSearchMovie";
            this.txbSearchMovie.Size = new System.Drawing.Size(300, 36);
            this.txbSearchMovie.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txbSearchMovie.StateCommon.Border.Rounding = 10F;
            this.txbSearchMovie.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchMovie.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema_management.Properties.Resources.lucide__search;
            this.pictureBox1.Location = new System.Drawing.Point(19, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnSearchDate
            // 
            this.pnSearchDate.Controls.Add(this.dtpSearchDate);
            this.pnSearchDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearchDate.Location = new System.Drawing.Point(403, 3);
            this.pnSearchDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.pnSearchDate.Name = "pnSearchDate";
            this.pnSearchDate.Size = new System.Drawing.Size(662, 54);
            this.pnSearchDate.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnSearchDate.TabIndex = 6;
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpSearchDate.CalendarTodayDate = new System.DateTime(2025, 10, 28, 0, 0, 0, 0);
            this.dtpSearchDate.CustomFormat = "mm/dd/yyyy";
            this.dtpSearchDate.CustomNullText = "mm/dd/yyyy";
            this.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchDate.Location = new System.Drawing.Point(0, 9);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(191, 36);
            this.dtpSearchDate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.dtpSearchDate.StateCommon.Border.Rounding = 10F;
            this.dtpSearchDate.TabIndex = 1;
            // 
            // UCMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UCMovies";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1056, 688);
            this.Load += new System.EventHandler(this.UCMovies_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMM)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnSearchDate)).EndInit();
            this.pnSearchDate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel lblMovieManagement;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonPanel pnSearch;
        private Krypton.Toolkit.KryptonTextBox txbSearchMovie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonPanel pnSearchDate;
        private Krypton.Toolkit.KryptonDateTimePicker dtpSearchDate;
        private Krypton.Toolkit.KryptonDataGridView dgvMM;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn MovieName;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Genre;
        private Krypton.Toolkit.KryptonDataGridViewComboBoxColumn AgeRating;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Duration;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn editBtn;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn delBtn;
    }
}
