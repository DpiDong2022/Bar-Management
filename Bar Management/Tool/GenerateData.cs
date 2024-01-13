using Bar_Management.BusinessLogic;
using Bar_Management.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Tool {
    public class GenerateData {
        public static List<TrangThaiTonKho> trangThaiTonKhos = new List<TrangThaiTonKho> (){
            new TrangThaiTonKho(){Id= 1,Ten = "Còn"},
            new TrangThaiTonKho(){Id= 2,Ten = "Hết"},
            new TrangThaiTonKho(){Id= 3,Ten = "Hết hạn"},
        };

        public static List<NhaCungCap> nhaCungCaps = new List<NhaCungCap> (){
            new NhaCungCap(){Id= 1,Ten="Phùng Đại Đồng", DiaChi="Ba Vì Hà Nội", Email="phungdaidong1114@gmail.com", Sdt="0368728267"},
            new NhaCungCap(){Id= 2,Ten="Đỗ Quốc Tuấn", DiaChi="Hà Nam", Email="doquoctuan2021144@gmail.com", Sdt="0988876544"},
            new NhaCungCap(){Id= 3,Ten="Tạ Đặng Trung Kiên", DiaChi="Hà Nam", Email="tadangtrungkien33@gmail.com", Sdt="0999999999"}
        };

        public static List<NguyenLieu> nguyenLieus = new List<NguyenLieu> (){
            new NguyenLieu(){Id= 1,Ten = "Rượu nếp", GiaBan=10000, HinhAnh="https://www.lottemart.vn/media/catalog/product/cache/0x0/8/9/8934591001240.png.webp"},
            new NguyenLieu(){Id= 2,Ten = "Khăn bàn", GiaBan=20000, HinhAnh="https://napkinvietnam.vn/wp-content/uploads/2022/01/khan-ban-mau-xam-300x300.jpg"},
            new NguyenLieu(){Id= 3,Ten = "Chổi lau nhà kenco", GiaBan=40000, HinhAnh="https://songlongplastic.net/wp-content/uploads/2022/10/z3664682953857_efddd5aa210078b45d7fb8d20b971372-scaled.jpg"},
            new NguyenLieu(){Id= 4,Ten = "Ghế nhựa", GiaBan=120000, HinhAnh="https://bangheduytan.com/wp-content/uploads/2021/03/ghe-lun-lo-do.jpg"},
        };

        public static List<TonKho> tonKhos = new List<TonKho> (){
            new TonKho(){Id= 1,SoLuong = 2, DonVi = "Cái", NguyenLieuId = 1, NgayNhap = DateTime.Now, 
                NgayHetHan = new DateTime(2024,2,14), GiaNhap=10000, NhaCungCapId=1, TrangThaiId = 1},
            new TonKho(){Id= 2,SoLuong = 4, DonVi = "Tải", NguyenLieuId = 2, NgayNhap = DateTime.Now,
                NgayHetHan = new DateTime(2024,2,16), GiaNhap=20000, NhaCungCapId=1, TrangThaiId = 1},
            new TonKho(){Id= 3,SoLuong = 8, DonVi = "Hộp", NguyenLieuId = 2, NgayNhap = DateTime.Now,
                NgayHetHan = new DateTime(2024,12,14), GiaNhap=30000, NhaCungCapId=2, TrangThaiId = 1},
            new TonKho(){Id= 4,SoLuong = 16, DonVi = "Cái", NguyenLieuId = 3, NgayNhap = DateTime.Now,
                NgayHetHan = new DateTime(2024,4,14), GiaNhap=40000, NhaCungCapId=3, TrangThaiId = 1},
            new TonKho(){Id= 5,SoLuong = 20, DonVi = "Cái", NguyenLieuId = 4, NgayNhap = DateTime.Now,
                NgayHetHan = new DateTime(2025,12,10), GiaNhap=40000, NhaCungCapId=3, TrangThaiId = 1},
        };

        public static List<LoaiMonAn> loaiMonAns = new List<LoaiMonAn> (){
            new LoaiMonAn(){Id= 1, TenLoai="Cocktail" },
            new LoaiMonAn(){Id= 2, TenLoai="Rượu" },
            new LoaiMonAn(){Id= 3, TenLoai="Rượu mạch" },
            new LoaiMonAn(){Id= 4, TenLoai="Nước ngọt" },
            new LoaiMonAn(){Id= 5, TenLoai="Đồ ăn nhẹ" },
            new LoaiMonAn(){Id= 6, TenLoai="Pizza" },
            new LoaiMonAn(){Id= 7, TenLoai="Món ngọt" },
            new LoaiMonAn(){Id= 8, TenLoai="Đồ ăn đặc biệt" }
        };

        public static List<MonAn> monAns = new List<MonAn> (){
            new MonAn(){Id= 1, TenMon="Margarita", MoTa="Một cocktail truyền thống của Mexico, Margarita thường được làm từ tequila, " +
                "triple sec và nước cốt chanh. Được phục vụ trên đá hoặc shaken với đá.", 
                IsAvailable=1, LoaiMonAnId=1, IsDelete=false, Gia=10000, 
                HinhAnh="https://www.liquor.com/thmb/JQgDGy26Zsw-_cFGKH4zNH9PlXk=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Frozen-Margarita-1500x1500-hero-191e49b3ab4f4781b93f3cfacac25136.jpg"},
            new MonAn(){Id= 2, TenMon="Mojito", MoTa="Một cocktail nguồn gốc từ Cuba, Mojito thường bao gồm rum, đường, nước cốt chanh, lá bạc hà, đá " +
                "và soda. Nó có hương vị tươi mát, ngọt ngào và có độ cay từ lá bạc hà.", 
                IsAvailable=1, LoaiMonAnId=1, IsDelete=false, Gia=15000, 
                HinhAnh="https://agratefulmeal.com/wp-content/uploads/2023/02/blue-mojito-curacao-cocktail-featured.jpg"},
            new MonAn(){Id= 3, TenMon="Cabernet Sauvignon", MoTa="Một loại nho đỏ nổi tiếng, Cabernet Sauvignon thường có hương thơm của quả mâm xôi, " +
                "mâm cảm và một chút cay. Nó tạo ra rượu đỏ đậm, hương vị đầy đặn và cấu trúc tannin mạnh mẽ.", 
                IsAvailable=1, LoaiMonAnId=2, IsDelete=false, Gia=30000, 
                HinhAnh="https://winecellar.vn/wp-content/uploads/2016/05/vistana-cabernet-sauvignon-merlot.jpg"},
            new MonAn(){Id= 4, TenMon="Chardonnay", MoTa="Rượu trắng phổ biến, Chardonnay thường có hương thơm của trái cây như táo và lê, có thể kết " +
                "hợp với hương vani hay nho trắng.", 
                IsAvailable=1, LoaiMonAnId=2, IsDelete=false, Gia=40000, 
                HinhAnh="https://winecellar.vn/wp-content/uploads/2017/07/chateau-de-meursault-bourgogne-chardonnay-1.jpg"},
            new MonAn(){Id= 5, TenMon="Irish Cream", MoTa="Một loại rượu mạch có nguồn gốc từ Ireland, Irish Cream kết hợp giữa whiskey, đường, kem và các " +
                "thành phần khác. Nó có hương vị ngọt ngào.", 
                IsAvailable=1, LoaiMonAnId=3, IsDelete=false, Gia=20000, 
                HinhAnh="https://www.imperialsugar.com/sites/default/files/recipe/Irish-cream-liqueur-imperial.jpg"},
            new MonAn(){Id= 6, TenMon="Baileys", MoTa="Một thương hiệu nổi tiếng của Irish Cream, Baileys thường có hương vị của kem sô cô la và vani, tạo " +
                "nên một hương vị ngon ngọt và thơm ngon.", 
                IsAvailable=1, LoaiMonAnId=3, IsDelete=false, Gia=23000, 
                HinhAnh="https://thewanderlustkitchen.com/wp-content/uploads/2022/12/Baileys-Chocoalte-Martini-Recipe-06-2.jpg"},
            new MonAn(){Id= 7, TenMon="Coca-Cola", MoTa="Một đồ uống có ga phổ biến trên toàn thế giới, Coca-Cola có hương vị ngọt ngào và cảm giác cà phê." +
                " Nó thường được phục vụ với đá.", 
                IsAvailable=1, LoaiMonAnId=4, IsDelete=false, Gia=25000, 
                HinhAnh="https://tea-3.lozi.vn/v1/ship/resized/losupply-quang-tri-thanh-pho-dong-ha-quang-tri-1648801646214781853-nuoc-ngot-coca-cola-lon-320ml-0-1658895994?w=480&type=o"},
            new MonAn(){Id= 8, TenMon="Sprite", MoTa="Một loại nước ngọt không có caffeine, Sprite có hương vị chanh mát, tươi mới và thường được ưa chuộng " +
                "như một đồ uống giải khát.", 
                IsAvailable=1, LoaiMonAnId=4, IsDelete=false, Gia=25000, 
                HinhAnh="https://product.hstatic.net/1000141988/product/nuoc_ngot_sprite_330_ml_36218b2593804919860644198e59fa1c.jpg"},
            new MonAn(){Id= 9, TenMon="Bánh mì sandwich", MoTa="Một món ăn nhẹ phổ biến, bánh mì sandwich thường bao gồm lớp thịt, rau sống, và sốt được " +
                "đặt giữa hai lớp bánh mì.", 
                IsAvailable=1, LoaiMonAnId=5, IsDelete=false, Gia=50000, 
                HinhAnh="https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/filters:quality(95)/https://cms-prod.s3-sgn09.fptcloud.com/mach_ban_6_cach_lam_banh_mi_sandwich_day_du_dinh_duong_1_8756a3e8e2.png"},
            new MonAn(){Id= 10, TenMon="Bánh tráng trộn", MoTa="Một món ăn nhẹ truyền thống trong ẩm thực Việt Nam, bánh tráng trộn thường chứa các thành " +
                "phần như bánh tráng, rau sống, đậu phộng, tôm khô và gia vị, tạo nên hương vị độc đáo.", 
                IsAvailable=1, LoaiMonAnId=5, IsDelete=false, Gia=50000, 
                HinhAnh="https://www.btaskee.com/wp-content/uploads/2021/08/banh-trang-tron.jpg"},
            new MonAn(){Id= 11, TenMon="Sô cô la brownie", MoTa="Một loại kem truyền thống, kem vanilla có hương vị tinh tế của vani. Nó thường được ưa chuộng " +
                "để ăn kèm với nhiều loại bánh ngọt và tráng miệng khác.", 
                IsAvailable=1, LoaiMonAnId=6, IsDelete=false, Gia=65000, 
                HinhAnh="https://cdn.tgdd.vn/Files/2022/04/13/1425530/cach-lam-banh-brownie-chocolate-mem-min-ngot-ngao-danh-tang-nguoi-thuong-202204131342149103.jpg"},
            new MonAn(){Id= 12, TenMon="Kem vanilla", MoTa="Một loại bánh ngọt được làm từ chocolate, bơ, đường và trứng, brownie thường có cấu trúc nhẹ, " +
                "giòn bên ngoài và ngọt ngon bên trong.",
                IsAvailable=1, LoaiMonAnId=6, IsDelete=false, Gia=54000, 
                HinhAnh="https://cdn.tgdd.vn/2020/09/CookProduct/1-1200x676-9.jpg"},
            new MonAn(){Id= 13, TenMon="Pizza Pepperoni", MoTa="Một phiên bản klasik của pizza, Margherita được làm từ bột nướng mỏng, sốt cà chua, phô mai " +
                "mozzarella và lá cỏ basil. Một món pizza đơn giản nhưng thơm ngon và ngon miệng.",
                IsAvailable=1, LoaiMonAnId=7, IsDelete=false, Gia=220000, 
                HinhAnh="https://www.simplyrecipes.com/thmb/pjYMLcsKHkr8D8tYixmaFNxppPw=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/__opt__aboutcom__coeus__resources__content_migration__simply_recipes__uploads__2019__09__easy-pepperoni-pizza-lead-3-8f256746d649404baa36a44d271329bc.jpg"},
            new MonAn(){Id= 14, TenMon="Pizza Margherita", MoTa="Là một trong những loại pizza phổ biến nhất, pizza Pepperoni thường được phủ đầy lớp xúc " +
                "xích pepperoni, một loại xúc xích Ý, cùng với sốt cà chua và phô mai.",
                IsAvailable=1, LoaiMonAnId=7, IsDelete=false, Gia=250000, 
                HinhAnh="https://images.prismic.io/eataly-us/ed3fcec7-7994-426d-a5e4-a24be5a95afd_pizza-recipe-main.jpg?auto=compress,format"}
        };

        public static List<Role> roles = new List<Role>(){
            new Role(){Id= 1,Ten="Admin"},
            new Role(){Id= 2,Ten="Nhân viên kho"},
            new Role(){Id= 3,Ten="Nhân viên bàn"},
        };

        public static List<Setting> settings = new List<Setting>(){
            new Setting(){Id= 1,NgonNgu="Tiếng Việt"},
            new Setting(){Id= 2,NgonNgu="Tiếng Anh"}
        };

        public static List<TrangThaiBan> trangThaiBans = new List<TrangThaiBan>(){
            new TrangThaiBan(){Id= 1,Ten="Trống"},
            new TrangThaiBan(){Id= 2,Ten="Đang dùng"}
        };

        public static List<NhanVien> nhanViens = new List<NhanVien>(){
            new NhanVien(){Id= 1, Ten="Nguyễn văn A", Email="nguyenvana@gmail.com",SDT="0998867545", NgaySinh=new DateTime(1999,3,12), 
                Luong=6000000, HinhAnh="https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Unknown_person.jpg/925px-Unknown_person.jpg", IsDelete=false},
            new NhanVien(){Id= 2, Ten="Nguyễn văn B", Email="nguyenvanb@gmail.com",SDT="0998867546", NgaySinh=new DateTime(1998,4,13),
                Luong=6500000, HinhAnh="https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Unknown_person.jpg/925px-Unknown_person.jpg", IsDelete=false},
            new NhanVien(){Id= 3, Ten="Phùng Đại C", Email="phungdaic@gmail.com",SDT="0998867547", NgaySinh=new DateTime(1997,5,14), 
                Luong=7500000, HinhAnh="https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Unknown_person.jpg/925px-Unknown_person.jpg", IsDelete=false},
            new NhanVien(){Id= 4, Ten="Phùng văn D", Email="phungvand@gmail.com",SDT="0998867548", NgaySinh=new DateTime(1996,6,15), 
                Luong=8000000, HinhAnh="https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Unknown_person.jpg/925px-Unknown_person.jpg", IsDelete=false}
        };

        public static List<TaiKhoan> taiKhoans = new List<TaiKhoan>(){
            new TaiKhoan(){Id= 1, NhanVienId=1, MatKhau="admin", RoleId=1, SettingId=1, Ten="admin", IsDelete=false},
            new TaiKhoan(){Id= 2, NhanVienId=2, MatKhau="123123", RoleId=2, SettingId=1, Ten="andraw tate", IsDelete=false},
            new TaiKhoan(){Id= 3, NhanVienId=3, MatKhau="123123", RoleId=3, SettingId=1, Ten="le minh an", IsDelete=false},
            new TaiKhoan(){Id= 4, NhanVienId=4, MatKhau="123123", RoleId=3, SettingId=1, Ten="ha nghiem", IsDelete=false},
        };

        public static List<HoaDon> hoaDons = new List<HoaDon>(){
            new HoaDon(){Id= 1,BanId=1, TaiKhoanTaoId = 4, TrangThai = true, NgayTao = new DateTime(2024,3,5), TongGia = 110000},
            new HoaDon(){Id= 2,BanId=1, TaiKhoanTaoId = 3, TrangThai = true, NgayTao = new DateTime(2024,4,6), TongGia = 150000},
            new HoaDon(){Id= 3,BanId=2, TaiKhoanTaoId = 4, TrangThai = true, NgayTao = new DateTime(2024,4,6), TongGia = 130000}
        };

        public static List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>(){
            new ChiTietHoaDon(){Id= 1, HoaDonId = 1, MonAnId=1, SoLuong=2, ThanhTien= 20000},
            new ChiTietHoaDon(){Id= 2, HoaDonId = 1, MonAnId=2, SoLuong=2, ThanhTien= 30000},
            new ChiTietHoaDon(){Id= 3, HoaDonId = 1, MonAnId=3, SoLuong=2, ThanhTien= 60000},
            new ChiTietHoaDon(){Id= 4, HoaDonId = 2, MonAnId=1, SoLuong=3, ThanhTien= 30000},
            new ChiTietHoaDon(){Id= 5, HoaDonId = 2, MonAnId=2, SoLuong=2, ThanhTien= 30000},
            new ChiTietHoaDon(){Id= 6, HoaDonId = 2, MonAnId=3, SoLuong=3, ThanhTien= 90000},
            new ChiTietHoaDon(){Id= 7, HoaDonId = 3, MonAnId=4, SoLuong=1, ThanhTien= 40000},
            new ChiTietHoaDon(){Id= 8, HoaDonId = 3, MonAnId=2, SoLuong=2, ThanhTien= 30000},
            new ChiTietHoaDon(){Id= 9, HoaDonId = 3, MonAnId=5, SoLuong=3, ThanhTien= 60000},
        };

        public static List<Ban> bans = new List<Ban>(){
            new Ban(){Id= 1, TenBan="Bàn 1", TrangThaiId=1},
            new Ban(){Id= 2, TenBan="Bàn 2", TrangThaiId=1},
            new Ban(){Id= 3, TenBan="Bàn 3", TrangThaiId=1},
            new Ban(){Id= 4, TenBan="Bàn 4", TrangThaiId=1},
            new Ban(){Id= 5, TenBan="Bàn 5", TrangThaiId=1},
            new Ban(){Id= 6, TenBan="Bàn 6", TrangThaiId=1},
            new Ban(){Id= 7, TenBan="Bàn 7", TrangThaiId=1},
            new Ban(){Id= 8, TenBan="Bàn 8", TrangThaiId=1},
            new Ban(){Id= 9, TenBan="Bàn 9", TrangThaiId=1},
            new Ban(){Id= 10, TenBan="Bàn 10", TrangThaiId=1},
            new Ban(){Id= 11, TenBan="Bàn 11", TrangThaiId=1},
            new Ban(){Id= 12, TenBan="Bàn 12", TrangThaiId=1},
            new Ban(){Id= 13, TenBan="Bàn 13", TrangThaiId=1},
            new Ban(){Id= 14, TenBan="Bàn 14", TrangThaiId=1},
            new Ban(){Id= 15, TenBan="Bàn 15", TrangThaiId=1},
            new Ban(){Id= 16, TenBan="Bàn 16", TrangThaiId=1},
            new Ban(){Id= 17, TenBan="Bàn 17", TrangThaiId=1},
            new Ban(){Id= 18, TenBan="Bàn 18", TrangThaiId=1},
            new Ban(){Id= 19, TenBan="Bàn 19", TrangThaiId=1},
            new Ban(){Id= 20, TenBan="Bàn 20", TrangThaiId=1},
            new Ban(){Id= 21, TenBan="Bàn 21", TrangThaiId=1},
            new Ban(){Id= 22, TenBan="Bàn 22", TrangThaiId=1},
            new Ban(){Id= 23, TenBan="Bàn 23", TrangThaiId=1},
            new Ban(){Id= 24, TenBan="Bàn 24", TrangThaiId=1},
            new Ban(){Id= 25, TenBan="Bàn 25", TrangThaiId=1}
        }; 

        public static void Render() {
            ThemTrangThaiTonKho();
            ThemNhaCungCap();
            ThemNguyenLieu();
            ThemTonKho();
            ThemLoaiMonAn();
            ThemMonAn();
            ThemTrangThaiBan();
            ThemSetting();
            ThemRole();
            ThemBan();
            ThemNhanVien();
            ThemTaiKhoan();
           /* ThemHoaDon();
            ThemChiTietHoaDon();*/
            new TonKhoLogic().UpdateOutOfDate();
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

        public static void ThemLoaiMonAn() {
            LoaiMonAnLogic logic = new LoaiMonAnLogic();
            if (logic.GetAll().Count() == 0) {
                foreach (var item in loaiMonAns) {
                    logic.Insert(item);
                }
            }
        }

        public static void ThemMonAn() {
            MonAnLogic logic = new MonAnLogic();
            try {
                if (logic.GetAll().Count() == 0) {
                    foreach (var item in monAns) {
                        logic.Insert(item);
                    }
                }
            } catch (Exception ex) {

                throw;
            }
        }

        public static void ThemSetting() {
            SettingLogic logic = new SettingLogic();
            if (logic.GetAll().Count() == 0) {
                foreach (var item in settings) {
                    logic.Insert(item);
                }
            }
        }

        public static void ThemRole() {
            RoleLogic logic = new RoleLogic();
            if (logic.GetAll().Count() == 0) {
                foreach (var item in roles) {
                    logic.Insert(item);
                }
            }
        }

        public static void ThemTrangThaiBan() {
            TrangThaiBanLogic logic = new TrangThaiBanLogic();
            if (logic.GetAll().Count() == 0) {
                foreach (var item in trangThaiBans) {
                    logic.Insert(item);
                }
            }
        }

        public static void ThemBan() {
            BanLogic logic = new BanLogic();
            if (logic.GetAll().Count() == 0) {
                for (int i =1; i< 26; i++) {
                    logic.Insert(new Ban() {TenBan="Bàn số "+i, TrangThaiId=1 });
                }
            }
        }

        public static void ThemNhanVien() {
            NhanVienLogic logic = new NhanVienLogic();
            if (logic.GetAll().Count() == 0) {
                foreach (var item in nhanViens) {
                    logic.Insert(item);
                }
            }
        }

        public static void ThemTaiKhoan() {
            TaiKhoanLogic logic = new TaiKhoanLogic ();
            if (logic.GetAll().Count() == 0) {
                foreach (var item in taiKhoans) {
                    logic.Insert(item);
                }
            }
        }

        public static void ThemHoaDon() {
            HoaDonLogic logic = new HoaDonLogic();
            if (logic.GetAll().Count() == 0) {
                foreach (var item in hoaDons) {
                    logic.Insert(item);
                }
            }
        }

        public static void ThemChiTietHoaDon() {
            ChiTieHoaDonLogic logic = new ChiTieHoaDonLogic();
            if (logic.GetAll().Count() == 0) {
                foreach (var item in chiTietHoaDons) {
                    logic.Insert(item);
                }
            }
        }
    }
}