namespace Bar_Management.Interfaces.EmployeeForm
{
    partial class Employ
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSortTrangthai = new System.Windows.Forms.RadioButton();
            this.radioSortGia = new System.Windows.Forms.RadioButton();
            this.radioSortLoaiMonAn = new System.Windows.Forms.RadioButton();
            this.radioSortTenMonAn = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.LocTrangThaicomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LocloaiMAComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.XoaBtn = new System.Windows.Forms.Button();
            this.LuuBtn = new System.Windows.Forms.Button();
            this.ThemBtn = new System.Windows.Forms.Button();
            this.DOBtxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchKeytextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExcelBtn = new System.Windows.Forms.Button();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Luongtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SDTtxt = new System.Windows.Forms.TextBox();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lương = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.DOBError = new System.Windows.Forms.ErrorProvider(this.components);
            this.SDTError = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.LuongError = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorHinhAnh = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOBError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SDTError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuongError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSortTrangthai);
            this.groupBox1.Controls.Add(this.radioSortGia);
            this.groupBox1.Controls.Add(this.radioSortLoaiMonAn);
            this.groupBox1.Controls.Add(this.radioSortTenMonAn);
            this.groupBox1.Location = new System.Drawing.Point(1211, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 158);
            this.groupBox1.TabIndex = 68;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1434, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 67;
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
            this.LocTrangThaicomboBox.Location = new System.Drawing.Point(1433, 333);
            this.LocTrangThaicomboBox.Name = "LocTrangThaicomboBox";
            this.LocTrangThaicomboBox.Size = new System.Drawing.Size(134, 26);
            this.LocTrangThaicomboBox.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1428, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 65;
            this.label10.Text = "Loại:";
            // 
            // LocloaiMAComboBox
            // 
            this.LocloaiMAComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocloaiMAComboBox.FormattingEnabled = true;
            this.LocloaiMAComboBox.Location = new System.Drawing.Point(1433, 276);
            this.LocloaiMAComboBox.Name = "LocloaiMAComboBox";
            this.LocloaiMAComboBox.Size = new System.Drawing.Size(134, 26);
            this.LocloaiMAComboBox.TabIndex = 64;
            this.LocloaiMAComboBox.SelectedIndexChanged += new System.EventHandler(this.LocloaiMAComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1428, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 63;
            this.label8.Text = "Lọc dữ liệu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(897, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Hình ảnh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "SDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Tên";
            // 
            // XoaBtn
            // 
            this.XoaBtn.Location = new System.Drawing.Point(377, 48);
            this.XoaBtn.Name = "XoaBtn";
            this.XoaBtn.Size = new System.Drawing.Size(115, 55);
            this.XoaBtn.TabIndex = 53;
            this.XoaBtn.Text = "Xóa";
            this.XoaBtn.UseVisualStyleBackColor = true;
            // 
            // LuuBtn
            // 
            this.LuuBtn.Location = new System.Drawing.Point(498, 48);
            this.LuuBtn.Name = "LuuBtn";
            this.LuuBtn.Size = new System.Drawing.Size(115, 55);
            this.LuuBtn.TabIndex = 54;
            this.LuuBtn.Text = "Lưu";
            this.LuuBtn.UseVisualStyleBackColor = true;
            // 
            // ThemBtn
            // 
            this.ThemBtn.Location = new System.Drawing.Point(257, 49);
            this.ThemBtn.Name = "ThemBtn";
            this.ThemBtn.Size = new System.Drawing.Size(115, 55);
            this.ThemBtn.TabIndex = 51;
            this.ThemBtn.Text = "Thêm";
            this.ThemBtn.UseVisualStyleBackColor = true;
            // 
            // DOBtxt
            // 
            this.DOBtxt.Location = new System.Drawing.Point(451, 163);
            this.DOBtxt.Name = "DOBtxt";
            this.DOBtxt.Size = new System.Drawing.Size(134, 22);
            this.DOBtxt.TabIndex = 48;
            this.DOBtxt.TextChanged += new System.EventHandler(this.GiaMonAnTextboxs_TextChanged);
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(451, 133);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(134, 22);
            this.Nametxt.TabIndex = 47;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.Name,
            this.SDT,
            this.Email,
            this.Lương,
            this.DOB});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(80, 258);
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
            this.dataGridView1.Size = new System.Drawing.Size(1331, 539);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchKeytextBox
            // 
            this.searchKeytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchKeytextBox.Location = new System.Drawing.Point(80, 189);
            this.searchKeytextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchKeytextBox.Name = "searchKeytextBox";
            this.searchKeytextBox.Size = new System.Drawing.Size(252, 30);
            this.searchKeytextBox.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-71, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 44;
            this.label7.Text = "Search";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Location = new System.Drawing.Point(963, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Ảnh món ăn";
            this.pictureBox1.WaitOnLoad = true;
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Image = global::Bar_Management.Properties.Resources.excelicon_;
            this.ExcelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExcelBtn.Location = new System.Drawing.Point(83, 48);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(170, 57);
            this.ExcelBtn.TabIndex = 52;
            this.ExcelBtn.Text = "Tải xuống danh sách";
            this.ExcelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExcelBtn.UseVisualStyleBackColor = true;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(726, 133);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(134, 22);
            this.Emailtxt.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Email";
            // 
            // Luongtxt
            // 
            this.Luongtxt.Location = new System.Drawing.Point(726, 163);
            this.Luongtxt.Name = "Luongtxt";
            this.Luongtxt.Size = new System.Drawing.Size(134, 22);
            this.Luongtxt.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(633, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Lương";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(726, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 26);
            this.comboBox1.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(633, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 58;
            this.label11.Text = "Chức vụ";
            // 
            // SDTtxt
            // 
            this.SDTtxt.Location = new System.Drawing.Point(451, 197);
            this.SDTtxt.Name = "SDTtxt";
            this.SDTtxt.Size = new System.Drawing.Size(134, 22);
            this.SDTtxt.TabIndex = 48;
            this.SDTtxt.TextChanged += new System.EventHandler(this.GiaMonAnTextboxs_TextChanged);
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
            // Name
            // 
            this.Name.HeaderText = "Tên";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Lương
            // 
            this.Lương.HeaderText = "Lương";
            this.Lương.MinimumWidth = 6;
            this.Lương.Name = "Lương";
            // 
            // DOB
            // 
            this.DOB.HeaderText = "Ngày Sinh";
            this.DOB.MinimumWidth = 6;
            this.DOB.Name = "DOB";
            // 
            // NameError
            // 
            this.NameError.ContainerControl = this;
            // 
            // DOBError
            // 
            this.DOBError.ContainerControl = this;
            // 
            // SDTError
            // 
            this.SDTError.ContainerControl = this;
            // 
            // EmailError
            // 
            this.EmailError.ContainerControl = this;
            // 
            // LuongError
            // 
            this.LuongError.ContainerControl = this;
            // 
            // errorHinhAnh
            // 
            this.errorHinhAnh.ContainerControl = this;
            // 
            // Employ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 886);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LocTrangThaicomboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LocloaiMAComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XoaBtn);
            this.Controls.Add(this.LuuBtn);
            this.Controls.Add(this.ExcelBtn);
            this.Controls.Add(this.ThemBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Luongtxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.SDTtxt);
            this.Controls.Add(this.DOBtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchKeytextBox);
            this.Controls.Add(this.label7);
            this.Name = "Employ";
            this.Text = "Employ";
            this.Load += new System.EventHandler(this.Employ_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOBError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SDTError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuongError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSortTrangthai;
        private System.Windows.Forms.RadioButton radioSortGia;
        private System.Windows.Forms.RadioButton radioSortLoaiMonAn;
        private System.Windows.Forms.RadioButton radioSortTenMonAn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox LocTrangThaicomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox LocloaiMAComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button XoaBtn;
        private System.Windows.Forms.Button LuuBtn;
        private System.Windows.Forms.Button ExcelBtn;
        private System.Windows.Forms.Button ThemBtn;
        private System.Windows.Forms.TextBox DOBtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchKeytextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Luongtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SDTtxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lương;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.ErrorProvider NameError;
        private System.Windows.Forms.ErrorProvider DOBError;
        private System.Windows.Forms.ErrorProvider SDTError;
        private System.Windows.Forms.ErrorProvider EmailError;
        private System.Windows.Forms.ErrorProvider LuongError;
        private System.Windows.Forms.ErrorProvider errorHinhAnh;
    }
}