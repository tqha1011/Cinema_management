namespace Cinema_management
{
    partial class UCShowtimes
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
            Krypton.Toolkit.IconSpec iconSpec1 = new Krypton.Toolkit.IconSpec();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCShowtimes));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnSearch = new Krypton.Toolkit.KryptonPanel();
            this.txbSearchMR = new Krypton.Toolkit.KryptonTextBox();
            this.pnSearchDate = new Krypton.Toolkit.KryptonPanel();
            this.dtpSearchDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            this.dgvShows = new Krypton.Toolkit.KryptonDataGridView();
            this.Movie = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Type = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Duration = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Showtimes = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.editBtn = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).BeginInit();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnSearchDate)).BeginInit();
            this.pnSearchDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShows)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1068, 120);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(915, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 58);
            this.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnDelete.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.Rounding = 10F;
            this.btnDelete.StateCommon.Border.Width = 0;
            this.btnDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnDelete.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnDelete.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnDelete.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StatePressed.Border.Rounding = 10F;
            this.btnDelete.StatePressed.Border.Width = 0;
            this.btnDelete.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDelete.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.btnDelete.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.btnDelete.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateTracking.Border.Rounding = 10F;
            this.btnDelete.StateTracking.Border.Width = 0;
            this.btnDelete.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDelete.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDelete.Values.Image = global::Cinema_management.Properties.Resources.material_symbols__delete_outline_rounded__1_;
            this.btnDelete.Values.Text = "Delete";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(759, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 58);
            this.btnUpdate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnUpdate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnUpdate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateCommon.Border.Rounding = 10F;
            this.btnUpdate.StateCommon.Border.Width = 0;
            this.btnUpdate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnUpdate.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnUpdate.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnUpdate.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StatePressed.Border.Rounding = 10F;
            this.btnUpdate.StatePressed.Border.Width = 0;
            this.btnUpdate.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.btnUpdate.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.btnUpdate.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateTracking.Border.Rounding = 10F;
            this.btnUpdate.StateTracking.Border.Width = 0;
            this.btnUpdate.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUpdate.Values.Image = global::Cinema_management.Properties.Resources.jam__write__1_1;
            this.btnUpdate.Values.Text = "Update";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.kryptonLabel1);
            this.flowLayoutPanel1.Controls.Add(this.kryptonLabel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(485, 87);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(363, 42);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Showtime Management";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 51);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(450, 33);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Schedule and manage movie showtimes";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(494, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(259, 58);
            this.btnAdd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnAdd.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnAdd.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 10F;
            this.btnAdd.StateCommon.Border.Width = 0;
            this.btnAdd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnAdd.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnAdd.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnAdd.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StatePressed.Border.Rounding = 10F;
            this.btnAdd.StatePressed.Border.Width = 0;
            this.btnAdd.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.btnAdd.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.btnAdd.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateTracking.Border.Rounding = 10F;
            this.btnAdd.StateTracking.Border.Width = 0;
            this.btnAdd.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAdd.Values.Image = global::Cinema_management.Properties.Resources.material_symbols__add_rounded;
            this.btnAdd.Values.Text = "Add New Schedule";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.pnSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnSearchDate, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 140);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1068, 90);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.txbSearchMR);
            this.pnSearch.Controls.Add(this.pictureBox1);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearch.Location = new System.Drawing.Point(3, 3);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(394, 57);
            this.pnSearch.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnSearch.TabIndex = 0;
            // 
            // txbSearchMR
            // 
            this.txbSearchMR.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txbSearchMR.CueHint.CueHintText = "Search movie or room...";
            this.txbSearchMR.CueHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchMR.Location = new System.Drawing.Point(55, 10);
            this.txbSearchMR.Name = "txbSearchMR";
            this.txbSearchMR.Size = new System.Drawing.Size(300, 37);
            this.txbSearchMR.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.txbSearchMR.StateCommon.Border.Rounding = 10F;
            this.txbSearchMR.TabIndex = 1;
            // 
            // pnSearchDate
            // 
            this.pnSearchDate.Controls.Add(this.dtpSearchDate);
            this.pnSearchDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearchDate.Location = new System.Drawing.Point(403, 3);
            this.pnSearchDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.pnSearchDate.Name = "pnSearchDate";
            this.pnSearchDate.Size = new System.Drawing.Size(662, 57);
            this.pnSearchDate.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnSearchDate.TabIndex = 6;
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpSearchDate.CustomFormat = "mm/dd/yyyy";
            this.dtpSearchDate.CustomNullText = "mm/dd/yyyy";
            this.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchDate.Location = new System.Drawing.Point(0, 10);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(191, 36);
            this.dtpSearchDate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.dtpSearchDate.StateCommon.Border.Rounding = 10F;
            this.dtpSearchDate.TabIndex = 1;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroup1.Location = new System.Drawing.Point(20, 230);
            this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(20);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.dgvShows);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonPanel1);
            this.kryptonGroup1.Panel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.kryptonGroup1.Size = new System.Drawing.Size(1068, 550);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.kryptonGroup1.StateCommon.Border.Rounding = 15F;
            this.kryptonGroup1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema_management.Properties.Resources.lucide__search;
            this.pictureBox1.Location = new System.Drawing.Point(16, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonButton6);
            this.kryptonPanel1.Controls.Add(this.kryptonButton5);
            this.kryptonPanel1.Controls.Add(this.kryptonButton4);
            this.kryptonPanel1.Controls.Add(this.kryptonButton3);
            this.kryptonPanel1.Controls.Add(this.kryptonButton2);
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(250, 518);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(80)))), ((int)(((byte)(253)))));
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(13, 30);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(221, 45);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Border.Rounding = 10F;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "All Showtimes";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(13, 98);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(221, 45);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateCommon.Border.Rounding = 10F;
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton2.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton2.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton2.TabIndex = 0;
            this.kryptonButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton2.Values.Text = "Phòng 1";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(13, 165);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(221, 45);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Border.Rounding = 10F;
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton3.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton3.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton3.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton3.TabIndex = 0;
            this.kryptonButton3.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton3.Values.Text = "Phòng 2";
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(13, 233);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(221, 45);
            this.kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateCommon.Border.Rounding = 10F;
            this.kryptonButton4.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton4.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton4.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton4.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton4.TabIndex = 0;
            this.kryptonButton4.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton4.Values.Text = "Phòng 3";
            // 
            // kryptonButton5
            // 
            this.kryptonButton5.Location = new System.Drawing.Point(13, 299);
            this.kryptonButton5.Name = "kryptonButton5";
            this.kryptonButton5.Size = new System.Drawing.Size(221, 45);
            this.kryptonButton5.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateCommon.Border.Rounding = 10F;
            this.kryptonButton5.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton5.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton5.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton5.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton5.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton5.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton5.TabIndex = 0;
            this.kryptonButton5.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton5.Values.Text = "Phòng 4";
            // 
            // kryptonButton6
            // 
            this.kryptonButton6.Location = new System.Drawing.Point(13, 367);
            this.kryptonButton6.Name = "kryptonButton6";
            this.kryptonButton6.Size = new System.Drawing.Size(221, 45);
            this.kryptonButton6.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton6.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton6.StateCommon.Border.Rounding = 10F;
            this.kryptonButton6.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton6.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton6.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton6.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton6.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton6.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(53)))), ((int)(((byte)(168)))));
            this.kryptonButton6.TabIndex = 0;
            this.kryptonButton6.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton6.Values.Text = "Phòng 5";
            // 
            // dgvShows
            // 
            this.dgvShows.AllowUserToAddRows = false;
            this.dgvShows.AllowUserToDeleteRows = false;
            this.dgvShows.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movie,
            this.Type,
            this.Duration,
            this.Showtimes,
            this.editBtn});
            this.dgvShows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShows.Location = new System.Drawing.Point(250, 0);
            this.dgvShows.Name = "dgvShows";
            this.dgvShows.RowHeadersVisible = false;
            this.dgvShows.RowHeadersWidth = 62;
            this.dgvShows.RowTemplate.Height = 40;
            this.dgvShows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShows.Size = new System.Drawing.Size(786, 518);
            this.dgvShows.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvShows.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvShows.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvShows.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvShows.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.LightGray;
            this.dgvShows.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dgvShows.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvShows.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShows.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.dgvShows.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dgvShows.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.LightGray;
            this.dgvShows.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dgvShows.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.dgvShows.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShows.TabIndex = 2;
            // 
            // Movie
            // 
            this.Movie.HeaderText = "Movie";
            this.Movie.MinimumWidth = 8;
            this.Movie.Name = "Movie";
            this.Movie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Movie.Width = 300;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.Width = 150;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 8;
            this.Duration.Name = "Duration";
            this.Duration.Width = 150;
            // 
            // Showtimes
            // 
            this.Showtimes.Checked = false;
            this.Showtimes.CustomFormat = "dd/mm/yyyy";
            this.Showtimes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Showtimes.HeaderText = "Showtimes";
            this.Showtimes.MinimumWidth = 8;
            this.Showtimes.Name = "Showtimes";
            this.Showtimes.ShowCheckBox = true;
            this.Showtimes.Width = 400;
            // 
            // editBtn
            // 
            this.editBtn.HeaderText = "Edit";
            iconSpec1.Alignment = Krypton.Toolkit.IconSpec.IconAlignment.Left;
            iconSpec1.Icon = ((System.Drawing.Image)(resources.GetObject("iconSpec1.Icon")));
            this.editBtn.IconSpecs.Add(iconSpec1);
            this.editBtn.MinimumWidth = 8;
            this.editBtn.Name = "editBtn";
            this.editBtn.Text = "Edit";
            this.editBtn.UseColumnTextForButtonValue = true;
            this.editBtn.Width = 150;
            // 
            // UCShowtimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCShowtimes";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1108, 800);
            this.Load += new System.EventHandler(this.UCShowtimes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnSearchDate)).EndInit();
            this.pnSearchDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnUpdate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonPanel pnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonTextBox txbSearchMR;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonDateTimePicker dtpSearchDate;
        private Krypton.Toolkit.KryptonPanel pnSearchDate;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private Krypton.Toolkit.KryptonDataGridView dgvShows;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Movie;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Type;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Duration;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn Showtimes;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn editBtn;
    }
}
