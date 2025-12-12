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
            this.lbTenMon = new Krypton.Toolkit.KryptonLabel();
            this.lbGia = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.SuspendLayout();
            // 
            // lbTenMon
            // 
            this.lbTenMon.Location = new System.Drawing.Point(25, 12);
            this.lbTenMon.Name = "lbTenMon";
            this.lbTenMon.Size = new System.Drawing.Size(215, 50);
            this.lbTenMon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbTenMon.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMon.TabIndex = 2;
            this.lbTenMon.Values.Text = "Bắp Caramel";
            // 
            // lbGia
            // 
            this.lbGia.Location = new System.Drawing.Point(225, 62);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(152, 44);
            this.lbGia.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lbGia.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.TabIndex = 3;
            this.lbGia.Values.Text = "100.000 đ";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(25, 62);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(83, 44);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "SL: 1";
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.AutoSize = false;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(32, 118);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(460, 2);
            this.kryptonBorderEdge1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(141)))));
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // UCHoaDonFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbTenMon);
            this.MinimumSize = new System.Drawing.Size(524, 142);
            this.Name = "UCHoaDonFood";
            this.Size = new System.Drawing.Size(524, 142);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lbTenMon;
        private Krypton.Toolkit.KryptonLabel lbGia;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
    }
}
