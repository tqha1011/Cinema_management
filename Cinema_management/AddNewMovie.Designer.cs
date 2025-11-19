namespace Cinema_management
{
    partial class AddNewMovie
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
            this.pnAdd = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblMovieName = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txbMovieName = new Krypton.Toolkit.KryptonTextBox();
            this.lblGenre = new Krypton.Toolkit.KryptonLabel();
            this.txbDirector = new Krypton.Toolkit.KryptonTextBox();
            this.cbbGenre = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.lblAgeRating = new Krypton.Toolkit.KryptonLabel();
            this.cbbAge = new Krypton.Toolkit.KryptonComboBox();
            this.lblDuration = new Krypton.Toolkit.KryptonLabel();
            this.txbDuration = new Krypton.Toolkit.KryptonTextBox();
            this.lblRlDate = new Krypton.Toolkit.KryptonLabel();
            this.kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblDescription = new Krypton.Toolkit.KryptonLabel();
            this.txbScript = new Krypton.Toolkit.KryptonTextBox();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnAdd)).BeginInit();
            this.pnAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAdd
            // 
            this.pnAdd.Controls.Add(this.kryptonLabel1);
            this.pnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAdd.Location = new System.Drawing.Point(0, 0);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(800, 105);
            this.pnAdd.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnAdd.TabIndex = 0;
            this.pnAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.pnAdd_Paint);
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
            // lblMovieName
            // 
            this.lblMovieName.Location = new System.Drawing.Point(272, 141);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(140, 30);
            this.lblMovieName.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblMovieName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.TabIndex = 1;
            this.lblMovieName.Values.Text = "Movie Name";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(93, 141);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(76, 30);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Poster";
            // 
            // txbMovieName
            // 
            this.txbMovieName.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txbMovieName.CueHint.CueHintText = "Enter movie name";
            this.txbMovieName.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMovieName.Location = new System.Drawing.Point(272, 177);
            this.txbMovieName.Name = "txbMovieName";
            this.txbMovieName.Size = new System.Drawing.Size(475, 44);
            this.txbMovieName.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txbMovieName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txbMovieName.StateCommon.Border.Rounding = 10F;
            this.txbMovieName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txbMovieName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMovieName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txbMovieName.TabIndex = 3;
            // 
            // lblGenre
            // 
            this.lblGenre.Location = new System.Drawing.Point(47, 393);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(72, 30);
            this.lblGenre.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblGenre.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.TabIndex = 1;
            this.lblGenre.Values.Text = "Genre";
            // 
            // txbDirector
            // 
            this.txbDirector.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txbDirector.CueHint.CueHintText = "Enter director name";
            this.txbDirector.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDirector.Location = new System.Drawing.Point(272, 286);
            this.txbDirector.Name = "txbDirector";
            this.txbDirector.Size = new System.Drawing.Size(475, 44);
            this.txbDirector.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txbDirector.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txbDirector.StateCommon.Border.Rounding = 10F;
            this.txbDirector.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txbDirector.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDirector.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txbDirector.TabIndex = 3;
            // 
            // cbbGenre
            // 
            this.cbbGenre.CueHint.Color1 = System.Drawing.Color.Black;
            this.cbbGenre.CueHint.CueHintText = "Select genre";
            this.cbbGenre.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGenre.DropDownWidth = 156;
            this.cbbGenre.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Romance",
            "Sci-Fi",
            "Horror",
            "Drama",
            "Animation"});
            this.cbbGenre.Location = new System.Drawing.Point(47, 429);
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
            this.cbbGenre.TabIndex = 4;
            this.cbbGenre.Text = "Action";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(272, 250);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(158, 30);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Director Name";
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.Location = new System.Drawing.Point(258, 393);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(122, 30);
            this.lblAgeRating.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblAgeRating.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeRating.TabIndex = 1;
            this.lblAgeRating.Values.Text = "Age Rating";
            // 
            // cbbAge
            // 
            this.cbbAge.CueHint.Color1 = System.Drawing.Color.Black;
            this.cbbAge.CueHint.CueHintText = "Select rating";
            this.cbbAge.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAge.DropDownWidth = 156;
            this.cbbAge.Items.AddRange(new object[] {
            "P",
            "K",
            "T13",
            "T16",
            "T18"});
            this.cbbAge.Location = new System.Drawing.Point(258, 429);
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
            this.cbbAge.TabIndex = 4;
            this.cbbAge.Text = "P";
            // 
            // lblDuration
            // 
            this.lblDuration.Location = new System.Drawing.Point(474, 393);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(199, 30);
            this.lblDuration.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblDuration.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.TabIndex = 1;
            this.lblDuration.Values.Text = "Duration (minutes)";
            // 
            // txbDuration
            // 
            this.txbDuration.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txbDuration.CueHint.CueHintText = "Enter duration";
            this.txbDuration.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDuration.Location = new System.Drawing.Point(474, 429);
            this.txbDuration.Name = "txbDuration";
            this.txbDuration.Size = new System.Drawing.Size(270, 44);
            this.txbDuration.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txbDuration.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txbDuration.StateCommon.Border.Rounding = 10F;
            this.txbDuration.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txbDuration.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDuration.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txbDuration.TabIndex = 3;
            // 
            // lblRlDate
            // 
            this.lblRlDate.Location = new System.Drawing.Point(474, 505);
            this.lblRlDate.Name = "lblRlDate";
            this.lblRlDate.Size = new System.Drawing.Size(141, 30);
            this.lblRlDate.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblRlDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRlDate.TabIndex = 1;
            this.lblRlDate.Values.Text = "Release Date";
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.CalendarTodayDate = new System.DateTime(2025, 11, 12, 0, 0, 0, 0);
            this.kryptonDateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.kryptonDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(474, 541);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(270, 34);
            this.kryptonDateTimePicker1.StateCommon.Border.Rounding = 5F;
            this.kryptonDateTimePicker1.TabIndex = 5;
            this.kryptonDateTimePicker1.ValueNullable = new System.DateTime(2025, 11, 13, 0, 0, 0, 0);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(47, 505);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 30);
            this.lblDescription.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblDescription.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Values.Text = "Description";
            // 
            // txbScript
            // 
            this.txbScript.AllowDrop = true;
            this.txbScript.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.txbScript.CueHint.CueHintText = "Enter movie description";
            this.txbScript.CueHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbScript.Location = new System.Drawing.Point(47, 541);
            this.txbScript.Name = "txbScript";
            this.txbScript.Size = new System.Drawing.Size(371, 44);
            this.txbScript.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txbScript.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txbScript.StateCommon.Border.Rounding = 10F;
            this.txbScript.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txbScript.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbScript.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txbScript.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(447, 669);
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
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(597, 669);
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
            this.btnSave.TabIndex = 6;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Save Movie";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 200);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AddNewMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.kryptonDateTimePicker1);
            this.Controls.Add(this.cbbAge);
            this.Controls.Add(this.cbbGenre);
            this.Controls.Add(this.txbDuration);
            this.Controls.Add(this.txbScript);
            this.Controls.Add(this.txbDirector);
            this.Controls.Add(this.txbMovieName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblAgeRating);
            this.Controls.Add(this.lblRlDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.pnAdd);
            this.Name = "AddNewMovie";
            this.Size = new System.Drawing.Size(800, 750);
            ((System.ComponentModel.ISupportInitialize)(this.pnAdd)).EndInit();
            this.pnAdd.ResumeLayout(false);
            this.pnAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnAdd;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblMovieName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txbMovieName;
        private Krypton.Toolkit.KryptonLabel lblGenre;
        private Krypton.Toolkit.KryptonTextBox txbDirector;
        private Krypton.Toolkit.KryptonComboBox cbbGenre;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblAgeRating;
        private Krypton.Toolkit.KryptonComboBox cbbAge;
        private Krypton.Toolkit.KryptonLabel lblDuration;
        private Krypton.Toolkit.KryptonTextBox txbDuration;
        private Krypton.Toolkit.KryptonLabel lblRlDate;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonLabel lblDescription;
        private Krypton.Toolkit.KryptonTextBox txbScript;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonButton btnSave;
    }
}
