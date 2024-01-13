using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.Models {
    public class NguyenLieu {
        [Key]
        public int? Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ten { get; set; }

        [DataType("text")]
        public string HinhAnh { get; set; }

        [DefaultValue(0)]
        public decimal GiaBan { get; set; }
        [Required]
        public bool IsDelete { get; set; }

        public override string ToString() {
            return Ten;
        }
    }
}
