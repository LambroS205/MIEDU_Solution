using System;

namespace MIEDU.Models.Entities
{
    public class Khoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string LienHe { get; set; }

        // Navigation property (dùng để map nếu sử dụng ORM hoặc hiển thị trên giao diện)
        public override string ToString()
        {
            return TenKhoa; // Tiện cho việc hiển thị lên ComboBox
        }
    }
}