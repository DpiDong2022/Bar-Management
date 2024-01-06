using Bar_Management.BusinessLogic;
using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Tool {
    public class GenerateData {
        static List<TrangThaiTonKho> trangThaiTonKhos = new List<TrangThaiTonKho> (){
            new TrangThaiTonKho(){Ten = "Còn"},
            new TrangThaiTonKho(){Ten = "Hết"},
            new TrangThaiTonKho(){Ten = "Hết hạn"},
        };

        static List<NhaCungCap> nhaCungCaps = new List<NhaCungCap> (){
            new NhaCungCap(){Ten="Phùng Đại Đồng", DiaChi="Ba Vì Hà Nội", Email="phungdaidong1114@gmail.com", Sdt="0368728267"},
            new NhaCungCap(){Ten="Đỗ Quốc Tuấn", DiaChi="Hà Nam", Email="doquoctuan2021144@gmail.com", Sdt="0988876544"},
            new NhaCungCap(){Ten="Tạ Đặng Trung Kiên", DiaChi="Hà Nam", Email="tadangtrungkien33@gmail.com", Sdt="0999999999"}
        };

        static List<NguyenLieu> nguyenLieus = new List<NguyenLieu> (){
            new NguyenLieu(){Ten = "Rượu nếp", GiaBan=10000, HinhAnh="https://www.lottemart.vn/media/catalog/product/cache/0x0/8/9/8934591001240.png.webp"},
            new NguyenLieu(){Ten = "Khăn bàn", GiaBan=20000, HinhAnh="https://napkinvietnam.vn/wp-content/uploads/2022/01/khan-ban-mau-xam-300x300.jpg"},
            new NguyenLieu(){Ten = "Chổi lau nhà kenco", GiaBan=40000, HinhAnh="https://songlongplastic.net/wp-content/uploads/2022/10/z3664682953857_efddd5aa210078b45d7fb8d20b971372-scaled.jpg"},
            new NguyenLieu(){Ten = "Ghế nhựa", GiaBan=120000, HinhAnh="https://bangheduytan.com/wp-content/uploads/2021/03/ghe-lun-lo-do.jpg"},
        };

        static List<TonKho> tonKhos = new List<TonKho> (){
            new TonKho(){SoLuong = 2, DonVi = "Cái", NguyenLieuId = 1, NgayNhap = DateTime.Now, 
                NgayHetHan = new DateTime(2024,2,14), GiaNhap=10000, NhaCungCapId=1, TrangThaiId = 1},
            new TonKho(){SoLuong = 4, DonVi = "Tải", NguyenLieuId = 2, NgayNhap = DateTime.Now,
                NgayHetHan = new DateTime(2024,2,16), GiaNhap=20000, NhaCungCapId=1, TrangThaiId = 1},
            new TonKho(){SoLuong = 8, DonVi = "Hộp", NguyenLieuId = 2, NgayNhap = DateTime.Now,
                NgayHetHan = new DateTime(2024,12,14), GiaNhap=30000, NhaCungCapId=2, TrangThaiId = 1},
            new TonKho(){SoLuong = 16, DonVi = "Cái", NguyenLieuId = 3, NgayNhap = DateTime.Now,
                NgayHetHan = new DateTime(2024,4,14), GiaNhap=40000, NhaCungCapId=3, TrangThaiId = 1},
            new TonKho(){SoLuong = 20, DonVi = "Cái", NguyenLieuId = 4, NgayNhap = DateTime.Now,
                NgayHetHan = new DateTime(2025,12,10), GiaNhap=40000, NhaCungCapId=3, TrangThaiId = 1},
        };

        public static void Render() {
            ThemTrangThaiTonKho();
            ThemNhaCungCap();
            ThemNguyenLieu();
            ThemTonKho();
        }

        public static void ThemTrangThaiTonKho() {
            TrangThaiTonKhoLogic logic = new TrangThaiTonKhoLogic();
            if (logic.GetAll().Count() == 0) {
                foreach (var item in trangThaiTonKhos) {
                    logic.Insert(item);
                }
            }
        }

        public static void ThemNhaCungCap() {
            NhaCungCapLogic logic = new NhaCungCapLogic();
            if (logic.GetAll().Count() == 0) {
                foreach (var item in nhaCungCaps) {
                    logic.Insert(item);
                }
            }
        }

        public static void ThemNguyenLieu() {
            NguyenLieuLogic logic = new NguyenLieuLogic();
            if (logic.GetAll().Count() == 0) {
                foreach (var item in nguyenLieus) {
                    logic.Insert(item);
                }
            }
        }
        public static void ThemTonKho() {
            TonKhoLogic logic = new TonKhoLogic();
            if (logic.GetAll().Count() == 0) {
                foreach (var item in tonKhos) {
                    logic.Insert(item);
                }
            }
        }

    }
}
