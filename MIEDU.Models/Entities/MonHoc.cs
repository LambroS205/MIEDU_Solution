using System;

namespace MIEDU.Models.Entities
{
    public class MonHoc
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoTinChi { get; set; }

        public override string ToString()
        {
            return $"{TenMon} ({SoTinChi} TC)";
        }
    }
}