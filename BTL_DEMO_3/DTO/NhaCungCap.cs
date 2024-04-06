using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_DEMO_3.DTO
{
    public class NhaCungCap
    {
        private string sMaNCC;
        private string sTenNCC;
        private string sHotline;
        private string sEmail;


        public NhaCungCap() { }
        public NhaCungCap(string sMaNCC, string sTenNCC, string sHotline, string sEmail)
        {
            this.sMaNCC = sMaNCC;
            this.sTenNCC = sTenNCC;
            this.sHotline = sHotline;
            this.sEmail = sEmail;
        }

        public string MaNCC { get { return sMaNCC; } set { sMaNCC = value; } }
        public string TenNCC { get { return sTenNCC; } set { sTenNCC = value; } }
        public string Hotline { get { return sHotline; } set { sHotline = value; } }
        public string Email { get { return sEmail; } set { sEmail = value; } }
    }
}
