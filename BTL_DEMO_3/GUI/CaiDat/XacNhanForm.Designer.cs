namespace BTL_DEMO_3.GUI.CaiDat
{
    partial class XacNhanForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_matKhau = new System.Windows.Forms.TextBox();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu";
            // 
            // tb_matKhau
            // 
            this.tb_matKhau.Location = new System.Drawing.Point(117, 58);
            this.tb_matKhau.Name = "tb_matKhau";
            this.tb_matKhau.Size = new System.Drawing.Size(333, 22);
            this.tb_matKhau.TabIndex = 1;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhan.Location = new System.Drawing.Point(15, 124);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(153, 45);
            this.btn_XacNhan.TabIndex = 2;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(297, 124);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(153, 45);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // XacNhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 215);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.tb_matKhau);
            this.Controls.Add(this.label1);
            this.Name = "XacNhanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XacNhanForm";
            this.Load += new System.EventHandler(this.XacNhanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_matKhau;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Button btn_thoat;
    }
}