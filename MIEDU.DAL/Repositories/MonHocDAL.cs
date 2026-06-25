using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MIEDU.Models.Entities;

namespace MIEDU.DAL.Repositories
{
    public class MonHocDAL
    {
        public List<MonHoc> GetAll()
        {
            var list = new List<MonHoc>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT MaMon, TenMon, SoTinChi FROM MonHoc";
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new MonHoc
                            {
                                MaMon = reader["MaMon"].ToString() ?? string.Empty,
                                TenMon = reader["TenMon"].ToString() ?? string.Empty,
                                SoTinChi = Convert.ToInt32(reader["SoTinChi"])
                            });
                        }
                    }
                }
            }
            return list;
        }

        public List<MonHoc> Search(string keyword)
        {
            var list = new List<MonHoc>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT MaMon, TenMon, SoTinChi FROM MonHoc WHERE MaMon LIKE @kw OR TenMon LIKE @kw";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new MonHoc
                            {
                                MaMon = reader["MaMon"].ToString() ?? string.Empty,
                                TenMon = reader["TenMon"].ToString() ?? string.Empty,
                                SoTinChi = Convert.ToInt32(reader["SoTinChi"])
                            });
                        }
                    }
                }
            }
            return list;
        }

        public bool CheckExists(string maMon)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT COUNT(1) FROM MonHoc WHERE MaMon = @Ma";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ma", maMon);
                    conn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        public bool Insert(MonHoc mh)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO MonHoc (MaMon, TenMon, SoTinChi) VALUES (@Ma, @Ten, @STC)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ma", mh.MaMon);
                    cmd.Parameters.AddWithValue("@Ten", mh.TenMon);
                    cmd.Parameters.AddWithValue("@STC", mh.SoTinChi);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(MonHoc mh)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE MonHoc SET TenMon = @Ten, SoTinChi = @STC WHERE MaMon = @Ma";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ma", mh.MaMon);
                    cmd.Parameters.AddWithValue("@Ten", mh.TenMon);
                    cmd.Parameters.AddWithValue("@STC", mh.SoTinChi);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(string maMon)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM MonHoc WHERE MaMon = @Ma";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ma", maMon);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}