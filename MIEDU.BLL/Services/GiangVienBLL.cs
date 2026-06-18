using System;
using System.Collections.Generic;
using System.Linq;
using MIEDU.DAL.Repositories;
using MIEDU.Models.Entities;

namespace MIEDU.BLL.Services
{
    public class GiangVienBLL
    {
        private readonly GiangVienDAL _giangVienDAL;

        public GiangVienBLL()
        {
            _giangVienDAL = new GiangVienDAL();
        }

        public List<GiangVien> GetAll()
        {
            return _giangVienDAL.GetAllGiangVien();
        }

        // NGHIỆP VỤ: Sắp xếp danh sách giảng viên tăng dần theo Họ tên (Sử dụng LINQ)
        public List<GiangVien> GetSortedByName()
        {
            var list = _giangVienDAL.GetAllGiangVien();
            return list.OrderBy(gv => gv.HoTen).ToList();
        }

        // NGHIỆP VỤ: Tìm kiếm giảng viên (theo Tên hoặc Mã)
        public List<GiangVien> Search(string keyword)
        {
            var list = _giangVienDAL.GetAllGiangVien();
            if (string.IsNullOrWhiteSpace(keyword)) return list;

            keyword = keyword.ToLower().Trim();

            // Dùng LINQ để lọc dữ liệu trực tiếp trên RAM sau khi kéo từ DB lên
            return list.Where(gv => gv.MaNhanSu.ToLower().Contains(keyword) ||
                                    gv.HoTen.ToLower().Contains(keyword)).ToList();
        }

        // NGHIỆP VỤ: Lọc giảng viên theo Khoa
        public List<GiangVien> GetByKhoa(string maKhoa)
        {
            var list = _giangVienDAL.GetAllGiangVien();
            return list.Where(gv => gv.MaKhoa == maKhoa).ToList();
        }
    }
}