using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_excel = Microsoft.Office.Interop.Excel;

namespace ThuHocPhi
{
    public partial class CNnganh : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-TQ8IENS6;Initial Catalog=btl_9;Integrated Security=True");

        public void getconn()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        private void Load_grvNganh()
        {
            getconn();
            SqlCommand cmd = new SqlCommand("Select * from nganh", conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            conn.Close();
            grvNganh.DataSource = dt;
            grvNganh.Refresh();
        }

        public CNnganh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Load_grvNganh();
            loadcbHocky();
        }
        private void loadcbHocky()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT maHK, tenHK FROM hocki", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable tb = new System.Data.DataTable();
            da.Fill(tb);
            cmd.Dispose();
            conn.Close();

            DataRow r = tb.NewRow();
            r["maHK"] = ""; // Giá trị rỗng cho lựa chọn đầu tiên
            r["tenHK"] = "---Chọn học kỳ---";
            tb.Rows.InsertAt(r, 0);

            comboBox1.DataSource = tb;
            comboBox1.DisplayMember = "tenHK"; // Hiển thị tên học kỳ
            comboBox1.ValueMember = "maHK"; // Giá trị thực sự của ComboBox là mã học kỳ
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        //private void checkManganh(String text, ref int p_kq)
        //{
        //    getconn();
        //    SqlCommand cmd = new SqlCommand("CheckManganh", conn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("@manganh", SqlDbType.NVarChar, 30).Value = text;
        //    SqlParameter kq = new SqlParameter("@kq", SqlDbType.Int);
        //    cmd.Parameters.Add(kq).Direction = ParameterDirection.Output;
        //    cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    conn.Close();
        //    p_kq = (int)kq.Value;
        //}
      

        private void btnThen_Click(object sender, EventArgs e)
        {
            String p_manganh = txtManganh.Text.Trim();
            String p_tenng = txtTenng.Text.Trim();
          
            getconn();
            //int p_kq = 0;
            //checkManganh(p_manganh, ref p_kq);
            //p_kq == 0
            if (p_manganh=="")
            {
                txtManganh.Focus();
                MessageBox.Show("Mã ngành không tồn tại");
                return;
            }
            if (p_tenng == "")
            {
                txtTenng.Focus();
                MessageBox.Show("Nhập tên ngành");
                return;
            }
           
            
            SqlCommand cmd = new SqlCommand("Insert into nganh values('" + p_manganh + "',N'" + p_tenng + "')", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            Load_grvNganh();
            MessageBox.Show("Thêm thành công");
        }
        int rowIndex;
        String tmp_masv;

        private void grvTtlienlac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            txtManganh.Text = grvNganh.Rows[rowIndex].Cells["manganh"].Value.ToString();
            txtTenng.Text = grvNganh.Rows[rowIndex].Cells["tennganh"].Value.ToString();
          
            tmp_masv = txtManganh.Text.Trim();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String p_masv = txtManganh.Text.Trim();
            String p_tenph = txtTenng.Text.Trim();
          
            getconn();
            if (p_masv != tmp_masv)
            {
                txtManganh.Focus();
                MessageBox.Show("Không thể sửa mã nganh");
                return;
            }
            if (p_tenph == "")
            {
                txtTenng.Focus();
                MessageBox.Show("Nhập tên nganh");
                return;
            }


            String sua = "Update nganh set tennganh=@tennganh where manganh=@manganh";


            SqlCommand cmd = new SqlCommand(sua,conn);
            cmd.Parameters.AddWithValue("@manganh", txtManganh.Text);
            cmd.Parameters.AddWithValue("@tennganh", txtTenng.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Cập nhật thông tin thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String xoa = "Delete  nganh where manganh = manganh";
           
            getconn();
            SqlCommand cmd = new SqlCommand(xoa, conn);
            cmd.Parameters.AddWithValue("@manganh", txtManganh.Text);
            cmd.Parameters.AddWithValue("@tennganh", txtTenng.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Xóa thành công");
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            String tim = "select * from nganh where manganh=@manganh";
            String p_masv = txtManganh.Text.Trim();
            String p_tenph = txtTenng.Text.Trim();
            
            SqlCommand cmd = new SqlCommand(tim, conn);
            
            cmd.Parameters.Add("@manganh", SqlDbType.NVarChar, 50).Value = p_masv;
            cmd.Parameters.Add("@tennganh", SqlDbType.NVarChar, 50).Value = p_tenph;
            

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            System.Data.DataTable tb = new System.Data.DataTable();
            ad.Fill(tb);
            grvNganh.DataSource = tb;
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grvTtlienlac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }


