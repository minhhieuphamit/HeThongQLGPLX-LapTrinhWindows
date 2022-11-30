namespace HTQLGPLX
{
    partial class formQLyViPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQLyViPham));
            this.dataGridViewLoiViPham = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBienBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGPLX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDungViPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLGPLXDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLGPLXDataSet = new HTQLGPLX.QLGPLXDataSet();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuHoSoGPLX = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMaGPLX = new System.Windows.Forms.Label();
            this.labelNgayLap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMaBienBan = new System.Windows.Forms.Label();
            this.labelNDViPham = new System.Windows.Forms.Label();
            this.dateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNDViPham = new System.Windows.Forms.ComboBox();
            this.comboBoxMaGPLX = new System.Windows.Forms.ComboBox();
            this.textBoxMaBienBan = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTienPhat = new System.Windows.Forms.Label();
            this.toolStripMenuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuXuatBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoiViPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGPLXDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGPLXDataSet)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLoiViPham
            // 
            this.dataGridViewLoiViPham.AllowUserToAddRows = false;
            this.dataGridViewLoiViPham.AllowUserToDeleteRows = false;
            this.dataGridViewLoiViPham.AllowUserToResizeColumns = false;
            this.dataGridViewLoiViPham.AllowUserToResizeRows = false;
            this.dataGridViewLoiViPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLoiViPham.AutoGenerateColumns = false;
            this.dataGridViewLoiViPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewLoiViPham.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLoiViPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewLoiViPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaBienBan,
            this.MaGPLX,
            this.NoiDungViPham,
            this.NgayLap,
            this.TienPhat});
            this.dataGridViewLoiViPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewLoiViPham.DataSource = this.qLGPLXDataSetBindingSource;
            this.dataGridViewLoiViPham.EnableHeadersVisualStyles = false;
            this.dataGridViewLoiViPham.Location = new System.Drawing.Point(2, 105);
            this.dataGridViewLoiViPham.Name = "dataGridViewLoiViPham";
            this.dataGridViewLoiViPham.ReadOnly = true;
            this.dataGridViewLoiViPham.RowHeadersVisible = false;
            this.dataGridViewLoiViPham.Size = new System.Drawing.Size(393, 358);
            this.dataGridViewLoiViPham.TabIndex = 10;
            this.dataGridViewLoiViPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoiViPham_CellClick);
            this.dataGridViewLoiViPham.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewLoiViPham_CellFormatting);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.STT.DataPropertyName = "STT";
            this.STT.Frozen = true;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.STT.Width = 33;
            // 
            // MaBienBan
            // 
            this.MaBienBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaBienBan.DataPropertyName = "MaBienBan";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.MaBienBan.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaBienBan.Frozen = true;
            this.MaBienBan.HeaderText = "Mã biên bản";
            this.MaBienBan.Name = "MaBienBan";
            this.MaBienBan.ReadOnly = true;
            this.MaBienBan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaBienBan.Width = 71;
            // 
            // MaGPLX
            // 
            this.MaGPLX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaGPLX.DataPropertyName = "MaGPLX";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.MaGPLX.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaGPLX.Frozen = true;
            this.MaGPLX.HeaderText = "Mã GPLX";
            this.MaGPLX.Name = "MaGPLX";
            this.MaGPLX.ReadOnly = true;
            this.MaGPLX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaGPLX.Width = 58;
            // 
            // NoiDungViPham
            // 
            this.NoiDungViPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoiDungViPham.DataPropertyName = "NoiDungViPham";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.NoiDungViPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.NoiDungViPham.FillWeight = 500F;
            this.NoiDungViPham.HeaderText = "Nội dung vi phạm";
            this.NoiDungViPham.MinimumWidth = 500;
            this.NoiDungViPham.Name = "NoiDungViPham";
            this.NoiDungViPham.ReadOnly = true;
            this.NoiDungViPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NgayLap
            // 
            this.NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NgayLap.DefaultCellStyle = dataGridViewCellStyle4;
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            this.NgayLap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NgayLap.Width = 54;
            // 
            // TienPhat
            // 
            this.TienPhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TienPhat.DataPropertyName = "TienPhat";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TienPhat.DefaultCellStyle = dataGridViewCellStyle5;
            this.TienPhat.HeaderText = "Tiền phạt";
            this.TienPhat.Name = "TienPhat";
            this.TienPhat.ReadOnly = true;
            this.TienPhat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TienPhat.Width = 57;
            // 
            // qLGPLXDataSetBindingSource
            // 
            this.qLGPLXDataSetBindingSource.DataSource = this.qLGPLXDataSet;
            this.qLGPLXDataSetBindingSource.Position = 0;
            // 
            // qLGPLXDataSet
            // 
            this.qLGPLXDataSet.DataSetName = "QLGPLXDataSet";
            this.qLGPLXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuHeThong,
            this.toolStripMenuChucNang});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(830, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuHeThong
            // 
            this.toolStripMenuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuHoSoGPLX,
            this.toolStripMenuLogout,
            this.toolStripSeparator1,
            this.toolStripMenuThoat});
            this.toolStripMenuHeThong.Name = "toolStripMenuHeThong";
            this.toolStripMenuHeThong.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuHeThong.Text = "Hệ thống";
            // 
            // toolStripMenuHoSoGPLX
            // 
            this.toolStripMenuHoSoGPLX.Image = global::HTQLGPLX.Properties.Resources.file_driver_license;
            this.toolStripMenuHoSoGPLX.Name = "toolStripMenuHoSoGPLX";
            this.toolStripMenuHoSoGPLX.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuHoSoGPLX.Text = "Quản lý giấy phép lái xe";
            this.toolStripMenuHoSoGPLX.Click += new System.EventHandler(this.toolStripMenuHoSoGPLX_Click);
            // 
            // toolStripMenuLogout
            // 
            this.toolStripMenuLogout.Image = global::HTQLGPLX.Properties.Resources.logout;
            this.toolStripMenuLogout.Name = "toolStripMenuLogout";
            this.toolStripMenuLogout.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuLogout.Text = "Đăng xuất";
            this.toolStripMenuLogout.Click += new System.EventHandler(this.toolStripMenuLogout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // toolStripMenuThoat
            // 
            this.toolStripMenuThoat.Name = "toolStripMenuThoat";
            this.toolStripMenuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuThoat.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuThoat.Text = "Exit";
            this.toolStripMenuThoat.Click += new System.EventHandler(this.toolStripMenuThoat_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.ForeColor = System.Drawing.Color.Black;
            this.buttonLogout.Image = global::HTQLGPLX.Properties.Resources.logout;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(739, 27);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(79, 47);
            this.buttonLogout.TabIndex = 11;
            this.buttonLogout.Text = "Đăng xuất";
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HTQLGPLX.Properties.Resources.driving_license;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(5, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "LỖI VI PHẠM ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaGPLX
            // 
            this.labelMaGPLX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaGPLX.AutoSize = true;
            this.labelMaGPLX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaGPLX.Location = new System.Drawing.Point(401, 189);
            this.labelMaGPLX.Name = "labelMaGPLX";
            this.labelMaGPLX.Size = new System.Drawing.Size(98, 13);
            this.labelMaGPLX.TabIndex = 2;
            this.labelMaGPLX.Text = "Mã giấy phép lái xe";
            // 
            // labelNgayLap
            // 
            this.labelNgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNgayLap.AutoSize = true;
            this.labelNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayLap.Location = new System.Drawing.Point(401, 260);
            this.labelNgayLap.Name = "labelNgayLap";
            this.labelNgayLap.Size = new System.Drawing.Size(49, 13);
            this.labelNgayLap.TabIndex = 4;
            this.labelNgayLap.Text = "Ngày lập";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tiền phạt";
            // 
            // labelMaBienBan
            // 
            this.labelMaBienBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaBienBan.AutoSize = true;
            this.labelMaBienBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaBienBan.Location = new System.Drawing.Point(401, 153);
            this.labelMaBienBan.Name = "labelMaBienBan";
            this.labelMaBienBan.Size = new System.Drawing.Size(66, 13);
            this.labelMaBienBan.TabIndex = 1;
            this.labelMaBienBan.Text = "Mã biên bản";
            // 
            // labelNDViPham
            // 
            this.labelNDViPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNDViPham.AutoSize = true;
            this.labelNDViPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNDViPham.Location = new System.Drawing.Point(401, 223);
            this.labelNDViPham.Name = "labelNDViPham";
            this.labelNDViPham.Size = new System.Drawing.Size(90, 13);
            this.labelNDViPham.TabIndex = 3;
            this.labelNDViPham.Text = "Nội dung vi phạm";
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerNgayLap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(507, 256);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(217, 20);
            this.dateTimePickerNgayLap.TabIndex = 4;
            // 
            // comboBoxNDViPham
            // 
            this.comboBoxNDViPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNDViPham.FormattingEnabled = true;
            this.comboBoxNDViPham.Location = new System.Drawing.Point(507, 220);
            this.comboBoxNDViPham.Name = "comboBoxNDViPham";
            this.comboBoxNDViPham.Size = new System.Drawing.Size(311, 21);
            this.comboBoxNDViPham.TabIndex = 3;
            // 
            // comboBoxMaGPLX
            // 
            this.comboBoxMaGPLX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMaGPLX.FormattingEnabled = true;
            this.comboBoxMaGPLX.Location = new System.Drawing.Point(507, 186);
            this.comboBoxMaGPLX.Name = "comboBoxMaGPLX";
            this.comboBoxMaGPLX.Size = new System.Drawing.Size(182, 21);
            this.comboBoxMaGPLX.TabIndex = 2;
            // 
            // textBoxMaBienBan
            // 
            this.textBoxMaBienBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMaBienBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaBienBan.Location = new System.Drawing.Point(507, 150);
            this.textBoxMaBienBan.Name = "textBoxMaBienBan";
            this.textBoxMaBienBan.Size = new System.Drawing.Size(169, 20);
            this.textBoxMaBienBan.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxSearch.Location = new System.Drawing.Point(12, 69);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(171, 23);
            this.textBoxSearch.TabIndex = 14;
            this.textBoxSearch.Text = "Search";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.formQLyViPham_Load);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Image = global::HTQLGPLX.Properties.Resources.edit;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(667, 370);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(70, 35);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseCompatibleTextRendering = true;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Image = global::HTQLGPLX.Properties.Resources.bin;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(582, 370);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(70, 35);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Xoá";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseCompatibleTextRendering = true;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Image = global::HTQLGPLX.Properties.Resources.add;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(497, 370);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 35);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseCompatibleTextRendering = true;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Image = global::HTQLGPLX.Properties.Resources.search;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(192, 64);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(92, 35);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.UseCompatibleTextRendering = true;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.TextChanged += new System.EventHandler(this.formQLyViPham_Load);
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelTienPhat
            // 
            this.labelTienPhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTienPhat.BackColor = System.Drawing.Color.White;
            this.labelTienPhat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienPhat.ForeColor = System.Drawing.Color.Black;
            this.labelTienPhat.Location = new System.Drawing.Point(505, 291);
            this.labelTienPhat.Name = "labelTienPhat";
            this.labelTienPhat.Size = new System.Drawing.Size(171, 24);
            this.labelTienPhat.TabIndex = 19;
            this.labelTienPhat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuChucNang
            // 
            this.toolStripMenuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuXuatBaoCao});
            this.toolStripMenuChucNang.Name = "toolStripMenuChucNang";
            this.toolStripMenuChucNang.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuChucNang.Text = "Chức năng";
            // 
            // toolStripMenuXuatBaoCao
            // 
            this.toolStripMenuXuatBaoCao.Name = "toolStripMenuXuatBaoCao";
            this.toolStripMenuXuatBaoCao.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuXuatBaoCao.Text = "Xuất báo cáo";
            this.toolStripMenuXuatBaoCao.Click += new System.EventHandler(this.toolStripMenuXuatBaoCao_Click);
            // 
            // formQLyViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 463);
            this.Controls.Add(this.labelTienPhat);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxMaGPLX);
            this.Controls.Add(this.comboBoxNDViPham);
            this.Controls.Add(this.dateTimePickerNgayLap);
            this.Controls.Add(this.labelNDViPham);
            this.Controls.Add(this.labelMaBienBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNgayLap);
            this.Controls.Add(this.labelMaGPLX);
            this.Controls.Add(this.textBoxMaBienBan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.dataGridViewLoiViPham);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "formQLyViPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lỗi vi phạm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formQLyViPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoiViPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGPLXDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGPLXDataSet)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource qLGPLXDataSetBindingSource;
        private QLGPLXDataSet qLGPLXDataSet;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuHeThong;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuHoSoGPLX;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuThoat;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLoiViPham;
        private System.Windows.Forms.Label labelMaGPLX;
        private System.Windows.Forms.Label labelNgayLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMaBienBan;
        private System.Windows.Forms.Label labelNDViPham;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLap;
        private System.Windows.Forms.ComboBox comboBoxNDViPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBienBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGPLX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDungViPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhat;
        private System.Windows.Forms.ComboBox comboBoxMaGPLX;
        private System.Windows.Forms.TextBox textBoxMaBienBan;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelTienPhat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuChucNang;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuXuatBaoCao;
    }
}