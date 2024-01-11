using AutoMapper;
using Bar_Management.DTO;
using Bar_Management.Models;
using System;
using Bar_Management.OrderForm;
namespace Bar_Management.Tool {
    public class AutoMapperProfile {
        public static DateTime ObjectToDateTime(object datetimeObj)
        {
            return DateTime.ParseExact(datetimeObj.ToString(), "dd-MM-yyyy", null);
        }
        public static IMapper InitializeAutoMapper() {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MonAn, MonAnDto>()
            .ForMember(dest => dest.TrangThai, opt => opt.MapFrom(src => src.IsAvailable));
                cfg.CreateMap<MonAn, MonAnOrderDTO>()
            .ForMember(dest => dest.TenMon, opt => opt.MapFrom(src => src.TenMon))
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Gia, opt => opt.MapFrom(src => src.Gia))
            .ForMember(dest => dest.HinhAnh, opt => opt.MapFrom(src => src.HinhAnh))
            .ForMember(dest => dest.LoaiMonAn, opt => opt.MapFrom(src => src.LoaiMonAn));




                cfg.CreateMap<MonAnDto, MonAn>()
            .ForMember(dest => dest.IsAvailable, opt => opt.MapFrom(src => src.TrangThai == "Còn" ? 1:0))
            .ForMember(dest => dest.LoaiMonAnId, opt => opt.MapFrom(src => src.LoaiMonAn.Id))
            .ForMember(dest => dest.Gia, opt => opt.MapFrom(src => decimal.Parse(((string)src.Gia).Replace(",",""))));

                cfg.CreateMap<TonKho, TonKhoDto>();
                cfg.CreateMap<TonKhoDto, TonKho>()
            .ForMember(dest => dest.NguyenLieuId, opt => opt.MapFrom(src => src.NguyenLieu.Id))
            .ForMember(dest => dest.NhaCungCapId, opt => opt.MapFrom(src => src.NhaCungCap.Id))
            .ForMember(dest => dest.TrangThaiId, opt => opt.MapFrom(src => src.TrangThai.Id))
            .ForMember(dest => dest.GiaNhap, opt => opt.MapFrom(src => decimal.Parse(((string)src.GiaNhap).Replace(",",""))))
            .ForMember(dest => dest.NgayNhap, opt => opt.MapFrom(src => DateTime.ParseExact(src.NgayNhap.ToString(), "dd-MM-yyyy",null)))
            .ForMember(dest => dest.NgayHetHan, opt => opt.MapFrom(src => DateTime.ParseExact(src.NgayHetHan.ToString(), "dd-MM-yyyy",null)));
                /* cfg.CreateMap<UserInformation, User>()
                        .ForMember(dest => dest.CreateAt, opt => opt.MapFrom(src => DateTime.Now))
                        .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => CommonFunctions.NameFormat(src.UserName)));*/

                //Nhân viên
                cfg.CreateMap<NhanVien, NhanVienDTO>();
                cfg.CreateMap<NhanVienDTO, NhanVien>()
                .ForMember(dest => dest.Luong, opt => opt.MapFrom(src => decimal.Parse(((string)src.Luong).Replace(",", ""))));
                

                //Tài khoản
                cfg.CreateMap<TaiKhoan, TaiKhoanDTO>();
                cfg.CreateMap<TaiKhoanDTO, TaiKhoan>()
                .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.Role.Id))
                .ForMember(dest => dest.NhanVienId, opt => opt.MapFrom(src => src.NhanVien.Id))
                .ForMember(dest => dest.SettingId, opt => opt.MapFrom(src => src.Setting.Id));

                //Hóa đơn
                // Hóa đơn
                cfg.CreateMap<HoaDon, HoaDonDto>();
                cfg.CreateMap<HoaDonDto, HoaDon>()
            .ForMember(dest => dest.TongGia, opt => opt.MapFrom(src => decimal.Parse(((string)src.TongGia).Replace(",", ""))))
            .ForMember(dest => dest.TrangThai, opt => opt.MapFrom(src => src.TrangThai == "Đã thanh toán" ? 1 : 0))
            .ForMember(dest => dest.NgayTao, opt => opt.MapFrom(src => ObjectToDateTime(src.NgayTao)));

                //chi tiết hóa đơn
                cfg.CreateMap<ChiTietHoaDon, ChiTietHoaDonDto>();
                cfg.CreateMap<ChiTietHoaDonDto, ChiTietHoaDon>()
            .ForMember(dest => dest.ThanhTien, opt => opt.MapFrom(src => decimal.Parse(((string)src.ThanhTien).Replace(",", ""))));
                
            });

            return config.CreateMapper();
        }

    }
}
