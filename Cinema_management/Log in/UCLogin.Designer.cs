namespace Cinema_management
{
    partial class UCLogin
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
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            this.llbQuenMK = new Krypton.Toolkit.KryptonLinkLabel();
            this.btnLogin = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(145, 34);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(260, 47);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(80)))), ((int)(((byte)(253)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Welcome Back";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.CueHint.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox1.CueHint.CueHintText = "Tên đăng nhập";
            this.kryptonTextBox1.CueHint.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.Location = new System.Drawing.Point(150, 133);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(287, 31);
            this.kryptonTextBox1.TabIndex = 1;
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.ButtonSpecs.Add(this.buttonSpecAny1);
            this.kryptonTextBox2.CueHint.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox2.CueHint.CueHintText = "Mật khẩu";
            this.kryptonTextBox2.CueHint.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox2.Location = new System.Drawing.Point(150, 186);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(287, 39);
            this.kryptonTextBox2.TabIndex = 1;
            this.kryptonTextBox2.TextChanged += new System.EventHandler(this.kryptonTextBox2_TextChanged);
            // 
            // llbQuenMK
            // 
            this.llbQuenMK.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.llbQuenMK.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline;
            this.llbQuenMK.Location = new System.Drawing.Point(280, 314);
            this.llbQuenMK.Name = "llbQuenMK";
            this.llbQuenMK.Size = new System.Drawing.Size(195, 34);
            this.llbQuenMK.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(80)))), ((int)(((byte)(253)))));
            this.llbQuenMK.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbQuenMK.TabIndex = 3;
            this.llbQuenMK.Values.Text = "Quên mật khẩu?";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(280, 354);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(195, 54);
            this.btnLogin.StateCommon.Border.Rounding = 10F;
            this.btnLogin.StateCommon.Border.Width = 0;
            this.btnLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnLogin.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnLogin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnLogin.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StatePressed.Border.Rounding = 10F;
            this.btnLogin.StatePressed.Border.Width = 0;
            this.btnLogin.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogin.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.btnLogin.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.btnLogin.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateTracking.Border.Rounding = 10F;
            this.btnLogin.StateTracking.Border.Width = 0;
            this.btnLogin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogin.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnLogin.Values.Text = "Log In";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(113, 242);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(324, 31);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Firebrick;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "Vui lòng điền đầy đủ thông tin!";
            // 
            // kryptonPictureBox2
            // 
            this.kryptonPictureBox2.Image = global::Cinema_management.Properties.Resources.mdi__password;
            this.kryptonPictureBox2.Location = new System.Drawing.Point(113, 186);
            this.kryptonPictureBox2.Name = "kryptonPictureBox2";
            this.kryptonPictureBox2.Size = new System.Drawing.Size(31, 39);
            this.kryptonPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox2.TabIndex = 2;
            this.kryptonPictureBox2.TabStop = false;
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = global::Cinema_management.Properties.Resources.material_symbols__person_rounded;
            this.kryptonPictureBox1.Location = new System.Drawing.Point(113, 133);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(31, 31);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox1.TabIndex = 2;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::Cinema_management.Properties.Resources.iconoir__eye;
            this.buttonSpecAny1.UniqueName = "3fb880b079f3444cb04ef0f5a6fd933d";
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.llbQuenMK);
            this.Controls.Add(this.kryptonPictureBox2);
            this.Controls.Add(this.kryptonPictureBox1);
            this.Controls.Add(this.kryptonTextBox2);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(550, 450);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
        private Krypton.Toolkit.KryptonLinkLabel llbQuenMK;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
    }
}
