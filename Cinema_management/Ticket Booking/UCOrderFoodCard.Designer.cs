namespace Cinema_management
{
    partial class UCOrderFoodCard
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
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.lblGia = new Krypton.Toolkit.KryptonLabel();
            this.lblTenMon = new Krypton.Toolkit.KryptonLabel();
            this.picPoster = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.lblGia);
            this.kryptonGroup1.Panel.Controls.Add(this.lblTenMon);
            this.kryptonGroup1.Panel.Controls.Add(this.picPoster);
            this.kryptonGroup1.Panel.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.kryptonGroup1.Size = new System.Drawing.Size(373, 504);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(141)))));
            this.kryptonGroup1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonGroup1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonGroup1.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup1.StateCommon.Border.Width = 5;
            this.kryptonGroup1.TabIndex = 0;
            // 
            // lblGia
            // 
            this.lblGia.Location = new System.Drawing.Point(71, 339);
            this.lblGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(200, 58);
            this.lblGia.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblGia.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.TabIndex = 3;
            this.lblGia.Values.Text = "100.000 đ";
            // 
            // lblTenMon
            // 
            this.lblTenMon.Location = new System.Drawing.Point(84, 280);
            this.lblTenMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(175, 58);
            this.lblTenMon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTenMon.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.TabIndex = 2;
            this.lblTenMon.Values.Text = "Tên món";
            // 
            // picPoster
            // 
            this.picPoster.Dock = System.Windows.Forms.DockStyle.Top;
            this.picPoster.Location = new System.Drawing.Point(27, 25);
            this.picPoster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(297, 248);
            this.picPoster.TabIndex = 1;
            this.picPoster.TabStop = false;
            // 
            // UCOrderFoodCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonGroup1);
            this.Margin = new System.Windows.Forms.Padding(40, 38, 40, 38);
            this.MinimumSize = new System.Drawing.Size(373, 504);
            this.Name = "UCOrderFoodCard";
            this.Size = new System.Drawing.Size(373, 504);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonPictureBox picPoster;
        private Krypton.Toolkit.KryptonLabel lblTenMon;
        private Krypton.Toolkit.KryptonLabel lblGia;
    }
}
