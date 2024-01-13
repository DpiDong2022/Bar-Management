using AutoMapper;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Models;
using Bar_Management.RevenueForm;
using Bar_Management.Tool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bar_Management.BusinessLogic {
    public class HoaDonLogic {

        private readonly AppDbContext _context;
        private readonly GenericRepository<HoaDon> _repo;
        private readonly GenericRepository<Ban> _repoBan;
        private readonly GenericRepository<TaiKhoan> _repoTaiKhoan;
        private readonly IMapper _mapper;

        public HoaDonLogic() {

            _mapper = AutoMapperProfile.InitializeAutoMapper();
            _context = Singleton.AppDbContext;
            _repo = new GenericRepository<HoaDon>();
            _repoTaiKhoan = new GenericRepository<TaiKhoan>();
            _repoBan = new GenericRepository<Ban>();
        }

        public bool Delete(HoaDon obj) {
            var existedMonan = _context.Set<HoaDon>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedMonan != null) {
                _context.Entry(existedMonan).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Delete(obj);
        }

        public IEnumerable<HoaDon> GetAll() {
            var taiKhoans = _repoTaiKhoan.GetAll();
            var bans = _repoBan.GetAll();
            var dd =_repo.GetAll().Select(hoaDon => new HoaDon() {
                Id = hoaDon.Id,
                BanId = hoaDon.BanId,
                TrangThai = hoaDon.TrangThai,
                NgayTao = hoaDon.NgayTao,
                TaiKhoanTaoId = hoaDon.TaiKhoanTaoId,
                TongGia = hoaDon.TongGia,
                TaiKhoanTao = taiKhoans.FirstOrDefault(tk => tk.Id == hoaDon.Id),
                //Ban = bans.FirstOrDefault(ban => ban.Id == hoaDon.BanId)
            });
            return dd;
        }

        public IEnumerable<BillMonth> LayDuLieuThongKeThang(int nam, int thangThu) {
            var bills = _repo.GetAll()
                .Where(hd => hd.NgayTao.Year == nam
                        && hd.NgayTao.Month == thangThu)
                .OrderBy(hd => hd.NgayTao);

            IEnumerable<int> days = Enumerable.Range(1,30);

            var groupBillMonth = days.GroupJoin(bills, day=>day, bill => bill.NgayTao.Day, (day, billGroup)=>new {
                Month = day,
                Revenue = billGroup.Sum(bill => bill?.TongGia ?? 0)
            }).Select(c => new BillMonth(){
                Month = c.Month,
                Revenue = c.Revenue
            });
            return groupBillMonth;
        }

        public IEnumerable<BillDay> LayDuLieuThongKeTuan(DateTime date) {
            var bills = _repo.GetAll()
                .Where(hd => hd.NgayTao > date 
                    && hd.NgayTao < date.AddDays(7))
                .OrderBy(hd => hd.NgayTao);

            IEnumerable<string> daysOfWeek = Enum.GetNames(typeof(DayOfWeek)).AsEnumerable();


            var groupBillWeak = daysOfWeek.GroupJoin(bills, day => day, bill => bill.NgayTao.DayOfWeek.ToString(), (day, billGroup)=> new {
                Day = day,
                Revenue = billGroup.Sum(bill => bill?.TongGia ?? 0)
            }).Select(c => new BillDay(){
                Day = c.Day,
                Revenue = c.Revenue
            });
            return groupBillWeak;
        }

        public IEnumerable<HoaDonDto> GetAllDto() {
            var dd = GetAll().Select(hoadon => _mapper.Map<HoaDonDto>(hoadon));
            return dd;
        }

        public IEnumerable<HoaDonDto> LocHoaDon(int banId=-1, int taiKhoanId=-1, DateTime? dateTimeStart=null, DateTime? dateTimeEnd=null) {
            var hoadons = GetAll();

            if (banId != -1) {
                hoadons = hoadons.Where(c => c.BanId== banId);
            }

            if (taiKhoanId != -1) {
                hoadons = hoadons.Where(c => c.TaiKhoanTaoId == taiKhoanId);
            }

            if (dateTimeStart == null) {
                var startDate = new DateTime(2024,1,1);
                hoadons = hoadons.Where(hd => hd.NgayTao >= startDate);
            } else {
                hoadons = hoadons.Where(hd => hd.NgayTao >= dateTimeStart);
            }

            if (dateTimeEnd == null) {
                var endDate = new DateTime(3000,1,1);
                hoadons = hoadons.Where(hd => hd.NgayTao <= endDate);
            } else {
                hoadons = hoadons.Where(hd => hd.NgayTao <= dateTimeEnd);
            }

            return hoadons.Select(hd => _mapper.Map<HoaDonDto>(hd));
        }


        public bool Insert(HoaDon obj) {
            obj.Id = null;
            return _repo.Insert(obj);
        }

        public bool Update(HoaDon obj) {
            var existedMonan = this._context.Set<HoaDon>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedMonan != null) {
                this._context.Entry(existedMonan).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Update(obj);
        }
    }
}
