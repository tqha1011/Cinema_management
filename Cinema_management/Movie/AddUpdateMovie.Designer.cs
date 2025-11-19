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
            this.btnUploadPoster = new Krypton.Toolkit.KryptonButton();
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
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.txtMovieID = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
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
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(833, 105);
            this.pnAdd.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnAdd.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(47, 34);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(215, 36);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Add New Movie";
            // 
            // btnUploadPoster
            // 
            this.btnUploadPoster.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUploadPoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPoster.Location = new System.Drawing.Point(53, 170);
            this.btnUploadPoster.Name = "btnUploadPoster";
            this.btnUploadPoster.Size = new System.Drawing.Size(170, 49);
            this.btnUploadPoster.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnUploadPoster.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnUploadPoster.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUploadPoster.StateCommon.Border.Rounding = 10F;
            this.btnUploadPoster.StateCommon.Border.Width = 0;
            this.btnUploadPoster.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUploadPoster.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPoster.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnUploadPoster.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnUploadPoster.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPoster.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnUploadPoster.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUploadPoster.StatePressed.Border.Rounding = 10F;
            this.btnUploadPoster.StatePressed.Border.Width = 0;
            this.btnUploadPoster.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUploadPoster.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPoster.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.btnUploadPoster.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.btnUploadPoster.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUploadPoster.StateTracking.Border.Rounding = 10F;
            this.btnUploadPoster.StateTracking.Border.Width = 0;
            this.btnUploadPoster.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUploadPoster.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPoster.TabIndex = 14;
            this.btnUploadPoster.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUploadPoster.Values.Image = global::Cinema_management.Properties.Resources.material_symbols__add_rounded;
            this.btnUploadPoster.Values.Text = "Upload Poster";
            this.btnUploadPoster.Click += new System.EventHandler(this.btnUploadPoster_Click);
            // 
            // txtDirector
            // 
            this.txtDirector.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txtDirector.CueHint.CueHintText = "Enter director name";
            this.txtDirector.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirector.Location = new System.Drawing.Point(261, 376);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(475, 44);
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
            this.txtMovieName.Location = new System.Drawing.Point(261, 267);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(475, 44);
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
            this.kryptonLabel2.Location = new System.Drawing.Point(93, 127);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(76, 30);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Poster";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(261, 340);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(158, 30);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 9;
            this.kryptonLabel3.Values.Text = "Director Name";
            // 
            // lblMovieName
            // 
            this.lblMovieName.Location = new System.Drawing.Point(261, 231);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(140, 30);
            this.lblMovieName.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblMovieName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.TabIndex = 10;
            this.lblMovieName.Values.Text = "Movie Name";
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(47, 231);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(180, 200);
            this.picPoster.TabIndex = 11;
            this.picPoster.TabStop = false;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.CalendarTodayDate = new System.DateTime(2025, 11, 12, 0, 0, 0, 0);
            this.dtpReleaseDate.CustomFormat = "dd/MM/yyyy";
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReleaseDate.Location = new System.Drawing.Point(495, 610);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(270, 34);
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
            this.cbbAge.Location = new System.Drawing.Point(279, 498);
            this.cbbAge.Name = "cbbAge";
            this.cbbAge.Size = new System.Drawing.Size(160, 34);
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
            this.cbbGenre.Location = new System.Drawing.Point(68, 498);
            this.cbbGenre.Name = "cbbGenre";
            this.cbbGenre.Size = new System.Drawing.Size(160, 34);
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
            this.txtDuration.Location = new System.Drawing.Point(495, 498);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(270, 44);
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
            this.rtbDescription.Location = new System.Drawing.Point(68, 610);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(371, 44);
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
            this.lblDuration.Location = new System.Drawing.Point(495, 462);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(199, 30);
            this.lblDuration.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblDuration.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.TabIndex = 15;
            this.lblDuration.Values.Text = "Duration (minutes)";
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.Location = new System.Drawing.Point(279, 462);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(122, 30);
            this.lblAgeRating.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblAgeRating.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeRating.TabIndex = 16;
            this.lblAgeRating.Values.Text = "Age Rating";
            // 
            // lblRlDate
            // 
            this.lblRlDate.Location = new System.Drawing.Point(495, 574);
            this.lblRlDate.Name = "lblRlDate";
            this.lblRlDate.Size = new System.Drawing.Size(141, 30);
            this.lblRlDate.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblRlDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRlDate.TabIndex = 17;
            this.lblRlDate.Values.Text = "Release Date";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(68, 574);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 30);
            this.lblDescription.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblDescription.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Values.Text = "Description";
            // 
            // lblGenre
            // 
            this.lblGenre.Location = new System.Drawing.Point(68, 462);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(72, 30);
            this.lblGenre.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblGenre.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.TabIndex = 19;
            this.lblGenre.Values.Text = "Genre";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(615, 681);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 45);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnSave.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.btnSave.StateCommon.Border.Rounding = 10F;
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnSave.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnSave.TabIndex = 25;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Save Movie";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(465, 681);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 45);
            this.btnCancel.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCancel.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCancel.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.btnCancel.StateCommon.Border.Rounding = 10F;
            this.btnCancel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.StateTracking.Back.Color1 = System.Drawing.Color.LightGray;
            this.btnCancel.StateTracking.Back.Color2 = System.Drawing.Color.LightGray;
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMovieID
            // 
            this.txtMovieID.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txtMovieID.CueHint.CueHintText = "Movie ID";
            this.txtMovieID.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieID.Location = new System.Drawing.Point(261, 163);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.ReadOnly = true;
            this.txtMovieID.Size = new System.Drawing.Size(475, 44);
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
            this.kryptonLabel4.Location = new System.Drawing.Point(261, 127);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(102, 30);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 27;
            this.kryptonLabel4.Values.Text = "Movie ID";
            // 
            // AddUpdateMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 752);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
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
            this.Controls.Add(this.btnUploadPoster);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.picPoster);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.pnAdd);
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
        private Krypton.Toolkit.KryptonButton btnUploadPoster;
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
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonTextBox txtMovieID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}