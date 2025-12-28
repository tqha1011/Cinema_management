namespace Cinema_management.Ticket_Booking
{
    partial class PaymentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.tableQR = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.ptbQR = new System.Windows.Forms.PictureBox();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.tableQR.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // tableQR
            // 
            this.tableQR.BackColor = System.Drawing.Color.Transparent;
            this.tableQR.ColumnCount = 1;
            this.tableQR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableQR.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableQR.Controls.Add(this.ptbQR, 0, 1);
            this.tableQR.Controls.Add(this.kryptonButton1, 0, 2);
            this.tableQR.Location = new System.Drawing.Point(82, 19);
            this.tableQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableQR.Name = "tableQR";
            this.tableQR.RowCount = 3;
            this.tableQR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableQR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableQR.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableQR.Size = new System.Drawing.Size(334, 522);
            this.tableQR.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.kryptonLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.kryptonLabel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(326, 216);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel1.Location = new System.Drawing.Point(4, 5);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(318, 98);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Blue;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "SCAN";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel2.Location = new System.Drawing.Point(4, 113);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(318, 98);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Blue;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "TO PAY";
            // 
            // ptbQR
            // 
            this.ptbQR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbQR.Location = new System.Drawing.Point(4, 231);
            this.ptbQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbQR.Name = "ptbQR";
            this.ptbQR.Size = new System.Drawing.Size(326, 216);
            this.ptbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbQR.TabIndex = 1;
            this.ptbQR.TabStop = false;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonButton1.AutoSize = true;
            this.kryptonButton1.Location = new System.Drawing.Point(98, 468);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(4, 16, 4, 5);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.Blue;
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.kryptonButton1.OverrideFocus.Back.Color1 = System.Drawing.Color.Blue;
            this.kryptonButton1.OverrideFocus.Back.Color2 = System.Drawing.Color.Blue;
            this.kryptonButton1.Size = new System.Drawing.Size(138, 48);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.kryptonButton1.StateCommon.Border.Rounding = 7F;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 2;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "Xác nhận";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 550);
            this.CloseBox = false;
            this.ControlBox = false;
            this.Controls.Add(this.tableQR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.StateCommon.Back.ColorAngle = 90F;
            this.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.StateCommon.Border.Rounding = 12F;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.White;
            this.TransparencyKey = System.Drawing.Color.Plum;
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.tableQR.ResumeLayout(false);
            this.tableQR.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableQR;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.PictureBox ptbQR;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}