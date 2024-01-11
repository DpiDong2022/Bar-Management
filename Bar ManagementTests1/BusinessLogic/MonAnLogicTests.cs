using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bar_Management.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using Bar_Management.Models;
using Moq;
using Bar_Management.DAO;

namespace Bar_Management.BusinessLogic.Tests {
    [TestClass()]
    public class MonAnLogicTests {
        private readonly MonAnLogic _monAnLogic;
        private Mock<ISet<MonAn>> _mockSet;
        private Mock<AppDbContext> _mockContext;
        public MonAnLogicTests() {
            _mockSet = new Mock<ISet<MonAn>>();
            _mockContext = new Mock<AppDbContext>();
            _mockContext.Setup(c => c.MonAns).Returns((Microsoft.EntityFrameworkCore.DbSet<MonAn>)_mockSet.Object);

            _monAnLogic = new MonAnLogic(_mockContext.Object);
        }

        [TestMethod()]
        public void MonAnLogicTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void MonAnLogicTest1() {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertTest() {
            var monAnMoi = new MonAn { TenMon = "test 1", Gia= 1000, IsAvailable = 1, LoaiMonAnId =1 , IsDelete = false};

            _monAnLogic.Insert(monAnMoi);

            // Assert
            try {

            } catch (Exception) {

                throw;
            }
            _mockSet.Verify(m => m.Add(It.IsAny<MonAn>()), Times.Once());
            _mockContext.Verify(m => m.SaveChanges(), Times.Once());

            var dd = _monAnLogic.GetAll();
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

        [TestMethod()]
        public void MonAnLogicTest2() {
            Assert.Fail();
        }

        [TestMethod()]
        public void MonAnLogicTest3() {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest1() {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTest1() {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertTest1() {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest1() {
            Assert.Fail();
        }

        [TestMethod()]
        public void TimKiemTest1() {
            Assert.Fail();
        }

        [TestMethod()]
        public void ExportToExcelTest1() {
            Assert.Fail();
        }
    }
}