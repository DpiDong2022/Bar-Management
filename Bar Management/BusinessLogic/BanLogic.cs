using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {

    public class BanLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<Ban> _repo;

        public BanLogic() {

            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<Ban>();
        }

        public bool Delete(Ban obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<Ban> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(Ban obj) {
            return _repo.Insert(obj);
        }

        public bool Update(Ban obj) {
            return _repo.Update(obj);
        }
    }
}
