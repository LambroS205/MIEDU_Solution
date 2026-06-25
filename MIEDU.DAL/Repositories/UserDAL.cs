using System;
using Microsoft.Data.SqlClient;

namespace MIEDU.DAL.Repositories
{
    // DTO (Data Transfer Object) dùng để chứa dữ liệu trả về cho màn hình Profile
    public class UserProfileDTO
    {
        public string HoTen { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public string Khoa { get; set; } = string.Empty;
    }

    public class UserDAL
    {
        public UserProfileDTO GetUserProfile(string maNhanSu)
        {
            var profile = new UserProfileDTO();
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT HoTen, Email, SoDienThoai, MaKhoa FROM NhanSu WHERE MaNhanSu = @ma";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ma", maNhanSu);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            profile.HoTen = reader["HoTen"].ToString() ?? "";
                            profile.Email = reader["Email"].ToString() ?? "";
                            profile.SoDienThoai = reader["SoDienThoai"].ToString() ?? "";
                            profile.Khoa = reader["MaKhoa"].ToString() ?? "Không có";
                        }
                    }
                }
            }
            return profile;
        }

        public bool UpdatePassword(string username, string newPassword)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE Users SET PasswordHash = @newPass WHERE Username = @username";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@newPass", newPassword);
                    cmd.Parameters.AddWithValue("@username", username);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateProfile(string maNhanSu, string email, string sdt)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE NhanSu SET Email = @email, SoDienThoai = @sdt WHERE MaNhanSu = @maNhanSu";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.Parameters.AddWithValue("@maNhanSu", maNhanSu);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}