namespace Cinema_management
{
    partial class AddUpdateMovieForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnAdd = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtDirector = new Krypton.Toolkit.KryptonTextBox();
            this.txtMovieName = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.lblMovieName = new Krypton.Toolkit.KryptonLabel();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.dtpReleaseDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.cbbAge = new Krypton.Toolkit.KryptonComboBox();
            this.cbbGenre = new Krypton.Toolkit.KryptonComboBox();
            this.txtDuration = new Krypton.Toolkit.KryptonTextBox();
            this.rtbDescription = new Krypton.Toolkit.KryptonTextBox();
            this.lblDuration = new Krypton.Toolkit.KryptonLabel();
            this.lblAgeRating = new Krypton.Toolkit.KryptonLabel();
            this.lblRlDate = new Krypton.Toolkit.KryptonLabel();
            this.lblDescription = new Krypton.Toolkit.KryptonLabel();
            this.lblGenre = new Krypton.Toolkit.KryptonLabel();
            this.txtMovieID = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.btnUploadPoster = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnAdd)).BeginInit();
            this.pnAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAdd
            // 
            this.pnAdd.Controls.Add(this.kryptonLabel1);
            this.pnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAdd.Location = new System.Drawing.Point(0, 0);
            this.pnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(1111, 131);
            this.pnAdd.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnAdd.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(63, 42);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(284, 47);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Add New Movie";
            // 
            // txtDirector
            // 
            this.txtDirector.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txtDirector.CueHint.CueHintText = "Enter director name";
            this.txtDirector.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirector.Location = new System.Drawing.Point(348, 470);
            this.txtDirector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(633, 52);
            this.txtDirector.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txtDirector.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txtDirector.StateCommon.Border.Rounding = 10F;
            this.txtDirector.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtDirector.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirector.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtDirector.TabIndex = 12;
            // 
            // txtMovieName
            // 
            this.txtMovieName.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txtMovieName.CueHint.CueHintText = "Enter movie name";
            this.txtMovieName.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName.Location = new System.Drawing.Point(348, 334);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(633, 52);
            this.txtMovieName.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txtMovieName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txtMovieName.StateCommon.Border.Rounding = 10F;
            this.txtMovieName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtMovieName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtMovieName.TabIndex = 13;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(124, 159);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(99, 40);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Poster";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(348, 425);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(209, 40);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 9;
            this.kryptonLabel3.Values.Text = "Director Name";
            // 
            // lblMovieName
            // 
            this.lblMovieName.Location = new System.Drawing.Point(348, 289);
            this.lblMovieName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(184, 40);
            this.lblMovieName.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblMovieName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.TabIndex = 10;
            this.lblMovieName.Values.Text = "Movie Name";
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(63, 289);
            this.picPoster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(240, 250);
            this.picPoster.TabIndex = 11;
            this.picPoster.TabStop = false;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.CalendarTodayDate = new System.DateTime(2025, 11, 12, 0, 0, 0, 0);
            this.dtpReleaseDate.CustomFormat = "dd/MM/yyyy";
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReleaseDate.Location = new System.Drawing.Point(660, 762);
            this.dtpReleaseDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(360, 41);
            this.dtpReleaseDate.StateCommon.Border.Rounding = 5F;
            this.dtpReleaseDate.TabIndex = 24;
            this.dtpReleaseDate.ValueNullable = new System.DateTime(2025, 11, 13, 0, 0, 0, 0);
            // 
            // cbbAge
            // 
            this.cbbAge.CueHint.Color1 = System.Drawing.Color.Black;
            this.cbbAge.CueHint.CueHintText = "Select rating";
            this.cbbAge.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAge.DropDownWidth = 156;
            this.cbbAge.Location = new System.Drawing.Point(372, 622);
            this.cbbAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbAge.Name = "cbbAge";
            this.cbbAge.Size = new System.Drawing.Size(213, 42);
            this.cbbAge.StateCommon.ComboBox.Border.Rounding = 5F;
            this.cbbAge.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbbAge.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cbbAge.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cbbAge.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.cbbAge.StateCommon.Item.Border.Rounding = 5F;
            this.cbbAge.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbbAge.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAge.TabIndex = 22;
            this.cbbAge.Text = "0";
            // 
            // cbbGenre
            // 
            this.cbbGenre.CueHint.Color1 = System.Drawing.Color.Black;
            this.cbbGenre.CueHint.CueHintText = "Select genre";
            this.cbbGenre.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGenre.DropDownWidth = 156;
            this.cbbGenre.Items.AddRange(new object[] {
            "Hành động"});
            this.cbbGenre.Location = new System.Drawing.Point(91, 622);
            this.cbbGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbGenre.Name = "cbbGenre";
            this.cbbGenre.Size = new System.Drawing.Size(213, 42);
            this.cbbGenre.StateCommon.ComboBox.Border.Rounding = 5F;
            this.cbbGenre.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbbGenre.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cbbGenre.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cbbGenre.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.cbbGenre.StateCommon.Item.Border.Rounding = 5F;
            this.cbbGenre.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbbGenre.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGenre.TabIndex = 23;
            this.cbbGenre.Text = "Hành động";
            // 
            // txtDuration
            // 
            this.txtDuration.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txtDuration.CueHint.CueHintText = "Enter duration";
            this.txtDuration.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(660, 622);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(360, 52);
            this.txtDuration.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txtDuration.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txtDuration.StateCommon.Border.Rounding = 10F;
            this.txtDuration.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtDuration.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtDuration.TabIndex = 20;
            // 
            // rtbDescription
            // 
            this.rtbDescription.AllowDrop = true;
            this.rtbDescription.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.rtbDescription.CueHint.CueHintText = "Enter movie description";
            this.rtbDescription.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(91, 762);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(495, 52);
            this.rtbDescription.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.rtbDescription.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.rtbDescription.StateCommon.Border.Rounding = 10F;
            this.rtbDescription.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.rtbDescription.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.rtbDescription.TabIndex = 21;
            // 
            // lblDuration
            // 
            this.lblDuration.Location = new System.Drawing.Point(660, 578);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(263, 40);
            this.lblDuration.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblDuration.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.TabIndex = 15;
            this.lblDuration.Values.Text = "Duration (minutes)";
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.Location = new System.Drawing.Point(372, 578);
            this.lblAgeRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(161, 40);
            this.lblAgeRating.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblAgeRating.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeRating.TabIndex = 16;
            this.lblAgeRating.Values.Text = "Age Rating";
            // 
            // lblRlDate
            // 
            this.lblRlDate.Location = new System.Drawing.Point(660, 718);
            this.lblRlDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblRlDate.Name = "lblRlDate";
            this.lblRlDate.Size = new System.Drawing.Size(185, 40);
            this.lblRlDate.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblRlDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRlDate.TabIndex = 17;
            this.lblRlDate.Values.Text = "Release Date";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(91, 718);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(166, 40);
            this.lblDescription.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblDescription.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Values.Text = "Description";
            // 
            // lblGenre
            // 
            this.lblGenre.Location = new System.Drawing.Point(91, 578);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(94, 40);
            this.lblGenre.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblGenre.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.TabIndex = 19;
            this.lblGenre.Values.Text = "Genre";
            // 
            // txtMovieID
            // 
            this.txtMovieID.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txtMovieID.CueHint.CueHintText = "Movie ID";
            this.txtMovieID.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieID.Location = new System.Drawing.Point(348, 204);
            this.txtMovieID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.ReadOnly = true;
            this.txtMovieID.Size = new System.Drawing.Size(633, 52);
            this.txtMovieID.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txtMovieID.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txtMovieID.StateCommon.Border.Rounding = 10F;
            this.txtMovieID.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtMovieID.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieID.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtMovieID.TabIndex = 28;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(348, 159);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(134, 40);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 27;
            this.kryptonLabel4.Values.Text = "Movie ID";
            // 
            // btnUploadPoster
            // 
            this.btnUploadPoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUploadPoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPoster.Location = new System.Drawing.Point(71, 212);
            this.btnUploadPoster.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadPoster.Name = "btnUploadPoster";
            this.btnUploadPoster.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUploadPoster.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUploadPoster.OverrideDefault.Back.ColorAngle = 45F;
            this.btnUploadPoster.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUploadPoster.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUploadPoster.OverrideDefault.Border.ColorAngle = 45F;
            this.btnUploadPoster.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUploadPoster.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUploadPoster.OverrideDefault.Border.Rounding = 10F;
            this.btnUploadPoster.OverrideDefault.Border.Width = 1;
            this.btnUploadPoster.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUploadPoster.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUploadPoster.OverrideFocus.Back.ColorAngle = 45F;
            this.btnUploadPoster.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUploadPoster.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUploadPoster.OverrideFocus.Border.ColorAngle = 45F;
            this.btnUploadPoster.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUploadPoster.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUploadPoster.OverrideFocus.Border.Rounding = 10F;
            this.btnUploadPoster.OverrideFocus.Border.Width = 1;
            this.btnUploadPoster.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnUploadPoster.Size = new System.Drawing.Size(227, 61);
            this.btnUploadPoster.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUploadPoster.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUploadPoster.StateCommon.Back.ColorAngle = 45F;
            this.btnUploadPoster.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUploadPoster.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUploadPoster.StateCommon.Border.ColorAngle = 45F;
            this.btnUploadPoster.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUploadPoster.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUploadPoster.StateCommon.Border.Rounding = 10F;
            this.btnUploadPoster.StateCommon.Border.Width = 1;
            this.btnUploadPoster.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUploadPoster.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPoster.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUploadPoster.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUploadPoster.StateNormal.Back.ColorAngle = 45F;
            this.btnUploadPoster.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUploadPoster.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUploadPoster.StateNormal.Border.ColorAngle = 45F;
            this.btnUploadPoster.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUploadPoster.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUploadPoster.StateNormal.Border.Rounding = 10F;
            this.btnUploadPoster.StateNormal.Border.Width = 1;
            this.btnUploadPoster.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnUploadPoster.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnUploadPoster.StatePressed.Back.ColorAngle = 135F;
            this.btnUploadPoster.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnUploadPoster.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnUploadPoster.StatePressed.Border.ColorAngle = 135F;
            this.btnUploadPoster.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUploadPoster.StatePressed.Border.Rounding = 10F;
            this.btnUploadPoster.StatePressed.Border.Width = 1;
            this.btnUploadPoster.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUploadPoster.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPoster.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUploadPoster.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUploadPoster.StateTracking.Back.ColorAngle = 45F;
            this.btnUploadPoster.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUploadPoster.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUploadPoster.StateTracking.Border.ColorAngle = 45F;
            this.btnUploadPoster.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUploadPoster.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUploadPoster.StateTracking.Border.Rounding = 10F;
            this.btnUploadPoster.StateTracking.Border.Width = 1;
            this.btnUploadPoster.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUploadPoster.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPoster.TabIndex = 29;
            this.btnUploadPoster.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUploadPoster.Values.Image = global::Cinema_management.Properties.Resources.material_symbols__add_rounded;
            this.btnUploadPoster.Values.Text = "Upload Poster";
            this.btnUploadPoster.Click += new System.EventHandler(this.btnUploadPoster_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(820, 851);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSave.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSave.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSave.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSave.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSave.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSave.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.OverrideDefault.Border.Rounding = 10F;
            this.btnSave.OverrideDefault.Border.Width = 1;
            this.btnSave.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSave.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSave.OverrideFocus.Back.ColorAngle = 45F;
            this.btnSave.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSave.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSave.OverrideFocus.Border.ColorAngle = 45F;
            this.btnSave.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.OverrideFocus.Border.Rounding = 10F;
            this.btnSave.OverrideFocus.Border.Width = 1;
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSave.Size = new System.Drawing.Size(200, 56);
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
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnSave.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnSave.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSave.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSave.StateNormal.Back.ColorAngle = 45F;
            this.btnSave.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSave.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSave.StateNormal.Border.ColorAngle = 45F;
            this.btnSave.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.StateNormal.Border.Rounding = 10F;
            this.btnSave.StateNormal.Border.Width = 1;
            this.btnSave.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnSave.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnSave.StatePressed.Back.ColorAngle = 135F;
            this.btnSave.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnSave.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnSave.StatePressed.Border.ColorAngle = 135F;
            this.btnSave.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StatePressed.Border.Rounding = 10F;
            this.btnSave.StatePressed.Border.Width = 1;
            this.btnSave.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSave.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSave.StateTracking.Back.ColorAngle = 45F;
            this.btnSave.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSave.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSave.StateTracking.Border.ColorAngle = 45F;
            this.btnSave.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.StateTracking.Border.Rounding = 10F;
            this.btnSave.StateTracking.Border.Width = 1;
            this.btnSave.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 30;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Save Movie";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(620, 851);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnCancel.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnCancel.OverrideDefault.Back.ColorAngle = 45F;
            this.btnCancel.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCancel.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCancel.OverrideDefault.Border.ColorAngle = 45F;
            this.btnCancel.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCancel.OverrideDefault.Border.Rounding = 10F;
            this.btnCancel.OverrideDefault.Border.Width = 4;
            this.btnCancel.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCancel.Size = new System.Drawing.Size(160, 56);
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
            this.btnCancel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnCancel.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCancel.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCancel.StateTracking.Back.ColorAngle = 45F;
            this.btnCancel.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCancel.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCancel.StateTracking.Border.ColorAngle = 45F;
            this.btnCancel.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCancel.StateTracking.Border.Rounding = 10F;
            this.btnCancel.StateTracking.Border.Width = 1;
            this.btnCancel.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddUpdateMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 940);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUploadPoster);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.cbbAge);
            this.Controls.Add(this.cbbGenre);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblAgeRating);
            this.Controls.Add(this.lblRlDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.picPoster);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.pnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddUpdateMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateMovie";
            this.Load += new System.EventHandler(this.AddUpdateMovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnAdd)).EndInit();
            this.pnAdd.ResumeLayout(false);
            this.pnAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnAdd;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtDirector;
        private Krypton.Toolkit.KryptonTextBox txtMovieName;
        private System.Windows.Forms.PictureBox picPoster;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblMovieName;
        private Krypton.Toolkit.KryptonDateTimePicker dtpReleaseDate;
        private Krypton.Toolkit.KryptonComboBox cbbAge;
        private Krypton.Toolkit.KryptonComboBox cbbGenre;
        private Krypton.Toolkit.KryptonTextBox txtDuration;
        private Krypton.Toolkit.KryptonTextBox rtbDescription;
        private Krypton.Toolkit.KryptonLabel lblDuration;
        private Krypton.Toolkit.KryptonLabel lblAgeRating;
        private Krypton.Toolkit.KryptonLabel lblRlDate;
        private Krypton.Toolkit.KryptonLabel lblDescription;
        private Krypton.Toolkit.KryptonLabel lblGenre;
        private Krypton.Toolkit.KryptonTextBox txtMovieID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonButton btnUploadPoster;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnCancel;
    }
}