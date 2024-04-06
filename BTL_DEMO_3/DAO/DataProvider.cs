using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL_DEMO_3.DTO;

namespace BTL_DEMO_3.DAO
{
    public class SqlConnectionData
    {
        public static SqlConnection Connection()
        {
            string strConn = @"Data Source=DESKTOP-PPFN3SS\SQLEXPRESS;Initial Catalog=QuanLyBanDienThoai_demo_3;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(strConn);
            return conn;
        }
    }
    internal class DataProvider
    {


        public static TaiKhoan checkLoginDTO(string username, string password)
        {
            TaiKhoan taiKhoan = null;

            using (SqlConnection conn = SqlConnectionData.Connection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_login", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) // nếu có dữ liệu
                {
                    while (reader.Read()) // đọc hết những dòng mà kết quả trả về
                    {
                        taiKhoan = new TaiKhoan(
                            reader.GetString(0),  // sMaNV
                            reader.GetString(1),  // sTenDangNhap
                            reader.GetString(2),  // sMatKhau
                            reader.GetBoolean(3)  // bPhanQuyen
                        );
                        break; // Đã tìm thấy, thoát khỏi vòng lặp
                    }
                }

                reader.Close();
            }

            return taiKhoan;
        
    }

        public static DataSet GetDataDTO(string procName, Dictionary<string, object> parameters)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection conn = SqlConnectionData.Connection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số vào command
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        //53 không kết nối được với sql
                        //208 lỗi không tìm thấy proc
                        // Đổ dữ liệu vào DataSet
                        adapter.Fill(dataSet);
                    }
                }
            }
            return dataSet;
        }
        public static DataSet GetDataQuery(string query, Dictionary<string, object> parameters)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection conn = SqlConnectionData.Connection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thêm các tham số vào command
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        // Đổ dữ liệu vào DataSet
                        adapter.Fill(dataSet);
                    }
                }
            }
            return dataSet;
        }

        public static int them_sua_xoa(string procName, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = SqlConnectionData.Connection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số vào command
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    // Thực thi stored procedure cập nhật và trả về số dòng ảnh hưởng
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
