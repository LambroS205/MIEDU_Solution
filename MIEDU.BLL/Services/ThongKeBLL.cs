using System;
using System.Collections.Generic;
using MIEDU.DAL.Repositories;
using MIEDU.Models.Entities;

namespace MIEDU.BLL.Services
{
    public class ThongKeBLL
    {
        private readonly ThongKeDAL _thongKeDAL;

        public ThongKeBLL()
        {
            _thongKeDAL = new ThongKeDAL();
        }

        public ThongKeTongQuan GetTongQuan()
        {
            return _thongKeDAL.GetThongKeTongQuan();
        }

        public List<ThongKeHocVi> GetThongKeHocVi()
        {
            return _thongKeDAL.GetThongKeTheoHocVi();
        }

        public List<TopGiangVien> GetTopGiangVien()
        {
            return _thongKeDAL.GetTopGiangVien();
        }
    }
}