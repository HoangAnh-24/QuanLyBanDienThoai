using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DTO
{
    public class KhachHang
    {

        private string sTenKH;
        private string sDiaChi;
        private string sSoDienThoai;


        public KhachHang() { }
        public KhachHang(string sTenKH, string sDiaChi, string sSoDienThoai)
        {

            this.sTenKH = sTenKH;
            this.sDiaChi = sDiaChi;
            this.sSoDienThoai = sSoDienThoai;

        }


        public string TenKH { get { return sTenKH; } set { sTenKH = value; } }
        public string DiaChi { get { return sDiaChi; } set { sDiaChi = value; } }
        public string SoDienThoai { get { return sSoDienThoai; } set { sSoDienThoai = value; } }
    }
}
