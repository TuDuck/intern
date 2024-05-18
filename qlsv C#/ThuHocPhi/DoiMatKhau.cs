using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThuHocPhi
{
    public partial class DoiMatKhau : Form
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
        

        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTaikhoan.Text.Trim();


            if (ChecktrungTaikhoan(tendangnhap) == 0)
            {
                txtTaikhoan.Focus();
                MessageBox.Show("Tên đăng nhập không tồn tại!");
                
                txtmkcu.Text = "";
                txtmkmoi.Text = "";
                txtxacnhan.Text = "";
                return;
            }


            if (tendangnhap == "")
            {
                txtTaikhoan.Focus();
                MessageBox.Show("Hãy nhập tên đăng nhập!");
                return;
            }
           
            string matkhaucu = txtmkcu.Text.Trim();
            if(matkhaucu == "")
            {
                txtmkcu.Focus();
                MessageBox.Show("Hãy nhập mật khẩu cũ!");
                return;

            }
            string matkhaumoi = txtmkmoi.Text.Trim();
            if( matkhaumoi == "")
            {
                txtmkmoi.Focus();
                MessageBox.Show("Hãy nhập mật khẩu mới!");
                return;
            }
            string xacnhan = txtxacnhan.Text.Trim();
            if(xacnhan == "")
            {
                txtxacnhan.Focus();
                MessageBox.Show("Hãy xác nhận lại mật khẩu!");
                return;
            }
            else if(txtxacnhan.Text!=txtmkmoi.Text)
            {
                txtmkmoi.Focus();
                MessageBox.Show("Mật khẩu không trùng khớp!");
                txtmkmoi.Text = "";
                txtxacnhan.Text = "";
                return;
            }
          
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sua = "update dang_nhap set matkhau = '"+txtmkmoi.Text+"' where tendangnhap='"+txtTaikhoan.Text+"'and matkhau='"+txtmkcu.Text+"'";
            SqlCommand cmd = new SqlCommand(sua, conn);
            cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
            cmd.Parameters.AddWithValue("@matkhau", matkhaumoi);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            loadgrv();
            
            txtTaikhoan.Text = "";
            txtmkcu.Text = "";
            txtmkmoi.Text = "";
            txtxacnhan.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
