using System;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace MIEDU.DAL
{
    public class DatabaseConnection
    {
        private static readonly string ConnectionString;

        // Khối static constructor sẽ chạy 1 lần duy nhất khi class được gọi lần đầu
        static DatabaseConnection()
        {
            // Thiết lập Configuration để đọc từ file appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Thêm kiểm tra Null (Toán tử ??) để giải quyết cảnh báo CS8618 và CS8601
            ConnectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Không tìm thấy chuỗi kết nối 'DefaultConnection' trong cấu hình.");
        }

        // Trả về một đối tượng kết nối mới
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}