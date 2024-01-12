using Bar_Management.BusinessLogic;
using Bar_Management.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.OrderForm {
    public partial class Order: Form {
        public string NhanVienID { get; set; }
        private readonly BanLogic _logicBan;

        public Order() {

            InitializeComponent();
            _logicBan = new BanLogic();
        }

        private void Order_Load(object sender, EventArgs e) {
            LoadBtn();
        }

  
        public void LoadBtn() { 
            for (int i = 1; i <= 25; i++) {
                // Đặt tên cho nút theo thứ tự
                Button btn = this.Controls.Find("btnBan" + i.ToString(), true).FirstOrDefault() as Button;

                // Gán sự kiện Click chung cho mọi nút
                btn.Click += CommonButtonClick;
                var ban = _logicBan.GetAll().ToList().FirstOrDefault(x=> x.Id == i);
                if (ban.TrangThaiId == 2) {
                    btn.BackColor = Color.Red;
                } else {
                    btn.BackColor = Color.Green;
                }

            }
        }

        private void CommonButtonClick(object sender, EventArgs e) {
            Button clickedButton = sender as Button;
            if (clickedButton != null) {
                int num = int.Parse(clickedButton.Text.Split(' ')[1]);
                int buttonNumber = num;

                // Lấy số từ tên nút
                OpenNewForm(buttonNumber);

            }
        }

        private void OpenNewForm(int buttonNumber) {
            // Tạo form mới và chuyển thông tin nếu cần
            Payment newForm = new Payment(buttonNumber,this);
            //newForm.TenBan = buttonNumber.ToString();
            newForm.NhanVienID = NhanVienID;

            newForm.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}