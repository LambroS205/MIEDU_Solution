using MIEDU.DAL.Repositories;
using MIEDU.Models.Entities;

namespace MIEDU.BLL.Services
{
    public class AuthBLL
    {
        private readonly AuthDAL _authDAL;

        public AuthBLL()
        {
            _authDAL = new AuthDAL();
        }

        // Logic xử lý Đăng nhập
        public UserAccount? Login(string username, string password)
        {
            // 1. Gọi DAL để lấy user theo Username
            var user = _authDAL.GetUserByUsername(username);

            // 2. Xác thực bằng hàm Authenticate (đã định nghĩa ở Models - Tính Đa Hình/Trừu Tượng)
            if (user != null && user.Authenticate(password))
            {
                return user; // Đăng nhập thành công
            }

            return null; // Đăng nhập thất bại (Sai username, password hoặc bị khóa)
        }
    }
}