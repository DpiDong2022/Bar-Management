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
    public class TonKhoLogic {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly GenericRepository<TonKho> _repo;
        private readonly GenericRepository<NhaCungCap> _nhaCungCap;
        private readonly GenericRepository<NguyenLieu> _nguyenLieu;
        private readonly GenericRepository<TrangThaiTonKho> _tranThaiTonKho;

        public TonKhoLogic() {
            _mapper = AutoMapperProfile.InitializeAutoMapper();
            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<TonKho>();
            _nhaCungCap = new GenericRepository<NhaCungCap>();
            _nguyenLieu= new GenericRepository<NguyenLieu>();
            _tranThaiTonKho = new GenericRepository<TrangThaiTonKho>();
        }

        public bool Delete(TonKho obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<TonKhoDto> GetAll() {
            var nhaCungCaps = _nhaCungCap.GetAll();
            var nguyenLieus = _nguyenLieu.GetAll();
            var trangThais = _tranThaiTonKho.GetAll();

            return _repo.GetAll()
                        .Join(nguyenLieus, 
                        tonKho => tonKho.NguyenLieuId,
                        nguyenLieu => nguyenLieu.Id,
                        (tonkho, nguyenlieu)=>new TonKho(tonkho) {NguyenLieuId=nguyenlieu.Id, NguyenLieu = nguyenlieu})

                        .Join(nhaCungCaps,
                        tonKho => tonKho.NhaCungCapId,
                        nhaCungCap => nhaCungCap.Id,
                        (tonkho, nhaCc) => new TonKho(tonkho) { NhaCungCapId = nhaCc.Id, NhaCungCap = nhaCc })

                        .Join(trangThais,
                        tonKho => tonKho.TrangThaiId,
                        trangthai => trangthai.Id,
                        (tonkho, trangthai) => new TonKho(tonkho) { TrangThaiId = trangthai.Id, TrangThai = trangthai })

                        .Select(tk => _mapper.Map<TonKhoDto>(tk));
        }

        public bool Insert(TonKho obj) {
            return _repo.Insert(obj);
        }

        public bool Update(TonKho obj) {
            return _repo.Update(obj);
        }
    }
}
