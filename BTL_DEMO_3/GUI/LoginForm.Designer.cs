namespace BTL_DEMO_3
{
    partial class LoginForm
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
            this.lb_DangNhapThaiBai = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.tb_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_DangNhapThaiBai
            // 
            this.lb_DangNhapThaiBai.AutoSize = true;
            this.lb_DangNhapThaiBai.ForeColor = System.Drawing.Color.Red;
            this.lb_DangNhapThaiBai.Location = new System.Drawing.Point(250, 357);
            this.lb_DangNhapThaiBai.Name = "lb_DangNhapThaiBai";
            this.lb_DangNhapThaiBai.Size = new System.Drawing.Size(0, 16);
            this.lb_DangNhapThaiBai.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(211, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 22);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // cb_HienMatKhau
            // 
            this.cb_HienMatKhau.AutoSize = true;
            this.cb_HienMatKhau.Location = new System.Drawing.Point(445, 256);
            this.cb_HienMatKhau.Name = "cb_HienMatKhau";
            this.cb_HienMatKhau.Size = new System.Drawing.Size(114, 20);
            this.cb_HienMatKhau.TabIndex = 39;
            this.cb_HienMatKhau.Text = "Hiện mật khẩu";
            this.cb_HienMatKhau.UseVisualStyleBackColor = true;
            this.cb_HienMatKhau.CheckedChanged += new System.EventHandler(this.cb_HienMatKhau_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(211, 228);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 22);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Location = new System.Drawing.Point(253, 228);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.PasswordChar = '*';
            this.tb_MatKhau.Size = new System.Drawing.Size(306, 22);
            this.tb_MatKhau.TabIndex = 37;
            // 
            // tb_TenTaiKhoan
            // 
            this.tb_TenTaiKhoan.Location = new System.Drawing.Point(253, 174);
            this.tb_TenTaiKhoan.Name = "tb_TenTaiKhoan";
            this.tb_TenTaiKhoan.Size = new System.Drawing.Size(306, 22);
            this.tb_TenTaiKhoan.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 27);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cửa Hàng Điện Thoại";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Location = new System.Drawing.Point(253, 315);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(289, 39);
            this.btn_DangNhap.TabIndex = 33;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 525);
            this.Controls.Add(this.lb_DangNhapThaiBai);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_HienMatKhau);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tb_MatKhau);
            this.Controls.Add(this.tb_TenTaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DangNhap);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DangNhapThaiBai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cb_HienMatKhau;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.TextBox tb_TenTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DangNhap;
    }
}

