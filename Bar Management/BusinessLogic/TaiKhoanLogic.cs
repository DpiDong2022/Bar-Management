using AutoMapper;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Models;
using Bar_Management.Tool;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Bar_Management.BusinessLogic {

    public class TaiKhoanLogic {

        public readonly AppDbContext Context;
        private readonly GenericRepository<TaiKhoan> _repo;
        private readonly RoleLogic _roleLogic;
        private readonly IMapper _mapper;
        private readonly NhanVienLogic _nhanvienLogic;

        public TaiKhoanLogic() {

            _mapper = AutoMapperProfile.InitializeAutoMapper();
            Context = Singleton.AppDbContext;
            _repo = new GenericRepository<TaiKhoan>();
            _roleLogic = new RoleLogic();
            _nhanvienLogic = new NhanVienLogic();
        }

        public TaiKhoanLogic(AppDbContext appDbContext) {

            _mapper = AutoMapperProfile.InitializeAutoMapper();
            Context = appDbContext;
            _repo = new GenericRepository<TaiKhoan>();
            _roleLogic = new RoleLogic();
            _nhanvienLogic = new NhanVienLogic();
        }

        public bool Delete(TaiKhoan obj) {
            var existedTaikhoan = this.Context.Set<TaiKhoan>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedTaikhoan != null) {
                this.Context.Entry(existedTaikhoan).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Delete(obj);
        }

        public IEnumerable<TaiKhoanDTO> GetAll() {
            var Roles = _roleLogic.GetAll();
            var nhanViens = _nhanvienLogic.GetAll();

            IEnumerable<TaiKhoanDTO> result = _repo.GetAll()
                .Where(c => !c.IsDelete)

                .Join(Roles,
                    taiKhoan => taiKhoan.RoleId,
                    role => role.Id,
                    (taiKhoan, role) => new TaiKhoan()
                    {
                        Id = taiKhoan.Id,
                        Ten = taiKhoan.Ten,
                        MatKhau = taiKhoan.MatKhau,
                        RoleId = taiKhoan.RoleId,
                        Role = role,
                        NhanVienId = taiKhoan.NhanVienId,
                        SettingId = taiKhoan.SettingId
                    })

                .Join(nhanViens,
                      taiKhoan => taiKhoan.NhanVienId,
                      nhanVien => nhanVien.Id,
                      (taiKhoan, nhanVien) => new TaiKhoan()
                      {
                          Id = taiKhoan.Id,
                          Ten = taiKhoan.Ten,
                          MatKhau = taiKhoan.MatKhau,
                          RoleId = taiKhoan.RoleId,
                          Role = taiKhoan.Role,
                          NhanVien = _mapper.Map<NhanVien>(nhanVien),
                          NhanVienId = taiKhoan.NhanVienId,
                          SettingId = taiKhoan.SettingId
                      })
                .Select(TaiKhoan => _mapper.Map<TaiKhoanDTO>(TaiKhoan));
            return result;
        }

        public bool Insert(TaiKhoan obj) {
            obj.Id = null;
            return _repo.Insert(obj);
        }

        public bool Update(TaiKhoan obj) {
            var existedTaikhoan = this.Context.Set<TaiKhoan>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedTaikhoan != null) {
                this.Context.Entry(existedTaikhoan).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Update(obj);
        }
        public List<TaiKhoanDTO> TimKiem(string searchKey, int RoleID = -1, int NhanvienID = -1) {
            IEnumerable<TaiKhoanDTO> taiKhoans;
            if (string.IsNullOrEmpty(searchKey)) {
                taiKhoans = GetAll();
            } else {
                searchKey = searchKey.ToLower();
                string[] keys = searchKey.Split(' ');
                IEnumerable<Models.Role> roles = new GenericRepository<Models.Role>().GetAll();

                taiKhoans = GetAll().Where(taiKhoan => keys.Any(
                    key => taiKhoan.Ten.ToLower().Contains(key)));
            }
            if (RoleID != -1) {
                taiKhoans = taiKhoans.Where(taiKhoan => taiKhoan.Role.Id == RoleID);
            }
            if (NhanvienID != -1) {
                taiKhoans = taiKhoans.Where(taiKhoan => taiKhoan.NhanVien.Id == NhanvienID);
            }

            return taiKhoans.ToList();
        }
        public void ExportToExcel(BindingList<TaiKhoanDTO> table) {
            // lấy vị trí path templete
            string currentPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            int binIndex = currentPath.LastIndexOf("bin");
            string templatepath = currentPath.Substring(0, binIndex) + "Templates\\TaiKhoanExcel.xlsx";
            if (!File.Exists(templatepath)) {
                return;
            }
            // Create a new Excel Application
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false; // Set to true for debugging

            try {
                // Open the template workbook
                Excel.Workbook templateWorkbook = excelApp.Workbooks.Open(templatepath);

                // Access the first worksheet
                Excel.Worksheet worksheet = (Excel.Worksheet)templateWorkbook.Sheets[1];

                // chỉnh sửa file 
                // Copy the style from the source row
                if (table.Count > 22) {
                    Excel.Range sourceRange = worksheet.Rows[3];
                    sourceRange.Copy();

                    // Paste the style to the target range
                    Excel.Range targetRange = worksheet.Range[worksheet.Cells[26, 1], worksheet.Cells[table.Count + 3, 6]];
                    targetRange.PasteSpecial(Excel.XlPasteType.xlPasteFormats);

                    // Clear the clipboard after pasting
                    Clipboard.Clear();
                }

                // ghi dữ liệu
                int rowCount = worksheet.Rows.Count;
                for (int row = 0; row < table.Count; row++) {
                    worksheet.Cells[row + 3, 1].Value = row + 1;
                    worksheet.Cells[row + 3, 2].Value = table[row].Ten;
                    worksheet.Cells[row + 3, 3].Value = table[row].MatKhau;
                    worksheet.Cells[row + 3, 4].Value = table[row].Role.Ten;
                    worksheet.Cells[row + 3, 5].Value = table[row].NhanVien.Ten;
                    worksheet.Cells[row + 3, 6].Value = table[row].Setting;
                }

                // Allow the user to choose where to save the modified file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Save Modified File",
                    FileName = "MonAnBaoCao.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    // Save the modified workbook to the user's chosen location
                    templateWorkbook.SaveAs(saveFileDialog.FileName);

                    Process.Start(saveFileDialog.FileName);
                }

                // Close and release resources
                templateWorkbook.Close(false, Missing.Value, Missing.Value);
                Marshal.ReleaseComObject(templateWorkbook);
            } catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            } finally {
                // Quit Excel application
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
            }
        }
    }
}