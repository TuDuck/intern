using Microsoft.Office.Interop.Excel;
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
using DataTable = System.Data.DataTable;

namespace ThuHocPhi
{
    public partial class CNnganhh : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CORZPOVVER3KA\\SQLEXPRESS;Initial Catalog=btl_9;Integrated Security=True");
        public CNnganhh()
        {
            InitializeComponent();
            load_datagr();
            loadcbHocky();  
        }
        private void load_datagr()
        {
            String dtgrload = "Select manganh,tennganh,maHK from nganh ";
            SqlCommand cmd = new SqlCommand(dtgrload, con);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable td = new DataTable();
            ad.Fill(td);
            dataGridView1.DataSource = td;
            dataGridView1.Refresh();
        }
        private void loadcbHocky()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT maHK, tenHK FROM hocki", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            DataRow r = tb.NewRow();
            r["maHK"] = ""; // Giá trị rỗng cho lựa chọn đầu tiên
            r["tenHK"] = "---Chọn học kỳ---";
            tb.Rows.InsertAt(r, 0);

            comboBox1.DataSource = tb;
            comboBox1.DisplayMember = "tenHK"; // Hiển thị tên học kỳ
            comboBox1.ValueMember = "maHK"; // Giá trị thực sự của ComboBox là mã học kỳ
        }
        private void button4_Click(object sender, EventArgs e)
        {
            load_datagr();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        
        String them = "insert into nganh values(@manganh,@tennganh,@maHK)";
            SqlCommand cmd = new SqlCommand(them, con);
            cmd.Parameters.AddWithValue("manganh", textBox1.Text);
            cmd.Parameters.AddWithValue("tennganh", textBox2.Text);
            cmd.Parameters.AddWithValue("maHK", comboBox1.SelectedValue.ToString());
            
            


            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            dataGridView1.Refresh();
            load_datagr();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String sua = "update nganh Set manganh=@manganh,tennganh=@tennganh,maHK=@maHK where manganh=@manganh";
            SqlCommand cmd = new SqlCommand(sua, con);
            cmd.Parameters.AddWithValue("manganh", textBox1.Text);
            cmd.Parameters.AddWithValue("tennganh", textBox2.Text);
            cmd.Parameters.AddWithValue("maHK", comboBox1.SelectedValue.ToString());
            


            cmd.ExecuteNonQuery();

            load_datagr();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String xoa = "delete nganh where manganh=@manganh";
            SqlCommand cmd = new SqlCommand(xoa, con);
            cmd.Parameters.AddWithValue("manganh", textBox1.Text);
            cmd.Parameters.AddWithValue("tennganh", textBox2.Text);
            cmd.Parameters.AddWithValue("maHK", comboBox1.SelectedValue.ToString());
            

            cmd.ExecuteNonQuery();
            load_datagr();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
