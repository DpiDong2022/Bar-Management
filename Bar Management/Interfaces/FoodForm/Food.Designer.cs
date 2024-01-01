namespace Bar_Management.FoodForm
{
    partial class Food
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiMonAnDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchKeytextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.TenMonAnbox = new System.Windows.Forms.TextBox();
            this.GiaMonAnTextboxs = new System.Windows.Forms.TextBox();
            this.motaText = new System.Windows.Forms.TextBox();
            this.LoaiMonAnComboBox = new System.Windows.Forms.ComboBox();
            this.loaiMonAnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBarHaiDataSet = new Bar_Management.QuanLyBarHaiDataSet();
            this.loaiMonAnsTableAdapter = new Bar_Management.QuanLyBarHaiDataSetTableAdapters.LoaiMonAnsTableAdapter();
            this.ThemBtn = new System.Windows.Forms.Button();
            this.LuuBtn = new System.Windows.Forms.Button();
            this.XoaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorMota = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorTenMonAn = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGia = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLoai = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEdit = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLuu = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorXoa = new System.Windows.Forms.ErrorProvider(this.components);
            this.SuaBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiMonAnsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBarHaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTenMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Menu List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.TenMonDgv,
            this.LoaiMonAnDgv,
            this.GiaDgv,
            this.TrangThaiDgv,
            this.moTaDgv});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(64, 211);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1331, 566);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "Id";
            this.dgvID.FillWeight = 30.32747F;
            this.dgvID.HeaderText = "ID";
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
            // searchKeytextBox
            // 
            this.searchKeytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchKeytextBox.Location = new System.Drawing.Point(64, 173);
            this.searchKeytextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchKeytextBox.Name = "searchKeytextBox";
            this.searchKeytextBox.Size = new System.Drawing.Size(252, 30);
            this.searchKeytextBox.TabIndex = 18;
            this.searchKeytextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Search";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(63, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 78);
            this.button1.TabIndex = 16;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Bar_Management.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 70F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Bar_Management.Properties.Resources.bin;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 70;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 70;
            // 
            // TenMonAnbox
            // 
            this.TenMonAnbox.Location = new System.Drawing.Point(435, 119);
            this.TenMonAnbox.Name = "TenMonAnbox";
            this.TenMonAnbox.Size = new System.Drawing.Size(134, 22);
            this.TenMonAnbox.TabIndex = 21;
            // 
            // GiaMonAnTextboxs
            // 
            this.GiaMonAnTextboxs.Location = new System.Drawing.Point(435, 147);
            this.GiaMonAnTextboxs.Name = "GiaMonAnTextboxs";
            this.GiaMonAnTextboxs.Size = new System.Drawing.Size(134, 22);
            this.GiaMonAnTextboxs.TabIndex = 22;
            // 
            // motaText
            // 
            this.motaText.CausesValidation = false;
            this.motaText.Location = new System.Drawing.Point(662, 119);
            this.motaText.MaxLength = 100;
            this.motaText.Multiline = true;
            this.motaText.Name = "motaText";
            this.motaText.Size = new System.Drawing.Size(249, 84);
            this.motaText.TabIndex = 24;
            // 
            // LoaiMonAnComboBox
            // 
            this.LoaiMonAnComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.loaiMonAnsBindingSource, "Id", true));
            this.LoaiMonAnComboBox.FormattingEnabled = true;
            this.LoaiMonAnComboBox.Location = new System.Drawing.Point(435, 179);
            this.LoaiMonAnComboBox.Name = "LoaiMonAnComboBox";
            this.LoaiMonAnComboBox.Size = new System.Drawing.Size(134, 24);
            this.LoaiMonAnComboBox.TabIndex = 23;
            this.LoaiMonAnComboBox.SelectedIndexChanged += new System.EventHandler(this.LoaiMonAnComboBox_SelectedIndexChanged);
            // 
            // loaiMonAnsBindingSource
            // 
            this.loaiMonAnsBindingSource.DataMember = "LoaiMonAns";
            this.loaiMonAnsBindingSource.DataSource = this.quanLyBarHaiDataSet;
            // 
            // quanLyBarHaiDataSet
            // 
            this.quanLyBarHaiDataSet.DataSetName = "QuanLyBarHaiDataSet";
            this.quanLyBarHaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiMonAnsTableAdapter
            // 
            this.loaiMonAnsTableAdapter.ClearBeforeFill = true;
            // 
            // ThemBtn
            // 
            this.ThemBtn.Location = new System.Drawing.Point(917, 148);
            this.ThemBtn.Name = "ThemBtn";
            this.ThemBtn.Size = new System.Drawing.Size(115, 55);
            this.ThemBtn.TabIndex = 25;
            this.ThemBtn.Text = "Thêm";
            this.ThemBtn.UseVisualStyleBackColor = true;
            this.ThemBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // LuuBtn
            // 
            this.LuuBtn.Location = new System.Drawing.Point(1158, 147);
            this.LuuBtn.Name = "LuuBtn";
            this.LuuBtn.Size = new System.Drawing.Size(115, 55);
            this.LuuBtn.TabIndex = 28;
            this.LuuBtn.Text = "Lưu";
            this.LuuBtn.UseVisualStyleBackColor = true;
            this.LuuBtn.Click += new System.EventHandler(this.LuuBtn_Click);
            // 
            // XoaBtn
            // 
            this.XoaBtn.Location = new System.Drawing.Point(1037, 147);
            this.XoaBtn.Name = "XoaBtn";
            this.XoaBtn.Size = new System.Drawing.Size(115, 55);
            this.XoaBtn.TabIndex = 27;
            this.XoaBtn.Text = "Xóa";
            this.XoaBtn.UseVisualStyleBackColor = true;
            this.XoaBtn.Click += new System.EventHandler(this.XoaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tên món ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Loại:";
            // 
            // errorMota
            // 
            this.errorMota.ContainerControl = this;
            // 
            // ErrorTenMonAn
            // 
            this.ErrorTenMonAn.ContainerControl = this;
            // 
            // errorGia
            // 
            this.errorGia.ContainerControl = this;
            // 
            // errorLoai
            // 
            this.errorLoai.ContainerControl = this;
            // 
            // errorEdit
            // 
            this.errorEdit.ContainerControl = this;
            // 
            // errorLuu
            // 
            this.errorLuu.ContainerControl = this;
            // 
            // errorXoa
            // 
            this.errorXoa.ContainerControl = this;
            // 
            // SuaBtn
            // 
            this.SuaBtn.Image = global::Bar_Management.Properties.Resources.excelicon_;
            this.SuaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuaBtn.Location = new System.Drawing.Point(916, 84);
            this.SuaBtn.Name = "SuaBtn";
            this.SuaBtn.Size = new System.Drawing.Size(170, 57);
            this.SuaBtn.TabIndex = 26;
            this.SuaBtn.Text = "Tải xuống danh sách";
            this.SuaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuaBtn.UseVisualStyleBackColor = true;
            this.SuaBtn.Click += new System.EventHandler(this.SuaBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1556, 880);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XoaBtn);
            this.Controls.Add(this.LuuBtn);
            this.Controls.Add(this.SuaBtn);
            this.Controls.Add(this.ThemBtn);
            this.Controls.Add(this.LoaiMonAnComboBox);
            this.Controls.Add(this.motaText);
            this.Controls.Add(this.GiaMonAnTextboxs);
            this.Controls.Add(this.TenMonAnbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchKeytextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Food";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Food_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Food_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiMonAnsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBarHaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTenMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchKeytextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox TenMonAnbox;
        private System.Windows.Forms.TextBox GiaMonAnTextboxs;
        private System.Windows.Forms.TextBox motaText;
        private System.Windows.Forms.ComboBox LoaiMonAnComboBox;
        private QuanLyBarHaiDataSet quanLyBarHaiDataSet;
        private System.Windows.Forms.BindingSource loaiMonAnsBindingSource;
        private QuanLyBarHaiDataSetTableAdapters.LoaiMonAnsTableAdapter loaiMonAnsTableAdapter;
        private System.Windows.Forms.Button ThemBtn;
        private System.Windows.Forms.Button LuuBtn;
        private System.Windows.Forms.Button XoaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorMota;
        private System.Windows.Forms.ErrorProvider ErrorTenMonAn;
        private System.Windows.Forms.ErrorProvider errorGia;
        private System.Windows.Forms.ErrorProvider errorLoai;
        private System.Windows.Forms.ErrorProvider errorEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiMonAnDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDgv;
        private System.Windows.Forms.ErrorProvider errorLuu;
        private System.Windows.Forms.ErrorProvider errorXoa;
        private System.Windows.Forms.Button SuaBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}