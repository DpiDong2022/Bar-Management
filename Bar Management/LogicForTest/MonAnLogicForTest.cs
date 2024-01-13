using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows.Forms;

namespace Bar_Management.LogicForTest {
    public interface Generic<T> {
        IEnumerable<T> GetAll();
        T Insert(T obj);
        T Update(T obj);
        T Delete(T obj);
        IEnumerable<T> TimKiem(string keySearch, int? TrangThai, int? LoaiMonAnId);
        ValidateStatus ValidateTen(string Ten);
        ValidateStatus ValidateLoaiMonAn(int LoaiMonAnId);
        ValidateStatus ValidateGia(string gia);
    }
    public enum ValidateStatus {
        Ok,
        TenVuotQua50KiTu,
        TenKhongDu2KiTu,
        LoaiMonAnNotFound,
        DinhDangError,
        NullError,
        GiaNhoHonMotError
    }
    public class MonAnLogicForTest:Generic<MonAn> {
        private AppDbContext _appDbContext;
        public MonAnLogicForTest() { 
            _appDbContext = new AppDbContext();
        }
        public MonAnLogicForTest(AppDbContext appDbContext) {
            _appDbContext = appDbContext;
        }

        public MonAn Delete(MonAn obj) {
            try {
                _appDbContext.MonAns.Remove(obj);
                _appDbContext.SaveChanges();
                return obj;
            } catch (Exception) {
                return obj;
            }
        }

        public IEnumerable<MonAn> GetAll() {
            return _appDbContext.MonAns.AsEnumerable();
        }

        public MonAn Insert(MonAn obj) {
            try {
                _appDbContext.MonAns.Add(obj);
                _appDbContext.SaveChanges();
                return obj;
            } catch (Exception) {
                return obj;
            }
        }

        public int Count() {
            return _appDbContext.MonAns.Count();
        }

        public MonAn Update(MonAn obj) {
            try {
                _appDbContext.Update(obj);
                _appDbContext.SaveChanges();
                return obj;
            } catch (Exception) {
                return obj;
            }
        }

        public ValidateStatus ValidateTen(string Ten) {
            if (string.IsNullOrEmpty(Ten)) {
                return ValidateStatus.NullError;
            }else if (Ten.Length > 50) {
                return ValidateStatus.TenVuotQua50KiTu;
            } else if(Ten.Length < 3){
                return ValidateStatus.TenKhongDu2KiTu;
            } else {
                return ValidateStatus.Ok;
            }
        }

        public ValidateStatus ValidateLoaiMonAn(int LoaiMonAnId) {
            LoaiMonAn loaiMonAn = _appDbContext.LoaiMonAns.ToList()
                .FirstOrDefault(c => c.Id == LoaiMonAnId);
            if (loaiMonAn == null) {
                return ValidateStatus.LoaiMonAnNotFound;
            } else {
                return ValidateStatus.Ok;
            }
        }

        public ValidateStatus ValidateGia(string gia) {

            if (string.IsNullOrEmpty(gia)) {
                return ValidateStatus.NullError;
            }else if (!decimal.TryParse(gia, out decimal decimalGia)) {
                return ValidateStatus.DinhDangError;
            }else if (decimalGia < 1) {
                return ValidateStatus.GiaNhoHonMotError;
            } else {
                return ValidateStatus.Ok;
            }
        }

        public IEnumerable<MonAn> TimKiem(string keySearch, int? TrangThai, int? LoaiMonAnId) {
            var result = _appDbContext.MonAns.ToList();
            if (TrangThai != -1) {
                result = result.Where(monan => monan.IsAvailable == TrangThai).ToList();
            }
            if (LoaiMonAnId != -1) {
                result = result.Where(monan => monan.LoaiMonAnId == LoaiMonAnId).ToList();
            }
            if (string.IsNullOrEmpty(keySearch)) {
                string[] keys = keySearch.Split(' ');
                result = result.Where(monAn => keys.Any(key => monAn.TenMon.Contains(key))).ToList();
            }
            return result;
        }
    }
}
