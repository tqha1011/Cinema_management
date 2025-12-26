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
            this.components = new System.ComponentModel.Container();
            this.pnSidebar = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnLogout = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.btnDashboard = new Krypton.Toolkit.KryptonButton();
            this.pnContent = new Krypton.Toolkit.KryptonPanel();
            this.pnContentforUC = new Krypton.Toolkit.KryptonPanel();
            this.kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnSidebar)).BeginInit();
            this.pnSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnContent)).BeginInit();
            this.pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnContentforUC)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSidebar
            // 
            this.pnSidebar.Controls.Add(this.kryptonLabel1);
            this.pnSidebar.Controls.Add(this.btnLogout);
            this.pnSidebar.Controls.Add(this.kryptonButton6);
            this.pnSidebar.Controls.Add(this.kryptonButton5);
            this.pnSidebar.Controls.Add(this.kryptonButton4);
            this.pnSidebar.Controls.Add(this.kryptonButton3);
            this.pnSidebar.Controls.Add(this.kryptonButton2);
            this.pnSidebar.Controls.Add(this.kryptonButton1);
            this.pnSidebar.Controls.Add(this.btnDashboard);
            this.pnSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnSidebar.Name = "pnSidebar";
            this.pnSidebar.Padding = new System.Windows.Forms.Padding(20);
            this.pnSidebar.Size = new System.Drawing.Size(439, 829);
            this.pnSidebar.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnSidebar.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 32);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(416, 55);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Gordita", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Image = global::Cinema_management.Properties.Resources.icon_park_solid__movie;
            this.kryptonLabel1.Values.Text = "CINEMA MANAGER";
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Location = new System.Drawing.Point(20, 739);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnLogout.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnLogout.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnLogout.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnLogout.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnLogout.Size = new System.Drawing.Size(399, 70);
            this.btnLogout.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnLogout.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnLogout.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnLogout.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnLogout.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogout.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogout.StateCommon.Border.Rounding = 25F;
            this.btnLogout.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnLogout.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.btnLogout.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.btnLogout.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogout.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogout.StatePressed.Border.Rounding = 25F;
            this.btnLogout.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogout.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLogout.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.btnLogout.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnLogout.StateTracking.Back.ColorAngle = 45F;
            this.btnLogout.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnLogout.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogout.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnLogout.Values.Image = global::Cinema_management.Properties.Resources.line_md__logout;
            this.btnLogout.Values.ImageStates.ImageCheckedNormal = null;
            this.btnLogout.Values.ImageStates.ImageCheckedPressed = null;
            this.btnLogout.Values.ImageStates.ImageCheckedTracking = null;
            this.btnLogout.Values.ImageStates.ImagePressed = global::Cinema_management.Properties.Resources.line_md__logout__1_1;
            this.btnLogout.Values.ImageStates.ImageTracking = global::Cinema_management.Properties.Resources.line_md__logout__1_;
            this.btnLogout.Values.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.kryptonButton5_Click);
            // 
            // kryptonButton6
            // 
            this.kryptonButton6.Location = new System.Drawing.Point(41, 537);
            this.kryptonButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton6.Name = "kryptonButton6";
            this.kryptonButton6.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton6.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton6.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton6.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton6.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton6.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton6.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton6.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton6.OverrideFocus.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton6.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton6.Size = new System.Drawing.Size(350, 70);
            this.kryptonButton6.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton6.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton6.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton6.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton6.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton6.StateCommon.Border.Rounding = 25F;
            this.kryptonButton6.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton6.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton6.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton6.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton6.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton6.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton6.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton6.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton6.StatePressed.Border.Rounding = 25F;
            this.kryptonButton6.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton6.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton6.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton6.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton6.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton6.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonButton6.TabIndex = 1;
            this.kryptonButton6.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton6.Values.Image = global::Cinema_management.Properties.Resources.lucide__popcorn;
            this.kryptonButton6.Values.Text = "Food n Beverage";
            this.kryptonButton6.Click += new System.EventHandler(this.kryptonButton6_Click);
            // 
            // kryptonButton5
            // 
            this.kryptonButton5.Location = new System.Drawing.Point(41, 645);
            this.kryptonButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton5.Name = "kryptonButton5";
            this.kryptonButton5.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton5.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton5.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton5.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton5.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton5.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton5.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton5.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton5.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton5.OverrideFocus.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton5.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton5.Size = new System.Drawing.Size(350, 70);
            this.kryptonButton5.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton5.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton5.StateCommon.Border.Rounding = 25F;
            this.kryptonButton5.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton5.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton5.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton5.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton5.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton5.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton5.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton5.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton5.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton5.StatePressed.Border.Rounding = 25F;
            this.kryptonButton5.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton5.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton5.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton5.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton5.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton5.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonButton5.TabIndex = 1;
            this.kryptonButton5.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton5.Values.Image = global::Cinema_management.Properties.Resources.clarity__analytics_solid;
            this.kryptonButton5.Values.Text = "Statistic";
            this.kryptonButton5.Click += new System.EventHandler(this.kryptonButton5_Click_1);
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(41, 757);
            this.kryptonButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton4.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton4.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton4.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton4.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton4.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton4.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton4.OverrideFocus.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton4.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.Size = new System.Drawing.Size(350, 70);
            this.kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton4.StateCommon.Border.Rounding = 25F;
            this.kryptonButton4.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton4.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton4.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton4.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton4.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton4.StatePressed.Border.Rounding = 25F;
            this.kryptonButton4.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton4.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton4.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton4.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton4.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonButton4.TabIndex = 1;
            this.kryptonButton4.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton4.Values.Image = global::Cinema_management.Properties.Resources.mingcute__ticket_fill1;
            this.kryptonButton4.Values.Text = "Now Showing";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(41, 436);
            this.kryptonButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton3.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton3.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton3.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton3.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton3.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton3.OverrideFocus.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.Size = new System.Drawing.Size(350, 70);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Rounding = 25F;
            this.kryptonButton3.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton3.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton3.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton3.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton3.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton3.StatePressed.Border.Rounding = 25F;
            this.kryptonButton3.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton3.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton3.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton3.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonButton3.TabIndex = 1;
            this.kryptonButton3.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton3.Values.Image = global::Cinema_management.Properties.Resources.tdesign__time_filled;
            this.kryptonButton3.Values.Text = "Showtimes";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(41, 326);
            this.kryptonButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton2.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton2.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton2.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton2.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton2.OverrideFocus.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton2.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.Size = new System.Drawing.Size(350, 70);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.StateCommon.Border.Rounding = 25F;
            this.kryptonButton2.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton2.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton2.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton2.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton2.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.StatePressed.Border.Rounding = 25F;
            this.kryptonButton2.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton2.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton2.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton2.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton2.Values.Image = global::Cinema_management.Properties.Resources.material_symbols__person_rounded__1_;
            this.kryptonButton2.Values.Text = "Staffs";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(41, 229);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton1.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton1.OverrideFocus.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.Size = new System.Drawing.Size(350, 70);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Rounding = 25F;
            this.kryptonButton1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StatePressed.Border.Rounding = 25F;
            this.kryptonButton1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.kryptonButton1.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton1.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Image = global::Cinema_management.Properties.Resources.jam__movie__2_;
            this.kryptonButton1.Values.Text = "Movies";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(41, 128);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnDashboard.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.btnDashboard.OverrideDefault.Back.ColorAngle = 45F;
            this.btnDashboard.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnDashboard.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDashboard.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.btnDashboard.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnDashboard.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDashboard.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDashboard.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDashboard.Size = new System.Drawing.Size(350, 70);
            this.btnDashboard.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnDashboard.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnDashboard.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnDashboard.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnDashboard.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDashboard.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDashboard.StateCommon.Border.Rounding = 25F;
            this.btnDashboard.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDashboard.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.btnDashboard.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.btnDashboard.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.btnDashboard.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.btnDashboard.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDashboard.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDashboard.StatePressed.Border.Rounding = 25F;
            this.btnDashboard.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDashboard.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDashboard.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.btnDashboard.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.btnDashboard.StateTracking.Back.ColorAngle = 45F;
            this.btnDashboard.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDashboard.Values.Image = global::Cinema_management.Properties.Resources.ri__dashboard_fill__1_;
            this.btnDashboard.Values.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnContent
            // 
            this.pnContent.Controls.Add(this.pnContentforUC);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(439, 0);
            this.pnContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1072, 829);
            this.pnContent.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnContent.StateCommon.Color2 = System.Drawing.Color.White;
            this.pnContent.TabIndex = 1;
            this.pnContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContent_Paint);
            // 
            // pnContentforUC
            // 
            this.pnContentforUC.AutoScroll = true;
            this.pnContentforUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContentforUC.Location = new System.Drawing.Point(0, 0);
            this.pnContentforUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContentforUC.Name = "pnContentforUC";
            this.pnContentforUC.Size = new System.Drawing.Size(1072, 829);
            this.pnContentforUC.TabIndex = 1;
            this.pnContentforUC.Resize += new System.EventHandler(this.pnContentforUC_Resize);
            // 
            // kryptonCustomPaletteBase1
            // 
            this.kryptonCustomPaletteBase1.ButtonSpecs.FormClose.Image = global::Cinema_management.Properties.Resources.ion__close;
            this.kryptonCustomPaletteBase1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::Cinema_management.Properties.Resources.zondicons__close_solid;
            this.kryptonCustomPaletteBase1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::Cinema_management.Properties.Resources.zondicons__close_solid;
            this.kryptonCustomPaletteBase1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 829);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LocalCustomPalette = this.kryptonCustomPaletteBase1;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.StateCommon.Border.Rounding = 25F;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(11)))), ((int)(((byte)(20)))));
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnSidebar)).EndInit();
            this.pnSidebar.ResumeLayout(false);
            this.pnSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnContent)).EndInit();
            this.pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnContentforUC)).EndInit();
            this.ResumeLayout(false);

        }

        private void pnContent_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnSidebar;
        private Krypton.Toolkit.KryptonPanel pnContent;
        private Krypton.Toolkit.KryptonButton btnDashboard;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonPanel pnContentforUC;
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
    }
}