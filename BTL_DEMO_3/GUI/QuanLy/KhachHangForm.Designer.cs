namespace BTL_DEMO_3.GUI.QuanLy
{
    partial class KhachHangForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_LuaChonTimKiem = new System.Windows.Forms.ComboBox();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_ThongBaoDS = new System.Windows.Forms.Label();
            this.dgv_KH = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbb_LuaChonTimKiem);
            this.groupBox2.Controls.Add(this.tb_TimKiem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.tb_HoTen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_DiaChi);
            this.groupBox2.Controls.Add(this.tb_SDT);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1067, 214);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // cbb_LuaChonTimKiem
            // 
            this.cbb_LuaChonTimKiem.FormattingEnabled = true;
            this.cbb_LuaChonTimKiem.Items.AddRange(new object[] {
            "Tên KH",
            "SĐT"});
            this.cbb_LuaChonTimKiem.Location = new System.Drawing.Point(537, 149);
            this.cbb_LuaChonTimKiem.Name = "cbb_LuaChonTimKiem";
            this.cbb_LuaChonTimKiem.Size = new System.Drawing.Size(146, 24);
            this.cbb_LuaChonTimKiem.TabIndex = 35;
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(40, 154);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(394, 22);
            this.tb_TimKiem.TabIndex = 35;
            this.tb_TimKiem.Click += new System.EventHandler(this.tb_TimKiem_TextChanged);
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
            this.label5.Location = new System.Drawing.Point(285, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Số điện thoại";
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
            // tb_HoTen
            // 
            this.tb_HoTen.Location = new System.Drawing.Point(40, 75);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(146, 22);
            this.tb_HoTen.TabIndex = 33;
            this.tb_HoTen.Validating += new System.ComponentModel.CancelEventHandler(this.tb_HoTen_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Họ và tên";
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(537, 73);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(146, 22);
            this.tb_DiaChi.TabIndex = 27;
            this.tb_DiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.tb_DiaChi_Validating);
            // 
            // tb_SDT
            // 
            this.tb_SDT.Location = new System.Drawing.Point(288, 73);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(146, 22);
            this.tb_SDT.TabIndex = 31;
            this.tb_SDT.Validating += new System.ComponentModel.CancelEventHandler(this.tb_SDT_Validating);
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
            this.groupBox1.Controls.Add(this.dgv_KH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 344);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // lb_ThongBaoDS
            // 
            this.lb_ThongBaoDS.AutoSize = true;
            this.lb_ThongBaoDS.Location = new System.Drawing.Point(513, 52);
            this.lb_ThongBaoDS.Name = "lb_ThongBaoDS";
            this.lb_ThongBaoDS.Size = new System.Drawing.Size(73, 16);
            this.lb_ThongBaoDS.TabIndex = 37;
            this.lb_ThongBaoDS.Text = "Thông báo";
            this.lb_ThongBaoDS.Visible = false;
            // 
            // dgv_KH
            // 
            this.dgv_KH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KH.BackgroundColor = System.Drawing.Color.White;
            this.dgv_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KH.Location = new System.Drawing.Point(7, 37);
            this.dgv_KH.Name = "dgv_KH";
            this.dgv_KH.RowHeadersWidth = 51;
            this.dgv_KH.RowTemplate.Height = 24;
            this.dgv_KH.Size = new System.Drawing.Size(1074, 301);
            this.dgv_KH.TabIndex = 0;
            this.dgv_KH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KH_CellClick);
            // 
            // KhachHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KhachHangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.KhachHangForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_ThongBaoDS;
        private System.Windows.Forms.DataGridView dgv_KH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_LuaChonTimKiem;
    }
}