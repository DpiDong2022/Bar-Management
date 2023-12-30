using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {

    public class TaiKhoanLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<TaiKhoan> _repo;

        public TaiKhoanLogic() {

            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<TaiKhoan>();
        }

        public bool Delete(TaiKhoan obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<TaiKhoan> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(TaiKhoan obj) {
            return _repo.Insert(obj);
        }

        public bool Update(TaiKhoan obj) {
            return _repo.Update(obj);
        }
    }
}
