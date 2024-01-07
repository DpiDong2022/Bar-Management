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
    public class NhanVienDTO
    {
        #region fiels
        private string _trangThai;
        private string _luong;

        public NhanVienDTO()
        {
        }

        public NhanVienDTO(string trangThai, int id, string ten, DateTime ngaySinh, string sDT, string email, string hinhAnh, object luong, TaiKhoan taiKhoan)
        {
            _trangThai = trangThai;
            Luong = luong;
            Id = id;
            Ten = ten;
            NgaySinh = ngaySinh;
            SDT = sDT;
            Email = email;
            HinhAnh = hinhAnh;
            Luong = luong;
            
        }
        #endregion
        public int Id { get; set; }
        
        public string Ten { get; set; }

        public DateTime NgaySinh { get; set; }

        public string SDT { get; set; }

        public string Email { get; set; }

        public string HinhAnh { get; set; }

        public object Luong {
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
        
    }
}
