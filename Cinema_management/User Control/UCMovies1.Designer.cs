namespace Cinema_management
{
    partial class UCMovies1
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
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtSearchMovie = new Krypton.Toolkit.KryptonTextBox();
            this.dtpSearchDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dgvMM = new Krypton.Toolkit.KryptonDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMM = new Krypton.Toolkit.KryptonPanel();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            this.paneldgv = new Krypton.Toolkit.KryptonPanel();
            this.ckbShowDeleted = new Krypton.Toolkit.KryptonCheckBox();
            this.MAPHIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Genre = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.AgeRating = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Duration = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEdit = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.btnDelete = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMM)).BeginInit();
            this.panelMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paneldgv)).BeginInit();
            this.paneldgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMovieManagement
            // 
            this.lblMovieManagement.Location = new System.Drawing.Point(68, 54);
            this.lblMovieManagement.Name = "lblMovieManagement";
            this.lblMovieManagement.Size = new System.Drawing.Size(308, 42);
            this.lblMovieManagement.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblMovieManagement.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieManagement.TabIndex = 1;
            this.lblMovieManagement.Values.Text = "Movie Management";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonLabel2.Location = new System.Drawing.Point(68, 102);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(454, 35);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Manage your cinema\'s movie collection";
            // 
            // txtSearchMovie
            // 
            this.txtSearchMovie.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtSearchMovie.CueHint.CueHintText = "Search movie...";
            this.txtSearchMovie.CueHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMovie.Location = new System.Drawing.Point(86, 154);
            this.txtSearchMovie.Multiline = true;
            this.txtSearchMovie.Name = "txtSearchMovie";
            this.txtSearchMovie.Size = new System.Drawing.Size(313, 43);
            this.txtSearchMovie.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txtSearchMovie.StateCommon.Border.Rounding = 10F;
            this.txtSearchMovie.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMovie.TabIndex = 4;
            this.txtSearchMovie.TextChanged += new System.EventHandler(this.txtSearchMovie_TextChanged);
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpSearchDate.CalendarTodayDate = new System.DateTime(2025, 10, 28, 0, 0, 0, 0);
            this.dtpSearchDate.CustomFormat = "dd/MM/yyyy";
            this.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchDate.Location = new System.Drawing.Point(452, 155);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.ShowCheckBox = true;
            this.dtpSearchDate.Size = new System.Drawing.Size(191, 36);
            this.dtpSearchDate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.dtpSearchDate.StateCommon.Border.Rounding = 10F;
            this.dtpSearchDate.TabIndex = 6;
            this.dtpSearchDate.ValueChanged += new System.EventHandler(this.dtpSearchDate_ValueChanged);
            // 
            // dgvMM
            // 
            this.dgvMM.AllowUserToResizeRows = false;
            this.dgvMM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHIM,
            this.MovieName,
            this.Genre,
            this.AgeRating,
            this.Duration,
            this.TRANGTHAI,
            this.btnEdit,
            this.btnDelete});
            this.dgvMM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMM.Location = new System.Drawing.Point(50, 30);
            this.dgvMM.Name = "dgvMM";
            this.dgvMM.ReadOnly = true;
            this.dgvMM.RowHeadersVisible = false;
            this.dgvMM.RowHeadersWidth = 70;
            this.dgvMM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMM.RowTemplate.Height = 40;
            this.dgvMM.RowTemplate.ReadOnly = true;
            this.dgvMM.Size = new System.Drawing.Size(850, 377);
            this.dgvMM.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvMM.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvMM.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvMM.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvMM.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMM.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(80)))), ((int)(((byte)(253)))));
            this.dgvMM.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(80)))), ((int)(((byte)(253)))));
            this.dgvMM.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgvMM.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMM.TabIndex = 7;
            this.dgvMM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMM_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema_management.Properties.Resources.lucide__search;
            this.pictureBox1.Location = new System.Drawing.Point(50, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panelMM
            // 
            this.panelMM.Controls.Add(this.ckbShowDeleted);
            this.panelMM.Controls.Add(this.btnAdd);
            this.panelMM.Controls.Add(this.lblMovieManagement);
            this.panelMM.Controls.Add(this.kryptonLabel2);
            this.panelMM.Controls.Add(this.txtSearchMovie);
            this.panelMM.Controls.Add(this.pictureBox1);
            this.panelMM.Controls.Add(this.dtpSearchDate);
            this.panelMM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMM.Location = new System.Drawing.Point(0, 0);
            this.panelMM.Name = "panelMM";
            this.panelMM.Padding = new System.Windows.Forms.Padding(20);
            this.panelMM.Size = new System.Drawing.Size(900, 203);
            this.panelMM.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelMM.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(621, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAdd.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAdd.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAdd.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAdd.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAdd.OverrideDefault.Border.ColorAngle = 45F;
            this.btnAdd.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.OverrideDefault.Border.Rounding = 10F;
            this.btnAdd.OverrideDefault.Border.Width = 1;
            this.btnAdd.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAdd.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAdd.OverrideFocus.Back.ColorAngle = 45F;
            this.btnAdd.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAdd.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAdd.OverrideFocus.Border.ColorAngle = 45F;
            this.btnAdd.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.OverrideFocus.Border.Rounding = 10F;
            this.btnAdd.OverrideFocus.Border.Width = 1;
            this.btnAdd.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAdd.Size = new System.Drawing.Size(243, 54);
            this.btnAdd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAdd.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAdd.StateCommon.Back.ColorAngle = 45F;
            this.btnAdd.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAdd.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAdd.StateCommon.Border.ColorAngle = 45F;
            this.btnAdd.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.StateCommon.Border.Rounding = 10F;
            this.btnAdd.StateCommon.Border.Width = 1;
            this.btnAdd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnAdd.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAdd.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAdd.StateNormal.Back.ColorAngle = 45F;
            this.btnAdd.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAdd.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAdd.StateNormal.Border.ColorAngle = 45F;
            this.btnAdd.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.StateNormal.Border.Rounding = 10F;
            this.btnAdd.StateNormal.Border.Width = 1;
            this.btnAdd.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAdd.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAdd.StatePressed.Back.ColorAngle = 135F;
            this.btnAdd.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAdd.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAdd.StatePressed.Border.ColorAngle = 135F;
            this.btnAdd.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StatePressed.Border.Rounding = 10F;
            this.btnAdd.StatePressed.Border.Width = 1;
            this.btnAdd.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAdd.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAdd.StateTracking.Back.ColorAngle = 45F;
            this.btnAdd.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAdd.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAdd.StateTracking.Border.ColorAngle = 45F;
            this.btnAdd.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.StateTracking.Border.Rounding = 10F;
            this.btnAdd.StateTracking.Border.Width = 1;
            this.btnAdd.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAdd.Values.Image = global::Cinema_management.Properties.Resources.material_symbols__add_rounded;
            this.btnAdd.Values.Text = "Add New Movie";
            this.btnAdd.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // paneldgv
            // 
            this.paneldgv.Controls.Add(this.dgvMM);
            this.paneldgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldgv.Location = new System.Drawing.Point(0, 203);
            this.paneldgv.Name = "paneldgv";
            this.paneldgv.Padding = new System.Windows.Forms.Padding(50, 30, 0, 0);
            this.paneldgv.Size = new System.Drawing.Size(900, 407);
            this.paneldgv.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.paneldgv.TabIndex = 9;
            // 
            // ckbShowDeleted
            // 
            this.ckbShowDeleted.Location = new System.Drawing.Point(700, 158);
            this.ckbShowDeleted.Name = "ckbShowDeleted";
            this.ckbShowDeleted.Size = new System.Drawing.Size(231, 33);
            this.ckbShowDeleted.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.ckbShowDeleted.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowDeleted.TabIndex = 8;
            this.ckbShowDeleted.Values.Text = "Phim ngừng chiếu";
            this.ckbShowDeleted.CheckedChanged += new System.EventHandler(this.ckbShowDeleted_CheckedChanged);
            // 
            // MAPHIM
            // 
            this.MAPHIM.DataPropertyName = "MAPHIM";
            this.MAPHIM.HeaderText = "MaPhim";
            this.MAPHIM.MinimumWidth = 8;
            this.MAPHIM.Name = "MAPHIM";
            this.MAPHIM.ReadOnly = true;
            this.MAPHIM.Width = 146;
            // 
            // MovieName
            // 
            this.MovieName.DataPropertyName = "TENPHIM";
            this.MovieName.HeaderText = "Movie Name";
            this.MovieName.MinimumWidth = 8;
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            this.MovieName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MovieName.Width = 197;
            // 
            // Genre
            // 
            this.Genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Genre.DataPropertyName = "THELOAIPHIM";
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 8;
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Genre.Width = 119;
            // 
            // AgeRating
            // 
            this.AgeRating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AgeRating.DataPropertyName = "GIOIHANTUOI";
            this.AgeRating.HeaderText = "Age Rating";
            this.AgeRating.MinimumWidth = 8;
            this.AgeRating.Name = "AgeRating";
            this.AgeRating.ReadOnly = true;
            this.AgeRating.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AgeRating.Width = 178;
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Duration.DataPropertyName = "THOILUONGPHIM";
            this.Duration.HeaderText = "Duration (min)";
            this.Duration.MinimumWidth = 8;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Duration.Width = 218;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "Is Active";
            this.TRANGTHAI.MinimumWidth = 8;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.ReadOnly = true;
            this.TRANGTHAI.Width = 118;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Edit";
            this.btnEdit.MinimumWidth = 8;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseColumnTextForButtonValue = true;
            this.btnEdit.Width = 150;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.MinimumWidth = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 150;
            // 
            // UCMovies1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.paneldgv);
            this.Controls.Add(this.panelMM);
            this.Name = "UCMovies1";
            this.Size = new System.Drawing.Size(900, 610);
            this.Load += new System.EventHandler(this.UCMovies1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMM)).EndInit();
            this.panelMM.ResumeLayout(false);
            this.panelMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paneldgv)).EndInit();
            this.paneldgv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblMovieManagement;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtSearchMovie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonDateTimePicker dtpSearchDate;
        private Krypton.Toolkit.KryptonDataGridView dgvMM;
        private Krypton.Toolkit.KryptonPanel panelMM;
        private Krypton.Toolkit.KryptonPanel paneldgv;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private Krypton.Toolkit.KryptonCheckBox ckbShowDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIM;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn MovieName;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Genre;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn AgeRating;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TRANGTHAI;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn btnEdit;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn btnDelete;
    }
}
