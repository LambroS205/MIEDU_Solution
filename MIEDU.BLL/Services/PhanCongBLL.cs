using System;
using System.Collections.Generic;
using System.Linq;
using MIEDU.DAL.Repositories;
using MIEDU.Models.Entities;

namespace MIEDU.BLL.Services
{
    public class PhanCongBLL
    {
        private readonly PhanCongDAL _phanCongDAL;
        private readonly GiangVienDAL _giangVienDAL;
        private readonly MonHocDAL _monHocDAL;

        public PhanCongBLL()
        {
            _phanCongDAL = new PhanCongDAL();
            _giangVienDAL = new GiangVienDAL();
            _monHocDAL = new MonHocDAL();
        }

        public List<PhanCong> GetAll()
        {
            return _phanCongDAL.GetAll();
        }

        public bool AddPhanCong(string maGV, string maMon, int hocKy, string namHoc)
        {
            // 1. Kiểm tra dữ liệu đầu vào rỗng
            if (string.IsNullOrWhiteSpace(maGV) || string.IsNullOrWhiteSpace(maMon))
            {
                throw new ArgumentException("Vui lòng chọn đầy đủ Giảng viên và Môn học.");
            }

            if (string.IsNullOrWhiteSpace(namHoc))
            {
                throw new ArgumentException("Năm học không được để trống.");
            }

            // Lấy thông tin Giảng viên, Môn học và danh sách phân công hiện tại từ DB
            var giangVien = _giangVienDAL.GetAll().FirstOrDefault(g => g.MaNhanSu == maGV);
            var monHoc = _monHocDAL.GetAll().FirstOrDefault(m => m.MaMon == maMon);
            var danhSachPhanCong = _phanCongDAL.GetAll();

            if (giangVien == null) throw new ArgumentException("Giảng viên không tồn tại trong hệ thống.");
            if (monHoc == null) throw new ArgumentException("Môn học không tồn tại trong hệ thống.");

            // 2. QUY TẮC 1: Kiểm tra trùng lặp phân công (Cùng GV, Môn, Kỳ, Năm)
            bool daPhanCong = danhSachPhanCong.Any(pc =>
                pc.MaGiangVien == maGV &&
                pc.MaMon == maMon &&
                pc.HocKy == hocKy &&
                pc.NamHoc == namHoc);

            if (daPhanCong)
            {
                throw new ArgumentException($"Giảng viên '{giangVien.HoTen}' đã được phân công dạy môn '{monHoc.TenMon}' trong Học kỳ {hocKy} ({namHoc}).");
            }

            // 3. QUY TẮC 2: Kiểm tra không vượt quá số Giờ Chuẩn trong năm học
            // Tính tổng tín chỉ đã được phân công trong NĂM HỌC HIỆN TẠI
            int tongTinChiDaPhan = danhSachPhanCong
                .Where(pc => pc.MaGiangVien == maGV && pc.NamHoc == namHoc)
                .Sum(pc => pc.MonHocInfo?.SoTinChi ?? 0);

            // Quy đổi: 1 Tín chỉ = 15 giờ chuẩn (tiết)
            int soGioDaPhan = tongTinChiDaPhan * 15;
            int soGioMonMoi = monHoc.SoTinChi * 15;
            int tongGioDuKien = soGioDaPhan + soGioMonMoi;

            if (tongGioDuKien > giangVien.SoGioChuan)
            {
                throw new ArgumentException(
                    $"Vượt quá số giờ chuẩn của giảng viên!\n\n" +
                    $"- Giới hạn giờ chuẩn: {giangVien.SoGioChuan} giờ.\n" +
                    $"- Đã phân công: {soGioDaPhan} giờ.\n" +
                    $"- Môn '{monHoc.TenMon}' tốn thêm: {soGioMonMoi} giờ.\n\n" +
                    $"Tổng dự kiến: {tongGioDuKien} > {giangVien.SoGioChuan}. Vui lòng phân công giảng viên khác!");
            }

            // Nếu thỏa mãn mọi quy tắc -> Khởi tạo Object và thêm vào CSDL
            var pcNew = new PhanCong
            {
                MaGiangVien = maGV,
                MaMon = maMon,
                HocKy = hocKy,
                NamHoc = namHoc
            };

            return _phanCongDAL.Add(pcNew);
        }
    }
}