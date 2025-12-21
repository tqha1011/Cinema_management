namespace Cinema_management.MessagboxCustom
{
    partial class AlertMessagebox
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
            this.kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.lblMessage = new Krypton.Toolkit.KryptonWrapLabel();
            this.btnConfirm = new Krypton.Toolkit.KryptonButton();
            this.kryptonTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonTableLayoutPanel1
            // 
            this.kryptonTableLayoutPanel1.AutoSize = true;
            this.kryptonTableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonTableLayoutPanel1.ColumnCount = 2;
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.kryptonTableLayoutPanel1.Controls.Add(this.ptbIcon, 0, 0);
            this.kryptonTableLayoutPanel1.Controls.Add(this.lblMessage, 1, 0);
            this.kryptonTableLayoutPanel1.Controls.Add(this.btnConfirm, 0, 1);
            this.kryptonTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            this.kryptonTableLayoutPanel1.RowCount = 2;
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kryptonTableLayoutPanel1.Size = new System.Drawing.Size(334, 76);
            this.kryptonTableLayoutPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonTableLayoutPanel1.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonTableLayoutPanel1.TabIndex = 0;
            // 
            // ptbIcon
            // 
            this.ptbIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ptbIcon.BackColor = System.Drawing.Color.Transparent;
            this.ptbIcon.Location = new System.Drawing.Point(3, 4);
            this.ptbIcon.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(36, 28);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbIcon.TabIndex = 0;
            this.ptbIcon.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            this.lblMessage.Location = new System.Drawing.Point(43, 9);
            this.lblMessage.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(139, 20);
            this.lblMessage.StateCommon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Text = "kryptonWrapLabel1";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.AutoSize = true;
            this.kryptonTableLayoutPanel1.SetColumnSpan(this.btnConfirm, 2);
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(126, 44);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OverrideDefault.Back.Color1 = System.Drawing.Color.SeaGreen;
            this.btnConfirm.OverrideDefault.Back.Color2 = System.Drawing.Color.SeaGreen;
            this.btnConfirm.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.btnConfirm.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.btnConfirm.Size = new System.Drawing.Size(82, 29);
            this.btnConfirm.StateCommon.Back.Color1 = System.Drawing.Color.SeaGreen;
            this.btnConfirm.StateCommon.Back.Color2 = System.Drawing.Color.SeaGreen;
            this.btnConfirm.StateCommon.Border.Rounding = 9F;
            this.btnConfirm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.StatePressed.Content.Padding = new System.Windows.Forms.Padding(-1, 3, -1, -1);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnConfirm.Values.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // AlertMessagebox
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 116);
            this.Controls.Add(this.kryptonTableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertMessagebox";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.StateCommon.Border.Rounding = 12F;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.SeaGreen;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.SeaGreen;
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Thông báo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AlertMessagebox_Load);
            this.kryptonTableLayoutPanel1.ResumeLayout(false);
            this.kryptonTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private System.Windows.Forms.PictureBox ptbIcon;
        private Krypton.Toolkit.KryptonWrapLabel lblMessage;
        private Krypton.Toolkit.KryptonButton btnConfirm;
    }
}