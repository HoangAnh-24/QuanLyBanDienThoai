using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DTO
{
    public class SanPham
    {
        private string sMaSP;
        private string sTenSP;
        private string sMaNCC;
        private string sHangSP;
        private string sXuatXuSP;
        private int iSoLuong;
        private float fGiaBan;


        public SanPham() { }

        public SanPham(string sMaSP, string sTenSP, int iSoLuong, float fGiaBan)
        {
            this.sMaSP = sMaSP;
            this.sTenSP = sTenSP;
            this.iSoLuong = iSoLuong;
            this.fGiaBan = fGiaBan;
        }
        public SanPham(string sMaSP, string sTenSP, string sMaNCC, string sHangSP, string sXuatXuSP, int iSoLuong, float fGiaBan)
        {
            this.sMaSP = sMaSP;
            this.sTenSP = sTenSP;
            this.sMaNCC = sMaNCC;
            this.sHangSP = sHangSP;
            this.sXuatXuSP = sXuatXuSP;
            this.iSoLuong = iSoLuong;
            this.fGiaBan = fGiaBan;
        }

        public string MaSP { get { return sMaSP; } set { sMaSP = value; } }
        public string TenSP { get { return sTenSP; } set { sTenSP = value; } }
        public string MaNCC { get { return sMaNCC; } set { sMaNCC = value; } }
        public string HangSP { get { return sHangSP; } set { sHangSP = value; } }
        public string XuatXuSP { get { return sXuatXuSP; } set { sXuatXuSP = value; } }
        public int SoLuong { get { return iSoLuong; } set { iSoLuong = value; } }
        public float GiaBan { get { return fGiaBan; } set { fGiaBan = value; } }

    }
}
