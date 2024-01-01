using AutoMapper;
using Bar_Management.BusinessLogic;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Interfaces;
using Bar_Management.Models;
using Bar_Management.Tool;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bar_Management.FoodForm {
    public partial class Food: Form {
        private readonly MonAnLogic _logic;
        private readonly LoaiMonAnLogic _loaiMonAnLogic;
        private SortableBindingList<MonAnDto> _table;
        private SortableBindingList<LoaiMonAn> _tableLoaimonAn;
        private readonly IMapper _mapper;
        private string _mode;
        private string _picturePath;
        public Food() {
            InitializeComponent();
            _logic = new MonAnLogic();
            _mapper = AutoMapperProfile.InitializeAutoMapper();
            _loaiMonAnLogic = new LoaiMonAnLogic();
            LoadTable();
            LoaiMonAnComboBox.ValueMember = "Id";
            LoaiMonAnComboBox.DisplayMember = "TenLoai";
            _tableLoaimonAn = new SortableBindingList<LoaiMonAn>(_loaiMonAnLogic.GetAll().ToList());
            _tableLoaimonAn.Insert(0,new LoaiMonAn() {Id=-1, TenLoai= "--Loại đồ ăn--" });
            LoaiMonAnComboBox.DataSource = _tableLoaimonAn;
            comboBoxTranthai.DropDownStyle = ComboBoxStyle.DropDownList;
            LoaiMonAnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTranthai.SelectedIndex = 0;
            LoaiMonAnComboBox.SelectedIndex = 0;
        }

        private void LoadTable() {
            if (_table != null) {
                _table.Clear();
            }
            IEnumerable<LoaiMonAn> loaimons = _loaiMonAnLogic.GetAll();
            //linq
            _table = new SortableBindingList<MonAnDto>(_logic.GetAll().Select(monAn => new MonAnDto() {
                Id = monAn.Id,
                TenMon = monAn.TenMon,
                Gia = string.Format("{0:#,##0}", monAn.Gia),
                TrangThai = monAn.IsAvailable == 1 ? "Còn" : "Hết",
                MoTa = monAn.MoTa,
                LoaiMonAn = loaimons.First(lm => lm.Id == monAn.LoaiMonAnId),
                HinhAnh = monAn.HinhAnh
            }).ToList());
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
                errorLoai.SetError(LoaiMonAnComboBox, "Bạn chưa chọn loại món ăn");
                isValid = false;
            }
            else if (new GenericRepository<LoaiMonAn>().GetAll().First(c => c.Id == loaiMonId) == null) {
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

            if (pictureBox1.Image==null) {
                errorHinhAnh.SetError(pictureBox1, "Hãy chọn một hình ảnh cho món ăn");
                isValid = false;
            } else {
                errorHinhAnh.Clear();
            }

            if (trangThai=="--Trạng thái--") {
                errorTrangThai.SetError(comboBoxTranthai, "Hãy chọn trạng thái món ăn");
                isValid = false;
            } else {
                errorTrangThai.Clear();
            }
            return isValid;
        }

        private void button1_Click(object sender, EventArgs e) {
            FoodAdd newForm = new FoodAdd();
            newForm.Show();
        }

        private void Food_Load(object sender, EventArgs e) {
            pictureBox1.AllowDrop = true;
        }

        private void button2_Click(object sender, EventArgs e) {
            TenMonAnbox.Text = string.Empty;
            GiaMonAnTextboxs.Text = string.Empty;
            motaText.Text = string.Empty;
            LoaiMonAnComboBox.SelectedIndex = 0;
            pictureBox1.Image = null;
            comboBoxTranthai.SelectedIndex = 0;
            TenMonAnbox.Focus();
            _mode = "them";

        }

        private async void LuuBtn_Click(object sender, EventArgs e) {
            // kiem tra connection internet
            if (!Internet.IsInternetAvailable()) {
                MessageBox.Show("Bạn chưa kết nối với internet, hãy kết nối với internet trước khi thực thi các tác vụ");
            }
            if (dataGridView1.SelectedRows.Count == 0) {
                errorEdit.SetError(LuuBtn, "Bạn chưa chọn dòng để chỉnh sửa");
                return;
            } else {
                errorEdit.Clear();
            }
            string tenMonAn = TenMonAnbox.Text.Trim();
            string gia = GiaMonAnTextboxs.Text.Trim();
            string moTa = motaText.Text.Trim();
            int tenLoaiMonAnId = (LoaiMonAnComboBox.SelectedItem as LoaiMonAn).Id;
            string trangThai = comboBoxTranthai.SelectedItem.ToString();
            // validate
            bool isValid = Validate(tenMonAn, gia,moTa, tenLoaiMonAnId, trangThai);
            if (!isValid)
                return;

            new LoadingForm(1).ShowDialog();
            string url = await CloudinaryService.uploadImage(_picturePath);

            MonAn monAn = new MonAn(){
                TenMon = tenMonAn,
                Gia = decimal.Parse(gia),
                MoTa = moTa,
                LoaiMonAnId = tenLoaiMonAnId,
                IsAvailable = trangThai == "Còn" ? 1:0,
                HinhAnh = url
            };

            // Mapper from monAn to monAnDto
            MonAnDto monAnDto = _mapper.Map<MonAnDto>(monAn);

            // Them/Sua
            if (_mode == "them" && _logic.Insert(monAn)) {
                MessageBox.Show("Success");
                errorLuu.Clear();
                LoadTable();
            } else if (_mode == "sua") {
                update(monAn, monAnDto);

                errorLuu.Clear();
            } else {
                errorLuu.SetError(LuuBtn, "Hãy chọn chức năng Thêm hoặc Sửa");
            }
        }

        private void update(MonAn monAn, MonAnDto monAnDto) {

            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0) {
                errorEdit.SetError(LuuBtn, "Hãy chọn dòng để sửa");
            } else {
                errorEdit.Clear();
                int index = dataGridView1.SelectedRows[0].Index;
                int id = (int)(dataGridView1.Rows[index].Cells[0].Value);
                monAn.Id = id;
                monAnDto.Id = id;

                if (_logic.Update(monAn)) {
                    MessageBox.Show("Sửa thành công");
                    _table.RemoveAt(index);
                    _table.Insert(index, monAnDto);
                    dataGridView1.Rows[index].Selected = true;
                }
            }
        }

        private void Food_MouseClick(object sender, MouseEventArgs e) {
        }
        private void XoaBtn_Click(object sender, EventArgs e) {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0) {
                errorXoa.SetError(XoaBtn, "Hãy chọn dòng để xóa");
            } else if (MessageBox.Show("Xóa món ăn?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK) {
                int id = (int)(selectedRows[0].Cells[0].Value);
                if (_logic.Delete(new MonAn() { Id = id })) {
                    _table.RemoveAt(selectedRows[0].Index);
                }
                errorXoa.Clear();
                TenMonAnbox.Text = string.Empty;
                GiaMonAnTextboxs.Text = string.Empty;
                motaText.Text = string.Empty;
                LoaiMonAnComboBox.SelectedIndex = 0;
                pictureBox1.Image = null;
                comboBoxTranthai.SelectedItem = null;
                TenMonAnbox.Focus();
                _mode = "";
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e) {
            if (Internet.IsInternetAvailable()==false) {
                MessageBox.Show("Bạn chưa kết nssối với internet");
                return;
            }
            // kiểm tra hàng được chọn là rỗng
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count != 0) {
                // lấy ra trực tiếp đối tượng hàng từ DataGridView, không cần gọi thuộc tính cell[0], cell[1], cell[2],... để lấy giá trị từng ô;
                MonAnDto monAnDto = selectedRows[0].DataBoundItem as MonAnDto;

                errorXoa.Clear();
                TenMonAnbox.Text = monAnDto.TenMon;
                motaText.Text = monAnDto.MoTa;
                GiaMonAnTextboxs.Text = monAnDto.Gia;
                comboBoxTranthai.SelectedIndex = monAnDto.TrangThai == "Còn" ? 1 : 2;

                int id = monAnDto.LoaiMonAn.Id;

                foreach (var item in LoaiMonAnComboBox.Items) {
                    if (((LoaiMonAn)item).Id == id) {
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
                    _mode = "sua";
                var d = LoaiMonAnComboBox.SelectedItem;
                var dd = LoaiMonAnComboBox.SelectedValue;
                //Validate(TenMonAnbox.Text, GiaMonAnTextboxs.Text, motaText.Text, int.Parse(LoaiMonAnComboBox.SelectedValue.ToString()));
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {
            int tenLoaiMonAnId = (LoaiMonAnComboBox.SelectedItem as LoaiMonAn).Id;
            int trangThaiId = comboBoxTranthai.SelectedIndex;
            if (trangThaiId == 0) {
                trangThaiId = -1;
            } else if(trangThaiId==1){
                trangThaiId = 1;
            } else {
                trangThaiId = 0;
            }
            _table = new SortableBindingList<MonAnDto>(_logic.TimKiem(searchKeytextBox.Text.Trim(), tenLoaiMonAnId, trangThaiId));
            dataGridView1.DataSource = _table;

        }

        private void SuaBtn_Click(object sender, EventArgs e) {
            _logic.ExportToExcel(_table);
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e) {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null) {
                var filenames = data as string[];
                if (filenames.Length > 0) {
                    _picturePath = filenames[0];
                    pictureBox1.Image = Image.FromFile(filenames[0]);
                }
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;    
        }

        private void LoaiMonAnComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            textBox4_TextChanged(sender, e);
        }

        private void comboBoxTranthai_SelectedIndexChanged(object sender, EventArgs e) {
            textBox4_TextChanged(sender, e);
        }
    }
}
