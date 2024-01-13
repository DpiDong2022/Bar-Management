using Bar_Management.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DAO {

    public interface IGenericRepository<T> where T : class {
        IEnumerable<T> GetAll();
        bool Insert(T obj);
        bool Delete(T ob0j);
        bool Update(T ob0j);
    }

    internal class GenericRepository<T>: IGenericRepository<T> where T : class{
        private readonly DbSet<T> _set;
        private readonly AppDbContext _context;
        public GenericRepository() {
            _context = Singleton.AppDbContext;
            _set = _context.Set<T>();
        }

        public bool Delete(T obj) {
            try {
                _set.Remove(obj);
                _context.SaveChanges(); 
                return true;
            } catch (Exception) {

                throw;
            }
        }

        public int Count() {
            return _context.Set<T>().Count();
        }

        public IEnumerable<T> GetAll() {
            return _set.AsNoTracking().ToList();
        }

        public bool Insert(T obj) {
            try {
                _set.AddAsync(obj);
                _context.SaveChanges();
                return true;
            } catch (Exception) {

                throw;
            }
        }

        public bool Update(T obj) {
            try {
                _set.Update(obj);
                _context.SaveChanges();
                return true;
            } catch (Exception) {

                throw;
            }
        }
    }
}
