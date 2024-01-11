using AutoMapper;
using Bar_Management.BusinessLogic;
using Bar_Management.DTO;
using Bar_Management.Models;
using Bar_Management.Tool;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.OrderHistoryForm
{
    public partial class OrderHistory : Form
    {
        private SortableBindingList<HoaDonDto> _tableHoaDon;
        private SortableBindingList<ChiTietHoaDonDto> _tableChiTiet;
        private readonly SortableBindingList<Ban> _tableBan;
        private readonly SortableBindingList<TaiKhoanDTO> _tabletaiKhoan;
        
        private readonly HoaDonLogic _hoaDonLogic;
        private  ChiTieHoaDonLogic _chiTieHoaDonLogic;
        private readonly BanLogic _banLogic;
        private readonly TaiKhoanLogic _taiKhoanLogic;

        private readonly IMapper _mapper;

        private int _taiKhoanId =-1;
        private int _banId =-1;
        private DateTime? _startDate = null;
        private DateTime? _endtDate = null;

        public OrderHistory()
        {
            InitializeComponent();
            _mapper = AutoMapperProfile.InitializeAutoMapper();

            _hoaDonLogic = new HoaDonLogic();
            _banLogic = new BanLogic();
            _taiKhoanLogic = new TaiKhoanLogic();
            _chiTieHoaDonLogic = new ChiTieHoaDonLogic();

            _tableBan = new SortableBindingList<Ban>(_banLogic.GetAll().ToList());
            _tableHoaDon = new SortableBindingList<HoaDonDto>(_hoaDonLogic.GetAllDto().ToList());
            _tableChiTiet = new SortableBindingList<ChiTietHoaDonDto>(_chiTieHoaDonLogic.GetAllDto().ToList());
            _tabletaiKhoan = new SortableBindingList<TaiKhoanDTO>(_taiKhoanLogic.GetAll().ToList());

            _tabletaiKhoan.Insert(0, new TaiKhoanDTO() { Id = -1, Ten = "--Tài khoản--" });
            _tableBan.Insert(0, new Ban() { Id = -1, TenBan = "--Bàn--" });

            locNhanVien.DataSource = _tabletaiKhoan;
            locBan.DataSource = _tableBan;
            locBan.SelectedIndex = 0;
            locNhanVien.SelectedIndex = 0;

            locBan.DropDownStyle = ComboBoxStyle.DropDownList;
            locNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;

            dataGridView1.DataSource = _tableHoaDon;
            for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            if (dataGridView1.SelectedRows.Count == 0) {
                return;
            }
            HoaDonDto hoadon = dataGridView1.SelectedRows[0].DataBoundItem as HoaDonDto;
            _tableChiTiet = new SortableBindingList<ChiTietHoaDonDto>(_chiTieHoaDonLogic
                .GetByHoaDonId(hoadon.Id).Select(c => _mapper.Map<ChiTietHoaDonDto>(c)).ToList());
        }

        private void OrderHistory_Load(object sender, EventArgs e) {
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e) {
            if (dataGridView1.SelectedRows.Count == 0) {
                return;
            }
            HoaDonDto hoadon = dataGridView1.SelectedRows[0].DataBoundItem as HoaDonDto;
            _tableChiTiet = new SortableBindingList<ChiTietHoaDonDto>(_chiTieHoaDonLogic
                .GetByHoaDonId(hoadon.Id).Select(c => _mapper.Map<ChiTietHoaDonDto>(c)).ToList());

            dataGridView2.DataSource = _tableChiTiet;
            for (int i = 0; i < dataGridView2.Rows.Count; i++) {
                dataGridView2.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dataGridView2_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 1) {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void dataGridView2_CellMouseLeave(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 1) {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        enum tranThaiHoaDon {

        }
        

        private void locBan_SelectedIndexChanged(object sender, EventArgs e) {
            if (locBan.SelectedItem != null) {
                _banId = (locBan.SelectedItem as Ban).Id;
            }
            _tableHoaDon = new SortableBindingList<HoaDonDto>(_hoaDonLogic.LocHoaDon(_banId, _taiKhoanId, _startDate, _endtDate).ToList());
            dataGridView1.DataSource = _tableHoaDon;
        }

        private void locNhanVien_SelectedIndexChanged(object sender, EventArgs e) {
            if (locNhanVien.SelectedItem != null) {
                _taiKhoanId = (locNhanVien.SelectedItem as TaiKhoanDTO).Id;
            }
            _tableHoaDon = new SortableBindingList<HoaDonDto>(_hoaDonLogic.LocHoaDon(_banId, _taiKhoanId, _startDate, _endtDate).ToList());
            dataGridView1.DataSource = _tableHoaDon;
        }

        private void Loc() {
            _tableHoaDon = new SortableBindingList<HoaDonDto>(_hoaDonLogic.LocHoaDon(_banId, _taiKhoanId, _startDate, _endtDate).ToList());
            dataGridView1.DataSource = _tableHoaDon;
        }

        private void dateTimeStart_ValueChanged(object sender, EventArgs e) {
            _startDate = dateTimeStart.Value;
            _tableHoaDon = new SortableBindingList<HoaDonDto>(_hoaDonLogic.LocHoaDon(_banId, _taiKhoanId, _startDate, _endtDate).ToList());
            dataGridView1.DataSource = _tableHoaDon;
        }

        private void dateTimeEnd_ValueChanged(object sender, EventArgs e) {
            _endtDate = dateTimeEnd.Value;
            _tableHoaDon = new SortableBindingList<HoaDonDto>(_hoaDonLogic.LocHoaDon(_banId, _taiKhoanId, _startDate, _endtDate).ToList());
            dataGridView1.DataSource = _tableHoaDon;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void sortTenBan_CheckedChanged(object sender, EventArgs e) {
            _tableHoaDon = new SortableBindingList<HoaDonDto>(_hoaDonLogic
                .LocHoaDon(_banId, _taiKhoanId, _startDate, _endtDate).ToList().OrderBy(c => c.Ban.Id).ToList());
            dataGridView1.DataSource = _tableHoaDon;
        }

        private void sorTimein_CheckedChanged(object sender, EventArgs e) {
            _tableHoaDon = new SortableBindingList<HoaDonDto>(_hoaDonLogic
                .LocHoaDon(_banId, _taiKhoanId, _startDate, _endtDate).ToList().OrderBy(c => DateTime.ParseExact((string)c.NgayTao, "dd-MM-yyyy", null)).ToList());
            dataGridView1.DataSource = _tableHoaDon;
        }

        private void radioSortGia_CheckedChanged(object sender, EventArgs e) {
            _tableHoaDon = new SortableBindingList<HoaDonDto>(_hoaDonLogic
    .LocHoaDon(_banId, _taiKhoanId, _startDate, _endtDate).ToList().OrderBy(c => decimal.Parse(((string)c.TongGia).Replace(",",""))).ToList());
            dataGridView1.DataSource = _tableHoaDon;
        }
    }
}
