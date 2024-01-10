namespace Bar_Management.OrderHistoryForm
{
    partial class OrderHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenbanDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locBan = new System.Windows.Forms.ComboBox();
            this.STT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locNhanVien = new System.Windows.Forms.ComboBox();
            this.locTrangThai = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSortGia = new System.Windows.Forms.RadioButton();
            this.sorTimein = new System.Windows.Forms.RadioButton();
            this.sortTenBan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order History";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeEnd.Location = new System.Drawing.Point(297, 246);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(207, 30);
            this.dateTimeEnd.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "to";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeStart.Location = new System.Drawing.Point(52, 246);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(198, 30);
            this.dateTimeStart.TabIndex = 16;
            this.dateTimeStart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle25.NullValue = null;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.dgvID,
            this.TenbanDgv,
            this.TimeIn,
            this.GiaDgv,
            this.TrangThaiDgv,
            this.nhanVienDgv});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(52, 285);
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
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.dataGridView1.RowTemplate.Height = 44;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(970, 710);
            this.dataGridView1.TabIndex = 20;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle28.NullValue = null;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView2.ColumnHeadersHeight = 50;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(1030, 120);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MistyRose;
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.dataGridView2.RowTemplate.Height = 44;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(703, 875);
            this.dataGridView2.TabIndex = 21;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
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
            // TenbanDgv
            // 
            this.TenbanDgv.DataPropertyName = "TenBan";
            this.TenbanDgv.FillWeight = 30.32747F;
            this.TenbanDgv.HeaderText = "Tên bàn";
            this.TenbanDgv.MinimumWidth = 6;
            this.TenbanDgv.Name = "TenbanDgv";
            // 
            // TimeIn
            // 
            this.TimeIn.DataPropertyName = "NgayTao";
            this.TimeIn.FillWeight = 30.32747F;
            this.TimeIn.HeaderText = "Time in";
            this.TimeIn.MinimumWidth = 6;
            this.TimeIn.Name = "TimeIn";
            // 
            // GiaDgv
            // 
            this.GiaDgv.DataPropertyName = "TongGia";
            this.GiaDgv.FillWeight = 30.32747F;
            this.GiaDgv.HeaderText = "Tổng";
            this.GiaDgv.MinimumWidth = 6;
            this.GiaDgv.Name = "GiaDgv";
            // 
            // TrangThaiDgv
            // 
            this.TrangThaiDgv.DataPropertyName = "TrangThai";
            this.TrangThaiDgv.FillWeight = 70F;
            this.TrangThaiDgv.HeaderText = "Trạng thái";
            this.TrangThaiDgv.MinimumWidth = 70;
            this.TrangThaiDgv.Name = "TrangThaiDgv";
            this.TrangThaiDgv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nhanVienDgv
            // 
            this.nhanVienDgv.DataPropertyName = "TaiKhoanTao";
            this.nhanVienDgv.FillWeight = 30.32747F;
            this.nhanVienDgv.HeaderText = "Nhân viên tạo";
            this.nhanVienDgv.MinimumWidth = 6;
            this.nhanVienDgv.Name = "nhanVienDgv";
            // 
            // locBan
            // 
            this.locBan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.locBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locBan.FormattingEnabled = true;
            this.locBan.ItemHeight = 22;
            this.locBan.Items.AddRange(new object[] {
            "--Trạng thái--",
            "Còn",
            "Hết"});
            this.locBan.Location = new System.Drawing.Point(514, 246);
            this.locBan.Name = "locBan";
            this.locBan.Size = new System.Drawing.Size(165, 30);
            this.locBan.TabIndex = 46;
            // 
            // STT2
            // 
            this.STT2.HeaderText = "STT";
            this.STT2.MinimumWidth = 6;
            this.STT2.Name = "STT2";
            this.STT2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 30.32747F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MonAn";
            this.dataGridViewTextBoxColumn2.FillWeight = 30.32747F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Món ăn";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong(none)";
            this.dataGridViewTextBoxColumn3.FillWeight = 30.32747F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ThanhTien";
            this.dataGridViewTextBoxColumn4.FillWeight = 30.32747F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Thành tiền";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // locNhanVien
            // 
            this.locNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.locNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locNhanVien.FormattingEnabled = true;
            this.locNhanVien.ItemHeight = 22;
            this.locNhanVien.Items.AddRange(new object[] {
            "--Trạng thái--",
            "Còn",
            "Hết"});
            this.locNhanVien.Location = new System.Drawing.Point(856, 245);
            this.locNhanVien.Name = "locNhanVien";
            this.locNhanVien.Size = new System.Drawing.Size(165, 30);
            this.locNhanVien.TabIndex = 48;
            // 
            // locTrangThai
            // 
            this.locTrangThai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.locTrangThai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locTrangThai.FormattingEnabled = true;
            this.locTrangThai.ItemHeight = 22;
            this.locTrangThai.Items.AddRange(new object[] {
            "--Trạng thái--",
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.locTrangThai.Location = new System.Drawing.Point(685, 245);
            this.locTrangThai.Name = "locTrangThai";
            this.locTrangThai.Size = new System.Drawing.Size(165, 30);
            this.locTrangThai.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sorTimein);
            this.groupBox1.Controls.Add(this.radioSortGia);
            this.groupBox1.Controls.Add(this.sortTenBan);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 119);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(Sắp xếp bảng)";
            // 
            // radioSortGia
            // 
            this.radioSortGia.AutoSize = true;
            this.radioSortGia.Location = new System.Drawing.Point(28, 84);
            this.radioSortGia.Name = "radioSortGia";
            this.radioSortGia.Size = new System.Drawing.Size(64, 23);
            this.radioSortGia.TabIndex = 2;
            this.radioSortGia.TabStop = true;
            this.radioSortGia.Text = "Tổng";
            this.radioSortGia.UseVisualStyleBackColor = true;
            this.radioSortGia.CheckedChanged += new System.EventHandler(this.radioSortGia_CheckedChanged);
            // 
            // sorTimein
            // 
            this.sorTimein.AutoSize = true;
            this.sorTimein.Location = new System.Drawing.Point(28, 55);
            this.sorTimein.Name = "sorTimein";
            this.sorTimein.Size = new System.Drawing.Size(81, 23);
            this.sorTimein.TabIndex = 1;
            this.sorTimein.TabStop = true;
            this.sorTimein.Text = "Time in";
            this.sorTimein.UseVisualStyleBackColor = true;
            this.sorTimein.CheckedChanged += new System.EventHandler(this.sorTimein_CheckedChanged);
            // 
            // sortTenBan
            // 
            this.sortTenBan.AutoSize = true;
            this.sortTenBan.Location = new System.Drawing.Point(28, 29);
            this.sortTenBan.Name = "sortTenBan";
            this.sortTenBan.Size = new System.Drawing.Size(82, 23);
            this.sortTenBan.TabIndex = 0;
            this.sortTenBan.TabStop = true;
            this.sortTenBan.Text = "Tên bàn";
            this.sortTenBan.UseVisualStyleBackColor = true;
            this.sortTenBan.CheckedChanged += new System.EventHandler(this.sortTenBan_CheckedChanged);
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1918, 1028);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.locTrangThai);
            this.Controls.Add(this.locNhanVien);
            this.Controls.Add(this.locBan);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(200000, 200000);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "OrderHistory";
            this.Text = "OrderHistory";
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenbanDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanVienDgv;
        private System.Windows.Forms.ComboBox locBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox locNhanVien;
        private System.Windows.Forms.ComboBox locTrangThai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSortGia;
        private System.Windows.Forms.RadioButton sorTimein;
        private System.Windows.Forms.RadioButton sortTenBan;
    }
}