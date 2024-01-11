using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.HomeForm
{
    public partial class Home : Form
    {
        private Form _parent;
        public Home(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePassword newForm = new ChangePassword();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
            _parent.Close();    
        }
    }
}
