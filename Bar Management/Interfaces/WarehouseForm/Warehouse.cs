using AutoMapper;
using Bar_Management.BusinessLogic;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Models;
using Bar_Management.Tool;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bar_Management.Interfaces.WarehouseForm {
    public partial class Warehouse: Form {
        private readonly NguyenLieuLogic _nguyenLieuLogic;
        private readonly NhaCungCapLogic _nhaCungCapLogic;
        private readonly TrangThaiTonKhoLogic _trangThaiTonKhoLogic;
        private readonly TonKhoLogic _tonKhoLogic;

        private SortableBindingList<TonKhoDto> _table;
        private SortableBindingList<NguyenLieu> _tableNguyenLieu;
        private SortableBindingList<Models.NhaCungCap> _tableNhaCc;
        private SortableBindingList<TrangThaiTonKho> _tableTrangThai;

        private SortableBindingList<NguyenLieu> _loctableNguyenLieu;
        private SortableBindingList<Models.NhaCungCap> _loctableNhaCc;
        private SortableBindingList<TrangThaiTonKho> _loctableTrangThai;

        private SortableBindingList<ExportInfor> _tableExportInfor;
        private int _rowSelectedIndex =-1;

        private readonly IMapper _mapper;

        public Warehouse() {
            InitializeComponent();
            _tonKhoLogic = new TonKhoLogic();
            _nguyenLieuLogic = new NguyenLieuLogic();
            _nhaCungCapLogic = new NhaCungCapLogic();
            _trangThaiTonKhoLogic = new TrangThaiTonKhoLogic();

            _table = new SortableBindingList<TonKhoDto>(_tonKhoLogic.GetAll().ToList());
            _tableExportInfor = new SortableBindingList<ExportInfor>(new List<ExportInfor>() { });
            _tableTrangThai = new SortableBindingList<TrangThaiTonKho>(_trangThaiTonKhoLogic.GetAll().ToList());
            _tableNhaCc = new SortableBindingList<Models.NhaCungCap>(_nhaCungCapLogic.GetAll().ToList());

            _loctableTrangThai = new SortableBindingList<TrangThaiTonKho>(_trangThaiTonKhoLogic.GetAll().ToList());
            _loctableNhaCc = new SortableBindingList<Models.NhaCungCap>(_nhaCungCapLogic.GetAll().ToList());

            _mapper = AutoMapperProfile.InitializeAutoMapper();
        }

        private void Warehouse_Load(object sender, EventArgs e) {
            LoadNguyenLieu();
            _tableTrangThai.Insert(0, new TrangThaiTonKho() { Id = -1, Ten = "--Trạng thái--" });
            _tableNhaCc.Insert(0, new Models.NhaCungCap() { Id = -1, Ten = "--Nhà cung cấp--" });

            _loctableTrangThai.Insert(0, new TrangThaiTonKho() { Id = -1, Ten = "--Trạng thái--" });
            _loctableNhaCc.Insert(0, new Models.NhaCungCap() { Id = -1, Ten = "--Nhà cung cấp--" });

            cboxNhaCC.DataSource = _tableNhaCc;
            cboxTrangthai.DataSource = _tableTrangThai;

            locNhaCc.DataSource = _loctableNhaCc;
            locTranThai.DataSource = _loctableTrangThai;

            dataGridView1.DataSource = _table;
            dataGridView2.DataSource = _tableExportInfor;

            cboxNhaCC.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxTrangthai.DropDownStyle = ComboBoxStyle.DropDownList;

            locNhaCc.DropDownStyle = ComboBoxStyle.DropDownList;
            locTranThai.DropDownStyle = ComboBoxStyle.DropDownList;

            SetVietnameseLanguage();
        }

        private void LoadNguyenLieu() {
            _tableNguyenLieu = new SortableBindingList<NguyenLieu>(_nguyenLieuLogic.GetAll().ToList());
            _tableNguyenLieu.Insert(0, new NguyenLieu() { Id = -1, Ten = "--Nguyên liệu--" });
            cboxNguyenLieu.DataSource = _tableNguyenLieu;
            cboxNguyenLieu.DropDownStyle = ComboBoxStyle.DropDownList;

            _loctableNguyenLieu = new SortableBindingList<NguyenLieu>(_nguyenLieuLogic.GetAll().ToList());
            _loctableNguyenLieu.Insert(0, new NguyenLieu() { Id = -1, Ten = "--Nguyên liệu--" });
            locNguyenLieu.DataSource = _loctableNguyenLieu;
            locNguyenLieu.DropDownStyle = ComboBoxStyle.DropDownList;

            dataGridView2.Columns[0].Visible = false;
        }

        private void btnThemNL_Click(object sender, EventArgs e) {
            var themNguyenLieuForm = new NguyenLieuF();
            themNguyenLieuForm.ShowDialog();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (new NguyenLieuF().ShowDialog() == DialogResult.OK) {
                LoadNguyenLieu();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex > -1) {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex > -1) {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                _rowSelectedIndex = -1;
            }
        }
        private void SetVietnameseLanguage() {
            dtNgayHetHan.Format = DateTimePickerFormat.Custom;
            dtNgayHetHan.CustomFormat = "dd/MM/yyyy";
        }

        private void ExcelBtn_Click(object sender, EventArgs e) {
            if (dataGridView1.Rows.Count == 0) {
                errExcel.SetError(dataGridView1, "Không thể tải xuống excel vì bảng danh sách chống");
                return;
            }
            errExcel.Clear();
            _tonKhoLogic.ExportToExcel(_table);
        }

        private void sortSoLuong_CheckedChanged(object sender, EventArgs e) {
            _table = new SortableBindingList<TonKhoDto>(_table.OrderBy(tk => tk.SoLuong).ToList());
            dataGridView1.DataSource = _table;
        }

        private void sortDonVi_CheckedChanged(object sender, EventArgs e) {
            _table = new SortableBindingList<TonKhoDto>(_table.OrderBy(tk => tk.DonVi).ToList());
            dataGridView1.DataSource = _table;
        }

        private void radioSortGia_CheckedChanged(object sender, EventArgs e) {
            _table = new SortableBindingList<TonKhoDto>(_table.OrderBy(tk => decimal.Parse(tk.GiaNhap.ToString().Replace(",", ""))).ToList());
            dataGridView1.DataSource = _table;
        }

        private void radioSortTrangthai_CheckedChanged(object sender, EventArgs e) {
            _table = new SortableBindingList<TonKhoDto>(_table.OrderBy(tk => tk.TrangThai.Id).ToList());
            dataGridView1.DataSource = _table;
        }

        private void sortNgayNhap_CheckedChanged(object sender, EventArgs e) {
            _table = new SortableBindingList<TonKhoDto>(_table.OrderBy(tk => DateTime.ParseExact(tk.NgayNhap.ToString(), "dd-MM-yyyy", null)).ToList());
            dataGridView1.DataSource = _table;
        }

        private void sortNgayHetHan_CheckedChanged(object sender, EventArgs e) {
            try {
                _table = new SortableBindingList<TonKhoDto>(_table.OrderBy(tk => DateTime.ParseExact(tk.NgayHetHan.ToString(), "dd-MM-yyyy", null)).ToList());
                dataGridView1.DataSource = _table;
            } catch (Exception ex) {

                throw;
            }
        }

        private void locNguyenLieu_SelectedIndexChanged(object sender, EventArgs e) {
            Loc();
        }

        private void locTranThai_SelectedIndexChanged(object sender, EventArgs e) {
            Loc();
        }

        private void locNhaCc_SelectedIndexChanged(object sender, EventArgs e) {
            Loc();
        }

        private void Loc() {
            int nguyenLieuid =locNguyenLieu.SelectedItem != null ? ((NguyenLieu)locNguyenLieu.SelectedItem).Id : -1;
            int nhaCcId =locNhaCc.SelectedItem != null ? ((Models.NhaCungCap)locNhaCc.SelectedItem).Id : -1;
            int trangThaiId = locTranThai.SelectedItem != null ? ((TrangThaiTonKho)locTranThai.SelectedItem).Id : -1;

            _table = new SortableBindingList<TonKhoDto>(_tonKhoLogic.Loc(nhaCcId, trangThaiId, nguyenLieuid));
            dataGridView1.DataSource = _table;

        }

        private void tbSoLuong_Click(object sender, EventArgs e) {
            if (tbSoLuong.Text == "Số lượng") {
                tbSoLuong.Text = string.Empty;
            }
        }

        private void tbDonVi_Click(object sender, EventArgs e) {
            if (tbDonVi.Text == "Đơn vị") {
                tbDonVi.Text = string.Empty;
            }
        }

        private void tbGiaNhap_Click(object sender, EventArgs e) {
            if (tbGiaNhap.Text == "Giá nhập") {
                tbGiaNhap.Text = string.Empty;
            }
        }

        private void tbSoLuong_Leave(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(tbSoLuong.Text)) {
                tbSoLuong.Text = "Số lượng";
            }
        }

        private void tbDonVi_Leave(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(tbDonVi.Text)) {
                tbDonVi.Text = "Đơn vị";
            }
        }

        private void tbGiaNhap_Leave(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(tbGiaNhap.Text)) {
                tbGiaNhap.Text = "Giá nhập";
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e) {
            cboxNguyenLieu.SelectedIndex = 0;
            cboxNhaCC.SelectedIndex = 0;
            cboxTrangthai.SelectedIndex = 0;
            tbGiaNhap.Text = "Giá nhập";
            tbSoLuong.Text = "Số lượng";
            tbDonVi.Text = "Đơn vị";
            dtNgayHetHan.Value = dtNgayHetHan.MinDate;
        }

        private void XoaBtn_Click(object sender, EventArgs e) {

            if (dataGridView1.SelectedRows.Count == 0) {
                return;
            } else if (MessageBox.Show("Xóa thông tin tồn kho?", "Xóa thông tin tồn kho", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK) {
                return;
            }

            TonKhoDto tonKhoDto = dataGridView1.SelectedRows[0].DataBoundItem as TonKhoDto;
            if (_tonKhoLogic.Delete(new TonKho() { Id = tonKhoDto.Id })) {
                MessageBox.Show("Xóa thành công");
                _table.Remove(tonKhoDto);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count != 0) {
                XoaBtn.Enabled = true;
                capNhatBtn.Enabled = true;
                btnChon.Enabled = true;
            } else {
                XoaBtn.Enabled = false;
                capNhatBtn.Enabled = false;
                btnChon.Enabled = false;
            }
        }

        private bool IsValidate(string soLuong, string donVi, string giaNhap, DateTime ngayHetHan, int nguyenLieuId, int nhaCungCapId, int trangThaiTonKhoId) {
            bool isValid= true;
            DateTime now = DateTime.Now;
            now = new DateTime(now.Year, now.Month, now.Day, 12, 0, 0);

            if (ngayHetHan < now) {
                errNgayHethan.SetError(dtNgayHetHan, "Ngày hết hạn không thể là ngày đã trôi qua");
                isValid = false;
            } else {
                errNgayHethan.Clear();
            }

            if (int.TryParse(soLuong, out int soLuongInt)) {
                if (soLuongInt < 1) {
                    errSoLuong.SetError(tbSoLuong, "Số lượng phải là một số lớn hơn hoặc bằng một");
                    isValid = false;
                } else {
                    errSoLuong.Clear();
                }
            } else {
                errSoLuong.SetError(tbSoLuong, "Số lượng phải là một số");
                isValid = false;
            }

            if (string.IsNullOrEmpty(donVi)) {
                errDonVi.SetError(tbDonVi, "Đơn vị không để chống");
            } else if (donVi == "Đơn vị") {
                errDonVi.SetError(tbDonVi, "Bạn chưa nhập đơn vị");
                isValid = false;
            } else {
                errDonVi.Clear();
            }

            if (string.IsNullOrEmpty(giaNhap)) {

                errGiaNhap.SetError(tbGiaNhap, "Giá nhập không để chống");
                isValid = false;
            } else if (decimal.TryParse(giaNhap, out decimal giaNhapDecimal)) {
                if (giaNhapDecimal == 0) {
                    errGiaNhap.SetError(tbGiaNhap, "Giá nhập phải lớn hơn 0");
                    isValid = false;
                } else {
                    errGiaNhap.Clear();
                }
            } else {
                errGiaNhap.SetError(tbGiaNhap, "Sai định giạng");
                isValid = false;
            }

            if (nguyenLieuId == -1) {
                errNguyenLieu.SetError(cboxNguyenLieu, "Bạn chưa chọn nguyên liệu");
                isValid = false;
            } else {
                errNguyenLieu.Clear();
            }

            if (nhaCungCapId == -1) {
                errNhaCc.SetError(cboxNhaCC, "Bạn chưa chọn nhà cung cấp");
                isValid = false;
            } else {
                errNhaCc.Clear();
            }

            if (trangThaiTonKhoId == -1) {
                errTranthai.SetError(cboxTrangthai, "Bạn chưa chọn trạng thái");
                isValid = false;
            } else {
                errTranthai.Clear();
            }

            return isValid;
        }

        private void ThemBtn_Click(object sender, EventArgs e) {

            NguyenLieu nguyenLieu = cboxNguyenLieu.SelectedItem as NguyenLieu;
            Models.NhaCungCap nhaCungCap = cboxNhaCC.SelectedItem as Models.NhaCungCap;
            TrangThaiTonKho trangThaiTonKho = cboxTrangthai.Items[1] as TrangThaiTonKho;
            string soLuong = tbSoLuong.Text;
            string donVi = tbDonVi.Text;
            string giaNhap = tbGiaNhap.Text;
            DateTime ngayHetHan = dtNgayHetHan.Value;

            if (!IsValidate(soLuong, donVi, giaNhap, ngayHetHan, nguyenLieu.Id, nhaCungCap.Id, trangThaiTonKho.Id))
                return;



            if (MessageBox.Show("Lưu thông tin tồn kho?", "Thông tin tồn kho", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK) {
                return;
            }

            TonKho tonKhoMoi = new TonKho(){
                NguyenLieuId = nhaCungCap.Id,
                NhaCungCapId = nhaCungCap.Id,
                TrangThaiId = trangThaiTonKho.Id,
                SoLuong = int.Parse(soLuong),
                DonVi = donVi,
                GiaNhap = decimal.Parse(giaNhap),
                NgayHetHan = ngayHetHan,
                NgayNhap = DateTime.Now
            };

            TonKhoDto tonKhoDto = new TonKhoDto(){
                NguyenLieu = nguyenLieu,
                NhaCungCap = nhaCungCap,
                TrangThai = trangThaiTonKho,
                SoLuong = int.Parse(soLuong),
                DonVi = donVi,
                GiaNhap = decimal.Parse(giaNhap),
                NgayHetHan = ngayHetHan,
                NgayNhap = DateTime.Now
            };
            // lấy id của dòng chùng thông tin nhà cung cấp nguyên liệu ngày nhập
            int id = KiemTraThongTinDaTonTai(tonKhoDto);
            if (id == -1) {
                // nếu không chùng thì thêm mới
                if (_tonKhoLogic.Insert(tonKhoMoi)) {
                    MessageBox.Show("Lưu thành công");
                    Loc();
                }

            } else {
                MessageBox.Show("Thêm không thành công do đang có một dòng thông tin cùng nhà cung cấp, nguyên liệu, đơn vị, ngày nhập",
                    "Cảnh báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private int KiemTraThongTinDaTonTai(TonKhoDto tonKhoDto) {
            foreach (var item in _table) {
                if (item.NhaCungCap.Id == tonKhoDto.NhaCungCap.Id
                    && item.NguyenLieu.Id == tonKhoDto.NguyenLieu.Id
                    && item.NgayNhap.ToString() == tonKhoDto.NgayNhap.ToString()) {
                    return item.Id;
                }
            }
            return -1;
        }

        private void capNhatBtn_Click(object sender, EventArgs e) {
            NguyenLieu nguyenLieu = cboxNguyenLieu.SelectedItem as NguyenLieu;
            Models.NhaCungCap nhaCungCap = cboxNhaCC.SelectedItem as Models.NhaCungCap;
            TrangThaiTonKho trangThaiTonKho = cboxTrangthai.SelectedItem as TrangThaiTonKho;
            string soLuong = tbSoLuong.Text;
            string donVi = tbDonVi.Text;
            string giaNhap = tbGiaNhap.Text;
            DateTime ngayHetHan = dtNgayHetHan.Value;

            if (!IsValidate(soLuong, donVi, giaNhap, ngayHetHan, nguyenLieu.Id, nhaCungCap.Id, trangThaiTonKho.Id))
                return;

            if (MessageBox.Show("Lưu thông tin tồn kho?", "Thông tin tồn kho", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK) {
                return;
            }

            TonKho tonKhoMoi = new TonKho(){
                NguyenLieu = nguyenLieu,
                NhaCungCap = nhaCungCap,
                TrangThai = trangThaiTonKho,
                SoLuong = int.Parse(soLuong),
                DonVi = donVi,
                GiaNhap = decimal.Parse(giaNhap),
                NgayHetHan = ngayHetHan,
                NgayNhap = DateTime.Now,
                Id = (int)(dataGridView1.SelectedRows[0].Cells[0].Value)
            };

            TonKhoDto tonKhoDto = _mapper.Map<TonKhoDto>(tonKhoMoi);
            // nếu không chùng thì thêm mới
            if (_tonKhoLogic.Update(tonKhoMoi)) {
                MessageBox.Show("Sửa thành công");
                _table.RemoveAt(dataGridView1.SelectedRows[0].Index);
                _table.Insert(0, tonKhoDto);
                dataGridView1.Rows[0].Selected = true;
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e) {
            if (dataGridView1.SelectedRows.Count == 0) {
                return;
            }

            TonKhoDto tonKhoDto = dataGridView1.SelectedRows[0].DataBoundItem as TonKhoDto;
            tbSoLuong.Text = tonKhoDto.SoLuong.ToString();
            tbGiaNhap.Text = tonKhoDto.GiaNhap.ToString();
            tbDonVi.Text = tonKhoDto.DonVi;
            dtNgayHetHan.Value = DateTime.ParseExact(tonKhoDto.NgayHetHan.ToString(), "dd-MM-yyyy", null);
            cboxNguyenLieu.SelectedItem = _tableNguyenLieu.First(nl => nl.Id == tonKhoDto.NguyenLieu.Id);
            cboxNhaCC.SelectedItem = _tableNhaCc.First(nl => nl.Id == tonKhoDto.NhaCungCap.Id);
            cboxTrangthai.SelectedItem = _tableTrangThai.First(nl => nl.Id == tonKhoDto.TrangThai.Id);
        }

        private void btnChon_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count == 0) {
                return;
            }

            TonKhoDto tonKhoDto = dataGridView1.SelectedRows[0].DataBoundItem as TonKhoDto;

            for (int index = 0; index < _tableExportInfor.Count; index++) {
                ExportInfor infor = _tableExportInfor.ToList()[index];
                if (infor.Id == tonKhoDto.Id.ToString()) {
                    return;
                }
            }

            ExportInfor exportInfor = new ExportInfor(){
                Id = tonKhoDto.Id.ToString(),
                SoLuong = 1,
                TenNguyenLieu = tonKhoDto.NguyenLieu.Ten,
                DonGia = tonKhoDto.GiaNhap.ToString(),
                DonVi = tonKhoDto.DonVi
            };

            _tableExportInfor.Insert(0, exportInfor);
            numSoLuongXuat.Focus();
        }

        private void numSoLuongXuat_ValueChanged(object sender, EventArgs e) {
            if (dataGridView2.SelectedRows.Count == 0) {
                return;
            }

            dataGridView2.SelectedRows[0].Cells[3].Value = numSoLuongXuat.Value;
        }

        private void boChonBtn_Click(object sender, EventArgs e) {
            if (dataGridView2.SelectedRows.Count == 0) {
                return;
            }

            _tableExportInfor.RemoveAt(dataGridView2.SelectedRows[0].Index);
        }

        private void numSoLuongXuat_Leave(object sender, EventArgs e) {
            if (dataGridView2.SelectedRows.Count == 0) {
                return;
            }

            ExportInfor exportInfor = dataGridView2.SelectedRows[0].DataBoundItem as ExportInfor;
            if (_table.Any(tk => tk.Id.ToString() == exportInfor.Id && tk.SoLuong < exportInfor.SoLuong)) {
                MessageBox.Show("Số lượng nguyên liệu muốn xuất vượt quá số lượng hiện tại đang có");
                numSoLuongXuat.Value = 1;
            }
        }

        private void xuatBtn_Click(object sender, EventArgs e) {

            if (dataGridView2.Rows.Count == 0) {
                MessageBox.Show("Hãy chọn nguyên liệu");
                return;
            }

            using (var transaction = new AppDbContext().Database.BeginTransaction()) {
                try {
                    for (int index = 0; index < dataGridView2.Rows.Count; index++) {
                        ExportInfor exportInfor = dataGridView2.Rows[index].DataBoundItem as ExportInfor;
                        TonKhoDto tonKhoDto = _table.First(c => c.Id.ToString() == exportInfor.Id);

                        tonKhoDto.SoLuong -= exportInfor.SoLuong;
                        if (tonKhoDto.SoLuong == 0) {
                            tonKhoDto.TrangThai = _tableTrangThai.First(c => c.Ten == "Hết");
                        }

                        TonKho tonKho = new TonKho(){
                            Id = tonKhoDto.Id,
                            SoLuong = tonKhoDto.SoLuong,
                            DonVi = tonKhoDto.DonVi,
                            NguyenLieuId = tonKhoDto.NguyenLieu.Id,
                            NhaCungCapId = tonKhoDto.NhaCungCap.Id,
                            TrangThaiId = tonKhoDto.TrangThai.Id,
                            GiaNhap = decimal.Parse(((string)tonKhoDto.GiaNhap).Replace(",","")),
                            NgayNhap = DateTime.ParseExact(tonKhoDto.NgayNhap.ToString(), "dd-MM-yyyy",null),
                            NgayHetHan = DateTime.ParseExact(tonKhoDto.NgayHetHan.ToString(), "dd-MM-yyyy", null)
                        };
                        _tonKhoLogic.Update(tonKho);


                    }
                    transaction.Commit();
                    Loc();
                    if (MessageBox.Show("Cập nhật thông tin xuất kho thành công, bạn có muốn in phiếu xuất kho?", "Thông báo", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK) {

                        _tonKhoLogic.PhieuXuatKho(_tableExportInfor);
                    }
                } catch (Exception ex) {
                    transaction.Rollback();
                    MessageBox.Show("Xuất không thành công do: " + ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e) {

        }
    }
}
