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
            this.btnConfirm = new Krypton.Toolkit.KryptonButton();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.lblMessage = new Krypton.Toolkit.KryptonWrapLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(115, 112);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OverrideDefault.Back.Color1 = System.Drawing.Color.SeaGreen;
            this.btnConfirm.OverrideDefault.Back.Color2 = System.Drawing.Color.SeaGreen;
            this.btnConfirm.Size = new System.Drawing.Size(122, 33);
            this.btnConfirm.StateCommon.Back.Color1 = System.Drawing.Color.SeaGreen;
            this.btnConfirm.StateCommon.Back.Color2 = System.Drawing.Color.SeaGreen;
            this.btnConfirm.StateCommon.Border.Rounding = 10F;
            this.btnConfirm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.StatePressed.Content.Padding = new System.Windows.Forms.Padding(-1, 3, -1, -1);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnConfirm.Values.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ptbIcon
            // 
            this.ptbIcon.BackColor = System.Drawing.Color.Transparent;
            this.ptbIcon.Location = new System.Drawing.Point(27, 30);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(58, 40);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbIcon.TabIndex = 2;
            this.ptbIcon.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = false;
            this.lblMessage.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            this.lblMessage.Location = new System.Drawing.Point(94, 30);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(271, 40);
            this.lblMessage.Text = "kryptonWrapLabel1";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AlertMessagebox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 134);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.ptbIcon);
            this.Controls.Add(this.btnConfirm);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertMessagebox";
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
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnConfirm;
        private System.Windows.Forms.PictureBox ptbIcon;
        private Krypton.Toolkit.KryptonWrapLabel lblMessage;
    }
}