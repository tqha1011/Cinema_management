namespace Cinema_management
{
    partial class UCDashboard
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
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.tlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.grDateTime = new Krypton.Toolkit.KryptonGroup();
            this.lblTime = new Krypton.Toolkit.KryptonLabel();
            this.lblDate = new Krypton.Toolkit.KryptonLabel();
            this.grTodayShows = new Krypton.Toolkit.KryptonGroup();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.grScreenRooms = new Krypton.Toolkit.KryptonGroup();
            this.btnAddStaff = new Krypton.Toolkit.KryptonButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.grTTMovies = new Krypton.Toolkit.KryptonGroup();
            this.btnAddMovie = new Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.lbCardValue = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.tlpCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDateTime.Panel)).BeginInit();
            this.grDateTime.Panel.SuspendLayout();
            this.grDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTodayShows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTodayShows.Panel)).BeginInit();
            this.grTodayShows.Panel.SuspendLayout();
            this.grTodayShows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grScreenRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grScreenRooms.Panel)).BeginInit();
            this.grScreenRooms.Panel.SuspendLayout();
            this.grScreenRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTTMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTTMovies.Panel)).BeginInit();
            this.grTTMovies.Panel.SuspendLayout();
            this.grTTMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(81, 56);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(174, 42);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Dashboard";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(81, 105);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(470, 33);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.Gray;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Welcome to Cinema Management System";
            this.kryptonLabel2.Click += new System.EventHandler(this.kryptonLabel2_Click);
            // 
            // tlpCards
            // 
            this.tlpCards.BackColor = System.Drawing.Color.White;
            this.tlpCards.ColumnCount = 4;
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.70492F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.77049F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.44262F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.08197F));
            this.tlpCards.Controls.Add(this.grDateTime, 3, 0);
            this.tlpCards.Controls.Add(this.grTodayShows, 2, 0);
            this.tlpCards.Controls.Add(this.grScreenRooms, 1, 0);
            this.tlpCards.Controls.Add(this.grTTMovies, 0, 0);
            this.tlpCards.Location = new System.Drawing.Point(81, 158);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.RowCount = 2;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCards.Size = new System.Drawing.Size(1144, 253);
            this.tlpCards.TabIndex = 2;
            this.tlpCards.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // grDateTime
            // 
            this.grDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDateTime.Location = new System.Drawing.Point(889, 10);
            this.grDateTime.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            // 
            // grDateTime.Panel
            // 
            this.grDateTime.Panel.Controls.Add(this.lblTime);
            this.grDateTime.Panel.Controls.Add(this.lblDate);
            this.grDateTime.Panel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.grDateTime.Size = new System.Drawing.Size(245, 213);
            this.grDateTime.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.grDateTime.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.grDateTime.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grDateTime.StateCommon.Border.Rounding = 10F;
            this.grDateTime.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(237, 175);
            this.lblTime.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblTime.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTime.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTime.TabIndex = 1;
            this.lblTime.Values.Text = "00:00:00";
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDate.Location = new System.Drawing.Point(0, 175);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(237, 30);
            this.lblDate.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.lblDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblDate.TabIndex = 2;
            this.lblDate.Values.Text = "dd/MM/yyyy";
            // 
            // grTodayShows
            // 
            this.grTodayShows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTodayShows.Location = new System.Drawing.Point(598, 10);
            this.grTodayShows.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            // 
            // grTodayShows.Panel
            // 
            this.grTodayShows.Panel.Controls.Add(this.btnAdd);
            this.grTodayShows.Panel.Controls.Add(this.pictureBox3);
            this.grTodayShows.Panel.Controls.Add(this.kryptonLabel8);
            this.grTodayShows.Panel.Controls.Add(this.kryptonLabel9);
            this.grTodayShows.Panel.Controls.Add(this.kryptonLabel10);
            this.grTodayShows.Panel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.grTodayShows.Size = new System.Drawing.Size(271, 213);
            this.grTodayShows.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.grTodayShows.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.grTodayShows.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grTodayShows.StateCommon.Border.Rounding = 10F;
            this.grTodayShows.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(1, 130);
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
            this.btnAdd.Size = new System.Drawing.Size(259, 58);
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
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAdd.Values.Image = global::Cinema_management.Properties.Resources.material_symbols__add_rounded;
            this.btnAdd.Values.Text = "Add New Schedule";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Cinema_management.Properties.Resources.uil__clock;
            this.pictureBox3.Location = new System.Drawing.Point(175, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(15, 91);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(196, 28);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 2;
            this.kryptonLabel8.Values.Text = "Scheduled for today";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(15, 59);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(45, 36);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 1;
            this.kryptonLabel9.Values.Text = "12";
            this.kryptonLabel9.Click += new System.EventHandler(this.kryptonLabel9_Click);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(15, 14);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(167, 30);
            this.kryptonLabel10.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel10.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 0;
            this.kryptonLabel10.Values.Text = "Today\'s Shows";
            // 
            // grScreenRooms
            // 
            this.grScreenRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grScreenRooms.Location = new System.Drawing.Point(304, 10);
            this.grScreenRooms.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            // 
            // grScreenRooms.Panel
            // 
            this.grScreenRooms.Panel.Controls.Add(this.btnAddStaff);
            this.grScreenRooms.Panel.Controls.Add(this.pictureBox2);
            this.grScreenRooms.Panel.Controls.Add(this.kryptonLabel5);
            this.grScreenRooms.Panel.Controls.Add(this.kryptonLabel6);
            this.grScreenRooms.Panel.Controls.Add(this.kryptonLabel7);
            this.grScreenRooms.Panel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.grScreenRooms.Size = new System.Drawing.Size(274, 213);
            this.grScreenRooms.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.grScreenRooms.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.grScreenRooms.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grScreenRooms.StateCommon.Border.Rounding = 10F;
            this.grScreenRooms.TabIndex = 1;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaff.Location = new System.Drawing.Point(1, 130);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddStaff.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddStaff.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAddStaff.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddStaff.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddStaff.OverrideDefault.Border.ColorAngle = 45F;
            this.btnAddStaff.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddStaff.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddStaff.OverrideDefault.Border.Rounding = 10F;
            this.btnAddStaff.OverrideDefault.Border.Width = 1;
            this.btnAddStaff.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddStaff.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddStaff.OverrideFocus.Back.ColorAngle = 45F;
            this.btnAddStaff.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddStaff.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddStaff.OverrideFocus.Border.ColorAngle = 45F;
            this.btnAddStaff.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddStaff.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddStaff.OverrideFocus.Border.Rounding = 10F;
            this.btnAddStaff.OverrideFocus.Border.Width = 1;
            this.btnAddStaff.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddStaff.Size = new System.Drawing.Size(259, 58);
            this.btnAddStaff.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddStaff.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddStaff.StateCommon.Back.ColorAngle = 45F;
            this.btnAddStaff.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddStaff.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddStaff.StateCommon.Border.ColorAngle = 45F;
            this.btnAddStaff.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddStaff.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddStaff.StateCommon.Border.Rounding = 10F;
            this.btnAddStaff.StateCommon.Border.Width = 1;
            this.btnAddStaff.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddStaff.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnAddStaff.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnAddStaff.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddStaff.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddStaff.StateNormal.Back.ColorAngle = 45F;
            this.btnAddStaff.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddStaff.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddStaff.StateNormal.Border.ColorAngle = 45F;
            this.btnAddStaff.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddStaff.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddStaff.StateNormal.Border.Rounding = 10F;
            this.btnAddStaff.StateNormal.Border.Width = 1;
            this.btnAddStaff.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAddStaff.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAddStaff.StatePressed.Back.ColorAngle = 135F;
            this.btnAddStaff.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAddStaff.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAddStaff.StatePressed.Border.ColorAngle = 135F;
            this.btnAddStaff.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddStaff.StatePressed.Border.Rounding = 10F;
            this.btnAddStaff.StatePressed.Border.Width = 1;
            this.btnAddStaff.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddStaff.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddStaff.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddStaff.StateTracking.Back.ColorAngle = 45F;
            this.btnAddStaff.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddStaff.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddStaff.StateTracking.Border.ColorAngle = 45F;
            this.btnAddStaff.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddStaff.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddStaff.StateTracking.Border.Rounding = 10F;
            this.btnAddStaff.StateTracking.Border.Width = 1;
            this.btnAddStaff.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddStaff.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.TabIndex = 5;
            this.btnAddStaff.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAddStaff.Values.Image = global::Cinema_management.Properties.Resources.material_symbols__add_rounded;
            this.btnAddStaff.Values.Text = "Add New Staff";
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Cinema_management.Properties.Resources.radix_icons__people;
            this.pictureBox2.Location = new System.Drawing.Point(175, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(15, 91);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(175, 28);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 2;
            this.kryptonLabel5.Values.Text = "Active employees";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(15, 59);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(30, 36);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 1;
            this.kryptonLabel6.Values.Text = "4";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(15, 14);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(117, 30);
            this.kryptonLabel7.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel7.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 0;
            this.kryptonLabel7.Values.Text = "Total Staff";
            // 
            // grTTMovies
            // 
            this.grTTMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTMovies.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlAlternate;
            this.grTTMovies.Location = new System.Drawing.Point(10, 10);
            this.grTTMovies.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            // 
            // grTTMovies.Panel
            // 
            this.grTTMovies.Panel.Controls.Add(this.btnAddMovie);
            this.grTTMovies.Panel.Controls.Add(this.pictureBox1);
            this.grTTMovies.Panel.Controls.Add(this.kryptonLabel4);
            this.grTTMovies.Panel.Controls.Add(this.lbCardValue);
            this.grTTMovies.Panel.Controls.Add(this.kryptonLabel3);
            this.grTTMovies.Panel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.grTTMovies.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroup1_Panel_Paint);
            this.grTTMovies.Size = new System.Drawing.Size(274, 213);
            this.grTTMovies.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.grTTMovies.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.grTTMovies.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grTTMovies.StateCommon.Border.Rounding = 10F;
            this.grTTMovies.TabIndex = 0;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMovie.Location = new System.Drawing.Point(4, 130);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddMovie.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddMovie.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAddMovie.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddMovie.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddMovie.OverrideDefault.Border.ColorAngle = 45F;
            this.btnAddMovie.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddMovie.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddMovie.OverrideDefault.Border.Rounding = 10F;
            this.btnAddMovie.OverrideDefault.Border.Width = 1;
            this.btnAddMovie.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddMovie.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddMovie.OverrideFocus.Back.ColorAngle = 45F;
            this.btnAddMovie.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddMovie.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddMovie.OverrideFocus.Border.ColorAngle = 45F;
            this.btnAddMovie.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddMovie.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddMovie.OverrideFocus.Border.Rounding = 10F;
            this.btnAddMovie.OverrideFocus.Border.Width = 1;
            this.btnAddMovie.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddMovie.Size = new System.Drawing.Size(259, 58);
            this.btnAddMovie.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddMovie.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddMovie.StateCommon.Back.ColorAngle = 45F;
            this.btnAddMovie.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddMovie.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddMovie.StateCommon.Border.ColorAngle = 45F;
            this.btnAddMovie.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddMovie.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddMovie.StateCommon.Border.Rounding = 10F;
            this.btnAddMovie.StateCommon.Border.Width = 1;
            this.btnAddMovie.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddMovie.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnAddMovie.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnAddMovie.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddMovie.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddMovie.StateNormal.Back.ColorAngle = 45F;
            this.btnAddMovie.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddMovie.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddMovie.StateNormal.Border.ColorAngle = 45F;
            this.btnAddMovie.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddMovie.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddMovie.StateNormal.Border.Rounding = 10F;
            this.btnAddMovie.StateNormal.Border.Width = 1;
            this.btnAddMovie.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAddMovie.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAddMovie.StatePressed.Back.ColorAngle = 135F;
            this.btnAddMovie.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnAddMovie.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnAddMovie.StatePressed.Border.ColorAngle = 135F;
            this.btnAddMovie.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddMovie.StatePressed.Border.Rounding = 10F;
            this.btnAddMovie.StatePressed.Border.Width = 1;
            this.btnAddMovie.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddMovie.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddMovie.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddMovie.StateTracking.Back.ColorAngle = 45F;
            this.btnAddMovie.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddMovie.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddMovie.StateTracking.Border.ColorAngle = 45F;
            this.btnAddMovie.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddMovie.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddMovie.StateTracking.Border.Rounding = 10F;
            this.btnAddMovie.StateTracking.Border.Width = 1;
            this.btnAddMovie.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddMovie.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.TabIndex = 4;
            this.btnAddMovie.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAddMovie.Values.Image = global::Cinema_management.Properties.Resources.material_symbols__add_rounded;
            this.btnAddMovie.Values.Text = "Add New Movie";
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Cinema_management.Properties.Resources.jam__movie;
            this.pictureBox1.Location = new System.Drawing.Point(175, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(15, 91);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(222, 28);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 2;
            this.kryptonLabel4.Values.Text = "Active movie in system";
            // 
            // lbCardValue
            // 
            this.lbCardValue.Location = new System.Drawing.Point(15, 59);
            this.lbCardValue.Name = "lbCardValue";
            this.lbCardValue.Size = new System.Drawing.Size(30, 36);
            this.lbCardValue.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lbCardValue.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardValue.TabIndex = 1;
            this.lbCardValue.Values.Text = "4";
            this.lbCardValue.Click += new System.EventHandler(this.lbCardValue_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(15, 14);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(142, 30);
            this.kryptonLabel3.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 0;
            this.kryptonLabel3.Values.Text = "Total Movies";
            // 
            // UCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.tlpCards);
            this.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Name = "UCDashboard";
            this.Padding = new System.Windows.Forms.Padding(25, 25, 25, 25);
            this.Size = new System.Drawing.Size(1269, 716);
            this.tlpCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDateTime.Panel)).EndInit();
            this.grDateTime.Panel.ResumeLayout(false);
            this.grDateTime.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDateTime)).EndInit();
            this.grDateTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grTodayShows.Panel)).EndInit();
            this.grTodayShows.Panel.ResumeLayout(false);
            this.grTodayShows.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTodayShows)).EndInit();
            this.grTodayShows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grScreenRooms.Panel)).EndInit();
            this.grScreenRooms.Panel.ResumeLayout(false);
            this.grScreenRooms.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grScreenRooms)).EndInit();
            this.grScreenRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTTMovies.Panel)).EndInit();
            this.grTTMovies.Panel.ResumeLayout(false);
            this.grTTMovies.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTTMovies)).EndInit();
            this.grTTMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // --- KHAI BÁO TIMER ---
        private System.Windows.Forms.Timer timerClock;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private Krypton.Toolkit.KryptonGroup grDateTime;
        private Krypton.Toolkit.KryptonLabel lblTime;
        private Krypton.Toolkit.KryptonLabel lblDate;
        private Krypton.Toolkit.KryptonGroup grTodayShows;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonGroup grScreenRooms;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonGroup grTTMovies;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel lbCardValue;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton btnAddMovie;
        private Krypton.Toolkit.KryptonButton btnAddStaff;
        private Krypton.Toolkit.KryptonButton btnAdd;
    }
}