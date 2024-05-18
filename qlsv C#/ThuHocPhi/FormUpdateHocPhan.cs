
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace btcuoiki
{
    public partial class FormUpdateHocPhan : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CORZPOVVER3KA\\SQLEXPRESS;Initial Catalog=btl_9;Integrated Security=True");


        public FormUpdateHocPhan(string mamh, string tenmh, string sotin)
        {
            InitializeComponent();          
            // Hiển thị dữ liệu trong các TextBox
            txtMamh.Text = mamh;
            txtTenmh.Text = tenmh;
            txtSotin.Text = sotin;
           // txtHocky.Text = maHK;
            
            //txtNganh.Text = nganh;    
        }

        private void btn_Update_Click(object sender, EventArgs e)  // sửa tên môn học với điều kiện trùng mã và tín mới = cũ
        {
            string mamh  = txtMamh.Text.Trim();
            string tenmh = txtTenmh.Text.Trim();
            string sotin = txtSotin.Text.Trim();
            string hocky = txtHocky.Text.Trim();
           
            //string nganh = txtNganh.Text.Trim(); 
           
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sua = "UPDATE monhoc SET tenmh = @tenmh, sotin =@sotinm, maHK = @maHK WHERE mamh = @mamh AND sotin=@sotin AND @hocky = maHK";

            SqlCommand cmd = new SqlCommand(sua, con); 
            cmd.Parameters.AddWithValue("@mamh", mamh) ;
            cmd.Parameters.AddWithValue("@tenmh", tenmh);
            cmd.Parameters.AddWithValue("@sotin", sotin);
            cmd.Parameters.AddWithValue("@hocky", hocky);

            //cmd.Parameters.AddWithValue("@giatin", giatin);
            

            cmd.ExecuteNonQuery(); 
            cmd.Dispose();
            con.Close();
                                         
            MessageBox.Show("Sửa thành công");           
        }

        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUpdateHocPhan_Load(object sender, EventArgs e)
        {

        }
    }
}
