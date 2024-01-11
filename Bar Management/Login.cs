using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bar_Management.BusinessLogic;
using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.MainForm;
using Bar_Management.Models;

namespace Bar_Management
{
    public partial class Login : Form
    {
        private readonly TaiKhoanLogic _logic;
        public Login()
        {
            _logic = new TaiKhoanLogic();
            InitializeComponent();
        }
        public TaiKhoanDTO CheckTaiKhoan (string username, string password)
        {
            var checkTK = _logic.GetAll().ToList().FirstOrDefault(x => x.Ten.ToString()== username && x.MatKhau.ToString() == password);
            if (checkTK == null)
            {
                return null;
            }
            return checkTK;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO check = CheckTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text);
            if (check == null)
            {
                MessageBox.Show("Sai tài khoản hoặc maath khẩu ! Vui lòng nhập lại ");
                return;
            }
            if (check.Role.ToString() == "Admin")
            {
                this.Hide();
                Main newForm = new Main();
                //newForm.TaiKhoanId = check.Id.ToString();
                Singleton.TaiKhoanId = check.Id;
                newForm.Show();
            }
            else
            {
                this.Hide();
                Main newForm = new Main();
                //newForm.TaiKhoanId = check.Id.ToString();
                Singleton.TaiKhoanId = check.Id;
                newForm.Show();
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
