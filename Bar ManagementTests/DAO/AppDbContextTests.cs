using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bar_Management.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DAO.Tests {
    [TestClass()]
    public class AppDbContextTests {

        [DataRow("192.168.1.9")]
        [DataRow("172.20.10.2")]
        [DataRow(".DONG\\LAPTOP")]
        [TestMethod()]
        public void AppDbContextTest(string serverName) {
            AppDbContext appDbContext = new AppDbContext(serverName);

            Assert.IsTrue(appDbContext.Database.CanConnect());
        }
    }
}