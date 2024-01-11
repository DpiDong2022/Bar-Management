using Bar_Management.BusinessLogic;
using Bar_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Bar_Management.RevenueForm
{
    public partial class Revenue : Form
    {
        private int thangSo = 1;
        private DateTime tuanDate = new DateTime(2024,1,1);
        private readonly HoaDonLogic _hoaDonLogic;
        public Revenue()
        {
            InitializeComponent();
            _hoaDonLogic = new HoaDonLogic();
            comboBoxNam.SelectedIndex = 0;
            comboBoxNam.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Revenue_Load(object sender, EventArgs e) {
            FillChartTuan();
            selectThang.Checked = true;
            comboBoxNam.SelectedIndex = 1;
        }

        private void FillChartTuan() {
            chart2.Series["Doanh Thu"].Points.Clear();
            chart2.ChartAreas[0].AxisX.Title = string.Empty;
            chart2.ChartAreas[0].AxisY.Title = string.Empty;
            chart2.Titles.Clear();

            if (comboBoxNam.SelectedItem == null) {
                return;
            }

            int year = int.Parse(comboBoxNam.SelectedItem.ToString());
            int month = tuanDate.Month;
            int day = tuanDate.Day;
            var date = new DateTime(year, month, day);
            IEnumerable<BillDay> billTuan = _hoaDonLogic.LayDuLieuThongKeTuan(date);

            foreach (BillDay billDay in billTuan) {
                chart2.Series["Doanh Thu"].Points.AddXY(billDay.Day, billDay.Revenue);
            }

            chart2.Titles.Add("Thống kê doanh thu");

            foreach (var point in chart2.Series["Doanh Thu"].Points) {
                if (point.YValues[0] == 0) {
                    point.Label = ".";
                } else {
                    point.Label = string.Format("{0:#,##0}", point.YValues[0]);
                }
            }

        }
        private void FillChartThang() {
            chart2.Series["Doanh Thu"].Points.Clear();
            chart2.ChartAreas[0].AxisX.Title = string.Empty;
            chart2.ChartAreas[0].AxisY.Title = string.Empty;
            chart2.Titles.Clear();

            if (comboBoxNam.SelectedItem == null) {
                return;
            }

            int year = int.Parse(comboBoxNam.SelectedItem.ToString());
            IEnumerable<BillMonth> billYear = _hoaDonLogic.LayDuLieuThongKeThang(year, int.Parse(thang.Text.Replace("Thg ", "")));

            // modify the chart
            foreach (BillMonth billThang in billYear) {
                chart2.Series["Doanh Thu"].Points.AddXY(billThang.Month, billThang.Revenue);
            }
            chart2.Titles.Add("Thống kê doanh thu");

            // format total price
            foreach (var point in chart2.Series["Doanh Thu"].Points) {
                if (point.YValues[0] == 0) {
                    point.Label = ".";
                } else {
                    point.Label = string.Format("{0:#,##0}", point.YValues[0]);
                }
               
            }

        }

        private void selectThang_CheckedChanged(object sender, EventArgs e) {
            if(selectThang.Checked) {
                rightTuan.Enabled = false;
                leftTuan.Enabled = false;
                tuan.Enabled = false;
                tuan.BackColor = Color.White;
                FillChartThang();
            } else {
                rightTuan.Enabled = true;
                leftTuan.Enabled = true;
                tuan.Enabled = true;
                tuan.BackColor = Color.DeepSkyBlue;
            }
        }

        private void selectNam_CheckedChanged(object sender, EventArgs e) {
            if (selectTuan.Checked) {
                rightThang.Enabled = false;
                leftThang.Enabled = false;
                thang.Enabled = false;
                thang.BackColor = Color.White;
                FillChartTuan();
            } else {
                rightThang.Enabled = true;
                leftThang.Enabled = true;
                thang.Enabled = true;
                thang.BackColor = Color.DeepSkyBlue;
            }
        }

        private void rightThang_Click(object sender, EventArgs e) {
            if (thangSo == 12) {
                thangSo = 1;
            } else {
                thangSo++;
            }
            thang.Text = $"Thg {thangSo}";
            FillChartThang();
        }

        private void leftThang_Click(object sender, EventArgs e) {
            if (thangSo == 1) {
                thangSo = 12;
            } else {
                thangSo--;
            }
            thang.Text = $"Thg {thangSo}";
            FillChartThang();
        }

        private void leftTuan_Click(object sender, EventArgs e) {
            tuanDate = tuanDate.AddDays(-7);
            tuan.Text = tuanDate.ToString("dd-MM");
            FillChartTuan();
        }

        private void rightTuan_Click(object sender, EventArgs e) {
            tuanDate = tuanDate.AddDays(7);
            tuan.Text = tuanDate.ToString("dd-MM");
            FillChartTuan();
        }
    }
}
