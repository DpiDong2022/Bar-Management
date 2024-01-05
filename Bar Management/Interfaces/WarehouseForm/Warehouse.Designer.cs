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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTranthai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.XoaBtn = new System.Windows.Forms.Button();
            this.LuuBtn = new System.Windows.Forms.Button();
            this.ExcelBtn = new System.Windows.Forms.Button();
            this.ThemBtn = new System.Windows.Forms.Button();
            this.LoaiMonAnComboBox = new System.Windows.Forms.ComboBox();
            this.motaText = new System.Windows.Forms.TextBox();
            this.GiaMonAnTextboxs = new System.Windows.Forms.TextBox();
            this.TenMonAnbox = new System.Windows.Forms.TextBox();
            this.searchKeytextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LocTrangThaicomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LocloaiMAComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemNL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiMonAnDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Trạng thái:";
            // 
            // comboBoxTranthai
            // 
            this.comboBoxTranthai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxTranthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTranthai.FormattingEnabled = true;
            this.comboBoxTranthai.ItemHeight = 18;
            this.comboBoxTranthai.Items.AddRange(new object[] {
            "--Trạng thái--",
            "Còn",
            "Hết"});
            this.comboBoxTranthai.Location = new System.Drawing.Point(637, 158);
            this.comboBoxTranthai.Name = "comboBoxTranthai";
            this.comboBoxTranthai.Size = new System.Drawing.Size(134, 26);
            this.comboBoxTranthai.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(844, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Hình ảnh:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Location = new System.Drawing.Point(910, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Ảnh món ăn";
            this.pictureBox1.WaitOnLoad = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mô tả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tên món ăn:";
            // 
            // XoaBtn
            // 
            this.XoaBtn.Location = new System.Drawing.Point(324, 11);
            this.XoaBtn.Name = "XoaBtn";
            this.XoaBtn.Size = new System.Drawing.Size(115, 55);
            this.XoaBtn.TabIndex = 47;
            this.XoaBtn.Text = "Xóa";
            this.XoaBtn.UseVisualStyleBackColor = true;
            // 
            // LuuBtn
            // 
            this.LuuBtn.Location = new System.Drawing.Point(445, 11);
            this.LuuBtn.Name = "LuuBtn";
            this.LuuBtn.Size = new System.Drawing.Size(115, 55);
            this.LuuBtn.TabIndex = 48;
            this.LuuBtn.Text = "Lưu";
            this.LuuBtn.UseVisualStyleBackColor = true;
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Image = global::Bar_Management.Properties.Resources.excelicon_;
            this.ExcelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExcelBtn.Location = new System.Drawing.Point(30, 11);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(170, 57);
            this.ExcelBtn.TabIndex = 46;
            this.ExcelBtn.Text = "Tải xuống danh sách";
            this.ExcelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExcelBtn.UseVisualStyleBackColor = true;
            // 
            // ThemBtn
            // 
            this.ThemBtn.Location = new System.Drawing.Point(204, 12);
            this.ThemBtn.Name = "ThemBtn";
            this.ThemBtn.Size = new System.Drawing.Size(115, 55);
            this.ThemBtn.TabIndex = 45;
            this.ThemBtn.Text = "Thêm";
            this.ThemBtn.UseVisualStyleBackColor = true;
            // 
            // LoaiMonAnComboBox
            // 
            this.LoaiMonAnComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiMonAnComboBox.FormattingEnabled = true;
            this.LoaiMonAnComboBox.Location = new System.Drawing.Point(398, 158);
            this.LoaiMonAnComboBox.Name = "LoaiMonAnComboBox";
            this.LoaiMonAnComboBox.Size = new System.Drawing.Size(134, 26);
            this.LoaiMonAnComboBox.TabIndex = 43;
            // 
            // motaText
            // 
            this.motaText.CausesValidation = false;
            this.motaText.Location = new System.Drawing.Point(637, 64);
            this.motaText.MaxLength = 100;
            this.motaText.Multiline = true;
            this.motaText.Name = "motaText";
            this.motaText.Size = new System.Drawing.Size(249, 84);
            this.motaText.TabIndex = 44;
            // 
            // GiaMonAnTextboxs
            // 
            this.GiaMonAnTextboxs.Location = new System.Drawing.Point(398, 126);
            this.GiaMonAnTextboxs.Name = "GiaMonAnTextboxs";
            this.GiaMonAnTextboxs.Size = new System.Drawing.Size(134, 22);
            this.GiaMonAnTextboxs.TabIndex = 42;
            // 
            // TenMonAnbox
            // 
            this.TenMonAnbox.Location = new System.Drawing.Point(398, 98);
            this.TenMonAnbox.Name = "TenMonAnbox";
            this.TenMonAnbox.Size = new System.Drawing.Size(134, 22);
            this.TenMonAnbox.TabIndex = 41;
            // 
            // searchKeytextBox
            // 
            this.searchKeytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchKeytextBox.Location = new System.Drawing.Point(27, 152);
            this.searchKeytextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchKeytextBox.Name = "searchKeytextBox";
            this.searchKeytextBox.Size = new System.Drawing.Size(252, 30);
            this.searchKeytextBox.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "Search";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1229, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 61;
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
            this.LocTrangThaicomboBox.Location = new System.Drawing.Point(1228, 156);
            this.LocTrangThaicomboBox.Name = "LocTrangThaicomboBox";
            this.LocTrangThaicomboBox.Size = new System.Drawing.Size(134, 26);
            this.LocTrangThaicomboBox.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1223, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 59;
            this.label10.Text = "Loại:";
            // 
            // LocloaiMAComboBox
            // 
            this.LocloaiMAComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocloaiMAComboBox.FormattingEnabled = true;
            this.LocloaiMAComboBox.Location = new System.Drawing.Point(1228, 99);
            this.LocloaiMAComboBox.Name = "LocloaiMAComboBox";
            this.LocloaiMAComboBox.Size = new System.Drawing.Size(134, 26);
            this.LocloaiMAComboBox.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1223, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 57;
            this.label8.Text = "Lọc dữ liệu:";
            // 
            // btnThemNL
            // 
            this.btnThemNL.Location = new System.Drawing.Point(30, 74);
            this.btnThemNL.Name = "btnThemNL";
            this.btnThemNL.Size = new System.Drawing.Size(115, 55);
            this.btnThemNL.TabIndex = 62;
            this.btnThemNL.Text = "Thêm loại nguyên liệu";
            this.btnThemNL.UseVisualStyleBackColor = true;
            this.btnThemNL.Click += new System.EventHandler(this.btnThemNL_Click);
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
            this.TenMonDgv,
            this.LoaiMonAnDgv,
            this.GiaDgv,
            this.TrangThaiDgv,
            this.moTaDgv});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(27, 201);
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
            this.dataGridView1.TabIndex = 63;
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
            this.TenMonDgv.DataPropertyName = "TenMon";
            this.TenMonDgv.FillWeight = 30.32747F;
            this.TenMonDgv.HeaderText = "Tên món ăn";
            this.TenMonDgv.MinimumWidth = 6;
            this.TenMonDgv.Name = "TenMonDgv";
            // 
            // LoaiMonAnDgv
            // 
            this.LoaiMonAnDgv.DataPropertyName = "LoaiMonAn";
            this.LoaiMonAnDgv.FillWeight = 30.32747F;
            this.LoaiMonAnDgv.HeaderText = "Loại món ăn";
            this.LoaiMonAnDgv.MinimumWidth = 6;
            this.LoaiMonAnDgv.Name = "LoaiMonAnDgv";
            // 
            // GiaDgv
            // 
            this.GiaDgv.DataPropertyName = "Gia";
            this.GiaDgv.FillWeight = 30.32747F;
            this.GiaDgv.HeaderText = "Giá";
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
            // moTaDgv
            // 
            this.moTaDgv.DataPropertyName = "MoTa";
            this.moTaDgv.FillWeight = 30.32747F;
            this.moTaDgv.HeaderText = "Mô tả";
            this.moTaDgv.MinimumWidth = 6;
            this.moTaDgv.Name = "moTaDgv";
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1483, 767);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThemNL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LocTrangThaicomboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LocloaiMAComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxTranthai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XoaBtn);
            this.Controls.Add(this.LuuBtn);
            this.Controls.Add(this.ExcelBtn);
            this.Controls.Add(this.ThemBtn);
            this.Controls.Add(this.LoaiMonAnComboBox);
            this.Controls.Add(this.motaText);
            this.Controls.Add(this.GiaMonAnTextboxs);
            this.Controls.Add(this.TenMonAnbox);
            this.Controls.Add(this.searchKeytextBox);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTranthai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button XoaBtn;
        private System.Windows.Forms.Button LuuBtn;
        private System.Windows.Forms.Button ExcelBtn;
        private System.Windows.Forms.Button ThemBtn;
        private System.Windows.Forms.ComboBox LoaiMonAnComboBox;
        private System.Windows.Forms.TextBox motaText;
        private System.Windows.Forms.TextBox GiaMonAnTextboxs;
        private System.Windows.Forms.TextBox TenMonAnbox;
        private System.Windows.Forms.TextBox searchKeytextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox LocTrangThaicomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox LocloaiMAComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThemNL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiMonAnDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDgv;
    }
}