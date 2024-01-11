﻿using Bar_Management.FoodForm;
using Bar_Management.Interfaces;
using Bar_Management.Tool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //tạo dữ liệu khởi tạo cho bảng trạng thái tồn kho, khách hàng, nguyên liệu
            GenerateData.Render();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            
        }
    }
}
