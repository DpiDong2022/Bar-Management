using Bar_Management.BusinessLogic;
using Bar_Management.DTO;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Bar_Management.OrderForm
{
    public partial class Payment : Form
    {
        private SortableBindingList<MonAnDto> _table;
        private readonly MonAnLogic _logic;
        public Payment()
        {
            InitializeComponent();
        }
        private void LoadTable()
        {
            if (_table != null)
            {
                _table = null;
            }
            _table = new SortableBindingList<MonAnDto>(_logic.GetAll().ToList());
            dataGridView1.DataSource = _table;
            dataGridView1.Columns["Setting"].Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BillList newForm = new BillList();
            newForm.Show();
        }

        private void product2_Load(object sender, EventArgs e)
        {

        }

        private void product3_Load(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
        private void AddCategory()
        {
            DataTable dt = new DataTable();
            LoadTable();
            foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(typeof(MonAnDto)))
            {
                dt.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            // Thêm dữ liệu từ SortableBindingList vào DataTable
            foreach (MonAnDto obj in _table)
            {
                DataRow row = dt.NewRow();
                foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(obj))
                {
                    row[prop.Name] = prop.GetValue(obj) ?? DBNull.Value;
                }
                dt.Rows.Add(row);


            }
            foreach(DataRow row in dt.Rows)
            {
                
            }
        }
    }
}
