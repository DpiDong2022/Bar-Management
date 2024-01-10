using AutoMapper;
using Bar_Management.BusinessLogic;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Models;
using Bar_Management.Tool;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bar_Management.Interfaces.AccountForm
{
    public partial class Account : Form
    {
        private readonly TaiKhoanLogic _logic;
        private readonly NhanVienLogic _nhanVienLogic;
        private readonly RoleLogic _roleLogic;
        private SortableBindingList<TaiKhoanDTO> _table;

        private SortableBindingList<Role> _tableRole1;
        private SortableBindingList<Role> _tableRole2;

        private SortableBindingList<NhanVienDTO> _tableNhanvien;
        private readonly IMapper _mapper;
        int _rowHoverIndex;
        public Account()
        {
            InitializeComponent();
            _logic = new TaiKhoanLogic();
            _mapper = AutoMapperProfile.InitializeAutoMapper();
            _nhanVienLogic = new NhanVienLogic();
            _roleLogic = new RoleLogic();
        }

        private void LoadTable()
        {
            if (_table != null)
            {
                _table = null;
            }
            _table = new SortableBindingList<TaiKhoanDTO>(_logic.GetAll().ToList());
            dataGridView1.DataSource = _table;
            dataGridView1.Columns["Setting"].Visible = false;
        }
        private bool Validate(string tenTK, int roleID, string matKhau, int nhanvienID)
        {
            bool isValid = true;
            // Tên tài khoản
            if (string.IsNullOrEmpty(tenTK))
            {
                errorTen.SetError(txtTen, "Tên tài khoản không được để trống");
                isValid = false;
            }
            else if (tenTK.Length > 50)
            {
                errorTen.SetError(txtTen, "Tên món ăn vượt quá độ dài 50 kí tự");
                isValid = false;
            }
            else
            {
                errorTen.Clear();
            }


            // Role
            if (roleID == -1)
            {
                errorRole.SetError(cbRole, "Bạn chưa chọn loại món ăn hoặc chưa có loại món ăn");
                isValid = false;
            }
            else if (new GenericRepository<Role>().GetAll().First(c => c.Id == roleID) == null)
            {
                errorRole.SetError(cbRole, "Loại món ăn không còn tồn tại");
                isValid = false;
            }
            else
            {
                errorRole.Clear();
            }

            //Nhân viên
            // Role
            if (nhanvienID == -1)
            {
                errorNhanvien.SetError(cbTennhanvien, "Bạn chưa chọn nhân viên");
                isValid = false;
            }
            else if (new GenericRepository<NhanVien>().GetAll().First(c => c.Id == nhanvienID) == null)
            {
                errorNhanvien.SetError(cbTennhanvien, "Nhân viên không còn tồn tại");
                isValid = false;
            }
            else
            {
                errorNhanvien.Clear();
            }


            //Mật khẩu
            if (string.IsNullOrEmpty(matKhau))
            {
                errorMatkhau.SetError(txtMatkhau, "Mật khẩu không được để trống");
                isValid = false;
            }
            else if (matKhau.Length > 30)
            {
                errorMatkhau.SetError(txtMatkhau, "Mật khẩu vượt quá độ dài 50 kí tự");
                isValid = false;
            }
            else
            {
                errorMatkhau.Clear();
            }

            //Tên người dùng
            //if (string.IsNullOrEmpty(tennguoidung))
            //{
            //    errorTennguoidung.SetError(txtTennguoidung, "Tên người dùng không được để trống");
            //    isValid = false;
            //}
            //else if (matKhau.Length > 30)
            //{
            //    errorTennguoidung.SetError(txtTennguoidung, "Tên người dùng vượt quá độ dài 30 kí tự");
            //    isValid = false;
            //}
            //else
            //{
            //    errorTennguoidung.Clear();
            //}

            return isValid;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {

            // tải bảng tài khoản
            LoadTable();

            // tải danh sach combobox
            cbRole.ValueMember = "Id";
            cbRole.DisplayMember = "Ten";
            _tableRole1 = new SortableBindingList<Role>(_roleLogic.GetAll().ToList());
            _tableRole1.Insert(0, new Role() { Id = -1, Ten = "--Role--" });

            _tableRole2 = new SortableBindingList<Role>(_roleLogic.GetAll().ToList());
            _tableRole2.Insert(0, new Role() { Id = -1, Ten = "--Role--" });
            //cbRole.DataSource = _tableRole2;
            cbRole.DataSource = _tableRole1;
            //combobox ten nhan vien
            cbTennhanvien.ValueMember = "Id";
            cbTennhanvien.DisplayMember = "Ten";

            _tableNhanvien = new SortableBindingList<NhanVienDTO>(_nhanVienLogic.GetAllDto().ToList());
            _tableNhanvien.Insert(0, new NhanVienDTO() { Id = -1, Ten = "--Nhân viên--" });
            cbTennhanvien.DataSource = _tableNhanvien;
            // ép chỉ đọc các dropdown
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTennhanvien.DropDownStyle = ComboBoxStyle.DropDownList;
            

            // set default index for comboboxs
            cbRole.SelectedIndex = 0;
            cbTennhanvien.SelectedIndex = 0;
            


        }

        private void ThemBtn_Click(object sender, EventArgs e)
        {
            ClearInputBoxs();
        }
        private void ClearInputBoxs()
        {
            txtTen.Text = string.Empty;
            txtMatkhau.Text = string.Empty;
            cbTennhanvien.SelectedIndex = 0;
            cbRole.SelectedIndex = 0;

            txtTen.Focus();
            dataGridView1.ClearSelection();
        }

        private void LuuBtn_Click(object sender, EventArgs e)
        {
            // kiem tra connection internet
            if (!Internet.IsInternetAvailable())
            {
                MessageBox.Show("Bạn chưa kết nối với internet, hãy kết nối với internet trước khi thực thi các tác vụ");
            }

            string tenTk = txtTen.Text.Trim();
            string matKhau = txtMatkhau.Text.Trim();
            int tenNguoidung = (cbTennhanvien.SelectedItem as NhanVien).Id;
            int tenRole = (cbRole.SelectedItem as Role).Id;

            // validate
            bool isValid = Validate(tenTk, tenRole, matKhau, tenNguoidung);
            if (!isValid) return;

            TaiKhoan taiKhoan = new TaiKhoan()
            {
                Ten = tenTk,
                MatKhau = matKhau,
                RoleId = tenRole,
                NhanVienId = tenNguoidung

            };

            // Them/Sua
            if (dataGridView1.SelectedRows.Count != 0)
            {
                // Loading dialog

                //new LoadingForm(1).ShowDialog();


                // Mapper from monAn to monAnDto
                TaiKhoanDTO taiKhoanDTo = _mapper.Map<TaiKhoanDTO>(taiKhoan);
                update(taiKhoan, taiKhoanDTo);
            }

        }
        private void update(TaiKhoan taiKhoan, TaiKhoanDTO taiKhoanDTO)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int id = (int)(dataGridView1.Rows[index].Cells[0].Value);
            taiKhoan.Id = id;
            taiKhoanDTO.Id = id;

            if (_logic.Update(taiKhoan))
            {
                MessageBox.Show("Sửa thành công");
                _table.RemoveAt(index);
                _table.Insert(0, taiKhoanDTO);
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
            else if (MessageBox.Show("Xóa tài khoản?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                TaiKhoanDTO taiKhoanDTO = selectedRows[0].DataBoundItem as TaiKhoanDTO;
                TaiKhoan taiKhoan = _mapper.Map<TaiKhoan>(taiKhoanDTO);
                taiKhoan.IsDelete = true;

                if (_logic.Update(taiKhoan))
                {
                    _table.RemoveAt(selectedRows[0].Index);
                }
                ClearInputBoxs();
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
            TaiKhoanDTO taiKhoanDTO = selectedRows[0].DataBoundItem as TaiKhoanDTO;
            errorXoa.Clear();

            txtTen.Text = taiKhoanDTO.Ten;
            txtMatkhau.Text = taiKhoanDTO.MatKhau;

            int RoleID = taiKhoanDTO.Role.Id;
            foreach (var item in cbRole.Items)
            {
                if (((Role)item).Id == RoleID) 
                {
                    cbRole.SelectedIndex = cbRole.Items.IndexOf(item);
                    break;
                }
            }

            int NhanvienID = taiKhoanDTO.NhanVien.Id;
            foreach (var item in cbTennhanvien.Items)
            {
                if (((NhanVienDTO)item).Id == NhanvienID)
                {
                    cbTennhanvien.SelectedIndex = cbTennhanvien.Items.IndexOf(item);
                    break;
                }
            }

        }

        private void searchKeytextBox_TextChanged(object sender, EventArgs e)
        {
            //int RoleID = (LocloaiMAComboBox.SelectedItem as LoaiMonAn).Id;
            //int trangThaiId = LocTrangThaicomboBox.SelectedIndex;

            _table = new SortableBindingList<TaiKhoanDTO>(_logic.TimKiem(searchKeytextBox.Text.Trim()));
            dataGridView1.DataSource = _table;
        }

        private void ExcelBtn_Click(object sender, EventArgs e)
        {
            _logic.ExportToExcel(_table);
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCyan;
            }
        }

        private void radioSortRole_CheckedChanged(object sender, EventArgs e)
        {
            _table = new SortableBindingList<TaiKhoanDTO>(_table.OrderBy(taiKhoan => taiKhoan.Role.Ten).ToList());
            dataGridView1.DataSource = _table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

