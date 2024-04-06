using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DTO
{
    public class DonHang
    {
        private string sMADH;
        private string sMaNV;
        private string sSDT;
        private DateTime dNgayLap;
        private float fTongTien;


        public DonHang() { }
        public DonHang(string sMADH, string sMaNV, string sSDT, DateTime dNgayLap, float fTongTien)
        {
            this.sMADH = sMADH;
            this.sMaNV = sMaNV;
            this.sSDT = sSDT;
            this.dNgayLap = dNgayLap;
            this.fTongTien = fTongTien;

        }

        public string MaDH { get { return sMADH; } set { sMADH = value; } }
        public string MaNV { get { return sMaNV; } set { sMADH = value; } }
        public string MaKH { get { return sSDT; } set { sSDT = value; } }
        public DateTime NgayLap { get { return dNgayLap; } set { dNgayLap = value; } }
        public float TongTien { get { return fTongTien; } set { fTongTien = value; } }
    }
}
