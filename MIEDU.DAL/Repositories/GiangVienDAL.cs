using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MIEDU.Models.Entities;

namespace MIEDU.DAL.Repositories
{
    public class GiangVienDAL
    {
        // Lấy toàn bộ danh sách Giảng viên bằng cách JOIN 2 bảng NhanSu và GiangVien
        public List<GiangVien> GetAllGiangVien()
        {
            var list = new List<GiangVien>();

            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT ns.MaNhanSu, ns.HoTen, ns.NgaySinh, ns.GioiTinh, 
                                        ns.SoDienThoai, ns.Email, ns.MaKhoa, 
                                        gv.HocVi, gv.ChucDanh, gv.SoGioChuan
                                 FROM NhanSu ns
                                 INNER JOIN GiangVien gv ON ns.MaNhanSu = gv.MaGiangVien";

                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Đọc dữ liệu ra biến tạm để kiểm tra trước khi đưa qua Validation
                            string phoneDb = reader["SoDienThoai"] != DBNull.Value ? reader["SoDienThoai"].ToString()! : string.Empty;
                            string emailDb = reader["Email"] != DBNull.Value ? reader["Email"].ToString()! : string.Empty;

                            list.Add(new GiangVien
                            {
                                MaNhanSu = reader["MaNhanSu"].ToString() ?? string.Empty,
                                HoTen = reader["HoTen"].ToString() ?? string.Empty,
                                NgaySinh = reader["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(reader["NgaySinh"]) : (DateTime?)null,
                                GioiTinh = reader["GioiTinh"].ToString() ?? string.Empty,

                                // Gán giá trị mặc định hợp lệ nếu rỗng để không bị Exception ở Setter class NhanSu
                                SoDienThoai = !string.IsNullOrEmpty(phoneDb) ? phoneDb : "0",
                                Email = !string.IsNullOrEmpty(emailDb) && emailDb.Contains("@") ? emailDb : "unknown@miedu.edu.vn",

                                MaKhoa = reader["MaKhoa"].ToString() ?? string.Empty,
                                HocVi = reader["HocVi"].ToString() ?? string.Empty,
                                ChucDanh = reader["ChucDanh"].ToString() ?? string.Empty,
                                SoGioChuan = reader["SoGioChuan"] != DBNull.Value ? Convert.ToInt32(reader["SoGioChuan"]) : 0
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}