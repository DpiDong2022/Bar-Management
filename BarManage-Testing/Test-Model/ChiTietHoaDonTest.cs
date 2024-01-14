using Bar_Management.BusinessLogic;
using Bar_Management.DAO;
using Bar_Management.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BarManage_Testing.Test_Model
{
    [TestClass]
    public class ChiTietHoaDonTest
    {
        private readonly AppDbContext _appDbContext;
        private readonly ChiTietLogic _logicChiTiet;
        public ChiTietHoaDonTest()
        {
            _appDbContext = new AppDbContext();
            _logicChiTiet = new ChiTietLogic(_appDbContext);
        }
        [DataRow(11)] // xóa bằng id của object đã tồn tại trong database
        [DataRow(19)]
        [DataRow(23)]
        [TestMethod()]
        public void DeleteTest(int ChiTietId)
        {
            // sử dụng transaction để sau khi test có thể khiến dữ liệu trở lại ban đầu tránh
            // ảnh hưởng đến giữ liệu hiện có
            using (var transaction = _appDbContext.Database.BeginTransaction())
            {
                // tạo object role với key id cần xóa
                ChiTietHoaDon chiTiet = new ChiTietHoaDon() { Id = ChiTietId };
                //đếm số bản ghi trước khi xóa
                int startCount = _appDbContext.ChiTietHoaDons.Count();
                // xóa object khỏi dataset
                _appDbContext.Remove(chiTiet);
                // xóa object trong database
                _appDbContext.SaveChanges();
                // đếm số bản ghi sau khi xóa
                int endCount = _appDbContext.Roles.Count();
                // nếu số lượng chênh lệch của bản ghi là 1 => true
                Assert.AreEqual(startCount - endCount, 1);

                // rollback dữ liệu đã bị xóa khi test xong data row cuối cùng
                if (ChiTietId == 27)
                {
                    transaction.Rollback();
                }

            }
        }



        [DataRow(8,5,true)] 
        [DataRow(14,6,false)]
        [DataRow(21,10,true)]
        [TestMethod()]
        public void GetAllTest(int HoaDonId, int SoLuonChiTietExpect, bool expect)
        {
            // Kiểm tra số lượng chi tiết  trong các hóa đơn mặc định
            int SoLuongChiTiet = _logicChiTiet.GetAll(HoaDonId).Count();
            bool isOkExpected = SoLuongChiTiet == SoLuonChiTietExpect;
            Assert.AreEqual(isOkExpected, expect);
        }

        
        [TestMethod()]
        public void NotNullTest()
        {
            // kiểm tra số lượng bản ghi mặc định của phân quyền phải lớn hơn 0
            Assert.IsTrue(_appDbContext.ChiTietHoaDons.Count() > 0);
        }


        [DataRow(1, 5,50000, true)]
        [DataRow(5, 6,120000, true)]
        [DataRow(8, 10,250000, true)]
        [TestMethod()]
        public void TinhThanhTienTest(int MonAnId, int SoLuong ,decimal ThanhTienExpect, bool expect)
        {
            decimal ThanhTien = _logicChiTiet.TinhThanhTien(MonAnId, SoLuong);
            bool isOk = ThanhTien == ThanhTienExpect;
            Assert.AreEqual(expect, isOk);
        }


        [DataRow(1, 1, 2, 2,3,3, true)]
        [DataRow(2, 2, 3, 3,4,5, false)]
        [DataRow(3, 3, 4, 4,5,5, true)]
        [TestMethod()]
        public void InsertTest(int HoaDonId, int HoaDonIdExpect, int MonanId, int MonAnIdExpect, int SoLuong, int SoLuongExpect,decimal ThanhTienExpect, bool isOkExpected)
        {
            using (var transaction = _appDbContext.Database.BeginTransaction())
            {
                // tạo object mới 
                ChiTietHoaDon chiTiet = new ChiTietHoaDon()
                {
                    HoaDonId = HoaDonId,
                    MonAnId = MonanId,
                    SoLuong = SoLuong,
                    ThanhTien = _logicChiTiet.TinhThanhTien(MonanId, SoLuong)
                };
                // thêm object mới
                _appDbContext.ChiTietHoaDons.Add(chiTiet);
                // lưu object vào database
                _appDbContext.SaveChanges();
                var newChiTiet = _appDbContext.ChiTietHoaDons.ToList().Last();
                bool isOk = newChiTiet.HoaDonId == HoaDonIdExpect
                            && newChiTiet.MonAnId == MonAnIdExpect
                            && newChiTiet.SoLuong == SoLuongExpect
                            && newChiTiet.ThanhTien == ThanhTienExpect;
                Assert.AreEqual(isOkExpected, isOk);
                transaction.Rollback();
            }
        }
    }
}
