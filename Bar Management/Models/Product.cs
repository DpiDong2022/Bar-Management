using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.Models
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }
        public event EventHandler onSelect = null;
        public int Id { get; set; }
        public string PPrice { get; set; }
        public string PCatergory { get; set; }
        public string PName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        public Image PImage
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }

        private void txtImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void txtImage_Click_1(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}