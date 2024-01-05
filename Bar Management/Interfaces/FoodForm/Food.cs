using AutoMapper;
using Bar_Management.BusinessLogic;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Interfaces;
using Bar_Management.Models;
using Bar_Management.Tool;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Bar_Management.FoodForm {
    public partial class Food: Form {
        private readonly MonAnLogic _logic;
        private readonly LoaiMonAnLogic _loaiMonAnLogic;
        private SortableBindingList<MonAnDto> _table;

        private SortableBindingList<LoaiMonAn> _tableLoaimonAn;
        private SortableBindingList<LoaiMonAn> _tableLoaimonAn2;
        private readonly IMapper _mapper;
        private string _picturePath;
        byte[] _imageDataStart;
        byte[] _imageDataEnd;
        string _urlImage;
        int _rowHoverIndex;
        public Food() {
            InitializeComponent();
            _logic = new MonAnLogic();
            _mapper = AutoMapperProfile.InitializeAutoMapper();
            _loaiMonAnLogic = new LoaiMonAnLogic();
            
        }

        private void LoadTable() {
            if (_table != null) {
                _table = null;
            }
            _table = new SortableBindingList<MonAnDto>(_logic.GetAll().ToList());
            dataGridView1.DataSource = _table;
            dataGridView1.Columns["HinhAnh"].Visible = false;
        }

        private bool Validate(string tenMon, string gia, string moTa, int loaiMonId, string trangThai) {
            bool isValid = true;
            if (!double.TryParse(gia, out double giaMonAn) || giaMonAn <= 0) {
                errorGia.SetError(GiaMonAnTextboxs, "Hãy điền giá trị là tiền");
                isValid = false;
            } else if (giaMonAn < 0) {
                errorGia.SetError(GiaMonAnTextboxs, "Giá tiền không nhỏ hơn 0");
                isValid = false;
            } else {
                errorGia.Clear();
            }

            if (string.IsNullOrEmpty(tenMon)) {
                ErrorTenMonAn.SetError(TenMonAnbox, "Tên món ăn không để trống");
                isValid = false;
            } else if (tenMon.Length > 50) {
                ErrorTenMonAn.SetError(TenMonAnbox, "Tên món ăn vượt quá độ dài 50 kí tự");
                isValid = false;
            } else {
                ErrorTenMonAn.Clear();
            }

            if (loaiMonId == -1) {
                errorLoai.SetError(LoaiMonAnComboBox, "Bạn chưa chọn loại món ăn hoặc chưa có loại món ăn");
                isValid = false;
            } else if (new GenericRepository<LoaiMonAn>().GetAll().First(c => c.Id == loaiMonId) == null) {
                errorLoai.SetError(LoaiMonAnComboBox, "Loại món ăn không còn tồn tại");
                isValid = false;
            } else {
                errorLoai.Clear();
            }

            if (moTa.Length > 100) {
                errorMota.SetError(motaText, "Chiều dài mô tả không vượt quá 100");
                isValid = false;
            } else {
                errorMota.Clear();
            }

            if (pictureBox1.Image == null) {
                errorHinhAnh.SetError(pictureBox1, "Hãy chọn một hình ảnh cho món ăn");
                isValid = false;
            } else {
                errorHinhAnh.Clear();
            }

            if (trangThai == "--Trạng thái--") {
                errorTrangThai.SetError(comboBoxTranthai, "Hãy chọn trạng thái món ăn");
                isValid = false;
            } else {
                errorTrangThai.Clear();
            }
            return isValid;
        }

        private void Food_Load(object sender, EventArgs e) {
            pictureBox1.AllowDrop = true;
            // tải bảng nhân viên
            LoadTable();

            // tải danh sach combobox
            LoaiMonAnComboBox.ValueMember = "Id";
            LoaiMonAnComboBox.DisplayMember = "TenLoai";
            _tableLoaimonAn = new SortableBindingList<LoaiMonAn>(_loaiMonAnLogic.GetAll().ToList());
            _tableLoaimonAn.Insert(0, new LoaiMonAn() { Id = -1, TenLoai = "--Loại đồ ăn--" });

            _tableLoaimonAn2 = new SortableBindingList<LoaiMonAn>(_loaiMonAnLogic.GetAll().ToList());
            _tableLoaimonAn2.Insert(0, new LoaiMonAn() { Id = -1, TenLoai = "--Loại đồ ăn--" });
            LocloaiMAComboBox.DataSource = _tableLoaimonAn2;
            LoaiMonAnComboBox.DataSource = _tableLoaimonAn;

            // ép chỉ đọc các dropdown
            comboBoxTranthai.DropDownStyle = ComboBoxStyle.DropDownList;
            LoaiMonAnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LocloaiMAComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LocTrangThaicomboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // set default index for comboboxs
            comboBoxTranthai.SelectedIndex = 0;
            LoaiMonAnComboBox.SelectedIndex = 0;
            LocloaiMAComboBox.SelectedIndex = 0;
            LocTrangThaicomboBox.SelectedIndex = 0;
        }

        // clear các box đầu vào dữ liệu - Click Thêm
        private void button2_Click(object sender, EventArgs e) {
            ClearInputBoxs();
        }

        // click lưu
        private async void LuuBtn_Click(object sender, EventArgs e) {
            // kiem tra connection internet
            if (!Internet.IsInternetAvailable()) {
                MessageBox.Show("Bạn chưa kết nối với internet, hãy kết nối với internet trước khi thực thi các tác vụ");
            }

            string tenMonAn = TenMonAnbox.Text.Trim();
            string gia = GiaMonAnTextboxs.Text.Trim();
            string moTa = motaText.Text.Trim();
            int tenLoaiMonAnId = (LoaiMonAnComboBox.SelectedItem as LoaiMonAn).Id;
            string trangThai = comboBoxTranthai.SelectedItem.ToString();
            // validate
            bool isValid = Validate(tenMonAn, gia,moTa, tenLoaiMonAnId, trangThai);
            if (!isValid) return;

            MonAn monAn = new MonAn(){
                TenMon = tenMonAn,
                Gia = decimal.Parse(gia),
                MoTa = moTa,
                LoaiMonAnId = tenLoaiMonAnId,
                IsAvailable = trangThai == "Còn" ? 1:0
            };

            // Them/Sua
            if (dataGridView1.SelectedRows.Count != 0) {
                // Loading dialog
                if (_imageDataStart != _imageDataEnd) {
                    _urlImage = await CloudinaryService.uploadImage(_picturePath);
                    new LoadingForm(1).ShowDialog();
                }
                monAn.HinhAnh = _urlImage;
                // Mapper from monAn to monAnDto
                MonAnDto monAnDto = _mapper.Map<MonAnDto>(monAn);
                update(monAn, monAnDto);
            } else{
                monAn.HinhAnh = await CloudinaryService.uploadImage(_picturePath);
                new LoadingForm(1).ShowDialog();
                if (_logic.Insert(monAn)) {
                    LoadTable();
                }
            }
        }

        // update
        private void update(MonAn monAn, MonAnDto monAnDto) {
            int index = dataGridView1.SelectedRows[0].Index;
            int id = (int)(dataGridView1.Rows[index].Cells[0].Value);
            monAn.Id = id;
            monAnDto.Id = id;

            if (_logic.Update(monAn)) {
                MessageBox.Show("Sửa thành công");
                _table.RemoveAt(index);
                _table.Insert(0, monAnDto);
                dataGridView1.Rows[index].Selected = true;
            }
        }

        private void Food_MouseClick(object sender, MouseEventArgs e) {
        }

        // Xóa click
        private void XoaBtn_Click(object sender, EventArgs e) {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0) {

                errorXoa.SetError(XoaBtn, "Hãy chọn dòng để xóa");

            } else if (MessageBox.Show("Xóa món ăn?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK) {
                MonAnDto monAnDto = selectedRows[0].DataBoundItem as MonAnDto;
                MonAn monan = _mapper.Map<MonAn>(monAnDto);
                monan.IsDelete = true;

                if (_logic.Update(monan)) {
                    _table.RemoveAt(selectedRows[0].Index);
                }
                ClearInputBoxs();
            }
        }

        // hiển thị thông tin vào box khi click vào mỗi hàng thông tin món ăn
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e) {
            if (Internet.IsInternetAvailable() == false) {
                MessageBox.Show("Bạn chưa kết nối với internet");
                return;
            }
            // kiểm tra hàng được chọn là rỗng
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0) {
                return;
            }

            // lấy ra trực tiếp đối tượng hàng từ DataGridView, không cần gọi thuộc tính cell[0], cell[1], cell[2],... để lấy giá trị từng ô;
            MonAnDto monAnDto = selectedRows[0].DataBoundItem as MonAnDto;
            errorXoa.Clear();

            TenMonAnbox.Text = monAnDto.TenMon;
            motaText.Text = monAnDto.MoTa;
            GiaMonAnTextboxs.Text = (string)monAnDto.Gia;
            comboBoxTranthai.SelectedIndex = monAnDto.TrangThai == "Còn" ? 1 : 2;

            int loaiMonAnId = monAnDto.LoaiMonAn.Id;

            foreach (var item in LoaiMonAnComboBox.Items) {
                if (((LoaiMonAn)item).Id == loaiMonAnId) {
                    LoaiMonAnComboBox.SelectedIndex = LoaiMonAnComboBox.Items.IndexOf(item);
                    break;
                }
            }

            if (string.IsNullOrEmpty(monAnDto.HinhAnh)) {
                monAnDto.HinhAnh = "https://res.cloudinary.com/dift2vpcj/image/upload/v1704122978/download_n07iy6.jpg";
            }
            byte[] dataImage = Internet.LoadImageFromUrl(monAnDto.HinhAnh);
            using (MemoryStream ms = new MemoryStream(dataImage)) {
                pictureBox1.Image = Image.FromStream(ms);
            }
            _imageDataStart = dataImage;
            _imageDataEnd = dataImage;
            _urlImage = monAnDto.HinhAnh;
        }

        // search
        private void textBox4_TextChanged(object sender, EventArgs e) {

            int tenLoaiMonAnId = (LocloaiMAComboBox.SelectedItem as LoaiMonAn).Id;
            int trangThaiId = LocTrangThaicomboBox.SelectedIndex;

            if (trangThaiId == 0) {
                trangThaiId = -1;
            } else if (trangThaiId == 1) {
                trangThaiId = 1;
            } else {
                trangThaiId = 0;
            }


            _table = new SortableBindingList<MonAnDto>(_logic.TimKiem(searchKeytextBox.Text.Trim(), tenLoaiMonAnId, trangThaiId));
            dataGridView1.DataSource = _table;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e) {

            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null) {
                var filenames = data as string[];
                if (filenames.Length > 0) {
                    _picturePath = filenames[0];
                    pictureBox1.Image = Image.FromFile(filenames[0]);
                    _imageDataEnd = ImageToByteArray(pictureBox1.Image);
                }
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
        }

        private byte[] ImageToByteArray(Image image) {
            using (MemoryStream memoryStream = new MemoryStream()) {
                // Save the image to the MemoryStream in a specific format (e.g., PNG)
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                // Return the byte array
                return memoryStream.ToArray();
            }
        }

        // lọc 
        private void LocloaiMAComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            textBox4_TextChanged(sender, e);
        }

        // lọc
        private void LocTrangThaicomboBox_SelectedIndexChanged(object sender, EventArgs e) {
            textBox4_TextChanged(sender, e);
        }

        // refresh input boxs
        private void ClearInputBoxs() {
            TenMonAnbox.Text = string.Empty;
            GiaMonAnTextboxs.Text = string.Empty;
            motaText.Text = string.Empty;
            LoaiMonAnComboBox.SelectedIndex = 0;
            pictureBox1.Image = null;
            _imageDataStart = null;
            _imageDataEnd = null;
            comboBoxTranthai.SelectedIndex = 0;
            TenMonAnbox.Focus();
            dataGridView1.ClearSelection();
        }

        // Xuất excel
        private void ExcelBtn_Click(object sender, EventArgs e) {
            _logic.ExportToExcel(_table);
        }

        private void LoaiMonAnComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboBoxTranthai_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex > -1) {
                _rowHoverIndex = e.RowIndex;

                dataGridView1.Rows[_rowHoverIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex > -1) {
                dataGridView1.Rows[_rowHoverIndex].DefaultCellStyle.BackColor = Color.White;
                _rowHoverIndex = -1;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex > -1) {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCyan;
            }
        }
    }
}
