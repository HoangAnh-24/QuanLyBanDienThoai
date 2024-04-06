using BTL_DEMO_3.DAO;
using BTL_DEMO_3.DTO;
using BTL_DEMO_3.GUI;
using BTL_DEMO_3.GUI.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_DEMO_3
{
    public partial class LoginForm : Form
    {
       private TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        private TaiKhoan taiKhoan;
       private ISendTaiKhoan sendTaiKhoan;
        public LoginForm()
        {
            InitializeComponent();
        }
        public LoginForm(ISendTaiKhoan sendTaiKhoan)
        {
            InitializeComponent();
            this.sendTaiKhoan =(sendTaiKhoan);
        }


        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string tenTK = tb_TenTaiKhoan.Text.Trim();  
            string matKhau = tb_MatKhau.Text.Trim();

            taiKhoan = new TaiKhoan();
            taiKhoan = taiKhoanDAO.getTkLogin(tenTK, matKhau);

            if (taiKhoan!= null)
            {
                MenuForm menuForm = new MenuForm();
                menuForm.Send(taiKhoan);
                this.Hide();
                menuForm.ShowDialog();
                tb_MatKhau.Clear();
                tb_TenTaiKhoan.Clear();
                this.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!! ");
            }
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void cb_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_HienMatKhau.Checked)
            {
                tb_MatKhau.PasswordChar = '\0';
            }
            else
            {
                tb_MatKhau.PasswordChar = '*';
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình không ?","Thông báo ",MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel=false;
            }
        }
    }
}
