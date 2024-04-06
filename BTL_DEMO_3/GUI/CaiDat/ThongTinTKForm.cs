using BTL_DEMO_3.DAO;
using BTL_DEMO_3.DTO;
using BTL_DEMO_3.GUI.CaiDat;
using BTL_DEMO_3.GUI.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BTL_DEMO_3.GUI
{
    public partial class ThongTinTKForm : Form, ISendResult, ISendTaiKhoan
    {
        private TaiKhoanDAO TaiKhoanDAO = new TaiKhoanDAO();
        private bool xacNhan;
        private TaiKhoan taiKhoan = new TaiKhoan();
        private ISendData sendData;
        public ThongTinTKForm()
        {
            InitializeComponent();
        }
        public ThongTinTKForm(ISendData sendData)
        {
            InitializeComponent();
            this.sendData = sendData;
        }

        private void ThongTinTKForm_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet = TaiKhoanDAO.getThongTinTK(taiKhoan.MaNV);
            DataTable dataTable = dataSet.Tables[0];
            DataRow row = dataTable.Rows[0];
            tb_MaNV.Text = taiKhoan.MaNV;
            tb_TenDangNhap.Text = taiKhoan.TenDangNhap;

            tb_HoTen.Text = row["sTenNV"].ToString();
            tb_Email.Text = row["sEmail"].ToString();
            tb_QueQuan.Text = row["sDiaChi"].ToString();
            tb_SDT.Text = row["sSdt"].ToString();
            if ((bool)row["bGioiTinh"] == true)
            {
                cbb_GioiTinh.Text = " Nam";
            }
            else
            {
                cbb_GioiTinh.Text = "Nữ";
            }

            dpt_NgaySinh.Value = (DateTime)row["dNgaySinh"];
        }



        private void btn_chinh_sua_Click(object sender, EventArgs e)
        {
            XacNhanForm xacNhanForm = new XacNhanForm(this);
            xacNhanForm.send(taiKhoan.MatKhau);
            xacNhanForm.ShowDialog();
            if (xacNhan)
            {
                string maNV = tb_MaNV.Text.Trim();
                string tenNV = tb_HoTen.Text.Trim();
                bool gioiTinh = (cbb_GioiTinh.Text.Trim() == "Nam") ? true : false;
                DateTime ngaySinh = DateTime.Parse(dpt_NgaySinh.Text);
                string sDT = tb_SDT.Text.Trim();
                string diaChi = tb_QueQuan.Text.Trim();
                string email = tb_Email.Text.Trim();
                string tenDangNhap = tb_TenDangNhap.Text.Trim();

                try
                {
                    int result = TaiKhoanDAO.suaTTTK(maNV,tenDangNhap, tenNV, gioiTinh, ngaySinh, diaChi, sDT, email);

                    if (result > 0)
                    {
                        MessageBox.Show("Sua thanh cong !!");
                        this.Close();
                
                    }
                    else
                    {
                        MessageBox.Show("Sua that bai !!");
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2601)
                    {
                        MessageBox.Show("Ten dang nhap da ton tai !!");
                    }
                }
               
                
                
            }
            // chưa sửa thông tin trong database

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SendResult(bool result)
        {
            this.xacNhan = result;
        }

        public void Send(TaiKhoan taiKhoan)
        {
            this.taiKhoan = taiKhoan;
        }
    }
}
