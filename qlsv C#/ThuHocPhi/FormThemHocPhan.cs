
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

namespace btcuoiki
{
    public partial class FormThemHocPhan : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CORZPOVVER3KA\\SQLEXPRESS;Initial Catalog=btl_9;Integrated Security=True");
        public FormThemHocPhan()
        {
            InitializeComponent();
        }


        private bool Kiemtraso(String Text)
        {
            int kq;
            return int.TryParse(Text, out kq);
        }

        private void ChecktrungMahp(String mahp, ref int p_kq)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("ChecktrungMahp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mamh", SqlDbType.NVarChar, 50).Value = mahp;
            SqlParameter kq = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add(kq).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            p_kq = (int)kq.Value;
        }

        private void ChecktrungTenmh(String tenmh, ref int p_kq1)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("ChecktrungTenmh", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tenmh", SqlDbType.NVarChar, 50).Value = tenmh;
            SqlParameter kq = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add(kq).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            p_kq1 = (int)kq.Value;
        }

        private void loadcbNganh()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT DISTINCT nganh FROM monhoc", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            DataRow r = tb.NewRow();
            r["nganh"] = "---Chọn ngành---";
            tb.Rows.InsertAt(r, 0);

            cbNganh.DataSource = tb;
            cbNganh.DisplayMember = "nganh"; // Hiển thị tên học kỳ
            cbNganh.ValueMember = "nganh"; // Giá trị thực sự của ComboBox là mã học kỳ
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

            cbHocKy.DataSource = tb;
            cbHocKy.DisplayMember = "tenHK"; // Hiển thị tên học kỳ
            cbHocKy.ValueMember = "maHK"; // Giá trị thực sự của ComboBox là mã học kỳ
        }
        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            string mamh = txtMamh.Text.Trim();
            if (mamh == "")
            {
                txtMamh.Focus();
                MessageBox.Show("Phải nhập mã học phần");
                return;
            }
            int p_kq = 0;
            ChecktrungMahp(mamh, ref p_kq);
            if (p_kq == 1)
            {
                txtMamh.Focus();
                MessageBox.Show("Trùng mã học phần");
                return;
            }
           
            string tenmon = txtTenmh.Text.Trim();
            if (tenmon == "")
            {
                txtTenmh.Focus();
                MessageBox.Show("Phải nhập tên môn!!!");
                return;
            }
            int p_kq1=0;
            ChecktrungTenmh(tenmon, ref p_kq1);
            if (p_kq1 == 1)
            {
                txtTenmh.Focus();
                MessageBox.Show("Trùng tên học phần!!!");
                return;
            }


            string sotin = txtSotin.Text.Trim();
            if (sotin == "")
            {
                txtSotin.Focus();
                MessageBox.Show("Phải nhập số tín chỉ!!!");
                return;
            }

            if (!Kiemtraso(txtSotin.Text.Trim()))
            {
                txtSotin.Focus();
                MessageBox.Show("Tín chỉ phải nhập số!!!");
                return;
            }

            string hocky = cbHocKy.SelectedValue.ToString();
            if(hocky == "")
            {
                cbHocKy.Focus();
                MessageBox.Show("Phải chọn học kỳ!!!");
            }
            
            string nganh = cbNganh.SelectedValue.ToString();
            if (nganh == "")
            {
                cbNganh.Focus();
                MessageBox.Show("Phải chọn ngành!!!");
            }


            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            String them = "Insert into monhoc(mamh,tenmh, sotin, maHK, nganh) Values('" + mamh + "', N'" + tenmon + "','" + sotin + "', '"+hocky+"', N'"+nganh+"')";
            SqlCommand cmd = new SqlCommand(them, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            
                   
            MessageBox.Show("Thêm thành công");
            txtMamh.Text = "";
            txtTenmh.Text = "";
            txtSotin.Text = "";
            cbHocKy.SelectedValue = "";
            cbNganh.SelectedValue = "";
            
        }

        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThemHocPhan_Load(object sender, EventArgs e)
        {
            loadcbNganh();
            loadcbHocky();
        }
    }
    
}
