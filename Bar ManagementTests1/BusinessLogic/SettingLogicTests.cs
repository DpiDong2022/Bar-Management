using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bar_Management.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using Bar_ManagementTests1;

namespace Bar_Management.BusinessLogic.Tests {
    [TestClass()]
    public class SettingLogicTests {
        private readonly SettingLogic _settingLogic;

        public SettingLogicTests() {
            TestSetup.InitializeMockDbContext();
            _settingLogic = new SettingLogic(TestSetup.MockSettings.Object);
            ;
        }

        [DataRow("Tiếng Anh",true)]
        [DataRow("Tiếng Việt", true)]
        [TestMethod()]
        public void GetAllTest(string language, bool expected) {
            // Kiểm tra phần mềm có hai setting có thuộc tính ngôn ngữ là Tiếng Anh và Tiếng Việt
            Assert.AreEqual(expected, _settingLogic.GetAll().Any(setting => setting.NgonNgu == language));
        }
    }
}