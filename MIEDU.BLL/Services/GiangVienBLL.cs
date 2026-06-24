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

        // Đã sửa: Gọi đúng phương thức GetAll() trong GiangVienDAL
        public List<GiangVien> GetAll()
        {
            return _giangVienDAL.GetAll();
        }

        // Đã sửa: Gọi đúng phương thức GetAll()
        public List<GiangVien> GetSortedByName()
        {
            var list = _giangVienDAL.GetAll();
            return list.OrderBy(gv => gv.HoTen).ToList();
        }

        // Đã sửa: Gọi đúng phương thức GetAll()
        public List<GiangVien> Search(string keyword)
        {
            var list = _giangVienDAL.GetAll();
            if (string.IsNullOrWhiteSpace(keyword)) return list;

            keyword = keyword.ToLower().Trim();

            return list.Where(gv => gv.MaNhanSu.ToLower().Contains(keyword) ||
                                    gv.HoTen.ToLower().Contains(keyword)).ToList();
        }

        // Đã sửa: Gọi đúng phương thức GetAll()
        public List<GiangVien> GetByKhoa(string maKhoa)
        {
            var list = _giangVienDAL.GetAll();
            return list.Where(gv => gv.MaKhoa == maKhoa).ToList();
        }

        public void Add(GiangVien gv)
        {
            if (string.IsNullOrWhiteSpace(gv.MaNhanSu) || string.IsNullOrWhiteSpace(gv.HoTen))
                throw new ArgumentException("Mã nhân sự và Họ tên không được để trống!");

            if (_giangVienDAL.CheckExists(gv.MaNhanSu))
                throw new ArgumentException("Mã giảng viên này đã tồn tại trong hệ thống!");

            _giangVienDAL.Insert(gv);
        }

        public void Update(GiangVien gv)
        {
            if (string.IsNullOrWhiteSpace(gv.MaNhanSu) || string.IsNullOrWhiteSpace(gv.HoTen))
                throw new ArgumentException("Mã nhân sự và Họ tên không được để trống!");

            _giangVienDAL.Update(gv);
        }

        public void Delete(string maNhanSu)
        {
            if (string.IsNullOrWhiteSpace(maNhanSu))
                throw new ArgumentException("Mã nhân sự không hợp lệ!");

            _giangVienDAL.Delete(maNhanSu);
        }
    }
}