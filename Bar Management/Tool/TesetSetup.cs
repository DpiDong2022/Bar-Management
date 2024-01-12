using Bar_Management.DAO;
using Bar_Management.Models;
using Bar_Management.Tool;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace Bar_ManagementTests1 {
/*    [TestClass]*/
    public class TesetSetup {
        public static MockDbContext<TrangThaiTonKho> MockTrangThaiTonKhos { get; private set; }
        public static MockDbContext<NhaCungCap> MockNhaCungCaps { get; private set; }
        public static MockDbContext<NguyenLieu> MockNguyenLieus { get; private set; }
        public static MockDbContext<TonKho> MockTonKhos { get; private set; }
        public static MockDbContext<LoaiMonAn> MockLoaiMonAns { get; private set; }
        public static MockDbContext<MonAn> MockMonAns { get; private set; }
        public static MockDbContext<TrangThaiBan> MockTrangThaiBans { get; private set; }
        public static MockDbContext<Setting> MockSettings { get; private set; }
        public static MockDbContext<Role> MockRoles { get; private set; }
        public static MockDbContext<Ban> MockBans { get; private set; }
        public static MockDbContext<NhanVien> MockNhanViens { get; private set; }
        public static MockDbContext<TaiKhoan> MockTaiKhoans { get; private set; }
 
        /*[AssemblyInitialize]*/
        public static void AssemblyInitialize() {
            InitializeMockDbContext();
        }

        public static void InitializeMockDbContext() {
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
        }
    }
}
