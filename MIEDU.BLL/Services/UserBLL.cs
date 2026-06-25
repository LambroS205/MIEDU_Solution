using System;
using MIEDU.DAL.Repositories;

namespace MIEDU.BLL.Services
{
    public class UserBLL
    {
        private readonly UserDAL _userDAL;
        private readonly AuthDAL _authDAL;

        public UserBLL()
        {
            _userDAL = new UserDAL();
            _authDAL = new AuthDAL();
        }

        public UserProfileDTO GetProfile(string maNhanSu)
        {
            return _userDAL.GetUserProfile(maNhanSu);
        }

        public bool ChangePassword(string username, string oldPassword, string newPassword, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword))
                throw new ArgumentException("Mật khẩu không được để trống!");

            if (newPassword != confirmPassword)
                throw new ArgumentException("Mật khẩu xác nhận không khớp với mật khẩu mới!");

            // Kiểm tra mật khẩu cũ có đúng không
            var user = _authDAL.GetUserByUsername(username);
            if (user == null || user.PasswordHash != oldPassword)
                throw new ArgumentException("Mật khẩu cũ không chính xác!");

            return _userDAL.UpdatePassword(username, newPassword);
        }

        public bool UpdateProfile(string maNhanSu, string email, string sdt)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                throw new ArgumentException("Email không hợp lệ!");

            if (string.IsNullOrWhiteSpace(sdt))
                throw new ArgumentException("Số điện thoại không được để trống!");

            return _userDAL.UpdateProfile(maNhanSu, email, sdt);
        }
    }
}