namespace Cinema_management
{
    partial class AddStaff
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
            this.btnExitAddStaf = new System.Windows.Forms.Button();
            this.lblAdd = new Krypton.Toolkit.KryptonLabel();
            this.pnBody = new Krypton.Toolkit.KryptonPanel();
            this.cboPosition = new Krypton.Toolkit.KryptonComboBox();
            this.datePickerHire = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            this.cbGender = new Krypton.Toolkit.KryptonComboBox();
            this.datePickerBirth = new Krypton.Toolkit.KryptonDateTimePicker();
            this.txbPasswordConfirm = new Krypton.Toolkit.KryptonTextBox();
            this.txbPassword = new Krypton.Toolkit.KryptonTextBox();
            this.txbAccount = new Krypton.Toolkit.KryptonTextBox();
            this.txbPhoneNum = new Krypton.Toolkit.KryptonTextBox();
            this.txbEmail = new Krypton.Toolkit.KryptonTextBox();
            this.txbName = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnSaveStaff = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnAdd)).BeginInit();
            this.pnAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnBody)).BeginInit();
            this.pnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAdd
            // 
            this.pnAdd.AutoSize = true;
            this.pnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnAdd.Controls.Add(this.btnExitAddStaf);
            this.pnAdd.Controls.Add(this.lblAdd);
            this.pnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAdd.Location = new System.Drawing.Point(0, 0);
            this.pnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.pnAdd.Size = new System.Drawing.Size(1012, 124);
            this.pnAdd.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnAdd.TabIndex = 2;
            // 
            // btnExitAddStaf
            // 
            this.btnExitAddStaf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitAddStaf.BackColor = System.Drawing.Color.Transparent;
            this.btnExitAddStaf.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitAddStaf.FlatAppearance.BorderSize = 0;
            this.btnExitAddStaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitAddStaf.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitAddStaf.Location = new System.Drawing.Point(954, 28);
            this.btnExitAddStaf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExitAddStaf.Name = "btnExitAddStaf";
            this.btnExitAddStaf.Size = new System.Drawing.Size(39, 36);
            this.btnExitAddStaf.TabIndex = 1;
            this.btnExitAddStaf.Text = "X";
            this.btnExitAddStaf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnExitAddStaf.UseVisualStyleBackColor = false;
            this.btnExitAddStaf.Click += new System.EventHandler(this.btnExitAddStaf_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.Location = new System.Drawing.Point(78, 58);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(260, 47);
            this.lblAdd.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblAdd.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Values.Text = "Add New Staff";
            // 
            // pnBody
            // 
            this.pnBody.AutoSize = true;
            this.pnBody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnBody.Controls.Add(this.btnSaveStaff);
            this.pnBody.Controls.Add(this.cboPosition);
            this.pnBody.Controls.Add(this.datePickerHire);
            this.pnBody.Controls.Add(this.kryptonLabel12);
            this.pnBody.Controls.Add(this.cbGender);
            this.pnBody.Controls.Add(this.datePickerBirth);
            this.pnBody.Controls.Add(this.txbPasswordConfirm);
            this.pnBody.Controls.Add(this.txbPassword);
            this.pnBody.Controls.Add(this.txbAccount);
            this.pnBody.Controls.Add(this.txbPhoneNum);
            this.pnBody.Controls.Add(this.txbEmail);
            this.pnBody.Controls.Add(this.txbName);
            this.pnBody.Controls.Add(this.kryptonLabel8);
            this.pnBody.Controls.Add(this.kryptonLabel11);
            this.pnBody.Controls.Add(this.kryptonLabel10);
            this.pnBody.Controls.Add(this.kryptonLabel9);
            this.pnBody.Controls.Add(this.kryptonLabel7);
            this.pnBody.Controls.Add(this.kryptonLabel6);
            this.pnBody.Controls.Add(this.kryptonLabel5);
            this.pnBody.Controls.Add(this.kryptonLabel4);
            this.pnBody.Controls.Add(this.kryptonLabel3);
            this.pnBody.Controls.Add(this.kryptonLabel2);
            this.pnBody.Controls.Add(this.kryptonLabel1);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 124);
            this.pnBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnBody.MinimumSize = new System.Drawing.Size(1012, 0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Padding = new System.Windows.Forms.Padding(30, 16, 30, 70);
            this.pnBody.Size = new System.Drawing.Size(1012, 1127);
            this.pnBody.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnBody.TabIndex = 3;
            // 
            // cboPosition
            // 
            this.cboPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPosition.DropDownWidth = 240;
            this.cboPosition.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cboPosition.Location = new System.Drawing.Point(334, 584);
            this.cboPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(360, 38);
            this.cboPosition.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboPosition.TabIndex = 34;
            // 
            // datePickerHire
            // 
            this.datePickerHire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerHire.CalendarTodayDate = new System.DateTime(2025, 11, 24, 0, 0, 0, 0);
            this.datePickerHire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerHire.Location = new System.Drawing.Point(334, 489);
            this.datePickerHire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePickerHire.Name = "datePickerHire";
            this.datePickerHire.Size = new System.Drawing.Size(360, 37);
            this.datePickerHire.TabIndex = 32;
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel12.Location = new System.Drawing.Point(82, 489);
            this.kryptonLabel12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(221, 43);
            this.kryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel12.TabIndex = 31;
            this.kryptonLabel12.Values.Text = "Start Working: ";
            // 
            // cbGender
            // 
            this.cbGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGender.DropDownWidth = 270;
            this.cbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Location = new System.Drawing.Point(334, 175);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(360, 38);
            this.cbGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbGender.TabIndex = 30;
            // 
            // datePickerBirth
            // 
            this.datePickerBirth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerBirth.CalendarTodayDate = new System.DateTime(2025, 11, 24, 0, 0, 0, 0);
            this.datePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerBirth.Location = new System.Drawing.Point(334, 250);
            this.datePickerBirth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datePickerBirth.Name = "datePickerBirth";
            this.datePickerBirth.Size = new System.Drawing.Size(360, 37);
            this.datePickerBirth.TabIndex = 29;
            // 
            // txbPasswordConfirm
            // 
            this.txbPasswordConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPasswordConfirm.Location = new System.Drawing.Point(334, 902);
            this.txbPasswordConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbPasswordConfirm.Name = "txbPasswordConfirm";
            this.txbPasswordConfirm.PasswordChar = '*';
            this.txbPasswordConfirm.Size = new System.Drawing.Size(597, 39);
            this.txbPasswordConfirm.TabIndex = 27;
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPassword.Location = new System.Drawing.Point(334, 823);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(597, 39);
            this.txbPassword.TabIndex = 26;
            // 
            // txbAccount
            // 
            this.txbAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAccount.Location = new System.Drawing.Point(334, 745);
            this.txbAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbAccount.Name = "txbAccount";
            this.txbAccount.Size = new System.Drawing.Size(597, 39);
            this.txbAccount.TabIndex = 25;
            // 
            // txbPhoneNum
            // 
            this.txbPhoneNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPhoneNum.Location = new System.Drawing.Point(334, 400);
            this.txbPhoneNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbPhoneNum.Name = "txbPhoneNum";
            this.txbPhoneNum.Size = new System.Drawing.Size(597, 39);
            this.txbPhoneNum.TabIndex = 24;
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEmail.Location = new System.Drawing.Point(334, 322);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(597, 39);
            this.txbEmail.TabIndex = 28;
            // 
            // txbName
            // 
            this.txbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbName.Location = new System.Drawing.Point(334, 100);
            this.txbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(597, 39);
            this.txbName.TabIndex = 23;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel8.Location = new System.Drawing.Point(80, 678);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(219, 43);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 22;
            this.kryptonLabel8.Values.Text = "User Account";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel11.Location = new System.Drawing.Point(82, 900);
            this.kryptonLabel11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(253, 43);
            this.kryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel11.TabIndex = 20;
            this.kryptonLabel11.Values.Text = "Password Again:";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel10.Location = new System.Drawing.Point(82, 822);
            this.kryptonLabel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(161, 43);
            this.kryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 19;
            this.kryptonLabel10.Values.Text = "Password:";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel9.Location = new System.Drawing.Point(82, 745);
            this.kryptonLabel9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(143, 43);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 18;
            this.kryptonLabel9.Values.Text = "Account:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel7.Location = new System.Drawing.Point(80, 584);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(140, 43);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 17;
            this.kryptonLabel7.Values.Text = "Position:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel6.Location = new System.Drawing.Point(80, 398);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(244, 43);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 16;
            this.kryptonLabel6.Values.Text = "Phone Number:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel5.Location = new System.Drawing.Point(80, 320);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(101, 43);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 15;
            this.kryptonLabel5.Values.Text = "Email:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel4.Location = new System.Drawing.Point(80, 239);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(144, 43);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Birthday:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel3.Location = new System.Drawing.Point(80, 164);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(130, 43);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 13;
            this.kryptonLabel3.Values.Text = "Gender:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel2.Location = new System.Drawing.Point(80, 98);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(170, 43);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 21;
            this.kryptonLabel2.Values.Text = "Full Name:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(80, 36);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(339, 43);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 12;
            this.kryptonLabel1.Values.Text = "Personal Information";
            // 
            // btnSaveStaff
            // 
            this.btnSaveStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveStaff.Location = new System.Drawing.Point(759, 995);
            this.btnSaveStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveStaff.Name = "btnSaveStaff";
            this.btnSaveStaff.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveStaff.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveStaff.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSaveStaff.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveStaff.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveStaff.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSaveStaff.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveStaff.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveStaff.OverrideDefault.Border.Rounding = 10F;
            this.btnSaveStaff.OverrideDefault.Border.Width = 1;
            this.btnSaveStaff.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveStaff.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveStaff.OverrideFocus.Back.ColorAngle = 45F;
            this.btnSaveStaff.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveStaff.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveStaff.OverrideFocus.Border.ColorAngle = 45F;
            this.btnSaveStaff.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveStaff.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveStaff.OverrideFocus.Border.Rounding = 10F;
            this.btnSaveStaff.OverrideFocus.Border.Width = 1;
            this.btnSaveStaff.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSaveStaff.Size = new System.Drawing.Size(172, 58);
            this.btnSaveStaff.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveStaff.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveStaff.StateCommon.Back.ColorAngle = 45F;
            this.btnSaveStaff.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveStaff.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveStaff.StateCommon.Border.ColorAngle = 45F;
            this.btnSaveStaff.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveStaff.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveStaff.StateCommon.Border.Rounding = 10F;
            this.btnSaveStaff.StateCommon.Border.Width = 1;
            this.btnSaveStaff.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSaveStaff.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStaff.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnSaveStaff.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnSaveStaff.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveStaff.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveStaff.StateNormal.Back.ColorAngle = 45F;
            this.btnSaveStaff.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveStaff.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveStaff.StateNormal.Border.ColorAngle = 45F;
            this.btnSaveStaff.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveStaff.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveStaff.StateNormal.Border.Rounding = 10F;
            this.btnSaveStaff.StateNormal.Border.Width = 1;
            this.btnSaveStaff.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnSaveStaff.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnSaveStaff.StatePressed.Back.ColorAngle = 135F;
            this.btnSaveStaff.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnSaveStaff.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnSaveStaff.StatePressed.Border.ColorAngle = 135F;
            this.btnSaveStaff.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveStaff.StatePressed.Border.Rounding = 10F;
            this.btnSaveStaff.StatePressed.Border.Width = 1;
            this.btnSaveStaff.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSaveStaff.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStaff.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveStaff.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveStaff.StateTracking.Back.ColorAngle = 45F;
            this.btnSaveStaff.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveStaff.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveStaff.StateTracking.Border.ColorAngle = 45F;
            this.btnSaveStaff.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveStaff.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveStaff.StateTracking.Border.Rounding = 10F;
            this.btnSaveStaff.StateTracking.Border.Width = 1;
            this.btnSaveStaff.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSaveStaff.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStaff.TabIndex = 35;
            this.btnSaveStaff.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSaveStaff.Values.Text = "Save";
            this.btnSaveStaff.Click += new System.EventHandler(this.btnSaveStaff_Click);
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1012, 0);
            this.Name = "AddStaff";
            this.Size = new System.Drawing.Size(1012, 1251);
            this.Load += new System.EventHandler(this.AddStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnAdd)).EndInit();
            this.pnAdd.ResumeLayout(false);
            this.pnAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnBody)).EndInit();
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnAdd;
        private Krypton.Toolkit.KryptonLabel lblAdd;
        private System.Windows.Forms.Button btnExitAddStaf;
        private Krypton.Toolkit.KryptonPanel pnBody;
        private Krypton.Toolkit.KryptonComboBox cboPosition;
        private Krypton.Toolkit.KryptonDateTimePicker datePickerHire;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonComboBox cbGender;
        private Krypton.Toolkit.KryptonDateTimePicker datePickerBirth;
        private Krypton.Toolkit.KryptonTextBox txbPasswordConfirm;
        private Krypton.Toolkit.KryptonTextBox txbPassword;
        private Krypton.Toolkit.KryptonTextBox txbAccount;
        private Krypton.Toolkit.KryptonTextBox txbPhoneNum;
        private Krypton.Toolkit.KryptonTextBox txbEmail;
        private Krypton.Toolkit.KryptonTextBox txbName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnSaveStaff;
    }
}
