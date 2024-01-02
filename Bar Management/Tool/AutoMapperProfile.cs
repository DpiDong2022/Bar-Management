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
                .ForMember(dest => dest.TrangThai, opt => opt.MapFrom(src => src.IsAvailable == 1 ? "Còn":"Hết"))
                .ForMember(dest => dest.LoaiMonAn, opt => opt.MapFrom(src => new LoaiMonAnLogic().GetAll().First(lm => lm.Id == src.LoaiMonAnId)))
                .ForMember(dest => dest.Gia, opt => opt.MapFrom(src => src.Gia.ToString("0#,##0")));
                cfg.CreateMap<MonAnDto, MonAn>()
                .ForMember(dest => dest.IsAvailable, opt => opt.MapFrom(src => src.TrangThai == "Còn" ? 1:0))
                .ForMember(dest => dest.LoaiMonAnId, opt => opt.MapFrom(src => src.LoaiMonAn.Id))
                .ForMember(dest => dest.Gia, opt => opt.MapFrom(src => int.Parse(src.Gia)));
                
               /* cfg.CreateMap<UserInformation, User>()
                    .ForMember(dest => dest.CreateAt, opt => opt.MapFrom(src => DateTime.Now))
                    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => CommonFunctions.NameFormat(src.UserName)));*/
            });
            return config.CreateMapper();
        }
    }
}
