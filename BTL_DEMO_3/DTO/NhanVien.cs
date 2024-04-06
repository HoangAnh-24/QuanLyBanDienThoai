using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DTO
{
    public class NhanVien
    {
        private string sMaNV;
        private string sTenNV;
        private bool bGioiTinh;
        private DateTime dNgaySinh;
        private string sDiaChi;
        private string sSoDienThoai;

        private string sEmail;


        public NhanVien() { }
        public NhanVien(string sMaNV, string sTenNV, bool bGioiTinh, DateTime dNgaySinh, string sDiaChi, string sSoDienThoai, string sEmail)
        {
            this.sMaNV = sMaNV;
            this.sTenNV = sTenNV;
            this.bGioiTinh = bGioiTinh;
            this.dNgaySinh = dNgaySinh;
            this.sDiaChi = sDiaChi;
            this.sSoDienThoai = sSoDienThoai;
            this.sEmail = sEmail;
        }

        public string MaNV { get { return sMaNV; } set { sMaNV = value; } }
        public string TenNV { get { return sTenNV; } set { sTenNV = value; } }

        public bool GioiTinh { get { return bGioiTinh; } set { bGioiTinh = value; } }

        public DateTime NgaySinh { get { return dNgaySinh; } set { dNgaySinh = value; } }
        public string DiaChi { get { return sDiaChi; } set { sDiaChi = value; } }
        public string SoDienThoai { get { return sSoDienThoai; } set { sSoDienThoai = value; } }
        public string Email { get { return sEmail; } set { sEmail = value; } }
    }
}
