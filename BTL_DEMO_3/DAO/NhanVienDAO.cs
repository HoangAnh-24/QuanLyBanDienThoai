using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DAO
{
    internal class NhanVienDAO : DataProvider
    {
        public DataSet getDsNV()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return GetDataDTO("proc_dsNhanVien", parameters);
        }

        public int them_NV(string sMaNV, string sTenNV, bool bGioiTinh, DateTime dNgaySinh, string sDiaChi, string sSoDienThoai, string sEmail)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaNV", sMaNV);
            parameters.Add("@sTenNV", sTenNV);
            parameters.Add("@bGioitinh", bGioiTinh);
            parameters.Add("@dNgaySinh", dNgaySinh);
            parameters.Add("@sDiaChi", sDiaChi);
            parameters.Add("@sSdt", sSoDienThoai);
            parameters.Add("@sEmail", sEmail);
            return them_sua_xoa("proc_ThemNV", parameters);
        }

        public int sua_NV(string sMaNV, string sTenNV, bool bGioiTinh, DateTime dNgaySinh, string sDiaChi, string sSoDienThoai, string sEmail)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaNV", sMaNV);
            parameters.Add("@sTenNV", sTenNV);
            parameters.Add("@bGioitinh", bGioiTinh);
            parameters.Add("@dNgaySinh", dNgaySinh);
            parameters.Add("@sDiaChi", sDiaChi);
            parameters.Add("@sSdt", sSoDienThoai);
            parameters.Add("@sEmail", sEmail);
            return them_sua_xoa("proc_SuaNV", parameters);
        }

        public int xoa_NV(string maNV)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaNV", maNV);

            return them_sua_xoa("proc_XoaNV", parameters);
        }

        public DataSet tim_TenNV(string tenNV)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sTenNV", tenNV);

            return GetDataDTO("proc_TimTenNV", parameters);
        }

        public DataSet tim_MaNV(string MaNV)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaNV", MaNV);

            return GetDataDTO("proc_TimMaNV", parameters);
        }
        public DataSet tim_QueQuan(string QueQuan)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sQueQuan", QueQuan);

            return GetDataDTO("proc_TimQuaQuanNV", parameters);
        }
    }
}
