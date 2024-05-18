using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using e_excel = Microsoft.Office.Interop.Excel;


namespace btcuoiki
{
    public partial class FormHocPhan : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CORZPOVVER3KA\\SQLEXPRESS;Initial Catalog=btl_9;Integrated Security=True");
        public FormHocPhan()
        {
            InitializeComponent();
        }

        private void loadgrv()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Select mamh, tenmh, sotin, nganh From monhoc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            grvHocPhan.DataSource = tb;

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

            cbHocky.DataSource = tb;
            cbHocky.DisplayMember = "tenHK"; // Hiển thị tên học kỳ
            cbHocky.ValueMember = "maHK"; // Giá trị thực sự của ComboBox là mã học kỳ
        }

        private void FormHocPhan_Load(object sender, EventArgs e)
        {
            loadcbNganh();
            loadcbHocky();
            loadgrv();
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThemHocPhan f = new FormThemHocPhan();
            f.ShowDialog();
            this.Show();
            loadgrv();
        }

        private DataGridViewRow dongchon; // Biến lưu trữ dòng được chọn
        private void grvHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dongchon = grvHocPhan.Rows[e.RowIndex];
                txtMamh.Text = dongchon.Cells["mamh"].Value.ToString();
                txtTenmh.Text = dongchon.Cells["tenmh"].Value.ToString();
                txtSotin.Text = dongchon.Cells["sotin"].Value.ToString();
                //txtHocKy.Text = dongchon.Cells["maHK"].Value.ToString();
            }
        }


        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            if (grvHocPhan.SelectedRows.Count > 0)
            {
                // Lấy giá trị của trường mamh từ dòng đã chọn
                string mamh = grvHocPhan.SelectedRows[0].Cells["mamh"].Value.ToString();

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string xoa = "DELETE FROM monhoc WHERE mamh = @mamh";

                SqlCommand cmd = new SqlCommand(xoa, con);
                cmd.Parameters.AddWithValue("@mamh", mamh);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                loadgrv();
                MessageBox.Show("Xóa thành công");

            }
        }

        private void btn_Sửa_Click(object sender, EventArgs e)
        {
            if (dongchon != null)
            {
                string mahph = dongchon.Cells["mamh"].Value.ToString(); 
                string tenmh = dongchon.Cells["tenmh"].Value.ToString();
                string sotin = dongchon.Cells["sotin"].Value.ToString();
                //string maHK = dongchon.Cells["maHK"].Value.ToString();
                
                FormUpdateHocPhan up = new FormUpdateHocPhan(mahph, tenmh, sotin );
                this.Hide();
                up.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
            loadgrv();

        }

        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Find_Click(object sender, EventArgs e) // tìm kiếm sau khi đã lọc cbNganh và cbHocky
        {
            string mamh = txtMamh.Text.Trim();
            string tenmh = txtTenmh.Text.Trim();
            string sotin = txtSotin.Text.Trim();
            string maHK = cbHocky.SelectedValue.ToString();
            string nganh = cbNganh.SelectedValue.ToString();    
            


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Hocphan_find", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mamh", mamh);
            cmd.Parameters.AddWithValue("@tenmh", tenmh);
            cmd.Parameters.AddWithValue("@sotin", sotin);
           // cmd.Parameters.AddWithValue("@maHK", maHK);
            cmd.Parameters.AddWithValue("@nganh", nganh);
            

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            grvHocPhan.DataSource = tb;
            grvHocPhan.Refresh();



        }
        public void ExportExcel(System.Data.DataTable tb, string sheetname)
        {
            //Tạo các đối tượng Excel

            e_excel.Application oExcel = new e_excel.Application();
            e_excel.Workbooks oBooks;
            e_excel.Sheets oSheets;
            e_excel.Workbook oBook;
            e_excel.Worksheet oSheet;
            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (e_excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (e_excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;
            // Tạo phần đầu nếu muốn
            e_excel.Range head = oSheet.get_Range("A1", "E1");
            head.MergeCells = true;
            head.Value2 = "DANH SÁCH HỌC PHẦN";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ HỌC PHẦN";
            cl1.ColumnWidth = 15;

            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN HỌC PHẦN";
            cl2.ColumnWidth = 30;

            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "SỐ TÍN";
            cl3.ColumnWidth = 10;

            //e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
           // cl4.Value2 = "HỌC KỲ";
           // cl4.ColumnWidth = 15;

            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "NGÀNH";
            cl5.ColumnWidth = 30;

           


            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = e_excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < tb.Rows.Count; r++)
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c < tb.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;
            // Ô bắt đầu điền dữ liệu
            e_excel.Range c1 = (e_excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            e_excel.Range c2 = (e_excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            e_excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = e_excel.Constants.xlSolid;
            // Căn giữa cột STT
            e_excel.Range c3 = (e_excel.Range)oSheet.Cells[rowEnd, columnStart];
            e_excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
        }
        private void btn_XuấtExcel_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = grvHocPhan.DataSource as DataTable;
            ExportExcel(tb, "DANH SÁCH HỌC PHẦN");
        }


        // Tạo một biến DataTable để lưu trữ dữ liệu đã lọc từ ComboBox 2
        


        private string NganhData;
        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nganh = cbNganh.SelectedValue.ToString();
            NganhData = nganh;

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }


            string query = "SELECT mamh, tenmh, sotin, nganh FROM monhoc WHERE nganh = @nganh";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nganh", nganh);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);

            cmd.Dispose();
            con.Close();
            grvHocPhan.DataSource = tb;

        }



        private void cbHocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hocky = cbHocky.SelectedValue.ToString();

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string query = "SELECT mamh, tenmh, sotin, nganh FROM monhoc WHERE nganh = @nganh AND monhoc.maHK = @hocky";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nganh", NganhData);
            cmd.Parameters.AddWithValue("@hocky", hocky);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);

            cmd.Dispose();
            con.Close();


            grvHocPhan.DataSource = tb;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            loadgrv();
            txtMamh.Text = "";
            txtTenmh.Text = "";
            txtSotin.Text = "";
            txtHocKy.Text = "";
            
        }

        private void grvHocPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

       
    





    

