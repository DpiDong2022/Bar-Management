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
        private readonly GenericRepository<LoaiMonAn> _repo;
        private readonly BindingList<LoaiMonAn> _table;
        public Category()
        {
            InitializeComponent();
            _repo = new GenericRepository<LoaiMonAn>();
            _table = new BindingList<LoaiMonAn>(_repo.GetAll().ToList());

            dataGridView1.DataSource = _table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryAdd newForm = new CategoryAdd();
            newForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void Category_Load(object sender, EventArgs e) {

        }
    }
}
