using Bar_Management.BusinessLogic;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Linq;
using System.Windows.Forms;
using Bar_Management.Models;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;
using System.Drawing;
using Bar_Management.DTO;

namespace Bar_Management.TableForm
{
    public partial class NhaCungCap : Form
    {
        private SortableBindingList<Models.NhaCungCap> _table;
        private readonly NhaCungCapLogic _logic;
        public NhaCungCap()
        {
            InitializeComponent();
            _logic = new NhaCungCapLogic();
            LoadTable();
        }

        private void LoadTable() {
            _table = new SortableBindingList<Models.NhaCungCap>(_logic.GetAll().ToList());
            dataGridView1.DataSource = _table;
            dataGridView1.Columns["IsDelete"].Visible = false;
        }
        private void label1_Click(object sender, EventArgs e) {

        }

        private void NhaCungCap_Load(object sender, EventArgs e) {
            
        }

        private void ThemBtn_Click(object sender, EventArgs e) {
            string ten = txtTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sdt = txtSdt.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (!IsValidate(ten, diaChi, email, sdt)) {
                return;
            }

            Models.NhaCungCap nhaCungCap = new Models.NhaCungCap();
            nhaCungCap.Ten = ten;
            nhaCungCap.DiaChi = diaChi;
            nhaCungCap.Email = email;
            nhaCungCap.Sdt = sdt;

            if (_logic.Insert(nhaCungCap)) {
                MessageBox.Show("Thêm thành công");
                LoadTable();
            }
        }

        private void clearbtn_Click(object sender, EventArgs e) {
            txtTen.Text = string.Empty;
            txtSdt.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
        }

        private bool IsValidate(string ten, string diaChi, string email, string sdt, int IdUpdated=-1) {
            bool validate = true;
            email = email.ToLower();

            if (string.IsNullOrEmpty(ten)) {
                errTen.SetError(txtTen,"Tên không dể trống");
                validate = false;
            }else if (ten.Length > 50) {
                errTen.SetError(txtTen, "Tên không vượt quá chiều dài 50 kí tự");
                validate = false;
            } else {
                errTen.Clear();
            }

            if (string.IsNullOrEmpty(diaChi)) {
                errDiaChi.SetError(txtDiaChi, "Địa chỉ không để trống");
                validate = false;
            } else if (diaChi.Length > 100) {
                errTen.SetError(txtDiaChi, "Địa chỉ không vượt quá chiều dài 100 kí tự");
                validate = false;
            } else {
                 errDiaChi.Clear();
            }

            if (string.IsNullOrEmpty(sdt)) {
                errSdt.SetError(txtSdt, "Số điện thoại không để chống");
                validate = false;
            } else if (sdt.Length > 11) {
                errSdt.SetError(txtSdt, "Số điện thoại có chiều dài là 10-11 chữ số");
                validate = false;
            } else if (sdt.Any(c => !char.IsNumber(c))) {
                errSdt.SetError(txtSdt, "Số điện thoại chỉ bao gồm các chữ sô từ 1-9");
                validate = false;
            } else if (_logic.GetAll().Any(ncc => ncc.Id != IdUpdated && ncc.Sdt == sdt)) {
                errSdt.SetError(txtSdt, "Số điện thoại đã tồn tại");
                validate = false;
            } else {
                errSdt.Clear();
            }

            if (string.IsNullOrEmpty(email)) {

                errEmail.SetError(txtEmail, "email không để chống");
                validate = false;
            }else if (!Regex.Match(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$").Success) {

                errEmail.SetError(txtEmail, "email không đúng định dạng");
                validate = false;
            } else if (_logic.GetAll().Any(ncc => ncc.Id != IdUpdated && ncc.Email.ToLower() == email)) {

                errSdt.SetError(txtEmail, "Địa chỉ email này đã tồn tại");
                validate = false;
            } else {
                errEmail.Clear();
            }

            return validate;
        }

        private void capNhatBtn_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count==0) {
                return;
            }

            string ten = txtTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sdt = txtSdt.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            int id = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);

            if (!IsValidate(ten, diaChi, email, sdt, id)) {
                return;
            }

            Models.NhaCungCap nhaCungCap = new Models.NhaCungCap();
            nhaCungCap.Id = id;
            nhaCungCap.Ten = ten;
            nhaCungCap.DiaChi = diaChi;
            nhaCungCap.Email = email;
            nhaCungCap.Sdt = sdt;

            if (_logic.Update(nhaCungCap)) {
                MessageBox.Show("Cập nhật thông tin thành công");
                _table.Remove(dataGridView1.SelectedRows[0].DataBoundItem as Models.NhaCungCap);
                _table.Insert(0, nhaCungCap);
            }
        }

        private void XoaBtn_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count == 0) {
                return;
            }

            Models.NhaCungCap nhaCungCap = dataGridView1.SelectedRows[0].DataBoundItem as Models.NhaCungCap;
            if(_logic.Delete(nhaCungCap)) {
                MessageBox.Show("Xóa thành công");
                _table.Remove(nhaCungCap);
            }
        }

        private void dataGridView1_Enter(object sender, EventArgs e) {
            
        }

        private void dataGridView1_MouseHover(object sender, EventArgs e) {
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex > -1) {

                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex > -1) {

                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            _table = new SortableBindingList<Models.NhaCungCap>(_logic.TimKiem(searchkey.Text.Trim().ToLower()));
            dataGridView1.DataSource = _table;
        }
    }
}
