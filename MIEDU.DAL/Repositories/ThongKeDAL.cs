using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MIEDU.Models.Entities;

namespace MIEDU.DAL.Repositories
{
    public class ThongKeDAL
    {
        public ThongKeTongQuan GetThongKeTongQuan()
        {
            var result = new ThongKeTongQuan();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM GiangVien", conn))
                    result.TongGiangVien = (int)cmd.ExecuteScalar();

                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM ChuyenVien", conn))
                    result.TongChuyenVien = (int)cmd.ExecuteScalar();

                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM MonHoc", conn))
                    result.TongMonHoc = (int)cmd.ExecuteScalar();

                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM PhanCong", conn))
                    result.TongPhanCong = (int)cmd.ExecuteScalar();
            }
            return result;
        }

        public List<ThongKeHocVi> GetThongKeTheoHocVi()
        {
            var list = new List<ThongKeHocVi>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT ISNULL(HocVi, N'Chưa cập nhật') AS HocVi, COUNT(*) AS SoLuong 
                                 FROM GiangVien 
                                 GROUP BY HocVi";

                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ThongKeHocVi
                            {
                                HocVi = reader["HocVi"].ToString() ?? "Chưa cập nhật",
                                SoLuong = Convert.ToInt32(reader["SoLuong"])
                            });
                        }
                    }
                }
            }
            return list;
        }

        // THÊM MỚI: Truy vấn SQL phức tạp kết hợp 3 bảng để tính tổng Tín chỉ
        public List<TopGiangVien> GetTopGiangVien()
        {
            var list = new List<TopGiangVien>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT TOP 5 ns.MaNhanSu, ns.HoTen, ISNULL(SUM(mh.SoTinChi), 0) AS TongTinChi
                                 FROM PhanCong pc
                                 INNER JOIN NhanSu ns ON pc.MaGiangVien = ns.MaNhanSu
                                 INNER JOIN MonHoc mh ON pc.MaMon = mh.MaMon
                                 GROUP BY ns.MaNhanSu, ns.HoTen
                                 ORDER BY TongTinChi DESC";

                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new TopGiangVien
                            {
                                MaGV = reader["MaNhanSu"].ToString() ?? string.Empty,
                                HoTen = reader["HoTen"].ToString() ?? string.Empty,
                                TongTinChi = Convert.ToInt32(reader["TongTinChi"])
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}