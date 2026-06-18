using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MIEDU.Models.Entities;

namespace MIEDU.DAL.Repositories
{
    public class ThongKeDAL
    {
        // Hàm lấy số liệu tổng quan (Tổng GV, CV, Môn, Phân công)
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

        // Hàm nhóm số lượng giảng viên theo Học vị (GROUP BY)
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
    }
}