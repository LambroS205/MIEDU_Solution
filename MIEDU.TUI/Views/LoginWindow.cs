using System;
using Terminal.Gui.App;
using Terminal.Gui.ViewBase;
using Terminal.Gui.Views;
using MIEDU.BLL.Services;
using MIEDU.Models.Entities;

namespace MIEDU.TUI.Views
{
    public class LoginWindow : Window
    {
        private AuthBLL _authBLL;
        private IApplication _app;

        // Lưu trữ UserAccount đang đăng nhập để các Window khác có thể truy cập
        public static UserAccount ?CurrentUser { get; private set; }

        public LoginWindow(IApplication app) : base()
        {
            _app = app;
            Title = "HỆ THỐNG ĐẠI HỌC MIEDU - ĐĂNG NHẬP";
            _authBLL = new AuthBLL();

            // Tạo các Label và TextField (Căn giữa màn hình bằng Pos.Center)
            var lblUsername = new Label { Text = "Tên đăng nhập:", X = Pos.Center() - 20, Y = Pos.Center() - 2 };
            var txtUsername = new TextField { Text = "", X = Pos.Right(lblUsername) + 1, Y = Pos.Center() - 2, Width = 20 };

            var lblPassword = new Label { Text = "Mật khẩu:", X = Pos.Center() - 20, Y = Pos.Center() };

            // Secret = true để hiển thị dấu sao (*) thay vì text thật
            var txtPassword = new TextField { Text = "", X = Pos.Right(lblUsername) + 1, Y = Pos.Center(), Width = 20, Secret = true };

            // Trong v2, is_default trở thành property IsDefault
            var btnLogin = new Button { Text = "Đăng nhập", X = Pos.Center() - 10, Y = Pos.Center() + 2, IsDefault = true };
            var btnExit = new Button { Text = "Thoát", X = Pos.Center() + 5, Y = Pos.Center() + 2 };

            // Sự kiện Clicked đổi thành Accepting trong Terminal.Gui v2
            btnLogin.Accepting += (s, e) => {
                // Gọi tới Business Logic Layer (BLL) để xử lý logic đăng nhập
                var user = _authBLL.Login(txtUsername.Text.ToString(), txtPassword.Text.ToString());

                if (user != null)
                {
                    CurrentUser = user; // Lưu thông tin người dùng

                    // Dừng Window Đăng nhập và Mở Window Chính
                    _app.RequestStop();
                    using var mainWindow = new MainWindow(_app);
                    _app.Run(mainWindow);
                }
                else
                {
                    // Hiển thị hộp thoại báo lỗi (Truyền instance _app vào đầu tiên theo chuẩn v2)
                    MessageBox.ErrorQuery(_app, "Lỗi", "Sai tài khoản hoặc mật khẩu!", "OK");
                }
            };

            btnExit.Accepting += (s, e) => {
                _app.RequestStop(); // Thoát app
            };

            Add(lblUsername, txtUsername, lblPassword, txtPassword, btnLogin, btnExit);
        }
    }
}