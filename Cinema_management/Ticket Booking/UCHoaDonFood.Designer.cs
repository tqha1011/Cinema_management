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
            this.lblTenMon = new Krypton.Toolkit.KryptonLabel();
            this.lblGia = new Krypton.Toolkit.KryptonLabel();
            this.lblSoLuong = new Krypton.Toolkit.KryptonLabel();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.SuspendLayout();
            // 
            // lblTenMon
            // 
            this.lblTenMon.Location = new System.Drawing.Point(33, 15);
            this.lblTenMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(285, 66);
            this.lblTenMon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTenMon.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.TabIndex = 2;
            this.lblTenMon.Values.Text = "Bắp Caramel";
            // 
            // lblGia
            // 
            this.lblGia.Location = new System.Drawing.Point(300, 78);
            this.lblGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(200, 58);
            this.lblGia.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lblGia.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.TabIndex = 3;
            this.lblGia.Values.Text = "100.000 đ";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(33, 78);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(108, 58);
            this.lblSoLuong.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lblSoLuong.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Values.Text = "SL: 1";
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.AutoSize = false;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(43, 148);
            this.kryptonBorderEdge1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(613, 2);
            this.kryptonBorderEdge1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(141)))));
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // UCHoaDonFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTenMon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(699, 178);
            this.Name = "UCHoaDonFood";
            this.Size = new System.Drawing.Size(699, 178);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTenMon;
        private Krypton.Toolkit.KryptonLabel lblGia;
        private Krypton.Toolkit.KryptonLabel lblSoLuong;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
    }
}
