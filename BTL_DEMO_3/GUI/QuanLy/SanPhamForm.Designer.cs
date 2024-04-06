namespace BTL_DEMO_3.GUI.QuanLy
{
    partial class SanPhamForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_ThongBaoDS = new System.Windows.Forms.Label();
            this.dgv_SanPham = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_LuaChonTimKiem = new System.Windows.Forms.ComboBox();
            this.tb_soLuongSp = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_TimKiemSp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ResetSP = new System.Windows.Forms.Button();
            this.btn_XoaSp = new System.Windows.Forms.Button();
            this.btn_SuaSP = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_XuatXuSp = new System.Windows.Forms.ComboBox();
            this.tblSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanDienThoaidemo3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanDienThoai_demo_3DataSet = new BTL_DEMO_3.QuanLyBanDienThoai_demo_3DataSet();
            this.tb_GiaBanSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_HangSanXuatSP = new System.Windows.Forms.ComboBox();
            this.tb_TenSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ThemSP = new System.Windows.Forms.Button();
            this.tb_MaSP = new System.Windows.Forms.TextBox();
            this.cb_NCCSP = new System.Windows.Forms.ComboBox();
            this.tblNhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tblSanPhamTableAdapter = new BTL_DEMO_3.QuanLyBanDienThoai_demo_3DataSetTableAdapters.tblSanPhamTableAdapter();
            this.tblNhaCungCapTableAdapter = new BTL_DEMO_3.QuanLyBanDienThoai_demo_3DataSetTableAdapters.tblNhaCungCapTableAdapter();
            this.fKsMaNCCtblSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoaidemo3DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoai_demo_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKsMaNCCtblSanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_ThongBaoDS);
            this.groupBox4.Controls.Add(this.dgv_SanPham);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1098, 375);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách sản phẩm";
            // 
            // lb_ThongBaoDS
            // 
            this.lb_ThongBaoDS.AutoSize = true;
            this.lb_ThongBaoDS.Location = new System.Drawing.Point(504, 74);
            this.lb_ThongBaoDS.Name = "lb_ThongBaoDS";
            this.lb_ThongBaoDS.Size = new System.Drawing.Size(73, 16);
            this.lb_ThongBaoDS.TabIndex = 38;
            this.lb_ThongBaoDS.Text = "Thông báo";
            this.lb_ThongBaoDS.Visible = false;
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPham.Location = new System.Drawing.Point(7, 31);
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.RowHeadersWidth = 51;
            this.dgv_SanPham.RowTemplate.Height = 24;
            this.dgv_SanPham.Size = new System.Drawing.Size(1085, 338);
            this.dgv_SanPham.TabIndex = 0;
            this.dgv_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellClick);
            this.dgv_SanPham.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_SanPham_CellFormatting);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbb_LuaChonTimKiem);
            this.groupBox3.Controls.Add(this.tb_soLuongSp);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.tb_TimKiemSp);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btn_ResetSP);
            this.groupBox3.Controls.Add(this.btn_XoaSp);
            this.groupBox3.Controls.Add(this.btn_SuaSP);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cb_XuatXuSp);
            this.groupBox3.Controls.Add(this.tb_GiaBanSP);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cb_HangSanXuatSP);
            this.groupBox3.Controls.Add(this.tb_TenSP);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btn_ThemSP);
            this.groupBox3.Controls.Add(this.tb_MaSP);
            this.groupBox3.Controls.Add(this.cb_NCCSP);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1102, 289);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // cbb_LuaChonTimKiem
            // 
            this.cbb_LuaChonTimKiem.FormattingEnabled = true;
            this.cbb_LuaChonTimKiem.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Tên sản phẩm",
            "Xuất xứ",
            "Hãng sản xuất"});
            this.cbb_LuaChonTimKiem.Location = new System.Drawing.Point(477, 224);
            this.cbb_LuaChonTimKiem.Name = "cbb_LuaChonTimKiem";
            this.cbb_LuaChonTimKiem.Size = new System.Drawing.Size(146, 24);
            this.cbb_LuaChonTimKiem.TabIndex = 37;
            // 
            // tb_soLuongSp
            // 
            this.tb_soLuongSp.Location = new System.Drawing.Point(477, 150);
            this.tb_soLuongSp.Name = "tb_soLuongSp";
            this.tb_soLuongSp.Size = new System.Drawing.Size(146, 22);
            this.tb_soLuongSp.TabIndex = 19;
            this.tb_soLuongSp.TextChanged += new System.EventHandler(this.tb_soLuongSp_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(474, 123);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 16);
            this.label21.TabIndex = 18;
            this.label21.Text = "Số lượng";
            // 
            // tb_TimKiemSp
            // 
            this.tb_TimKiemSp.Location = new System.Drawing.Point(49, 224);
            this.tb_TimKiemSp.Name = "tb_TimKiemSp";
            this.tb_TimKiemSp.Size = new System.Drawing.Size(355, 22);
            this.tb_TimKiemSp.TabIndex = 17;
            this.tb_TimKiemSp.TextChanged += new System.EventHandler(this.tb_TimKiemSp_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tìm Kiếm : ";
            // 
            // btn_ResetSP
            // 
            this.btn_ResetSP.Location = new System.Drawing.Point(936, 197);
            this.btn_ResetSP.Name = "btn_ResetSP";
            this.btn_ResetSP.Size = new System.Drawing.Size(113, 30);
            this.btn_ResetSP.TabIndex = 15;
            this.btn_ResetSP.Text = "Reset";
            this.btn_ResetSP.UseVisualStyleBackColor = true;
            this.btn_ResetSP.Click += new System.EventHandler(this.btn_ResetSP_Click);
            // 
            // btn_XoaSp
            // 
            this.btn_XoaSp.Location = new System.Drawing.Point(936, 143);
            this.btn_XoaSp.Name = "btn_XoaSp";
            this.btn_XoaSp.Size = new System.Drawing.Size(113, 30);
            this.btn_XoaSp.TabIndex = 14;
            this.btn_XoaSp.Text = "Xóa";
            this.btn_XoaSp.UseVisualStyleBackColor = true;
            this.btn_XoaSp.Click += new System.EventHandler(this.btn_XoaSp_Click);
            // 
            // btn_SuaSP
            // 
            this.btn_SuaSP.Location = new System.Drawing.Point(936, 90);
            this.btn_SuaSP.Name = "btn_SuaSP";
            this.btn_SuaSP.Size = new System.Drawing.Size(113, 30);
            this.btn_SuaSP.TabIndex = 13;
            this.btn_SuaSP.Text = "Sửa";
            this.btn_SuaSP.UseVisualStyleBackColor = true;
            this.btn_SuaSP.Click += new System.EventHandler(this.btn_SuaSP_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(683, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Xuất xứ";
            // 
            // cb_XuatXuSp
            // 
            this.cb_XuatXuSp.DataSource = this.tblSanPhamBindingSource;
            this.cb_XuatXuSp.DisplayMember = "sXuatSu";
            this.cb_XuatXuSp.FormattingEnabled = true;
            this.cb_XuatXuSp.Location = new System.Drawing.Point(686, 71);
            this.cb_XuatXuSp.Name = "cb_XuatXuSp";
            this.cb_XuatXuSp.Size = new System.Drawing.Size(146, 24);
            this.cb_XuatXuSp.TabIndex = 11;
            this.cb_XuatXuSp.SelectedIndexChanged += new System.EventHandler(this.cb_XuatXuSp_SelectedIndexChanged);
            // 
            // tblSanPhamBindingSource
            // 
            this.tblSanPhamBindingSource.DataMember = "tblSanPham";
            this.tblSanPhamBindingSource.DataSource = this.quanLyBanDienThoaidemo3DataSetBindingSource;
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
            // tb_GiaBanSP
            // 
            this.tb_GiaBanSP.Location = new System.Drawing.Point(258, 151);
            this.tb_GiaBanSP.Name = "tb_GiaBanSP";
            this.tb_GiaBanSP.Size = new System.Drawing.Size(146, 22);
            this.tb_GiaBanSP.TabIndex = 10;
            this.tb_GiaBanSP.TextChanged += new System.EventHandler(this.tb_GiaBanSP_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hãng sản xuất";
            // 
            // cb_HangSanXuatSP
            // 
            this.cb_HangSanXuatSP.DataSource = this.tblSanPhamBindingSource;
            this.cb_HangSanXuatSP.DisplayMember = "sHangSP";
            this.cb_HangSanXuatSP.FormattingEnabled = true;
            this.cb_HangSanXuatSP.Location = new System.Drawing.Point(477, 71);
            this.cb_HangSanXuatSP.Name = "cb_HangSanXuatSP";
            this.cb_HangSanXuatSP.Size = new System.Drawing.Size(146, 24);
            this.cb_HangSanXuatSP.TabIndex = 7;
            this.cb_HangSanXuatSP.SelectedIndexChanged += new System.EventHandler(this.cb_HangSanXuatSP_SelectedIndexChanged);
            // 
            // tb_TenSP
            // 
            this.tb_TenSP.Location = new System.Drawing.Point(49, 151);
            this.tb_TenSP.Name = "tb_TenSP";
            this.tb_TenSP.Size = new System.Drawing.Size(146, 22);
            this.tb_TenSP.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhà cung cấp";
            // 
            // btn_ThemSP
            // 
            this.btn_ThemSP.Location = new System.Drawing.Point(936, 36);
            this.btn_ThemSP.Name = "btn_ThemSP";
            this.btn_ThemSP.Size = new System.Drawing.Size(113, 30);
            this.btn_ThemSP.TabIndex = 3;
            this.btn_ThemSP.Text = "Thêm";
            this.btn_ThemSP.UseVisualStyleBackColor = true;
            this.btn_ThemSP.Click += new System.EventHandler(this.btn_ThemSP_Click);
            // 
            // tb_MaSP
            // 
            this.tb_MaSP.Location = new System.Drawing.Point(49, 73);
            this.tb_MaSP.Name = "tb_MaSP";
            this.tb_MaSP.Size = new System.Drawing.Size(146, 22);
            this.tb_MaSP.TabIndex = 2;
            // 
            // cb_NCCSP
            // 
            this.cb_NCCSP.DataSource = this.tblNhaCungCapBindingSource;
            this.cb_NCCSP.DisplayMember = "sMaNCC";
            this.cb_NCCSP.FormattingEnabled = true;
            this.cb_NCCSP.Location = new System.Drawing.Point(258, 71);
            this.cb_NCCSP.Name = "cb_NCCSP";
            this.cb_NCCSP.Size = new System.Drawing.Size(146, 24);
            this.cb_NCCSP.TabIndex = 1;
            // 
            // tblNhaCungCapBindingSource
            // 
            this.tblNhaCungCapBindingSource.DataMember = "tblNhaCungCap";
            this.tblNhaCungCapBindingSource.DataSource = this.quanLyBanDienThoaidemo3DataSetBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // tblSanPhamTableAdapter
            // 
            this.tblSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // tblNhaCungCapTableAdapter
            // 
            this.tblNhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // fKsMaNCCtblSanPhamBindingSource
            // 
            this.fKsMaNCCtblSanPhamBindingSource.DataMember = "FK_sMaNCC_tblSanPham";
            this.fKsMaNCCtblSanPhamBindingSource.DataSource = this.tblNhaCungCapBindingSource;
            // 
            // SanPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 707);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "SanPhamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.SanPhamForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoaidemo3DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoai_demo_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKsMaNCCtblSanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_SanPham;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_soLuongSp;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_TimKiemSp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ResetSP;
        private System.Windows.Forms.Button btn_XoaSp;
        private System.Windows.Forms.Button btn_SuaSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_XuatXuSp;
        private System.Windows.Forms.TextBox tb_GiaBanSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_HangSanXuatSP;
        private System.Windows.Forms.TextBox tb_TenSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ThemSP;
        private System.Windows.Forms.TextBox tb_MaSP;
        private System.Windows.Forms.ComboBox cb_NCCSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_LuaChonTimKiem;
        private System.Windows.Forms.BindingSource quanLyBanDienThoaidemo3DataSetBindingSource;
        private QuanLyBanDienThoai_demo_3DataSet quanLyBanDienThoai_demo_3DataSet;
        private System.Windows.Forms.BindingSource tblSanPhamBindingSource;
        private QuanLyBanDienThoai_demo_3DataSetTableAdapters.tblSanPhamTableAdapter tblSanPhamTableAdapter;
        private System.Windows.Forms.BindingSource tblNhaCungCapBindingSource;
        private QuanLyBanDienThoai_demo_3DataSetTableAdapters.tblNhaCungCapTableAdapter tblNhaCungCapTableAdapter;
        private System.Windows.Forms.BindingSource fKsMaNCCtblSanPhamBindingSource;
        private System.Windows.Forms.Label lb_ThongBaoDS;
    }
}