namespace Bar_Management.Interfaces.WarehouseForm
{
    partial class Warehouse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSortTrangthai = new System.Windows.Forms.RadioButton();
            this.radioSortGia = new System.Windows.Forms.RadioButton();
            this.radioSortLoaiMonAn = new System.Windows.Forms.RadioButton();
            this.radioSortTenMonAn = new System.Windows.Forms.RadioButton();
            this.XoaBtn = new System.Windows.Forms.Button();
            this.LuuBtn = new System.Windows.Forms.Button();
            this.ExcelBtn = new System.Windows.Forms.Button();
            this.ThemBtn = new System.Windows.Forms.Button();
            this.searchKeytextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LocTrangThaicomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LocloaiMAComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboxNguyenLieu = new System.Windows.Forms.ComboBox();
            this.cboxNhaCC = new System.Windows.Forms.ComboBox();
            this.cboxTrangthai = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiMonAnDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle22.NullValue = null;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.TenMonDgv,
            this.LoaiMonAnDgv,
            this.GiaDgv,
            this.TrangThaiDgv,
            this.TrangThai,
            this.moTaDgv,
            this.ngayNhap,
            this.ngayHetHan});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(23, 404);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.Height = 44;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1460, 561);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSortTrangthai);
            this.groupBox1.Controls.Add(this.radioSortGia);
            this.groupBox1.Controls.Add(this.radioSortLoaiMonAn);
            this.groupBox1.Controls.Add(this.radioSortTenMonAn);
            this.groupBox1.Location = new System.Drawing.Point(1495, 650);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 158);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sắp xếp bảng";
            // 
            // radioSortTrangthai
            // 
            this.radioSortTrangthai.AutoSize = true;
            this.radioSortTrangthai.Location = new System.Drawing.Point(27, 110);
            this.radioSortTrangthai.Name = "radioSortTrangthai";
            this.radioSortTrangthai.Size = new System.Drawing.Size(88, 20);
            this.radioSortTrangthai.TabIndex = 3;
            this.radioSortTrangthai.TabStop = true;
            this.radioSortTrangthai.Text = "Trạng thái";
            this.radioSortTrangthai.UseVisualStyleBackColor = true;
            // 
            // radioSortGia
            // 
            this.radioSortGia.AutoSize = true;
            this.radioSortGia.Location = new System.Drawing.Point(27, 84);
            this.radioSortGia.Name = "radioSortGia";
            this.radioSortGia.Size = new System.Drawing.Size(49, 20);
            this.radioSortGia.TabIndex = 2;
            this.radioSortGia.TabStop = true;
            this.radioSortGia.Text = "Giá";
            this.radioSortGia.UseVisualStyleBackColor = true;
            // 
            // radioSortLoaiMonAn
            // 
            this.radioSortLoaiMonAn.AutoSize = true;
            this.radioSortLoaiMonAn.Location = new System.Drawing.Point(27, 54);
            this.radioSortLoaiMonAn.Name = "radioSortLoaiMonAn";
            this.radioSortLoaiMonAn.Size = new System.Drawing.Size(101, 20);
            this.radioSortLoaiMonAn.TabIndex = 1;
            this.radioSortLoaiMonAn.TabStop = true;
            this.radioSortLoaiMonAn.Text = "Loại món ăn";
            this.radioSortLoaiMonAn.UseVisualStyleBackColor = true;
            // 
            // radioSortTenMonAn
            // 
            this.radioSortTenMonAn.AutoSize = true;
            this.radioSortTenMonAn.Location = new System.Drawing.Point(27, 28);
            this.radioSortTenMonAn.Name = "radioSortTenMonAn";
            this.radioSortTenMonAn.Size = new System.Drawing.Size(99, 20);
            this.radioSortTenMonAn.TabIndex = 0;
            this.radioSortTenMonAn.TabStop = true;
            this.radioSortTenMonAn.Text = "Tên món ăn";
            this.radioSortTenMonAn.UseVisualStyleBackColor = true;
            // 
            // XoaBtn
            // 
            this.XoaBtn.Location = new System.Drawing.Point(558, 81);
            this.XoaBtn.Name = "XoaBtn";
            this.XoaBtn.Size = new System.Drawing.Size(115, 55);
            this.XoaBtn.TabIndex = 72;
            this.XoaBtn.Text = "Xóa";
            this.XoaBtn.UseVisualStyleBackColor = true;
            // 
            // LuuBtn
            // 
            this.LuuBtn.Location = new System.Drawing.Point(316, 81);
            this.LuuBtn.Name = "LuuBtn";
            this.LuuBtn.Size = new System.Drawing.Size(115, 55);
            this.LuuBtn.TabIndex = 73;
            this.LuuBtn.Text = "Thêm";
            this.LuuBtn.UseVisualStyleBackColor = true;
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Image = global::Bar_Management.Properties.Resources.excelicon_;
            this.ExcelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExcelBtn.Location = new System.Drawing.Point(22, 80);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(170, 57);
            this.ExcelBtn.TabIndex = 71;
            this.ExcelBtn.Text = "Tải xuống danh sách";
            this.ExcelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExcelBtn.UseVisualStyleBackColor = true;
            // 
            // ThemBtn
            // 
            this.ThemBtn.Location = new System.Drawing.Point(196, 81);
            this.ThemBtn.Name = "ThemBtn";
            this.ThemBtn.Size = new System.Drawing.Size(115, 55);
            this.ThemBtn.TabIndex = 70;
            this.ThemBtn.Text = "Clear";
            this.ThemBtn.UseVisualStyleBackColor = true;
            // 
            // searchKeytextBox
            // 
            this.searchKeytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchKeytextBox.Location = new System.Drawing.Point(23, 366);
            this.searchKeytextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchKeytextBox.Multiline = true;
            this.searchKeytextBox.Name = "searchKeytextBox";
            this.searchKeytextBox.Size = new System.Drawing.Size(288, 30);
            this.searchKeytextBox.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 339);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 64;
            this.label7.Text = "Search";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1498, 514);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 87;
            this.label9.Text = "Trạng thái:";
            // 
            // LocTrangThaicomboBox
            // 
            this.LocTrangThaicomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LocTrangThaicomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocTrangThaicomboBox.FormattingEnabled = true;
            this.LocTrangThaicomboBox.ItemHeight = 18;
            this.LocTrangThaicomboBox.Items.AddRange(new object[] {
            "--Trạng thái--",
            "Còn",
            "Hết"});
            this.LocTrangThaicomboBox.Location = new System.Drawing.Point(1497, 533);
            this.LocTrangThaicomboBox.Name = "LocTrangThaicomboBox";
            this.LocTrangThaicomboBox.Size = new System.Drawing.Size(134, 26);
            this.LocTrangThaicomboBox.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1492, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 85;
            this.label10.Text = "Nguyên liệu:";
            // 
            // LocloaiMAComboBox
            // 
            this.LocloaiMAComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocloaiMAComboBox.FormattingEnabled = true;
            this.LocloaiMAComboBox.Location = new System.Drawing.Point(1497, 476);
            this.LocloaiMAComboBox.Name = "LocloaiMAComboBox";
            this.LocloaiMAComboBox.Size = new System.Drawing.Size(134, 26);
            this.LocloaiMAComboBox.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1492, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 83;
            this.label8.Text = "Lọc dữ liệu:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 55);
            this.button1.TabIndex = 88;
            this.button1.Text = "Thêm loại nguyên liệu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboxNguyenLieu
            // 
            this.cboxNguyenLieu.DisplayMember = "TenNguyenLieu";
            this.cboxNguyenLieu.DropDownHeight = 100;
            this.cboxNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxNguyenLieu.FormattingEnabled = true;
            this.cboxNguyenLieu.IntegralHeight = false;
            this.cboxNguyenLieu.ItemHeight = 18;
            this.cboxNguyenLieu.Location = new System.Drawing.Point(25, 150);
            this.cboxNguyenLieu.Name = "cboxNguyenLieu";
            this.cboxNguyenLieu.Size = new System.Drawing.Size(130, 26);
            this.cboxNguyenLieu.TabIndex = 89;
            this.cboxNguyenLieu.ValueMember = "Id";
            // 
            // cboxNhaCC
            // 
            this.cboxNhaCC.DisplayMember = "Ten";
            this.cboxNhaCC.DropDownHeight = 100;
            this.cboxNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxNhaCC.FormattingEnabled = true;
            this.cboxNhaCC.IntegralHeight = false;
            this.cboxNhaCC.ItemHeight = 18;
            this.cboxNhaCC.Location = new System.Drawing.Point(25, 235);
            this.cboxNhaCC.Name = "cboxNhaCC";
            this.cboxNhaCC.Size = new System.Drawing.Size(130, 26);
            this.cboxNhaCC.TabIndex = 90;
            this.cboxNhaCC.ValueMember = "Id";
            // 
            // cboxTrangthai
            // 
            this.cboxTrangthai.DisplayMember = "Ten";
            this.cboxTrangthai.DropDownHeight = 100;
            this.cboxTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTrangthai.FormattingEnabled = true;
            this.cboxTrangthai.IntegralHeight = false;
            this.cboxTrangthai.ItemHeight = 18;
            this.cboxTrangthai.Location = new System.Drawing.Point(25, 193);
            this.cboxTrangthai.Name = "cboxTrangthai";
            this.cboxTrangthai.Size = new System.Drawing.Size(130, 26);
            this.cboxTrangthai.TabIndex = 91;
            this.cboxTrangthai.ValueMember = "Id";
            this.cboxTrangthai.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 26);
            this.textBox1.TabIndex = 92;
            this.textBox1.Text = "Số lượng";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(172, 235);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 26);
            this.textBox3.TabIndex = 94;
            this.textBox3.Text = "Giá nhập";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(172, 193);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(138, 26);
            this.textBox4.TabIndex = 95;
            this.textBox4.Text = "Đơn vị";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 300);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 22);
            this.dateTimePicker1.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 98;
            this.label1.Text = "Ngày hết hạn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(768, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 55);
            this.button2.TabIndex = 99;
            this.button2.Text = "Xuất nguyên liệu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1498, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "Nhà cung cấp:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 18;
            this.comboBox1.Items.AddRange(new object[] {
            "--Trạng thái--",
            "Còn",
            "Hết"});
            this.comboBox1.Location = new System.Drawing.Point(1497, 597);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 26);
            this.comboBox1.TabIndex = 100;
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "Id";
            this.dgvID.FillWeight = 30.32747F;
            this.dgvID.HeaderText = "ID";
            this.dgvID.MaxInputLength = 50;
            this.dgvID.MinimumWidth = 6;
            this.dgvID.Name = "dgvID";
            // 
            // TenMonDgv
            // 
            this.TenMonDgv.DataPropertyName = "NguyenLieu";
            this.TenMonDgv.FillWeight = 30.32747F;
            this.TenMonDgv.HeaderText = "Tên nguyên liệu";
            this.TenMonDgv.MinimumWidth = 6;
            this.TenMonDgv.Name = "TenMonDgv";
            // 
            // LoaiMonAnDgv
            // 
            this.LoaiMonAnDgv.DataPropertyName = "SoLuong";
            this.LoaiMonAnDgv.FillWeight = 30.32747F;
            this.LoaiMonAnDgv.HeaderText = "Số lượng";
            this.LoaiMonAnDgv.MinimumWidth = 6;
            this.LoaiMonAnDgv.Name = "LoaiMonAnDgv";
            // 
            // GiaDgv
            // 
            this.GiaDgv.DataPropertyName = "DonVi";
            this.GiaDgv.FillWeight = 30.32747F;
            this.GiaDgv.HeaderText = "Đơn vị";
            this.GiaDgv.MinimumWidth = 6;
            this.GiaDgv.Name = "GiaDgv";
            // 
            // TrangThaiDgv
            // 
            this.TrangThaiDgv.DataPropertyName = "GiaNhap";
            this.TrangThaiDgv.FillWeight = 70F;
            this.TrangThaiDgv.HeaderText = "Giá nhập";
            this.TrangThaiDgv.MinimumWidth = 70;
            this.TrangThaiDgv.Name = "TrangThaiDgv";
            this.TrangThaiDgv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // moTaDgv
            // 
            this.moTaDgv.DataPropertyName = "NhaCungCap";
            this.moTaDgv.FillWeight = 30.32747F;
            this.moTaDgv.HeaderText = "Nhà cung cấp";
            this.moTaDgv.MinimumWidth = 6;
            this.moTaDgv.Name = "moTaDgv";
            // 
            // ngayNhap
            // 
            this.ngayNhap.DataPropertyName = "NgayNhap";
            this.ngayNhap.HeaderText = "Ngày nhập";
            this.ngayNhap.MinimumWidth = 6;
            this.ngayNhap.Name = "ngayNhap";
            // 
            // ngayHetHan
            // 
            this.ngayHetHan.DataPropertyName = "NgayHetHan";
            this.ngayHetHan.HeaderText = "Ngày hết hạn";
            this.ngayHetHan.MinimumWidth = 6;
            this.ngayHetHan.Name = "ngayHetHan";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(437, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 55);
            this.button3.TabIndex = 102;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.tenNguyenLieu,
            this.SoLuong});
            this.dataGridView2.Location = new System.Drawing.Point(945, 150);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(538, 236);
            this.dataGridView2.TabIndex = 103;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 47;
            // 
            // tenNguyenLieu
            // 
            this.tenNguyenLieu.HeaderText = "Tên nguyên liệu";
            this.tenNguyenLieu.MinimumWidth = 6;
            this.tenNguyenLieu.Name = "tenNguyenLieu";
            this.tenNguyenLieu.Width = 120;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 83;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1660, 865);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboxTrangthai);
            this.Controls.Add(this.cboxNhaCC);
            this.Controls.Add(this.cboxNguyenLieu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LocTrangThaicomboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LocloaiMAComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.XoaBtn);
            this.Controls.Add(this.LuuBtn);
            this.Controls.Add(this.ExcelBtn);
            this.Controls.Add(this.ThemBtn);
            this.Controls.Add(this.searchKeytextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Warehouse";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSortTrangthai;
        private System.Windows.Forms.RadioButton radioSortGia;
        private System.Windows.Forms.RadioButton radioSortLoaiMonAn;
        private System.Windows.Forms.RadioButton radioSortTenMonAn;
        private System.Windows.Forms.Button XoaBtn;
        private System.Windows.Forms.Button LuuBtn;
        private System.Windows.Forms.Button ExcelBtn;
        private System.Windows.Forms.Button ThemBtn;
        private System.Windows.Forms.TextBox searchKeytextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox LocTrangThaicomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox LocloaiMAComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboxNguyenLieu;
        private System.Windows.Forms.ComboBox cboxNhaCC;
        private System.Windows.Forms.ComboBox cboxTrangthai;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiMonAnDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}