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
namespace ThuHocPhi
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Mời nhập tài khoản!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Mời nhập mật khẩu");
            }
            else
            {
                try
                {

                    SqlConnection conn = new SqlConnection("Data Source=CORZPOVVER3KA\\SQLEXPRESS;Initial Catalog=btl_9;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Select * from dang_nhap where tendangnhap= @tendangnhap and matkhau= @matkhau", conn);
                    cmd.Parameters.AddWithValue("@tendangnhap", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@matkhau", txtPassword.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        TrangChu h = new TrangChu();
                        this.Hide();
                        
                        h.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tên tài Khoản hoặc mật khẩu không đúng!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                txtUsername.Text = "";
                txtPassword.Text = "";
            }    



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
