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

        static List<LoaiMonAn> loaiMonAns = new List<LoaiMonAn> (){
            new LoaiMonAn(){ TenLoai="Cocktail" },
            new LoaiMonAn(){ TenLoai="Rượu" },
            new LoaiMonAn(){ TenLoai="Rượu mạch" },
            new LoaiMonAn(){ TenLoai="Nước ngọt" },
            new LoaiMonAn(){ TenLoai="Đồ ăn nhẹ" },
            new LoaiMonAn(){ TenLoai="Pizza" },
            new LoaiMonAn(){ TenLoai="Món ngọt" },
            new LoaiMonAn(){ TenLoai="Đồ ăn đặc biệt" }
        };

        static List<MonAn> monAns = new List<MonAn> (){
            new MonAn(){ TenMon="Margarita", MoTa="Một cocktail truyền thống của Mexico, Margarita thường được làm từ tequila, " +
                "triple sec và nước cốt chanh. Được phục vụ trên đá hoặc shaken với đá.", 
                IsAvailable=1, LoaiMonAnId=1, IsDelete=false, Gia=10000, 
                HinhAnh="https://www.liquor.com/thmb/JQgDGy26Zsw-_cFGKH4zNH9PlXk=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Frozen-Margarita-1500x1500-hero-191e49b3ab4f4781b93f3cfacac25136.jpg"},
            new MonAn(){ TenMon="Mojito", MoTa="Một cocktail nguồn gốc từ Cuba, Mojito thường bao gồm rum, đường, nước cốt chanh, lá bạc hà, đá " +
                "và soda. Nó có hương vị tươi mát, ngọt ngào và có độ cay từ lá bạc hà.", 
                IsAvailable=1, LoaiMonAnId=1, IsDelete=false, Gia=15000, 
                HinhAnh="https://agratefulmeal.com/wp-content/uploads/2023/02/blue-mojito-curacao-cocktail-featured.jpg"},
            new MonAn(){ TenMon="Cabernet Sauvignon", MoTa="Một loại nho đỏ nổi tiếng, Cabernet Sauvignon thường có hương thơm của quả mâm xôi, " +
                "mâm cảm và một chút cay. Nó tạo ra rượu đỏ đậm, hương vị đầy đặn và cấu trúc tannin mạnh mẽ.", 
                IsAvailable=1, LoaiMonAnId=2, IsDelete=false, Gia=30000, 
                HinhAnh="https://winecellar.vn/wp-content/uploads/2016/05/vistana-cabernet-sauvignon-merlot.jpg"},
            new MonAn(){ TenMon="Chardonnay", MoTa="Rượu trắng phổ biến, Chardonnay thường có hương thơm của trái cây như táo và lê, có thể kết " +
                "hợp với hương vani hay nho trắng.", 
                IsAvailable=1, LoaiMonAnId=2, IsDelete=false, Gia=40000, 
                HinhAnh="https://winecellar.vn/wp-content/uploads/2017/07/chateau-de-meursault-bourgogne-chardonnay-1.jpg"},
            new MonAn(){ TenMon="Irish Cream", MoTa="Một loại rượu mạch có nguồn gốc từ Ireland, Irish Cream kết hợp giữa whiskey, đường, kem và các " +
                "thành phần khác. Nó có hương vị ngọt ngào.", 
                IsAvailable=1, LoaiMonAnId=3, IsDelete=false, Gia=20000, 
                HinhAnh="https://www.imperialsugar.com/sites/default/files/recipe/Irish-cream-liqueur-imperial.jpg"},
            new MonAn(){ TenMon="Baileys", MoTa="Một thương hiệu nổi tiếng của Irish Cream, Baileys thường có hương vị của kem sô cô la và vani, tạo " +
                "nên một hương vị ngon ngọt và thơm ngon.", 
                IsAvailable=1, LoaiMonAnId=3, IsDelete=false, Gia=23000, 
                HinhAnh="https://thewanderlustkitchen.com/wp-content/uploads/2022/12/Baileys-Chocoalte-Martini-Recipe-06-2.jpg"},
            new MonAn(){ TenMon="Coca-Cola", MoTa="Một đồ uống có ga phổ biến trên toàn thế giới, Coca-Cola có hương vị ngọt ngào và cảm giác cà phê." +
                " Nó thường được phục vụ với đá.", 
                IsAvailable=1, LoaiMonAnId=4, IsDelete=false, Gia=25000, 
                HinhAnh="https://tea-3.lozi.vn/v1/ship/resized/losupply-quang-tri-thanh-pho-dong-ha-quang-tri-1648801646214781853-nuoc-ngot-coca-cola-lon-320ml-0-1658895994?w=480&type=o"},
            new MonAn(){ TenMon="Sprite", MoTa="Một loại nước ngọt không có caffeine, Sprite có hương vị chanh mát, tươi mới và thường được ưa chuộng " +
                "như một đồ uống giải khát.", 
                IsAvailable=1, LoaiMonAnId=4, IsDelete=false, Gia=25000, 
                HinhAnh="https://product.hstatic.net/1000141988/product/nuoc_ngot_sprite_330_ml_36218b2593804919860644198e59fa1c.jpg"},
            new MonAn(){ TenMon="Bánh mì sandwich", MoTa="Một món ăn nhẹ phổ biến, bánh mì sandwich thường bao gồm lớp thịt, rau sống, và sốt được " +
                "đặt giữa hai lớp bánh mì.", 
                IsAvailable=1, LoaiMonAnId=5, IsDelete=false, Gia=50000, 
                HinhAnh="https://cdn.nhathuoclongchau.com.vn/unsafe/800x0/filters:quality(95)/https://cms-prod.s3-sgn09.fptcloud.com/mach_ban_6_cach_lam_banh_mi_sandwich_day_du_dinh_duong_1_8756a3e8e2.png"},
            new MonAn(){ TenMon="Bánh tráng trộn", MoTa="Một món ăn nhẹ truyền thống trong ẩm thực Việt Nam, bánh tráng trộn thường chứa các thành " +
                "phần như bánh tráng, rau sống, đậu phộng, tôm khô và gia vị, tạo nên hương vị độc đáo.", 
                IsAvailable=1, LoaiMonAnId=5, IsDelete=false, Gia=50000, 
                HinhAnh="https://www.btaskee.com/wp-content/uploads/2021/08/banh-trang-tron.jpg"},
            new MonAn(){ TenMon="Sô cô la brownie", MoTa="Một loại kem truyền thống, kem vanilla có hương vị tinh tế của vani. Nó thường được ưa chuộng " +
                "để ăn kèm với nhiều loại bánh ngọt và tráng miệng khác.", 
                IsAvailable=1, LoaiMonAnId=6, IsDelete=false, Gia=65000, 
                HinhAnh="https://cdn.tgdd.vn/Files/2022/04/13/1425530/cach-lam-banh-brownie-chocolate-mem-min-ngot-ngao-danh-tang-nguoi-thuong-202204131342149103.jpg"},
            new MonAn(){ TenMon="Kem vanilla", MoTa="Một loại bánh ngọt được làm từ chocolate, bơ, đường và trứng, brownie thường có cấu trúc nhẹ, " +
                "giòn bên ngoài và ngọt ngon bên trong.",
                IsAvailable=1, LoaiMonAnId=6, IsDelete=false, Gia=54000, 
                HinhAnh="https://cdn.tgdd.vn/2020/09/CookProduct/1-1200x676-9.jpg"},
            new MonAn(){ TenMon="Pizza Pepperoni", MoTa="Một phiên bản klasik của pizza, Margherita được làm từ bột nướng mỏng, sốt cà chua, phô mai " +
                "mozzarella và lá cỏ basil. Một món pizza đơn giản nhưng thơm ngon và ngon miệng.",
                IsAvailable=1, LoaiMonAnId=7, IsDelete=false, Gia=220000, 
                HinhAnh="https://www.simplyrecipes.com/thmb/pjYMLcsKHkr8D8tYixmaFNxppPw=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/__opt__aboutcom__coeus__resources__content_migration__simply_recipes__uploads__2019__09__easy-pepperoni-pizza-lead-3-8f256746d649404baa36a44d271329bc.jpg"},
            new MonAn(){ TenMon="Pizza Margherita", MoTa="Là một trong những loại pizza phổ biến nhất, pizza Pepperoni thường được phủ đầy lớp xúc " +
                "xích pepperoni, một loại xúc xích Ý, cùng với sốt cà chua và phô mai.",
                IsAvailable=1, LoaiMonAnId=7, IsDelete=false, Gia=250000, 
                HinhAnh="https://images.prismic.io/eataly-us/ed3fcec7-7994-426d-a5e4-a24be5a95afd_pizza-recipe-main.jpg?auto=compress,format"}
        };

        static List<Role> roles = new List<Role>(){
            new Role(){Ten="Admin"},
            new Role(){Ten="Nhân viên kho"},
            new Role(){Ten="Nhân viên bàn"},
        };

        static List<Setting> settings = new List<Setting>(){
            new Setting(){NgonNgu="Tiếng Việt"},
            new Setting(){NgonNgu="Tiếng Anh"}
        };

        static List<TrangThaiBan> trangThaiBans = new List<TrangThaiBan>(){
            new TrangThaiBan(){Ten="Trống"},
            new TrangThaiBan(){Ten="Đang dùng"}
        };

        static List<NhanVien> nhanViens = new List<NhanVien>(){
            new NhanVien(){ Ten="Nguyễn văn A", Email="nguyenvana@gmail.com",SDT="0998867545", NgaySinh=new DateTime(1999,3,12), 
                Luong=6000000, HinhAnh="https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Unknown_person.jpg/925px-Unknown_person.jpg", IsDelete=false},
            new NhanVien(){ Ten="Nguyễn văn B", Email="nguyenvanb@gmail.com",SDT="0998867546", NgaySinh=new DateTime(1998,4,13),
                Luong=6500000, HinhAnh="https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Unknown_person.jpg/925px-Unknown_person.jpg", IsDelete=false},
            new NhanVien(){ Ten="Phùng Đại C", Email="phungdaic@gmail.com",SDT="0998867547", NgaySinh=new DateTime(1997,5,14), 
                Luong=7500000, HinhAnh="https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Unknown_person.jpg/925px-Unknown_person.jpg", IsDelete=false},
            new NhanVien(){ Ten="Phùng văn D", Email="phungvand@gmail.com",SDT="0998867548", NgaySinh=new DateTime(1996,6,15), 
                Luong=8000000, HinhAnh="https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Unknown_person.jpg/925px-Unknown_person.jpg", IsDelete=false}
        };

        static List<TaiKhoan> taiKhoans = new List<TaiKhoan>(){
            new TaiKhoan(){ NhanVienId=1, MatKhau="admin", RoleId=1, SettingId=1, Ten="admin", IsDelete=false},
            new TaiKhoan(){ NhanVienId=2, MatKhau="123123", RoleId=2, SettingId=1, Ten="andraw tate", IsDelete=false},
            new TaiKhoan(){ NhanVienId=3, MatKhau="123123", RoleId=3, SettingId=1, Ten="le minh an", IsDelete=false},
            new TaiKhoan(){ NhanVienId=4, MatKhau="123123", RoleId=3, SettingId=1, Ten="ha nghiem", IsDelete=false},
        };

        static List<HoaDon> hoaDons = new List<HoaDon>(){
            new HoaDon(){BanId=1, TaiKhoanTaoId = 4, TrangThai = true, NgayTao = new DateTime(2024,3,5), TongGia = 10000},
            new HoaDon(){BanId=1, TaiKhoanTaoId = 5, TrangThai = true, NgayTao = new DateTime(2024,4,6), TongGia = 10000},
            new HoaDon(){BanId=2, TaiKhoanTaoId = 4, TrangThai = true, NgayTao = new DateTime(2024,5,7), TongGia = 10000},
            new HoaDon(){BanId=3, TaiKhoanTaoId = 1, TrangThai = true, NgayTao = new DateTime(2024,5,8), TongGia = 10000},
            new HoaDon(){BanId=3, TaiKhoanTaoId = 4, TrangThai = true, NgayTao = new DateTime(2024,6,9), TongGia = 10000},
            new HoaDon(){BanId=4, TaiKhoanTaoId = 5, TrangThai = true, NgayTao = new DateTime(2024,7,10), TongGia = 10000},
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
            ThemHoaDon();
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
    }
}