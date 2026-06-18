using System;
using System.Text.RegularExpressions;

namespace MIEDU.Models.Entities
{
    // TÍNH TRỪU TƯỢNG (ABSTRACTION): Sử dụng từ khóa 'abstract', lớp này dùng làm bản vẽ chung 
    // cho Giảng viên và Chuyên viên, không thể khởi tạo trực tiếp (new NhanSu() sẽ lỗi).
    public abstract class NhanSu
    {
        // TÍNH ĐÓNG GÓI (ENCAPSULATION): Các field được private, truy xuất qua Properties (get/set).
        private string _email;
        private string _soDienThoai;

        public string MaNhanSu { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string MaKhoa { get; set; }
        public string LoaiNhanSu { get; set; } // 'GiangVien' hoặc 'ChuyenVien'

        // Đóng gói có validation: Kiểm tra email hợp lệ khi set
        public string Email
        {
            get { return _email; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Contains("@"))
                    _email = value;
                else
                    throw new ArgumentException("Email không hợp lệ!");
            }
        }

        public string SoDienThoai
        {
            get { return _soDienThoai; }
            set
            {
                // Validate đơn giản: số điện thoại phải chứa các chữ số
                if (Regex.IsMatch(value ?? "", @"^\d+$"))
                    _soDienThoai = value;
                else
                    throw new ArgumentException("Số điện thoại chỉ được chứa chữ số.");
            }
        }

        // TÍNH ĐA HÌNH (POLYMORPHISM): Khai báo phương thức abstract/virtual 
        // để các lớp con (GiangVien, ChuyenVien) ghi đè (override) logic riêng của chúng.
        public abstract string HienThiThongTin();

        // Cung cấp một phương thức virtual có thể dùng chung hoặc bị ghi đè
        public virtual int TinhGioLam()
        {
            return 40; // Mặc định 40h/tuần cho nhân sự bình thường
        }
    }
}