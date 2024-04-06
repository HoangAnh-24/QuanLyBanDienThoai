namespace BTL_DEMO_3.GUI
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_QuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.item_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.item_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.item_SanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.item_TaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.item_NhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.item_ThongkeHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.item_LichSuNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Nhap = new System.Windows.Forms.ToolStripMenuItem();
            this.item_NhapSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.item_NhapHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.item_troGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_caiDat = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Thong_tin_tai_khoan = new System.Windows.Forms.ToolStripMenuItem();
            this.item_DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.item_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.item_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_Chao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Home,
            this.menu_QuanLy,
            this.menu_ThongKe,
            this.menu_Nhap,
            this.menu_TroGiup,
            this.menu_caiDat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_Home
            // 
            this.menu_Home.Name = "menu_Home";
            this.menu_Home.Size = new System.Drawing.Size(64, 24);
            this.menu_Home.Text = "Home";
            // 
            // menu_QuanLy
            // 
            this.menu_QuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_NhanVien,
            this.item_KhachHang,
            this.item_SanPham,
            this.item_TaiKhoan,
            this.item_NhaCungCap});
            this.menu_QuanLy.Name = "menu_QuanLy";
            this.menu_QuanLy.Size = new System.Drawing.Size(73, 24);
            this.menu_QuanLy.Text = "Quản lý";
            // 
            // item_NhanVien
            // 
            this.item_NhanVien.Name = "item_NhanVien";
            this.item_NhanVien.Size = new System.Drawing.Size(183, 26);
            this.item_NhanVien.Text = "Nhân viên";
            this.item_NhanVien.Click += new System.EventHandler(this.item_NhanVien_Click);
            // 
            // item_KhachHang
            // 
            this.item_KhachHang.Name = "item_KhachHang";
            this.item_KhachHang.Size = new System.Drawing.Size(183, 26);
            this.item_KhachHang.Text = "Khách hàng";
            this.item_KhachHang.Click += new System.EventHandler(this.item_KhachHang_Click);
            // 
            // item_SanPham
            // 
            this.item_SanPham.Name = "item_SanPham";
            this.item_SanPham.Size = new System.Drawing.Size(183, 26);
            this.item_SanPham.Text = "Sản phẩm";
            this.item_SanPham.Click += new System.EventHandler(this.item_SanPham_Click);
            // 
            // item_TaiKhoan
            // 
            this.item_TaiKhoan.Name = "item_TaiKhoan";
            this.item_TaiKhoan.Size = new System.Drawing.Size(183, 26);
            this.item_TaiKhoan.Text = "Tài Khoản";
            this.item_TaiKhoan.Click += new System.EventHandler(this.item_TaiKhoan_Click);
            // 
            // item_NhaCungCap
            // 
            this.item_NhaCungCap.Name = "item_NhaCungCap";
            this.item_NhaCungCap.Size = new System.Drawing.Size(183, 26);
            this.item_NhaCungCap.Text = "Nhà cung cấp";
            this.item_NhaCungCap.Click += new System.EventHandler(this.item_NhaCungCap_Click);
            // 
            // menu_ThongKe
            // 
            this.menu_ThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_ThongkeHoaDon,
            this.item_LichSuNhapHang});
            this.menu_ThongKe.Name = "menu_ThongKe";
            this.menu_ThongKe.Size = new System.Drawing.Size(86, 24);
            this.menu_ThongKe.Text = "Thống Kê";
            // 
            // item_ThongkeHoaDon
            // 
            this.item_ThongkeHoaDon.Name = "item_ThongkeHoaDon";
            this.item_ThongkeHoaDon.Size = new System.Drawing.Size(212, 26);
            this.item_ThongkeHoaDon.Text = "Thống kê hóa đơn";
            this.item_ThongkeHoaDon.Click += new System.EventHandler(this.item_ThongkeHoaDon_Click);
            // 
            // item_LichSuNhapHang
            // 
            this.item_LichSuNhapHang.Name = "item_LichSuNhapHang";
            this.item_LichSuNhapHang.Size = new System.Drawing.Size(212, 26);
            this.item_LichSuNhapHang.Text = "Lịch sử nhập hàng";
            // 
            // menu_Nhap
            // 
            this.menu_Nhap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_NhapSanPham,
            this.item_NhapHoaDon});
            this.menu_Nhap.Name = "menu_Nhap";
            this.menu_Nhap.Size = new System.Drawing.Size(59, 24);
            this.menu_Nhap.Text = "Nhập";
            // 
            // item_NhapSanPham
            // 
            this.item_NhapSanPham.Name = "item_NhapSanPham";
            this.item_NhapSanPham.Size = new System.Drawing.Size(196, 26);
            this.item_NhapSanPham.Text = "Nhập sản phẩm";
            this.item_NhapSanPham.Click += new System.EventHandler(this.item_NhapSanPham_Click);
            // 
            // item_NhapHoaDon
            // 
            this.item_NhapHoaDon.Name = "item_NhapHoaDon";
            this.item_NhapHoaDon.Size = new System.Drawing.Size(196, 26);
            this.item_NhapHoaDon.Text = "Nhập hóa đơn";
            this.item_NhapHoaDon.Click += new System.EventHandler(this.item_NhapHoaDon_Click);
            // 
            // menu_TroGiup
            // 
            this.menu_TroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_troGiup});
            this.menu_TroGiup.Name = "menu_TroGiup";
            this.menu_TroGiup.Size = new System.Drawing.Size(78, 24);
            this.menu_TroGiup.Text = "Trợ giúp";
            // 
            // item_troGiup
            // 
            this.item_troGiup.Name = "item_troGiup";
            this.item_troGiup.Size = new System.Drawing.Size(135, 26);
            this.item_troGiup.Text = "Hỗ trợ";
            // 
            // menu_caiDat
            // 
            this.menu_caiDat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_Thong_tin_tai_khoan,
            this.item_DoiMatKhau,
            this.item_thoat,
            this.item_DangXuat});
            this.menu_caiDat.Name = "menu_caiDat";
            this.menu_caiDat.Size = new System.Drawing.Size(70, 24);
            this.menu_caiDat.Text = "Cài đặt";
            // 
            // item_Thong_tin_tai_khoan
            // 
            this.item_Thong_tin_tai_khoan.Name = "item_Thong_tin_tai_khoan";
            this.item_Thong_tin_tai_khoan.Size = new System.Drawing.Size(220, 26);
            this.item_Thong_tin_tai_khoan.Text = "Thông tin tài khoản";
            this.item_Thong_tin_tai_khoan.Click += new System.EventHandler(this.item_Thong_tin_tai_khoan_Click);
            // 
            // item_DoiMatKhau
            // 
            this.item_DoiMatKhau.Name = "item_DoiMatKhau";
            this.item_DoiMatKhau.Size = new System.Drawing.Size(220, 26);
            this.item_DoiMatKhau.Text = "Đổi mật khẩu";
            this.item_DoiMatKhau.Click += new System.EventHandler(this.item_DoiMatKhau_Click);
            // 
            // item_thoat
            // 
            this.item_thoat.Name = "item_thoat";
            this.item_thoat.Size = new System.Drawing.Size(220, 26);
            this.item_thoat.Text = "Thoát";
            this.item_thoat.Click += new System.EventHandler(this.item_thoat_Click);
            // 
            // item_DangXuat
            // 
            this.item_DangXuat.Name = "item_DangXuat";
            this.item_DangXuat.Size = new System.Drawing.Size(220, 26);
            this.item_DangXuat.Text = "Đăng xuất";
            this.item_DangXuat.Click += new System.EventHandler(this.item_DangXuat_Click);
            // 
            // lb_Chao
            // 
            this.lb_Chao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Chao.AutoSize = true;
            this.lb_Chao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Chao.Location = new System.Drawing.Point(449, 55);
            this.lb_Chao.Name = "lb_Chao";
            this.lb_Chao.Size = new System.Drawing.Size(64, 25);
            this.lb_Chao.TabIndex = 3;
            this.lb_Chao.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_Chao);
            this.panel1.Location = new System.Drawing.Point(13, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 517);
            this.panel1.TabIndex = 4;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_Home;
        private System.Windows.Forms.ToolStripMenuItem menu_QuanLy;
        private System.Windows.Forms.ToolStripMenuItem item_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem item_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem item_SanPham;
        private System.Windows.Forms.ToolStripMenuItem item_TaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem item_NhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem menu_ThongKe;
        private System.Windows.Forms.ToolStripMenuItem item_ThongkeHoaDon;
        private System.Windows.Forms.ToolStripMenuItem item_LichSuNhapHang;
        private System.Windows.Forms.ToolStripMenuItem menu_Nhap;
        private System.Windows.Forms.ToolStripMenuItem item_NhapSanPham;
        private System.Windows.Forms.ToolStripMenuItem item_NhapHoaDon;
        private System.Windows.Forms.ToolStripMenuItem menu_TroGiup;
        private System.Windows.Forms.ToolStripMenuItem item_troGiup;
        private System.Windows.Forms.ToolStripMenuItem menu_caiDat;
        private System.Windows.Forms.ToolStripMenuItem item_Thong_tin_tai_khoan;
        private System.Windows.Forms.ToolStripMenuItem item_DoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem item_thoat;
        private System.Windows.Forms.ToolStripMenuItem item_DangXuat;
        private System.Windows.Forms.Label lb_Chao;
        private System.Windows.Forms.Panel panel1;
    }
}