using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.EmployeeForm
{
    public partial class EmployeeAdd : Form
    {
        public EmployeeAdd()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private bool Validate(string tenMon, string gia, string moTa, int loaiMonId, string trangThai)
        {
            bool isValid = true;
            if (!double.TryParse(gia, out double giaMonAn) || giaMonAn <= 0)
            {
                errorGia.SetError(GiaMonAnTextboxs, "Hãy điền giá trị là tiền");
                isValid = false;
            }
            else if (giaMonAn < 0)
            {
                errorGia.SetError(GiaMonAnTextboxs, "Giá tiền không nhỏ hơn 0");
                isValid = false;
            }
            else
            {
                errorGia.Clear();
            }

            if (string.IsNullOrEmpty(tenMon))
            {
                ErrorTenMonAn.SetError(TenMonAnbox, "Tên món ăn không để trống");
                isValid = false;
            }
            else if (tenMon.Length > 50)
            {
                ErrorTenMonAn.SetError(TenMonAnbox, "Tên món ăn vượt quá độ dài 50 kí tự");
                isValid = false;
            }
            else
            {
                ErrorTenMonAn.Clear();
            }

            if (loaiMonId == -1)
            {
                errorLoai.SetError(LoaiMonAnComboBox, "Bạn chưa chọn loại món ăn hoặc chưa có loại món ăn");
                isValid = false;
            }
            else if (new GenericRepository<LoaiMonAn>().GetAll().First(c => c.Id == loaiMonId) == null)
            {
                errorLoai.SetError(LoaiMonAnComboBox, "Loại món ăn không còn tồn tại");
                isValid = false;
            }
            else
            {
                errorLoai.Clear();
            }

            if (moTa.Length > 100)
            {
                errorMota.SetError(motaText, "Chiều dài mô tả không vượt quá 100");
                isValid = false;
            }
            else
            {
                errorMota.Clear();
            }

            if (pictureBox1.Image == null)
            {
                errorHinhAnh.SetError(pictureBox1, "Hãy chọn một hình ảnh cho món ăn");
                isValid = false;
            }
            else
            {
                errorHinhAnh.Clear();
            }

            if (trangThai == "--Trạng thái--")
            {
                errorTrangThai.SetError(comboBoxTranthai, "Hãy chọn trạng thái món ăn");
                isValid = false;
            }
            else
            {
                errorTrangThai.Clear();
            }
            return isValid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
