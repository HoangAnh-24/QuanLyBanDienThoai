using BTL_DEMO_3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DAO
{
    internal class TaiKhoanDAO : DataProvider
    {

        public TaiKhoan getTkLogin(string username, string password)
        {
            return checkLoginDTO(username, password); 
        }

        public int suaTTTK(string sMaNV,string tenDangNhap, string sTenNV, bool bGioiTinh, DateTime dNgaySinh, string sDiaChi, string sSoDienThoai, string sEmail)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaNV", sMaNV);
            parameters.Add("@sTenDangNhap",tenDangNhap);
            parameters.Add("@sTenNV", sTenNV);
            parameters.Add("@bGioitinh", bGioiTinh);
            parameters.Add("@dNgaySinh", dNgaySinh);
            parameters.Add("@sDiaChi", sDiaChi);
            parameters.Add("@sSdt", sSoDienThoai);
            parameters.Add("@sEmail", sEmail);
            return them_sua_xoa("proc_suaTTTK", parameters);
        }
        public DataSet getDSTaiKhoan()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return GetDataDTO("proc_dsTaiKhoan", parameters);
        }

        public DataSet getThongTinTK(string maNV)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maNV",maNV);

            return GetDataDTO("proc_ThongTinTK", parameters);
        }

        public int doiMatKhau(string user,string pass)
        {
            Dictionary<string ,Object> parameters = new Dictionary<string ,Object>();
            parameters.Add("@user", user);
            parameters.Add("@pass",pass);

            return them_sua_xoa("proc_DoiMatkhauTK",parameters);
        }

        public int themTaiKhoan(string sMaNV, string sTenDangNhap, string sMatKhau, bool bPhanQuyen)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaNV", sMaNV);
            parameters.Add("@sTenDangNhap", sTenDangNhap);
            parameters.Add("@sMatKhau", sMatKhau);
            parameters.Add("@bQuyen", bPhanQuyen);

            return them_sua_xoa("proc_ThemTK", parameters);
        }

        public int suaTaiKhoan(string sMaNV, string sTenDangNhap, string sMatKhau, bool bPhanQuyen)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@sMaNV", sMaNV);
            parameters.Add("@sTenDangNhap", sTenDangNhap);
            parameters.Add("@sMatKhau", sMatKhau);
            parameters.Add("@bQuyen", bPhanQuyen);

            return them_sua_xoa("proc_SuaTK", parameters);
        }

        public int xoaTaiKhoan(string tenTK)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sTenDangNhap", tenTK);

            return them_sua_xoa("proc_XoaTK", parameters);
        }
        public DataSet tim_TenDangNhap(string tenTK)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sTenDangNhap", tenTK);

            return GetDataDTO("proc_TimTenDangNhap", parameters);
        }

        public DataSet tim_MaN(string maNV)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sMaNV", maNV);

            return GetDataDTO("proc_TimMaNVTK", parameters);
        }
    }
}
