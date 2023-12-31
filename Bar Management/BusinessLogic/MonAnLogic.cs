using AutoMapper;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Models;
using Bar_Management.Tool;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {
    public class MonAnLogic {

        public readonly AppDbContext Context;
        private readonly GenericRepository<MonAn> _repo;
        private readonly IMapper _mapper;

        public MonAnLogic() {
            _mapper = AutoMapperProfile.InitializeAutoMapper();
            Context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<MonAn>();
        }

        public bool Delete(MonAn obj) {
            var existedMonan = this.Context.Set<MonAn>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedMonan != null) {
                this.Context.Entry(existedMonan).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Delete(obj);
        }

        public IEnumerable<MonAn> GetAll() {
            return _repo.GetAll();
        }

        public bool Insert(MonAn obj) {
            return _repo.Insert(obj);
        }

        public bool Update(MonAn obj) {
            var existedMonan = this.Context.Set<MonAn>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedMonan != null) {
                this.Context.Entry(existedMonan).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Update(obj);
        }

        public List<MonAnDto> TimKiem(string searchKey) {
            if (string.IsNullOrEmpty(searchKey)) {
                return GetAll().Select(monAn => _mapper.Map<MonAnDto>(monAn)).ToList();
            }
            searchKey = searchKey.ToLower();
            string[] keys = searchKey.Split(' ');
            IEnumerable<LoaiMonAn> loaimonAns = new GenericRepository<LoaiMonAn>().GetAll();
            return GetAll().Where(monAn => keys.Any(
                key => monAn.TenMon.ToLower().Contains(key)
                || monAn.MoTa.ToLower().ToLower().Contains(key)))
                .Select(monAn => _mapper.Map<MonAnDto>(monAn)).ToList();
        }
    }
}
