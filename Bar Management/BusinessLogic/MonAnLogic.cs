using AutoMapper;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Models;
using Bar_Management.TableForm;
using Bar_Management.Tool;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Bar_Management.BusinessLogic {
    public class MonAnLogic {

        public readonly AppDbContext Context;
        private readonly GenericRepository<MonAn> _repo;
        private readonly IMapper _mapper;

        public MonAnLogic() {
            _mapper = AutoMapperProfile.InitializeAutoMapper();
            Context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<MonAn>();
        }

        public bool Delete(MonAn obj) {
            var existedMonan = this.Context.Set<MonAn>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedMonan != null) {
                this.Context.Entry(existedMonan).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Delete(obj);
        }

        public IEnumerable<MonAn> GetAll() {
            return _repo.GetAll().Where(c => !c.IsDelete);
        }

        public bool Insert(MonAn obj) {
            return _repo.Insert(obj);
        }

        public bool Update(MonAn obj) {
            var existedMonan = this.Context.Set<MonAn>().Local.FirstOrDefault(c => c.Id == obj.Id);
            if (existedMonan != null) {
                this.Context.Entry(existedMonan).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            return _repo.Update(obj);
        }

        public List<MonAnDto> TimKiem(string searchKey, int loaiMonAnId=-1, int tinhTrang=-1) {
            IEnumerable<MonAn> monans;
            if (string.IsNullOrEmpty(searchKey)) {
                monans = GetAll();
            } else {
                searchKey = searchKey.ToLower();
                string[] keys = searchKey.Split(' ');
                IEnumerable<LoaiMonAn> loaimonAns = new GenericRepository<LoaiMonAn>().GetAll();

                monans = GetAll().Where(monAn => keys.Any(
                    key => monAn.TenMon.ToLower().Contains(key)
                    || monAn.MoTa.ToLower().ToLower().Contains(key)));
            }
            if (loaiMonAnId != -1) {
                monans = monans.Where(monan => monan.LoaiMonAnId == loaiMonAnId);
            }
            if (tinhTrang != -1) {
                monans = monans.Where(monan => monan.IsAvailable == tinhTrang);
            }
            return monans.Select(monan => _mapper.Map<MonAnDto>(monan)).ToList();
        }

        public void ExportToExcel(BindingList<MonAnDto> table) {
            // lấy vị trí path templete
            string currentPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            int binIndex = currentPath.LastIndexOf("bin");
            string templatepath = currentPath.Substring(0, binIndex)+"Templates\\MonAnExcel.xlsx";
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
                    Excel.Range targetRange = worksheet.Range[worksheet.Cells[26, 1], worksheet.Cells[table.Count+3, 6]];
                    targetRange.PasteSpecial(Excel.XlPasteType.xlPasteFormats);

                    // Clear the clipboard after pasting
                    Clipboard.Clear();
                }
                
                // ghi dữ liệu
                int rowCount = worksheet.Rows.Count;
                for (int row = 0; row < table.Count; row++) {
                    worksheet.Cells[row + 3, 1].Value = row + 1;
                    worksheet.Cells[row + 3, 2].Value = table[row].TenMon;
                    worksheet.Cells[row + 3, 3].Value = table[row].LoaiMonAn.TenLoai;
                    worksheet.Cells[row + 3, 4].Value = table[row].Gia;
                    worksheet.Cells[row + 3, 5].Value = table[row].TrangThai;
                    worksheet.Cells[row + 3, 6].Value = table[row].MoTa;
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
