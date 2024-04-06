using BTL_DEMO_3.DAO;
using BTL_DEMO_3.DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_DEMO_3.GUI.NhapLieu
{
    public partial class TaoDonHangForm : Form
    {
        private List<SanPham> DSSanPham = new List<SanPham>();
        private SanPham SanPham;
        private ChiTietDonHang chiTietDonHang;
        private List<ChiTietDonHang> DsCTDH = new List<ChiTietDonHang>();
        private DonHangDAO DonHangDAO = new DonHangDAO();
        private ChiTietDonHangDAO ChiTietDonHangDAO = new ChiTietDonHangDAO();
        private KhachHangDAO KhachHangDAO = new KhachHangDAO();
        private int ChonCBB = -1;
        private int ChonViewTable = -1;
        public TaoDonHangForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void btn_HuyDonHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy đơn hàng đang tạo không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ClearTextBox();
                DsCTDH.Clear();
                dgv_DSSPDaChon.Rows.Clear();
            }
        }

        private void ClearTextBox()
        {
            if (tb_DiaChiKH.Text != string.Empty || tb_maDH.Text != string.Empty || tb_SoLuongMua.Text != string.Empty
                || cbb_maNV.Text != string.Empty || cbb_MaSP.Text != string.Empty || tb_tenKH.Text != string.Empty || cbb_SDT.Text != string.Empty
                || dtp_NgayLapDH.Text != string.Empty)
            {
                tb_DiaChiKH.Text = string.Empty;
                tb_maDH.Text = string.Empty;
                tb_SoLuongMua.Text = string.Empty;
                cbb_maNV.Text = string.Empty;
                cbb_MaSP.Text = string.Empty;
                tb_tenKH.Text = string.Empty;
                cbb_SDT.Text = string.Empty;
                dtp_NgayLapDH.Text = string.Empty;
            }
        }

        private void TaoDonHangForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanDienThoai_demo_3DataSet.tblSanPham' table. You can move, or remove it, as needed.
            this.tblSanPhamTableAdapter.Fill(this.quanLyBanDienThoai_demo_3DataSet.tblSanPham);
            // TODO: This line of code loads data into the 'quanLyBanDienThoai_demo_3DataSet.tblKhachHang' table. You can move, or remove it, as needed.
            this.tblKhachHangTableAdapter.Fill(this.quanLyBanDienThoai_demo_3DataSet.tblKhachHang);
            // TODO: This line of code loads data into the 'quanLyBanDienThoai_demo_3DataSet.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this.quanLyBanDienThoai_demo_3DataSet.tblNhanVien);
            cbb_maNV.SelectedIndex = -1;
            cbb_SDT.SelectedIndex = -1;
            LoadToList();
            loadItemCBB(DSSanPham);
            loadDsCTHD();
        }


        private void LoadToList()
        {
            DataSet ds = DonHangDAO.getThongTinSP();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables["Table"] != null)
            {
                foreach (DataRow row in ds.Tables["Table"].Rows)
                {

                    SanPham sanPham = new SanPham(
                        row[0].ToString(),
                        row[1].ToString(),
                        Convert.ToInt32(row[2]),
                        Convert.ToInt32(row[3])
                    );


                    DSSanPham.Add(sanPham);
                }
            }
        }
        private void loadItemCBB(List<SanPham> sanPhams)
        {

            string rowData = "";
            cbb_MaSP.SelectedIndex = -1;
            cbb_MaSP.Items.Clear();

            if (sanPhams != null && sanPhams.Count > 0)
            {
                foreach (var sanPham in sanPhams)
                {
                    rowData = " Mã sản phẩm : " + sanPham.MaSP.ToString() + " | " +
                                    " Tên sản phẩm : " + sanPham.TenSP.ToString() + " | " +
                                    " Số lượng : " + sanPham.SoLuong.ToString();

                    // Thêm chuỗi đã gộp vào ComboBox
                    cbb_MaSP.Items.Add(rowData);
                }
            }
            else
            {
                cbb_MaSP.Items.Add("Không có sản phẩm nào!!");
            }
        }
        private void btn_themSanPham_Click(object sender, EventArgs e)
        {
            // chưa check số lượng nhở hơn không

            if (ChonCBB != -1)
            {
                if (DSSanPham[ChonCBB].SoLuong > 0)
                {

                    if ((int.Parse(tb_SoLuongMua.Text.ToString())) > 0)
                    {
                        int soLuongMua = (int.Parse(tb_SoLuongMua.Text.ToString()));
                        if (soLuongMua <= DSSanPham[ChonCBB].SoLuong)
                        {
                            // sử dụng biến chonCBB để lưu stt được chọn trong cbb từ đó để trừ số lượng trong list
                            //khi nhấn thêm chi tiết đơn hàng sẽ được thêm nhưng không có mã hóa đơn khi nhấn thêm hóa đơn mới đẩy mã hóa đơn vào 
                            DSSanPham[ChonCBB].SoLuong -= soLuongMua;
                            chiTietDonHang = new ChiTietDonHang(DSSanPham[ChonCBB].MaSP, DSSanPham[ChonCBB].MaSP, soLuongMua, DSSanPham[ChonCBB].GiaBan * soLuongMua);
                            DsCTDH.Add(chiTietDonHang);
                            ChonCBB = -1;
                            loadItemCBB(DSSanPham);
                            loadDsCTHD();
                            // chưa có nếu thêm sản phẩm giống thì tự công vào cái đã có
                            tb_SoLuongMua.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Số lượng mua lớn hơn số lượng sản phẩm có !!");
                            tb_SoLuongMua.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Số lượng mua của bạn đang sai");
                    }
                }
                else
                {
                    tb_SoLuongMua.Text = "Sản phẩm đã hết hàng !!";
                    tb_SoLuongMua.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm !!");
            }
        }


        private void loadDsCTHD()
        {
            dgv_DSSPDaChon.Rows.Clear();
            dgv_DSSPDaChon.Visible = true;
            if (DsCTDH.Count > 0)
            {
                lb_ThongBaoDS.Visible = false;
                foreach (ChiTietDonHang row in DsCTDH)
                {

                    dgv_DSSPDaChon.Rows.Add(row.MaSP, row.TenSP, row.SoLuongMua, row.ThanhTien); ;
                }
            }
            else
            {
                dgv_DSSPDaChon.Visible = false;
                lb_ThongBaoDS.Visible = true;
                lb_ThongBaoDS.Text = "Không có sản phảm nào được chọn";
            }
        }
        private void InitializeDataGridView()
        {
            // Thêm các cột vào DataGridView
            dgv_DSSPDaChon.ColumnCount = 4;
            dgv_DSSPDaChon.Columns[0].Name = "Mã sản phâm";
            dgv_DSSPDaChon.Columns[1].Name = "Tên sản phẩm";
            dgv_DSSPDaChon.Columns[2].Name = "Số lượng mua";
            dgv_DSSPDaChon.Columns[3].Name = "Thành tiền";



            // Không cho phép chỉnh sửa dữ liệu trực tiếp trên DataGridView
            dgv_DSSPDaChon.ReadOnly = true;
            // Cài đặt chế độ hiển thị dữ liệu đầy đủ trên DataGridView
            dgv_DSSPDaChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DSSPDaChon.AllowUserToAddRows = false;
        }

        private void btn_XoaSanPham_Click(object sender, EventArgs e)
        {
            // dùng biến chonviewTable để lưu vị trí click trên datafridview  sau đó sẽ xóa vị trí đó khỏi bảng và cộng số lượng đã mua vào số lượng kho 
            if (ChonViewTable >= 0 && ChonViewTable <= dgv_DSSPDaChon.Rows.Count)
            {
                DataGridViewRow selectIndex = dgv_DSSPDaChon.Rows[ChonViewTable];
                string MaSp = selectIndex.Cells[0].Value.ToString();
                for (int i = 0; i < DSSanPham.Count; i++)
                {
                    if (DSSanPham[i].MaSP.Equals(MaSp))
                    {
                        DSSanPham[i].SoLuong += int.Parse(selectIndex.Cells[2].Value.ToString());
                        dgv_DSSPDaChon.Rows.RemoveAt(ChonViewTable);
                        for (int j = 0; j < DSSanPham.Count; j++)
                        {
                            if (DsCTDH[j].MaSP.Equals(MaSp))
                            {
                                DsCTDH.RemoveAt(j);
                                break;
                            }
                        }
                        ChonViewTable = -1;
                        loadItemCBB(DSSanPham);
                        loadDsCTHD();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại sản phẩm !!");
            }


        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btn_LapDonHang_Click(object sender, EventArgs e)
        {
            string maHD = tb_maDH.Text.Trim();
            float tong_tien = TinhTongTien(DsCTDH);

            ThemKhachHang();
            ThemDonHang(maHD, tong_tien);
            ClearTextBox();
            dgv_DSSPDaChon.Rows.Clear();

        }

        private float TinhTongTien(List<ChiTietDonHang> DsCTDH)
        {
            float tong_tien = 0;
            foreach (ChiTietDonHang chiTietDonHang in DsCTDH)
            {
                tong_tien += chiTietDonHang.ThanhTien;
            }
            return tong_tien;
        }

        private void ThemDonHang(string maHD, float tong_tien)
        {
            DateTime dateTime = dtp_NgayLapDH.Value;
            try
            {
                DonHangDAO.themDonHang(maHD, cbb_maNV.Text.Trim(), cbb_SDT.Text.Trim(), dateTime, tong_tien);
                ThemChiTietDonHang(maHD);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Hóa đơn đã tồn tại !!");
                }
            }

        }

        private void ThemChiTietDonHang(string maHD)
        {
            foreach (ChiTietDonHang chiTietDonHang in DsCTDH)
            {
                chiTietDonHang.MaDH = maHD;
                ChiTietDonHangDAO.themChiTietDonHang(chiTietDonHang.MaDH, chiTietDonHang.MaSP, chiTietDonHang.TenSP, chiTietDonHang.SoLuongMua, chiTietDonHang.ThanhTien);
            }
            CapNhatSanPham();
        }

        private void ThemKhachHang()
        {
            try
            {
                int result = KhachHangDAO.themKhachHang(tb_tenKH.Text.Trim(), tb_DiaChiKH.Text.Trim(), cbb_SDT.Text.Trim());
            }
            catch (SqlException ex)
            {

            }

        }

        private void CapNhatSanPham()
        {
            for (int i = 0; i < DSSanPham.Count; i++)
            {
                DonHangDAO.LoadDataToDatabase(DSSanPham[i].MaSP, DSSanPham[i].SoLuong);
            }
        }

        private void loadKH()
        {

        }

        private void btn_XuatDonHang_Click(object sender, EventArgs e)
        {

        }

        private void btn_XemDonHang_Click(object sender, EventArgs e)
        {

        }

        private void cbb_MaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChonCBB = cbb_MaSP.SelectedIndex;
            tb_SoLuongMua.Clear();
            tb_SoLuongMua.Enabled = true;
        }

        private void dgv_DSSPDaChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChonViewTable = e.RowIndex;
        }

        private void cbb_SDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = DonHangDAO.Lay_KH(cbb_SDT.Text.Trim());
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                tb_DiaChiKH.ReadOnly = true;
                tb_tenKH.ReadOnly = true;
                // Lấy dữ liệu từ DataSet và gán vào TextBox
                tb_tenKH.Text = ds.Tables[0].Rows[0]["sTenKH"].ToString();
                tb_DiaChiKH.Text = ds.Tables[0].Rows[0]["sDiaChi"].ToString();
            }
            else
            {

                tb_DiaChiKH.ReadOnly = false;
                tb_tenKH.ReadOnly = false;
            }
        }

        private void cbb_SDT_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = DonHangDAO.Lay_KH(cbb_SDT.Text.Trim());
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                tb_DiaChiKH.ReadOnly = true;
                tb_tenKH.ReadOnly = true;
                // Lấy dữ liệu từ DataSet và gán vào TextBox
                tb_tenKH.Text = ds.Tables[0].Rows[0]["sTenKH"].ToString();
                tb_DiaChiKH.Text = ds.Tables[0].Rows[0]["sDiaChi"].ToString();
            }
            else
            {

                tb_DiaChiKH.ReadOnly = false;
                tb_tenKH.ReadOnly = false;
            }
        }
    }
}
