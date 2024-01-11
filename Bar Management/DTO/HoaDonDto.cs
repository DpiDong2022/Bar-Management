using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bar_Management.DAO;

namespace Bar_Management.DTO {
    public class HoaDonDto {
        #region Fields
        private string _trangThai;
        private string _tongGia;
        private string _thoiGianTao;
        #endregion
        public int Id { get; set; }
        public Ban Ban { get; set; }
        public object NgayTao {
            get {
                return _thoiGianTao;
            }
            set {
                _thoiGianTao = ((DateTime)value).ToString("dd-MM-yyyy");
            } 
        }
        public TaiKhoan TaiKhoanTao { get; set; }
        public object TongGia {
            get {
                return _tongGia;
            }
            set {
                _tongGia = string.Format((string)value, "{0:#,##0}");
            }
        }
        public object TrangThai 
        {
            get {
                return _trangThai;
            }
            set
            {
                
                _trangThai = ((int)value) == 1 ? "Đã thanh toán" : "Chưa thanh toán";
            }
        }
       
    }
}
