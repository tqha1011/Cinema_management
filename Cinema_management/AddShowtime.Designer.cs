namespace Cinema_management
{
    partial class AddShowtime
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
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.pnAdd = new Krypton.Toolkit.KryptonPanel();
            this.lblMovieName = new Krypton.Toolkit.KryptonLabel();
            this.kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblRlDate = new Krypton.Toolkit.KryptonLabel();
            this.kryptonDateTimePicker2 = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.cbbGenre = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.cbbMovieName = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonDateTimePicker3 = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblEndDate = new Krypton.Toolkit.KryptonLabel();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnAdd)).BeginInit();
            this.pnAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMovieName)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(47, 34);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(275, 56);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Add Showtime";
            // 
            // pnAdd
            // 
            this.pnAdd.Controls.Add(this.kryptonLabel1);
            this.pnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAdd.Location = new System.Drawing.Point(0, 0);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(895, 105);
            this.pnAdd.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnAdd.TabIndex = 1;
            // 
            // lblMovieName
            // 
            this.lblMovieName.Location = new System.Drawing.Point(47, 134);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(157, 38);
            this.lblMovieName.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblMovieName.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.TabIndex = 4;
            this.lblMovieName.Values.Text = "Movie Name";
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.kryptonDateTimePicker1.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            this.kryptonDateTimePicker1.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(503, 170);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(351, 39);
            this.kryptonDateTimePicker1.StateCommon.Border.Rounding = 5F;
            this.kryptonDateTimePicker1.TabIndex = 7;
            // 
            // lblRlDate
            // 
            this.lblRlDate.Location = new System.Drawing.Point(489, 134);
            this.lblRlDate.Name = "lblRlDate";
            this.lblRlDate.Size = new System.Drawing.Size(134, 38);
            this.lblRlDate.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblRlDate.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRlDate.TabIndex = 6;
            this.lblRlDate.Values.Text = "Start Date";
            // 
            // kryptonDateTimePicker2
            // 
            this.kryptonDateTimePicker2.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.kryptonDateTimePicker2.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            this.kryptonDateTimePicker2.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.kryptonDateTimePicker2.Location = new System.Drawing.Point(360, 275);
            this.kryptonDateTimePicker2.Name = "kryptonDateTimePicker2";
            this.kryptonDateTimePicker2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDateTimePicker2.Size = new System.Drawing.Size(198, 39);
            this.kryptonDateTimePicker2.StateCommon.Border.Rounding = 5F;
            this.kryptonDateTimePicker2.TabIndex = 9;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(350, 239);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(131, 38);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Showtime";
            this.kryptonLabel2.Click += new System.EventHandler(this.kryptonLabel2_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(47, 239);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(82, 38);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 8;
            this.kryptonLabel3.Values.Text = "Room";
            this.kryptonLabel3.Click += new System.EventHandler(this.kryptonLabel2_Click);
            // 
            // cbbGenre
            // 
            this.cbbGenre.CueHint.Color1 = System.Drawing.Color.Black;
            this.cbbGenre.CueHint.CueHintText = "Select genre";
            this.cbbGenre.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGenre.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.cbbGenre.DropDownWidth = 156;
            this.cbbGenre.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbbGenre.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.cbbGenre.Location = new System.Drawing.Point(56, 280);
            this.cbbGenre.Name = "cbbGenre";
            this.cbbGenre.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.cbbGenre.Size = new System.Drawing.Size(240, 34);
            this.cbbGenre.StateCommon.ComboBox.Border.Rounding = 5F;
            this.cbbGenre.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbbGenre.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cbbGenre.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cbbGenre.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.cbbGenre.StateCommon.Item.Border.Rounding = 5F;
            this.cbbGenre.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbbGenre.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGenre.TabIndex = 10;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.kryptonTextBox1.CueHint.CueHintText = "0 đ";
            this.kryptonTextBox1.CueHint.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.Enabled = false;
            this.kryptonTextBox1.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.kryptonTextBox1.Location = new System.Drawing.Point(47, 359);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonTextBox1.Size = new System.Drawing.Size(270, 57);
            this.kryptonTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonTextBox1.TabIndex = 12;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(47, 323);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(148, 38);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 11;
            this.kryptonLabel4.Values.Text = "Ticket Price";
            // 
            // cbbMovieName
            // 
            this.cbbMovieName.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.cbbMovieName.DropDownWidth = 382;
            this.cbbMovieName.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbbMovieName.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.cbbMovieName.Location = new System.Drawing.Point(56, 170);
            this.cbbMovieName.Name = "cbbMovieName";
            this.cbbMovieName.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.cbbMovieName.Size = new System.Drawing.Size(382, 34);
            this.cbbMovieName.StateCommon.ComboBox.Border.Rounding = 5F;
            this.cbbMovieName.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbbMovieName.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.cbbMovieName.StateCommon.Item.Back.Color2 = System.Drawing.Color.White;
            this.cbbMovieName.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbbMovieName.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Nunito", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMovieName.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.cbbMovieName.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.cbbMovieName.TabIndex = 5;
            // 
            // kryptonDateTimePicker3
            // 
            this.kryptonDateTimePicker3.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.kryptonDateTimePicker3.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            this.kryptonDateTimePicker3.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.kryptonDateTimePicker3.Location = new System.Drawing.Point(623, 275);
            this.kryptonDateTimePicker3.Name = "kryptonDateTimePicker3";
            this.kryptonDateTimePicker3.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDateTimePicker3.Size = new System.Drawing.Size(231, 39);
            this.kryptonDateTimePicker3.StateCommon.Border.Rounding = 5F;
            this.kryptonDateTimePicker3.TabIndex = 16;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(609, 239);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(121, 38);
            this.lblEndDate.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblEndDate.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.TabIndex = 15;
            this.lblEndDate.Values.Text = "End Date";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(362, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnCancel.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnCancel.OverrideDefault.Back.ColorAngle = 45F;
            this.btnCancel.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnCancel.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnCancel.OverrideDefault.Border.ColorAngle = 60F;
            this.btnCancel.OverrideDefault.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnCancel.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCancel.OverrideDefault.Border.Rounding = 20F;
            this.btnCancel.OverrideDefault.Border.Width = 4;
            this.btnCancel.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnCancel.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnCancel.OverrideFocus.Back.ColorAngle = 45F;
            this.btnCancel.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnCancel.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnCancel.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnCancel.OverrideFocus.Border.ColorAngle = 45F;
            this.btnCancel.OverrideFocus.Border.Rounding = 20F;
            this.btnCancel.OverrideFocus.Border.Width = 1;
            this.btnCancel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCancel.Size = new System.Drawing.Size(192, 55);
            this.btnCancel.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnCancel.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnCancel.StateCommon.Back.ColorAngle = 45F;
            this.btnCancel.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCancel.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCancel.StateCommon.Border.ColorAngle = 45F;
            this.btnCancel.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCancel.StateCommon.Border.Rounding = 10F;
            this.btnCancel.StateCommon.Border.Width = 4;
            this.btnCancel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnCancel.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnCancel.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnCancel.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnCancel.StateNormal.Border.ColorAngle = 60F;
            this.btnCancel.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnCancel.StateNormal.Border.Rounding = 20F;
            this.btnCancel.StateNormal.Border.Width = 4;
            this.btnCancel.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnCancel.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnCancel.StatePressed.Back.ColorAngle = 135F;
            this.btnCancel.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnCancel.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnCancel.StatePressed.Border.ColorAngle = 135F;
            this.btnCancel.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StatePressed.Border.Rounding = 10F;
            this.btnCancel.StatePressed.Border.Width = 1;
            this.btnCancel.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnCancel.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnCancel.StateTracking.Back.ColorAngle = 45F;
            this.btnCancel.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnCancel.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnCancel.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnCancel.StateTracking.Border.ColorAngle = 45F;
            this.btnCancel.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCancel.StateTracking.Border.Rounding = 20F;
            this.btnCancel.StateTracking.Border.Width = 1;
            this.btnCancel.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(585, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnSave.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSave.OverrideDefault.Back.ColorAngle = 60F;
            this.btnSave.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSave.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnSave.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSave.OverrideDefault.Border.ColorAngle = 60F;
            this.btnSave.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.OverrideDefault.Border.Rounding = 20F;
            this.btnSave.OverrideDefault.Border.Width = 1;
            this.btnSave.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSave.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnSave.OverrideFocus.Back.ColorAngle = 45F;
            this.btnSave.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSave.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSave.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnSave.OverrideFocus.Border.ColorAngle = 45F;
            this.btnSave.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.OverrideFocus.Border.Rounding = 20F;
            this.btnSave.OverrideFocus.Border.Width = 1;
            this.btnSave.Size = new System.Drawing.Size(220, 52);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSave.StateCommon.Back.ColorAngle = 45F;
            this.btnSave.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSave.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSave.StateCommon.Border.ColorAngle = 45F;
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.StateCommon.Border.Rounding = 10F;
            this.btnSave.StateCommon.Border.Width = 1;
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnSave.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnSave.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnSave.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSave.StateNormal.Back.ColorAngle = 60F;
            this.btnSave.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSave.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnSave.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSave.StateNormal.Border.ColorAngle = 60F;
            this.btnSave.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.StateNormal.Border.Rounding = 20F;
            this.btnSave.StateNormal.Border.Width = 1;
            this.btnSave.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(97)))), ((int)(((byte)(44)))));
            this.btnSave.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btnSave.StatePressed.Back.ColorAngle = 135F;
            this.btnSave.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSave.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(97)))), ((int)(((byte)(44)))));
            this.btnSave.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btnSave.StatePressed.Border.ColorAngle = 135F;
            this.btnSave.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.StatePressed.Border.Rounding = 20F;
            this.btnSave.StatePressed.Border.Width = 1;
            this.btnSave.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSave.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnSave.StateTracking.Back.ColorAngle = 45F;
            this.btnSave.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSave.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnSave.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnSave.StateTracking.Border.ColorAngle = 45F;
            this.btnSave.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.StateTracking.Border.Rounding = 20F;
            this.btnSave.StateTracking.Border.Width = 1;
            this.btnSave.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 18;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Save Showtime";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kryptonCustomPaletteBase1
            // 
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideDefault.Border.ColorAngle = 60F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideDefault.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideDefault.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideFocus.Back.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideFocus.Border.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideFocus.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideFocus.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateNormal.Border.ColorAngle = 60F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateNormal.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateNormal.Border.Width = 3;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateTracking.Back.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateTracking.Border.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateTracking.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCommand.StateTracking.Border.Width = 3;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Back.ColorAngle = 60F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Border.ColorAngle = 60F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Back.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Border.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateNormal.Back.ColorAngle = 60F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateNormal.Border.ColorAngle = 60F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateNormal.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StatePressed.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Nunito", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Back.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Border.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Nunito", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideDefault.Back.ColorAngle = 60F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideDefault.Border.ColorAngle = 60F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideDefault.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideFocus.Back.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideFocus.Border.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideFocus.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideFocus.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateNormal.Back.ColorAngle = 60F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateNormal.Border.ColorAngle = 60F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateNormal.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateTracking.Back.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateTracking.Border.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateTracking.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateActive.Back.Color2 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Border.Width = 3;
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlStandalone.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlStandalone.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlStandalone.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlStandalone.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlStandalone.StateCommon.Border.Rounding = 15F;
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlStandalone.StateCommon.Border.Width = 2;
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlStandalone.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlStandalone.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonCustomPaletteBase1.InputControlStyles.InputControlStandalone.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCustomPaletteBase1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // AddShowtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonDateTimePicker2);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.cbbGenre);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.kryptonDateTimePicker3);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonDateTimePicker1);
            this.Controls.Add(this.lblRlDate);
            this.Controls.Add(this.cbbMovieName);
            this.Controls.Add(this.pnAdd);
            this.Controls.Add(this.lblMovieName);
            this.Name = "AddShowtime";
            this.Size = new System.Drawing.Size(895, 439);
            this.Load += new System.EventHandler(this.AddShowtime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnAdd)).EndInit();
            this.pnAdd.ResumeLayout(false);
            this.pnAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMovieName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel pnAdd;
        private Krypton.Toolkit.KryptonLabel lblMovieName;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonLabel lblRlDate;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonComboBox cbbGenre;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonComboBox cbbMovieName;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker3;
        private Krypton.Toolkit.KryptonLabel lblEndDate;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
    }
}