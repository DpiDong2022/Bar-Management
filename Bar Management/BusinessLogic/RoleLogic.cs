using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {

    internal class RoleLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<Role> _repo;

        public RoleLogic() {

            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<Role>();
        }

        public bool Delete(Role obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<Role> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(Role obj) {
            return _repo.Insert(obj);
        }

        public bool Update(Role obj) {
            return _repo.Update(obj);
        }
    }
}
