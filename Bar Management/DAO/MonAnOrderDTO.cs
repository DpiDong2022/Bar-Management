using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DTO
{
    public class MonAnOrderDTO
    {
        #region fiels
        private string _gia;
        # endregion

        public int Id { get; set; }
        public string TenMon { get; set; }
        public decimal Gia { get; set; }
       
        
        public LoaiMonAn LoaiMonAn { get; set; }
        public string HinhAnh { get; set; }

        public MonAnOrderDTO(decimal gia, int id, string tenMon, LoaiMonAn loaiMonAn, string hinhAnh)
        {
            
            Gia = gia;
            Id = id;
            TenMon = tenMon;
            
            LoaiMonAn = loaiMonAn;
            HinhAnh = hinhAnh;
        }

        public MonAnOrderDTO()
        {
        }
    }
}
