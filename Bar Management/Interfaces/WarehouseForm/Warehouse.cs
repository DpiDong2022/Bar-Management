using Bar_Management.BusinessLogic;
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

namespace Bar_Management.Interfaces.WarehouseForm
{
    public partial class Warehouse : Form
    {
        private readonly NguyenLieuLogic _nguyenLieuLogic;
        private readonly NhaCungCapLogic _nhaCungCapLogic;
        private readonly TrangThaiTonKhoLogic _trangThaiTonKhoLogic;
        private readonly TonKhoLogic _tonKhoLogic;
        private readonly SortableBindingList<TonKhoDto> _table;
        private int _rowSelectedIndex =-1;

        public Warehouse()
        {
            InitializeComponent();
            _tonKhoLogic = new TonKhoLogic();
            _nguyenLieuLogic = new NguyenLieuLogic();
            _nhaCungCapLogic = new NhaCungCapLogic();
            _trangThaiTonKhoLogic = new TrangThaiTonKhoLogic();
            _table = new SortableBindingList<TonKhoDto>(_tonKhoLogic.GetAll().ToList());
        }

        private void Warehouse_Load(object sender, EventArgs e) {
             cboxNguyenLieu.DataSource = new BindingList<NguyenLieu>(_nguyenLieuLogic.GetAll().ToList());
             cboxNhaCC.DataSource = new BindingList<NhaCungCap>(_nhaCungCapLogic.GetAll().ToList());
             cboxTrangthai.DataSource = new BindingList<TrangThaiTonKho>(_trangThaiTonKhoLogic.GetAll().ToList());
             dataGridView1.DataSource = _table;
        }

        private void btnThemNL_Click(object sender, EventArgs e) {
            var themNguyenLieuForm = new NguyenLieuF();
            themNguyenLieuForm.ShowDialog();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            new NguyenLieuF().ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex > -1) {
                _rowSelectedIndex = e.RowIndex;
                dataGridView1.Rows[_rowSelectedIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex > -1) {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCyan;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex > -1) {
                dataGridView1.Rows[_rowSelectedIndex].DefaultCellStyle.BackColor = Color.White;
                _rowSelectedIndex = -1;
            }
        }
    }
}
