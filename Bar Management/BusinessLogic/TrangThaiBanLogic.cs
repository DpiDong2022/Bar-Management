using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {

    public class TrangThaiBanLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<TrangThaiBan> _repo;

        public TrangThaiBanLogic() {

            _context = Singleton.AppDbContext;
            _repo = new GenericRepository<TrangThaiBan>();
        }

        public bool Delete(TrangThaiBan obj) {
            var existedMonan = _context.Set<TrangThaiBan>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedMonan != null) {
                _context.Entry(existedMonan).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Delete(obj);
        }

        public IEnumerable<TrangThaiBan> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(TrangThaiBan obj) {
            obj.Id = null;
            return _repo.Insert(obj);
        }

        public bool Update(TrangThaiBan obj) {
            var existedMonan = _context.Set<TrangThaiBan>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedMonan != null) {
                _context.Entry(existedMonan).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Update(obj);
        }
    }
}
