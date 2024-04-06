using BTL_DEMO_3.DAO;
using BTL_DEMO_3.DTO;
using BTL_DEMO_3.GUI.CaiDat;
using BTL_DEMO_3.GUI.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_DEMO_3.GUI
{
    public partial class DoiMatKhauForm : Form,ISendTaiKhoan
    {
        private TaiKhoan taiKhoan = new TaiKhoan();
        private TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        public DoiMatKhauForm()
        {
            InitializeComponent();
        }

        private void DoiMatKhauForm_Load(object sender, EventArgs e)
        {
            tb_TenDangNhap.Text = taiKhoan.TenDangNhap;
            tb_TenDangNhap.TabStop = false;
        }

        private void tn_XacNhan_Click(object sender, EventArgs e)
        {

            if (tb_MatKhauMoi.Text.Equals(tb_MatKhauMoi2.Text) && tb_MatKhauMoi.Text!= string.Empty)
            {
                if (tb_Matkhau.Text.Equals(taiKhoan.MatKhau))
                {
                   if( taiKhoanDAO.doiMatKhau(taiKhoan.TenDangNhap, tb_MatKhauMoi.Text.Trim())>0)
                    {
                        MessageBox.Show("Doi mat khau thanh cong");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Doi mat khau that bai");
                    }
                }
                else
                {
                    MessageBox.Show("Mat khau khong trung khop !!");
                }
            }
            else
            {
                MessageBox.Show("Mat khau moi khong trung khop !!");
            }
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Send(TaiKhoan taiKhoan)
        {
            this.taiKhoan = taiKhoan;
        }
    }
}
