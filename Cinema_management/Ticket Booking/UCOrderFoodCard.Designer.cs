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
            this.kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.lblGia = new Krypton.Toolkit.KryptonLabel();
            this.lblTenMon = new Krypton.Toolkit.KryptonWrapLabel();
            this.picPoster = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.kryptonTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonTableLayoutPanel1);
            this.kryptonGroup1.Panel.Controls.Add(this.picPoster);
            this.kryptonGroup1.Panel.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.kryptonGroup1.Size = new System.Drawing.Size(268, 385);
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
            // kryptonTableLayoutPanel1
            // 
            this.kryptonTableLayoutPanel1.ColumnCount = 1;
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel1.Controls.Add(this.lblGia, 0, 1);
            this.kryptonTableLayoutPanel1.Controls.Add(this.lblTenMon, 0, 0);
            this.kryptonTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel1.Location = new System.Drawing.Point(20, 219);
            this.kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            this.kryptonTableLayoutPanel1.RowCount = 2;
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.kryptonTableLayoutPanel1.Size = new System.Drawing.Size(206, 134);
            this.kryptonTableLayoutPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonTableLayoutPanel1.TabIndex = 4;
            // 
            // lblGia
            // 
            this.lblGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGia.Location = new System.Drawing.Point(26, 92);
            this.lblGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(154, 38);
            this.lblGia.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblGia.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.TabIndex = 3;
            this.lblGia.Values.Image = global::Cinema_management.Properties.Resources.iconmoney_resize;
            this.lblGia.Values.Text = "100.000 đ";
            // 
            // lblTenMon
            // 
            this.lblTenMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenMon.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            this.lblTenMon.Location = new System.Drawing.Point(3, 0);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(200, 88);
            this.lblTenMon.StateCommon.Font = new System.Drawing.Font("Nunito", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.lblTenMon.Text = "Combo bắp vị phô mai + nước";
            this.lblTenMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPoster
            // 
            this.picPoster.Dock = System.Windows.Forms.DockStyle.Top;
            this.picPoster.Location = new System.Drawing.Point(20, 20);
            this.picPoster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(206, 199);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPoster.TabIndex = 1;
            this.picPoster.TabStop = false;
            // 
            // UCOrderFoodCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonGroup1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.MinimumSize = new System.Drawing.Size(268, 385);
            this.Name = "UCOrderFoodCard";
            this.Size = new System.Drawing.Size(268, 385);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.kryptonTableLayoutPanel1.ResumeLayout(false);
            this.kryptonTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonPictureBox picPoster;
        private Krypton.Toolkit.KryptonLabel lblGia;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Krypton.Toolkit.KryptonWrapLabel lblTenMon;
    }
}
