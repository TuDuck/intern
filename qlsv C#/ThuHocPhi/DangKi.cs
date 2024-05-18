using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThuHocPhi
{
    public partial class DangKi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=CORZPOVVER3KA\\SQLEXPRESS;Initial Catalog=btl_9;Integrated Security=True");
        private void loadgrv()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("Select tendangnhap,matkhau From dang_nhap", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            conn.Close();




        }
        private bool Kiemtraso(String Text)
        {
            int kq;
            return int.TryParse(Text, out kq);
        }

        private int ChecktrungTaikhoan(String tendangnhap)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("ChecktrungTaikhoan", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tendangnhap", SqlDbType.NVarChar, 50).Value = tendangnhap;
            SqlParameter kq = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add(kq).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            int p_kq = (int)kq.Value;
            return p_kq;
        }
        public DangKi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTaikhoan.Text.Trim();


            if (ChecktrungTaikhoan(tendangnhap) == 1)
            {
                txtTaikhoan.Focus();
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }


            if (tendangnhap == "")
            {
                txtTaikhoan.Focus();
                MessageBox.Show("Hãy nhập tên đăng nhập!");
                return;
            }
            string matkhau = txtMatkhau.Text.Trim();
            if (matkhau == "")
            {
                txtMatkhau.Focus();
                MessageBox.Show("Hãy nhập mật khẩu!");
                return;
            }
            string xacnhan = txtXacnhan.Text.Trim();
            if (xacnhan=="")
            {
                txtXacnhan.Focus();
                MessageBox.Show("Hãy xác nhận lại mật khẩu!");
                return;
            }
            else if(txtXacnhan.Text!= txtMatkhau.Text)
            {
                txtMatkhau.Focus();
                MessageBox.Show("Mật khẩu không trùng khớp!");
                return;
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String them = "Insert into dang_nhap(tendangnhap,matkhau) Values('" + tendangnhap + "', N'" + matkhau + "')";
            SqlCommand cmd = new SqlCommand(them, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            loadgrv();
            MessageBox.Show("Thêm thành công");
            txtTaikhoan.Text = "";
            txtMatkhau.Text = "";
            txtXacnhan.Text = "";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DangKi_Load(object sender, EventArgs e)
        {

        }
    }
}
