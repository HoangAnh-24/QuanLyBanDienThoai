using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DAO
{
    internal class NhaCungCapDAO : DataProvider
    {

        public DataSet getNhaCungCup()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return GetDataDTO("proc_dsNhaCungCap", parameters);
        }

        public int themNhaCungCap(string sMaNCC, string sTenNCC, string sHotline, string sEmail)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaNCC", sMaNCC);
            parameters.Add("@sTenNCC", sTenNCC);
            parameters.Add("@sHotline", sHotline);
            parameters.Add("@sEmail", sEmail);

            return them_sua_xoa("proc_ThemNCC", parameters);
        }

        public int suaNhaCungCap(string sMaNCC, string sTenNCC, string sHotline, string sEmail)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@sMaNCC", sMaNCC);
            parameters.Add("@sTenNCC", sTenNCC);
            parameters.Add("@sHotline", sHotline);
            parameters.Add("@sEmail", sEmail);

            return them_sua_xoa("proc_SuaNCC", parameters);
        }

        public int xoaNhaCungCap(string maNCC)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaNCC", maNCC);

            return them_sua_xoa("proc_XoaNCC", parameters);
        }
        public DataSet tim_TenNCC(string tenNCC)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sTenNCC", tenNCC);

            return GetDataDTO("proc_TimTenNCC", parameters);
        }

        public DataSet tim_MaNCC(string maNCC)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaNCC", maNCC);

            return GetDataDTO("proc_TimMaNCC", parameters);
        }

        public DataSet tim_Hotline(string maNCC)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sHotline", maNCC);

            return GetDataDTO("proc_TimHotline", parameters);
        }

        public DataSet tim_Email(string maNCC)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sEmail", maNCC);

            return GetDataDTO("proc_TimEmail", parameters);
        }
    }
}
