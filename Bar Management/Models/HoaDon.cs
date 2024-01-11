using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Bar_Management.Models {
    public class HoaDon {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime NgayTao { get; set; }

        [Required]
        public int TaiKhoanTaoId { get; set; }

        [ForeignKey("TaiKhoanTaoId")]
        public TaiKhoan TaiKhoanTao { get; set; }

        [Required]
        public decimal TongGia { get; set; }

        [Required]
        public bool TrangThai { get; set; } = false;
        [Required]
        public int BanId { get; set; }

        public Ban Ban { get; set; }

    }
}
