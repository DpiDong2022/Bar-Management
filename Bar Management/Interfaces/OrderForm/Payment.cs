using Bar_Management.BusinessLogic;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.MainForm;
using Bar_Management.Models;
using Bar_Management.Tool;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.OrderForm {
    public partial class Payment: Form {
        public string TenBan { get; set; }
        public string NhanVienID { get; set; }
        private LoaiMonAnLogic _logicLoaimonan;
        private BindingList<LoaiMonAn> _table;

        private readonly MonAnLogic _logicMonan;
        private BindingList<MonAnOrderDTO> _tableMonan;

        private readonly HoaDonLogic _logicHoaDon;
        private SortableBindingList<HoaDonDto> _tableHoaDon;

        private readonly ChiTieHoaDonLogic _logicChiTiet;
        private SortableBindingList<ChiTietHoaDonDto> _tableChiTiet;

        private readonly NhanVien _logicNhanVien;
        private SortableBindingList<NhanVienDTO> _tableNhanVien;

        private readonly BanLogic _logicBan;

        private Form _parent;

        public Payment(int BanId, Form parent) {

            InitializeComponent();
            _logicLoaimonan = new LoaiMonAnLogic();

            _logicMonan = new MonAnLogic();

            _logicHoaDon = new HoaDonLogic();

            _logicChiTiet = new ChiTieHoaDonLogic();

            _logicBan = new BanLogic();
            TenBan = BanId.ToString();
            _parent = parent;

        }
        private void LoadTable() {
            if (_table != null) {
                _table = null;
            }
            _table = new BindingList<LoaiMonAn>(_logicLoaimonan.GetAll().ToList());

            if (_tableMonan != null) {
                _tableMonan = null;
            }
            _tableMonan = new BindingList<MonAnOrderDTO>(_logicMonan.GetAllMonAnOrder().ToList());

        }
        public DataTable ConvertToDataTable<T>(BindingList<T> list) {
            DataTable dt = new DataTable();

            foreach (var info in typeof(T).GetProperties()) {
                dt.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list) {
                object[] values = new object[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++) {
                    values[i] = dt.Columns[i].DataType != typeof(DateTime) ? Convert.ChangeType(typeof(T).GetProperty(dt.Columns[i].ColumnName)?.GetValue(entity), dt.Columns[i].DataType) : DateTime.Parse(typeof(T).GetProperty(dt.Columns[i].ColumnName)?.GetValue(entity).ToString());
                }

                dt.Rows.Add(values);
            }

            return dt;
        }


        private void button5_Click(object sender, EventArgs e) {
            this.Close();
            Main main = new Main();
            main.Show();
            main.btnOrder.PerformClick();


        }

        private void button6_Click(object sender, EventArgs e) {
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }
        private void AddCategory() {
            DataTable dt = new DataTable();
            LoadTable();
            dt = ConvertToDataTable<LoaiMonAn>(_table);
            CategoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0) {
                foreach (DataRow row in dt.Rows) {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(168, 54);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["TenLoai"].ToString();
                    b.TextAlign = HorizontalAlignment.Left;

                    //event for click
                    b.Click += new EventHandler(_Click);


                    CategoryPanel.Controls.Add(b);

                }
            }
        }

        private void _Click(object sender, EventArgs e) {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in ProductPanel.Controls) {
                var pro = (Product)item;
                pro.Visible = pro.PCatergory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
        private void LoadDataGridView(int BanId) {
            HoaDon checkHoaDon = _logicHoaDon.GetAll().ToList().Where(x => x.BanId.ToString() == TenBan)
                                                                    .OrderByDescending(x => x.NgayTao)
                                                                    .FirstOrDefault();
            if (checkHoaDon == null) {
                return;
            } else if (checkHoaDon != null && checkHoaDon.TrangThai == false) {
                var ChiTiets = _logicChiTiet.GetAll().ToList().Where(x => x.HoaDonId == checkHoaDon.Id);
                gunaDataGridView1.Rows.Clear();
                if (ChiTiets != null) {
                    foreach (var item in ChiTiets) {
                        string TenMon = item.MonAn.TenMon;
                        gunaDataGridView1.Rows.Add(new object[] { item.Id, item.MonAnId, TenMon, item.SoLuong, item.MonAn.Gia, item.ThanhTien });
                    }
                }
            } else if (checkHoaDon.TrangThai == true) {
                gunaDataGridView1.Rows.Clear();
            }

            //gunaDataGridView1.Rows.Add(new object[] { 0, wdg.Id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });

        }

        private void Payment_Load(object sender, EventArgs e) {
            gunaDataGridView1.BorderStyle = BorderStyle.FixedSingle;
            LoadDataGridView(int.Parse(TenBan));
            GetTotal();

            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProduct();
        }
        private void AddItems(string id, string name, string cat, string price, Image image) {
            var w = new Product()
            {
                PName = name,
                PPrice = price,
                PCatergory = cat,
                PImage = image,
                Id = Convert.ToInt32(id),
            };

            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) => {
                var wdg = (Product)ss;

                foreach (DataGridViewRow item in gunaDataGridView1.Rows) {
                    // check sản phẩm tồn tại
                    if (Convert.ToInt32(item.Cells["dgvId"].Value) == wdg.Id) {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvThanhtien"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvGia"].Value.ToString());

                        GetTotal();
                        return;

                    }

                }
                // Thêm sản phẩm mới
                gunaDataGridView1.Rows.Add(new object[] { 0, wdg.Id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();

            };

        }

        MemoryCache memoryCache = new MemoryCache(new MemoryCacheOptions());
        public async Task<Image> LoadImageFromUrlAsync(string url) {
            Image image = memoryCache.Get(url) as Image;
            byte[] dataImage;
            if (image == null) {
                try {
                    dataImage = await Task.Run(() => Internet.LoadImageFromUrl(url));
                    using (MemoryStream ms = new MemoryStream(dataImage)) {
                        image = Image.FromStream(ms);
                    }
                } catch (Exception) {
                    dataImage = await Task.Run(() => Internet.LoadImageFromUrl("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXctqNvh3iZX3GK7QJV_cTXbB1Dntc_QkJjzDidc32h3_ZsWQvTmiJcOuexrVT_zlq3L4&usqp=CAU"));
                    using (MemoryStream ms = new MemoryStream(dataImage)) {
                        image = Image.FromStream(ms);
                    }
                }
                memoryCache.Set(url, image, DateTimeOffset.MaxValue);
            }
            return image;
        }

        private async void LoadProduct() {
            DataTable dt = new DataTable();
            LoadTable();
            dt = ConvertToDataTable<MonAnOrderDTO>(_tableMonan);

            foreach (DataRow row in dt.Rows) {
                string data = row["HinhAnh"].ToString();
                var image = await LoadImageFromUrlAsync(data);
                AddItems(row["Id"].ToString(), row["TenMon"].ToString(), row["LoaiMonAn"].ToString(),
                        row["Gia"].ToString(), image);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e) {
            foreach (var item in ProductPanel.Controls) {
                var pro = (Product)item;
                pro.Visible = pro.PName.ToLower().Contains(textBox1.Text.Trim().ToLower());
            }
        }

        private void gunaDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            // for searil no
            int count = 0;
            foreach (DataGridViewRow row in gunaDataGridView1.Rows) {
                count++;
                row.Cells[0].Value = count;
            }
        }
        private void GetTotal() {
            double tot = 0;
            txtTotal.Text = "";
            foreach (DataGridViewRow row in gunaDataGridView1.Rows) {
                tot += double.Parse(row.Cells["dgvThanhtien"].Value.ToString());
            }
            txtTotal.Text = tot.ToString();
        }

        private void gunaDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {

        }

        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void txtTotal_Click(object sender, EventArgs e) {

        }

        private void btnThanhtoan_Click(object sender, EventArgs e) {
            GetTotal();
            Ban ban = _logicBan.GetAll().FirstOrDefault(x => x.Id.ToString() == TenBan);
            ban.TrangThaiId = 2;
            _logicBan.Update(ban);

            int TaiKhoanId = Singleton.TaiKhoanId;
            var checkHoaDon = _logicHoaDon.GetAll().Where(x => x.BanId.ToString() == TenBan 
                                                                    && x.TaiKhoanTaoId == TaiKhoanId)
                                                                    .OrderByDescending(x => x.NgayTao)
                                                                    .FirstOrDefault();
            checkHoaDon.Ban = _logicBan.GetAll().FirstOrDefault(x => x.Id.ToString() == TenBan);
            checkHoaDon.TrangThai = true;
            _logicHoaDon.Update(checkHoaDon);


        }

        private void btnLuu_Click(object sender, EventArgs e) {
            var ban = _logicBan.GetAll().ToList().FirstOrDefault(x => x.Id.ToString() == TenBan);
            if (gunaDataGridView1.RowCount == 0) {
                MessageBox.Show("Chưa có món ăn nào được chọn ! ");
                return;
            }
            var checkHoaDon = _logicHoaDon.GetAll().Where(x => x.BanId.ToString() == TenBan)
                                                                    .OrderByDescending(x => x.NgayTao)
                                                                    .FirstOrDefault();
            if (checkHoaDon == null || checkHoaDon.TrangThai == true) {
                HoaDon hoaDon = new HoaDon()
                {
                    BanId  = int.Parse(TenBan),
                    TaiKhoanTaoId = Singleton.TaiKhoanId,
                    NgayTao = DateTime.Now,
                    TongGia = 0,
                    TrangThai = false

                };
                _logicHoaDon.Update(hoaDon);
                foreach (DataGridViewRow item in gunaDataGridView1.Rows) {
                    ChiTietHoaDon chiTiet = new ChiTietHoaDon()
                    {
                        HoaDonId = hoaDon.Id,
                        //MonAn = _logicMonan.GetAll().ToList().FirstOrDefault(x => x.Id == int.Parse(item.Cells["dgvId"].Value.ToString()),
                        MonAnId = int.Parse(item.Cells["dgvId"].Value.ToString()),
                        SoLuong = int.Parse(item.Cells["dgvQty"].Value.ToString()),
                        ThanhTien = decimal.Parse(item.Cells["dgvThanhTien"].Value.ToString()),
                    };
                    _logicChiTiet.Insert(chiTiet);
                }

                ban.TrangThaiId = 2;
                _logicBan.Update(ban);

                MessageBox.Show("Lưu thành công ");

            } else if (checkHoaDon != null) {
                foreach (DataGridViewRow item in gunaDataGridView1.Rows) {
                    string CellMonan = item.Cells["dgvTenmon"].Value.ToString();

                    var CheckChitiet = _logicChiTiet.GetAll().ToList().Where(x=> x.HoaDonId == checkHoaDon.Id);
                    var CheckChiTietMonan = CheckChitiet.FirstOrDefault(x => x.MonAn.TenMon.ToString() == CellMonan);
                    if (CheckChiTietMonan == null) {
                        ChiTietHoaDon chiTiet = new ChiTietHoaDon()
                        {
                            HoaDonId = checkHoaDon.Id,
                            //MonAn = _logicMonan.GetAll().ToList().FirstOrDefault(x => x.Id == int.Parse(item.Cells["dgvId"].Value.ToString()),
                            MonAnId = int.Parse(item.Cells["dgvId"].Value.ToString()),
                            SoLuong = int.Parse(item.Cells["dgvQty"].Value.ToString()),
                            ThanhTien = decimal.Parse(item.Cells["dgvThanhTien"].Value.ToString()),
                        };
                        _logicChiTiet.Update(chiTiet);
                    } else if (CheckChiTietMonan.SoLuong != int.Parse(item.Cells["dgvQty"].Value.ToString())) {
                        CheckChiTietMonan.SoLuong = int.Parse(item.Cells["dgvQty"].Value.ToString());
                        CheckChiTietMonan.ThanhTien = decimal.Parse(item.Cells["dgvThanhTien"].Value.ToString());
                        _logicChiTiet.Update(CheckChiTietMonan);
                    }

                }
                ban.TrangThaiId = 2;
                _logicBan.Update(ban);
                MessageBox.Show("Lưu thành công ");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e) {
            var item = gunaDataGridView1.SelectedRows[0];
            if (item == null) {
                MessageBox.Show("Chưa chọn món cần tăng Số lượng ");
                return;
            };
            item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
            item.Cells["dgvThanhtien"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvGia"].Value.ToString());

            GetTotal();
        }

        private void btnTru_Click(object sender, EventArgs e) {
           

            var item = gunaDataGridView1.SelectedRows[0];
            if (item == null) {
                MessageBox.Show("Chưa chọn món cần giảm Số lượng ");
                return;
            };
            if (item.Cells["dgvQty"].Value.ToString()=="1") {
                return;
            }


            item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) - 1;
            item.Cells["dgvThanhtien"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvGia"].Value.ToString());
            GetTotal();
        }

        private void btnBochon_Click(object sender, EventArgs e) {

            if (gunaDataGridView1.Rows.Count == 0) {
                return;
            }
            var item = gunaDataGridView1.SelectedRows[0];
            if (item == null) {
                MessageBox.Show("Chưa chọn món cần bỏ chọn ");
                return;
            };

            var checkHoaDon = _logicHoaDon.GetAll().ToList().Where(x => x.BanId.ToString() == TenBan)
                                                                    .OrderByDescending(x => x.NgayTao)
                                                                    .FirstOrDefault();
            string CellMonan = item.Cells["dgvTenmon"].Value.ToString();
            var chiTiet = _logicChiTiet.GetAll().FirstOrDefault(x=> x.HoaDonId == checkHoaDon.Id && x.MonAn.TenMon.ToString() == CellMonan);
            if (chiTiet == null) {
                gunaDataGridView1.Rows.Remove(item);
            } else {
                gunaDataGridView1.Rows.Remove(item);
                chiTiet.HoaDon = null;
                _logicChiTiet.Delete(chiTiet);
            }
            GetTotal();
        }

        private void btnTInhTien_Click(object sender, EventArgs e) {
            if (gunaDataGridView1.Rows.Count==0) {
                MessageBox.Show("Không có gì để thanh toán");
                return;
            }
            BanLogic _logicBan2 = new BanLogic();
            int TaiKhoanId = Singleton.TaiKhoanId;
            var checkHoaDon = _logicHoaDon.GetAll().Where(x => x.BanId.ToString() == TenBan)
                                                                    .OrderByDescending(x => x.NgayTao)
                                                                    .FirstOrDefault();

            //checkHoaDon.Ban = _logicBan.GetAll().FirstOrDefault(x => x.Id.ToString() == TenBan);
            int IdBan = int.Parse(TenBan);
            Ban ban1 = _logicBan._context.Find<Ban>(IdBan);
            checkHoaDon.TrangThai = true;
            checkHoaDon.TongGia = decimal.Parse(txtTotal.Text);
            _logicHoaDon.Update(checkHoaDon);
            var ban = _logicBan.GetAll().FirstOrDefault(x => x.Id.ToString() == TenBan);
            ban.TrangThaiId = 1;
            gunaDataGridView1.Rows.Clear();
            _logicBan2.Update(ban);


            MessageBox.Show("Thanh toán thành công ");
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e) {
            // ((Main)_parent.Parent).btnOrder.PerformClick();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void btnBan_Click(object sender, EventArgs e) {
        }
    }
}