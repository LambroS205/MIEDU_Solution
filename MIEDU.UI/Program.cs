using System;
using System.Windows.Forms;
using MIEDU.UI.Forms;

namespace MIEDU.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form Đăng nhập đầu tiên
            Application.Run(new LoginForm());
        }
    }
}