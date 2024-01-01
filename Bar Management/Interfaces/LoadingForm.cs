using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.Interfaces {
    public partial class LoadingForm: Form {
        public LoadingForm(int second) {
            InitializeComponent();
            timer1.Interval = second*10;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void LoadingForm_Load(object sender, EventArgs e) {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (progressBar1.Value < 100) {
                progressBar1.Value += 1;
            } else {
                progressBar1.Value = 0;
                timer1.Stop();
                this.Close();
            }
        }
    }
}
