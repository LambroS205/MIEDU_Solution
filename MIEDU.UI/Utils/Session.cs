using System;
using MIEDU.Models.Entities;

namespace MIEDU.UI.Utils
{
    // Lớp static lưu trữ thông tin User đang đăng nhập vào hệ thống
    public static class Session
    {
        public static UserAccount ?CurrentUser { get; set; }

        public static void Logout()
        {
            CurrentUser = null;
        }

        public static bool IsLoggedIn => CurrentUser != null;
    }
}