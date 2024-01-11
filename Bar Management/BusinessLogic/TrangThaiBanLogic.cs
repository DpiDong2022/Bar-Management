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

            _context = Singleton.Instance;
            _repo = new GenericRepository<TrangThaiBan>();
        }

        public bool Delete(TrangThaiBan obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<TrangThaiBan> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(TrangThaiBan obj) {
            return _repo.Insert(obj);
        }

        public bool Update(TrangThaiBan obj) {
            return _repo.Update(obj);
        }
    }
}
