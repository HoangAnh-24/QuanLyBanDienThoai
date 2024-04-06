using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DAO
{
    internal class ChiTietDonHangDAO : DataProvider
    {
        public DataSet getChiTietDonHang()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return GetDataDTO("proc_dsChiTietDonHang", parameters);
        }

        public int themChiTietDonHang(string sMaDH, string sTenSP, string sMaSP, int iSoLuongMua, float fThanhTien)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaDH", sMaDH);
            parameters.Add("@sMaSP", sMaSP);
            parameters.Add("@sTenSP", sTenSP);
            parameters.Add("@iSoLuongMua", iSoLuongMua);
            parameters.Add("@fThanhTien", fThanhTien);


            return them_sua_xoa("proc_ThemCTDH", parameters);
        }

        public int suaChiTietDonHang(string sMaDH, string sTenSP, string sMaSP, int iSoLuongMua, float fThanhTien)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@sMaDH", sMaDH);
            parameters.Add("@sMaSP", sMaSP);
            parameters.Add("@sTenSP", sTenSP);
            parameters.Add("@iSoLuongMua", iSoLuongMua);
            parameters.Add("@fThanhTien", fThanhTien);


            return them_sua_xoa("proc_SuaCTDH", parameters);
        }

        public int xoaChiTietDonHang(string maDH)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaDH", maDH);

            return them_sua_xoa("proc_XoaCTDH", parameters);
        }
        public DataSet tim_MaCTDH(string sMaCTDH)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaCTDH", sMaCTDH);

            return GetDataDTO("proc_TimMaCTDH", parameters);
        }

        public DataSet tim_MaSP(string sMaNV)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaNV", sMaNV);

            return GetDataDTO("proc_TimMaNV", parameters);
        }
    }
}
