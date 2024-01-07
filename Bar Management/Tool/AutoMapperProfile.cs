using AutoMapper;
using Bar_Management.OrderForm;
using System;
using Bar_Management.Models;
using Bar_Management.DTO;
using Bar_Management.BusinessLogic;
using System.Linq;
using System.Windows.Forms;

namespace Bar_Management.Tool{
    public class AutoMapperProfile{
        public static IMapper InitializeAutoMapper() {
            
            var config = new MapperConfiguration(cfg =>
            {
                //Món ăn
                cfg.CreateMap<MonAn, MonAnDto>()
                .ForMember(dest => dest.TrangThai, opt => opt.MapFrom(src => src.IsAvailable));

                cfg.CreateMap<MonAnDto, MonAn>()
                .ForMember(dest => dest.IsAvailable, opt => opt.MapFrom(src => src.TrangThai == "Còn" ? 1:0))
                .ForMember(dest => dest.LoaiMonAnId, opt => opt.MapFrom(src => src.LoaiMonAn.Id))
                .ForMember(dest => dest.Gia, opt => opt.MapFrom(src => decimal.Parse(((string)src.Gia).Replace(",",""))));


                //Tồn kho
                cfg.CreateMap<TonKho, TonKhoDto>();
                cfg.CreateMap<TonKhoDto, TonKho>();


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
               /* cfg.CreateMap<UserInformation, User>()
                    .ForMember(dest => dest.CreateAt, opt => opt.MapFrom(src => DateTime.Now))
                    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => CommonFunctions.NameFormat(src.UserName)));*/
            });
            return config.CreateMapper();
        }
    }
}
