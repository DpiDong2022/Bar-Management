using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DTO {
    public class TonKhoDto {
        #region Fields
        private string _gia;
        private string _ngayNhap;
        private string _ngayHetHan;
        #endregion
        public int Id { get; set; }
        public NguyenLieu NguyenLieu { get; set; }
        public int SoLuong { get; set; }
        public string DonVi { get; set; }
        public object GiaNhap {
            get {
                return _gia;
            }
            set {
                _gia = string.Format("{0:#,##0}", decimal.Parse(value.ToString()));
            } 
        }
        public TrangThaiTonKho TrangThai { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public object NgayNhap {
            get {
                return _ngayNhap;
            }
            private set { 
                _ngayNhap = ((DateTime)value).ToString("dd-MM-yyyy");
            } 
        }
        public object NgayHetHan {
            get {
                return _ngayHetHan;
            }
            private set {
                _ngayHetHan = ((DateTime)value).ToString("dd-MM-yyyy");
            }
        }
    }
}
