using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DAO
{
    internal class KhachHangDAO : DataProvider
    {
        public DataSet getKhachHang()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return GetDataDTO("proc_dsKhachHang", parameters);
        }

        public int themKhachHang(string sTenKH, string sDiaChi, string sSoDienThoai)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sTenKH", sTenKH);
            parameters.Add("@sDiaChi", sDiaChi);
            parameters.Add("@sSDT", sSoDienThoai);

            return them_sua_xoa("proc_ThemKH", parameters);
        }

        public int suaKhachHang(string sTenKH, string sDiaChi, string sSoDienThoai)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sTenKH", sTenKH);
            parameters.Add("@sDiaChi", sDiaChi);
            parameters.Add("@sSDT", sSoDienThoai);

            return them_sua_xoa("proc_SuaKH", parameters);
        }

        public int xoaKhachHang(string sSoDienThoai)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sSDT", sSoDienThoai);

            return them_sua_xoa("proc_XoaKH", parameters);
        }
        public DataSet tim_TenKH(string tenKH)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sTenKH", tenKH);

            return GetDataDTO("proc_TimTenKH", parameters);
        }

        public DataSet tim_SDTKH(string sSoDienThoai)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sSDT", sSoDienThoai);

            return GetDataDTO("proc_TimSDTKH", parameters);
        }
    }
}
