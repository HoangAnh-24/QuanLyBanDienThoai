namespace BTL_DEMO_3.GUI.NhapLieu
{
    partial class TaoDonHangForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_SDT = new System.Windows.Forms.ComboBox();
            this.tblKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanDienThoaidemo3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanDienThoai_demo_3DataSet = new BTL_DEMO_3.QuanLyBanDienThoai_demo_3DataSet();
            this.cbb_maNV = new System.Windows.Forms.ComboBox();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtp_NgayLapDH = new System.Windows.Forms.DateTimePicker();
            this.tb_DiaChiKH = new System.Windows.Forms.TextBox();
            this.tb_tenKH = new System.Windows.Forms.TextBox();
            this.tb_maDH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_XoaSanPham = new System.Windows.Forms.Button();
            this.btn_themSanPham = new System.Windows.Forms.Button();
            this.tb_SoLuongMua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_MaSP = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_ThongBaoDS = new System.Windows.Forms.Label();
            this.dgv_DSSPDaChon = new System.Windows.Forms.DataGridView();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_LapDonHang = new System.Windows.Forms.Button();
            this.btn_HuyDonHang = new System.Windows.Forms.Button();
            this.btn_XuatDonHang = new System.Windows.Forms.Button();
            this.btn_XemDonHang = new System.Windows.Forms.Button();
            this.tblNhanVienTableAdapter = new BTL_DEMO_3.QuanLyBanDienThoai_demo_3DataSetTableAdapters.tblNhanVienTableAdapter();
            this.tblKhachHangTableAdapter = new BTL_DEMO_3.QuanLyBanDienThoai_demo_3DataSetTableAdapters.tblKhachHangTableAdapter();
            this.tblSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSanPhamTableAdapter = new BTL_DEMO_3.QuanLyBanDienThoai_demo_3DataSetTableAdapters.tblSanPhamTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoaidemo3DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoai_demo_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSPDaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_SDT);
            this.groupBox1.Controls.Add(this.cbb_maNV);
            this.groupBox1.Controls.Add(this.dtp_NgayLapDH);
            this.groupBox1.Controls.Add(this.tb_DiaChiKH);
            this.groupBox1.Controls.Add(this.tb_tenKH);
            this.groupBox1.Controls.Add(this.tb_maDH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // cbb_SDT
            // 
            this.cbb_SDT.DataSource = this.tblKhachHangBindingSource;
            this.cbb_SDT.DisplayMember = "sSDT";
            this.cbb_SDT.FormattingEnabled = true;
            this.cbb_SDT.Location = new System.Drawing.Point(395, 48);
            this.cbb_SDT.Name = "cbb_SDT";
            this.cbb_SDT.Size = new System.Drawing.Size(151, 24);
            this.cbb_SDT.TabIndex = 11;
            this.cbb_SDT.SelectedIndexChanged += new System.EventHandler(this.cbb_SDT_SelectedIndexChanged);
            this.cbb_SDT.TextChanged += new System.EventHandler(this.cbb_SDT_TextChanged);
            // 
            // tblKhachHangBindingSource
            // 
            this.tblKhachHangBindingSource.DataMember = "tblKhachHang";
            this.tblKhachHangBindingSource.DataSource = this.quanLyBanDienThoaidemo3DataSetBindingSource;
            // 
            // quanLyBanDienThoaidemo3DataSetBindingSource
            // 
            this.quanLyBanDienThoaidemo3DataSetBindingSource.DataSource = this.quanLyBanDienThoai_demo_3DataSet;
            this.quanLyBanDienThoaidemo3DataSetBindingSource.Position = 0;
            // 
            // quanLyBanDienThoai_demo_3DataSet
            // 
            this.quanLyBanDienThoai_demo_3DataSet.DataSetName = "QuanLyBanDienThoai_demo_3DataSet";
            this.quanLyBanDienThoai_demo_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbb_maNV
            // 
            this.cbb_maNV.DataSource = this.tblNhanVienBindingSource;
            this.cbb_maNV.DisplayMember = "sMaNV";
            this.cbb_maNV.FormattingEnabled = true;
            this.cbb_maNV.Location = new System.Drawing.Point(395, 108);
            this.cbb_maNV.Name = "cbb_maNV";
            this.cbb_maNV.Size = new System.Drawing.Size(151, 24);
            this.cbb_maNV.TabIndex = 6;
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource.DataSource = this.quanLyBanDienThoaidemo3DataSetBindingSource;
            // 
            // dtp_NgayLapDH
            // 
            this.dtp_NgayLapDH.Location = new System.Drawing.Point(6, 172);
            this.dtp_NgayLapDH.Name = "dtp_NgayLapDH";
            this.dtp_NgayLapDH.Size = new System.Drawing.Size(328, 22);
            this.dtp_NgayLapDH.TabIndex = 10;
            // 
            // tb_DiaChiKH
            // 
            this.tb_DiaChiKH.Location = new System.Drawing.Point(6, 108);
            this.tb_DiaChiKH.Name = "tb_DiaChiKH";
            this.tb_DiaChiKH.Size = new System.Drawing.Size(328, 22);
            this.tb_DiaChiKH.TabIndex = 9;
            // 
            // tb_tenKH
            // 
            this.tb_tenKH.Location = new System.Drawing.Point(192, 48);
            this.tb_tenKH.Name = "tb_tenKH";
            this.tb_tenKH.Size = new System.Drawing.Size(142, 22);
            this.tb_tenKH.TabIndex = 7;
            // 
            // tb_maDH
            // 
            this.tb_maDH.Location = new System.Drawing.Point(9, 48);
            this.tb_maDH.Name = "tb_maDH";
            this.tb_maDH.Size = new System.Drawing.Size(113, 22);
            this.tb_maDH.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày lập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nhân viên lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XoaSanPham);
            this.groupBox2.Controls.Add(this.btn_themSanPham);
            this.groupBox2.Controls.Add(this.tb_SoLuongMua);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbb_MaSP);
            this.groupBox2.Location = new System.Drawing.Point(594, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn sản phẩm";
            // 
            // btn_XoaSanPham
            // 
            this.btn_XoaSanPham.Location = new System.Drawing.Point(298, 172);
            this.btn_XoaSanPham.Name = "btn_XoaSanPham";
            this.btn_XoaSanPham.Size = new System.Drawing.Size(113, 29);
            this.btn_XoaSanPham.TabIndex = 5;
            this.btn_XoaSanPham.Text = "Xóa sản phẩm";
            this.btn_XoaSanPham.UseVisualStyleBackColor = true;
            this.btn_XoaSanPham.Click += new System.EventHandler(this.btn_XoaSanPham_Click);
            // 
            // btn_themSanPham
            // 
            this.btn_themSanPham.Location = new System.Drawing.Point(47, 171);
            this.btn_themSanPham.Name = "btn_themSanPham";
            this.btn_themSanPham.Size = new System.Drawing.Size(126, 29);
            this.btn_themSanPham.TabIndex = 1;
            this.btn_themSanPham.Text = "Thêm sản phẩm";
            this.btn_themSanPham.UseVisualStyleBackColor = true;
            this.btn_themSanPham.Click += new System.EventHandler(this.btn_themSanPham_Click);
            // 
            // tb_SoLuongMua
            // 
            this.tb_SoLuongMua.Location = new System.Drawing.Point(6, 133);
            this.tb_SoLuongMua.Name = "tb_SoLuongMua";
            this.tb_SoLuongMua.Size = new System.Drawing.Size(225, 22);
            this.tb_SoLuongMua.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng mua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã sản phẩm     |      Tên sản phẩm      |       Số lượng tồn";
            // 
            // cbb_MaSP
            // 
            this.cbb_MaSP.FormattingEnabled = true;
            this.cbb_MaSP.Location = new System.Drawing.Point(6, 59);
            this.cbb_MaSP.Name = "cbb_MaSP";
            this.cbb_MaSP.Size = new System.Drawing.Size(458, 24);
            this.cbb_MaSP.TabIndex = 2;
            this.cbb_MaSP.SelectedIndexChanged += new System.EventHandler(this.cbb_MaSP_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_ThongBaoDS);
            this.groupBox3.Controls.Add(this.dgv_DSSPDaChon);
            this.groupBox3.Location = new System.Drawing.Point(12, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1090, 396);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm đã chọn";
            // 
            // lb_ThongBaoDS
            // 
            this.lb_ThongBaoDS.AutoSize = true;
            this.lb_ThongBaoDS.Location = new System.Drawing.Point(502, 68);
            this.lb_ThongBaoDS.Name = "lb_ThongBaoDS";
            this.lb_ThongBaoDS.Size = new System.Drawing.Size(44, 16);
            this.lb_ThongBaoDS.TabIndex = 6;
            this.lb_ThongBaoDS.Text = "label1";
            this.lb_ThongBaoDS.Visible = false;
            // 
            // dgv_DSSPDaChon
            // 
            this.dgv_DSSPDaChon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DSSPDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSPDaChon.Location = new System.Drawing.Point(9, 22);
            this.dgv_DSSPDaChon.Name = "dgv_DSSPDaChon";
            this.dgv_DSSPDaChon.RowHeadersWidth = 51;
            this.dgv_DSSPDaChon.RowTemplate.Height = 24;
            this.dgv_DSSPDaChon.Size = new System.Drawing.Size(1081, 368);
            this.dgv_DSSPDaChon.TabIndex = 1;
            this.dgv_DSSPDaChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSSPDaChon_CellClick);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(21, 657);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(113, 29);
            this.btn_Reset.TabIndex = 0;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_LapDonHang
            // 
            this.btn_LapDonHang.Location = new System.Drawing.Point(353, 657);
            this.btn_LapDonHang.Name = "btn_LapDonHang";
            this.btn_LapDonHang.Size = new System.Drawing.Size(113, 29);
            this.btn_LapDonHang.TabIndex = 2;
            this.btn_LapDonHang.Text = "Lập đơn hàng";
            this.btn_LapDonHang.UseVisualStyleBackColor = true;
            this.btn_LapDonHang.Click += new System.EventHandler(this.btn_LapDonHang_Click);
            // 
            // btn_HuyDonHang
            // 
            this.btn_HuyDonHang.Location = new System.Drawing.Point(181, 657);
            this.btn_HuyDonHang.Name = "btn_HuyDonHang";
            this.btn_HuyDonHang.Size = new System.Drawing.Size(113, 29);
            this.btn_HuyDonHang.TabIndex = 3;
            this.btn_HuyDonHang.Text = "Hủy đơn hàng";
            this.btn_HuyDonHang.UseVisualStyleBackColor = true;
            this.btn_HuyDonHang.Click += new System.EventHandler(this.btn_HuyDonHang_Click);
            // 
            // btn_XuatDonHang
            // 
            this.btn_XuatDonHang.Location = new System.Drawing.Point(521, 657);
            this.btn_XuatDonHang.Name = "btn_XuatDonHang";
            this.btn_XuatDonHang.Size = new System.Drawing.Size(113, 29);
            this.btn_XuatDonHang.TabIndex = 4;
            this.btn_XuatDonHang.Text = "Xuất hóa đơn";
            this.btn_XuatDonHang.UseVisualStyleBackColor = true;
            this.btn_XuatDonHang.Click += new System.EventHandler(this.btn_XuatDonHang_Click);
            // 
            // btn_XemDonHang
            // 
            this.btn_XemDonHang.Location = new System.Drawing.Point(681, 657);
            this.btn_XemDonHang.Name = "btn_XemDonHang";
            this.btn_XemDonHang.Size = new System.Drawing.Size(113, 29);
            this.btn_XemDonHang.TabIndex = 5;
            this.btn_XemDonHang.Text = "Xem đơn hàng";
            this.btn_XemDonHang.UseVisualStyleBackColor = true;
            this.btn_XemDonHang.Click += new System.EventHandler(this.btn_XemDonHang_Click);
            // 
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tblKhachHangTableAdapter
            // 
            this.tblKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tblSanPhamBindingSource
            // 
            this.tblSanPhamBindingSource.DataMember = "tblSanPham";
            this.tblSanPhamBindingSource.DataSource = this.quanLyBanDienThoaidemo3DataSetBindingSource;
            // 
            // tblSanPhamTableAdapter
            // 
            this.tblSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // TaoDonHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 707);
            this.Controls.Add(this.btn_XemDonHang);
            this.Controls.Add(this.btn_XuatDonHang);
            this.Controls.Add(this.btn_HuyDonHang);
            this.Controls.Add(this.btn_LapDonHang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "TaoDonHangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng";
            this.Load += new System.EventHandler(this.TaoDonHangForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoaidemo3DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoai_demo_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSPDaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_XoaSanPham;
        private System.Windows.Forms.Button btn_themSanPham;
        private System.Windows.Forms.TextBox tb_SoLuongMua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_MaSP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_DSSPDaChon;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_LapDonHang;
        private System.Windows.Forms.Button btn_HuyDonHang;
        private System.Windows.Forms.Button btn_XuatDonHang;
        private System.Windows.Forms.ComboBox cbb_maNV;
        private System.Windows.Forms.DateTimePicker dtp_NgayLapDH;
        private System.Windows.Forms.TextBox tb_DiaChiKH;
        private System.Windows.Forms.TextBox tb_tenKH;
        private System.Windows.Forms.TextBox tb_maDH;
        private System.Windows.Forms.Button btn_XemDonHang;
        private System.Windows.Forms.ComboBox cbb_SDT;
        private System.Windows.Forms.BindingSource quanLyBanDienThoaidemo3DataSetBindingSource;
        private QuanLyBanDienThoai_demo_3DataSet quanLyBanDienThoai_demo_3DataSet;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QuanLyBanDienThoai_demo_3DataSetTableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
        private System.Windows.Forms.BindingSource tblKhachHangBindingSource;
        private QuanLyBanDienThoai_demo_3DataSetTableAdapters.tblKhachHangTableAdapter tblKhachHangTableAdapter;
        private System.Windows.Forms.BindingSource tblSanPhamBindingSource;
        private QuanLyBanDienThoai_demo_3DataSetTableAdapters.tblSanPhamTableAdapter tblSanPhamTableAdapter;
        private System.Windows.Forms.Label lb_ThongBaoDS;
    }
}