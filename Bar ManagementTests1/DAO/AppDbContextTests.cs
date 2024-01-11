using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bar_Management.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Bar_Management.DAO.Tests {
    [TestClass()]
    public class AppDbContextTests {
        [TestMethod()]
        public void AppDbContextTest() {
            AppDbContext context = new AppDbContext();
        }
    }
}