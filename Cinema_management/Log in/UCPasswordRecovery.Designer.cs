namespace Cinema_management
{
    partial class UCPasswordRecovery
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
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtEmailConfirm = new Krypton.Toolkit.KryptonTextBox();
            this.lblEmailExist = new Krypton.Toolkit.KryptonLabel();
            this.lblCheck = new Krypton.Toolkit.KryptonLabel();
            this.btnSendCode = new Krypton.Toolkit.KryptonButton();
            this.txtPassNew = new Krypton.Toolkit.KryptonTextBox();
            this.txtVerified = new Krypton.Toolkit.KryptonTextBox();
            this.btnConfirm = new Krypton.Toolkit.KryptonButton();
            this.ptbIconBack = new Krypton.Toolkit.KryptonPictureBox();
            this.ptbLock = new Krypton.Toolkit.KryptonPictureBox();
            this.btnShowHide = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIconBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(94, 27);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(283, 40);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(80)))), ((int)(((byte)(253)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Password Recovery";
            // 
            // txtEmailConfirm
            // 
            this.txtEmailConfirm.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtEmailConfirm.CueHint.CueHintText = "Email";
            this.txtEmailConfirm.CueHint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailConfirm.Location = new System.Drawing.Point(118, 98);
            this.txtEmailConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailConfirm.Name = "txtEmailConfirm";
            this.txtEmailConfirm.Size = new System.Drawing.Size(286, 27);
            this.txtEmailConfirm.TabIndex = 3;
            // 
            // lblEmailExist
            // 
            this.lblEmailExist.Location = new System.Drawing.Point(160, 223);
            this.lblEmailExist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblEmailExist.Name = "lblEmailExist";
            this.lblEmailExist.Size = new System.Drawing.Size(173, 27);
            this.lblEmailExist.StateCommon.ShortText.Color1 = System.Drawing.Color.Firebrick;
            this.lblEmailExist.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailExist.TabIndex = 6;
            this.lblEmailExist.Values.Text = "Email không tồn tại";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = false;
            this.lblCheck.Location = new System.Drawing.Point(147, 254);
            this.lblCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(207, 25);
            this.lblCheck.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(80)))), ((int)(((byte)(253)))));
            this.lblCheck.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.TabIndex = 7;
            this.lblCheck.Values.Text = "Vui lòng kiểm tra email";
            // 
            // btnSendCode
            // 
            this.btnSendCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode.Location = new System.Drawing.Point(250, 294);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnSendCode.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnSendCode.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSendCode.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSendCode.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSendCode.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSendCode.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSendCode.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSendCode.OverrideDefault.Border.Rounding = 10F;
            this.btnSendCode.OverrideDefault.Border.Width = 4;
            this.btnSendCode.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSendCode.Size = new System.Drawing.Size(173, 43);
            this.btnSendCode.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnSendCode.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnSendCode.StateCommon.Back.ColorAngle = 45F;
            this.btnSendCode.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSendCode.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSendCode.StateCommon.Border.ColorAngle = 45F;
            this.btnSendCode.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSendCode.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSendCode.StateCommon.Border.Rounding = 10F;
            this.btnSendCode.StateCommon.Border.Width = 4;
            this.btnSendCode.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSendCode.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnSendCode.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnSendCode.StatePressed.Back.ColorAngle = 135F;
            this.btnSendCode.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnSendCode.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnSendCode.StatePressed.Border.ColorAngle = 135F;
            this.btnSendCode.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSendCode.StatePressed.Border.Rounding = 10F;
            this.btnSendCode.StatePressed.Border.Width = 1;
            this.btnSendCode.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSendCode.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSendCode.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSendCode.StateTracking.Back.ColorAngle = 45F;
            this.btnSendCode.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSendCode.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSendCode.StateTracking.Border.ColorAngle = 45F;
            this.btnSendCode.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSendCode.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSendCode.StateTracking.Border.Rounding = 10F;
            this.btnSendCode.StateTracking.Border.Width = 1;
            this.btnSendCode.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSendCode.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.TabIndex = 15;
            this.btnSendCode.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSendCode.Values.Text = "Send Code";
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // txtPassNew
            // 
            this.txtPassNew.ButtonSpecs.Add(this.btnShowHide);
            this.txtPassNew.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtPassNew.CueHint.CueHintText = "Mật khẩu mới";
            this.txtPassNew.CueHint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNew.Location = new System.Drawing.Point(118, 186);
            this.txtPassNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Size = new System.Drawing.Size(286, 33);
            this.txtPassNew.TabIndex = 9;
            // 
            // txtVerified
            // 
            this.txtVerified.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtVerified.CueHint.CueHintText = "Nhập mã xác nhận";
            this.txtVerified.CueHint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerified.Location = new System.Drawing.Point(118, 143);
            this.txtVerified.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVerified.Name = "txtVerified";
            this.txtVerified.Size = new System.Drawing.Size(286, 27);
            this.txtVerified.TabIndex = 11;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Location = new System.Drawing.Point(58, 294);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnConfirm.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnConfirm.OverrideDefault.Back.ColorAngle = 45F;
            this.btnConfirm.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnConfirm.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnConfirm.OverrideDefault.Border.ColorAngle = 45F;
            this.btnConfirm.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnConfirm.OverrideDefault.Border.Rounding = 10F;
            this.btnConfirm.OverrideDefault.Border.Width = 1;
            this.btnConfirm.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnConfirm.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnConfirm.OverrideFocus.Back.ColorAngle = 45F;
            this.btnConfirm.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnConfirm.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnConfirm.OverrideFocus.Border.ColorAngle = 45F;
            this.btnConfirm.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnConfirm.OverrideFocus.Border.Rounding = 10F;
            this.btnConfirm.OverrideFocus.Border.Width = 1;
            this.btnConfirm.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnConfirm.Size = new System.Drawing.Size(173, 43);
            this.btnConfirm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnConfirm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnConfirm.StateCommon.Back.ColorAngle = 45F;
            this.btnConfirm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnConfirm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnConfirm.StateCommon.Border.ColorAngle = 45F;
            this.btnConfirm.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnConfirm.StateCommon.Border.Rounding = 10F;
            this.btnConfirm.StateCommon.Border.Width = 1;
            this.btnConfirm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnConfirm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnConfirm.StatePressed.Back.ColorAngle = 135F;
            this.btnConfirm.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnConfirm.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnConfirm.StatePressed.Border.ColorAngle = 135F;
            this.btnConfirm.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StatePressed.Border.Rounding = 10F;
            this.btnConfirm.StatePressed.Border.Width = 1;
            this.btnConfirm.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnConfirm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnConfirm.StateTracking.Back.ColorAngle = 45F;
            this.btnConfirm.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnConfirm.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnConfirm.StateTracking.Border.ColorAngle = 45F;
            this.btnConfirm.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnConfirm.StateTracking.Border.Rounding = 10F;
            this.btnConfirm.StateTracking.Border.Width = 1;
            this.btnConfirm.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnConfirm.Values.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ptbIconBack
            // 
            this.ptbIconBack.Image = global::Cinema_management.Properties.Resources.iconbackarrow;
            this.ptbIconBack.Location = new System.Drawing.Point(18, 13);
            this.ptbIconBack.Name = "ptbIconBack";
            this.ptbIconBack.Size = new System.Drawing.Size(38, 28);
            this.ptbIconBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbIconBack.TabIndex = 13;
            this.ptbIconBack.TabStop = false;
            this.ptbIconBack.Click += new System.EventHandler(this.ptbIconBack_Click);
            // 
            // ptbLock
            // 
            this.ptbLock.Image = global::Cinema_management.Properties.Resources.iconpass;
            this.ptbLock.Location = new System.Drawing.Point(85, 188);
            this.ptbLock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbLock.Name = "ptbLock";
            this.ptbLock.Size = new System.Drawing.Size(28, 31);
            this.ptbLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLock.TabIndex = 10;
            this.ptbLock.TabStop = false;
            // 
            // btnShowHide
            // 
            this.btnShowHide.Image = global::Cinema_management.Properties.Resources.iconoir__eye;
            this.btnShowHide.UniqueName = "3fb880b079f3444cb04ef0f5a6fd933d";
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // kryptonPictureBox2
            // 
            this.kryptonPictureBox2.Image = global::Cinema_management.Properties.Resources.iconemail;
            this.kryptonPictureBox2.Location = new System.Drawing.Point(85, 98);
            this.kryptonPictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPictureBox2.Name = "kryptonPictureBox2";
            this.kryptonPictureBox2.Size = new System.Drawing.Size(28, 25);
            this.kryptonPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox2.TabIndex = 4;
            this.kryptonPictureBox2.TabStop = false;
            // 
            // UCPasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ptbIconBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtVerified);
            this.Controls.Add(this.ptbLock);
            this.Controls.Add(this.txtPassNew);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.lblEmailExist);
            this.Controls.Add(this.kryptonPictureBox2);
            this.Controls.Add(this.txtEmailConfirm);
            this.Controls.Add(this.kryptonLabel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCPasswordRecovery";
            this.Size = new System.Drawing.Size(489, 360);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIconBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
        private Krypton.Toolkit.KryptonTextBox txtEmailConfirm;
        private Krypton.Toolkit.KryptonLabel lblEmailExist;
        private Krypton.Toolkit.KryptonLabel lblCheck;
        private Krypton.Toolkit.KryptonButton btnSendCode;
        private Krypton.Toolkit.KryptonTextBox txtPassNew;
        private Krypton.Toolkit.KryptonTextBox txtVerified;
        private Krypton.Toolkit.KryptonButton btnConfirm;
        private Krypton.Toolkit.KryptonPictureBox ptbLock;
        private Krypton.Toolkit.ButtonSpecAny btnShowHide;
        private Krypton.Toolkit.KryptonPictureBox ptbIconBack;
    }
}