using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using App = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

using System.Runtime.Remoting.Messaging;

namespace ThuHocPhi
{


    public partial class Sinhvien : Form
    {

        SqlConnection con = new SqlConnection("Data Source=CORZPOVVER3KA\\SQLEXPRESS;Initial Catalog=btl_9;Integrated Security=True");
        public Sinhvien()
        {
            InitializeComponent();


            load_cbnganh();
            load_cblop();

        }


      
        private void load_data()
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String query = "select * from sinhvien where malop=@malop and tennganh=@nganh";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@malop", comboBox2.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@nganh", comboBox1.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            // Hiển thị dữ liệu lên DataGridView
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }




            //    String selectedNganh = comboBox1.SelectedItem.ToString();
            //load_data();




            // if (selectedNganh == "công nghệ thông tin")
            // {

            //     comboBox2.Items.Add("72DCTM21");
            //     load_data();


            // }
            // else if (selectedNganh == "điện tử viễn thông")
            // {
            //     comboBox2.Items.Add("72DCDT24"); load_data();
            // }
            // else if (selectedNganh == "kinh tế vận tải")
            // {
            //     comboBox2.Items.Add("72DCKT22"); load_data();

            // }
            //else if (selectedNganh == "ô tô")
            // {
            //     comboBox2.Items.Add("72DCOT23"); load_data();


            // }



        }

        // Sự kiện SelectedIndexChanged của ComboBox ngành, gọi hàm load dữ liệu lớp với idnganh được chọn


        private void load_cbnganh()
        {
            String cbng = "select DISTINCT tennganh from nganh";
            SqlCommand cmd = new SqlCommand(cbng, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow r = dt.NewRow();
            //r["manganh"] = "";
            r["tennganh"] = "------chon nganh----";
            dt.Rows.InsertAt(r, 0);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "tennganh";
            comboBox1.ValueMember = "tennganh";


        }


        private void load_cblop()
        {

            String cblop = "select * from lop";
            SqlCommand cmd = new SqlCommand(cblop, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow r = dt.NewRow();
            r["malop"] = "------chon lop----";

            dt.Rows.InsertAt(r, 0);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "malop";
            comboBox2.ValueMember = "malop";
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CORZPOVVER3KA\\SQLEXPRESS;Initial Catalog=btl_9;Integrated Security=True");
            con.Open();
        }

        private void load_datagr()
        {
            String dtgrload = "Select *from sinhvien ";
            SqlCommand cmd = new SqlCommand(dtgrload, con);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable td = new DataTable();
            ad.Fill(td);
            dataGridView1.DataSource = td;
            dataGridView1.Refresh();
        }
        private int checktrungmasv(String p_masv)
        {
            //b1 knoi database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("checktrungmasv", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@masv", SqlDbType.NVarChar, 50).Value = p_masv;
            SqlParameter Param = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add(Param).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            int p_kq = (int)Param.Value;
            return p_kq;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checktrungmasv(textBox1.Text) == 1)
            {
                textBox1.Focus();
                MessageBox.Show("nhap lai");
                return;
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            String them = "insert into sinhvien values(@masv,@tensv,@malop,@tennganh,@ngaysinh)";
            SqlCommand cmd = new SqlCommand(them, con);
            cmd.Parameters.AddWithValue("masv", textBox1.Text);
            cmd.Parameters.AddWithValue("tensv", textBox2.Text);
            cmd.Parameters.AddWithValue("malop", comboBox2.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("tennganh", comboBox1.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("ngaysinh", dateTimePicker1.Value);


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
            String sua = "update sinhvien Set masv=@masv,tensv=@tensv,malop=@malop,tennganh=@nganh,ngaysinh=@ngaysinh where masv=@masv";
            SqlCommand cmd = new SqlCommand(sua, con);
            cmd.Parameters.AddWithValue("masv", textBox1.Text);
            cmd.Parameters.AddWithValue("tensv", textBox2.Text);
            cmd.Parameters.AddWithValue("malop", comboBox2.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("nganh", comboBox1.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("ngaysinh", dateTimePicker1.Value);

            cmd.ExecuteNonQuery();

            load_datagr();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String xoa = "delete sinhvien where masv=@masv";
            SqlCommand cmd = new SqlCommand(xoa, con);
            cmd.Parameters.AddWithValue("masv", textBox1.Text);
            cmd.Parameters.AddWithValue("tensv", textBox2.Text);
            cmd.Parameters.AddWithValue("malop", comboBox2.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("tennganh", comboBox1.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("ngaysinh", dateTimePicker1.Value);
            cmd.ExecuteNonQuery();
            load_datagr();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String tim = "Select *from sinhvien where masv=@masv";
            SqlCommand cmd = new SqlCommand(tim, con);
            cmd.Parameters.AddWithValue("masv", textBox1.Text);
            cmd.Parameters.AddWithValue("tensv", textBox2.Text);
            cmd.Parameters.AddWithValue("malop", comboBox2.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("tennganh", comboBox1.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("ngaysinh", dateTimePicker1.Value);
            cmd.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            System.Data.DataTable td = new System.Data.DataTable();
            ad.Fill(td);
            //cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = td;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            TrangChu h = new TrangChu();
            h.Show();
        }
        App obj = new App();
        private void xuatexcel(DataGridView dg, String duongdan, String tentep)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            App obj = new App();
            obj.Application.Workbooks.Add(Type.Missing); ;
            obj.Columns.ColumnWidth = 50;
            for (int i = 1; i < dg.Columns.Count; i++)
            {
                obj.Cells[1, i] = dg.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                for (int j = 0; j < dg.Columns.Count; j++)
                {
                    if (dg.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tentep + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        String filename;

        private void button6_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            xuatexcel(dataGridView1, "E:\\C#\\", "e_excel.xlsx");
            FileInfo fi = new FileInfo("E:\\C#\\e_excel.xlsx.xlsx");
            if (fi.Exists)
            {
                System.Diagnostics.Process.Start(@"E:\C#\e_excel.xlsx.xlsx");
            }
            else
            {
                //file doesn't exist
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbCommand Ole = new OleDbCommand("SELECT * FROM [Sheet1]");
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "excel file |*.xls;*.xlsx";
            f.FilterIndex = 1; //trỏ vào vị trí đầu tiên của bộ lọc
            f.RestoreDirectory = true; // nhớ đường dẫn của lần truy cập trước
            f.Multiselect = false; //không cho phép chọn nhiều file 1 lúc
            if (f.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = f.FileName;
                filename = f.FileName;  //Biến filename khai báo biến toàn cục
                System.Diagnostics.Process.Start(filename);
            }
            if (filename == null)
            {
                MessageBox.Show("Chưa chọn file");
            }
            else
            {

            }
        }




        private void button8_Click(object sender, EventArgs e)
        {

            load_datagr();

        }

        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            String cblop = comboBox2.SelectedValue.ToString();
            load_data();


            //if (cblop == "72DCTM21")
            //{
            //    load_data();
            //}
            //else if (cblop == "72DCDT24")
            //{
            //    load_data();
            //}
            //else if (cblop == "72DCKT22")
            //{
            //    load_data(); 
            //}
            //else if (cblop == "72DCOT23")
            //{
            //    load_data();
            //}
            //else MessageBox.Show("loi roi");
        }
    }
}
