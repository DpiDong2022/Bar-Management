using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DTO {
    public class ChiTietHoaDonDto {
        #region Fields
        private string _thanhTien;
        #endregion

        public int Id { get; set; }
        public MonAn MonAn { get; set; }
        public int SoLuong { get; set; }
        public object ThanhTien 
        {
            get {
                return _thanhTien;
            }
            set {
                _thanhTien = string.Format((string)value, "{0:#,##0}");
            } 
        }

        public ChiTietHoaDonDto(int id, MonAn monAn, int soLuong, object thanhTien) {
            Id = id;
            MonAn = monAn;
            SoLuong = soLuong;
            ThanhTien = thanhTien;
        }

        public ChiTietHoaDonDto() {
        }
    }
}
