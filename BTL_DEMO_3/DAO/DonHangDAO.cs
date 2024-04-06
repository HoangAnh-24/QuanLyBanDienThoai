using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DAO
{
    internal class DonHangDAO : DataProvider
    {
        public DataSet getDonHang()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return GetDataDTO("proc_dsDonHang", parameters);
        }

        public int LoadDataToDatabase(string sMaSp, int iSoluong)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaSP", sMaSp);
            parameters.Add("@iSoLuong", iSoluong);

            return them_sua_xoa("proc_CapNhapLaiSanPham",parameters);
        }

        public int themDonHang(string sMADH, string sMaNV, string sSDT, DateTime dNgayLap, float fTongTien)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaDH", sMADH);
            parameters.Add("@sMaNV", sMaNV);
            parameters.Add("@sSDT", sSDT);
            parameters.Add("@dNgayLap", dNgayLap);
            parameters.Add("@fTongTien", fTongTien);

            return them_sua_xoa("proc_ThemDH", parameters);
        }


        public DataSet getThongTinSP()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return GetDataDTO("proc_ThongTinSanPham", parameters);
        }
        public int suaDonHang(string sMADH, string sMaNV, string sSDT, DateTime dNgayLap, float fTongTien)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@sMADH", sMADH);
            parameters.Add("@sMaNV", sMaNV);
            parameters.Add("@sSDT", sSDT);
            parameters.Add("@dNgayLap", dNgayLap);
            parameters.Add("@fTongTien", fTongTien);

            return them_sua_xoa("proc_SuaDH", parameters);
        }

        public int xoaDonHang(string maDH)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaDH", maDH);

            return them_sua_xoa("proc_XoaDH", parameters);
        }
        public DataSet tim_MaDH(string sMaDH)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaDH", sMaDH);

            return GetDataDTO("proc_TimMaDH", parameters);
        }

        public DataSet tim_MaNV(string sMaNV)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaNV", sMaNV);

            return GetDataDTO("proc_TimMaNVDH", parameters);
        }
        public DataSet tim_SDT(string sSDT)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sSDT", sSDT);

            return GetDataDTO("proc_TimSDTDH", parameters);
        }

        

        public DataSet Lay_KH(string sdt)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sSDT", sdt);

            return GetDataQuery("Select *from tblKhachHang where sSDT = @sSDT", parameters);
        }

        public DataSet LocKhoang(DateTime dateStart, DateTime dateEnd)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@dNgayBatDau", dateStart);
            parameters.Add("@dNgayKetThuc", dateEnd);

            return GetDataDTO("proc_LocTheoKhoang", parameters);
        }
    }
}
