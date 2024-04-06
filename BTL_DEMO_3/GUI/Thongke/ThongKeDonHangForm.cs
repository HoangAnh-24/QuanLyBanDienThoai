using BTL_DEMO_3.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace BTL_DEMO_3.GUI.Thongke
{
    public partial class ThongKeDonHangForm : Form
    {

        private DonHangDAO donHangDAO = new DonHangDAO();
        public ThongKeDonHangForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void ThongKeDonHangForm_Load(object sender, EventArgs e)
        {
            loadData(donHangDAO.getDonHang());
          
        }

        private void loadData(DataSet ds)
        {
            dgv_DSDH.Rows.Clear();
            dgv_DSDH.Visible = true;
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables.Count > 0)
            {
                lb_ThongBaoDS.Visible = false;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dgv_DSDH.Rows.Add(row.ItemArray);
                }

                int rowCount = ds.Tables[0].Rows.Count;
                lb_soLuongDonHang.Text = rowCount.ToString();


                int sum = 0;
                foreach (DataRow row in ds.Tables[0].Rows)
                {

                   // sum += Convert.ToInt32(row[4]);
                }
                lb_DoanhThu.Text = sum.ToString();
            }
            else
            {
                lb_soLuongDonHang.Text = "0";
                lb_DoanhThu.Text ="0";
                dgv_DSDH.Visible = false;
                lb_ThongBaoDS.Visible = true;
                lb_ThongBaoDS.Text = "Không có đơn hàng ";
            }

            
        }

        private void InitializeDataGridView()
        {
            // Thêm các cột vào DataGridView
            dgv_DSDH.ColumnCount = 5;
            dgv_DSDH.Columns[0].Name = "Mã đơn hàng";
            dgv_DSDH.Columns[1].Name = "Mã nhân viên";
            dgv_DSDH.Columns[2].Name = "Số điện thoại khách hàng";
            dgv_DSDH.Columns[3].Name = "Ngày lập";
            dgv_DSDH.Columns[4].Name = "Tổng thành tiền";


            // Không cho phép chỉnh sửa dữ liệu trực tiếp trên DataGridView
            dgv_DSDH.ReadOnly = true;
            // Cài đặt chế độ hiển thị dữ liệu đầy đủ trên DataGridView
            dgv_DSDH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DSDH.AllowUserToAddRows = false;
        }
        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbb_LocTimKiem.Text.Equals("Mã hóa đơn"))
            {
                loadData(donHangDAO.tim_MaDH(tb_TimKiem.Text.Trim()));
            }
            else if (cbb_LocTimKiem.Text.Equals("Số điện thoại"))
            {
                loadData(donHangDAO.tim_SDT(tb_TimKiem.Text.Trim()));
            }
            else if (cbb_LocTimKiem.Text.Equals("Mã nhân viên"))
            {
                loadData(donHangDAO.tim_MaNV(tb_TimKiem.Text.Trim()));
            }
            else
            {
                MessageBox.Show("Hãy chọn mục cần tìm kiếm");
            }
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {

            if(dtp_NgayBatDau.Value < dtp_NgayKetThuc.Value )
            {
                if (btn_Loc.Text == "Lọc")
                {
                    btn_Loc.Text = "Bỏ lọc";
                    loadData(donHangDAO.LocKhoang(dtp_NgayBatDau.Value, dtp_NgayKetThuc.Value));
                }
                else
                {
                    btn_Loc.Text = "Lọc";
                    loadData(donHangDAO.getDonHang());
                }
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
            }
            
        }
    }
}
