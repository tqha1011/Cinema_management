namespace Cinema_management.Ticket_Booking
{
    partial class UCHoaDonFood
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
            this.lblGia = new Krypton.Toolkit.KryptonLabel();
            this.lblSoLuong = new Krypton.Toolkit.KryptonLabel();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.lblTenMon = new Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGia
            // 
            this.lblGia.Location = new System.Drawing.Point(220, 79);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(131, 38);
            this.lblGia.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lblGia.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.TabIndex = 3;
            this.lblGia.Values.Text = "100.000 đ";
            this.lblGia.Click += new System.EventHandler(this.lblGia_Click);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(20, 79);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(72, 38);
            this.lblSoLuong.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lblSoLuong.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Values.Text = "SL: 1";
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.AutoSize = false;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(32, 122);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(460, 2);
            this.kryptonBorderEdge1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(141)))));
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = false;
            this.lblTenMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenMon.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            this.lblTenMon.Location = new System.Drawing.Point(20, 5);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(484, 77);
            this.lblTenMon.StateCommon.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTenMon.Text = "Tên Món";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lblTenMon);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.kryptonPanel1.Size = new System.Drawing.Size(524, 82);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 5;
            // 
            // UCHoaDonFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblGia);
            this.MinimumSize = new System.Drawing.Size(524, 142);
            this.Name = "UCHoaDonFood";
            this.Size = new System.Drawing.Size(524, 142);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel lblGia;
        private Krypton.Toolkit.KryptonLabel lblSoLuong;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonWrapLabel lblTenMon;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}
