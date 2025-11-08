using System;
using System.Windows.Forms;

namespace Cinema_management
{
    partial class MovieRowControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbFilmName = new Krypton.Toolkit.KryptonLabel();
            this.btnRating = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            this.lblDuration = new Krypton.Toolkit.KryptonLabel();
            this.lblDirector = new Krypton.Toolkit.KryptonLabel();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.29787F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.42105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.05263F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.89474F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.93617F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.31915F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonButton3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.picPoster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbFilmName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRating, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDirector, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDuration, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2, 5, 0, 5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1060, 90);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lbFilmName
            // 
            this.lbFilmName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFilmName.Location = new System.Drawing.Point(132, 30);
            this.lbFilmName.Name = "lbFilmName";
            this.lbFilmName.Size = new System.Drawing.Size(163, 30);
            this.lbFilmName.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lbFilmName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilmName.TabIndex = 1;
            this.lbFilmName.Values.Text = "The Dark Night";
            // 
            // btnRating
            // 
            this.btnRating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRating.AutoSize = true;
            this.btnRating.Location = new System.Drawing.Point(467, 25);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(78, 40);
            this.btnRating.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(194)))));
            this.btnRating.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(194)))));
            this.btnRating.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(194)))));
            this.btnRating.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRating.StateCommon.Border.Rounding = 15F;
            this.btnRating.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnRating.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating.TabIndex = 3;
            this.btnRating.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRating.Values.Text = "PG-13";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonButton3.AutoSize = true;
            this.kryptonButton3.Location = new System.Drawing.Point(344, 25);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(81, 40);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonButton3.StateCommon.Border.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonButton3.StateCommon.Border.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Rounding = 15F;
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.TabIndex = 6;
            this.kryptonButton3.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton3.Values.Text = "Action";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.kryptonButton1);
            this.flowLayoutPanel1.Controls.Add(this.kryptonButton5);
            this.flowLayoutPanel1.Controls.Add(this.kryptonButton6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(867, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(189, 74);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonButton1.Location = new System.Drawing.Point(10, 10);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(10);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.kryptonButton1.Size = new System.Drawing.Size(41, 40);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.kryptonButton1.StateCommon.Border.Rounding = 10F;
            this.kryptonButton1.StateCommon.Border.Width = 0;
            this.kryptonButton1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, -1);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Image = global::Cinema_management.Properties.Resources.iconamoon__eye_light;
            this.kryptonButton1.Values.Text = "";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton5
            // 
            this.kryptonButton5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonButton5.Location = new System.Drawing.Point(71, 10);
            this.kryptonButton5.Margin = new System.Windows.Forms.Padding(10);
            this.kryptonButton5.Name = "kryptonButton5";
            this.kryptonButton5.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.kryptonButton5.Size = new System.Drawing.Size(41, 40);
            this.kryptonButton5.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton5.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton5.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.kryptonButton5.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.kryptonButton5.StateCommon.Border.Rounding = 10F;
            this.kryptonButton5.StateCommon.Border.Width = 0;
            this.kryptonButton5.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, -1);
            this.kryptonButton5.TabIndex = 3;
            this.kryptonButton5.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton5.Values.Image = global::Cinema_management.Properties.Resources.jam__write;
            this.kryptonButton5.Values.Text = "";
            // 
            // kryptonButton6
            // 
            this.kryptonButton6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonButton6.Location = new System.Drawing.Point(132, 10);
            this.kryptonButton6.Margin = new System.Windows.Forms.Padding(10);
            this.kryptonButton6.Name = "kryptonButton6";
            this.kryptonButton6.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.kryptonButton6.Size = new System.Drawing.Size(41, 40);
            this.kryptonButton6.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton6.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton6.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.kryptonButton6.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.kryptonButton6.StateCommon.Border.Rounding = 10F;
            this.kryptonButton6.StateCommon.Border.Width = 0;
            this.kryptonButton6.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, -1);
            this.kryptonButton6.TabIndex = 4;
            this.kryptonButton6.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton6.Values.Image = global::Cinema_management.Properties.Resources.material_symbols__delete_outline_rounded;
            this.kryptonButton6.Values.Text = "";
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDuration.Location = new System.Drawing.Point(584, 31);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(84, 28);
            this.lblDuration.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblDuration.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.TabIndex = 11;
            this.lblDuration.Values.Text = "152 min";
            // 
            // lblDirector
            // 
            this.lblDirector.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDirector.Location = new System.Drawing.Point(686, 31);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(175, 28);
            this.lblDirector.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblDirector.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.TabIndex = 7;
            this.lblDirector.Values.Text = "Christopher Nolan";
            // 
            // picPoster
            // 
            this.picPoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPoster.Image = global::Cinema_management.Properties.Resources.wallpaper_;
            this.picPoster.Location = new System.Drawing.Point(5, 8);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(94, 74);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // MovieRowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MovieRowControl";
            this.Size = new System.Drawing.Size(1060, 90);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);

        }

        private void KryptonButton1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picPoster;
        private Krypton.Toolkit.KryptonLabel lbFilmName;
        private Krypton.Toolkit.KryptonButton btnRating;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private Krypton.Toolkit.KryptonLabel lblDirector;
        private Krypton.Toolkit.KryptonLabel lblDuration;
    }
}
