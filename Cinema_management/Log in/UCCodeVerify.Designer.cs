namespace Cinema_management
{
    partial class UCCodeVerify
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
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            this.btnVerify = new Krypton.Toolkit.KryptonButton();
            this.kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(105, 31);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(338, 47);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Password Recovery";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.AutoSize = false;
            this.kryptonLabel3.Location = new System.Drawing.Point(65, 110);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(421, 31);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(90)))), ((int)(((byte)(48)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 8;
            this.kryptonLabel3.Values.Text = "Mã xác nhận đã được gửi đến Email:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.AutoSize = false;
            this.kryptonLabel2.Location = new System.Drawing.Point(87, 147);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(377, 31);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(90)))), ((int)(((byte)(48)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 9;
            this.kryptonLabel2.Values.Text = "blablabla@gmail.com";
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.CueHint.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox2.CueHint.CueHintText = "Mã xác nhận";
            this.kryptonTextBox2.CueHint.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox2.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.kryptonTextBox2.Location = new System.Drawing.Point(136, 210);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonTextBox2.Size = new System.Drawing.Size(315, 57);
            this.kryptonTextBox2.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonTextBox2.StateCommon.Content.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox2.TabIndex = 10;
            // 
            // kryptonPictureBox2
            // 
            this.kryptonPictureBox2.Image = global::Cinema_management.Properties.Resources.mdi__password;
            this.kryptonPictureBox2.Location = new System.Drawing.Point(78, 219);
            this.kryptonPictureBox2.Name = "kryptonPictureBox2";
            this.kryptonPictureBox2.Size = new System.Drawing.Size(48, 38);
            this.kryptonPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox2.TabIndex = 11;
            this.kryptonPictureBox2.TabStop = false;
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerify.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            this.btnVerify.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.btnVerify.Location = new System.Drawing.Point(280, 341);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnVerify.Size = new System.Drawing.Size(195, 54);
            this.btnVerify.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnVerify.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVerify.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnVerify.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Nunito", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVerify.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnVerify.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Nunito", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.TabIndex = 12;
            this.btnVerify.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnVerify.Values.Text = "Verify";
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
            // UCCodeVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.kryptonPictureBox2);
            this.Controls.Add(this.kryptonTextBox2);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "UCCodeVerify";
            this.Size = new System.Drawing.Size(550, 450);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonButton btnVerify;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
    }
}
