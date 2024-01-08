﻿namespace Bar_Management.Interfaces.AccountForm
{
    partial class Account
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
            this.radioSortLoaiMonAn = new System.Windows.Forms.RadioButton();
            this.radioSortRole = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.XoaBtn = new System.Windows.Forms.Button();
            this.LuuBtn = new System.Windows.Forms.Button();
            this.ThemBtn = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchKeytextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ExcelBtn = new System.Windows.Forms.Button();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMatkhau = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTennguoidung = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRole = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbTennhanvien = new System.Windows.Forms.ComboBox();
            this.errorNhanvien = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorXoa = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMatkhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTennguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSortLoaiMonAn);
            this.groupBox1.Controls.Add(this.radioSortRole);
            this.groupBox1.Location = new System.Drawing.Point(1289, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 158);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sắp xếp bảng";
            // 
            // radioSortLoaiMonAn
            // 
            this.radioSortLoaiMonAn.AutoSize = true;
            this.radioSortLoaiMonAn.Location = new System.Drawing.Point(27, 54);
            this.radioSortLoaiMonAn.Name = "radioSortLoaiMonAn";
            this.radioSortLoaiMonAn.Size = new System.Drawing.Size(65, 20);
            this.radioSortLoaiMonAn.TabIndex = 1;
            this.radioSortLoaiMonAn.TabStop = true;
            this.radioSortLoaiMonAn.Text = "Lương";
            this.radioSortLoaiMonAn.UseVisualStyleBackColor = true;
            // 
            // radioSortRole
            // 
            this.radioSortRole.AutoSize = true;
            this.radioSortRole.Location = new System.Drawing.Point(27, 28);
            this.radioSortRole.Name = "radioSortRole";
            this.radioSortRole.Size = new System.Drawing.Size(55, 20);
            this.radioSortRole.TabIndex = 0;
            this.radioSortRole.TabStop = true;
            this.radioSortRole.Text = "Tên ";
            this.radioSortRole.UseVisualStyleBackColor = true;
            this.radioSortRole.CheckedChanged += new System.EventHandler(this.radioSortRole_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(805, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 89;
            this.label6.Text = "Role";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbRole
            // 
            this.cbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.ItemHeight = 18;
            this.cbRole.Items.AddRange(new object[] {
            "--Role--"});
            this.cbRole.Location = new System.Drawing.Point(918, 265);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(203, 26);
            this.cbRole.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(796, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 82;
            this.label11.Text = "Tên người dùng";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = " Tên Tài Khoản";
            // 
            // XoaBtn
            // 
            this.XoaBtn.Location = new System.Drawing.Point(359, 111);
            this.XoaBtn.Name = "XoaBtn";
            this.XoaBtn.Size = new System.Drawing.Size(115, 55);
            this.XoaBtn.TabIndex = 79;
            this.XoaBtn.Text = "Xóa";
            this.XoaBtn.UseVisualStyleBackColor = true;
            this.XoaBtn.Click += new System.EventHandler(this.XoaBtn_Click);
            // 
            // LuuBtn
            // 
            this.LuuBtn.Location = new System.Drawing.Point(480, 111);
            this.LuuBtn.Name = "LuuBtn";
            this.LuuBtn.Size = new System.Drawing.Size(115, 55);
            this.LuuBtn.TabIndex = 80;
            this.LuuBtn.Text = "Lưu";
            this.LuuBtn.UseVisualStyleBackColor = true;
            this.LuuBtn.Click += new System.EventHandler(this.LuuBtn_Click);
            // 
            // ThemBtn
            // 
            this.ThemBtn.Location = new System.Drawing.Point(239, 112);
            this.ThemBtn.Name = "ThemBtn";
            this.ThemBtn.Size = new System.Drawing.Size(115, 55);
            this.ThemBtn.TabIndex = 77;
            this.ThemBtn.Text = "Thêm";
            this.ThemBtn.UseVisualStyleBackColor = true;
            this.ThemBtn.Click += new System.EventHandler(this.ThemBtn_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(468, 209);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(247, 29);
            this.txtTen.TabIndex = 73;
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
            this.ID,
            this.Ten,
            this.DOB,
            this.SDT,
            this.Email});
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
            this.dataGridView1.Location = new System.Drawing.Point(61, 324);
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
            this.dataGridView1.Size = new System.Drawing.Size(1476, 539);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên tài khoản";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "MatKhau";
            this.DOB.HeaderText = "Mật khẩu";
            this.DOB.MinimumWidth = 6;
            this.DOB.Name = "DOB";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "NhanVien";
            this.SDT.HeaderText = "Nhân viên";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Role";
            this.Email.HeaderText = "Role";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // searchKeytextBox
            // 
            this.searchKeytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchKeytextBox.Location = new System.Drawing.Point(62, 252);
            this.searchKeytextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchKeytextBox.Name = "searchKeytextBox";
            this.searchKeytextBox.Size = new System.Drawing.Size(252, 30);
            this.searchKeytextBox.TabIndex = 71;
            this.searchKeytextBox.TextChanged += new System.EventHandler(this.searchKeytextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 70;
            this.label7.Text = "Search";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Image = global::Bar_Management.Properties.Resources.excelicon_;
            this.ExcelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExcelBtn.Location = new System.Drawing.Point(65, 111);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(170, 57);
            this.ExcelBtn.TabIndex = 78;
            this.ExcelBtn.Text = "Tải xuống danh sách";
            this.ExcelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExcelBtn.UseVisualStyleBackColor = true;
            this.ExcelBtn.Click += new System.EventHandler(this.ExcelBtn_Click);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(468, 259);
            this.txtMatkhau.Multiline = true;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(247, 29);
            this.txtMatkhau.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Mật khẩu";
            // 
            // errorTen
            // 
            this.errorTen.ContainerControl = this;
            // 
            // errorMatkhau
            // 
            this.errorMatkhau.ContainerControl = this;
            // 
            // errorTennguoidung
            // 
            this.errorTennguoidung.ContainerControl = this;
            // 
            // errorRole
            // 
            this.errorRole.ContainerControl = this;
            // 
            // cbTennhanvien
            // 
            this.cbTennhanvien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTennhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTennhanvien.FormattingEnabled = true;
            this.cbTennhanvien.ItemHeight = 18;
            this.cbTennhanvien.Items.AddRange(new object[] {
            "--Tên người dùng--"});
            this.cbTennhanvien.Location = new System.Drawing.Point(918, 215);
            this.cbTennhanvien.Name = "cbTennhanvien";
            this.cbTennhanvien.Size = new System.Drawing.Size(203, 26);
            this.cbTennhanvien.TabIndex = 88;
            // 
            // errorNhanvien
            // 
            this.errorNhanvien.ContainerControl = this;
            // 
            // errorXoa
            // 
            this.errorXoa.ContainerControl = this;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 1008);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTennhanvien);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XoaBtn);
            this.Controls.Add(this.LuuBtn);
            this.Controls.Add(this.ExcelBtn);
            this.Controls.Add(this.ThemBtn);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchKeytextBox);
            this.Controls.Add(this.label7);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMatkhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTennguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorXoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSortLoaiMonAn;
        private System.Windows.Forms.RadioButton radioSortRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button XoaBtn;
        private System.Windows.Forms.Button LuuBtn;
        private System.Windows.Forms.Button ExcelBtn;
        private System.Windows.Forms.Button ThemBtn;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchKeytextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorTen;
        private System.Windows.Forms.ErrorProvider errorMatkhau;
        private System.Windows.Forms.ErrorProvider errorTennguoidung;
        private System.Windows.Forms.ErrorProvider errorRole;
        private System.Windows.Forms.ComboBox cbTennhanvien;
        private System.Windows.Forms.ErrorProvider errorNhanvien;
        private System.Windows.Forms.ErrorProvider errorXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}