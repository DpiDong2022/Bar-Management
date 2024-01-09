using AutoMapper;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Models;
using Bar_Management.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Bar_Management.BusinessLogic {

    public class NhanVienLogic {

        public readonly AppDbContext Context;
        private readonly GenericRepository<NhanVien> _repo;
        private readonly IMapper _mapper;

        public NhanVienLogic() {
            _mapper = AutoMapperProfile.InitializeAutoMapper();
            Context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<NhanVien>();
        }

        public bool Delete(NhanVien obj) {
            var existedNhanvien = this.Context.Set<NhanVien>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedNhanvien != null)
            {
                this.Context.Entry(existedNhanvien).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Delete(obj);
        }

        public IEnumerable<NhanVienDTO> GetAll() {
            IEnumerable<NhanVien> result4 = _repo.GetAll().OrderByDescending(nv => nv.Luong.ToString().Replace(",",""));

            IEnumerable<NhanVienDTO> result = _repo.GetAll()
                //.Where(c => !c.isDeleted)
                .Select(nhanvien => _mapper.Map<NhanVienDTO>(nhanvien));
            return result;
        }

        public bool Insert(NhanVien obj) {
            return _repo.Insert(obj);
        }

        public bool Update(NhanVien obj) {
            var existedNhavien = this.Context.Set<NhanVien>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedNhavien != null)
            {
                this.Context.Entry(existedNhavien).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Update(obj);
        }
        public List<NhanVienDTO> TimKiem(string searchKey)
        {
            IEnumerable<NhanVienDTO> nhanviens;
            if (string.IsNullOrEmpty(searchKey))
            {
                nhanviens = GetAll();
            }
            else
            {
                searchKey = searchKey.ToLower();
                string[] keys = searchKey.Split(' ');

                nhanviens = GetAll().Where(nhanVien => keys.Any(
                    key => nhanVien.Ten.ToLower().Contains(key)
                    || nhanVien.Email.ToLower().ToLower().Contains(key)));
            }
            
            return nhanviens.ToList();
        }
        public void ExportToExcel(BindingList<NhanVienDTO> table)
        {
            // lấy vị trí path templete
            string currentPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            int binIndex = currentPath.LastIndexOf("bin");
            string templatepath = currentPath.Substring(0, binIndex) + "Templates\\NhanVienExcel.xlsx";
            if (!File.Exists(templatepath))
            {
                return;
            }
            // Create a new Excel Application
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false; // Set to true for debugging

            try
            {
                // Open the template workbook
                Excel.Workbook templateWorkbook = excelApp.Workbooks.Open(templatepath);

                // Access the first worksheet
                Excel.Worksheet worksheet = (Excel.Worksheet)templateWorkbook.Sheets[1];

                // chỉnh sửa file 
                // Copy the style from the source row
                if (table.Count > 22)
                {
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
                for (int row = 0; row < table.Count; row++)
                {
                    worksheet.Cells[row + 3, 1].Value = row + 1;
                    worksheet.Cells[row + 3, 2].Value = table[row].Ten;
                    worksheet.Cells[row + 3, 3].Value = table[row].NgaySinh;
                    worksheet.Cells[row + 3, 4].Value = table[row].SDT;
                    worksheet.Cells[row + 3, 5].Value = table[row].Email;
                    worksheet.Cells[row + 3, 6].Value = table[row].Luong;
                }

                // Allow the user to choose where to save the modified file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Save Modified File",
                    FileName = "DanhSachNhanVien.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the modified workbook to the user's chosen location
                    templateWorkbook.SaveAs(saveFileDialog.FileName);

                    Process.Start(saveFileDialog.FileName);
                }

                // Close and release resources
                templateWorkbook.Close(false, Missing.Value, Missing.Value);
                Marshal.ReleaseComObject(templateWorkbook);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Quit Excel application
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
            }
        }

    }
}
