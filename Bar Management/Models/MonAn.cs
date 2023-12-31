﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Bar_Management.Models {
    public class MonAn {

        #region fiels
        private string _tinhTrang;
        # endregion

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Chiều dài của tên không nhỏ hơn 0 hoặc lớn hơn 50")]
        public string TenMon { get; set; }

        [Required]
        public int LoaiMonAnId { get; set; }

        [ForeignKey("LoaiMonAnId")]
        public LoaiMonAn LoaiMonAn { get; set; }

        [Required]
        public decimal Gia { get; set; }

        [Required]

        [DefaultValue(1)]
        public int IsAvailable { get; set; } = 1;

        [MaxLength(255)]
        public string HinhAnh { get; set; }

        [MaxLength(100, ErrorMessage = "Chiều dài của mô tả không lớn hơn 100")]
        public string MoTa { get; set; }
    }
}
