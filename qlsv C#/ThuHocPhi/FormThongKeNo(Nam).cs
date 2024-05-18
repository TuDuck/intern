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
using e_excel = Microsoft.Office.Interop.Excel;

namespace ThuHocPhi
{
    public partial class FormThongkeno : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=CORZPOVVER3KA\\SQLEXPRESS;Initial Catalog=btl_9;Integrated Security=True");
        public FormThongkeno()
        {
            InitializeComponent();
        }

        public void getconn()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
       

        public void loadcbNganh()
        {          
            getconn();
            
            SqlCommand cmd = new SqlCommand("Select DISTINCT nganh From monhoc", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            conn.Close();

            DataRow r = tb.NewRow();
            r["nganh"] = "";
            r["nganh"] = "---Chọn ngành---";
            tb.Rows.InsertAt(r, 0);

            cbNganh.DataSource = tb;
            cbNganh.DisplayMember = "nganh";
            cbNganh.ValueMember = "nganh";

        }

        public void loadcbHocky()
        {
            getconn();

            SqlCommand cmd = new SqlCommand("Select DISTINCT maHK, tenHK From hocki", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            conn.Close();

            DataRow r = tb.NewRow();
            r["maHK"] = "";
            r["tenHK"] = "---Chọn học kỳ---";
            tb.Rows.InsertAt(r, 0);

            cbHocky.DataSource = tb;
            cbHocky.DisplayMember = "tenHK";
            cbHocky.ValueMember = "maHK";

        }


        private void Load_grvThuno()
        {
            getconn();
            string a = "SELECT thuno.masv, thuno.tensv, nganh.hocphiky, thuno.dadong, thuno.phaidong FROM thuno CROSS JOIN nganh WHERE thuno.maHK = nganh.maHK AND thuno.nganh = nganh.tennganh AND thuno.dadong > 0 AND thuno.dadong IS NOT NULL";
            SqlCommand cmd = new SqlCommand(a, conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            cmd.Dispose();
            conn.Close();
            grvThuno.DataSource = tb;
        }
        private void Form12_Load(object sender, EventArgs e)
        {
            loadcbNganh();
            loadcbHocky();
            Load_grvThuno();           
        }

        private void grvThuno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if(i > -1)
            {
                txtMasv.Text = grvThuno.Rows[i].Cells["masv"].Value.ToString();
                txtHoten.Text = grvThuno.Rows[i].Cells["tensv"].Value.ToString();               
                txtDadong.Text = grvThuno.Rows[i].Cells["dadong"].Value.ToString();
                txtConphaidong.Text = grvThuno.Rows[i].Cells["phaidong"].Value.ToString();

            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            String p_masv = txtMasvfind.Text.Trim();
            if(p_masv == "(Nhập mã sinh viên)")
            {
                MessageBox.Show("Chưa nhập mã sinh viên");
                return;
            }
            SqlCommand cmd = new SqlCommand("Thuno_find", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@masv", SqlDbType.NVarChar, 50).Value = p_masv;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            conn.Close();
            grvThuno.DataSource = dt;
        }

        public void ExportExcel(DataTable tb, string sheetname)
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
            e_excel.Range head = oSheet.get_Range("A1", "D1");
            head.MergeCells = true;
            head.Value2 = "DANH SÁCH KHOẢN NỢ";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ SINH VIÊN";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN SINH VIÊN";

            cl2.ColumnWidth = 30.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "HỌC PHÍ(THEO HỌC KỲ)";
            cl3.ColumnWidth = 40.0;
            e_excel.Range cl5 = oSheet.get_Range("D3", "D3");
            cl5.Value2 = "ĐÃ ĐÓNG";
            cl5.ColumnWidth = 20.0;
            e_excel.Range cl4 = oSheet.get_Range("E3", "E3");
            cl4.Value2 = "CÒN PHẢI ĐÓNG";
            cl4.ColumnWidth = 30.0;
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
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = grvThuno.DataSource as DataTable;
            //b6: goi phuong thuc ExportExcel
            ExportExcel(tb, "DSKhoanno");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string nganhData;

        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nganh = cbNganh.SelectedValue.ToString();
            nganhData = nganh;
            getconn();
            string a = "SELECT thuno.masv, thuno.tensv, nganh.hocphiky, thuno.dadong, thuno.phaidong FROM thuno CROSS JOIN nganh WHERE thuno.maHK = nganh.maHK AND thuno.nganh = nganh.tennganh AND thuno.nganh = @nganh AND thuno.dadong > 0 AND thuno.dadong IS NOT NULL";
            SqlCommand cmd = new SqlCommand(a, conn);
            cmd.Parameters.AddWithValue("@nganh", nganh);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable tb1 = new DataTable();
            da1.Fill(tb1);
            cmd.Dispose();
            conn.Close();

            grvThuno.DataSource = tb1;

        }

        

        private void cbHocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hocky = cbHocky.SelectedValue.ToString();
            getconn();
            string a = "SELECT thuno.masv, thuno.tensv, nganh.hocphiky, thuno.dadong, thuno.phaidong FROM thuno CROSS JOIN nganh WHERE thuno.maHK = nganh.maHK AND thuno.nganh = nganh.tennganh AND thuno.maHK = @hocky AND thuno.nganh = @nganh AND thuno.dadong > 0 AND thuno.dadong IS NOT NULL";
            SqlCommand cmd = new SqlCommand(a, conn);
            cmd.Parameters.AddWithValue("@nganh", nganhData);
            cmd.Parameters.AddWithValue("@hocky", hocky);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable tb1 = new DataTable();
            da1.Fill(tb1);
            cmd.Dispose();
            conn.Close();

            grvThuno.DataSource = tb1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
