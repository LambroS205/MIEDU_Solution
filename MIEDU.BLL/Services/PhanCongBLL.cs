using System;
using System.Collections.Generic;
using MIEDU.DAL.Repositories;
using MIEDU.Models.Entities;

namespace MIEDU.BLL.Services
{
    public class PhanCongBLL
    {
        private readonly PhanCongDAL _phanCongDAL = new PhanCongDAL();

        public List<PhanCong> GetAll()
        {
            return _phanCongDAL.GetAll();
        }

        public bool AddPhanCong(string maGV, string maMon, int hocKy, string namHoc)
        {
            if (string.IsNullOrWhiteSpace(maGV) || string.IsNullOrWhiteSpace(maMon))
            {
                throw new ArgumentException("Vui lòng chọn đầy đủ Giảng viên và Môn học.");
            }

            if (string.IsNullOrWhiteSpace(namHoc))
            {
                throw new ArgumentException("Năm học không được để trống.");
            }

            var pc = new PhanCong
            {
                MaGiangVien = maGV,
                MaMon = maMon,
                HocKy = hocKy,
                NamHoc = namHoc
            };

            return _phanCongDAL.Add(pc);
        }
    }
}