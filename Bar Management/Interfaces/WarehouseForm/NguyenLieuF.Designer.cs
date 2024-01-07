namespace Bar_Management.Interfaces.WarehouseForm {
    partial class NguyenLieuF {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tboxTenNguyenLieu = new System.Windows.Forms.TextBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.errAnh = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenNL = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenNL)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(513, 431);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // tboxTenNguyenLieu
            // 
            this.tboxTenNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxTenNguyenLieu.Location = new System.Drawing.Point(12, 456);
            this.tboxTenNguyenLieu.Multiline = true;
            this.tboxTenNguyenLieu.Name = "tboxTenNguyenLieu";
            this.tboxTenNguyenLieu.Size = new System.Drawing.Size(191, 39);
            this.tboxTenNguyenLieu.TabIndex = 1;
            this.tboxTenNguyenLieu.Text = "Tên nguyên liệu";
            this.tboxTenNguyenLieu.Click += new System.EventHandler(this.tboxTenNguyenLieu_Click);
            this.tboxTenNguyenLieu.TextChanged += new System.EventHandler(this.tboxTenNguyenLieu_TextChanged);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(221, 456);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(126, 39);
            this.btnChonAnh.TabIndex = 3;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(192, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 39);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 507);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(157, 39);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Lưu";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errAnh
            // 
            this.errAnh.ContainerControl = this;
            // 
            // errTenNL
            // 
            this.errTenNL.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*\"";
            this.openFileDialog1.Title = "Chọn một hình ảnh";
            // 
            // NguyenLieuF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(537, 558);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.tboxTenNguyenLieu);
            this.Controls.Add(this.pictureBox);
            this.MaximumSize = new System.Drawing.Size(555, 605);
            this.MinimumSize = new System.Drawing.Size(555, 605);
            this.Name = "NguyenLieuF";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm loại nguyên liệu";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NguyenLieuF_MouseClick);
            this.MouseHover += new System.EventHandler(this.NguyenLieuF_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenNL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox tboxTenNguyenLieu;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errAnh;
        private System.Windows.Forms.ErrorProvider errTenNL;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}