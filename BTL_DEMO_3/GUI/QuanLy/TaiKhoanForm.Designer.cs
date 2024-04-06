namespace BTL_DEMO_3.GUI.QuanLy
{
    partial class TaiKhoanForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_MaNV = new System.Windows.Forms.ComboBox();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanDienThoaidemo3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanDienThoai_demo_3DataSet = new BTL_DEMO_3.QuanLyBanDienThoai_demo_3DataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.cbb_QuyenTaiKhoan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_LuaChonTimKiem = new System.Windows.Forms.ComboBox();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TenDangNhap = new System.Windows.Forms.TextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_ThongBaoDS = new System.Windows.Forms.Label();
            this.dgv_TK = new System.Windows.Forms.DataGridView();
            this.tblNhanVienTableAdapter = new BTL_DEMO_3.QuanLyBanDienThoai_demo_3DataSetTableAdapters.tblNhanVienTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoaidemo3DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoai_demo_3DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_MaNV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_MatKhau);
            this.groupBox2.Controls.Add(this.cbb_QuyenTaiKhoan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbb_LuaChonTimKiem);
            this.groupBox2.Controls.Add(this.tb_TimKiem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_TenDangNhap);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1067, 214);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            // 
            // cbb_MaNV
            // 
            this.cbb_MaNV.DataSource = this.tblNhanVienBindingSource;
            this.cbb_MaNV.DisplayMember = "sMaNV";
            this.cbb_MaNV.FormattingEnabled = true;
            this.cbb_MaNV.Location = new System.Drawing.Point(40, 71);
            this.cbb_MaNV.Name = "cbb_MaNV";
            this.cbb_MaNV.Size = new System.Drawing.Size(146, 24);
            this.cbb_MaNV.TabIndex = 41;
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource.DataSource = this.quanLyBanDienThoaidemo3DataSetBindingSource;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mật khẩu";
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Location = new System.Drawing.Point(483, 74);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.Size = new System.Drawing.Size(146, 22);
            this.tb_MatKhau.TabIndex = 40;
            // 
            // cbb_QuyenTaiKhoan
            // 
            this.cbb_QuyenTaiKhoan.FormattingEnabled = true;
            this.cbb_QuyenTaiKhoan.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbb_QuyenTaiKhoan.Location = new System.Drawing.Point(692, 73);
            this.cbb_QuyenTaiKhoan.Name = "cbb_QuyenTaiKhoan";
            this.cbb_QuyenTaiKhoan.Size = new System.Drawing.Size(146, 24);
            this.cbb_QuyenTaiKhoan.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // cbb_LuaChonTimKiem
            // 
            this.cbb_LuaChonTimKiem.FormattingEnabled = true;
            this.cbb_LuaChonTimKiem.Location = new System.Drawing.Point(483, 150);
            this.cbb_LuaChonTimKiem.Name = "cbb_LuaChonTimKiem";
            this.cbb_LuaChonTimKiem.Size = new System.Drawing.Size(146, 24);
            this.cbb_LuaChonTimKiem.TabIndex = 35;
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(40, 154);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(360, 22);
            this.tb_TimKiem.TabIndex = 35;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Tìm Kiếm : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tên đăng nhập";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(948, 167);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(113, 30);
            this.btn_reset.TabIndex = 30;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(948, 21);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(113, 30);
            this.btn_Them.TabIndex = 23;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(689, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Quyền truy cập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã nhân viên";
            // 
            // tb_TenDangNhap
            // 
            this.tb_TenDangNhap.Location = new System.Drawing.Point(254, 73);
            this.tb_TenDangNhap.Name = "tb_TenDangNhap";
            this.tb_TenDangNhap.Size = new System.Drawing.Size(146, 22);
            this.tb_TenDangNhap.TabIndex = 31;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(948, 68);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(113, 30);
            this.btn_Sua.TabIndex = 28;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(948, 122);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(113, 30);
            this.btn_Xoa.TabIndex = 29;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_ThongBaoDS);
            this.groupBox1.Controls.Add(this.dgv_TK);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 344);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài khoản";
            // 
            // lb_ThongBaoDS
            // 
            this.lb_ThongBaoDS.AutoSize = true;
            this.lb_ThongBaoDS.Location = new System.Drawing.Point(503, 62);
            this.lb_ThongBaoDS.Name = "lb_ThongBaoDS";
            this.lb_ThongBaoDS.Size = new System.Drawing.Size(73, 16);
            this.lb_ThongBaoDS.TabIndex = 37;
            this.lb_ThongBaoDS.Text = "Thông báo";
            this.lb_ThongBaoDS.Visible = false;
            // 
            // dgv_TK
            // 
            this.dgv_TK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TK.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TK.Location = new System.Drawing.Point(7, 37);
            this.dgv_TK.Name = "dgv_TK";
            this.dgv_TK.RowHeadersWidth = 51;
            this.dgv_TK.RowTemplate.Height = 24;
            this.dgv_TK.Size = new System.Drawing.Size(1074, 301);
            this.dgv_TK.TabIndex = 0;
            this.dgv_TK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TK_CellClick);
            this.dgv_TK.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_TK_CellFormatting);
            // 
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // TaiKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TaiKhoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.TaiKhoanForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoaidemo3DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoai_demo_3DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.ComboBox cbb_QuyenTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_LuaChonTimKiem;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TenDangNhap;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_ThongBaoDS;
        private System.Windows.Forms.DataGridView dgv_TK;
        private System.Windows.Forms.ComboBox cbb_MaNV;
        private System.Windows.Forms.BindingSource quanLyBanDienThoaidemo3DataSetBindingSource;
        private QuanLyBanDienThoai_demo_3DataSet quanLyBanDienThoai_demo_3DataSet;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QuanLyBanDienThoai_demo_3DataSetTableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
    }
}