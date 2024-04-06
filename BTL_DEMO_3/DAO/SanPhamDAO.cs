using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DAO
{
    internal class SanPhamDAO : DataProvider
    {
        public DataSet getSanPham()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return GetDataDTO("proc_dsSanPham", parameters);
        }

        public int themSanPham(string sMaSP, string sTenSP, string sMaNCC, string sHangSP, string sXuatXuSP, int iSoLuong, float fGiaBan)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaSP", sMaSP);
            parameters.Add("@sTenSP", sTenSP);
            parameters.Add("@sMaNCC", sMaNCC);
            parameters.Add("@sHangSP", sHangSP);
            parameters.Add("@sXuatSu", sXuatXuSP);
            parameters.Add("@iSoLuong", iSoLuong);
            parameters.Add("@fGiaBan", fGiaBan);

            return them_sua_xoa("proc_ThemSP", parameters);
        }

        public int suaSanPham(string sMaSP, string sTenSP, string sMaNCC, string sHangSP, string sXuatXuSP, int iSoLuong, float fGiaBan)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaSP", sMaSP);
            parameters.Add("@sTenSP", sTenSP);
            parameters.Add("@sMaNCC", sMaNCC);
            parameters.Add("@sHangSP", sHangSP);
            parameters.Add("@sXuatSu", sXuatXuSP);
            parameters.Add("@iSoLuong", iSoLuong);
            parameters.Add("@fGiaBan", fGiaBan);


            return them_sua_xoa("proc_SuaSP", parameters);
        }

        public int xoaSanPham(string sMaSP)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaSP", sMaSP);

            return them_sua_xoa("proc_XoaSP", parameters);
        }
        public DataSet tim_TenSP(string tenSP)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sTenSP", tenSP);

            return GetDataDTO("proc_TimTenSP", parameters);
        }

        public DataSet tim_MaSP(string sMaSP)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaSP", sMaSP);

            return GetDataDTO("proc_TimMaSP", parameters);
        }
        public DataSet tim_XuatXu(string sMaSP)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sXuatSu", sMaSP);

            return GetDataDTO("proc_TimXuatXuSP", parameters);
        }
        public DataSet tim_HangSanXuat(string sMaSP)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sHangSanXuat", sMaSP);

            return GetDataDTO("proc_TimHangSanXuatSP", parameters);
        }
    }
}
