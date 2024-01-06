using AutoMapper;
using Bar_Management.BusinessLogic;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.Interfaces.EmployeeForm
{
    public partial class Employ : Form
    {
        private readonly NhanVienLogic _logic;        
        private SortableBindingList<NhanVienDTO> _table;

        private SortableBindingList<LoaiMonAn> _tableLoaimonAn;
        private SortableBindingList<LoaiMonAn> _tableLoaimonAn2;
        private readonly IMapper _mapper;
        private string _picturePath;
        byte[] _imageDataStart;
        byte[] _imageDataEnd;
        string _urlImage;
        int _rowHoverIndex;
        public Employ()
        {
            InitializeComponent();
        }
        private bool Validate(string ten, string NgaySinh, string SDT, string Email, string Luong)
        {
            //Lương
            bool isValid = true;
            if (!decimal.TryParse(Luong, out decimal LuongNV) || LuongNV <= 0)
            {
                LuongError.SetError(Nametxt, "Hãy điền giá trị là tiền");
                isValid = false;
            }
            else if (LuongNV < 0)
            {
                LuongError.SetError(DOBtxt, "Giá tiền không nhỏ hơn 0");
                isValid = false;
            }
            else
            {
                LuongError.Clear();
            }

            //Ngày sinh
            if (!DateTime.TryParse(NgaySinh, out DateTime NgaySinhNV) )
            {
                DOBError.SetError(Nametxt, "Hãy điền thời gian");
                isValid = false;
            }
            else if (NgaySinhNV.Year <= 2005)
            {
                LuongError.SetError(DOBtxt, "Năm sinh không nhỏ hơn 2005");
                isValid = false;
            }
            else
            {
                DOBError.Clear();
            }

            //Tên
            if (string.IsNullOrEmpty(ten))
            {
                NameError.SetError(Nametxt, "Tên nhân viên không để trống");
                isValid = false;
            }
            else if (ten.Length > 50)
            {
                NameError.SetError(Nametxt, "Tên nhân viên vượt quá độ dài 50 kí tự");
                isValid = false;
            }
            else
            {
                NameError.Clear();
            }

            //SDT
            if (string.IsNullOrEmpty(SDT))
            {
                SDTError.SetError(Nametxt, "SDT nhân viên không để trống");
                isValid = false;
            }
            else if (SDT.Length > 11)
            {
                SDTError.SetError(Nametxt, "SDT nhân viên vượt quá độ dài 11 kí tự");
                isValid = false;
            }
            else
            {
                SDTError.Clear();
            }


            //Email
            if (string.IsNullOrEmpty(Email))
            {
                EmailError.SetError(Nametxt, "Email nhân viên không để trống");
                isValid = false;
            }
            else if (Email.Length > 50)
            {
                EmailError.SetError(Nametxt, "Email nhân viên vượt quá độ dài 50 kí tự");
                isValid = false;
            }
            else
            {
                EmailError.Clear();
            }

            //if (loaiMonId == -1)
            //{
            //    errorLoai.SetError(LoaiMonAnComboBox, "Bạn chưa chọn loại món ăn hoặc chưa có loại món ăn");
            //    isValid = false;
            //}
            //else if (new GenericRepository<LoaiMonAn>().GetAll().First(c => c.Id == loaiMonId) == null)
            //{
            //    errorLoai.SetError(LoaiMonAnComboBox, "Loại món ăn không còn tồn tại");
            //    isValid = false;
            //}
            //else
            //{
            //    errorLoai.Clear();
            //}

           
            //Hình ảnh
            if (pictureBox1.Image == null)
            {
                errorHinhAnh.SetError(pictureBox1, "Hãy chọn một hình ảnh cho nhân viên");
                isValid = false;
            }
            else
            {
                errorHinhAnh.Clear();
            }
            return isValid;
        }
        private void GiaMonAnTextboxs_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LocloaiMAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Employ_Load(object sender, EventArgs e)
        {

        }
    }
}
