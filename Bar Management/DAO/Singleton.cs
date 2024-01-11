using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DAO {
    public static class Singleton {
        private static AppDbContext _instance;
        private static int _taiKhoanId;
        private static int _banId;

        public static AppDbContext Instance {
            get {
                if (_instance == null) {
                    _instance = new AppDbContext();
                }
                return _instance;
            }
        }
        public static int TaiKhoanId 
        {
            get
            {
                return _taiKhoanId;
            }
            set
            {
                _taiKhoanId = value;
            }
        }
        public static int BanId
        {
            get
            {
                return _banId;
            }
            set
            {
                _banId = value;
            }
        }
    }
}
