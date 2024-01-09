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
        public int PPrice { get; set; }
        public string PCategory { get; set; }
        public string PName
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }
        public string PImage
        {
            get { return txtImage.Text; }
            set { txtImage.Text = value; }
        }

        private void txtImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
