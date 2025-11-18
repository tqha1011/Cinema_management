namespace Cinema_management.Staff_Management
{
    partial class AddStaff_popup
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
            this.panelHost = new Krypton.Toolkit.KryptonPanel();
            this.panelChu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.panelHost)).BeginInit();
            this.panelHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHost
            // 
            this.panelHost.Controls.Add(this.panelChu);
            this.panelHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHost.Location = new System.Drawing.Point(10, 10);
            this.panelHost.Name = "panelHost";
            this.panelHost.Size = new System.Drawing.Size(646, 735);
            this.panelHost.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelHost.StateCommon.Color2 = System.Drawing.Color.White;
            this.panelHost.TabIndex = 0;
            // 
            // panelChu
            // 
            this.panelChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChu.Location = new System.Drawing.Point(0, 0);
            this.panelChu.Name = "panelChu";
            this.panelChu.Size = new System.Drawing.Size(646, 735);
            this.panelChu.TabIndex = 0;
            // 
            // AddStaff_popup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 755);
            this.CloseBox = false;
            this.ControlBox = false;
            this.Controls.Add(this.panelHost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStaff_popup";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.Rounding = 10F;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.AddStaff_popup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelHost)).EndInit();
            this.panelHost.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel panelHost;
        private System.Windows.Forms.Panel panelChu;
    }
}