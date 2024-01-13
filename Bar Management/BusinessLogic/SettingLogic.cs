using Bar_Management.DAO;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {

    public class SettingLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<Setting> _repo;

        public SettingLogic() {

            _context = Singleton.AppDbContext;
            _repo = new GenericRepository<Setting>();
        }
        public SettingLogic(AppDbContext appDbContext) {

            _context = appDbContext;
            _repo = new GenericRepository<Setting>();
        }

        public bool Delete(Setting obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<Setting> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(Setting obj) {
            obj.Id = null;
            return _repo.Insert(obj);
        }

        public bool Update(Setting obj) {
            return _repo.Update(obj);
        }

    }
}
