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
            this.addStaff1 = new Cinema_management.AddStaff();
            ((System.ComponentModel.ISupportInitialize)(this.panelHost)).BeginInit();
            this.panelHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHost
            // 
            this.panelHost.Controls.Add(this.addStaff1);
            this.panelHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHost.Location = new System.Drawing.Point(10, 10);
            this.panelHost.Name = "panelHost";
            this.panelHost.Size = new System.Drawing.Size(677, 599);
            this.panelHost.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelHost.StateCommon.Color2 = System.Drawing.Color.White;
            this.panelHost.TabIndex = 0;
            // 
            // addStaff1
            // 
            this.addStaff1.BackColor = System.Drawing.Color.White;
            this.addStaff1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStaff1.Location = new System.Drawing.Point(0, 0);
            this.addStaff1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addStaff1.Name = "addStaff1";
            this.addStaff1.Size = new System.Drawing.Size(677, 599);
            this.addStaff1.TabIndex = 0;
            // 
            // AddStaff_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 619);
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
            ((System.ComponentModel.ISupportInitialize)(this.panelHost)).EndInit();
            this.panelHost.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel panelHost;
        private AddStaff addStaff1;
    }
}