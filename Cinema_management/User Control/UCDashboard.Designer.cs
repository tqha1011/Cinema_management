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
            this.grTTMovies = new Krypton.Toolkit.KryptonGroup();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.lbCardValue = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grScreenRooms = new Krypton.Toolkit.KryptonGroup();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grTodayShows = new Krypton.Toolkit.KryptonGroup();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.grDateTime = new Krypton.Toolkit.KryptonGroup();
            this.lblDate = new Krypton.Toolkit.KryptonLabel();
            this.lblTime = new Krypton.Toolkit.KryptonLabel();
            this.grQuickActions = new Krypton.Toolkit.KryptonGroup();
            this.kryptonLabel14 = new Krypton.Toolkit.KryptonLabel();
            this.tlpCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTTMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTTMovies.Panel)).BeginInit();
            this.grTTMovies.Panel.SuspendLayout();
            this.grTTMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grScreenRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grScreenRooms.Panel)).BeginInit();
            this.grScreenRooms.Panel.SuspendLayout();
            this.grScreenRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTodayShows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTodayShows.Panel)).BeginInit();
            this.grTodayShows.Panel.SuspendLayout();
            this.grTodayShows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDateTime.Panel)).BeginInit();
            this.grDateTime.Panel.SuspendLayout();
            this.grDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grQuickActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grQuickActions.Panel)).BeginInit();
            this.grQuickActions.Panel.SuspendLayout();
            this.grQuickActions.SuspendLayout();
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
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.Controls.Add(this.grDateTime, 3, 0);
            this.tlpCards.Controls.Add(this.grTodayShows, 2, 0);
            this.tlpCards.Controls.Add(this.grScreenRooms, 1, 0);
            this.tlpCards.Controls.Add(this.grTTMovies, 0, 0);
            this.tlpCards.Location = new System.Drawing.Point(81, 158);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.RowCount = 2;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCards.Size = new System.Drawing.Size(1160, 190);
            this.tlpCards.TabIndex = 2;
            this.tlpCards.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // grTTMovies
            // 
            this.grTTMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTMovies.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlAlternate;
            this.grTTMovies.Location = new System.Drawing.Point(10, 10);
            this.grTTMovies.Margin = new System.Windows.Forms.Padding(10);
            // 
            // grTTMovies.Panel
            // 
            this.grTTMovies.Panel.Controls.Add(this.pictureBox1);
            this.grTTMovies.Panel.Controls.Add(this.kryptonLabel4);
            this.grTTMovies.Panel.Controls.Add(this.lbCardValue);
            this.grTTMovies.Panel.Controls.Add(this.kryptonLabel3);
            this.grTTMovies.Panel.Margin = new System.Windows.Forms.Padding(3);
            this.grTTMovies.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroup1_Panel_Paint);
            this.grTTMovies.Size = new System.Drawing.Size(270, 150);
            this.grTTMovies.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.grTTMovies.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.grTTMovies.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grTTMovies.StateCommon.Border.Rounding = 10F;
            this.grTTMovies.TabIndex = 0;
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
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(15, 91);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(222, 28);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 2;
            this.kryptonLabel4.Values.Text = "Active movie in system";
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
            // grScreenRooms
            // 
            this.grScreenRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grScreenRooms.Location = new System.Drawing.Point(300, 10);
            this.grScreenRooms.Margin = new System.Windows.Forms.Padding(10);
            // 
            // grScreenRooms.Panel
            // 
            this.grScreenRooms.Panel.Controls.Add(this.pictureBox2);
            this.grScreenRooms.Panel.Controls.Add(this.kryptonLabel5);
            this.grScreenRooms.Panel.Controls.Add(this.kryptonLabel6);
            this.grScreenRooms.Panel.Controls.Add(this.kryptonLabel7);
            this.grScreenRooms.Panel.Margin = new System.Windows.Forms.Padding(3);
            this.grScreenRooms.Size = new System.Drawing.Size(270, 150);
            this.grScreenRooms.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.grScreenRooms.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.grScreenRooms.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grScreenRooms.StateCommon.Border.Rounding = 10F;
            this.grScreenRooms.TabIndex = 1;
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
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(15, 91);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(175, 28);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 2;
            this.kryptonLabel5.Values.Text = "Active employees";
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
            // grTodayShows
            // 
            this.grTodayShows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTodayShows.Location = new System.Drawing.Point(590, 10);
            this.grTodayShows.Margin = new System.Windows.Forms.Padding(10);
            // 
            // grTodayShows.Panel
            // 
            this.grTodayShows.Panel.Controls.Add(this.pictureBox3);
            this.grTodayShows.Panel.Controls.Add(this.kryptonLabel8);
            this.grTodayShows.Panel.Controls.Add(this.kryptonLabel9);
            this.grTodayShows.Panel.Controls.Add(this.kryptonLabel10);
            this.grTodayShows.Panel.Margin = new System.Windows.Forms.Padding(3);
            this.grTodayShows.Size = new System.Drawing.Size(270, 150);
            this.grTodayShows.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.grTodayShows.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.grTodayShows.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grTodayShows.StateCommon.Border.Rounding = 10F;
            this.grTodayShows.TabIndex = 2;
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
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(15, 91);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(196, 28);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 2;
            this.kryptonLabel8.Values.Text = "Scheduled for today";
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
            // grDateTime
            // 
            this.grDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDateTime.Location = new System.Drawing.Point(880, 10);
            this.grDateTime.Margin = new System.Windows.Forms.Padding(10);
            // 
            // grDateTime.Panel
            // 
            this.grDateTime.Panel.Controls.Add(this.lblTime);
            this.grDateTime.Panel.Controls.Add(this.lblDate);
            this.grDateTime.Panel.Margin = new System.Windows.Forms.Padding(3);
            this.grDateTime.Size = new System.Drawing.Size(270, 150);
            this.grDateTime.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.grDateTime.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.grDateTime.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grDateTime.StateCommon.Border.Rounding = 10F;
            this.grDateTime.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDate.Location = new System.Drawing.Point(0, 112);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(262, 30);
            this.lblDate.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.lblDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblDate.TabIndex = 2;
            this.lblDate.Values.Text = "dd/MM/yyyy";
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(262, 112);
            this.lblTime.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblTime.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTime.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTime.TabIndex = 1;
            this.lblTime.Values.Text = "00:00:00";
            // 
            // grQuickActions
            // 
            this.grQuickActions.Location = new System.Drawing.Point(81, 381);
            this.grQuickActions.Margin = new System.Windows.Forms.Padding(10, 30, 10, 10);
            // 
            // grQuickActions.Panel
            // 
            this.grQuickActions.Panel.Controls.Add(this.kryptonLabel14);
            this.grQuickActions.Panel.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.grQuickActions.Panel.Padding = new System.Windows.Forms.Padding(1, 15, 15, 15);
            this.grQuickActions.Size = new System.Drawing.Size(1150, 300);
            this.grQuickActions.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.grQuickActions.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.grQuickActions.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grQuickActions.StateCommon.Border.Rounding = 10F;
            this.grQuickActions.TabIndex = 4;
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel14.Location = new System.Drawing.Point(1, 15);
            this.kryptonLabel14.Margin = new System.Windows.Forms.Padding(0, 30, 10, 10);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(1126, 30);
            this.kryptonLabel14.StateCommon.Padding = new System.Windows.Forms.Padding(30, -1, -1, -1);
            this.kryptonLabel14.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel14.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel14.TabIndex = 3;
            this.kryptonLabel14.Values.Text = "Quick Actions";
            this.kryptonLabel14.Click += new System.EventHandler(this.kryptonLabel14_Click);
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
            this.Controls.Add(this.grQuickActions);
            this.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Name = "UCDashboard";
            this.Padding = new System.Windows.Forms.Padding(25, 25, 25, 25);
            this.Size = new System.Drawing.Size(1269, 716);
            this.tlpCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grTTMovies.Panel)).EndInit();
            this.grTTMovies.Panel.ResumeLayout(false);
            this.grTTMovies.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTTMovies)).EndInit();
            this.grTTMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grScreenRooms.Panel)).EndInit();
            this.grScreenRooms.Panel.ResumeLayout(false);
            this.grScreenRooms.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grScreenRooms)).EndInit();
            this.grScreenRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTodayShows.Panel)).EndInit();
            this.grTodayShows.Panel.ResumeLayout(false);
            this.grTodayShows.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTodayShows)).EndInit();
            this.grTodayShows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDateTime.Panel)).EndInit();
            this.grDateTime.Panel.ResumeLayout(false);
            this.grDateTime.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDateTime)).EndInit();
            this.grDateTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grQuickActions.Panel)).EndInit();
            this.grQuickActions.Panel.ResumeLayout(false);
            this.grQuickActions.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grQuickActions)).EndInit();
            this.grQuickActions.ResumeLayout(false);
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
        private Krypton.Toolkit.KryptonGroup grQuickActions;
        private Krypton.Toolkit.KryptonLabel kryptonLabel14;
    }
}