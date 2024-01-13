using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bar_Management.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic.Tests
{
    [TestClass()]
    public class SettingLogicTests
    {
        private SettingLogic _settingLogic;
        [TestMethod()]
        public void GetAllTest()
        {
            _settingLogic = new SettingLogic();

            Assert.AreEqual(2, _settingLogic.GetAll().Count());
        }
    }
}