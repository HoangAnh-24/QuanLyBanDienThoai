namespace BTL_DEMO_3.GUI.QuanLy
{
    partial class NhanVienForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_ThongBaoDS = new System.Windows.Forms.Label();
            this.dgv_NV = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_LuaChonTK = new System.Windows.Forms.ComboBox();
            this.dtp_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_GT = new System.Windows.Forms.ComboBox();
            this.btn_resetNV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_XoaNV = new System.Windows.Forms.Button();
            this.btn_SuaNV = new System.Windows.Forms.Button();
            this.tb_QueQuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.tb_MaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_ThongBaoDS);
            this.groupBox1.Controls.Add(this.dgv_NV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 335);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // lb_ThongBaoDS
            // 
            this.lb_ThongBaoDS.AutoSize = true;
            this.lb_ThongBaoDS.Location = new System.Drawing.Point(508, 44);
            this.lb_ThongBaoDS.Name = "lb_ThongBaoDS";
            this.lb_ThongBaoDS.Size = new System.Drawing.Size(73, 16);
            this.lb_ThongBaoDS.TabIndex = 38;
            this.lb_ThongBaoDS.Text = "Thông báo";
            this.lb_ThongBaoDS.Visible = false;
            // 
            // dgv_NV
            // 
            this.dgv_NV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NV.BackgroundColor = System.Drawing.Color.White;
            this.dgv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NV.Location = new System.Drawing.Point(7, 22);
            this.dgv_NV.Name = "dgv_NV";
            this.dgv_NV.RowHeadersWidth = 51;
            this.dgv_NV.RowTemplate.Height = 24;
            this.dgv_NV.Size = new System.Drawing.Size(1074, 306);
            this.dgv_NV.TabIndex = 0;
            this.dgv_NV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NV_CellClick);
            this.dgv_NV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_NV_CellFormatting);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbb_LuaChonTK);
            this.groupBox3.Controls.Add(this.dtp_ngaySinh);
            this.groupBox3.Controls.Add(this.cbb_GT);
            this.groupBox3.Controls.Add(this.btn_resetNV);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_HoTen);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tb_SDT);
            this.groupBox3.Controls.Add(this.tb_TimKiem);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btn_XoaNV);
            this.groupBox3.Controls.Add(this.btn_SuaNV);
            this.groupBox3.Controls.Add(this.tb_QueQuan);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tb_Email);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btn_ThemNV);
            this.groupBox3.Controls.Add(this.tb_MaNV);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1087, 244);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Lựa chọn tìm kiếm ";
            // 
            // cbb_LuaChonTK
            // 
            this.cbb_LuaChonTK.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LuaChonTK.FormattingEnabled = true;
            this.cbb_LuaChonTK.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Họ và tên",
            "Quê quán"});
            this.cbb_LuaChonTK.Location = new System.Drawing.Point(435, 212);
            this.cbb_LuaChonTK.Name = "cbb_LuaChonTK";
            this.cbb_LuaChonTK.Size = new System.Drawing.Size(146, 26);
            this.cbb_LuaChonTK.TabIndex = 51;
            // 
            // dtp_ngaySinh
            // 
            this.dtp_ngaySinh.Location = new System.Drawing.Point(623, 67);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.Size = new System.Drawing.Size(191, 22);
            this.dtp_ngaySinh.TabIndex = 51;
            // 
            // cbb_GT
            // 
            this.cbb_GT.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_GT.FormattingEnabled = true;
            this.cbb_GT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_GT.Location = new System.Drawing.Point(49, 146);
            this.cbb_GT.Name = "cbb_GT";
            this.cbb_GT.Size = new System.Drawing.Size(146, 26);
            this.cbb_GT.TabIndex = 50;
            this.cbb_GT.Validating += new System.ComponentModel.CancelEventHandler(this.cbb_GT_Validating);
            // 
            // btn_resetNV
            // 
            this.btn_resetNV.Location = new System.Drawing.Point(945, 186);
            this.btn_resetNV.Name = "btn_resetNV";
            this.btn_resetNV.Size = new System.Drawing.Size(113, 30);
            this.btn_resetNV.TabIndex = 16;
            this.btn_resetNV.Text = "Reset";
            this.btn_resetNV.UseVisualStyleBackColor = true;
            this.btn_resetNV.Click += new System.EventHandler(this.btn_resetNV_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Giới tính";
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Location = new System.Drawing.Point(248, 68);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(146, 22);
            this.tb_HoTen.TabIndex = 22;
            this.tb_HoTen.Validating += new System.ComponentModel.CancelEventHandler(this.tb_HoTen_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Họ và tên";
            // 
            // tb_SDT
            // 
            this.tb_SDT.Location = new System.Drawing.Point(435, 66);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(146, 22);
            this.tb_SDT.TabIndex = 19;
            this.tb_SDT.Validating += new System.ComponentModel.CancelEventHandler(this.tb_SDT_Validating);
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(49, 212);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(345, 22);
            this.tb_TimKiem.TabIndex = 17;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tìm Kiếm : ";
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.Location = new System.Drawing.Point(945, 141);
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(113, 30);
            this.btn_XoaNV.TabIndex = 14;
            this.btn_XoaNV.Text = "Xóa";
            this.btn_XoaNV.UseVisualStyleBackColor = true;
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.Location = new System.Drawing.Point(945, 87);
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(113, 30);
            this.btn_SuaNV.TabIndex = 13;
            this.btn_SuaNV.Text = "Sửa";
            this.btn_SuaNV.UseVisualStyleBackColor = true;
            this.btn_SuaNV.Click += new System.EventHandler(this.btn_SuaNV_Click);
            // 
            // tb_QueQuan
            // 
            this.tb_QueQuan.Location = new System.Drawing.Point(248, 153);
            this.tb_QueQuan.Name = "tb_QueQuan";
            this.tb_QueQuan.Size = new System.Drawing.Size(146, 22);
            this.tb_QueQuan.TabIndex = 10;
            this.tb_QueQuan.Validating += new System.ComponentModel.CancelEventHandler(this.tb_QueQuan_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quê Quán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số điện thoại";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(435, 153);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(146, 22);
            this.tb_Email.TabIndex = 6;
            this.tb_Email.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Email_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Location = new System.Drawing.Point(945, 40);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(113, 30);
            this.btn_ThemNV.TabIndex = 3;
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.UseVisualStyleBackColor = true;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // tb_MaNV
            // 
            this.tb_MaNV.Location = new System.Drawing.Point(49, 68);
            this.tb_MaNV.Name = "tb_MaNV";
            this.tb_MaNV.Size = new System.Drawing.Size(146, 22);
            this.tb_MaNV.TabIndex = 2;
            this.tb_MaNV.Validating += new System.ComponentModel.CancelEventHandler(this.tb_MaNV_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "NhanVienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.NhanVienForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_NV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbb_GT;
        private System.Windows.Forms.Button btn_resetNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_XoaNV;
        private System.Windows.Forms.Button btn_SuaNV;
        private System.Windows.Forms.TextBox tb_QueQuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ThemNV;
        private System.Windows.Forms.TextBox tb_MaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ThongBaoDS;
        private System.Windows.Forms.DateTimePicker dtp_ngaySinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_LuaChonTK;
    }
}