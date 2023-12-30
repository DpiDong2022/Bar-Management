using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {

    public class DatBanTruocLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<DatBanTruoc> _repo;

        public DatBanTruocLogic() {

            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<DatBanTruoc>();
        }

        public bool Delete(DatBanTruoc obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<DatBanTruoc> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(DatBanTruoc obj) {
            return _repo.Insert(obj);
        }

        public bool Update(DatBanTruoc obj) {
            return _repo.Update(obj);
        }
    }
}
