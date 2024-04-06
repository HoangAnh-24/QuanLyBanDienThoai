using BTL_DEMO_3.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_DEMO_3.GUI.QuanLy
{
    public partial class TaiKhoanForm : Form
    {
        TaiKhoanDAO TaiKhoanDAO = new TaiKhoanDAO();
        public TaiKhoanForm()
        {
            InitializeComponent();
            initDatagridview();
        }

        private void TaiKhoanForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanDienThoai_demo_3DataSet.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this.quanLyBanDienThoai_demo_3DataSet.tblNhanVien);
            cbb_MaNV.SelectedIndex = -1;
            LoadDS();
        }

        private void initDatagridview()
        {
            dgv_TK.ColumnCount = 4;
            dgv_TK.Columns[0].Name = "Mã nhân viên";
            dgv_TK.Columns[1].Name = "Tên đăng nhập";
            dgv_TK.Columns[2].Name = "Mật khẩu";
            dgv_TK.Columns[3].Name = "Quyền truy cập";
            dgv_TK.ReadOnly = true;//khong cho sua chi cho doc
            dgv_TK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_TK.AllowUserToAddRows = false;//tranh nguoi dung them cot
        }

        private void LoadDS()
        {
            //nhan du lieu tu DAO
            DataSet dataSet = TaiKhoanDAO.getDSTaiKhoan();
            dgv_TK.Rows.Clear();
            //dem so hang trong bang   //dem bang 
            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
            {
                //duyet tung hang trong bang roi them tung hang vao datagrv
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    dgv_TK.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                dgv_TK.Visible = false;
                lb_ThongBaoDS.Visible = true;
                lb_ThongBaoDS.Text = "Không có bản ghi nào";
            }
        }

        private bool checkQuyen(string quyen)
        {
            if (quyen.Equals("Quản lý"))
            {
                return true;
            }
            else if (quyen.Equals("Nhân viên"))
            {
                return false;
            }
            return false;
        }

        private string getQuyen(bool quyen)
        {
            if (quyen == true)
            {
                return "Quản lý";
            }
            else if (quyen == false)
            {
                return "Nhân viên";
            }
            return "Nhân viên";
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            int res = 0;

            if (cbb_MaNV.Text != string.Empty && tb_TenDangNhap.Text != string.Empty && tb_MatKhau.Text != string.Empty && cbb_QuyenTaiKhoan.Text != string.Empty)
            {

                try
                {
                    res = TaiKhoanDAO.themTaiKhoan(cbb_MaNV.Text.Trim(), tb_TenDangNhap.Text.Trim(), tb_MatKhau.Text.Trim(), checkQuyen(cbb_QuyenTaiKhoan.Text));
                }
                catch (SqlException ex)
                {

                    if ( ex.Number == 2627) 
                    {
                        // Xử lý lỗi khi chèn trùng lặp vào bảng tblHopDong
                        MessageBox.Show("Nhân viên đã có tài khoản");
                    }
                    else if (ex.Number == 2601)
                    {
                        MessageBox.Show("Tên đăng nhập dã tồn tại");
                    }
                    else
                    {
                        // Xử lý các loại lỗi khác từ cơ sở dữ liệu
                        MessageBox.Show("Lỗi không xác định: " + ex.Message);
                    }
                }

                if (res > 0)
                {
                    MessageBox.Show("Thành công!!");
                    LoadDS();
                }
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int res = 0;

            if (cbb_MaNV.Text != string.Empty && tb_TenDangNhap.Text != string.Empty && tb_MatKhau.Text != string.Empty && cbb_QuyenTaiKhoan.Text != string.Empty)
            {
                res = TaiKhoanDAO.suaTaiKhoan(cbb_MaNV.Text.Trim(), tb_TenDangNhap.Text.Trim(), tb_MatKhau.Text.Trim(), checkQuyen(cbb_QuyenTaiKhoan.Text));

                if (res > 0)
                {
                    MessageBox.Show("Thành công!!");
                    LoadDS();
                }
                else
                {
                    MessageBox.Show("Thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int res = 0;
            if (tb_TenDangNhap.Text != string.Empty)
            {
                res = TaiKhoanDAO.xoaTaiKhoan(tb_TenDangNhap.Text.Trim());

                if (res > 0)
                {
                    MessageBox.Show("Thành công!!");
                    LoadDS();
                }
                else
                {
                    MessageBox.Show("Thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập");
            }

        }

        private void dgv_TK_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int indexrow = e.RowIndex;
            if (indexrow >= 0 && indexrow <= dgv_TK.Rows.Count)
            {
                DataGridViewRow selectindex = dgv_TK.Rows[indexrow];
                cbb_MaNV.Text = selectindex.Cells[0].Value.ToString();
                tb_TenDangNhap.Text = selectindex.Cells[1].Value.ToString();
                tb_MatKhau.Text = selectindex.Cells[2].Value.ToString();
                cbb_QuyenTaiKhoan.Text = getQuyen((bool)selectindex.Cells[3].Value).ToString();
                
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbb_LuaChonTimKiem.Text == "Tên đăng nhập")
            {
                string tenTK = tb_TimKiem.Text;
                DataSet result = TaiKhoanDAO.tim_TenDangNhap(tenTK);
                dgv_TK.Rows.Clear();
                if (result.Tables[0].Rows.Count > 0 && result.Tables.Count > 0)
                {
                    foreach (DataRow row in result.Tables[0].Rows)
                    {
                        dgv_TK.Rows.Add(row.ItemArray);
                    }
                }
                else
                {
                    lb_ThongBaoDS.Visible = true;
                    lb_ThongBaoDS.Text = "Không có bản ghi nào";
                }
            }
            else
          if (cbb_LuaChonTimKiem.Text == "Mã nhân viên")
            {
                string MaNV = tb_TimKiem.Text;
                DataSet result = TaiKhoanDAO.tim_MaN(MaNV);
                dgv_TK.Rows.Clear();
                if (result.Tables[0].Rows.Count > 0 && result.Tables.Count > 0)
                {
                    foreach (DataRow row in result.Tables[0].Rows)
                    {
                        dgv_TK.Rows.Add(row.ItemArray);
                    }
                }
                else
                {
                    lb_ThongBaoDS.Visible = true;
                    lb_ThongBaoDS.Text = "Không có bản ghi nào";
                }

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (cbb_MaNV.Text.Trim() != "" || tb_TenDangNhap.Text.Trim() != "" || tb_MatKhau.Text.Trim() != "" || cbb_QuyenTaiKhoan.Text.Trim() != "" || tb_TimKiem.Text.Trim() != "" || cbb_LuaChonTimKiem.Text.Trim() != "")
            {
                cbb_MaNV.Text = string.Empty;
                tb_TenDangNhap.Text = string.Empty;
                tb_MatKhau.Text = string.Empty;
                cbb_QuyenTaiKhoan.Text = string.Empty;
                tb_TimKiem.Text = string.Empty;
                cbb_LuaChonTimKiem.Text = string.Empty;
                dgv_TK.ReadOnly = false;
            }
        }

        private void dgv_TK_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_TK.Columns[e.ColumnIndex].Name == "Quyền truy cập")
            {
                if (e.Value != null && (bool)e.Value == true)
                {
                    e.Value = getQuyen((bool)e.Value);
                }
                else if (e.Value != null && (bool)e.Value == false)
                {
                    e.Value = getQuyen((bool)e.Value);
                }
            }
        }
    }
}
