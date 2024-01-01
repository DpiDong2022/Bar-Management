namespace Bar_Management.DTO {
     public enum TrangThaiEnum {
        Het = 0,
        Con
    }
    public class MonAnDto {
        #region fiels
        private string _tinhTrang;
        # endregion

        public int Id { get; set; }
        public string TenMon { get; set; }
        public string Gia { get; set; }
        public string TrangThai { get; set; }
        public string MoTa { get; set; }
        public LoaiMonAn LoaiMonAn { get; set; }
        public string HinhAnh { get; set; }
    }
}
