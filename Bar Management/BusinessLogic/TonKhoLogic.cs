using AutoMapper;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Models;
using Bar_Management.Tool;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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
    public class TonKhoLogic {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly GenericRepository<TonKho> _repo;
        private readonly GenericRepository<NhaCungCap> _nhaCungCap;
        private readonly GenericRepository<NguyenLieu> _nguyenLieu;
        private readonly GenericRepository<TrangThaiTonKho> _tranThaiTonKho;

        public TonKhoLogic() {
            _mapper = AutoMapperProfile.InitializeAutoMapper();
            _context = AppDbContextSingleton.Instance;
            _repo = new GenericRepository<TonKho>();
            _nhaCungCap = new GenericRepository<NhaCungCap>();
            _nguyenLieu= new GenericRepository<NguyenLieu>();
            _tranThaiTonKho = new GenericRepository<TrangThaiTonKho>();
        }

        public bool Delete(TonKho obj) {
            return _repo.Delete(obj);
        }

        public IEnumerable<TonKhoDto> GetAll() {
            var nhaCungCaps = _nhaCungCap.GetAll();
            var nguyenLieus = _nguyenLieu.GetAll();
            var trangThais = _tranThaiTonKho.GetAll();

            return _repo.GetAll()
                        .Join(nguyenLieus, 
                        tonKho => tonKho.NguyenLieuId,
                        nguyenLieu => nguyenLieu.Id,
                        (tonkho, nguyenlieu)
                        =>new TonKho(tonkho) {NguyenLieuId=nguyenlieu.Id, NguyenLieu = nguyenlieu})

                        .Join(nhaCungCaps,
                        tonKho => tonKho.NhaCungCapId,
                        nhaCungCap => nhaCungCap.Id,
                        (tonkho, nhaCc) 
                        => new TonKho(tonkho) { NhaCungCapId = nhaCc.Id, NhaCungCap = nhaCc })

                        .Join(trangThais,
                        tonKho => tonKho.TrangThaiId,
                        trangthai => trangthai.Id,
                        (tonkho, trangthai) 
                        => new TonKho(tonkho) { TrangThaiId = trangthai.Id, TrangThai = trangthai })

                        .Select(tk => _mapper.Map<TonKhoDto>(tk));
        }

        public bool Insert(TonKho obj) {
            return _repo.Insert(obj);
        }

        public bool Update(TonKho obj) {
            return _repo.Update(obj);
        }

        public List<TonKhoDto> Loc(int nhaCungCapId = -1, int tinhTrangId = -1, int nguyenLieuId=-1) {
            IEnumerable<TonKhoDto> tonKhos;
            tonKhos = GetAll();

            if (nhaCungCapId != -1) {
                tonKhos = tonKhos.Where(tonKho => tonKho.NhaCungCap.Id == nhaCungCapId);
            }

            if (tinhTrangId != -1) {
                tonKhos = tonKhos.Where(tonKho => tonKho.TrangThai.Id == tinhTrangId);
            } else {

            }

            if (nguyenLieuId != -1) {
                tonKhos = tonKhos.Where(tonKho => tonKho.NguyenLieu.Id == nguyenLieuId);
            }
            return tonKhos.OrderByDescending(c => c.NgayNhap).ToList();
        }

        public void ExportToExcel(SortableBindingList<TonKhoDto> table) {
            // lấy vị trí path templete
            string currentPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            int binIndex = currentPath.LastIndexOf("bin");
            string templatepath = currentPath.Substring(0, binIndex)+"Templates\\TonKhoExcel.xlsx";
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
                    Excel.Range targetRange = worksheet.Range[worksheet.Cells[26, 1], worksheet.Cells[table.Count+3, 9]];
                    targetRange.PasteSpecial(Excel.XlPasteType.xlPasteFormats);

                    // Clear the clipboard after pasting
                    Clipboard.Clear();
                }

                // ghi dữ liệu
                int rowCount = worksheet.Rows.Count;
                for (int row = 0; row < table.Count; row++) {
                    worksheet.Cells[row + 3, 1].Value = row + 1;
                    worksheet.Cells[row + 3, 2].Value = table[row].NguyenLieu.Ten;
                    worksheet.Cells[row + 3, 3].Value = table[row].DonVi;
                    worksheet.Cells[row + 3, 4].Value = table[row].SoLuong;
                    worksheet.Cells[row + 3, 5].Value = table[row].GiaNhap;
                    worksheet.Cells[row + 3, 6].Value = table[row].TrangThai.Ten;
                    worksheet.Cells[row + 3, 7].Value = table[row].NhaCungCap.Ten;
                    worksheet.Cells[row + 3, 8].Value = table[row].NgayNhap.ToString();
                    worksheet.Cells[row + 3, 9].Value = table[row].NgayHetHan.ToString();
                }

                // Allow the user to choose where to save the modified file
                SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Save Modified File",
                    FileName = "TonKhoBaoCao.xlsx"
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
