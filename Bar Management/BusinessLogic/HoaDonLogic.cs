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
    public class HoaDonLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<HoaDon> _repo;
        private readonly GenericRepository<Ban> _repoBan;
        private readonly GenericRepository<TaiKhoan> _repoTaiKhoan;
        private readonly IMapper _mapper;

        public HoaDonLogic() {

            _mapper = AutoMapperProfile.InitializeAutoMapper();
            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<HoaDon>();
            _repoTaiKhoan = new GenericRepository<TaiKhoan>();
            _repoBan = new GenericRepository<Ban>();
        }

        public bool Delete(HoaDon obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<HoaDon> GetAll() {
            var taiKhoans = _repoTaiKhoan.GetAll();
            var bans = _repoBan.GetAll();
            var result = _repo.GetAll().Select(hoaDon => new HoaDon() {
                Id = hoaDon.Id,
                BanId = hoaDon.BanId,
                TrangThai = hoaDon.TrangThai,
                NgayTao = hoaDon.NgayTao,
                TaiKhoanTaoId = hoaDon.TaiKhoanTaoId,
                TongGia = hoaDon.TongGia,
                TaiKhoanTao = taiKhoans.First(tk => tk.Id == hoaDon.TaiKhoanTaoId),
                Ban = bans.First(ban => ban.Id == hoaDon.BanId)
            });
            return result;
        }

        public IEnumerable<HoaDonDto> GetAllDto() {
            return GetAll().Select(hoadon => _mapper.Map<HoaDonDto>(hoadon));
        }

        public IEnumerable<HoaDonDto> LocHoaDon(int banId=-1, int taiKhoanId=-1, DateTime? dateTimeStart=null, DateTime? dateTimeEnd=null) {
            var hoadons = GetAll();

            if (banId != -1) {
                hoadons = hoadons.Where(c => c.BanId== banId);
            }

            if (taiKhoanId != -1) {
                hoadons = hoadons.Where(c => c.TaiKhoanTaoId == taiKhoanId);
            }

            if (dateTimeStart == null) {
                var startDate = new DateTime(2024,1,1);
                hoadons = hoadons.Where(hd => hd.NgayTao >= startDate);
            } else {
                hoadons = hoadons.Where(hd => hd.NgayTao >= dateTimeStart);
            }

            if (dateTimeEnd == null) {
                var endDate = new DateTime(3000,1,1);
                hoadons = hoadons.Where(hd => hd.NgayTao <= endDate);
            } else {
                hoadons = hoadons.Where(hd => hd.NgayTao <= dateTimeEnd);
            }

            return hoadons.Select(hd => _mapper.Map<HoaDonDto>(hd));
        }

        public bool Insert(HoaDon obj) {
            return _repo.Insert(obj);
        }

        public bool Update(HoaDon obj) {
            return _repo.Update(obj);
        }
    }
}
