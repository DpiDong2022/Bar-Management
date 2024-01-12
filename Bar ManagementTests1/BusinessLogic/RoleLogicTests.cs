using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bar_Management.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bar_Management.Models;
using Bar_Management.DAO;
using Bar_ManagementTests1;

namespace Bar_Management.BusinessLogic.Tests {
    [TestClass()]
    public class RoleLogicTests {
        private RoleLogic _roleLogic;
        public RoleLogicTests() {
            _roleLogic = new RoleLogic(TesetSetup.MockRoles.Object);
        }

        [DataRow("Admin", true)]
        [DataRow("Nhân viên kho", true)]
        [DataRow("Nhân viên bàn", true)]
        [DataRow("Nhân bếp", false)]
        [DataRow("Nhân viên giặt là", false)]
        [TestMethod()]
        public void RoleLogicTest(string roleName, bool expected) {

            Role[] danhSachTenPhanQuyen = _roleLogic.GetAll().ToArray();
            Assert.AreEqual(expected, danhSachTenPhanQuyen.Any(role => role.Ten == roleName));
        }

        [TestMethod()]
        public void CountTest() {
            // phần mềm có 3 bản ghi mặc định phân quyền trong bảng role 
            int expected = 3;
            //Assert.AreEqual(expected, roleLogic.Count());
            Assert.AreEqual(expected, _roleLogic.Count());
        }
    }
}