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
            this.components = new System.ComponentModel.Container();
            this.lblMovieManagement = new Krypton.Toolkit.KryptonLabel();
            this.txtSearchMovie = new Krypton.Toolkit.KryptonTextBox();
            this.dtpSearchDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.dgvMM = new Krypton.Toolkit.KryptonDataGridView();
            this.MAPHIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Genre = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.AgeRating = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Duration = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NPH = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.panelMM = new Krypton.Toolkit.KryptonPanel();
            this.ckbShowDeleted = new Krypton.Toolkit.KryptonCheckBox();
            this.btnXoa = new Krypton.Toolkit.KryptonButton();
            this.btnSua = new Krypton.Toolkit.KryptonButton();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneldgv = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMM)).BeginInit();
            this.panelMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paneldgv)).BeginInit();
            this.paneldgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMovieManagement
            // 
            this.lblMovieManagement.Location = new System.Drawing.Point(81, 56);
            this.lblMovieManagement.Name = "lblMovieManagement";
            this.lblMovieManagement.Size = new System.Drawing.Size(357, 56);
            this.lblMovieManagement.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.lblMovieManagement.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieManagement.TabIndex = 1;
            this.lblMovieManagement.Values.Text = "Movie Management";
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
            this.txtSearchMovie.TextChanged += new System.EventHandler(this.txtSearchMovie_TextChanged);
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpSearchDate.CalendarTodayDate = new System.DateTime(2025, 10, 28, 0, 0, 0, 0);
            this.dtpSearchDate.CustomFormat = "dd/MM/yyyy";
            this.dtpSearchDate.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchDate.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.dtpSearchDate.Location = new System.Drawing.Point(486, 146);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dtpSearchDate.ShowCheckBox = true;
            this.dtpSearchDate.Size = new System.Drawing.Size(236, 45);
            this.dtpSearchDate.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.dtpSearchDate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.dtpSearchDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dtpSearchDate.StateCommon.Border.Width = 3;
            this.dtpSearchDate.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dtpSearchDate.StateCommon.Content.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearchDate.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dtpSearchDate.TabIndex = 6;
            this.dtpSearchDate.ValueChanged += new System.EventHandler(this.dtpSearchDate_ValueChanged);
            // 
            // kryptonCustomPaletteBase1
            // 
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.kryptonCustomPaletteBase1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // dgvMM
            // 
            this.dgvMM.AllowUserToResizeRows = false;
            this.dgvMM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMM.ColumnHeadersHeight = 70;
            this.dgvMM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHIM,
            this.MovieName,
            this.Genre,
            this.AgeRating,
            this.Duration,
            this.TRANGTHAI,
            this.NPH});
            this.dgvMM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMM.Location = new System.Drawing.Point(50, 30);
            this.dgvMM.Name = "dgvMM";
            this.dgvMM.ReadOnly = true;
            this.dgvMM.RowHeadersVisible = false;
            this.dgvMM.RowHeadersWidth = 70;
            this.dgvMM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMM.RowTemplate.DividerHeight = 20;
            this.dgvMM.RowTemplate.Height = 80;
            this.dgvMM.RowTemplate.ReadOnly = true;
            this.dgvMM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMM.Size = new System.Drawing.Size(1310, 327);
            this.dgvMM.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvMM.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvMM.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvMM.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dgvMM.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.Transparent;
            this.dgvMM.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)));
            this.dgvMM.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvMM.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMM.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvMM.StateCommon.DataCell.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvMM.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.dgvMM.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dgvMM.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.dgvMM.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.dgvMM.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dgvMM.StateCommon.HeaderColumn.Border.Width = 4;
            this.dgvMM.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.dgvMM.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMM.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvMM.StateNormal.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvMM.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(70)))));
            this.dgvMM.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.dgvMM.TabIndex = 7;
            this.dgvMM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMM_CellContentClick);
            // 
            // MAPHIM
            // 
            this.MAPHIM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MAPHIM.DataPropertyName = "MAPHIM";
            this.MAPHIM.HeaderText = "ID";
            this.MAPHIM.MinimumWidth = 8;
            this.MAPHIM.Name = "MAPHIM";
            this.MAPHIM.ReadOnly = true;
            this.MAPHIM.Width = 90;
            // 
            // MovieName
            // 
            this.MovieName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MovieName.DataPropertyName = "TENPHIM";
            this.MovieName.HeaderText = "Movie Name";
            this.MovieName.MinimumWidth = 8;
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            this.MovieName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MovieName.Width = 330;
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
            this.Genre.Width = 135;
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
            this.AgeRating.Width = 203;
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
            this.Duration.Width = 246;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "Is Active";
            this.TRANGTHAI.MinimumWidth = 8;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.ReadOnly = true;
            this.TRANGTHAI.Visible = false;
            this.TRANGTHAI.Width = 80;
            // 
            // NPH
            // 
            this.NPH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NPH.DataPropertyName = "NGAYPHATHANH";
            this.NPH.DefaultCellStyle.Format = "dd/MM/yyyy";
            this.NPH.HeaderText = "Release Day";
            this.NPH.MinimumWidth = 8;
            this.NPH.Name = "NPH";
            this.NPH.ReadOnly = true;
            this.NPH.Width = 218;
            // 
            // panelMM
            // 
            this.panelMM.Controls.Add(this.ckbShowDeleted);
            this.panelMM.Controls.Add(this.btnXoa);
            this.panelMM.Controls.Add(this.btnSua);
            this.panelMM.Controls.Add(this.btnAdd);
            this.panelMM.Controls.Add(this.lblMovieManagement);
            this.panelMM.Controls.Add(this.txtSearchMovie);
            this.panelMM.Controls.Add(this.pictureBox1);
            this.panelMM.Controls.Add(this.dtpSearchDate);
            this.panelMM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMM.Location = new System.Drawing.Point(25, 25);
            this.panelMM.Name = "panelMM";
            this.panelMM.Padding = new System.Windows.Forms.Padding(20);
            this.panelMM.Size = new System.Drawing.Size(1360, 203);
            this.panelMM.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelMM.TabIndex = 8;
            // 
            // ckbShowDeleted
            // 
            this.ckbShowDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbShowDeleted.Images.CheckedNormal = global::Cinema_management.Properties.Resources.ri__toggle_fill;
            this.ckbShowDeleted.Images.CheckedPressed = global::Cinema_management.Properties.Resources.ri__toggle_fill;
            this.ckbShowDeleted.Images.CheckedTracking = global::Cinema_management.Properties.Resources.ri__toggle_fill;
            this.ckbShowDeleted.Images.UncheckedNormal = global::Cinema_management.Properties.Resources.ri__toggle_line__1_;
            this.ckbShowDeleted.Images.UncheckedPressed = global::Cinema_management.Properties.Resources.ri__toggle_line__1_;
            this.ckbShowDeleted.Images.UncheckedTracking = global::Cinema_management.Properties.Resources.ri__toggle_line__1_;
            this.ckbShowDeleted.Location = new System.Drawing.Point(1041, 142);
            this.ckbShowDeleted.Name = "ckbShowDeleted";
            this.ckbShowDeleted.Size = new System.Drawing.Size(283, 44);
            this.ckbShowDeleted.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ckbShowDeleted.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowDeleted.TabIndex = 8;
            this.ckbShowDeleted.Values.Text = "Phim ngừng chiếu";
            this.ckbShowDeleted.CheckedChanged += new System.EventHandler(this.ckbShowDeleted_CheckedChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(1150, 54);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnXoa.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnXoa.OverrideDefault.Back.ColorAngle = 60F;
            this.btnXoa.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnXoa.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnXoa.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnXoa.OverrideDefault.Border.ColorAngle = 60F;
            this.btnXoa.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXoa.OverrideDefault.Border.Rounding = 20F;
            this.btnXoa.OverrideDefault.Border.Width = 1;
            this.btnXoa.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnXoa.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnXoa.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnXoa.OverrideFocus.Back.ColorAngle = 45F;
            this.btnXoa.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnXoa.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnXoa.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnXoa.OverrideFocus.Border.ColorAngle = 45F;
            this.btnXoa.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXoa.OverrideFocus.Border.Rounding = 20F;
            this.btnXoa.OverrideFocus.Border.Width = 1;
            this.btnXoa.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnXoa.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnXoa.Size = new System.Drawing.Size(190, 58);
            this.btnXoa.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnXoa.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnXoa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnXoa.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnXoa.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnXoa.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnXoa.StateNormal.Back.ColorAngle = 60F;
            this.btnXoa.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnXoa.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnXoa.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnXoa.StateNormal.Border.ColorAngle = 60F;
            this.btnXoa.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnXoa.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXoa.StateNormal.Border.Rounding = 20F;
            this.btnXoa.StateNormal.Border.Width = 4;
            this.btnXoa.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(97)))), ((int)(((byte)(44)))));
            this.btnXoa.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btnXoa.StatePressed.Back.ColorAngle = 135F;
            this.btnXoa.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnXoa.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(97)))), ((int)(((byte)(44)))));
            this.btnXoa.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btnXoa.StatePressed.Border.ColorAngle = 135F;
            this.btnXoa.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StatePressed.Border.Rounding = 20F;
            this.btnXoa.StatePressed.Border.Width = 1;
            this.btnXoa.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnXoa.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnXoa.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnXoa.StateTracking.Back.ColorAngle = 45F;
            this.btnXoa.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnXoa.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnXoa.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnXoa.StateTracking.Border.ColorAngle = 45F;
            this.btnXoa.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXoa.StateTracking.Border.Rounding = 20F;
            this.btnXoa.StateTracking.Border.Width = 1;
            this.btnXoa.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnXoa.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Nunito", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnXoa.Values.Image = global::Cinema_management.Properties.Resources.mi__delete;
            this.btnXoa.Values.ImageStates.ImageCheckedNormal = null;
            this.btnXoa.Values.ImageStates.ImageCheckedPressed = null;
            this.btnXoa.Values.ImageStates.ImageCheckedTracking = null;
            this.btnXoa.Values.ImageStates.ImagePressed = global::Cinema_management.Properties.Resources.mi__delete__1_;
            this.btnXoa.Values.ImageStates.ImageTracking = global::Cinema_management.Properties.Resources.mi__delete__1_;
            this.btnXoa.Values.Text = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Location = new System.Drawing.Point(949, 54);
            this.btnSua.Name = "btnSua";
            this.btnSua.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnSua.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnSua.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnSua.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSua.OverrideDefault.Border.ColorAngle = 60F;
            this.btnSua.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSua.OverrideDefault.Border.Rounding = 20F;
            this.btnSua.OverrideDefault.Border.Width = 4;
            this.btnSua.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSua.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSua.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnSua.OverrideFocus.Back.ColorAngle = 45F;
            this.btnSua.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSua.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnSua.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSua.OverrideFocus.Border.ColorAngle = 45F;
            this.btnSua.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSua.OverrideFocus.Border.Rounding = 20F;
            this.btnSua.OverrideFocus.Border.Width = 1;
            this.btnSua.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSua.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSua.Size = new System.Drawing.Size(190, 58);
            this.btnSua.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSua.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.btnSua.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSua.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnSua.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnSua.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnSua.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnSua.StateNormal.Back.ColorAngle = 60F;
            this.btnSua.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSua.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnSua.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSua.StateNormal.Border.ColorAngle = 60F;
            this.btnSua.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSua.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSua.StateNormal.Border.Rounding = 20F;
            this.btnSua.StateNormal.Border.Width = 4;
            this.btnSua.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(97)))), ((int)(((byte)(44)))));
            this.btnSua.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btnSua.StatePressed.Back.ColorAngle = 135F;
            this.btnSua.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSua.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(97)))), ((int)(((byte)(44)))));
            this.btnSua.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btnSua.StatePressed.Border.ColorAngle = 135F;
            this.btnSua.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StatePressed.Border.Rounding = 20F;
            this.btnSua.StatePressed.Border.Width = 1;
            this.btnSua.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSua.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSua.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnSua.StateTracking.Back.ColorAngle = 45F;
            this.btnSua.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSua.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnSua.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSua.StateTracking.Border.ColorAngle = 45F;
            this.btnSua.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSua.StateTracking.Border.Rounding = 20F;
            this.btnSua.StateTracking.Border.Width = 1;
            this.btnSua.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSua.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Nunito", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.TabIndex = 7;
            this.btnSua.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSua.Values.Image = global::Cinema_management.Properties.Resources.akar_icons__edit__2_;
            this.btnSua.Values.ImageStates.ImageCheckedNormal = null;
            this.btnSua.Values.ImageStates.ImageCheckedPressed = null;
            this.btnSua.Values.ImageStates.ImageCheckedTracking = null;
            this.btnSua.Values.ImageStates.ImagePressed = global::Cinema_management.Properties.Resources.akar_icons__edit__1_;
            this.btnSua.Values.ImageStates.ImageTracking = global::Cinema_management.Properties.Resources.akar_icons__edit__1_;
            this.btnSua.Values.Text = "Update";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(678, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnAdd.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnAdd.OverrideDefault.Back.ColorAngle = 60F;
            this.btnAdd.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnAdd.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnAdd.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnAdd.OverrideDefault.Border.ColorAngle = 60F;
            this.btnAdd.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.OverrideDefault.Border.Rounding = 20F;
            this.btnAdd.OverrideDefault.Border.Width = 1;
            this.btnAdd.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnAdd.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnAdd.OverrideFocus.Back.ColorAngle = 45F;
            this.btnAdd.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnAdd.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnAdd.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnAdd.OverrideFocus.Border.ColorAngle = 45F;
            this.btnAdd.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.OverrideFocus.Border.Rounding = 20F;
            this.btnAdd.OverrideFocus.Border.Width = 1;
            this.btnAdd.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAdd.Size = new System.Drawing.Size(260, 58);
            this.btnAdd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnAdd.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnAdd.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnAdd.StateNormal.Back.ColorAngle = 60F;
            this.btnAdd.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnAdd.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnAdd.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnAdd.StateNormal.Border.ColorAngle = 60F;
            this.btnAdd.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.StateNormal.Border.Rounding = 20F;
            this.btnAdd.StateNormal.Border.Width = 1;
            this.btnAdd.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(97)))), ((int)(((byte)(44)))));
            this.btnAdd.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btnAdd.StatePressed.Back.ColorAngle = 135F;
            this.btnAdd.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnAdd.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(97)))), ((int)(((byte)(44)))));
            this.btnAdd.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btnAdd.StatePressed.Border.ColorAngle = 135F;
            this.btnAdd.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StatePressed.Border.Rounding = 20F;
            this.btnAdd.StatePressed.Border.Width = 1;
            this.btnAdd.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnAdd.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnAdd.StateTracking.Back.ColorAngle = 45F;
            this.btnAdd.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnAdd.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnAdd.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnAdd.StateTracking.Border.ColorAngle = 45F;
            this.btnAdd.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.StateTracking.Border.Rounding = 20F;
            this.btnAdd.StateTracking.Border.Width = 1;
            this.btnAdd.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Nunito", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAdd.Values.Image = global::Cinema_management.Properties.Resources.material_symbols__add_rounded;
            this.btnAdd.Values.Text = "Add New Movie";
            this.btnAdd.Click += new System.EventHandler(this.btnAddMovie_Click);
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
            // paneldgv
            // 
            this.paneldgv.Controls.Add(this.dgvMM);
            this.paneldgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldgv.Location = new System.Drawing.Point(25, 228);
            this.paneldgv.Name = "paneldgv";
            this.paneldgv.Padding = new System.Windows.Forms.Padding(50, 30, 0, 0);
            this.paneldgv.Size = new System.Drawing.Size(1360, 357);
            this.paneldgv.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.paneldgv.TabIndex = 9;
            // 
            // UCMovies1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.paneldgv);
            this.Controls.Add(this.panelMM);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UCMovies1";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Size = new System.Drawing.Size(1410, 610);
            this.Load += new System.EventHandler(this.UCMovies1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMM)).EndInit();
            this.panelMM.ResumeLayout(false);
            this.panelMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paneldgv)).EndInit();
            this.paneldgv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblMovieManagement;
        private Krypton.Toolkit.KryptonTextBox txtSearchMovie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonDateTimePicker dtpSearchDate;
        private Krypton.Toolkit.KryptonDataGridView dgvMM;
        private Krypton.Toolkit.KryptonPanel panelMM;
        private Krypton.Toolkit.KryptonPanel paneldgv;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private Krypton.Toolkit.KryptonCheckBox ckbShowDeleted;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonButton btnSua;
        private Krypton.Toolkit.KryptonButton btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIM;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn MovieName;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Genre;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn AgeRating;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TRANGTHAI;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn NPH;
    }
}
