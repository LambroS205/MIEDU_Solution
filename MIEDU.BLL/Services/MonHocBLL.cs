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
    }
}