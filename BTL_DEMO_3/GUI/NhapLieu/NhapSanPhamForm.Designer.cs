namespace BTL_DEMO_3.GUI.NhapLieu
{
    partial class NhapSanPhamForm
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
            this.dgv_DSNhapHang = new System.Windows.Forms.DataGridView();
            this.btn_NhapHangForm = new System.Windows.Forms.Button();
            this.lb_ThongBaoDS = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_ThongBaoDS);
            this.groupBox1.Controls.Add(this.dgv_DSNhapHang);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch sử nhập hàng";
            // 
            // dgv_DSNhapHang
            // 
            this.dgv_DSNhapHang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DSNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSNhapHang.Location = new System.Drawing.Point(7, 22);
            this.dgv_DSNhapHang.Name = "dgv_DSNhapHang";
            this.dgv_DSNhapHang.RowHeadersWidth = 51;
            this.dgv_DSNhapHang.RowTemplate.Height = 24;
            this.dgv_DSNhapHang.Size = new System.Drawing.Size(1034, 359);
            this.dgv_DSNhapHang.TabIndex = 0;
            // 
            // btn_NhapHangForm
            // 
            this.btn_NhapHangForm.Location = new System.Drawing.Point(20, 445);
            this.btn_NhapHangForm.Name = "btn_NhapHangForm";
            this.btn_NhapHangForm.Size = new System.Drawing.Size(120, 30);
            this.btn_NhapHangForm.TabIndex = 3;
            this.btn_NhapHangForm.Text = "Nhập hàng";
            this.btn_NhapHangForm.UseVisualStyleBackColor = true;
            this.btn_NhapHangForm.Click += new System.EventHandler(this.btn_NhapHangForm_Click);
            // 
            // lb_ThongBaoDS
            // 
            this.lb_ThongBaoDS.AutoSize = true;
            this.lb_ThongBaoDS.Location = new System.Drawing.Point(461, 37);
            this.lb_ThongBaoDS.Name = "lb_ThongBaoDS";
            this.lb_ThongBaoDS.Size = new System.Drawing.Size(44, 16);
            this.lb_ThongBaoDS.TabIndex = 1;
            this.lb_ThongBaoDS.Text = "label1";
            this.lb_ThongBaoDS.Visible = false;
            // 
            // NhapSanPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 501);
            this.Controls.Add(this.btn_NhapHangForm);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhapSanPhamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử nhập hàng";
            this.Load += new System.EventHandler(this.NhapSanPhamForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSNhapHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DSNhapHang;
        private System.Windows.Forms.Button btn_NhapHangForm;
        private System.Windows.Forms.Label lb_ThongBaoDS;
    }
}