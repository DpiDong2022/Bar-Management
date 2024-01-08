using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DTO
{
    public class TaiKhoanDTO
    {
        //#region fiels
        //private string _trangThai;
        //private string _gia;
        //# endregion
        public int Id { get; set; }
        public string Ten { get; set; }

        public string MatKhau { get; set; }

        public Role Role { get; set; }

        public NhanVien NhanVien { get; set; }
        public Setting Setting { get; set; }

        public override string ToString() {
            return Ten;
        }
    }
}
