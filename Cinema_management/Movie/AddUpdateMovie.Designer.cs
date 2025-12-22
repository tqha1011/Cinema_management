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
            this.components = new System.ComponentModel.Container();
            this.pnAdd = new Krypton.Toolkit.KryptonPanel();
            this.label = new Krypton.Toolkit.KryptonLabel();
            this.txtDirector = new Krypton.Toolkit.KryptonTextBox();
            this.txtMovieName = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.lblMovieName = new Krypton.Toolkit.KryptonLabel();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.dtpReleaseDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.cbbAge = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
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
            this.pnAdd.Controls.Add(this.label);
            this.pnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAdd.Location = new System.Drawing.Point(0, 0);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(833, 105);
            this.pnAdd.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnAdd.TabIndex = 1;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(47, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(261, 50);
            this.label.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.label.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.TabIndex = 0;
            this.label.Values.Text = "Add New Movie";
            // 
            // txtDirector
            // 
            this.txtDirector.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txtDirector.CueHint.CueHintText = "Enter director name";
            this.txtDirector.CueHint.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirector.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.txtDirector.Location = new System.Drawing.Point(306, 376);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtDirector.Size = new System.Drawing.Size(430, 57);
            this.txtDirector.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtDirector.TabIndex = 12;
            // 
            // txtMovieName
            // 
            this.txtMovieName.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txtMovieName.CueHint.CueHintText = "Enter movie name";
            this.txtMovieName.CueHint.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.txtMovieName.Location = new System.Drawing.Point(306, 267);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtMovieName.Size = new System.Drawing.Size(430, 57);
            this.txtMovieName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtMovieName.TabIndex = 13;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(306, 340);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(182, 38);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 9;
            this.kryptonLabel3.Values.Text = "Director Name";
            // 
            // lblMovieName
            // 
            this.lblMovieName.Location = new System.Drawing.Point(306, 231);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(157, 38);
            this.lblMovieName.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblMovieName.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.TabIndex = 10;
            this.lblMovieName.Values.Text = "Movie Name";
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(53, 211);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(212, 222);
            this.picPoster.TabIndex = 11;
            this.picPoster.TabStop = false;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.CalendarTodayDate = new System.DateTime(2025, 11, 12, 0, 0, 0, 0);
            this.dtpReleaseDate.CustomFormat = "dd/MM/yyyy";
            this.dtpReleaseDate.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReleaseDate.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            this.dtpReleaseDate.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.dtpReleaseDate.Location = new System.Drawing.Point(495, 618);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dtpReleaseDate.Size = new System.Drawing.Size(270, 39);
            this.dtpReleaseDate.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.dtpReleaseDate.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.dtpReleaseDate.StateCommon.Content.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReleaseDate.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, -1, -1, -1);
            this.dtpReleaseDate.TabIndex = 24;
            this.dtpReleaseDate.ValueNullable = new System.DateTime(2025, 11, 13, 0, 0, 0, 0);
            // 
            // cbbAge
            // 
            this.cbbAge.CueHint.Color1 = System.Drawing.Color.Black;
            this.cbbAge.CueHint.CueHintText = "Select rating";
            this.cbbAge.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAge.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.cbbAge.DropDownWidth = 156;
            this.cbbAge.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbbAge.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.cbbAge.Location = new System.Drawing.Point(290, 512);
            this.cbbAge.Name = "cbbAge";
            this.cbbAge.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.cbbAge.Size = new System.Drawing.Size(133, 40);
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
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Back.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Border.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Border.Rounding = 20F;
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
            // cbbGenre
            // 
            this.cbbGenre.CueHint.Color1 = System.Drawing.Color.Black;
            this.cbbGenre.CueHint.CueHintText = "Select genre";
            this.cbbGenre.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGenre.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.cbbGenre.DropDownWidth = 156;
            this.cbbGenre.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbbGenre.Items.AddRange(new object[] {
            "Hành động"});
            this.cbbGenre.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.cbbGenre.Location = new System.Drawing.Point(68, 512);
            this.cbbGenre.Name = "cbbGenre";
            this.cbbGenre.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.cbbGenre.Size = new System.Drawing.Size(160, 40);
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
            this.txtDuration.CueHint.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.txtDuration.Location = new System.Drawing.Point(495, 498);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtDuration.Size = new System.Drawing.Size(270, 57);
            this.txtDuration.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtDuration.TabIndex = 20;
            // 
            // rtbDescription
            // 
            this.rtbDescription.AllowDrop = true;
            this.rtbDescription.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.rtbDescription.CueHint.CueHintText = "Enter movie description";
            this.rtbDescription.CueHint.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.rtbDescription.Location = new System.Drawing.Point(68, 610);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.rtbDescription.Size = new System.Drawing.Size(371, 57);
            this.rtbDescription.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.rtbDescription.TabIndex = 21;
            // 
            // lblDuration
            // 
            this.lblDuration.Location = new System.Drawing.Point(495, 462);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(232, 38);
            this.lblDuration.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblDuration.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.TabIndex = 15;
            this.lblDuration.Values.Text = "Duration (minutes)";
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.Location = new System.Drawing.Point(279, 462);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(144, 38);
            this.lblAgeRating.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblAgeRating.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeRating.TabIndex = 16;
            this.lblAgeRating.Values.Text = "Age Rating";
            // 
            // lblRlDate
            // 
            this.lblRlDate.Location = new System.Drawing.Point(495, 574);
            this.lblRlDate.Name = "lblRlDate";
            this.lblRlDate.Size = new System.Drawing.Size(167, 38);
            this.lblRlDate.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblRlDate.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRlDate.TabIndex = 17;
            this.lblRlDate.Values.Text = "Release Date";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(68, 574);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(146, 38);
            this.lblDescription.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblDescription.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Values.Text = "Description";
            // 
            // lblGenre
            // 
            this.lblGenre.Location = new System.Drawing.Point(68, 462);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(84, 38);
            this.lblGenre.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblGenre.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.TabIndex = 19;
            this.lblGenre.Values.Text = "Genre";
            // 
            // txtMovieID
            // 
            this.txtMovieID.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txtMovieID.CueHint.CueHintText = "Movie ID";
            this.txtMovieID.CueHint.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieID.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.txtMovieID.Location = new System.Drawing.Point(306, 163);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtMovieID.ReadOnly = true;
            this.txtMovieID.Size = new System.Drawing.Size(430, 57);
            this.txtMovieID.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtMovieID.TabIndex = 28;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(306, 127);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(115, 38);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 27;
            this.kryptonLabel4.Values.Text = "Movie ID";
            // 
            // btnUploadPoster
            // 
            this.btnUploadPoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUploadPoster.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            this.btnUploadPoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPoster.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.btnUploadPoster.Location = new System.Drawing.Point(53, 127);
            this.btnUploadPoster.Name = "btnUploadPoster";
            this.btnUploadPoster.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUploadPoster.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUploadPoster.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnUploadPoster.Size = new System.Drawing.Size(212, 64);
            this.btnUploadPoster.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUploadPoster.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUploadPoster.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPoster.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUploadPoster.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUploadPoster.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUploadPoster.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUploadPoster.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUploadPoster.TabIndex = 29;
            this.btnUploadPoster.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUploadPoster.Values.Text = "Upload Poster";
            this.btnUploadPoster.Click += new System.EventHandler(this.btnUploadPoster_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.btnSave.Location = new System.Drawing.Point(602, 692);
            this.btnSave.Name = "btnSave";
            this.btnSave.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.OverrideFocus.Border.Rounding = 10F;
            this.btnSave.OverrideFocus.Border.Width = 1;
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnSave.Size = new System.Drawing.Size(163, 59);
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.TabIndex = 30;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(419, 692);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnCancel.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnCancel.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnCancel.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCancel.OverrideDefault.Border.Rounding = 20F;
            this.btnCancel.OverrideDefault.Border.Width = 3;
            this.btnCancel.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnCancel.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnCancel.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.btnCancel.OverrideFocus.Back.ColorAngle = 45F;
            this.btnCancel.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnCancel.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnCancel.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.btnCancel.OverrideFocus.Border.ColorAngle = 45F;
            this.btnCancel.OverrideFocus.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnCancel.OverrideFocus.Border.Rounding = 20F;
            this.btnCancel.OverrideFocus.Border.Width = 3;
            this.btnCancel.Size = new System.Drawing.Size(163, 59);
            this.btnCancel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnCancel.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnCancel.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnCancel.StateNormal.Border.Rounding = 20F;
            this.btnCancel.StateNormal.Border.Width = 3;
            this.btnCancel.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.btnCancel.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.btnCancel.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.btnCancel.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StatePressed.Border.Rounding = 20F;
            this.btnCancel.StatePressed.Border.Width = 3;
            this.btnCancel.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancel.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnCancel.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.btnCancel.StateTracking.Back.ColorAngle = 45F;
            this.btnCancel.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnCancel.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.btnCancel.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.btnCancel.StateTracking.Border.ColorAngle = 45F;
            this.btnCancel.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnCancel.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCancel.StateTracking.Border.Rounding = 20F;
            this.btnCancel.StateTracking.Border.Width = 3;
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddUpdateMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 791);
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
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.pnAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUpdateMovieForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Krypton.Toolkit.KryptonLabel label;
        private Krypton.Toolkit.KryptonTextBox txtDirector;
        private Krypton.Toolkit.KryptonTextBox txtMovieName;
        private System.Windows.Forms.PictureBox picPoster;
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
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
    }
}