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
                cfg.CreateMap<MonAn, MonAnDto>()
                .ForMember(dest => dest.TrangThai, opt => opt.MapFrom(src => src.IsAvailable));

                cfg.CreateMap<MonAnDto, MonAn>()
                .ForMember(dest => dest.IsAvailable, opt => opt.MapFrom(src => src.TrangThai == "Còn" ? 1:0))
                .ForMember(dest => dest.LoaiMonAnId, opt => opt.MapFrom(src => src.LoaiMonAn.Id))
                .ForMember(dest => dest.Gia, opt => opt.MapFrom(src => decimal.Parse(((string)src.Gia).Replace(",",""))));

                cfg.CreateMap<TonKho, TonKhoDto>();
                cfg.CreateMap<TonKhoDto, TonKho>()
                 .ForMember(dest => dest.GiaNhap, opt => opt.MapFrom(src => decimal.Parse(src.GiaNhap.ToString().Replace(",",""))))
                 .ForMember(dest => dest.NgayNhap, opt => opt.MapFrom(src => DateTime.ParseExact(src.NgayNhap.ToString(), "dd-MM-yyyy",null)))
                 .ForMember(dest => dest.NgayHetHan, opt => opt.MapFrom(src => DateTime.ParseExact(src.NgayHetHan.ToString(), "dd-MM-yyyy",null)));
               /* cfg.CreateMap<UserInformation, User>()
                    .ForMember(dest => dest.CreateAt, opt => opt.MapFrom(src => DateTime.Now))
                    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => CommonFunctions.NameFormat(src.UserName)));*/
            });
            return config.CreateMapper();
        }
    }
}
