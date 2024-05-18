using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuHocPhi
{
    internal class database
    {
        private string connectionString = @"Data Source=CORZPOVVER3KA\\SQLEXPRESS;Initial Catalog=btl_9;Integrated Security=True";
        private SqlConnection connect;
        private DataTable dt;
        private SqlCommand cmd;
        public database()
        {
            //hàm khởi tạo
            //hàm chạy đầu tiên khi class dtb đc gọi
            try
            {
                connect = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("connected failed: " + ex.Message);
            }
        }
        //khai báo hàm truy xuất dữ liệu từ bảng sinh viên
        public DataTable SelectData(string sql, List<customparameter> lstPara)
        {
            try
            {
                //ket noi DB
                connect.Open();

                //câu truy vấn du lieu
                //sql = "exec selectallSv";

                //tạo query cho SQL
                cmd = new SqlCommand(sql, connect); //truyền Query và tạo connect
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstPara) //gán các tham số  cho cmd
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                //Tạo đối tượng dataAdapter để lấy kq từ command
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                //Đổ dữ liệu từ dataAdapter ra DataTable
                dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("loadted failed: " + ex.Message);
                return null;
            }
            finally
            {
                connect.Close();
            }
        }

    }
}
