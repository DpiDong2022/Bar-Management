using AutoMapper;
using Bar_Management.BusinessLogic;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Models;
using Bar_Management.Tool;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Forms;

namespace Bar_Management.FoodForm {
    public partial class Food: Form {
        private readonly MonAnLogic _logic;
        private readonly LoaiMonAnLogic _loaiMonAnLogic;
        private BindingList<MonAnDto> _table;
        private readonly IMapper _mapper;
        private string _mode;
        public Food() {
            InitializeComponent();
            _logic = new MonAnLogic();
            _mapper = AutoMapperProfile.InitializeAutoMapper();
            _loaiMonAnLogic = new LoaiMonAnLogic();
            LoadTable();
            LoaiMonAnComboBox.ValueMember = "id";
            LoaiMonAnComboBox.DisplayMember = "tenLoai";
            LoaiMonAnComboBox.DataSource = new BindingList<LoaiMonAn>(_loaiMonAnLogic.GetAll().ToList());
        }

        private void LoadTable() {
            if (_table!=null) {
                _table.Clear();
            }
            IEnumerable<LoaiMonAn> loaimons = _loaiMonAnLogic.GetAll();
            //linq
            _table = new BindingList<MonAnDto>(_logic.GetAll().Select(monAn => new MonAnDto() {
                Id = monAn.Id,
                TenMon = monAn.TenMon,
                Gia = monAn.Gia.ToString("0#,##0"),
                TrangThai = monAn.IsAvailable == 1 ? "Còn" : "Hết",
                MoTa = monAn.MoTa,
                LoaiMonAn = loaimons.First(lm => lm.Id == monAn.LoaiMonAnId)
            }).ToList());
            dataGridView1.DataSource = _table;
        }

        private bool Validate(string tenMon, string gia, string moTa, int loaiMonId) {
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

            if (new GenericRepository<LoaiMonAn>().GetAll().First(c => c.Id == loaiMonId) == null) {
                errorLoai.SetError(LoaiMonAnComboBox, "Loại món ăn không còn tồn tại");
            } else {
                errorLoai.Clear();
            }

            if (moTa.Length > 100) {
                errorMota.SetError(motaText, "Chiều dài mô tả không vượt quá 100");
            } else {
                errorMota.Clear();
            }
            return isValid;
        }

        private void button1_Click(object sender, EventArgs e) {
            FoodAdd newForm = new FoodAdd();
            newForm.Show();
        }

        private void Food_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'quanLyBarHaiDataSet.LoaiMonAns' table. You can move, or remove it, as needed.
            this.loaiMonAnsTableAdapter.Fill(this.quanLyBarHaiDataSet.LoaiMonAns);

        }

        private void button2_Click(object sender, EventArgs e) {
            TenMonAnbox.Text = string.Empty;
            GiaMonAnTextboxs.Text = string.Empty;
            motaText.Text = string.Empty;
            LoaiMonAnComboBox.SelectedIndex = 0;
            TenMonAnbox.Focus();
            _mode = "them";
            
        }

        private void LuuBtn_Click(object sender, EventArgs e) {
            string tenMonAn = TenMonAnbox.Text.Trim();
            string gia = GiaMonAnTextboxs.Text.Trim();
            string moTa = motaText.Text.Trim();
            int tenLoaiMonAnId = (dataGridView1.SelectedRows[0].DataBoundItem as MonAnDto).LoaiMonAn.Id;
            // validate
            bool isValid = Validate(tenMonAn, gia,moTa, tenLoaiMonAnId);
            if (!isValid) return;
           
            MonAn monAn = new MonAn(){
                TenMon = tenMonAn,
                Gia = decimal.Parse(gia),
                MoTa = moTa,
                LoaiMonAnId = tenLoaiMonAnId,
                IsAvailable = 1
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
                /*int index = dataGridView1.SelectedRows[0].Index;
                int id = (int)(dataGridView1.Rows[index].Cells[0].Value);
                monAn.Id = id;*/
                
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
                    _table.ResetItem(index);
                   /* _table.RemoveAt(index);
                    _table.Insert(index, monAnDto);*/
                }
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e) {
            try {
                this.loaiMonAnsTableAdapter.FillBy(this.quanLyBarHaiDataSet.LoaiMonAns);
            } catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Food_MouseClick(object sender, MouseEventArgs e) {
        }
        private void XoaBtn_Click(object sender, EventArgs e) {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0) {
                errorXoa.SetError(XoaBtn, "Hãy chọn dòng để xóa");
            } else if(MessageBox.Show("Xóa món ăn?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)==DialogResult.OK){
                int id = (int)(selectedRows[0].Cells[0].Value);
                if (_logic.Delete(new MonAn() { Id = id })) {
                    _table.RemoveAt(selectedRows[0].Index);
                }
                errorXoa.Clear();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e) {
            // kiểm tra hàng được chọn là rỗng
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count != 0) {
                // lấy ra trực tiếp đối tượng hàng từ DataGridView, không cần gọi thuộc tính cell[0], cell[1], cell[2],... để lấy giá trị từng ô;
                MonAnDto monAnDto = selectedRows[0].DataBoundItem as MonAnDto;

                errorXoa.Clear();
                TenMonAnbox.Text = monAnDto.TenMon;
                motaText.Text = monAnDto.MoTa;
                GiaMonAnTextboxs.Text = monAnDto.Gia;

                int id = monAnDto.Id;

                foreach (var item in LoaiMonAnComboBox.Items)
                {
                    if (((LoaiMonAn)item).Id == id) {
                        LoaiMonAnComboBox.SelectedIndex = LoaiMonAnComboBox.Items.IndexOf(item);
                        break;
                    }
                }
                //LoaiMonAnComboBox.SelectedItem = (LoaiMonAn)(selectedRow.Cells[5].Value);
                _mode = "sua";
                var d = LoaiMonAnComboBox.SelectedItem;
                var dd = LoaiMonAnComboBox.SelectedValue;
                //Validate(TenMonAnbox.Text, GiaMonAnTextboxs.Text, motaText.Text, int.Parse(LoaiMonAnComboBox.SelectedValue.ToString()));
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {
            _table = new BindingList<MonAnDto>(_logic.TimKiem(searchKeytextBox.Text.Trim()));
            dataGridView1.DataSource = _table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void LoaiMonAnComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
