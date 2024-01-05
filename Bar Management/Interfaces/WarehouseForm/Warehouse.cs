using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.Interfaces.WarehouseForm
{
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }

        private void Warehouse_Load(object sender, EventArgs e) {

        }

        private void btnThemNL_Click(object sender, EventArgs e) {
            var themNguyenLieuForm = new NguyenLieuF();
            themNguyenLieuForm.ShowDialog();
        }
    }
}
