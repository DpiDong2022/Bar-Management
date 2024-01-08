using AutoMapper;
using Bar_Management.DTO;
using Bar_Management.Models;
using System;
using System.Runtime.Remoting.Messaging;

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
