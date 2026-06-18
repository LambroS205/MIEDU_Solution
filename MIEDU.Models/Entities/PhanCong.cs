using System;

namespace MIEDU.Models.Entities
{
    public class PhanCong
    {
        public int ID { get; set; }
        public string MaGiangVien { get; set; }
        public string MaMon { get; set; }
        public int HocKy { get; set; }
        public string NamHoc { get; set; }

        // Navigation properties (Tham chiếu tới Object thực tế giúp UI dễ truy xuất thông tin)
        public GiangVien GiangVienInfo { get; set; }
        public MonHoc MonHocInfo { get; set; }
    }
}