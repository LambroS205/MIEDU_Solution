using System;

namespace MIEDU.Models.Entities
{
    // TÍNH KẾ THỪA (INHERITANCE): ChuyenVien thừa kế từ NhanSu
    public class ChuyenVien : NhanSu
    {
        public string PhongBan { get; set; }
        public string ChucVu { get; set; }

        public ChuyenVien()
        {
            LoaiNhanSu = "ChuyenVien";
        }

        // TÍNH ĐA HÌNH (POLYMORPHISM): Ghi đè (Override)
        public override string HienThiThongTin()
        {
            return $"[Chuyên Viên] {MaNhanSu} - {HoTen} | Phòng: {PhongBan} | Chức vụ: {ChucVu}";
        }

        public override int TinhGioLam()
        {
            return 40; // Giờ hành chính mặc định
        }
    }
}