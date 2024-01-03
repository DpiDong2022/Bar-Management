using Bar_Management.Models;

namespace Bar_Management.DTO {
     public enum TrangThaiMonAnEnum {
        Het = 0,
        Con =1
    }
    public class MonAnDto {
        #region fiels
        private string _trangThai;
        private string _gia;
        # endregion

        public int Id { get; set; }
        public string TenMon { get; set; }
        public object Gia 
        {
            get {
                return
                    _gia;
            }
            set {
                _gia = string.Format("{0:#,##0}", float.Parse(value.ToString()));
            }
        }
        public object TrangThai 
        {
            get {
                return _trangThai;
            }
            set {
                if ((int)value == 1 || (int)value == 0) {
                    _trangThai = (int)value == 1 ? "Còn" : "Hết";
                    return;
                }
                _trangThai = "khong biet";
            }
        }
        public string MoTa { get; set; }
        public LoaiMonAn LoaiMonAn { get; set; }
        public string HinhAnh { get; set; }

        public MonAnDto(object gia, int id, string tenMon, object trangThai, string moTa, LoaiMonAn loaiMonAn, string hinhAnh) {
            TrangThai = trangThai;
            Gia = gia;
            Id = id;
            TenMon = tenMon;
            MoTa = moTa;
            LoaiMonAn = loaiMonAn;
            HinhAnh = hinhAnh;
        }

        public MonAnDto() {
        }
    }
}
