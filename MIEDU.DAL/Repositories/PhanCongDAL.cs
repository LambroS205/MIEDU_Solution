using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MIEDU.Models.Entities;

namespace MIEDU.DAL.Repositories
{
    public class PhanCongDAL
    {
        public List<PhanCong> GetAll()
        {
            var list = new List<PhanCong>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                // JOIN để lấy luôn Tên Giảng viên và Tên Môn học đưa lên UI cho đẹp
                string query = @"SELECT pc.ID, pc.MaGiangVien, pc.MaMon, pc.HocKy, pc.NamHoc,
                                        ns.HoTen, mh.TenMon, mh.SoTinChi
                                 FROM PhanCong pc
                                 INNER JOIN NhanSu ns ON pc.MaGiangVien = ns.MaNhanSu
                                 INNER JOIN MonHoc mh ON pc.MaMon = mh.MaMon";

                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new PhanCong
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                MaGiangVien = reader["MaGiangVien"].ToString() ?? string.Empty,
                                MaMon = reader["MaMon"].ToString() ?? string.Empty,
                                HocKy = Convert.ToInt32(reader["HocKy"]),
                                NamHoc = reader["NamHoc"].ToString() ?? string.Empty,
                                // Khởi tạo object map dữ liệu JOIN
                                GiangVienInfo = new GiangVien { HoTen = reader["HoTen"].ToString() ?? string.Empty },
                                MonHocInfo = new MonHoc
                                {
                                    TenMon = reader["TenMon"].ToString() ?? string.Empty,
                                    SoTinChi = Convert.ToInt32(reader["SoTinChi"])
                                }
                            });
                        }
                    }
                }
            }
            return list;
        }

        public bool Add(PhanCong pc)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO PhanCong (MaGiangVien, MaMon, HocKy, NamHoc) VALUES (@MaGV, @MaMon, @HocKy, @NamHoc)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaGV", pc.MaGiangVien);
                    cmd.Parameters.AddWithValue("@MaMon", pc.MaMon);
                    cmd.Parameters.AddWithValue("@HocKy", pc.HocKy);
                    cmd.Parameters.AddWithValue("@NamHoc", pc.NamHoc);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}