using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DAO
{
    internal class NhapHangDAO : DataProvider
    {
        public DataSet getDSNhapHang()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return GetDataDTO("proc_dsNhapHang", parameters);
        }

        public int themNhapHang( string maSP, string maNV, int soLuongNhap, DateTime ngayNhap)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
           
            parameters.Add("@sMaSP", maSP);
            parameters.Add("@sMaNV", maNV);
            parameters.Add("@iSoLuong", soLuongNhap);
            parameters.Add("@dNgayNhap", ngayNhap);

            return them_sua_xoa("proc_ThemNH", parameters);
        }

        public int suaNhapHang( string maSP, string maNV, int soLuongNhap, DateTime ngayNhap)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

           
            parameters.Add("@sMaSP", maSP);
            parameters.Add("@sMaNV", maNV);
            parameters.Add("@iSoLuongNhap", soLuongNhap);
            parameters.Add("@dNgayNhap", ngayNhap);

            return them_sua_xoa("proc_SuaNH", parameters);
        }


        public DataSet tim_NgayNhap(DateTime NgayNhap)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@dNgayNhap", NgayNhap);

            return GetDataDTO("proc_NgayNhapNH", parameters);
        }

        public DataSet tim_MaSPNhap(string maSP)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaSP", maSP);

            return GetDataDTO("proc_TimMaSPNhap", parameters);
        }
    }
}
