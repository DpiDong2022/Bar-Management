namespace Bar_Management.OrderForm
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.Label();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.product1 = new Bar_Management.Models.Product();
            this.product2 = new Bar_Management.Models.Product();
            this.product3 = new Bar_Management.Models.Product();
            this.product4 = new Bar_Management.Models.Product();
            this.gunaDataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnTInhTien = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBochon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.CategoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.CategoryPanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 1055);
            this.panel1.TabIndex = 0;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Controls.Add(this.guna2Button1);
            this.CategoryPanel.Location = new System.Drawing.Point(41, 149);
            this.CategoryPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(171, 633);
            this.CategoryPanel.TabIndex = 3;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(3, 2);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(168, 54);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bar_Management.Properties.Resources.bar_counter1;
            this.pictureBox1.Location = new System.Drawing.Point(53, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(244, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1680, 96);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bar_Management.Properties.Resources.cocktail_drink;
            this.pictureBox2.Location = new System.Drawing.Point(8, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 96);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(780, 468);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(384, 111);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(941, 763);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 41);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1633, 240);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 92);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1206, 760);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(189, 44);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.Text = "Total Cost";
            this.txtTotal.Click += new System.EventHandler(this.txtTotal_Click);
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.product1);
            this.ProductPanel.Controls.Add(this.product2);
            this.ProductPanel.Controls.Add(this.product3);
            this.ProductPanel.Controls.Add(this.product4);
            this.ProductPanel.Location = new System.Drawing.Point(288, 149);
            this.ProductPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(627, 602);
            this.ProductPanel.TabIndex = 18;
            // 
            // product1
            // 
            this.product1.Id = 0;
            this.product1.Location = new System.Drawing.Point(3, 2);
            this.product1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.product1.Name = "product1";
            this.product1.PCatergory = null;
            this.product1.PImage = ((System.Drawing.Image)(resources.GetObject("product1.PImage")));
            this.product1.PName = "ProductName";
            this.product1.PPrice = null;
            this.product1.Size = new System.Drawing.Size(149, 150);
            this.product1.TabIndex = 0;
            // 
            // product2
            // 
            this.product2.Id = 0;
            this.product2.Location = new System.Drawing.Point(158, 2);
            this.product2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.product2.Name = "product2";
            this.product2.PCatergory = null;
            this.product2.PImage = ((System.Drawing.Image)(resources.GetObject("product2.PImage")));
            this.product2.PName = "ProductName";
            this.product2.PPrice = null;
            this.product2.Size = new System.Drawing.Size(149, 150);
            this.product2.TabIndex = 1;
            // 
            // product3
            // 
            this.product3.Id = 0;
            this.product3.Location = new System.Drawing.Point(313, 2);
            this.product3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.product3.Name = "product3";
            this.product3.PCatergory = null;
            this.product3.PImage = ((System.Drawing.Image)(resources.GetObject("product3.PImage")));
            this.product3.PName = "ProductName";
            this.product3.PPrice = null;
            this.product3.Size = new System.Drawing.Size(149, 150);
            this.product3.TabIndex = 2;
            // 
            // product4
            // 
            this.product4.Id = 0;
            this.product4.Location = new System.Drawing.Point(468, 2);
            this.product4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.product4.Name = "product4";
            this.product4.PCatergory = null;
            this.product4.PImage = ((System.Drawing.Image)(resources.GetObject("product4.PImage")));
            this.product4.PName = "ProductName";
            this.product4.PPrice = null;
            this.product4.Size = new System.Drawing.Size(149, 150);
            this.product4.TabIndex = 3;
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.ColumnHeadersHeight = 18;
            this.gunaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvStt,
            this.dgvId,
            this.dgvTenmon,
            this.dgvQty,
            this.dgvGia,
            this.dgvThanhtien});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(941, 153);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.Size = new System.Drawing.Size(671, 598);
            this.gunaDataGridView1.TabIndex = 19;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 18;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = true;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick_1);
            this.gunaDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gunaDataGridView1_CellFormatting);
            // 
            // dgvStt
            // 
            this.dgvStt.HeaderText = "Stt";
            this.dgvStt.MinimumWidth = 6;
            this.dgvStt.Name = "dgvStt";
            this.dgvStt.ReadOnly = true;
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "Id";
            this.dgvId.MinimumWidth = 6;
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Visible = false;
            // 
            // dgvTenmon
            // 
            this.dgvTenmon.HeaderText = "Tên món";
            this.dgvTenmon.MinimumWidth = 6;
            this.dgvTenmon.Name = "dgvTenmon";
            this.dgvTenmon.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.HeaderText = "Số lượng";
            this.dgvQty.MinimumWidth = 6;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            // 
            // dgvGia
            // 
            this.dgvGia.HeaderText = "Giá";
            this.dgvGia.MinimumWidth = 6;
            this.dgvGia.Name = "dgvGia";
            this.dgvGia.ReadOnly = true;
            // 
            // dgvThanhtien
            // 
            this.dgvThanhtien.HeaderText = "Thành tiền ";
            this.dgvThanhtien.MinimumWidth = 6;
            this.dgvThanhtien.Name = "dgvThanhtien";
            this.dgvThanhtien.ReadOnly = true;
            // 
            // btnTru
            // 
            this.btnTru.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTru.Location = new System.Drawing.Point(1633, 367);
            this.btnTru.Margin = new System.Windows.Forms.Padding(4);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(93, 85);
            this.btnTru.TabIndex = 15;
            this.btnTru.Text = "Bớt";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnTInhTien
            // 
            this.btnTInhTien.Location = new System.Drawing.Point(1049, 763);
            this.btnTInhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTInhTien.Name = "btnTInhTien";
            this.btnTInhTien.Size = new System.Drawing.Size(127, 41);
            this.btnTInhTien.TabIndex = 21;
            this.btnTInhTien.Text = "Thanh Toán";
            this.btnTInhTien.UseVisualStyleBackColor = true;
            this.btnTInhTien.Click += new System.EventHandler(this.btnTInhTien_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 70F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Bar_Management.Properties.Resources.bin;
            this.dataGridViewImageColumn1.MinimumWidth = 70;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // btnBochon
            // 
            this.btnBochon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBochon.Location = new System.Drawing.Point(1633, 490);
            this.btnBochon.Margin = new System.Windows.Forms.Padding(4);
            this.btnBochon.Name = "btnBochon";
            this.btnBochon.Size = new System.Drawing.Size(93, 89);
            this.btnBochon.TabIndex = 15;
            this.btnBochon.Text = "Bỏ chọn";
            this.btnBochon.UseVisualStyleBackColor = true;
            this.btnBochon.Click += new System.EventHandler(this.btnBochon_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnTInhTien);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnBochon);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1942, 1252);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Payment_FormClosed);
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel1.ResumeLayout(false);
            this.CategoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Models.Product product2;
        private Models.Product product1;
        private Models.Product product4;
        private Models.Product product3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private System.Windows.Forms.Label txtTotal;
        private Guna.UI2.WinForms.Guna2DataGridView gunaDataGridView1;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnTInhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvThanhtien;
        private System.Windows.Forms.Button btnBochon;
    }
}