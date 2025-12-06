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
            this.lbGiaTien = new Krypton.Toolkit.KryptonLabel();
            this.lbTenMon = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroup1.Location = new System.Drawing.Point(0, 0);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.lbGiaTien);
            this.kryptonGroup1.Panel.Controls.Add(this.lbTenMon);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonPictureBox1);
            this.kryptonGroup1.Panel.Padding = new System.Windows.Forms.Padding(20);
            this.kryptonGroup1.Size = new System.Drawing.Size(277, 367);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(141)))));
            this.kryptonGroup1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(141)))));
            this.kryptonGroup1.StateCommon.Border.ColorAngle = 90F;
            this.kryptonGroup1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear33;
            this.kryptonGroup1.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup1.StateCommon.Border.Width = 5;
            this.kryptonGroup1.TabIndex = 0;
            // 
            // lbGiaTien
            // 
            this.lbGiaTien.Location = new System.Drawing.Point(28, 273);
            this.lbGiaTien.Name = "lbGiaTien";
            this.lbGiaTien.Size = new System.Drawing.Size(199, 44);
            this.lbGiaTien.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbGiaTien.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaTien.TabIndex = 1;
            this.lbGiaTien.Values.Text = "100.000 VND";
            // 
            // lbTenMon
            // 
            this.lbTenMon.Location = new System.Drawing.Point(61, 224);
            this.lbTenMon.Name = "lbTenMon";
            this.lbTenMon.Size = new System.Drawing.Size(133, 44);
            this.lbTenMon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbTenMon.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMon.TabIndex = 1;
            this.lbTenMon.Values.Text = "Tên món";
            this.lbTenMon.Click += new System.EventHandler(this.lbTenMon_Click);
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPictureBox1.Location = new System.Drawing.Point(20, 20);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(215, 198);
            this.kryptonPictureBox1.TabIndex = 0;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // UCFoodCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonGroup1);
            this.Margin = new System.Windows.Forms.Padding(30);
            this.MinimumSize = new System.Drawing.Size(277, 367);
            this.Name = "UCFoodCard";
            this.Size = new System.Drawing.Size(277, 367);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonLabel lbGiaTien;
        private Krypton.Toolkit.KryptonLabel lbTenMon;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
    }
}
