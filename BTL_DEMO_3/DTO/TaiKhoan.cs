using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DTO
{
    public class TaiKhoan
    {
        private string sMaNV;
        private string sTenDangNhap;
        private string sMatKhau;
        private bool bPhanQuyen;


        public TaiKhoan() { }
        public TaiKhoan(string sMaNV, string sTenDangNhap, string sMatKhau, bool bPhanQuyen)
        {
            this.sMaNV = sMaNV;
            this.sTenDangNhap = sTenDangNhap;
            this.sMatKhau = sMatKhau;
            this.bPhanQuyen = bPhanQuyen;
        }

        public string MaNV { get { return sMaNV; } set { sMaNV = value; } }
        public string TenDangNhap { get { return sTenDangNhap; } set { sTenDangNhap = value; } }
        public string MatKhau { get { return sMatKhau; } set { sMatKhau = value; } }
        public bool PhanQuyen { get { return bPhanQuyen; } set { bPhanQuyen = value; } }


    }
}
