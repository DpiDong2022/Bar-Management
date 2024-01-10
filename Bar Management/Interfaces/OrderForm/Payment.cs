using Bar_Management.BusinessLogic;
using Bar_Management.DTO;
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

namespace Bar_Management.OrderForm
{
    public partial class Payment : Form
    {
        private LoaiMonAnLogic _logicLoaimonan;
        private BindingList<LoaiMonAn> _table;

        private readonly MonAnLogic _logicMonan;
        private BindingList<MonAnOrderDTO> _tableMonan;
        public Payment()
        {
            InitializeComponent();
            _logicLoaimonan = new LoaiMonAnLogic();

            
            _logicMonan = new MonAnLogic();
            

        }
        private void LoadTable()
        {
            if (_table != null)
            {
                _table = null;
            }
            _table = new BindingList<LoaiMonAn>(_logicLoaimonan.GetAll().ToList());

            if (_tableMonan != null)
            {
                _tableMonan = null;
            }
            _tableMonan = new BindingList<MonAnOrderDTO>(_logicMonan.GetAllMonAnOrder().ToList());

        }
        public DataTable ConvertToDataTable<T>(BindingList<T> list)
        {
            DataTable dt = new DataTable();

            foreach (var info in typeof(T).GetProperties())
            {
                dt.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list)
            {
                object[] values = new object[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    values[i] = dt.Columns[i].DataType != typeof(DateTime) ? Convert.ChangeType(typeof(T).GetProperty(dt.Columns[i].ColumnName)?.GetValue(entity), dt.Columns[i].DataType) : DateTime.Parse(typeof(T).GetProperty(dt.Columns[i].ColumnName)?.GetValue(entity).ToString());
                }

                dt.Rows.Add(values);
            }

            return dt;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BillList newForm = new BillList();
            newForm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddCategory()
        {
            DataTable dt = new DataTable();
            LoadTable();
            dt = ConvertToDataTable<LoaiMonAn>(_table);
            CategoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
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

        private void _Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (Product)item;
                pro.Visible = pro.PCatergory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            gunaDataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProduct();
        }
        private void AddItems(string id, string name, string cat, string price, Image image)
        {
            var w = new Product()
            {
                PName = name,
                PPrice = price,
                PCatergory = cat,
                PImage = image,
                Id = Convert.ToInt32(id),
            };

            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (Product)ss;

                foreach (DataGridViewRow item in gunaDataGridView1.Rows)
                {
                    // check sản phẩm tồn tại
                    if (Convert.ToInt32(item.Cells["dgvId"].Value) == wdg.Id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvThanhtien"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvGia"].Value.ToString());
                        
                        return;
                        
                    }
                    
                }
                // Thêm sản phẩm mới
                gunaDataGridView1.Rows.Add(new object[] { 0, wdg.Id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                
            };

        }
        //public Image LoadImageFromUrl(string url)
        //{

        //    byte[] dataImage;
        //    try
        //    {
        //        dataImage = Internet.LoadImageFromUrl(url);
        //        using (MemoryStream ms = new MemoryStream(dataImage))
        //        {

        //            return Image.FromStream(ms);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        dataImage = Internet.LoadImageFromUrl("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXctqNvh3iZX3GK7QJV_cTXbB1Dntc_QkJjzDidc32h3_ZsWQvTmiJcOuexrVT_zlq3L4&usqp=CAU");
        //        using (MemoryStream ms = new MemoryStream(dataImage))
        //        {

        //            return Image.FromStream(ms);
        //        }
        //    }
        //}

        //// lấy sản phẩm từ data base
        //private void LoadProduct()
        //{
        //    DataTable dt = new DataTable();
        //    LoadTable();
        //    dt = ConvertToDataTable<MonAnOrderDTO>(_tableMonan);

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        string data = row["HinhAnh"].ToString();
        //        var image = LoadImageFromUrl(data);
        //        AddItems(row["Id"].ToString(), row["TenMon"].ToString(), row["LoaiMonAn"].ToString(),
        //                row["Gia"].ToString(), image);

        //    }

        //}
        MemoryCache memoryCache = new MemoryCache(new MemoryCacheOptions());
        public async Task<Image> LoadImageFromUrlAsync(string url)
        {
            Image image = memoryCache.Get(url) as Image;
            byte[] dataImage;
            if (image == null)
            {
                try
                {
                    dataImage = await Task.Run(() => Internet.LoadImageFromUrl(url));
                    using (MemoryStream ms = new MemoryStream(dataImage))
                    {
                        image =  Image.FromStream(ms);
                    }
                }
                catch (Exception)
                {
                    dataImage = await Task.Run(() => Internet.LoadImageFromUrl("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXctqNvh3iZX3GK7QJV_cTXbB1Dntc_QkJjzDidc32h3_ZsWQvTmiJcOuexrVT_zlq3L4&usqp=CAU"));
                    using (MemoryStream ms = new MemoryStream(dataImage))
                    {
                        image = Image.FromStream(ms);
                    }
                }
                memoryCache.Set(url, image,DateTimeOffset.MaxValue);
            }
            return image;
        }

        private async void LoadProduct()
        {
            DataTable dt = new DataTable();
            LoadTable();
            dt = ConvertToDataTable<MonAnOrderDTO>(_tableMonan);

            foreach (DataRow row in dt.Rows)
            {
                string data = row["HinhAnh"].ToString();
                var image = await LoadImageFromUrlAsync(data);
                AddItems(row["Id"].ToString(), row["TenMon"].ToString(), row["LoaiMonAn"].ToString(),
                        row["Gia"].ToString(), image);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (Product)item;
                pro.Visible = pro.PName.ToLower().Contains(textBox1.Text.Trim().ToLower());
            }
        }

        private void gunaDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // for searil no
            int count = 0;
            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }
        private void GetTotal()
        {
            double tot = 0;
            txtTotal.Text = "";
            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                if (int.Parse(row.Cells["dgvStt"].Value.ToString()) < gunaDataGridView1.Rows.Count  )
                {
                    tot += double.Parse(row.Cells["dgvThanhtien"].Value.ToString());
                }
                else break;
            }
            txtTotal.Text = tot.ToString("N2");
        }

        private void gunaDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            GetTotal();
        }
    }
}
