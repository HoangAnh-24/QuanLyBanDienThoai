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
    public partial class KhachHangForm : Form
    {
        KhachHangDAO khachHangDAO = new KhachHangDAO();
        ErrorProvider errorProvider1 = new ErrorProvider();
        public KhachHangForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        public void LoadData()
        {
            DataSet dataSet = khachHangDAO.getKhachHang();

            dgv_KH.Rows.Clear();

            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    dgv_KH.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                dgv_KH.Visible = false;
                lb_ThongBaoDS.Visible = true;
                lb_ThongBaoDS.Text = " Không có bản ghi";
            }
        }

        private void InitializeDataGridView()
        {
            // Thêm các cột vào DataGridView
            dgv_KH.ColumnCount = 3;
            dgv_KH.Columns[0].Name = "Tên KH";
            dgv_KH.Columns[1].Name = "Địa chỉ";
            dgv_KH.Columns[2].Name = "SĐT";


            // Không cho phép chỉnh sửa dữ liệu trực tiếp trên DataGridView
            dgv_KH.ReadOnly = true;
            // Cài đặt chế độ hiển thị dữ liệu đầy đủ trên DataGridView
            dgv_KH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_KH.AllowUserToAddRows = false;
        }
        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (tb_HoTen.Text != string.Empty
                && tb_DiaChi.Text != string.Empty
                && tb_SDT.Text != string.Empty
                )
            {
                string tenKH = tb_HoTen.Text.Trim();
                string diaChi = tb_DiaChi.Text.Trim();
                string SDT = tb_SDT.Text.Trim();

                try
                {
                    int result = khachHangDAO.themKhachHang(tenKH, diaChi, SDT);

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm thành công !!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!!");
                    }
                }catch(SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        //2601 loi unqie
                        //2627 loi primary key
                        //547 loi forkey
                        MessageBox.Show("KHách hàng đã tồn tại");
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!");
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (tb_HoTen.Text != string.Empty
                && tb_DiaChi.Text != string.Empty
                && tb_SDT.Text != string.Empty
                )
            {
                string tenKH = tb_HoTen.Text.Trim();
                string diaChi = tb_DiaChi.Text.Trim();
                string SDT = tb_SDT.Text.Trim();

                try
                {
                    int result = khachHangDAO.suaKhachHang(tenKH, diaChi, SDT);

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thành công !!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại !!");
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        //2601 loi unqie
                        //2627 loi primary key
                        //547 loi forkey
                        MessageBox.Show("Khách hàng đã tồn tại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_SDT.Text != string.Empty)
            {
                int result = khachHangDAO.xoaKhachHang(tb_SDT.Text.Trim());
                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công !!");
                    LoadData();
                    tb_SDT.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập SDT !!");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (tb_HoTen.Text != string.Empty
                || tb_DiaChi.Text != string.Empty
                || tb_SDT.Text != string.Empty
                || tb_TimKiem.Text != string.Empty)
            {
                tb_HoTen.Text = string.Empty;
                tb_DiaChi.Text = string.Empty;
                tb_SDT.Text = string.Empty;
                tb_TimKiem.Text = string.Empty;
                tb_SDT.ReadOnly = false;
            }
        }

        private void dgv_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_SDT.ReadOnly = true;
            int indexRow = e.RowIndex;
            if (indexRow >= 0 && indexRow <= dgv_KH.Rows.Count)
            {
                DataGridViewRow selectIndex = dgv_KH.Rows[indexRow];
                tb_HoTen.Text = selectIndex.Cells[0].Value.ToString();
                tb_DiaChi.Text = selectIndex.Cells[1].Value.ToString();
                tb_SDT.Text = selectIndex.Cells[2].Value.ToString();
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            lb_ThongBaoDS.Visible = false;
            dgv_KH.Visible = true;

            if(tb_TimKiem.Text.Trim() != string.Empty)
            {
                if (cbb_LuaChonTimKiem.Text == "Tên KH")
                {
                    DataSet dataSet = khachHangDAO.tim_TenKH(tb_TimKiem.Text.Trim());

                    dgv_KH.Rows.Clear();

                    if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
                    {
                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            dgv_KH.Rows.Add(row.ItemArray);
                        }
                    }
                    else
                    {
                        dgv_KH.Visible = false;
                        lb_ThongBaoDS.Visible = true;
                        lb_ThongBaoDS.Text = "Không có bản ghi";
                    }
                }
                else if (cbb_LuaChonTimKiem.Text == "SĐT")
                {
                    DataSet dataSet = khachHangDAO.tim_SDTKH(tb_TimKiem.Text.Trim());

                    dgv_KH.Rows.Clear();

                    if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
                    {
                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            dgv_KH.Rows.Add(row.ItemArray);
                        }
                    }
                    else
                    {
                        dgv_KH.Visible = false;
                        lb_ThongBaoDS.Visible = true;
                        lb_ThongBaoDS.Text = " Không có bản ghi";
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn tìm kiếm theo");
                  
                }
            }
            else
            {
                LoadData();
            }
     
          
        }

        private void tb_HoTen_Validating(object sender, CancelEventArgs e)
        {
            if (tb_HoTen.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(tb_HoTen, "Họ tên chưa được nhập" );
            }
            else
            {
                errorProvider1.SetError(tb_HoTen, null);
            }
        }

        private void tb_DiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (tb_DiaChi.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(tb_DiaChi, "Địa chỉ chưa được nhập");
            }
            else
            {
                errorProvider1.SetError(tb_DiaChi, null);
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
                errorProvider1.SetError(tb_SDT, "SDT chưa được nhập");
            }
            else
            {
                if (!isNumber(tb_SDT.Text.Trim()))
                    errorProvider1.SetError(tb_SDT, "Khong phai la so");
                else
                    errorProvider1.SetError(tb_SDT, null);
            }
        }
    }
}
