using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {

    public class NhanVienLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<NhanVien> _repo;

        public NhanVienLogic() {

            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<NhanVien>();
        }

        public bool Delete(NhanVien obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<NhanVien> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(NhanVien obj) {
            return _repo.Insert(obj);
        }

        public bool Update(NhanVien obj) {
            return _repo.Update(obj);
        }
    }
}
