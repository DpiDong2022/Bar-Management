namespace Bar_Management.TableForm
{
    partial class NhaCungCap
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiMonAnDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(139, 151);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1122, 667);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 667);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhà cung cấp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.TenMonDgv,
            this.LoaiMonAnDgv,
            this.GiaDgv,
            this.TrangThaiDgv,
            this.moTaDgv});
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView2.Location = new System.Drawing.Point(4, 677);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1331, 566);
            this.dataGridView2.TabIndex = 20;
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
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1669, 869);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhaCungCap";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiMonAnDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDgv;
    }
}