namespace BTL_DEMO_3.GUI.NhapLieu
{
    partial class ChiTietNhaphangForm
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
            this.lb_ThongBaoDS = new System.Windows.Forms.Label();
            this.dgv_DSSP = new System.Windows.Forms.DataGridView();
            this.btn_NhapHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_SoLuongNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_MaNV = new System.Windows.Forms.ComboBox();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanDienThoaidemo3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanDienThoai_demo_3DataSet = new BTL_DEMO_3.QuanLyBanDienThoai_demo_3DataSet();
            this.tblNhanVienTableAdapter = new BTL_DEMO_3.QuanLyBanDienThoai_demo_3DataSetTableAdapters.tblNhanVienTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoaidemo3DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoai_demo_3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_ThongBaoDS);
            this.groupBox1.Controls.Add(this.dgv_DSSP);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 521);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // lb_ThongBaoDS
            // 
            this.lb_ThongBaoDS.AutoSize = true;
            this.lb_ThongBaoDS.Location = new System.Drawing.Point(492, 68);
            this.lb_ThongBaoDS.Name = "lb_ThongBaoDS";
            this.lb_ThongBaoDS.Size = new System.Drawing.Size(44, 16);
            this.lb_ThongBaoDS.TabIndex = 2;
            this.lb_ThongBaoDS.Text = "label1";
            // 
            // dgv_DSSP
            // 
            this.dgv_DSSP.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSP.Location = new System.Drawing.Point(13, 22);
            this.dgv_DSSP.Name = "dgv_DSSP";
            this.dgv_DSSP.RowHeadersWidth = 51;
            this.dgv_DSSP.RowTemplate.Height = 24;
            this.dgv_DSSP.Size = new System.Drawing.Size(1038, 493);
            this.dgv_DSSP.TabIndex = 0;
            this.dgv_DSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSSP_CellClick);
            this.dgv_DSSP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_SanPham_CellFormatting);
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.Location = new System.Drawing.Point(912, 575);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Size = new System.Drawing.Size(152, 36);
            this.btn_NhapHang.TabIndex = 1;
            this.btn_NhapHang.Text = "Nhập hàng";
            this.btn_NhapHang.UseVisualStyleBackColor = true;
            this.btn_NhapHang.Click += new System.EventHandler(this.btn_NhapHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số lượng nhập :";
            // 
            // tb_SoLuongNhap
            // 
            this.tb_SoLuongNhap.Location = new System.Drawing.Point(117, 582);
            this.tb_SoLuongNhap.Name = "tb_SoLuongNhap";
            this.tb_SoLuongNhap.Size = new System.Drawing.Size(146, 22);
            this.tb_SoLuongNhap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 588);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã nhân viên :";
            // 
            // cbb_MaNV
            // 
            this.cbb_MaNV.DataSource = this.tblNhanVienBindingSource;
            this.cbb_MaNV.DisplayMember = "sMaNV";
            this.cbb_MaNV.FormattingEnabled = true;
            this.cbb_MaNV.Location = new System.Drawing.Point(432, 585);
            this.cbb_MaNV.Name = "cbb_MaNV";
            this.cbb_MaNV.Size = new System.Drawing.Size(146, 24);
            this.cbb_MaNV.TabIndex = 5;
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
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // ChiTietNhaphangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 641);
            this.Controls.Add(this.cbb_MaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_SoLuongNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_NhapHang);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChiTietNhaphangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập sản phẩm";
            this.Load += new System.EventHandler(this.ChiTietNhaphangForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoaidemo3DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDienThoai_demo_3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DSSP;
        private System.Windows.Forms.Button btn_NhapHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_SoLuongNhap;
        private System.Windows.Forms.Label lb_ThongBaoDS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_MaNV;
        private System.Windows.Forms.BindingSource quanLyBanDienThoaidemo3DataSetBindingSource;
        private QuanLyBanDienThoai_demo_3DataSet quanLyBanDienThoai_demo_3DataSet;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QuanLyBanDienThoai_demo_3DataSetTableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
    }
}