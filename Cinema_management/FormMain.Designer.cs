using System;
using System.Windows.Forms;

namespace Cinema_management
{
    partial class FormMain
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
            this.pnSidebar = new Krypton.Toolkit.KryptonPanel();
            this.lbManagement = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.btnDashboard = new Krypton.Toolkit.KryptonButton();
            this.pnHeader = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.pnContent = new Krypton.Toolkit.KryptonPanel();
            this.pnContentforUC = new Krypton.Toolkit.KryptonPanel();
            this.pnHeaderTheme = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pnSidebar)).BeginInit();
            this.pnSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnHeader)).BeginInit();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnContent)).BeginInit();
            this.pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnContentforUC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnHeaderTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSidebar
            // 
            this.pnSidebar.Controls.Add(this.lbManagement);
            this.pnSidebar.Controls.Add(this.kryptonButton4);
            this.pnSidebar.Controls.Add(this.kryptonButton3);
            this.pnSidebar.Controls.Add(this.kryptonButton2);
            this.pnSidebar.Controls.Add(this.kryptonButton1);
            this.pnSidebar.Controls.Add(this.btnDashboard);
            this.pnSidebar.Controls.Add(this.pnHeader);
            this.pnSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnSidebar.Name = "pnSidebar";
            this.pnSidebar.Size = new System.Drawing.Size(267, 698);
            this.pnSidebar.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnSidebar.StateCommon.Color2 = System.Drawing.Color.White;
            this.pnSidebar.TabIndex = 0;
            // 
            // lbManagement
            // 
            this.lbManagement.Location = new System.Drawing.Point(22, 55);
            this.lbManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbManagement.Name = "lbManagement";
            this.lbManagement.Size = new System.Drawing.Size(174, 30);
            this.lbManagement.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.lbManagement.StateCommon.ShortText.Color2 = System.Drawing.Color.DimGray;
            this.lbManagement.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManagement.TabIndex = 2;
            this.lbManagement.Values.Text = "MANAGEMENT";
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(22, 339);
            this.kryptonButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton4.Size = new System.Drawing.Size(222, 37);
            this.kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton4.StateCommon.Border.Rounding = 10F;
            this.kryptonButton4.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(153)))));
            this.kryptonButton4.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(153)))));
            this.kryptonButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.kryptonButton4.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.kryptonButton4.StatePressed.Border.Rounding = 10F;
            this.kryptonButton4.StatePressed.Border.Width = 1;
            this.kryptonButton4.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton4.TabIndex = 1;
            this.kryptonButton4.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton4.Values.Image = global::Cinema_management.Properties.Resources.tabler__ticket;
            this.kryptonButton4.Values.Text = "Tickets";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(22, 282);
            this.kryptonButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.Size = new System.Drawing.Size(222, 37);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Border.Rounding = 10F;
            this.kryptonButton3.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(153)))));
            this.kryptonButton3.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(153)))));
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.kryptonButton3.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.kryptonButton3.StatePressed.Border.Rounding = 10F;
            this.kryptonButton3.StatePressed.Border.Width = 1;
            this.kryptonButton3.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.TabIndex = 1;
            this.kryptonButton3.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton3.Values.Image = global::Cinema_management.Properties.Resources.uil__clock;
            this.kryptonButton3.Values.Text = "Showtimes";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(22, 222);
            this.kryptonButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.Size = new System.Drawing.Size(222, 37);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Border.Rounding = 10F;
            this.kryptonButton2.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(153)))));
            this.kryptonButton2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(153)))));
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.kryptonButton2.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.kryptonButton2.StatePressed.Border.Rounding = 10F;
            this.kryptonButton2.StatePressed.Border.Width = 1;
            this.kryptonButton2.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton2.Values.Image = global::Cinema_management.Properties.Resources.ic__baseline_tv;
            this.kryptonButton2.Values.Text = "Staffs";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(22, 162);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.Size = new System.Drawing.Size(222, 37);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Border.Rounding = 10F;
            this.kryptonButton1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(153)))));
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(153)))));
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.kryptonButton1.StatePressed.Border.Rounding = 10F;
            this.kryptonButton1.StatePressed.Border.Width = 1;
            this.kryptonButton1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Image = global::Cinema_management.Properties.Resources.jam__movie;
            this.kryptonButton1.Values.Text = "Movies";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(22, 105);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnDashboard.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnDashboard.Size = new System.Drawing.Size(222, 37);
            this.btnDashboard.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnDashboard.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnDashboard.StateCommon.Border.Rounding = 10F;
            this.btnDashboard.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(153)))));
            this.btnDashboard.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(153)))));
            this.btnDashboard.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.btnDashboard.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(19)))));
            this.btnDashboard.StatePressed.Border.Rounding = 10F;
            this.btnDashboard.StatePressed.Border.Width = 1;
            this.btnDashboard.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDashboard.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDashboard.Values.Image = global::Cinema_management.Properties.Resources.hugeicons__analytics_03;
            this.btnDashboard.Values.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.kryptonLabel1);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(267, 40);
            this.pnHeader.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnHeader.StateCommon.Color2 = System.Drawing.Color.White;
            this.pnHeader.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 10);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(222, 34);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Image = global::Cinema_management.Properties.Resources.tabler__movie;
            this.kryptonLabel1.Values.Text = "Cinema Manager";
            // 
            // pnContent
            // 
            this.pnContent.Controls.Add(this.pnContentforUC);
            this.pnContent.Controls.Add(this.pnHeaderTheme);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(267, 0);
            this.pnContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1417, 698);
            this.pnContent.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnContent.StateCommon.Color2 = System.Drawing.Color.White;
            this.pnContent.TabIndex = 1;
            this.pnContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContent_Paint);
            // 
            // pnContentforUC
            // 
            this.pnContentforUC.AutoScroll = true;
            this.pnContentforUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContentforUC.Location = new System.Drawing.Point(0, 40);
            this.pnContentforUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContentforUC.Name = "pnContentforUC";
            this.pnContentforUC.Size = new System.Drawing.Size(1417, 658);
            this.pnContentforUC.TabIndex = 1;
            // 
            // pnHeaderTheme
            // 
            this.pnHeaderTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeaderTheme.Location = new System.Drawing.Point(0, 0);
            this.pnHeaderTheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnHeaderTheme.Name = "pnHeaderTheme";
            this.pnHeaderTheme.Size = new System.Drawing.Size(1417, 40);
            this.pnHeaderTheme.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnHeaderTheme.StateCommon.Color2 = System.Drawing.Color.White;
            this.pnHeaderTheme.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 698);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnSidebar)).EndInit();
            this.pnSidebar.ResumeLayout(false);
            this.pnSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnHeader)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnContent)).EndInit();
            this.pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnContentforUC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnHeaderTheme)).EndInit();
            this.ResumeLayout(false);

        }

        private void pnContent_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnSidebar;
        private Krypton.Toolkit.KryptonPanel pnHeader;
        private Krypton.Toolkit.KryptonPanel pnContent;
        private Krypton.Toolkit.KryptonPanel pnHeaderTheme;
        private Krypton.Toolkit.KryptonLabel lbManagement;
        private Krypton.Toolkit.KryptonButton btnDashboard;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel pnContentforUC;
    }
}