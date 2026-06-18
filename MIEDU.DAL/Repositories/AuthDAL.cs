using System;
using Microsoft.Data.SqlClient;
using MIEDU.Models.Entities;

namespace MIEDU.DAL.Repositories
{
    public class AuthDAL
    {
        // 1. Thêm dấu ? vào kiểu trả về để báo cho trình biên dịch biết hàm này có thể trả về null
        public UserAccount? GetUserByUsername(string username)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                // Truy vấn lấy thông tin User và tên Role
                string query = @"SELECT u.Username, u.PasswordHash, u.MaNhanSu, u.RoleID, u.IsActive, r.RoleName 
                                 FROM Users u
                                 LEFT JOIN Roles r ON u.RoleID = r.RoleID
                                 WHERE u.Username = @Username";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 2. Sử dụng ?? string.Empty và toán tử ! (null-forgiving) để chặn cảnh báo gán null
                            return new UserAccount
                            {
                                Username = reader["Username"].ToString() ?? string.Empty,
                                PasswordHash = reader["PasswordHash"].ToString() ?? string.Empty,
                                MaNhanSu = reader["MaNhanSu"] != DBNull.Value ? reader["MaNhanSu"].ToString()! : string.Empty,
                                RoleID = Convert.ToInt32(reader["RoleID"]),
                                IsActive = Convert.ToBoolean(reader["IsActive"]),
                                RoleName = reader["RoleName"] != DBNull.Value ? reader["RoleName"].ToString()! : string.Empty
                            };
                        }
                    }
                }
            }

            return null; // Không tìm thấy tài khoản
        }
    }
}