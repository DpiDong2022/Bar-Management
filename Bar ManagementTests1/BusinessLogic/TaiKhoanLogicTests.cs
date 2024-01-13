using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bar_Management.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bar_ManagementTests1;

namespace Bar_Management.BusinessLogic.Tests {
    [TestClass()]
    public class TaiKhoanLogicTests {
        private readonly TaiKhoanLogic _logic;
        // ctrl + .

        public TaiKhoanLogicTests() {
            TestSetup.InitializeMockDbContext();
            _logic = new TaiKhoanLogic(TestSetup.MockTaiKhoans.Object);
        }

        [TestMethod()]
        public void TaiKhoanLogicTest() {
            Assert.Fail();
        }

        [DataRow(1, true)]
        [DataRow(3, true)]
        [DataRow(5, true)]
        [TestMethod()]
        public void DeleteTest(int id, bool expected) {
            Assert.AreEqual(expected, _logic.Delete(new Models.TaiKhoan() { Id = id }));
        }
       
        [TestMethod()]
        public void GetAllTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void TimKiemTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void ExportToExcelTest() {
            Assert.Fail();
        }
    }
}