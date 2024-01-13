using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bar_Management.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bar_Management.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Drawing;

namespace Bar_Management.DAO.Tests {
    [TestClass()]
    public class RoleLogicTests {
        private AppDbContext _appDbContext;

        public RoleLogicTests() {
            _appDbContext = new AppDbContext();
        }

        [DataRow(17)] // xóa bằng id của object đã tồn tại trong database
        [DataRow(18)]
        [DataRow(22)]
        [TestMethod()]
        public void DeleteTest(int roleId) {
            // sử dụng transaction để sau khi test có thể khiến dữ liệu trở lại ban đầu tránh
            // ảnh hưởng đến giữ liệu hiện có
            using (var transaction = _appDbContext.Database.BeginTransaction()) {
                // tạo object role với key id cần xóa
                Role role = new Role(){Id = roleId};
               //đếm số bản ghi trước khi xóa
                int startCount = _appDbContext.Roles.Count();
                // xóa object khỏi dataset
                _appDbContext.Remove(role);
                // xóa object trong database
                _appDbContext.SaveChanges();
                // đếm số bản ghi sau khi xóa
                int endCount = _appDbContext.Roles.Count();
                // nếu số lượng chênh lệch của bản ghi là 1 => true
                Assert.AreEqual(startCount-endCount, 1);

                // rollback dữ liệu đã bị xóa khi test xong data row cuối cùng
                if (roleId == 22) {
                    transaction.Rollback();
                }
            }
        }
    
        [TestMethod()]
        public void GetAllTest() {
            Assert.IsTrue(_appDbContext.Roles.Count() > 0);
        }

        [TestMethod()]
        public void NotNullTest() {
            // kiểm tra số lượng bản ghi mặc định của phân quyền phải lớn hơn 0
            Assert.IsTrue(_appDbContext.Roles.Count() > 0);
        }


        [DataRow("Nhan Vien 1","Nhan Vien 1", true)]
        [DataRow("Nhan Vien 2","Nhan Vien 4", false)]
        [DataRow("Nhan Vien 3","Nhan Vien 3", true)]
        [TestMethod()]
        public void InsertTest(string ten, string tenExpected, bool isOkExpected) {
            using (var transaction = _appDbContext.Database.BeginTransaction()) {
                // tạo object mới 
                Role role = new Role(){Ten = ten};
                // thêm object mới
                _appDbContext.Add(role);
                // lưu object vào database
                _appDbContext.SaveChanges();
                bool isOk = _appDbContext.Roles.ToList().Last().Ten==tenExpected;
                Assert.AreEqual(isOkExpected, isOk);
                transaction.Rollback();
            }
        }
    }
}