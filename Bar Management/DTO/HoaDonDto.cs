using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        } // date created
        public TaiKhoan TaiKhoanTao { get; set; }
        public object TongGia {
            get {
                return _tongGia;
            }
            set {
                _tongGia = string.Format("{0:#,##0}", float.Parse(value.ToString()));
            }
        }  // total price
        public object TrangThai 
        {
            get {
                return _trangThai;
            }
            set {
                _trangThai = ((bool)value) == true ? "Đã thanh toán" : "Chưa thanh toán";
            }
        }

/*        public HoaDonDto(int id, Ban ban, object ngayTao, TaiKhoan taiKhoanTao, object tongGia, object trangThai) {
            Id = id;
            Ban = ban;
            NgayTao = ngayTao;
            TaiKhoanTao = taiKhoanTao;
            TongGia = tongGia;
            TrangThai = trangThai;
        }*/
    }
}
