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
    public partial class SanPhamForm : Form
    {
        SanPhamDAO SanPhamDAO = new SanPhamDAO();
        ErrorProvider ErrorProvider = new ErrorProvider();
        public SanPhamForm()
        {
            InitializeComponent();
        }

        private void SanPhamForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanDienThoai_demo_3DataSet.tblNhaCungCap' table. You can move, or remove it, as needed.
            this.tblNhaCungCapTableAdapter.Fill(this.quanLyBanDienThoai_demo_3DataSet.tblNhaCungCap);
            // TODO: This line of code loads data into the 'quanLyBanDienThoai_demo_3DataSet.tblSanPham' table. You can move, or remove it, as needed.
            this.tblSanPhamTableAdapter.Fill(this.quanLyBanDienThoai_demo_3DataSet.tblSanPham);

            //tat chon mac dinh
            cb_HangSanXuatSP.SelectedIndex = -1;
            cb_NCCSP.SelectedIndex = -1;
            cb_XuatXuSp.SelectedIndex = -1;

            InitializeDataGridView();
            loadSp();

        }

        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            int result;
            if (tb_MaSP.Text != string.Empty && tb_GiaBanSP.Text != string.Empty
                && tb_soLuongSp.Text != string.Empty && cb_XuatXuSp.Text != string.Empty
                && cb_NCCSP.Text != string.Empty && cb_HangSanXuatSP.Text != string.Empty
                && tb_TenSP.Text != string.Empty && ErrorProvider.GetError(tb_soLuongSp) == string.Empty && ErrorProvider.GetError(tb_GiaBanSP) == string.Empty)
            {
                string xuatXu = cb_XuatXuSp.Text.ToString().Trim();
                try
                {
                    result = SanPhamDAO.themSanPham(tb_MaSP.Text.ToString().Trim(), tb_TenSP.Text.ToString().Trim(), cb_NCCSP.Text.ToString().Trim()
                       , cb_HangSanXuatSP.Text.ToString().Trim(), xuatXu
                       , int.Parse(tb_soLuongSp.Text.ToString().Trim()), float.Parse(tb_GiaBanSP.Text.ToString().Trim()));
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công");
                        loadSp();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại");
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        //2601 loi unqie
                        //2627 loi primary key
                        //547 loi forkey
                        MessageBox.Show("Sản phẩm đã tồn tại");
                    }
                    else if (ex.Number == 547)
                    {
                        MessageBox.Show("Mã nhà sản xuất không tồn tại");
                    }
                    else
                    {

                        MessageBox.Show("Lỗi không xác định: " + ex.Message);
                    }
                }

            }
            else if (ErrorProvider.GetError(tb_soLuongSp) != string.Empty && ErrorProvider.GetError(tb_GiaBanSP) != string.Empty)
            {
                MessageBox.Show("Số lượng hoặc giá tiền không nhập đúng định dạng ");
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin tài khoản ");
            }
        }

        private void btn_SuaSP_Click(object sender, EventArgs e)
        {
            int result;
            if (tb_MaSP.Text != string.Empty && tb_GiaBanSP.Text != string.Empty
                && tb_soLuongSp.Text != string.Empty && cb_XuatXuSp.Text != string.Empty
                && cb_NCCSP.Text != string.Empty && cb_HangSanXuatSP.Text != string.Empty
                && tb_TenSP.Text != string.Empty &&
                ErrorProvider.GetError(tb_soLuongSp) == string.Empty && ErrorProvider.GetError(tb_GiaBanSP) == string.Empty)
            {
                try
                {
                    result = SanPhamDAO.suaSanPham(tb_MaSP.Text.ToString().Trim(), tb_TenSP.Text.ToString().Trim(), cb_NCCSP.Text.ToString().Trim()
                    , cb_HangSanXuatSP.Text.ToString().Trim(), cb_XuatXuSp.Text.ToString().Trim()
                    , int.Parse(tb_soLuongSp.Text.ToString().Trim()), float.Parse(tb_GiaBanSP.Text.ToString().Trim()));
                    if (result > 0)
                    {
                        MessageBox.Show("Sửa sản phẩm thành công");
                        loadSp();
                    }
                    else
                    {
                        MessageBox.Show("Sửa sản phẩm thất bại");
                    }
                }catch (SqlException ex)
                {
                    if (ex.Number == 2627) 
                    {
                        //2601 loi unqie
                        //2627 loi primary key
                        //547 loi forkey
                        MessageBox.Show("Sản phẩm đã tồn tại");
                    }
                    else if (ex.Number == 547)
                    {
                        MessageBox.Show("Mã nhà sản xuất đã tồn tại");
                    }
                    else
                    {
                  
                        MessageBox.Show("Lỗi không xác định: " + ex.Message);
                    }
                }

             
            }
            else if (ErrorProvider.GetError(tb_soLuongSp) != string.Empty && ErrorProvider.GetError(tb_GiaBanSP) != string.Empty)
            {
                MessageBox.Show("Số lượng hoặc giá tiền nhập không đúng định dạng");
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin sản phẩn");
            }
        }

        private void btn_XoaSp_Click(object sender, EventArgs e)
        {
            if (tb_MaSP.Text != string.Empty)
            {
                int result = SanPhamDAO.xoaSanPham(tb_MaSP.Text.Trim());
                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công !!");
                    loadSp();
                    tb_MaSP.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm !!");
            }
        }

        private void btn_ResetSP_Click(object sender, EventArgs e)
        {
            if (tb_MaSP.Text != string.Empty || tb_GiaBanSP.Text != string.Empty || tb_soLuongSp.Text != string.Empty
                || cb_XuatXuSp.Text != string.Empty || cb_NCCSP.Text != string.Empty || cb_HangSanXuatSP.Text != string.Empty
                || tb_TenSP.Text != string.Empty || tb_TimKiemSp.Text != string.Empty || cbb_LuaChonTimKiem.Text != string.Empty)
            {
                tb_TenSP.Text = string.Empty;
                tb_MaSP.Text = string.Empty;
                tb_GiaBanSP.Text = string.Empty;
                tb_soLuongSp.Text = string.Empty;
                tb_TimKiemSp.Text = string.Empty;
                cbb_LuaChonTimKiem.Text = string.Empty;
                cb_HangSanXuatSP.Text = string.Empty;
                cb_NCCSP.Text = string.Empty;
                cb_XuatXuSp.Text = string.Empty;
                ErrorProvider.Clear();

                tb_MaSP.ReadOnly = false;
                MessageBox.Show("Các ô nhập đã được làm mới");
            }
            else
            {
                MessageBox.Show("Các ô nhập đã được sẵn sàng");
            }
        }

        private void loadSp()
        {
            DataSet dataSet = SanPhamDAO.getSanPham();
            dgv_SanPham.Rows.Clear();
            dgv_SanPham.Visible = true;
            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
            {
                lb_ThongBaoDS.Visible = false;
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    dgv_SanPham.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                dgv_SanPham.Visible = false;
                lb_ThongBaoDS.Visible = true;
                lb_ThongBaoDS.Text = "Không có bản ghi nào";
            }
        }
        private void InitializeDataGridView()
        {
            // Thêm các cột vào DataGridView
            dgv_SanPham.ColumnCount = 7;
            dgv_SanPham.Columns[0].Name = "Mã sản phâm";
            dgv_SanPham.Columns[1].Name = "Tên sản phẩm";
            dgv_SanPham.Columns[2].Name = "Mã nhà cung câp";
            dgv_SanPham.Columns[3].Name = "Hãng sản xuất";
            dgv_SanPham.Columns[4].Name = "Xuất xứ";
            dgv_SanPham.Columns[5].Name = "Số lượng";
            dgv_SanPham.Columns[6].Name = "Giá tiền";


            // Không cho phép chỉnh sửa dữ liệu trực tiếp trên DataGridView
            dgv_SanPham.ReadOnly = true;
            // Cài đặt chế độ hiển thị dữ liệu đầy đủ trên DataGridView
            dgv_SanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_SanPham.AllowUserToAddRows = false;
        }

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaSP.ReadOnly = true;
            int indexRow = e.RowIndex;
            if (indexRow >= 0 && indexRow <= dgv_SanPham.Rows.Count)
            {
                DataGridViewRow selectIndex = dgv_SanPham.Rows[indexRow];
                tb_MaSP.Text = selectIndex.Cells[0].Value.ToString();
                tb_TenSP.Text = selectIndex.Cells[1].Value.ToString();
                cb_NCCSP.Text = selectIndex.Cells[2].Value.ToString();
                cb_HangSanXuatSP.Text = selectIndex.Cells[3].Value.ToString();
                cb_XuatXuSp.Text = selectIndex.Cells[4].Value.ToString();
                tb_soLuongSp.Text = selectIndex.Cells[5].Value.ToString();
                tb_GiaBanSP.Text = selectIndex.Cells[6].Value.ToString();
            }
        }

        private void tb_GiaBanSP_TextChanged(object sender, EventArgs e)
        {
            if (!isNumber(tb_GiaBanSP.Text.Trim()))
            {
                ErrorProvider.SetError(tb_GiaBanSP, "Không phải là số");
            }
            else
            {
                ErrorProvider.SetError(tb_GiaBanSP, "");
            }

        }

        private void tb_soLuongSp_TextChanged(object sender, EventArgs e)
        {
            if (!isNumber(tb_soLuongSp.Text.Trim()))
            {
                ErrorProvider.SetError(tb_soLuongSp, "Không phải là số");
            }
            else
            {
                ErrorProvider.SetError(tb_soLuongSp, "");
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

        private void cb_XuatXuSp_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void tb_TimKiemSp_TextChanged(object sender, EventArgs e)
        {

            if (cbb_LuaChonTimKiem.Text.Equals("Mã sản phẩm"))
            {
                DataSet data = SanPhamDAO.tim_MaSP(tb_TimKiemSp.Text.Trim());
                loadDSTK(data);
            }
            else if (cbb_LuaChonTimKiem.Text.Equals("Tên sản phẩm"))
            {
                DataSet data = SanPhamDAO.tim_TenSP(tb_TimKiemSp.Text.Trim());
                loadDSTK(data);
            }
            else if (cbb_LuaChonTimKiem.Text.Equals("Xuất xứ"))
            {
                DataSet data = SanPhamDAO.tim_XuatXu(tb_TimKiemSp.Text.Trim());
                loadDSTK(data);
            }
            else if (cbb_LuaChonTimKiem.Text.Equals("Hãng sản xuất"))
            {
                DataSet data = SanPhamDAO.tim_HangSanXuat(tb_TimKiemSp.Text.Trim());
                loadDSTK(data);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục cần tìm kiếm ");
            }



        }

        private void loadDSTK(DataSet ds)
        {
            dgv_SanPham.Rows.Clear();
            dgv_SanPham.Visible = true;
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables.Count > 0)
            {
                lb_ThongBaoDS.Visible = false;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dgv_SanPham.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                dgv_SanPham.Visible = false;
                lb_ThongBaoDS.Visible = true;
                lb_ThongBaoDS.Text = "Không tìm thấy sản phẩm";
            }

        }

        private void cb_HangSanXuatSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_SanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex = 5; 

            if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
            {
                
                if (dgv_SanPham.Rows[e.RowIndex].Cells[columnIndex].Value != null &&
                    dgv_SanPham.Rows[e.RowIndex].Cells[columnIndex].Value.ToString() == "0")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }

            int columnIndex_2 = 6;

            if (e.ColumnIndex == columnIndex_2 && e.RowIndex >= 0)
            {

                if (dgv_SanPham.Rows[e.RowIndex].Cells[columnIndex_2].Value != null &&
                    dgv_SanPham.Rows[e.RowIndex].Cells[columnIndex_2].Value.ToString() == "0")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }

        }


        
    }
}
