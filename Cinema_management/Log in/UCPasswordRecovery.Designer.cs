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
            this.components = new System.ComponentModel.Container();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtEmailConfirm = new Krypton.Toolkit.KryptonTextBox();
            this.lblEmailExist = new Krypton.Toolkit.KryptonLabel();
            this.lblCheck = new Krypton.Toolkit.KryptonLabel();
            this.btnSendCode = new Krypton.Toolkit.KryptonButton();
            this.txtPassNew = new Krypton.Toolkit.KryptonTextBox();
            this.btnShowHide = new Krypton.Toolkit.ButtonSpecAny();
            this.txtVerified = new Krypton.Toolkit.KryptonTextBox();
            this.btnConfirm = new Krypton.Toolkit.KryptonButton();
            this.ptbIconBack = new Krypton.Toolkit.KryptonPictureBox();
            this.ptbLock = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIconBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(106, 34);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(338, 47);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Password Recovery";
            // 
            // txtEmailConfirm
            // 
            this.txtEmailConfirm.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtEmailConfirm.CueHint.CueHintText = "Email";
            this.txtEmailConfirm.CueHint.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailConfirm.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.txtEmailConfirm.Location = new System.Drawing.Point(138, 108);
            this.txtEmailConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailConfirm.Multiline = true;
            this.txtEmailConfirm.Name = "txtEmailConfirm";
            this.txtEmailConfirm.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtEmailConfirm.Size = new System.Drawing.Size(322, 55);
            this.txtEmailConfirm.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtEmailConfirm.StateCommon.Content.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailConfirm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.txtEmailConfirm.TabIndex = 3;
            // 
            // lblEmailExist
            // 
            this.lblEmailExist.Location = new System.Drawing.Point(180, 279);
            this.lblEmailExist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblEmailExist.Name = "lblEmailExist";
            this.lblEmailExist.Size = new System.Drawing.Size(206, 31);
            this.lblEmailExist.StateCommon.ShortText.Color1 = System.Drawing.Color.Firebrick;
            this.lblEmailExist.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailExist.TabIndex = 6;
            this.lblEmailExist.Values.Text = "Email không tồn tại";
            // 
            // lblCheck
            // 
            this.lblCheck.Location = new System.Drawing.Point(135, 318);
            this.lblCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(281, 38);
            this.lblCheck.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.lblCheck.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.TabIndex = 7;
            this.lblCheck.Values.Text = "Vui lòng kiểm tra email";
            // 
            // btnSendCode
            // 
            this.btnSendCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCode.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.btnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.btnSendCode.Location = new System.Drawing.Point(281, 368);
            this.btnSendCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSendCode.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSendCode.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnSendCode.Size = new System.Drawing.Size(195, 54);
            this.btnSendCode.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSendCode.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSendCode.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSendCode.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSendCode.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
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
            this.txtPassNew.CueHint.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNew.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.txtPassNew.Location = new System.Drawing.Point(137, 246);
            this.txtPassNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassNew.Multiline = true;
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtPassNew.Size = new System.Drawing.Size(322, 55);
            this.txtPassNew.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPassNew.StateCommon.Content.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNew.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.txtPassNew.TabIndex = 9;
            // 
            // btnShowHide
            // 
            this.btnShowHide.Image = global::Cinema_management.Properties.Resources.iconoir__eye;
            this.btnShowHide.UniqueName = "3fb880b079f3444cb04ef0f5a6fd933d";
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // txtVerified
            // 
            this.txtVerified.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtVerified.CueHint.CueHintText = "Nhập mã xác nhận";
            this.txtVerified.CueHint.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerified.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.txtVerified.Location = new System.Drawing.Point(137, 176);
            this.txtVerified.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVerified.Multiline = true;
            this.txtVerified.Name = "txtVerified";
            this.txtVerified.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.txtVerified.Size = new System.Drawing.Size(322, 57);
            this.txtVerified.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtVerified.StateCommon.Content.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerified.TabIndex = 11;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.btnConfirm.Location = new System.Drawing.Point(65, 368);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnConfirm.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnConfirm.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnConfirm.Size = new System.Drawing.Size(195, 54);
            this.btnConfirm.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnConfirm.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Nunito", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnConfirm.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Nunito", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnConfirm.Values.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ptbIconBack
            // 
            this.ptbIconBack.Image = global::Cinema_management.Properties.Resources.iconbackarrow;
            this.ptbIconBack.Location = new System.Drawing.Point(20, 16);
            this.ptbIconBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbIconBack.Name = "ptbIconBack";
            this.ptbIconBack.Size = new System.Drawing.Size(43, 35);
            this.ptbIconBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbIconBack.TabIndex = 13;
            this.ptbIconBack.TabStop = false;
            this.ptbIconBack.Click += new System.EventHandler(this.ptbIconBack_Click);
            // 
            // ptbLock
            // 
            this.ptbLock.Image = global::Cinema_management.Properties.Resources.iconpass;
            this.ptbLock.Location = new System.Drawing.Point(100, 246);
            this.ptbLock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbLock.Name = "ptbLock";
            this.ptbLock.Size = new System.Drawing.Size(32, 42);
            this.ptbLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLock.TabIndex = 10;
            this.ptbLock.TabStop = false;
            // 
            // kryptonPictureBox2
            // 
            this.kryptonPictureBox2.Image = global::Cinema_management.Properties.Resources.iconemail;
            this.kryptonPictureBox2.Location = new System.Drawing.Point(91, 108);
            this.kryptonPictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPictureBox2.Name = "kryptonPictureBox2";
            this.kryptonPictureBox2.Size = new System.Drawing.Size(41, 41);
            this.kryptonPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox2.TabIndex = 4;
            this.kryptonPictureBox2.TabStop = false;
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
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.ColorAngle = 60F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Back.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.ColorAngle = 60F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Width = 3;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Back.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Border.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Nunito", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Back.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(136)))), ((int)(((byte)(64)))));
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Border.ColorAngle = 45F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Rounding = 20F;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Nunito", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // UCPasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
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
            this.Size = new System.Drawing.Size(550, 450);
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
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
    }
}