using Bar_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Management.DTO
{
    public  class NhanVienDTO
    {
        #region fiels
        private string _trangThai;
        private string _luong;
        #endregion

        public int Id { get; set; }
       
        public string Ten { get; set; }

        public DateTime NgaySinh { get; set; }

        [Required]
        
        public string SDT { get; set; }

 
        public string Email { get; set; }

        public string HinhAnh { get; set; }

        public object Luong
        {
            get
            {
                return
                    _luong;
            }
            set
            {
                _luong = string.Format("{0:#,##0}", float.Parse(value.ToString()));
            }
        }
        public TaiKhoan TaiKhoan { get; set; }
        public NhanVienDTO() { }
        public NhanVienDTO(string trangThai, object luong, int id, string ten, DateTime ngaySinh, string sDT, string email, string hinhAnh,  TaiKhoan taiKhoan)
        {
            _trangThai = trangThai;            
            Id = id;
            Ten = ten;
            NgaySinh = ngaySinh;
            SDT = sDT;
            Email = email;
            HinhAnh = hinhAnh;
            Luong = luong;
            TaiKhoan = taiKhoan;
        }
    }
}
