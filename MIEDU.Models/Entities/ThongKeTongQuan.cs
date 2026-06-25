using System;

namespace MIEDU.Models.Entities
{
    // Dữ liệu cho 4 thẻ (Cards) trên cùng
    public class ThongKeTongQuan
    {
        public int TongGiangVien { get; set; }
        public int TongChuyenVien { get; set; }
        public int TongMonHoc { get; set; }
        public int TongPhanCong { get; set; }
    }

    // Dữ liệu để vẽ Biểu đồ Tròn
    public class ThongKeHocVi
    {
        public string HocVi { get; set; } = string.Empty;
        public int SoLuong { get; set; }
    }

    // THÊM MỚI: Model cho Bảng xếp hạng Top Giảng viên
    public class TopGiangVien
    {
        public string MaGV { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public int TongTinChi { get; set; }
    }
}