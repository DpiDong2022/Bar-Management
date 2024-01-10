using AutoMapper;
using Bar_Management.DTO;
using Bar_Management.Models;
using System;
using System.Windows.Forms;

namespace Bar_Management.Tool {
    public class AutoMapperProfile {
        public static IMapper InitializeAutoMapper() {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MonAn, MonAnDto>()
            .ForMember(dest => dest.TrangThai, opt => opt.MapFrom(src => src.IsAvailable));

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
            .ForMember(dest => dest.NgayNhap, opt => opt.MapFrom(src => ObjectToDateTime(src.NgayNhap)))
            .ForMember(dest => dest.NgayHetHan, opt => opt.MapFrom(src => ObjectToDateTime(src.NgayHetHan)));
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

                // Hóa đơn
                cfg.CreateMap<HoaDon, HoaDonDto>();
                cfg.CreateMap<HoaDonDto, HoaDon>()
            .ForMember(dest => dest.TongGia, opt => opt.MapFrom(src => decimal.Parse(((string)src.TongGia).Replace(",",""))))
            .ForMember(dest => dest.TrangThai, opt => opt.MapFrom(src => src.TrangThai == "Đã thanh toán" ? true:false))
            .ForMember(dest => dest.NgayTao, opt => opt.MapFrom(src => ObjectToDateTime(src.NgayTao)));

                //chi tiết hóa đơn
                cfg.CreateMap<ChiTietHoaDon, ChiTietHoaDonDto>();
                cfg.CreateMap<ChiTietHoaDonDto, ChiTietHoaDon>()
            .ForMember(dest => dest.ThanhTien, opt => opt.MapFrom(src => decimal.Parse(((string)src.ThanhTien).Replace(",",""))));
            });

            return config.CreateMapper();
        }

        public static DateTime ObjectToDateTime(object datetimeObj) {
            return DateTime.ParseExact(datetimeObj.ToString(), "dd-MM-yyyy", null);
        }

    }
}
