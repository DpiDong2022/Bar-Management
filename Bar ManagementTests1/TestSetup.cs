using Bar_Management.DAO;
using Bar_Management.Models;
using Bar_Management.Tool;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace Bar_ManagementTests1 {
/*    [TestClass]*/
    public class TestSetup {
        public TestSetup() {
            InitializeMockDbContext();
        }

        public MockDbContext<TrangThaiTonKho> MockTrangThaiTonKhos { get; private set; }
        public  MockDbContext<NhaCungCap> MockNhaCungCaps { get; private set; }
        public  MockDbContext<NguyenLieu> MockNguyenLieus { get; private set; }
        public  MockDbContext<TonKho> MockTonKhos { get; private set; }
        public  MockDbContext<LoaiMonAn> MockLoaiMonAns { get; private set; }
        public  MockDbContext<MonAn> MockMonAns { get; private set; }
        public  MockDbContext<TrangThaiBan> MockTrangThaiBans { get; private set; }
        public  MockDbContext<Setting> MockSettings { get; private set; }
        public  MockDbContext<Role> MockRoles { get; private set; }
        public  MockDbContext<Ban> MockBans { get; private set; }
        public  MockDbContext<NhanVien> MockNhanViens { get; private set; }
        public  MockDbContext<TaiKhoan> MockTaiKhoans { get; private set; }
        public  MockDbContext<HoaDon> MockHoaDons { get; private set; }
        public  MockDbContext<ChiTietHoaDon> MockChiTietHoaDons { get; private set; }


        public void InitializeMockDbContext() {
            MockTrangThaiTonKhos = new MockDbContext<TrangThaiTonKho>(GenerateData.trangThaiTonKhos);
            MockNhaCungCaps = new MockDbContext<NhaCungCap>(GenerateData.nhaCungCaps);
            MockNguyenLieus = new MockDbContext<NguyenLieu>(GenerateData.nguyenLieus);
            MockTonKhos = new MockDbContext<TonKho>(GenerateData.tonKhos);
            MockLoaiMonAns = new MockDbContext<LoaiMonAn>(GenerateData.loaiMonAns);
            MockMonAns = new MockDbContext<MonAn>(GenerateData.monAns);
            MockTrangThaiBans = new MockDbContext<TrangThaiBan>(GenerateData.trangThaiBans);
            MockSettings = new MockDbContext<Setting>(GenerateData.settings);
            MockRoles = new MockDbContext<Role>(GenerateData.roles);
            MockBans = new MockDbContext<Ban>(GenerateData.bans);
            MockNhanViens = new MockDbContext<NhanVien>(GenerateData.nhanViens);
            MockTaiKhoans = new MockDbContext<TaiKhoan>(GenerateData.taiKhoans);
            MockHoaDons = new MockDbContext<HoaDon>(GenerateData.hoaDons);
            MockChiTietHoaDons = new MockDbContext<ChiTietHoaDon>(GenerateData.chiTietHoaDons);
        }
    }
}
