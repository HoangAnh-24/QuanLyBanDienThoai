using BTL_DEMO_3.DTO;
using BTL_DEMO_3.GUI.Code;
using BTL_DEMO_3.GUI.NhapLieu;
using BTL_DEMO_3.GUI.QuanLy;
using BTL_DEMO_3.GUI.Thongke;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_DEMO_3.GUI
{
    public partial class MenuForm : Form, ISendTaiKhoan
    {
       private TaiKhoan TaiKhoan = new TaiKhoan();
        private ISendTaiKhoan SendTaiKhoan;
        public MenuForm()
        {
            InitializeComponent();
        }
        public MenuForm(ISendTaiKhoan SendTaiKhoan)
        {
            InitializeComponent();
            this.SendTaiKhoan = SendTaiKhoan;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            if(TaiKhoan.PhanQuyen == true)
            {
                lb_Chao.Text = " Xin chào quản lý " + TaiKhoan.TenDangNhap;
            }
            else
            {
                lb_Chao.Text ="Xin chào nhân viên "+ TaiKhoan.TenDangNhap;
                item_NhanVien.Visible = false;
                menu_ThongKe.Visible = false;
                item_TaiKhoan.Visible = false;
            }
        }
      

        private void item_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ? ", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void item_DangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ? ", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void item_NhaCungCap_Click(object sender, EventArgs e)
        {
            NhaCungCapForm nhaCungCap = new NhaCungCapForm();
            this.Hide();
            nhaCungCap.ShowDialog();
            this.Show();
        }

        private void item_Thong_tin_tai_khoan_Click(object sender, EventArgs e)
        {
            ThongTinTKForm form = new ThongTinTKForm();
            form.Send(this.TaiKhoan);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void item_NhanVien_Click(object sender, EventArgs e)
        {
            NhanVienForm form = new NhanVienForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void item_KhachHang_Click(object sender, EventArgs e)
        {
            KhachHangForm form = new KhachHangForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void item_SanPham_Click(object sender, EventArgs e)
        {
            SanPhamForm form = new SanPhamForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void item_TaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoanForm form = new TaiKhoanForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void item_DoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhauForm form = new DoiMatKhauForm();
            form.Send(this.TaiKhoan);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void item_NhapSanPham_Click(object sender, EventArgs e)
        {
           NhapSanPhamForm nhapSanPhamForm = new NhapSanPhamForm();
            this.Hide();
            nhapSanPhamForm.ShowDialog();
            this.Show();
        }

        private void item_NhapHoaDon_Click(object sender, EventArgs e)
        {
            TaoDonHangForm form = new TaoDonHangForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        public void Send(TaiKhoan taiKhoan)
        {
          this.TaiKhoan = taiKhoan;
        }

        private void item_ThongkeHoaDon_Click(object sender, EventArgs e)
        {
            ThongKeDonHangForm thongKeDonHangForm = new ThongKeDonHangForm();
            this.Hide();
            thongKeDonHangForm.ShowDialog();
            this.Show();
        }
    }
}
