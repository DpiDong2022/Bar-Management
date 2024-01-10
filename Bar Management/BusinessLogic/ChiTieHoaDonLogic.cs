using AutoMapper;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Models;
using Bar_Management.Tool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {
    public class ChiTieHoaDonLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<ChiTietHoaDon> _repo;
        private readonly GenericRepository<MonAn> _repoMonAn;
        private readonly GenericRepository<HoaDon> _repoHoaDon;
        private readonly IMapper _mapper;

        public ChiTieHoaDonLogic() {

            _mapper = AutoMapperProfile.InitializeAutoMapper();
            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<ChiTietHoaDon>();
            _repoHoaDon = new GenericRepository<HoaDon> { };
            _repoMonAn = new GenericRepository<MonAn> { };
        }

        public bool Delete(ChiTietHoaDon obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<ChiTietHoaDon> GetAll() {
            var monAns = _repoMonAn.GetAll();
            var hoaDons = _repoHoaDon.GetAll();
            return _repo.GetAll().Select(chitiet => new ChiTietHoaDon() {
                Id = chitiet.Id,
                HoaDonId = chitiet.HoaDonId,
                ThanhTien = chitiet.ThanhTien,
                MonAnId = chitiet.MonAnId,
                SoLuong = chitiet.SoLuong,
                MonAn = monAns.FirstOrDefault(c => c.Id == chitiet.MonAnId),
                HoaDon = hoaDons.FirstOrDefault(c => c.Id == chitiet.HoaDonId)
            });
        }

        public IEnumerable<ChiTietHoaDonDto> GetAllDto() {
            return _repo.GetAll().Select(chitiet => _mapper.Map<ChiTietHoaDonDto>(chitiet));
        }

        public IEnumerable<ChiTietHoaDon> GetByHoaDonId(int id) {
            var monAns = _repoMonAn.GetAll();
            var hoaDons = _repoHoaDon.GetAll();
            var result = _repo.GetAll()
                .Where(chitiet => chitiet.HoaDonId == id)
                .Select(chitiet => new ChiTietHoaDon() {
                    Id = chitiet.Id,
                    HoaDonId = chitiet.HoaDonId,
                    ThanhTien = chitiet.ThanhTien,
                    MonAnId = chitiet.MonAnId,
                    SoLuong = chitiet.SoLuong,
                    MonAn = monAns.FirstOrDefault(c => c.Id == chitiet.MonAnId),
                    HoaDon = hoaDons.FirstOrDefault(c => c.Id == chitiet.HoaDonId)
                });
            return result;
        }

        public bool Insert(ChiTietHoaDon obj) {
            return _repo.Insert(obj);
        }

        public bool Update(ChiTietHoaDon obj) {
            return _repo.Update(obj);
        }
    }
}
