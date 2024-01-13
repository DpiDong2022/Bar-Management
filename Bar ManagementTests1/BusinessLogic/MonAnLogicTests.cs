using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bar_Management.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bar_Management.DAO;
using Bar_Management.Models;
using System.Dynamic;
using Bar_ManagementTests1;

namespace Bar_Management.BusinessLogic.Tests {
    [TestClass()]
    public class MonAnLogicTests {
        private readonly MonAnLogic _monAnLogic;
        private readonly TestSetup _testSetup;

        public MonAnLogicTests() {
            _testSetup = new TestSetup();
            _monAnLogic = new MonAnLogic(_testSetup.MockMonAns.Object);
        }

        [TestMethod()]
        public void InsertTest() {
            Assert.Fail();
        }

        [DataRow(9, false)]
        [TestMethod()]
        public void DeleteTest(int monAnId, bool expected) {
            Assert.AreEqual(expected, _monAnLogic.Delete(new MonAn { Id= monAnId }));
        }
    }
}