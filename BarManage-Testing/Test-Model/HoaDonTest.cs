using Bar_Management.DAO;
using Bar_Management.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace BarManage_Testing.Test_Model
{
    [TestClass]
    public class HoaDonTest
    {
        private AppDbContext _appDbContext;
        public HoaDonTest()
        {
            _appDbContext = new AppDbContext();
        }
        [DataRow(17)] // xóa bằng id của object đã tồn tại trong database
        [DataRow(18)]
        [DataRow(22)]
        [TestMethod()]
        public void DeleteTest(int HoaDonId)
        {
            // sử dụng transaction để sau khi test có thể khiến dữ liệu trở lại ban đầu tránh
            // ảnh hưởng đến giữ liệu hiện có
            using (var transaction = _appDbContext.Database.BeginTransaction())
            {
                //// tạo object role với key id cần xóa
                //Role role = new Role() { Id = roleId };
                ////đếm số bản ghi trước khi xóa
                //int startCount = _appDbContext.Roles.Count();
                //// xóa object khỏi dataset
                //_appDbContext.Remove(role);
                //// xóa object trong database
                //_appDbContext.SaveChanges();
                //// đếm số bản ghi sau khi xóa
                //int endCount = _appDbContext.Roles.Count();
                //// nếu số lượng chênh lệch của bản ghi là 1 => true
                //Assert.AreEqual(startCount - endCount, 1);

                //// rollback dữ liệu đã bị xóa khi test xong data row cuối cùng
                //if (roleId == 22)
                //{
                //    transaction.Rollback();
                //}
            }
        }
    }
}
