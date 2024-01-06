using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {
    public class NguyenLieuLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<NguyenLieu> _repo;

        public NguyenLieuLogic() {

            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<NguyenLieu>();
        }

        public bool Delete(NguyenLieu obj) {
            var existedObj = _context.Set<NguyenLieu>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedObj != null) {
                _context.Entry(existedObj).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Delete(obj);
        }

        public IEnumerable<NguyenLieu> GetAll() {
            return _repo.GetAll().Where(c => !c.IsDelete);
        }

        public bool Insert(NguyenLieu obj) {
            return _repo.Insert(obj);
        }

        public bool Update(NguyenLieu obj) {
            var existedObj = _context.Set<NguyenLieu>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedObj != null) {
                _context.Entry(existedObj).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Update(obj);
        }
    }
}
