using System;
using MIEDU.Models.Interfaces;

namespace MIEDU.Models.Entities
{
    // Kế thừa Interface để áp đặt cấu trúc
    public class UserAccount : IUser
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string MaNhanSu { get; set; }
        public int RoleID { get; set; }
        public bool IsActive { get; set; }

        // Navigation Properties
        public NhanSu NhanSuInfo { get; set; }
        public string RoleName { get; set; }

        // TÍNH ĐA HÌNH & TRỪU TƯỢNG: Triển khai các hàm của interface IUser
        public string GetRoleName()
        {
            return RoleName ?? "Unknown";
        }

        public bool Authenticate(string password)
        {
            // Trong thực tế, đây sẽ là hàm so sánh Hash.
            // Ở ví dụ này, để cho đơn giản ta so sánh chuỗi.
            return PasswordHash == password && IsActive;
        }
    }
}