using Bar_Management.BusinessLogic;
using Bar_Management.DAO;
using Bar_Management.Models;
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
    public partial class Category : Form
    {
        private readonly LoaiMonAnLogic _logic;
        private readonly BindingList<LoaiMonAn> _table;
        public Category()
        {
            InitializeComponent();
            _logic = new LoaiMonAnLogic();
            _table = new BindingList<LoaiMonAn>(_logic.GetAll().ToList());

            dataGridView1.DataSource = _table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryAdd newForm = new CategoryAdd();
            newForm.ShowDialog();

            if (newForm.DialogResult == DialogResult.OK) {
                LoaiMonAn loaiMonAn = new LoaiMonAn(){TenLoai= newForm.TenLoaiMonAn };
                _logic.Insert(loaiMonAn);
                _table.Insert(0, loaiMonAn);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void Category_Load(object sender, EventArgs e) {

        }
    }
}
