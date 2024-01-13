using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Models {
    public class TonKho {
        [Key]
        public int? Id { get; set; }

        [Required]
        public int NguyenLieuId { get; set; }

        [ForeignKey("NguyenLieuId")]
        public NguyenLieu NguyenLieu { get; set; }

        [Required]
        public int SoLuong { get; set; }

        [Required]
        [MaxLength(20)]
        public string DonVi { get; set; }

        [Required]
        public decimal GiaNhap { get; set; }

        [DefaultValue(1)]
        public int TrangThaiId { get; set; }

        [ForeignKey("TrangThaiId")]
        public TrangThaiTonKho TrangThai { get; set; }

        [DefaultValue(1)]
        public int NhaCungCapId { get; set; }
        [ForeignKey("NhaCungCapId")]
        public NhaCungCap NhaCungCap { get; set; }
        [Required]
        public DateTime NgayNhap { get; set; }

        [Required]
        public DateTime NgayHetHan { get; set; }

        public TonKho(TonKho tonKho) {
            Id = tonKho.Id;
            NguyenLieuId = tonKho.NguyenLieuId;
            NguyenLieu = tonKho.NguyenLieu;
            SoLuong = tonKho.SoLuong;
            DonVi = tonKho.DonVi;
            GiaNhap = tonKho.GiaNhap;
            TrangThaiId = tonKho.TrangThaiId;
            TrangThai = tonKho.TrangThai;
            NhaCungCapId = tonKho.NhaCungCapId;
            NhaCungCap = tonKho.NhaCungCap;
            NgayNhap = tonKho.NgayNhap;
            NgayHetHan = tonKho.NgayHetHan;
        }

        public TonKho(int id, int nguyenLieuId, NguyenLieu nguyenLieu, int soLuong, string donVi, decimal giaNhap, int trangThaiId, TrangThaiTonKho trangThai, int nhaCungCapId, NhaCungCap nhaCungCap, DateTime ngayNhap, DateTime ngayHetHan) {
            Id = id;
            NguyenLieuId = nguyenLieuId;
            NguyenLieu = nguyenLieu;
            SoLuong = soLuong;
            DonVi = donVi;
            GiaNhap = giaNhap;
            TrangThaiId = trangThaiId;
            TrangThai = trangThai;
            NhaCungCapId = nhaCungCapId;
            NhaCungCap = nhaCungCap;
            NgayNhap = ngayNhap;
            NgayHetHan = ngayHetHan;
        }

        public TonKho() {
        }
    }
}

