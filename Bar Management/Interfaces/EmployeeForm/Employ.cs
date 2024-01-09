using AutoMapper;
using Bar_Management.BusinessLogic;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Models;
using Bar_Management.Tool;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        
        private readonly IMapper _mapper;
        private string _picturePath;
        byte[] _imageDataStart;
        byte[] _imageDataEnd;
        string _urlImage;
        int _rowHoverIndex;
        public Employ()
        {
            InitializeComponent();
            _logic = new NhanVienLogic();
            _mapper = AutoMapperProfile.InitializeAutoMapper();
            
        }

        private void LoadTable()
        {
            if (_table != null)
            {
                _table = null;
            }
            _table = new SortableBindingList<NhanVienDTO>(_logic.GetAll().ToList());
            dataGridView1.DataSource = _table;
            dataGridView1.Columns["HinhAnh"].Visible = false;
        }
        private bool Validate(string ten, string luong, string ngaysinh, string SDT, string Email)
        {
            bool isValid = true;
            var checkNV = _logic.GetAll().FirstOrDefault(x => x.Ten == ten);

            //Lương
            if (!double.TryParse(luong, out double luongNV) || luongNV <= 0)
            {
                errorLuong.SetError(txtLuong, "Hãy điền giá trị là tiền");
                isValid = false;
            }
            else if (luongNV < 0)
            {
                errorLuong.SetError(txtLuong, "Giá tiền không nhỏ hơn 0");
                isValid = false;
            }
            
            else
            {
                errorLuong.Clear();
            }

            //Tên
            if (string.IsNullOrEmpty(ten))
            {
                errorTen.SetError(txtTen, "Tên nhân viên không để trống");
                isValid = false;
            }
            else if (ten.Length > 50)
            {
                errorTen.SetError(txtTen, "Tên món ăn vượt quá độ dài 50 kí tự");
                isValid = false;
            }
           
            else if (checkNV!= null)
            {
                errorTen.SetError(txtTen, "Tên nhân viên không được trùng ");
                isValid = false;
            }
            else
            {
                errorTen.Clear();
            }

            //Ngày Sinh
            if(DateTime.Parse(ngaysinh).Year > 2005)
            {
                errorNgaySinh.SetError(txtNgaySinh, " Năm sinh phải nhỏ hơn hoặc bằng 2005 ");
                isValid = false;
            }
                
            else
            {
                errorNgaySinh.Clear();
            }

            //SDT
            if (SDT.Length > 11)
            {
                errorSDT.SetError(txtSDT, "Chiều dài SDT không vượt quá 11");
                isValid = false;
            }
            else
            {
                errorSDT.Clear();
            }

            //Hình ảnh
            if (pictureBox1.Image == null)
            {
                errorHinhAnh.SetError(pictureBox1, "Hãy chọn một hình ảnh cho nhân viên ");
                isValid = false;
            }
            else
            {
                errorHinhAnh.Clear();
            }

            //Email
            if (Email.Length > 30)
            {
                errorEmail.SetError(txtEmail, "Chiều dài Email không vượt quá 30 kí tự");
                isValid = false;
            }
            else
            {
                errorEmail.Clear();
            }

            return isValid;
        }


        private void Employ_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            // tải bảng nhân viên
            LoadTable();

        }
        private void ClearInputBoxs()
        {
            txtTen.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtNgaySinh.Text = string.Empty;
            txtLuong.Text = string.Empty;
            pictureBox1.Image = null;
            _imageDataStart = null;
            _imageDataEnd = null;
            txtEmail.Text = string.Empty;
            txtTen.Focus();
            dataGridView1.ClearSelection();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GiaMonAnTextboxs_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThemBtn_Click(object sender, EventArgs e)
        {
            ClearInputBoxs();
        }

        private async void LuuBtn_Click(object sender, EventArgs e)
        {
            // kiem tra connection internet
            if (!Internet.IsInternetAvailable())
            {
                MessageBox.Show("Bạn chưa kết nối với internet, hãy kết nối với internet trước khi thực thi các tác vụ");
            }

            string ten = txtTen.Text.Trim();
            string SDT = txtSDT.Text.Trim();
            string Email = txtEmail.Text.Trim();           
            string Luong = txtLuong.Text.Trim();
            string NgaySinh = txtNgaySinh.Text.Trim();
            // validate
            bool isValid = Validate(ten, Luong,NgaySinh, SDT, Email);
            if (!isValid) return;

            NhanVien nhanVien = new NhanVien()
            {
                Ten = ten,
                SDT = SDT,
                Email = Email,
                Luong = decimal.Parse(Luong),
                NgaySinh = DateTime.Parse(NgaySinh)
            };

            // Them/Sua
            if (dataGridView1.SelectedRows.Count != 0)
            {
                // Loading dialog
                if (_imageDataStart != _imageDataEnd)
                {
                    _urlImage = await CloudinaryService.uploadImage(_picturePath);
                    new LoadingForm(1).ShowDialog();
                }
                nhanVien.HinhAnh = _urlImage;
                // Mapper from monAn to monAnDto
                NhanVienDTO nhanvienDTO = _mapper.Map<NhanVienDTO>(nhanVien);
                update(nhanVien,nhanvienDTO);
            }
            else
            {
                nhanVien.HinhAnh = await CloudinaryService.uploadImage(_picturePath);
                new LoadingForm(1).ShowDialog();
                if (_logic.Insert(nhanVien))
                {
                    LoadTable();
                }
            }
        }
        private void update(NhanVien nhanVien, NhanVienDTO nhanVienDTO)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int id = (int)(dataGridView1.Rows[index].Cells[0].Value);
            nhanVien.Id = id;
            nhanVienDTO.Id = id;

            if (_logic.Update(nhanVien))
            {
                MessageBox.Show("Sửa thành công");
                _table.RemoveAt(index);
                _table.Insert(0, nhanVienDTO);
                dataGridView1.Rows[index].Selected = true;
            }
        }

        private void XoaBtn_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0)
            {

                errorXoa.SetError(XoaBtn, "Hãy chọn dòng để xóa");

            }
            else if (MessageBox.Show("Xóa nhân viên ?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                NhanVienDTO nhanVienDTO = selectedRows[0].DataBoundItem as NhanVienDTO;
                NhanVien nhanVien = _mapper.Map<NhanVien>(nhanVienDTO);
                nhanVien.IsDelete = true;

                if (_logic.Update(nhanVien))
                {
                    _table.RemoveAt(selectedRows[0].Index);
                }
                ClearInputBoxs();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCyan;
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _rowHoverIndex = e.RowIndex;

                dataGridView1.Rows[_rowHoverIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridView1.Rows[_rowHoverIndex].DefaultCellStyle.BackColor = Color.White;
                _rowHoverIndex = -1;
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Internet.IsInternetAvailable() == false)
            {
                MessageBox.Show("Bạn chưa kết nối với internet");
                return;
            }
            // kiểm tra hàng được chọn là rỗng
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0)
            {
                return;
            }

            // lấy ra trực tiếp đối tượng hàng từ DataGridView, không cần gọi thuộc tính cell[0], cell[1], cell[2],... để lấy giá trị từng ô;
            NhanVienDTO nhanvienDTO = selectedRows[0].DataBoundItem as NhanVienDTO;
            errorXoa.Clear();

            txtTen.Text = nhanvienDTO.Ten;
            txtSDT.Text = nhanvienDTO.SDT;
            txtNgaySinh.Text = nhanvienDTO.NgaySinh.ToString();
            txtLuong .Text = (string)nhanvienDTO.Luong;
            txtEmail .Text = nhanvienDTO.Email;
            

            if (string.IsNullOrEmpty(nhanvienDTO.HinhAnh))
            {
                nhanvienDTO.HinhAnh = "https://res.cloudinary.com/dift2vpcj/image/upload/v1704122978/download_n07iy6.jpg";
            }
            byte[] dataImage = Internet.LoadImageFromUrl(nhanvienDTO.HinhAnh);
            using (MemoryStream ms = new MemoryStream(dataImage))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
            _imageDataStart = dataImage;
            _imageDataEnd = dataImage;
            _urlImage = nhanvienDTO.HinhAnh;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var filenames = data as string[];
                if (filenames.Length > 0)
                {
                    _picturePath = filenames[0];
                    pictureBox1.Image = Image.FromFile(filenames[0]);
                    _imageDataEnd = ImageToByteArray(pictureBox1.Image);
                }
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Save the image to the MemoryStream in a specific format (e.g., PNG)
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                // Return the byte array
                return memoryStream.ToArray();
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void ExcelBtn_Click(object sender, EventArgs e)
        {
            _logic.ExportToExcel(_table);
            MessageBox.Show("In thành công !");
        }

        private void radioSortTenMonAn_CheckedChanged(object sender, EventArgs e)
        {
            _table = new SortableBindingList<NhanVienDTO>(_table.OrderBy(monAn => monAn.Ten).ToList());
            dataGridView1.DataSource = _table;
        }

        private void radioSortLoaiMonAn_CheckedChanged(object sender, EventArgs e)
        {
            _table = new SortableBindingList<NhanVienDTO>(_table.OrderBy(monAn => monAn.Luong).ToList());
            dataGridView1.DataSource = _table;
        }

        private void searchKeytextBox_TextChanged(object sender, EventArgs e)
        {

           
            _table = new SortableBindingList<NhanVienDTO>(_logic.TimKiem(searchKeytextBox.Text.Trim()));
            dataGridView1.DataSource = _table;
        }
    }
    }

