using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bar_Management.LogicForTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bar_Management.Models;
using System.Runtime.InteropServices;
using Bar_Management.DAO;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Bar_Management.LogicForTest.Tests {
    [TestClass()]
    public class MonAnLogicForTestTests {
        private MonAnLogicForTest _monAnLogicForTest;
        private AppDbContext _appDbContext;

        public MonAnLogicForTestTests() {
            _appDbContext = new AppDbContext();
            _monAnLogicForTest = new MonAnLogicForTest(_appDbContext);
            
        }

        [DataRow(1, true)]
        [DataRow(5, true)]
        [DataRow(9, true)]
        [DataRow(15, false)]
        [TestMethod()]
        public void DeleteTest(int monAnId, bool expected) {
            using (var transaction = _appDbContext.Database.BeginTransaction()) {
                // xóa món ăn
                _monAnLogicForTest.Delete(new MonAn{ Id = monAnId});

                // Lấy ra các món ăn vừa xóa, nếu null thì món ăn đã bị xóa
                MonAn monAnRemoved = _appDbContext.MonAns
                                        .FirstOrDefault(man => man.Id==monAnId);
                Assert.IsNull(monAnRemoved);

                if (monAnId == 15) {
                    transaction.Rollback();
                }
            }
        }

        [TestMethod()]
        public void GetAllTest() {
            // Kiểm tra 14 món ăn mặc định của phần mềm
            IEnumerable<MonAn> monAns = _monAnLogicForTest.GetAll();
            Assert.IsTrue(monAns.Count()==14);
        }

        [DataRow(1, "Nước khoáng", 1, "", false)]
        [DataRow(2, "Nước cam", 5, "32000", true)]
        [DataRow(3, "Dưa hấu", 9, "51000d", false)]
        [DataRow(3, "", 9, "51000d", false)]
        [TestMethod()]
        public void UpdateTest(int monAnId, string tenMonAn, int loaiMonAnId, string gia, bool expected) {

            ValidateStatus tenValid = _monAnLogicForTest.ValidateTen(tenMonAn);
            ValidateStatus loaiMonAnValid = _monAnLogicForTest.ValidateLoaiMonAn(loaiMonAnId);
            ValidateStatus giaValid = _monAnLogicForTest.ValidateGia(gia);

            bool isvalid=false;
            if (ValidateStatus.Ok == tenValid && tenValid == loaiMonAnValid && loaiMonAnValid == giaValid) {
                isvalid = true;
            }

            Assert.AreEqual(expected, isvalid);
        }

        [DataRow("Nước khoáng", 1, 13000, true)]
        [DataRow("Nước cam",    5, 30000, true)]
        [DataRow("Dưa hấu",     9, 50000, true)]
        [DataRow("Kẹo lạc",     30, 15000, false)]
        [TestMethod()]
        public void InsertTest(string tenMonAn, int loaiMonAnId, float gia, bool expected) {

            using (var transaction = _appDbContext.Database.BeginTransaction()) {
                MonAn monAn = new MonAn{TenMon = tenMonAn, LoaiMonAnId = loaiMonAnId,
                                        Gia = Convert.ToDecimal(gia), IsAvailable = 1};

                MonAn monAnInserted = _monAnLogicForTest.Insert(monAn);
                Assert.AreEqual(expected, monAnInserted.Id != null);

                if (loaiMonAnId == 30) {
                    transaction.Rollback();
                }
            }
        }

        [DataRow("", ValidateStatus.NullError)]
        [DataRow(null, ValidateStatus.NullError)]
        [DataRow("Cua Hoang De", ValidateStatus.Ok)]
        [DataRow("ca", ValidateStatus.TenKhongDu2KiTu)]
        [DataRow("Ten mon an co chieu dai nhieu hon 50 ki tu " +
                 "Ten mon an co chieu dai nhieu hon 50 ki tu", ValidateStatus.TenVuotQua50KiTu)]
        [TestMethod()]
        public void ValidateTenTest(string tenMonAn, ValidateStatus expected) {
            Assert.AreEqual(expected, _monAnLogicForTest.ValidateTen(tenMonAn));
        }

        // có chín loại món ăn, kiểm tra các loại món ăn mặc định
        [DataRow(1, ValidateStatus.Ok)]
        [DataRow(5, ValidateStatus.Ok)]
        [DataRow(9, ValidateStatus.Ok)]
        [DataRow(30, ValidateStatus.LoaiMonAnNotFound)]
        [TestMethod()]
        public void ValidateLoaiMonAnTest(int loaiMonAnId, ValidateStatus expected) {
            Assert.AreEqual(expected, _monAnLogicForTest.ValidateLoaiMonAn(loaiMonAnId));
        }


        // kiểm tra đầu vào giá tiền
        [DataRow("", ValidateStatus.NullError)]
        [DataRow("12000d", ValidateStatus.DinhDangError)]
        [DataRow("145000", ValidateStatus.Ok)]
        [DataRow("0.9", ValidateStatus.GiaNhoHonMotError)]
        [TestMethod()]
        public void ValidateGiaTest(string gia, ValidateStatus expected) {
            Assert.AreEqual(expected, _monAnLogicForTest.ValidateGia(gia));
        }

        [DataRow("", 0, 1, false)]
        [DataRow("pizzA", 1, 5, true)]
        [DataRow("pizza", 1, 9, false)]
        [DataRow("n", 1, 3, true)]
        [TestMethod()]
        public void TimKiemTest(string keySearch, int trangThai, int loaiMonAnId, bool expected) {

            //Tìm kiếm 
            IEnumerable<MonAn> monAns = _monAnLogicForTest.TimKiem(keySearch, trangThai, loaiMonAnId);

            // Nếu tồn tại những món ăn khác trangthai, loaiMonAnId đầu vào thì sai (false)
            Assert.AreEqual(expected, monAns.Any(monAn => monAn.IsAvailable != trangThai
                                                    || monAn.LoaiMonAnId != loaiMonAnId
                                                    || !keySearch.Split(' ')
                                                        .Any(key => monAn.TenMon.Contains(key))));
        }
    }
}