using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DTO
{
    public class NhapHang
    {
        private string maNH;
        private string maSP;
        private string maNV;
        private int soLuongNhap;
        private DateTime ngayNhap;

        public NhapHang(string maNH, string maSP, string maNV, int soLuongNhap, DateTime ngayNhap)
        {
            this.maNH = maNH;
            this.maSP = maSP;
            this.maNV = maNV;
            this.soLuongNhap = soLuongNhap;
            this.ngayNhap = ngayNhap;
        }

        public NhapHang() { }

        public string MaNH { get { return maNH; } set { maNH = value; } }
        public string MSP { get { return maSP; } set { maSP = value; } }
        public string MANV { get { return maNV; } set { maNV = value; } }

        public int SoLuongNhap { get { return soLuongNhap; } set { soLuongNhap = value; } }
        public DateTime NgayNhap { get { return ngayNhap; } set { ngayNhap = value; } }
    }
}
