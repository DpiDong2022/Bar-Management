using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {

    public class TrangThaiTonKhoLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<TrangThaiTonKho> _repo;

        public TrangThaiTonKhoLogic() {
            _context = Singleton.AppDbContext;
            _repo = new GenericRepository<TrangThaiTonKho>();
        }

        public bool Delete(TrangThaiTonKho obj) {
            var existedObj = _context.Set<TrangThaiTonKho>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedObj != null) {
                _context.Entry(existedObj).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Delete(obj);
        }

        public IEnumerable<TrangThaiTonKho> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(TrangThaiTonKho obj) {
            obj.Id = null;
            return _repo.Insert(obj);
        }

        public bool Update(TrangThaiTonKho obj) {
            var existedObj = _context.Set<TrangThaiTonKho>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedObj != null) {
                _context.Entry(existedObj).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Update(obj);
        }
    }
}
