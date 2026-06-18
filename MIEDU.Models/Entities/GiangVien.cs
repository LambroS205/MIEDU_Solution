using System;

namespace MIEDU.Models.Entities
{
    // TÍNH KẾ THỪA (INHERITANCE): GiangVien thừa kế toàn bộ thuộc tính và phương thức từ NhanSu
    public class GiangVien : NhanSu
    {
        public string HocVi { get; set; }
        public string ChucDanh { get; set; }
        public int SoGioChuan { get; set; }

        public GiangVien()
        {
            LoaiNhanSu = "GiangVien";
        }

        // TÍNH ĐA HÌNH (POLYMORPHISM): Ghi đè phương thức HienThiThongTin của lớp cha
        public override string HienThiThongTin()
        {
            return $"[Giảng Viên] {MaNhanSu} - {HoTen} | Học vị: {HocVi} | Chức danh: {ChucDanh}";
        }

        // TÍNH ĐA HÌNH: Giảng viên tính giờ làm theo số giờ chuẩn quy định
        public override int TinhGioLam()
        {
            return SoGioChuan;
        }
    }
}