using System;
using System.Collections.Generic;
using MIEDU.DAL.Repositories;
using MIEDU.Models.Entities;

namespace MIEDU.BLL.Services
{
    public class MonHocBLL
    {
        private readonly MonHocDAL _monHocDAL = new MonHocDAL();

        public List<MonHoc> GetAll()
        {
            return _monHocDAL.GetAll();
        }

        public List<MonHoc> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAll();
            return _monHocDAL.Search(keyword);
        }

        public void Add(MonHoc mh)
        {
            if (string.IsNullOrWhiteSpace(mh.MaMon) || string.IsNullOrWhiteSpace(mh.TenMon))
                throw new ArgumentException("Mã môn và tên môn không được để trống!");

            if (mh.SoTinChi <= 0)
                throw new ArgumentException("Số tín chỉ phải lớn hơn 0!");

            if (_monHocDAL.CheckExists(mh.MaMon))
                throw new ArgumentException("Mã môn học này đã tồn tại!");

            _monHocDAL.Insert(mh);
        }

        public void Update(MonHoc mh)
        {
            if (string.IsNullOrWhiteSpace(mh.TenMon))
                throw new ArgumentException("Tên môn học không được để trống!");

            if (mh.SoTinChi <= 0)
                throw new ArgumentException("Số tín chỉ phải lớn hơn 0!");

            _monHocDAL.Update(mh);
        }

        public void Delete(string maMon)
        {
            if (string.IsNullOrWhiteSpace(maMon))
                throw new ArgumentException("Mã môn không hợp lệ!");

            _monHocDAL.Delete(maMon);
        }
    }
}