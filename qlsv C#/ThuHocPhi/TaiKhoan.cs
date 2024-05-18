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
using System.Windows.Input;

namespace ThuHocPhi
{
    public partial class TaiKhoan : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=CORZPOVVER3KA\\SQLEXPRESS;Initial Catalog=btl_9;Integrated Security=True");


        public void getconn()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public TaiKhoan()
        {
            InitializeComponent();
        }


        private void loaddata()
        {
            getconn();
            String sql = "Select * from dang_nhap";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            conn.Close();
            dgvTaikhoan.DataSource = tb;
            dgvTaikhoan.Refresh();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtUsername.Text.Trim();
            if (txtUsername.Text == "")
            {
                txtUsername.Focus();
                MessageBox.Show("Vui Lòng chọn tài khoản cần xóa");
                return;
            }
            getconn();
            string xoa = "Delete From dang_nhap Where tendangnhap='" + tendangnhap + "'";
            SqlCommand cmd = new SqlCommand(xoa, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            loaddata();
            MessageBox.Show("Xóa thành công");

        }

        private void dgvTaikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTaikhoan.Rows.Count)
            {
                DataGridViewRow row = dgvTaikhoan.Rows[e.RowIndex];
                txtUsername.Text = row.Cells["tendangnhap"].Value.ToString();
                txtPassword.Text = row.Cells["matkhau"].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String tendangnhap = txtUsername.Text.Trim();
            if (tendangnhap == "")
            {
                txtUsername.Focus();
                MessageBox.Show("Nhập tên tài khoản cần tìm");
                loaddata();
                return;
            }
            SqlCommand cmd = new SqlCommand("Find_DN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tendangnhap", SqlDbType.NVarChar, 50).Value = tendangnhap;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            conn.Close();
            dgvTaikhoan.DataSource = dt;
            txtUsername.Text = "";
            txtPassword.Text = "";
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}