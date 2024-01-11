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

            _context = Singleton.Instance;
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
            var existedMonan = this._context.Set<Ban>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedMonan != null)
            {
                this._context.Entry(existedMonan).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Update(obj);
        }
    }
}
