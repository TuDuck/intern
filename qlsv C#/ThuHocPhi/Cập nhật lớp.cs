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

namespace ThuHocPhi
{
    public partial class CapNhatLop : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CORZPOVVER3KA\\SQLEXPRESS;Initial Catalog=btl_9;Integrated Security=True");

        public CapNhatLop()
        {
            InitializeComponent();
        }
        public void getconn()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            load_grlop();
        }
        private void load_grlop(){
            SqlCommand cmd = new SqlCommand("Select * from lop", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String p_malop = textBox1.Text.Trim();
            String p_tenlop = textBox2.Text.Trim();

            getconn();
            //int p_kq = 0;
            //checkManganh(p_manganh, ref p_kq);
            //p_kq == 0
            if (p_malop == "")
            {
                textBox1.Focus();
                MessageBox.Show("Mã ngành không tồn tại");
                return;
            }
            if (p_tenlop == "")
            {
                textBox2.Focus();
                MessageBox.Show("Nhập tên ngành");
                return;
            }


            SqlCommand cmd = new SqlCommand("Insert into nganh values('" + p_malop + "',N'" + p_tenlop + "')", con) ;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            load_grlop();
            MessageBox.Show("Thêm thành công");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String p_malop = textBox1.Text.Trim();
            String p_tenlop = textBox2.Text.Trim();

            getconn();
            //int p_kq = 0;
            //checkManganh(p_manganh, ref p_kq);
            //p_kq == 0
            if (p_malop == "")
            {
                textBox1.Focus();
                MessageBox.Show("Mã ngành không tồn tại");
                return;
            }
            if (p_tenlop == "")
            {
                textBox2.Focus();
                MessageBox.Show("Nhập tên ngành");
                return;
            }

            String sua = "Update lop set tenlop=@tenlop where malop=@malop";


            SqlCommand cmd = new SqlCommand(sua, con);
            cmd.Parameters.AddWithValue("@malop", textBox1.Text);
            cmd.Parameters.AddWithValue("@tenlop", textBox2.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Cập nhật thông tin thành công");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String xoa = "Delete  lop where malop = malop";

            getconn();
            SqlCommand cmd = new SqlCommand(xoa, con);
            cmd.Parameters.AddWithValue("@manganh", textBox1.Text);
            cmd.Parameters.AddWithValue("@tennganh", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Xóa thành công");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String tim = "select * from lop where malop=@malop";
            String p_malop = textBox1.Text.Trim();
            String p_tenlop = textBox2.Text.Trim();

            SqlCommand cmd = new SqlCommand(tim, con);

            cmd.Parameters.Add("@malop", SqlDbType.NVarChar, 50).Value = p_malop;
            cmd.Parameters.Add("@tenlop", SqlDbType.NVarChar, 50).Value = p_tenlop;


            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
