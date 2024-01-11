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

namespace Bar_Management.BusinessLogic
{
    public class HoaDonLogic
    {

        private readonly AppDbContext _context;
        private readonly GenericRepository<HoaDon> _repo;
        private readonly GenericRepository<Ban> _repoBan;
        private readonly GenericRepository<TaiKhoan> _repoTaiKhoan;
        private readonly IMapper _mapper;

        public HoaDonLogic()
        {

            _mapper = AutoMapperProfile.InitializeAutoMapper();
            _context = Singleton.Instance;
            _repo = new GenericRepository<HoaDon>();
            _repoTaiKhoan = new GenericRepository<TaiKhoan>();
            _repoBan = new GenericRepository<Ban>();
        }

        public bool Delete(HoaDon obj)
        {
            return _repo.Delete(obj);
        }

        public IEnumerable<HoaDon> GetAll()
        {
            var taiKhoans = _repoTaiKhoan.GetAll();
            var bans = _repoBan.GetAll();
            return _repo.GetAll().Select(hoaDon => new HoaDon()
            {
                Id = hoaDon.Id,
                BanId = hoaDon.BanId,
                TrangThai = hoaDon.TrangThai,
                NgayTao = hoaDon.NgayTao,
                TaiKhoanTaoId = hoaDon.TaiKhoanTaoId,
                TongGia = hoaDon.TongGia,
                TaiKhoanTao = taiKhoans.FirstOrDefault(tk => tk.Id == hoaDon.Id),
                Ban = bans.FirstOrDefault(ban => ban.Id == hoaDon.BanId)
            });
        }

        public IEnumerable<HoaDonDto> GetAllDto()
        {
            return _repo.GetAll().Select(hoadon => _mapper.Map<HoaDonDto>(hoadon));
        }

        public bool Insert(HoaDon obj)
        {
            return _repo.Insert(obj);
        }

        public bool Update(HoaDon obj)
        {
            return _repo.Update(obj);
        }
    }
}
