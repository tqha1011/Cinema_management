namespace Cinema_management.MessageboxCustom
{
    partial class Warning
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
            this.ptbWarning = new System.Windows.Forms.PictureBox();
            this.btnOk = new Krypton.Toolkit.KryptonButton();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.lblmsg = new Krypton.Toolkit.KryptonWrapLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbWarning
            // 
            this.ptbWarning.Location = new System.Drawing.Point(15, 35);
            this.ptbWarning.Name = "ptbWarning";
            this.ptbWarning.Size = new System.Drawing.Size(58, 40);
            this.ptbWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbWarning.TabIndex = 0;
            this.ptbWarning.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(55, 107);
            this.btnOk.Name = "btnOk";
            this.btnOk.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btnOk.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btnOk.Size = new System.Drawing.Size(90, 25);
            this.btnOk.StateCommon.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btnOk.StateCommon.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btnOk.StateCommon.Border.Rounding = 8F;
            this.btnOk.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.TabIndex = 1;
            this.btnOk.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnOk.Values.Text = "Đồng ý";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(182, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OverrideDefault.Back.Color1 = System.Drawing.Color.SlateGray;
            this.btnCancel.OverrideDefault.Back.Color2 = System.Drawing.Color.SlateGray;
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.StateCommon.Back.Color1 = System.Drawing.Color.SlateGray;
            this.btnCancel.StateCommon.Back.Color2 = System.Drawing.Color.SlateGray;
            this.btnCancel.StateCommon.Border.Rounding = 8F;
            this.btnCancel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Text = "Không";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = false;
            this.lblmsg.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            this.lblmsg.Location = new System.Drawing.Point(79, 35);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(282, 40);
            this.lblmsg.Text = "kryptonWrapLabel1";
            // 
            // Warning
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 123);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ptbWarning);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Warning";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.StateCommon.Border.Rounding = 12F;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Cảnh báo";
            this.Load += new System.EventHandler(this.Warning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbWarning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbWarning;
        private Krypton.Toolkit.KryptonButton btnOk;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonWrapLabel lblmsg;
    }
}