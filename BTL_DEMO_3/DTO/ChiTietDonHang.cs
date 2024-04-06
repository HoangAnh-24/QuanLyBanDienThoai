using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DTO
{
    public class ChiTietDonHang
    {
        
        private string sMaDH;
        private string sMaSP;
        private string sTenSP;
        private int iSoLuongMua;
        private float fThanhTien;


        public ChiTietDonHang() { }
        public ChiTietDonHang( string sMaDH, string sMaSP, string sTenSP, int iSoLuongMua, float fThanhTien)
        {
            
            this.sMaDH = sMaDH;
            this.sMaSP = sMaSP;
            this.sTenSP = sTenSP;
            this.iSoLuongMua = iSoLuongMua;
            this.fThanhTien = fThanhTien;
        }

        public ChiTietDonHang( string sMaSP, string sTenSP, int iSoLuongMua, float fThanhTien)
        {

            
            this.sMaSP = sMaSP;
            this.sTenSP = sTenSP;
            this.iSoLuongMua = iSoLuongMua;
            this.fThanhTien = fThanhTien;
        }



        public string TenSP { get { return sTenSP; } set { sTenSP = value; } }
        public string MaDH { get { return sMaDH; } set { sMaDH = value; } }
        public string MaSP { get { return sMaSP; } set { sMaSP = value; } }
        public int SoLuongMua { get { return iSoLuongMua; } set { iSoLuongMua = value; } }
        public float ThanhTien { get { return fThanhTien; } set { fThanhTien = value; } }
    }
}
