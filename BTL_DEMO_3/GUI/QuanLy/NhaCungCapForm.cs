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

namespace BTL_DEMO_3.GUI.QuanLy
{
    public partial class NhaCungCapForm : Form
    {
        NhaCungCapDAO NhaCungCapDAO = new NhaCungCapDAO();
        public NhaCungCapForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void NhaCungCapForm_Load(object sender, EventArgs e)
        {
            loadNCC();
        }

        private void loadNCC()
        {
            DataSet dataSet = NhaCungCapDAO.getNhaCungCup();
            dgv_NCC.Rows.Clear();
            dgv_NCC.Visible = true;
            
            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
            {
                lb_ThongBaoDS.Visible = false;
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    dgv_NCC.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                dgv_NCC.Visible = false;
                lb_ThongBaoDS.Visible = true;
                lb_ThongBaoDS.Text = " Không có bản ghi nào";
            }
        }
        private void InitializeDataGridView()
        {
            // Thêm các cột vào DataGridView
            dgv_NCC.ColumnCount = 4;
            dgv_NCC.Columns[0].Name = "Mã nhà cung cấp";
            dgv_NCC.Columns[1].Name = "Tên nhà cung cấp";
            dgv_NCC.Columns[2].Name = "Hotline";
            dgv_NCC.Columns[3].Name = "Email";



            // Không cho phép chỉnh sửa dữ liệu trực tiếp trên DataGridView
            dgv_NCC.ReadOnly = true;
            // Cài đặt chế độ hiển thị dữ liệu đầy đủ trên DataGridView
            dgv_NCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_NCC.AllowUserToAddRows = false;
        }

        private void tb_themNCC_Click(object sender, EventArgs e)
        {
            if (tb_maNCC.Text != string.Empty && tb_TenNCC.Text != string.Empty && tb_hotline.Text != string.Empty && tb_EmailNCC.Text != string.Empty)
            {
                string maNCC = tb_maNCC.Text.Trim();
                string tenNCC = tb_TenNCC.Text.Trim();
                string hotline = tb_hotline.Text.Trim();
                string email = tb_EmailNCC.Text.Trim();

                int result = NhaCungCapDAO.themNhaCungCap(maNCC, tenNCC, hotline, email);

                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công !!");
                    loadNCC();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại !!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!");
            }
        }

        private void btn_suaNCC_Click(object sender, EventArgs e)
        {
            if (tb_maNCC.Text != string.Empty && tb_TenNCC.Text != string.Empty && tb_hotline.Text != string.Empty && tb_EmailNCC.Text != string.Empty)
            {
                string maNCC = tb_maNCC.Text.Trim();
                string tenNCC = tb_TenNCC.Text.Trim();
                string hotline = tb_hotline.Text.Trim();
                string email = tb_EmailNCC.Text.Trim();

                int result = NhaCungCapDAO.suaNhaCungCap(maNCC, tenNCC, hotline, email);

                if (result > 0)
                {
                    MessageBox.Show("Sửa thành công !!");
                    loadNCC();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại !!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!");
            }
        }

        private void btn_XoaNCC_Click(object sender, EventArgs e)
        {
            if (tb_maNCC.Text != string.Empty)
            {
                int result = NhaCungCapDAO.xoaNhaCungCap(tb_maNCC.Text.ToString().Trim());
                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công !!");
                    loadNCC();
                    tb_maNCC.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp !!");
            }
        }

        private void btn_resetNCC_Click(object sender, EventArgs e)
        {
            if (tb_maNCC.Text != string.Empty || tb_TenNCC.Text != string.Empty || tb_hotline.Text != string.Empty || tb_EmailNCC.Text != string.Empty || tb_TimKiemNCC.Text != string.Empty)
            {
                tb_EmailNCC.Text = string.Empty;
                tb_TimKiemNCC.Text = string.Empty;
                tb_TenNCC.Text = string.Empty;
                tb_maNCC.Text = string.Empty;
                tb_hotline.Text = string.Empty;

                tb_maNCC.ReadOnly = false;
            }
        }

        private void dgv_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_maNCC.ReadOnly = true;
            int indexRow = e.RowIndex;
            if (indexRow >= 0 && indexRow <= dgv_NCC.Rows.Count)
            {
                DataGridViewRow selectIndex = dgv_NCC.Rows[indexRow];
                tb_maNCC.Text = selectIndex.Cells[0].Value.ToString();
                tb_TenNCC.Text = selectIndex.Cells[1].Value.ToString();
                tb_hotline.Text = selectIndex.Cells[2].Value.ToString();
                tb_EmailNCC.Text = selectIndex.Cells[3].Value.ToString();

            }
        }

        



        private void tb_TimKiemNCC_TextChanged(object sender, EventArgs e)
        {
            if (cbb_LuaChonTimKiem.Text.Equals("Mã nhà cung cấp"))
            {
                DataSet data = NhaCungCapDAO.tim_MaNCC(tb_TimKiemNCC.Text.Trim());
                loadDSTK(data);
            }
            else if (cbb_LuaChonTimKiem.Text.Equals("Tên nhà cung cấp"))
            {
                DataSet data = NhaCungCapDAO.tim_TenNCC(tb_TimKiemNCC.Text.Trim());
                loadDSTK(data);
            }
            else if (cbb_LuaChonTimKiem.Text.Equals("Hotline"))
            {
                DataSet data = NhaCungCapDAO.tim_Hotline(tb_TimKiemNCC.Text.Trim());
                loadDSTK(data);
            }
            else if (cbb_LuaChonTimKiem.Text.Equals("Email"))
            {
                DataSet data = NhaCungCapDAO.tim_Email(tb_TimKiemNCC.Text.Trim());
                loadDSTK(data);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục cần tìm kiếm ");
            }
        }

        private void loadDSTK( DataSet ds )
        {
            dgv_NCC.Rows.Clear();
            dgv_NCC.Visible = true;
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables.Count > 0)
            {
                lb_ThongBaoDS.Visible = false;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dgv_NCC.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                dgv_NCC.Visible = false;
                lb_ThongBaoDS.Visible = true;
                lb_ThongBaoDS.Text = " Không thấy nhà cung cấp";
            }
        }
    }
}
