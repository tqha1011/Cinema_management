namespace Cinema_management
{
    partial class UCFoodCard
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
            this.lblSoLuong = new Krypton.Toolkit.KryptonLabel();
            this.lblGia = new Krypton.Toolkit.KryptonLabel();
            this.lblTenMon = new Krypton.Toolkit.KryptonWrapLabel();
            this.ptbMonAn = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.kryptonTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonTableLayoutPanel1);
            this.kryptonGroup1.Panel.Controls.Add(this.ptbMonAn);
            this.kryptonGroup1.Panel.Padding = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.kryptonGroup1.Size = new System.Drawing.Size(267, 311);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(141)))));
            this.kryptonGroup1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(141)))));
            this.kryptonGroup1.StateCommon.Border.ColorAngle = 90F;
            this.kryptonGroup1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear33;
            this.kryptonGroup1.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup1.StateCommon.Border.Width = 5;
            this.kryptonGroup1.TabIndex = 0;
            // 
            // kryptonTableLayoutPanel1
            // 
            this.kryptonTableLayoutPanel1.ColumnCount = 2;
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel1.Controls.Add(this.lblSoLuong, 0, 1);
            this.kryptonTableLayoutPanel1.Controls.Add(this.lblGia, 1, 1);
            this.kryptonTableLayoutPanel1.Controls.Add(this.lblTenMon, 0, 0);
            this.kryptonTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel1.Location = new System.Drawing.Point(18, 174);
            this.kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            this.kryptonTableLayoutPanel1.RowCount = 2;
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel1.Size = new System.Drawing.Size(209, 99);
            this.kryptonTableLayoutPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonTableLayoutPanel1.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoLuong.Location = new System.Drawing.Point(3, 69);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(89, 27);
            this.lblSoLuong.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblSoLuong.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.lblSoLuong.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Values.Text = "SL:  100";
            // 
            // lblGia
            // 
            this.lblGia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGia.Location = new System.Drawing.Point(145, 69);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(61, 27);
            this.lblGia.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblGia.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.TabIndex = 2;
            this.lblGia.Values.Image = global::Cinema_management.Properties.Resources.iconmoney_resize;
            this.lblGia.Values.Text = "1đ";
            // 
            // lblTenMon
            // 
            this.kryptonTableLayoutPanel1.SetColumnSpan(this.lblTenMon, 2);
            this.lblTenMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenMon.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            this.lblTenMon.Location = new System.Drawing.Point(3, 0);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(203, 66);
            this.lblTenMon.StateCommon.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.lblTenMon.Text = "Combo bắp vị phô mai + nước";
            this.lblTenMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbMonAn
            // 
            this.ptbMonAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbMonAn.Location = new System.Drawing.Point(18, 16);
            this.ptbMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbMonAn.Name = "ptbMonAn";
            this.ptbMonAn.Size = new System.Drawing.Size(209, 158);
            this.ptbMonAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMonAn.TabIndex = 0;
            this.ptbMonAn.TabStop = false;
            // 
            // UCFoodCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonGroup1);
            this.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.MinimumSize = new System.Drawing.Size(246, 294);
            this.Name = "UCFoodCard";
            this.Size = new System.Drawing.Size(267, 311);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.kryptonTableLayoutPanel1.ResumeLayout(false);
            this.kryptonTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonPictureBox ptbMonAn;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel lblSoLuong;
        private Krypton.Toolkit.KryptonLabel lblGia;
        private Krypton.Toolkit.KryptonWrapLabel lblTenMon;
    }
}
