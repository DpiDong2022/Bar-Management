using Bar_Management.BusinessLogic;
using Bar_Management.Tool;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.Interfaces.WarehouseForm {
    public partial class NguyenLieuF: Form {
        public string TenNguyenLieu;
        public string ImagePath;
        private readonly NguyenLieuLogic _nguyenLieuLogic;
        public NguyenLieuF() {
            InitializeComponent();
            tboxTenNguyenLieu.Focus();
            _nguyenLieuLogic = new NguyenLieuLogic();
        }

        private void tboxTenNguyenLieu_TextChanged(object sender, EventArgs e) {

        }

        private void tboxTenNguyenLieu_Click(object sender, EventArgs e) {
            tboxTenNguyenLieu.Text = string.Empty;
        }

        private void btnChonAnh_Click(object sender, EventArgs e) {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK) {
            //    if (Helper.IsImageFile(pictureBox.ImageLocation)) {
            //        pictureBox.ImageLocation = openFileDialog1.FileName;
            //    } else {
            //        MessageBox.Show("Hãy chọn một ảnh đúng định dạng");
            //    }
               
            //}
        }

        private void NguyenLieuF_MouseClick(object sender, MouseEventArgs e) {

        }

        private void NguyenLieuF_MouseHover(object sender, EventArgs e) {
            if (tboxTenNguyenLieu.Text.Length == 0) {
                tboxTenNguyenLieu.Text = "Tên nguyên liệu";
            }
        }

        private void pictureBox_MouseHover(object sender, EventArgs e) {
            if (tboxTenNguyenLieu.Text.Length == 0) {
                tboxTenNguyenLieu.Text = "Tên nguyên liệu";
            }
        }

        private bool isValidate(string ten) {
            bool isValid = true;
            if (ten.Length == 0) {
                isValid = false;
                errTenNL.SetError(tboxTenNguyenLieu, "Tên nguyên liệu không để chống");
            } else {
                errTenNL.Clear();
            }

            //if (string.IsNullOrEmpty(pictureBox.ImageLocation)) {
            //    errAnh.SetError(btnChonAnh, "Bạn chưa chọn ảnh");
            //    isValid = false;
            //} else if(!File.Exists(pictureBox.ImageLocation)){
            //    isValid = false;
            //    errAnh.SetError(btnChonAnh, "Ảnh không tồn tại");
            //} else {
            //    errAnh.Clear();
            //}

            if (_nguyenLieuLogic.GetAll().Any(nl => nl.Ten.ToLower()== tboxTenNguyenLieu.Text.ToLower())) {
                isValid = false;
                errTenNL.SetError(tboxTenNguyenLieu, "Tên loại đã tồn tại");
            } else {
                errTenNL.Clear();
            }

            return isValid;
        }

        private async void btnOk_Click(object sender, EventArgs e) {
            if (isValidate(tboxTenNguyenLieu.Text)) {
                TenNguyenLieu = tboxTenNguyenLieu.Text.Trim();
                ImagePath = pictureBox.ImageLocation;
              
                string url = await CloudinaryService.uploadImage(ImagePath);
                new LoadingForm(2).ShowDialog();
                bool insertSuccess = _nguyenLieuLogic.Insert(new Models.NguyenLieu() {Ten=TenNguyenLieu, HinhAnh=url });
                if (insertSuccess) {
                    MessageBox.Show("Thêm thành công");
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void pictureBox_Click(object sender, EventArgs e) {

        }
    }
}
