using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {

    public class NhaCungCapLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<NhaCungCap> _repo;

        public NhaCungCapLogic() {

            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<NhaCungCap>();
        }

        public bool Delete(NhaCungCap obj) {
            var existedObj = _context.Set<NhaCungCap>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedObj != null) {
                _context.Entry(existedObj).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Delete(obj);
        }

        public IEnumerable<NhaCungCap> GetAll() {
            return _repo.GetAll().Where(c => !c.IsDelete);
        }

        public bool Insert(NhaCungCap obj) {
            return _repo.Insert(obj);
        }

        public bool Update(NhaCungCap obj) {
            var existedObj = _context.Set<NhaCungCap>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedObj != null) {
                _context.Entry(existedObj).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Update(obj);
        }
    }
}
