using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Bar_Management.DAO {
    public interface IRepository<T> where T : class {
        IEnumerable<T> GetAll();
        T Insert(T obj);
        T Delete(T ob0j);
        T Update(T ob0j);
    }

    public class RepocitoryTest<T>: IRepository<T> where T : class {
        public AppDbContext AppContext;
        public RepocitoryTest(AppDbContext appDbContext) {
            AppContext = appDbContext;
        }
        public RepocitoryTest() {
            AppContext = new AppDbContext();
        }
        public T Delete(T obj) {
            AppContext.Set<T>().Remove(obj);
            AppContext.SaveChanges();
            return obj;
            //_appDbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll() {
            return AppContext.Set<T>();
        }

        public T Insert(T obj) {
            AppContext.Set<T>().Add(obj);
            AppContext.SaveChanges();
            return obj;
        }

        public T GetById(T obj) {
            AppContext.Set<T>().Add(obj);
            AppContext.SaveChanges();
            return obj;
        }

        public T Update(T ob0j) {
            throw new NotImplementedException();
        }
    }
}
