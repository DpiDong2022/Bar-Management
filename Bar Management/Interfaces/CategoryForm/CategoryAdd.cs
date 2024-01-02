using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.CategoryForm
{
    public partial class CategoryAdd : Form
    {
        public string TenLoaiMonAn;
        public CategoryAdd()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox1.Text)) {
                errorName.SetError(textBox1, "Tên loại món ăn không để trống");
 
            } else {
                errorName.Clear();
                TenLoaiMonAn = textBox1.Text.Trim();
                this.DialogResult = DialogResult.OK; return;
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
