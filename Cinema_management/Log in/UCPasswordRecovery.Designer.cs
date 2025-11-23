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
            this.kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.btnSendCode = new Krypton.Toolkit.KryptonButton();
            this.kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(106, 34);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(338, 47);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(80)))), ((int)(((byte)(253)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Password Recovery";
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.CueHint.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox2.CueHint.CueHintText = "Tên đăng nhập hoặc email";
            this.kryptonTextBox2.CueHint.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox2.Location = new System.Drawing.Point(133, 122);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(322, 31);
            this.kryptonTextBox2.TabIndex = 3;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(152, 224);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(303, 31);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Firebrick;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 6;
            this.kryptonLabel2.Values.Text = "Tên đăng nhập không tồn tại";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.AutoSize = false;
            this.kryptonLabel3.Location = new System.Drawing.Point(92, 273);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(377, 31);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(80)))), ((int)(((byte)(253)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 7;
            this.kryptonLabel3.Values.Text = "Vui lòng kiểm tra hộp thư email của bạn để nhận mã xác nhận";
            // 
            // btnSendCode
            // 
            this.btnSendCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCode.Location = new System.Drawing.Point(280, 354);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(195, 54);
            this.btnSendCode.StateCommon.Border.Rounding = 10F;
            this.btnSendCode.StateCommon.Border.Width = 0;
            this.btnSendCode.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSendCode.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnSendCode.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnSendCode.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnSendCode.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSendCode.StatePressed.Border.Rounding = 10F;
            this.btnSendCode.StatePressed.Border.Width = 0;
            this.btnSendCode.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSendCode.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.btnSendCode.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.btnSendCode.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSendCode.StateTracking.Border.Rounding = 10F;
            this.btnSendCode.StateTracking.Border.Width = 0;
            this.btnSendCode.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSendCode.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.TabIndex = 8;
            this.btnSendCode.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSendCode.Values.Text = "Send Code";
            // 
            // kryptonPictureBox2
            // 
            this.kryptonPictureBox2.Image = global::Cinema_management.Properties.Resources.material_symbols__mail_rounded;
            this.kryptonPictureBox2.Location = new System.Drawing.Point(96, 122);
            this.kryptonPictureBox2.Name = "kryptonPictureBox2";
            this.kryptonPictureBox2.Size = new System.Drawing.Size(31, 31);
            this.kryptonPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox2.TabIndex = 4;
            this.kryptonPictureBox2.TabStop = false;
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = global::Cinema_management.Properties.Resources.mdi__password;
            this.kryptonPictureBox1.Location = new System.Drawing.Point(96, 168);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(31, 39);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox1.TabIndex = 10;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.ButtonSpecs.Add(this.buttonSpecAny1);
            this.kryptonTextBox1.CueHint.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox1.CueHint.CueHintText = "Mật khẩu mới";
            this.kryptonTextBox1.CueHint.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.Location = new System.Drawing.Point(133, 168);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(322, 39);
            this.kryptonTextBox1.TabIndex = 9;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::Cinema_management.Properties.Resources.iconoir__eye;
            this.buttonSpecAny1.UniqueName = "3fb880b079f3444cb04ef0f5a6fd933d";
            // 
            // UCPasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonPictureBox1);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonPictureBox2);
            this.Controls.Add(this.kryptonTextBox2);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "UCPasswordRecovery";
            this.Size = new System.Drawing.Size(550, 450);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton btnSendCode;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
    }
}
