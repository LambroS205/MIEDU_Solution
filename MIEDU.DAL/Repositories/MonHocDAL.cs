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
    }
}