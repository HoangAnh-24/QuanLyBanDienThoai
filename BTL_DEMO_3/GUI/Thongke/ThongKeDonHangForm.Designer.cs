namespace BTL_DEMO_3.GUI.Thongke
{
    partial class ThongKeDonHangForm
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
            this.dgv_DSDH = new System.Windows.Forms.DataGridView();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_LocTimKiem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_DoanhThu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_soLuongDonHang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.btn_PhieuDonHang = new System.Windows.Forms.Button();
            this.btn_xemDonHang = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btn_SapXep = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDH)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_ThongBaoDS);
            this.groupBox1.Controls.Add(this.dgv_DSDH);
            this.groupBox1.Location = new System.Drawing.Point(12, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1140, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đơn hàng";
            // 
            // lb_ThongBaoDS
            // 
            this.lb_ThongBaoDS.AutoSize = true;
            this.lb_ThongBaoDS.Location = new System.Drawing.Point(514, 72);
            this.lb_ThongBaoDS.Name = "lb_ThongBaoDS";
            this.lb_ThongBaoDS.Size = new System.Drawing.Size(73, 16);
            this.lb_ThongBaoDS.TabIndex = 39;
            this.lb_ThongBaoDS.Text = "Thông báo";
            this.lb_ThongBaoDS.Visible = false;
            // 
            // dgv_DSDH
            // 
            this.dgv_DSDH.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DSDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSDH.Location = new System.Drawing.Point(6, 21);
            this.dgv_DSDH.Name = "dgv_DSDH";
            this.dgv_DSDH.RowHeadersWidth = 51;
            this.dgv_DSDH.RowTemplate.Height = 24;
            this.dgv_DSDH.Size = new System.Drawing.Size(1128, 364);
            this.dgv_DSDH.TabIndex = 0;
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(9, 56);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(358, 22);
            this.tb_TimKiem.TabIndex = 1;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm";
            // 
            // cbb_LocTimKiem
            // 
            this.cbb_LocTimKiem.FormattingEnabled = true;
            this.cbb_LocTimKiem.Items.AddRange(new object[] {
            "Mã hóa đơn",
            "Số điện thoại",
            "Mã nhân viên"});
            this.cbb_LocTimKiem.Location = new System.Drawing.Point(9, 110);
            this.cbb_LocTimKiem.Name = "cbb_LocTimKiem";
            this.cbb_LocTimKiem.Size = new System.Drawing.Size(171, 24);
            this.cbb_LocTimKiem.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lựa chọn tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_TimKiem);
            this.groupBox2.Controls.Add(this.cbb_LocTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 173);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_DoanhThu);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lb_soLuongDonHang);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 588);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1140, 109);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin danh sách";
            // 
            // lb_DoanhThu
            // 
            this.lb_DoanhThu.AutoSize = true;
            this.lb_DoanhThu.Location = new System.Drawing.Point(136, 76);
            this.lb_DoanhThu.Name = "lb_DoanhThu";
            this.lb_DoanhThu.Size = new System.Drawing.Size(44, 16);
            this.lb_DoanhThu.TabIndex = 9;
            this.lb_DoanhThu.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng doanh thu :";
            // 
            // lb_soLuongDonHang
            // 
            this.lb_soLuongDonHang.AutoSize = true;
            this.lb_soLuongDonHang.Location = new System.Drawing.Point(136, 32);
            this.lb_soLuongDonHang.Name = "lb_soLuongDonHang";
            this.lb_soLuongDonHang.Size = new System.Drawing.Size(44, 16);
            this.lb_soLuongDonHang.TabIndex = 7;
            this.lb_soLuongDonHang.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số đơn hàng :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Loc);
            this.groupBox4.Controls.Add(this.btn_PhieuDonHang);
            this.groupBox4.Controls.Add(this.btn_xemDonHang);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.dtp_NgayKetThuc);
            this.groupBox4.Controls.Add(this.dtp_NgayBatDau);
            this.groupBox4.Controls.Add(this.btn_SapXep);
            this.groupBox4.Location = new System.Drawing.Point(391, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(761, 172);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lọc";
            // 
            // btn_Loc
            // 
            this.btn_Loc.Location = new System.Drawing.Point(583, 14);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(155, 32);
            this.btn_Loc.TabIndex = 10;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = true;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // btn_PhieuDonHang
            // 
            this.btn_PhieuDonHang.Location = new System.Drawing.Point(583, 134);
            this.btn_PhieuDonHang.Name = "btn_PhieuDonHang";
            this.btn_PhieuDonHang.Size = new System.Drawing.Size(155, 32);
            this.btn_PhieuDonHang.TabIndex = 9;
            this.btn_PhieuDonHang.Text = "Phiếu đơn hàng";
            this.btn_PhieuDonHang.UseVisualStyleBackColor = true;
            // 
            // btn_xemDonHang
            // 
            this.btn_xemDonHang.Location = new System.Drawing.Point(583, 90);
            this.btn_xemDonHang.Name = "btn_xemDonHang";
            this.btn_xemDonHang.Size = new System.Drawing.Size(155, 32);
            this.btn_xemDonHang.TabIndex = 8;
            this.btn_xemDonHang.Text = "Xem đơn hàng";
            this.btn_xemDonHang.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kết thúc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bắt đầu";
            // 
            // dtp_NgayKetThuc
            // 
            this.dtp_NgayKetThuc.Location = new System.Drawing.Point(27, 111);
            this.dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            this.dtp_NgayKetThuc.Size = new System.Drawing.Size(343, 22);
            this.dtp_NgayKetThuc.TabIndex = 2;
            // 
            // dtp_NgayBatDau
            // 
            this.dtp_NgayBatDau.Location = new System.Drawing.Point(27, 53);
            this.dtp_NgayBatDau.Name = "dtp_NgayBatDau";
            this.dtp_NgayBatDau.Size = new System.Drawing.Size(343, 22);
            this.dtp_NgayBatDau.TabIndex = 1;
            // 
            // btn_SapXep
            // 
            this.btn_SapXep.Location = new System.Drawing.Point(583, 52);
            this.btn_SapXep.Name = "btn_SapXep";
            this.btn_SapXep.Size = new System.Drawing.Size(155, 32);
            this.btn_SapXep.TabIndex = 0;
            this.btn_SapXep.Text = "Sắp Xếp";
            this.btn_SapXep.UseVisualStyleBackColor = true;
            // 
            // ThongKeDonHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 709);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongKeDonHangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hóa đơn";
            this.Load += new System.EventHandler(this.ThongKeDonHangForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DSDH;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_LocTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_DoanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_soLuongDonHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_PhieuDonHang;
        private System.Windows.Forms.Button btn_xemDonHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_NgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtp_NgayBatDau;
        private System.Windows.Forms.Button btn_SapXep;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.Label lb_ThongBaoDS;
    }
}