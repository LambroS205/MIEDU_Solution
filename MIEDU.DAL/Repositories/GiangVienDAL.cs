using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MIEDU.Models.Entities;

namespace MIEDU.DAL.Repositories
{
    public class GiangVienDAL
    {
        // Hàm phụ trợ giúp tái sử dụng code đọc dữ liệu, tránh lặp lại ở GetAll và Search
        private GiangVien MapReaderToGiangVien(SqlDataReader reader)
        {
            return new GiangVien
            {
                MaNhanSu = reader["MaNhanSu"].ToString() ?? string.Empty,
                HoTen = reader["HoTen"].ToString() ?? string.Empty,
                NgaySinh = reader["NgaySinh"] as DateTime?,
                GioiTinh = reader["GioiTinh"].ToString() ?? string.Empty,
                SoDienThoai = reader["SoDienThoai"] != DBNull.Value ? reader["SoDienThoai"].ToString()! : "0",
                Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString()! : "unknown@miedu.edu.vn",
                MaKhoa = reader["MaKhoa"].ToString() ?? string.Empty,
                HocVi = reader["HocVi"].ToString() ?? string.Empty,
                ChucDanh = reader["ChucDanh"].ToString() ?? string.Empty,
                SoGioChuan = Convert.ToInt32(reader["SoGioChuan"])
            };
        }

        public List<GiangVien> GetAll()
        {
            var list = new List<GiangVien>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT n.MaNhanSu, n.HoTen, n.NgaySinh, n.GioiTinh, n.SoDienThoai, n.Email, n.MaKhoa,
                                        gv.HocVi, gv.ChucDanh, gv.SoGioChuan
                                 FROM NhanSu n
                                 INNER JOIN GiangVien gv ON n.MaNhanSu = gv.MaGiangVien";
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(MapReaderToGiangVien(reader));
                        }
                    }
                }
            }
            return list;
        }

        public List<GiangVien> Search(string keyword)
        {
            var list = new List<GiangVien>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT n.MaNhanSu, n.HoTen, n.NgaySinh, n.GioiTinh, n.SoDienThoai, n.Email, n.MaKhoa,
                                        gv.HocVi, gv.ChucDanh, gv.SoGioChuan
                                 FROM NhanSu n
                                 INNER JOIN GiangVien gv ON n.MaNhanSu = gv.MaGiangVien
                                 WHERE n.HoTen LIKE @Keyword OR n.MaNhanSu LIKE @Keyword";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(MapReaderToGiangVien(reader));
                        }
                    }
                }
            }
            return list;
        }

        public bool CheckExists(string maGV)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT COUNT(1) FROM NhanSu WHERE MaNhanSu = @MaGV";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaGV", maGV);
                    conn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        public bool Insert(GiangVien gv)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlNhanSu = @"INSERT INTO NhanSu (MaNhanSu, HoTen, NgaySinh, GioiTinh, SoDienThoai, Email, MaKhoa, LoaiNhanSu) 
                                             VALUES (@Ma, @Ten, @NgaySinh, @GioiTinh, @SDT, @Email, @Khoa, 'GiangVien')";
                        using (var cmd1 = new SqlCommand(sqlNhanSu, conn, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@Ma", gv.MaNhanSu);
                            cmd1.Parameters.AddWithValue("@Ten", gv.HoTen);
                            cmd1.Parameters.AddWithValue("@NgaySinh", (object?)gv.NgaySinh ?? DBNull.Value);
                            cmd1.Parameters.AddWithValue("@GioiTinh", gv.GioiTinh);
                            cmd1.Parameters.AddWithValue("@SDT", gv.SoDienThoai);
                            cmd1.Parameters.AddWithValue("@Email", gv.Email);
                            cmd1.Parameters.AddWithValue("@Khoa", (object?)gv.MaKhoa ?? DBNull.Value);
                            cmd1.ExecuteNonQuery();
                        }

                        string sqlGiangVien = @"INSERT INTO GiangVien (MaGiangVien, HocVi, ChucDanh, SoGioChuan) 
                                                VALUES (@Ma, @HocVi, @ChucDanh, @SoGioChuan)";
                        using (var cmd2 = new SqlCommand(sqlGiangVien, conn, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@Ma", gv.MaNhanSu);
                            cmd2.Parameters.AddWithValue("@HocVi", gv.HocVi);
                            cmd2.Parameters.AddWithValue("@ChucDanh", gv.ChucDanh);
                            cmd2.Parameters.AddWithValue("@SoGioChuan", gv.SoGioChuan);
                            cmd2.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public bool Update(GiangVien gv)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlNhanSu = @"UPDATE NhanSu SET HoTen = @Ten, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, 
                                             SoDienThoai = @SDT, Email = @Email, MaKhoa = @Khoa WHERE MaNhanSu = @Ma";
                        using (var cmd1 = new SqlCommand(sqlNhanSu, conn, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@Ma", gv.MaNhanSu);
                            cmd1.Parameters.AddWithValue("@Ten", gv.HoTen);
                            cmd1.Parameters.AddWithValue("@NgaySinh", (object?)gv.NgaySinh ?? DBNull.Value);
                            cmd1.Parameters.AddWithValue("@GioiTinh", gv.GioiTinh);
                            cmd1.Parameters.AddWithValue("@SDT", gv.SoDienThoai);
                            cmd1.Parameters.AddWithValue("@Email", gv.Email);
                            cmd1.Parameters.AddWithValue("@Khoa", (object?)gv.MaKhoa ?? DBNull.Value);
                            cmd1.ExecuteNonQuery();
                        }

                        string sqlGiangVien = @"UPDATE GiangVien SET HocVi = @HocVi, ChucDanh = @ChucDanh, SoGioChuan = @SoGioChuan 
                                                WHERE MaGiangVien = @Ma";
                        using (var cmd2 = new SqlCommand(sqlGiangVien, conn, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@Ma", gv.MaNhanSu);
                            cmd2.Parameters.AddWithValue("@HocVi", gv.HocVi);
                            cmd2.Parameters.AddWithValue("@ChucDanh", gv.ChucDanh);
                            cmd2.Parameters.AddWithValue("@SoGioChuan", gv.SoGioChuan);
                            cmd2.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public bool Delete(string maGV)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                // Vì có CASCADE DELETE trong CSDL, xóa NhanSu sẽ tự xóa các bản ghi liên quan ở GiangVien.
                string query = "DELETE FROM NhanSu WHERE MaNhanSu = @Ma";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ma", maGV);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}