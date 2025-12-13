namespace Cinema_management
{
    partial class UCShowtimeBlock
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime.Location = new System.Drawing.Point(4, 4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(45, 19);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00";
            // 
            // lblMovieName
            // 
            this.lblMovieName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMovieName.AutoEllipsis = true;
            this.lblMovieName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(4, 25);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(142, 53);
            this.lblMovieName.TabIndex = 1;
            this.lblMovieName.Text = "Tên Phim";
            // 
            // UCShowtimeBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.lblTime);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UCShowtimeBlock";
            this.Size = new System.Drawing.Size(148, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Label lblMovieName;
    }
}