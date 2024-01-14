using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic
{
    public interface Generic<T>
    {
        IEnumerable<T> GetAll();
        T Insert(T obj);
        T Update(T obj);
        T Delete(T obj);
        IEnumerable<T> TimKiem(string keySearch);
        IEnumerable<T> LocDuLieu(int TrangThai, int LoaiMonAnId);
        T Validate();
    }
    public class ChiTietLogic : Generic<ChiTietHoaDon>
    {
        private AppDbContext _appDbContext;

        public ChiTietLogic(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public ChiTietHoaDon Delete(ChiTietHoaDon obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChiTietHoaDon> GetAll(int HoaDonId)
        {
            return _appDbContext.ChiTietHoaDons.Where(x => x.HoaDonId == HoaDonId);
        }

        public ChiTietHoaDon Insert(ChiTietHoaDon obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChiTietHoaDon> LocDuLieu(int TrangThai, int LoaiMonAnId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChiTietHoaDon> TimKiem(string keySearch)
        {
            throw new NotImplementedException();
        }

        public ChiTietHoaDon Update(ChiTietHoaDon obj)
        {
            throw new NotImplementedException();
        }

        public ChiTietHoaDon Validate()
        {
            throw new NotImplementedException();
        }
        public decimal TinhThanhTien(int MonAnId, int SoLuong)
        {
            decimal total = 0;

            var GiaMonAn = _appDbContext.MonAns.FirstOrDefault(x => x.Id == MonAnId).Gia;
            return total = SoLuong * GiaMonAn;
            
        }

        public IEnumerable<ChiTietHoaDon> GetAll()
        {
            throw new NotImplementedException();
        }
    }
    
    
}
