namespace BTL_DEMO_3.GUI.QuanLy
{
    partial class NhaCungCapForm
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
            this.lb_ThongBaoDS = new System.Windows.Forms.Label();
            this.dgv_NCC = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_LuaChonTimKiem = new System.Windows.Forms.ComboBox();
            this.tb_themNCC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_TimKiemNCC = new System.Windows.Forms.TextBox();
            this.tb_EmailNCC = new System.Windows.Forms.TextBox();
            this.tb_hotline = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_TenNCC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_resetNCC = new System.Windows.Forms.Button();
            this.btn_XoaNCC = new System.Windows.Forms.Button();
            this.btn_suaNCC = new System.Windows.Forms.Button();
            this.tb_maNCC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_ThongBaoDS);
            this.groupBox2.Controls.Add(this.dgv_NCC);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1091, 395);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // lb_ThongBaoDS
            // 
            this.lb_ThongBaoDS.AutoSize = true;
            this.lb_ThongBaoDS.Location = new System.Drawing.Point(513, 59);
            this.lb_ThongBaoDS.Name = "lb_ThongBaoDS";
            this.lb_ThongBaoDS.Size = new System.Drawing.Size(73, 16);
            this.lb_ThongBaoDS.TabIndex = 38;
            this.lb_ThongBaoDS.Text = "Thông báo";
            this.lb_ThongBaoDS.Visible = false;
            // 
            // dgv_NCC
            // 
            this.dgv_NCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NCC.BackgroundColor = System.Drawing.Color.White;
            this.dgv_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NCC.Location = new System.Drawing.Point(29, 22);
            this.dgv_NCC.Name = "dgv_NCC";
            this.dgv_NCC.RowHeadersWidth = 51;
            this.dgv_NCC.RowTemplate.Height = 24;
            this.dgv_NCC.Size = new System.Drawing.Size(1056, 367);
            this.dgv_NCC.TabIndex = 0;
            this.dgv_NCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NCC_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbb_LuaChonTimKiem);
            this.groupBox1.Controls.Add(this.tb_themNCC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_TimKiemNCC);
            this.groupBox1.Controls.Add(this.tb_EmailNCC);
            this.groupBox1.Controls.Add(this.tb_hotline);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tb_TenNCC);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btn_resetNCC);
            this.groupBox1.Controls.Add(this.btn_XoaNCC);
            this.groupBox1.Controls.Add(this.btn_suaNCC);
            this.groupBox1.Controls.Add(this.tb_maNCC);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1105, 274);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // cbb_LuaChonTimKiem
            // 
            this.cbb_LuaChonTimKiem.FormattingEnabled = true;
            this.cbb_LuaChonTimKiem.Items.AddRange(new object[] {
            "Mã nhà cung cấp",
            "Tên nhà cung cấp",
            "Hotline",
            "Email"});
            this.cbb_LuaChonTimKiem.Location = new System.Drawing.Point(639, 180);
            this.cbb_LuaChonTimKiem.Name = "cbb_LuaChonTimKiem";
            this.cbb_LuaChonTimKiem.Size = new System.Drawing.Size(146, 24);
            this.cbb_LuaChonTimKiem.TabIndex = 27;
            // 
            // tb_themNCC
            // 
            this.tb_themNCC.Location = new System.Drawing.Point(945, 36);
            this.tb_themNCC.Name = "tb_themNCC";
            this.tb_themNCC.Size = new System.Drawing.Size(113, 30);
            this.tb_themNCC.TabIndex = 26;
            this.tb_themNCC.Text = "Thêm";
            this.tb_themNCC.UseVisualStyleBackColor = true;
            this.tb_themNCC.Click += new System.EventHandler(this.tb_themNCC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tìm kiếm :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(636, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Email";
            // 
            // tb_TimKiemNCC
            // 
            this.tb_TimKiemNCC.Location = new System.Drawing.Point(49, 180);
            this.tb_TimKiemNCC.Name = "tb_TimKiemNCC";
            this.tb_TimKiemNCC.Size = new System.Drawing.Size(560, 22);
            this.tb_TimKiemNCC.TabIndex = 22;
            this.tb_TimKiemNCC.TextChanged += new System.EventHandler(this.tb_TimKiemNCC_TextChanged);
            // 
            // tb_EmailNCC
            // 
            this.tb_EmailNCC.Location = new System.Drawing.Point(639, 95);
            this.tb_EmailNCC.Name = "tb_EmailNCC";
            this.tb_EmailNCC.Size = new System.Drawing.Size(146, 22);
            this.tb_EmailNCC.TabIndex = 21;
            // 
            // tb_hotline
            // 
            this.tb_hotline.Location = new System.Drawing.Point(463, 95);
            this.tb_hotline.Name = "tb_hotline";
            this.tb_hotline.Size = new System.Drawing.Size(146, 22);
            this.tb_hotline.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Hotline ";
            // 
            // tb_TenNCC
            // 
            this.tb_TenNCC.Location = new System.Drawing.Point(262, 95);
            this.tb_TenNCC.Name = "tb_TenNCC";
            this.tb_TenNCC.Size = new System.Drawing.Size(146, 22);
            this.tb_TenNCC.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tên nhà cung cấp";
            // 
            // btn_resetNCC
            // 
            this.btn_resetNCC.Location = new System.Drawing.Point(945, 186);
            this.btn_resetNCC.Name = "btn_resetNCC";
            this.btn_resetNCC.Size = new System.Drawing.Size(113, 30);
            this.btn_resetNCC.TabIndex = 15;
            this.btn_resetNCC.Text = "Reset";
            this.btn_resetNCC.UseVisualStyleBackColor = true;
            this.btn_resetNCC.Click += new System.EventHandler(this.btn_resetNCC_Click);
            // 
            // btn_XoaNCC
            // 
            this.btn_XoaNCC.Location = new System.Drawing.Point(945, 141);
            this.btn_XoaNCC.Name = "btn_XoaNCC";
            this.btn_XoaNCC.Size = new System.Drawing.Size(113, 30);
            this.btn_XoaNCC.TabIndex = 14;
            this.btn_XoaNCC.Text = "Xóa";
            this.btn_XoaNCC.UseVisualStyleBackColor = true;
            this.btn_XoaNCC.Click += new System.EventHandler(this.btn_XoaNCC_Click);
            // 
            // btn_suaNCC
            // 
            this.btn_suaNCC.Location = new System.Drawing.Point(945, 87);
            this.btn_suaNCC.Name = "btn_suaNCC";
            this.btn_suaNCC.Size = new System.Drawing.Size(113, 30);
            this.btn_suaNCC.TabIndex = 13;
            this.btn_suaNCC.Text = "Sửa";
            this.btn_suaNCC.UseVisualStyleBackColor = true;
            this.btn_suaNCC.Click += new System.EventHandler(this.btn_suaNCC_Click);
            // 
            // tb_maNCC
            // 
            this.tb_maNCC.Location = new System.Drawing.Point(49, 95);
            this.tb_maNCC.Name = "tb_maNCC";
            this.tb_maNCC.Size = new System.Drawing.Size(146, 22);
            this.tb_maNCC.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã nhà cung cấp";
            // 
            // NhaCungCapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 698);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhaCungCapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.NhaCungCapForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_ThongBaoDS;
        private System.Windows.Forms.DataGridView dgv_NCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_LuaChonTimKiem;
        private System.Windows.Forms.Button tb_themNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_TimKiemNCC;
        private System.Windows.Forms.TextBox tb_EmailNCC;
        private System.Windows.Forms.TextBox tb_hotline;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_TenNCC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_resetNCC;
        private System.Windows.Forms.Button btn_XoaNCC;
        private System.Windows.Forms.Button btn_suaNCC;
        private System.Windows.Forms.TextBox tb_maNCC;
        private System.Windows.Forms.Label label12;
    }
}