using Bar_Management.DAO;
using Bar_Management.Models;
using System.Collections.Generic;

namespace Bar_Management.BusinessLogic {

    public class RoleLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<Role> _repo;

        public RoleLogic() {

            _context = Singleton.AppDbContext;
            _repo = new GenericRepository<Role>();
        }

        public RoleLogic(AppDbContext context) {
            _context = context;
            _repo = new GenericRepository<Role>();

        }

        public bool Delete(Role obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<Role> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(Role obj) {
            obj.Id = null;
            return _repo.Insert(obj);
        }

        public bool Update(Role obj) {
            return _repo.Update(obj);
        }

        public int Count() {
            return _repo.Count();
        }
    }
}
