using BTL_DEMO_3.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_DEMO_3.GUI.NhapLieu
{
    public partial class NhapSanPhamForm : Form
    {
        NhapHangDAO nhapHangDAO = new NhapHangDAO();
        public NhapSanPhamForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void loadNH()
        {
            DataSet dataSet = nhapHangDAO.getDSNhapHang();
            dgv_DSNhapHang.Rows.Clear();
            dgv_DSNhapHang.Visible = true;
            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
            {
                lb_ThongBaoDS.Visible = false;
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    dgv_DSNhapHang.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                dgv_DSNhapHang.Visible = false;
                lb_ThongBaoDS.Visible = true;
                lb_ThongBaoDS.Text = "Khong co ban ghi nao";
            }
        }
        private void InitializeDataGridView()
        {
            // Thêm các cột vào DataGridView
            dgv_DSNhapHang.ColumnCount = 5;
            dgv_DSNhapHang.Columns[0].Name = "Mã nhập hàng";
            dgv_DSNhapHang.Columns[1].Name = "Mã sản phẩm";
            dgv_DSNhapHang.Columns[2].Name = "Mã nhân viên";
            dgv_DSNhapHang.Columns[3].Name = "Số lượng nhập";
            dgv_DSNhapHang.Columns[4].Name = "Ngày nhập";



            // Không cho phép chỉnh sửa dữ liệu trực tiếp trên DataGridView
            dgv_DSNhapHang.ReadOnly = true;
            // Cài đặt chế độ hiển thị dữ liệu đầy đủ trên DataGridView
            dgv_DSNhapHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DSNhapHang.AllowUserToAddRows = false;
        }

        private void btn_NhapHangForm_Click(object sender, EventArgs e)
        {
            ChiTietNhaphangForm chiTietNhaphangForm = new ChiTietNhaphangForm();
            chiTietNhaphangForm.ShowDialog();
            loadNH();
        }

        private void NhapSanPhamForm_Load(object sender, EventArgs e)
        {
           loadNH();
        }


    }
}
