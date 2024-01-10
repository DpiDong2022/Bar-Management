using AutoMapper;
using Bar_Management.BusinessLogic;
using Bar_Management.DTO;
using Bar_Management.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.OrderHistoryForm
{
    public partial class OrderHistory : Form
    {
        private readonly SortableBindingList<HoaDonDto> _tableHoaDon;
        private readonly SortableBindingList<ChiTietHoaDonDto> _tableChiTiet;
        private readonly SortableBindingList<Ban> _tableBan;
        private readonly SortableBindingList<TaiKhoanDTO> _tabletaiKhoan;
        
        private readonly HoaDonLogic _hoaDonLogic;
        private readonly ChiTieHoaDonLogic _chiTieHoaDonLogic;
        private readonly BanLogic _banLogic;
        private readonly TaiKhoanLogic _taiKhoanLogic;
        private readonly IMapper _mapper;

        public OrderHistory()
        {
            InitializeComponent();
            _hoaDonLogic = new HoaDonLogic();
            _banLogic = new BanLogic();
            _taiKhoanLogic = new TaiKhoanLogic();
            _hoaDonLogic = new HoaDonLogic();
            _chiTieHoaDonLogic = new ChiTieHoaDonLogic();

            _tableBan = new SortableBindingList<Ban>(_banLogic.GetAll().ToList());
            _tableHoaDon = new SortableBindingList<HoaDonDto>(_hoaDonLogic.GetAllDto().ToList());
            _tableChiTiet = new SortableBindingList<ChiTietHoaDonDto>(_chiTieHoaDonLogic.GetAllDto().ToList());
            _tabletaiKhoan = new SortableBindingList<TaiKhoanDTO>(_taiKhoanLogic.GetAll().ToList());

            dataGridView1.DataSource = _tableHoaDon;
            locBan.DataSource = _tableBan;
            locNhanVien.DataSource = _tabletaiKhoan;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }

        private void OrderHistory_Load(object sender, EventArgs e) {

        }

        private void sortTenBan_CheckedChanged(object sender, EventArgs e) {

        }

        private void radioSortGia_CheckedChanged(object sender, EventArgs e) {

        }

        private void sorTimein_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
