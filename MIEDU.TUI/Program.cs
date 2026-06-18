using System;
using Terminal.Gui.App;
using MIEDU.TUI.Views;

namespace MIEDU.TUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lệnh này bắt buộc phải gọi trước tiên để khởi tạo màn hình Console (v2 dùng IApplication)
            using IApplication app = Application.Create();
            app.Init();

            // Chạy Window Đăng nhập đầu tiên
            using var loginWindow = new LoginWindow(app);
            app.Run(loginWindow);

            // Trong v2, khối using sẽ tự động dọn dẹp (Dispose) và gọi Shutdown.
        }
    }
}