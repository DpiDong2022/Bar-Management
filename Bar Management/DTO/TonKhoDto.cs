using Bar_Management.Models;
using System;

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
                try {
                    _gia = string.Format("{0:#,##0}", decimal.Parse(value.ToString()));
                } catch (Exception) {

                    throw;
                }
                
            }
        }
        public TrangThaiTonKho TrangThai { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public object NgayNhap {
            get {
                return _ngayNhap;
            }
            set {
                _ngayNhap = ((DateTime)value).ToString("dd-MM-yyyy");
            }
        }
        public object NgayHetHan {
            get {
                return _ngayHetHan;
            }
            set {
                _ngayHetHan = ((DateTime)value).ToString("dd-MM-yyyy");
            }
        }

        public TonKhoDto(int id, NguyenLieu nguyenLieu, int soLuong, string donVi, object giaNhap, TrangThaiTonKho trangThai, NhaCungCap nhaCungCap, object ngayNhap, object ngayHetHan) {
            Id = id;
            NguyenLieu = nguyenLieu;
            SoLuong = soLuong;
            DonVi = donVi;
            GiaNhap = giaNhap;
            TrangThai = trangThai;
            NhaCungCap = nhaCungCap;
            NgayNhap = ngayNhap;
            NgayHetHan = ngayHetHan;
        }

        public TonKhoDto() {
        }

    }
}
