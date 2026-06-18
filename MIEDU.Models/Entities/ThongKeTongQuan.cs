using System;

namespace MIEDU.Models.Entities
{
    // Model chứa dữ liệu tổng quan cho các thẻ (Cards) trên Dashboard
    public class ThongKeTongQuan
    {
        public int TongGiangVien { get; set; }
        public int TongChuyenVien { get; set; }
        public int TongMonHoc { get; set; }
        public int TongPhanCong { get; set; }
    }

    // Model chứa dữ liệu gom nhóm để đưa lên DataGridView hoặc Biểu đồ
    public class ThongKeHocVi
    {
        public string HocVi { get; set; } = string.Empty;
        public int SoLuong { get; set; }
    }
}