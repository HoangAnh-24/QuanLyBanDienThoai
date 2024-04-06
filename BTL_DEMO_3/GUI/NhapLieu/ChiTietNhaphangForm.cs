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

namespace BTL_DEMO_3.GUI.NhapLieu
{
    public partial class ChiTietNhaphangForm : Form
    {
        private Color selectedRowColor = Color.LightBlue;
        private Color defaultRowColor =  Color.White;
        private string maSp = string.Empty;
        private NhapHangDAO nhapHangDAO = new NhapHangDAO();


        private SanPhamDAO sanPhamDAO = new SanPhamDAO();
        
        public ChiTietNhaphangForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            if(checkTBSoLuong(tb_SoLuongNhap.Text.Trim())==true && cbb_MaNV.Text != string.Empty && maSp!=string.Empty)
            {

                try
                {
                    int rerult = nhapHangDAO.themNhapHang(maSp, cbb_MaNV.Text.Trim(), (int)int.Parse(tb_SoLuongNhap.Text), DateTime.Now);
                    if(rerult>0)
                    {
                        MessageBox.Show("Nhap hang thanh cong ");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nhap hang that bai");

                    }
                }catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
              
            }
            else if(maSp == string.Empty)
            {
                MessageBox.Show("Hay chon san pham");
            }
            else if(cbb_MaNV.Text == string.Empty)
            {
                MessageBox.Show("Hay chon ma nhien vien");
            }
            else
            {
                MessageBox.Show("Hay chon day du thong tin");
            }
            
        }

        private bool checkTBSoLuong(string value)
        {
            if(isNumber(value)== true && (int)int.Parse(value) > 0)
            {
                return true;
            }
            return false;
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

        private void ChiTietNhaphangForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanDienThoai_demo_3DataSet.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this.quanLyBanDienThoai_demo_3DataSet.tblNhanVien);
            loadSp();
            cbb_MaNV.SelectedIndex = -1;
        }

         private void loadSp()
        {
            DataSet dataSet = sanPhamDAO.getSanPham();
            dgv_DSSP.Rows.Clear();
            dgv_DSSP.Visible = true;
            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
            {
                lb_ThongBaoDS.Visible = false;
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    dgv_DSSP.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                dgv_DSSP.Visible = false;
                lb_ThongBaoDS.Visible = true;
                lb_ThongBaoDS.Text = "Khong co ban ghi nao";
            }
        }
        private void InitializeDataGridView()
        {
            // Thêm các cột vào DataGridView
            dgv_DSSP.ColumnCount = 7;
            dgv_DSSP.Columns[0].Name = "Mã sản phâm";
            dgv_DSSP.Columns[1].Name = "Tên sản phẩm";
            dgv_DSSP.Columns[2].Name = "Mã nhà cung câp";
            dgv_DSSP.Columns[3].Name = "Hãng sản xuất";
            dgv_DSSP.Columns[4].Name = "Xuất xứ";
            dgv_DSSP.Columns[5].Name = "Số lượng";
            dgv_DSSP.Columns[6].Name = "Giá tiền";


            // Không cho phép chỉnh sửa dữ liệu trực tiếp trên DataGridView
            dgv_DSSP.ReadOnly = true;
            // Cài đặt chế độ hiển thị dữ liệu đầy đủ trên DataGridView
            dgv_DSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DSSP.AllowUserToAddRows = false;
        }

        private void dgv_SanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex = 5;

            if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
            {

                if (dgv_DSSP.Rows[e.RowIndex].Cells[columnIndex].Value != null &&
                    dgv_DSSP.Rows[e.RowIndex].Cells[columnIndex].Value.ToString() == "0")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

     

        private void dgv_DSSP_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                e.Cell.Style.BackColor = selectedRowColor;
            }
            else
            {
                e.Cell.Style.BackColor = defaultRowColor;
            }
        }

        private void dgv_DSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            // Nếu chỉ số dòng hợp lệ
            if (rowIndex >= 0)
            {
                DataGridViewRow selectIndex = dgv_DSSP.Rows[rowIndex];
                maSp= selectIndex.Cells[0].Value.ToString();

                // Hủy chọn tất cả các dòng
                dgv_DSSP.ClearSelection();

                // Chọn dòng được nhấp vào
                dgv_DSSP.Rows[rowIndex].Selected = true;

                // Thay đổi màu của toàn bộ dòng
                foreach (DataGridViewRow row in dgv_DSSP.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Nếu là ô trong dòng được chọn
                        if (row.Index == rowIndex)
                        {
                            cell.Style.BackColor = selectedRowColor; // Đặt màu cho ô trong dòng được chọn
                           
                        }
                        else
                        {
                            cell.Style.BackColor = defaultRowColor; // Đặt màu cho các ô trong các dòng khác
                           
                        }
                    }
                }

                
            }
           
        }

      
    }
}
