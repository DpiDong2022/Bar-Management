using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.Interfaces.WarehouseForm {
    public partial class NguyenLieuF: Form {
        public NguyenLieuF() {
            InitializeComponent();
            tboxTenNguyenLieu.Focus();
        }

        private void tboxTenNguyenLieu_TextChanged(object sender, EventArgs e) {

        }

        private void tboxTenNguyenLieu_Click(object sender, EventArgs e) {
            tboxTenNguyenLieu.Text = string.Empty;
        }
    }
}
