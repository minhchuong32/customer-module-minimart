using System;
using System.Windows.Forms;
using MiniMart.GUI;   // thêm namespace GUI để gọi Form1

namespace MiniMart
{
    static class Program
    {
        /// <summary>
        /// Điểm khởi đầu của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // chạy Form1 trong GUI
            Application.Run(new Form1());
        }
    }
}
