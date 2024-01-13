using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bar_Management.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic.Tests {
    [TestClass()]
    public class NhanVienLogicTests {
        private NhanVienLogic _logic;
        [TestMethod()]
        public void DeleteTest() {
            _logic = new NhanVienLogic();

            Assert.AreEqual(7, _logic.GetAll().Count());
        }
    }
}