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
    public partial class NhanVienForm : Form
    {
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        ErrorProvider errorProvider1 = new ErrorProvider();
        public NhanVienForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        public void LoadData()
        {
            DataSet dataSet = nhanVienDAO.getDsNV();

            dgv_NV.Rows.Clear();
            dgv_NV.Visible = true;


            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
            {
                lb_ThongBaoDS.Visible = false;
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    dgv_NV.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                dgv_NV.Visible = false;
                lb_ThongBaoDS.Visible = true;
                lb_ThongBaoDS.Text = "Không có bản ghi";
            }
        }

        private void InitializeDataGridView()
        {
            // Thêm các cột vào DataGridView
            dgv_NV.ColumnCount = 7;
            dgv_NV.Columns[0].Name = "Mã nhân viên";
            dgv_NV.Columns[1].Name = "Tên nhân viên";
            dgv_NV.Columns[2].Name = "Giới tính";
            dgv_NV.Columns[3].Name = "Ngày Sinh";
            dgv_NV.Columns[4].Name = "Số điện thoại";
            dgv_NV.Columns[5].Name = "Địa chỉ";
            dgv_NV.Columns[6].Name = "Email";


            // Không cho phép chỉnh sửa dữ liệu trực tiếp trên DataGridView
            dgv_NV.ReadOnly = true;
            // Cài đặt chế độ hiển thị dữ liệu đầy đủ trên DataGridView
            dgv_NV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_NV.AllowUserToAddRows = false;
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            if (tb_MaNV.Text != string.Empty
                && tb_HoTen.Text != string.Empty
                && tb_SDT.Text != string.Empty
                && tb_Email.Text != string.Empty
                && tb_QueQuan.Text != string.Empty
                && cbb_GT.Text != string.Empty
                && dtp_ngaySinh.Text != string.Empty
                )
            {
                string maNV = tb_MaNV.Text.Trim();
                string tenNV = tb_HoTen.Text.Trim();
                bool gioiTinh = (cbb_GT.Text.Trim() == "Nam") ? true : false;
                DateTime ngaySinh = DateTime.Parse(dtp_ngaySinh.Text);
                string sDT = tb_SDT.Text.Trim();
                string diaChi = tb_QueQuan.Text.Trim();
                string email = tb_Email.Text.Trim();

                try
                {
                    int result = nhanVienDAO.them_NV(maNV, tenNV, gioiTinh, ngaySinh, diaChi, sDT, email);

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm thành công !!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!!");
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại !!");
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin !!");
            }
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            if (tb_MaNV.Text != string.Empty
                && tb_HoTen.Text != string.Empty
                && tb_SDT.Text != string.Empty
                && tb_Email.Text != string.Empty
                && tb_QueQuan.Text != string.Empty
                && cbb_GT.Text != string.Empty
                && dtp_ngaySinh.Text != string.Empty
                )
            {
                string maNV = tb_MaNV.Text.Trim();
                string tenNV = tb_HoTen.Text.Trim();
                bool gioiTinh = (cbb_GT.Text.Trim() == "Nam") ? true : false;
                DateTime ngaySinh = DateTime.Parse(dtp_ngaySinh.Text);
                string sDT = tb_SDT.Text.Trim();
                string diaChi = tb_QueQuan.Text.Trim();
                string email = tb_Email.Text.Trim();

                try
                {
                    int result = nhanVienDAO.sua_NV(maNV, tenNV, gioiTinh, ngaySinh, diaChi, sDT, email);

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thành công !!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Sua thất bại !!");
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại !!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!");
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (tb_MaNV.Text != string.Empty)
            {
                try
                {
                    int result = nhanVienDAO.xoa_NV(tb_MaNV.Text.Trim());
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa thành công !!");
                        LoadData();
                        tb_MaNV.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại !!");
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Không thể xóa nhân viên !!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên !!");
            }

        }

        private void btn_resetNV_Click(object sender, EventArgs e)
        {
            if (tb_MaNV.Text != string.Empty
                || tb_HoTen.Text != string.Empty
                || tb_SDT.Text != string.Empty
                || tb_Email.Text != string.Empty
                || tb_QueQuan.Text != string.Empty
                || cbb_GT.Text != string.Empty
                || dtp_ngaySinh.Text != string.Empty
                || cbb_LuaChonTK.Text != string.Empty
                || tb_TimKiem.Text != string.Empty)
            {
                tb_MaNV.Text = string.Empty;
                tb_HoTen.Text = string.Empty;
                cbb_GT.Text = string.Empty;
                tb_QueQuan.Text = string.Empty;
                tb_SDT.Text = string.Empty;
                tb_Email.Text = string.Empty;
                cbb_LuaChonTK.Text = string.Empty;
                tb_TimKiem.Text = string.Empty;

                tb_MaNV.ReadOnly = false;
            }
        }

        private void dgv_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaNV.ReadOnly = true;
            int indexRow = e.RowIndex;
            if (indexRow >= 0 && indexRow <= dgv_NV.Rows.Count)
            {
                DataGridViewRow selectIndex = dgv_NV.Rows[indexRow];
                tb_MaNV.Text = selectIndex.Cells[0].Value.ToString();
                tb_HoTen.Text = selectIndex.Cells[1].Value.ToString();
                cbb_GT.Text = ((bool)selectIndex.Cells[2].Value == true) ? "Nam" : "Nữ";
                dtp_ngaySinh.Value = DateTime.Parse(selectIndex.Cells[3].Value.ToString());
                tb_SDT.Text = selectIndex.Cells[4].Value.ToString();
                tb_QueQuan.Text = selectIndex.Cells[5].Value.ToString();
                tb_Email.Text = selectIndex.Cells[6].Value.ToString();
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbb_LuaChonTK.Text == "Mã nhân viên")
            {
                LoadData_2(nhanVienDAO.tim_MaNV(tb_TimKiem.Text.Trim()));
            }
            else if (cbb_LuaChonTK.Text == "Họ và tên")
            {
                LoadData_2(nhanVienDAO.tim_TenNV(tb_TimKiem.Text.Trim()));
            }
            else if (cbb_LuaChonTK.Text == "Quê quán")
            {
                LoadData_2(nhanVienDAO.tim_QueQuan(tb_TimKiem.Text.Trim()));
            }
            else
            {
                MessageBox.Show("Hãy chọn mục cần tìm kiếm");
            }

        }

        private void LoadData_2(DataSet dataSet)
        {

            dgv_NV.Rows.Clear();
            dgv_NV.Visible = true;
            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
            {
                lb_ThongBaoDS.Visible = false;
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    dgv_NV.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                dgv_NV.Visible = false;
                lb_ThongBaoDS.Visible = true;
                lb_ThongBaoDS.Text = "không có bản ghi nào";
            }
        }


        private void tb_MaNV_Validating(object sender, CancelEventArgs e)
        {
            if (tb_MaNV.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(tb_MaNV, "Mã nhân viên chưa được nhập đúng");
            }
            else
            {
                errorProvider1.SetError(tb_MaNV, null);
            }
        }

        private void tb_HoTen_Validating(object sender, CancelEventArgs e)
        {
            if (tb_HoTen.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(tb_HoTen, "Họ tên chưa được nhập đúng");
            }
            else
            {
                errorProvider1.SetError(tb_HoTen, null);
            }
        }
        private bool isNumber(string value)
        {
            foreach (Char ch in value)
            {
                if (!Char.IsDigit(ch))
                    return false;
            }
            return true;
        }
        private void tb_SDT_Validating(object sender, CancelEventArgs e)
        {
            if (tb_SDT.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(tb_SDT, "SDT chưa được nhập đúng");
            }
            else
            {
                if (!isNumber(tb_SDT.Text.Trim()))
                    errorProvider1.SetError(tb_SDT, "Không phải là số");
                else
                    errorProvider1.SetError(tb_SDT, null);
            }
        }

        private void tb_QueQuan_Validating(object sender, CancelEventArgs e)
        {
            if (tb_QueQuan.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(tb_QueQuan, "Địa chỉ chưa được nhập");
            }
            else
            {
                errorProvider1.SetError(tb_QueQuan, null);
            }
        }

        private void tb_Email_Validating(object sender, CancelEventArgs e)
        {
            if (tb_Email.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(tb_Email, "email chưa được nhập");
            }
            else
            {
                errorProvider1.SetError(tb_Email, null);
            }
        }

        private void cbb_GT_Validating(object sender, CancelEventArgs e)
        {
            if (cbb_GT.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(cbb_GT, "Chưa chọn giới tính");
            }
            else
            {
                errorProvider1.SetError(cbb_GT, null);
            }
        }

        private void dtp_ngaySinh_Validating(object sender, CancelEventArgs e)
        {
            if (dtp_ngaySinh.Value >= DateTime.Now)
            {
                errorProvider1.SetError(dtp_ngaySinh, "Ngày sinh phải bé hơn ngày hiện tại");
            }
            else
            {
                errorProvider1.SetError(dtp_ngaySinh, null);
            }
        }

        private void dgv_NV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_NV.Columns[e.ColumnIndex].Name == "Giới tính")
            {
                if (e.Value != null && (bool)e.Value == true)
                {
                    e.Value = getGioiTinh((bool)e.Value);
                }
                else if (e.Value != null && (bool)e.Value == false)
                {
                    e.Value = getGioiTinh((bool)e.Value);
                }
            }
        }

        private string getGioiTinh(bool gt)
        {
            if (gt)
            {
                return "Nam";
            }
            return "Nữ";
        }
    }
}
