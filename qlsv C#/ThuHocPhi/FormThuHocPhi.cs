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
using App = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;
//using Microsoft.Office.Core;
using System.Runtime.Remoting.Messaging;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using e_excel = Microsoft.Office.Interop.Excel;



namespace Thuhocphi
{
    public partial class FormThuHocPhi : Form
    {

        SqlConnection con = new SqlConnection("Data Source=CORZPOVVER3KA\\SQLEXPRESS;Initial Catalog=btl_9;Integrated Security=True");

        private DataTable hocPhanTable;

        public FormThuHocPhi()
        {
            InitializeComponent();
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
            r["nganh"] = ""; // Giá trị rỗng cho lựa chọn đầu tiên
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

            SqlCommand cmd = new SqlCommand("SELECT mahK, tenHK FROM hocki", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            DataRow r = tb.NewRow();
            r["tenHK"] = ""; // Giá trị rỗng cho lựa chọn đầu tiên
            r["tenHK"] = "---Chọn học kỳ---";
            tb.Rows.InsertAt(r, 0);

            cbHocky.DataSource = tb;
            cbHocky.DisplayMember = "tenHK"; // Hiển thị tên học kỳ
            cbHocky.ValueMember = "maHK"; // Giá trị thực sự của ComboBox là mã học kỳ


        }

        private void loadgrvSinhVien()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string a = "SELECT sinhvien.masv, sinhvien.tensv, sinhvien.malop, thuno.phaidong, thuno.tongtien FROM sinhvien INNER JOIN thuno ON sinhvien.masv = thuno.masv";
            SqlCommand cmd = new SqlCommand(a, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            grvSinhVien.DataSource = tb;

        }
        private void loadgrvHocPhan()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            String a = "SELECT mamh, tenmh, sotin, giatin FROM monhoc";
            SqlCommand cmd = new SqlCommand(a, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            grvHocPhan.DataSource = tb;
        }



        private void FormThuHocPhi_Load(object sender, EventArgs e)
        {
            loadcbNganh();
            loadcbHocky();
            loadgrvSinhVien();
            loadgrvHocPhan();
        }


        private void TinhSotin()
        {
            int SumTin = 0;

            // Lặp qua từng hàng trong DataGridView và tính tổng cột "sotin"
            for (int i = 0; i < grvHocPhan.Rows.Count; i++)
            {
                DataGridViewRow row = grvHocPhan.Rows[i];
                if (row.Cells["sotin"].Value != null)
                {
                    int sotin = 0;
                    int.TryParse(row.Cells["sotin"].Value.ToString(), out sotin);
                    SumTin += sotin;
                }
            }

            // Hiển thị kết quả tổng lên lbTongtin
            txtTin.Text = SumTin.ToString();
        }

        private void TinhTongTien()
        {
            double tienHK = 0;
            double TongTien = 0;

            // Duyệt qua từng hàng trong grvHocPhan và tính tổng tiền
            for (int i = 0; i < grvHocPhan.Rows.Count; i++)
            {
                DataGridViewRow row = grvHocPhan.Rows[i];

                if (row.Cells["sotin"].Value != null && row.Cells["giatin"].Value != null)
                {
                    int sotin = 0;
                    int.TryParse(row.Cells["sotin"].Value.ToString(), out sotin);

                    double giatin = 0;
                    double.TryParse(row.Cells["giatin"].Value.ToString(), out giatin);

                    double tienMon = sotin * giatin;
                    tienHK += tienMon;
                }
            }
            txtTienHocKy.Text = tienHK.ToString("N0");
            


            // Duyệt qua từng hàng trong grvSinhVien và cộng phần đóng vào tổng tiền
            for (int i = 0; i < grvSinhVien.Rows.Count; i++)
            {
                DataGridViewRow row = grvSinhVien.Rows[i];
                DataGridViewCell cell = row.Cells["phaidong"];

                if (row.Selected && cell.Value != null && double.TryParse(cell.Value.ToString(), out double phaiDong))
                {
                    TongTien = tienHK + phaiDong;
                    break; // Thoát khỏi vòng lặp sau khi tìm thấy dòng phaidong được chọn
                }
                else
                {
                    TongTien = tienHK;
                }
            }

            txtTongtien.Text = TongTien.ToString("N0");
        }


        private DataGridViewRow dongchon;
        private void grvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grvSinhVien.Rows.Count)
            {
                dongchon = grvSinhVien.Rows[e.RowIndex];
                txtMasv.Text  = dongchon.Cells["masv"].Value.ToString();
                txtHoten.Text = dongchon.Cells["tensv"].Value.ToString();
                txtMalop.Text = dongchon.Cells["malop"].Value.ToString();
                txtNo.Text = dongchon.Cells["phaidong"].Value.ToString();
              
                //dateTimePicker1.Value = DateTime.Parse(dongchon.Cells["ngaysinh"].Value.ToString());
            }
        }


        private void btn_Find_Click(object sender, EventArgs e)
        {       

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string query = "SELECT masv, tensv, malop, nganh FROM sinhvien WHERE masv LIKE @Keyword OR tensv LIKE @Keyword OR malop LIKE @Keyword OR nganh LIKE @Keyword";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Keyword", "%" + txtFind.Text.Trim() + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            grvSinhVien.DataSource = tb;
            grvSinhVien.Refresh();
        }

        private string nganhData; // Biến lưu trữ thông tin lọc từ cbNganh

        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nganh = cbNganh.SelectedValue.ToString();

            // Lưu trữ thông tin lọc từ cbNganh
            nganhData = nganh;

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string query1 = "SELECT sinhvien.masv, sinhvien.tensv, sinhvien.malop, thuno.phaidong, thuno.tongtien FROM sinhvien INNER JOIN  thuno ON sinhvien.masv = thuno.masv WHERE sinhvien.tennganh = @nganh";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.Parameters.AddWithValue("@nganh", nganh);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable tb1 = new DataTable();
            da1.Fill(tb1);
            cmd1.Dispose();
            con.Close();

            grvSinhVien.DataSource = tb1;



            string query2 = "SELECT mamh, tenmh, sotin, giatin FROM monhoc WHERE monhoc.nganh = @nganh";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.Parameters.AddWithValue("@nganh", nganh);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable tb2 = new DataTable();
            da2.Fill(tb2);
            cmd2.Dispose();
            con.Close();

            grvHocPhan.DataSource = tb2;
        }

        private void cbHocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hocky = cbHocky.SelectedValue.ToString();

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string query1 = "SELECT sinhvien.masv, sinhvien.tensv, sinhvien.malop, thuno.phaidong, thuno.tongtien FROM sinhvien INNER JOIN thuno ON sinhvien.masv = thuno.masv WHERE thuno.maHK = @hocky AND thuno.nganh = @nganh";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.Parameters.AddWithValue("@nganh", nganhData);
            cmd1.Parameters.AddWithValue("@hocky", hocky);

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable tb1 = new DataTable();
            da1.Fill(tb1);
            cmd1.Dispose();
            con.Close();

            grvSinhVien.DataSource = tb1;

            string query = "SELECT mamh, tenmh, sotin, giatin FROM monhoc WHERE monhoc.maHK = @hocky AND monhoc.nganh = @nganh";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nganh", nganhData);
            cmd.Parameters.AddWithValue("@hocky", hocky);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grvHocPhan.DataSource = tb;

           
            
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
            head.Value2 = "BẢNG THU HỌC PHÍ";
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
            cl2.ColumnWidth = 30;

            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "MÃ LỚP";
            cl3.ColumnWidth = 10;

            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "CÒN PHẢI ĐÓNG";
            cl4.ColumnWidth = 15;

            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "TỔNG TIỀN";
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


        private void btn_Bill_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = grvSinhVien.DataSource as DataTable;
            ExportExcel(tb, "THU HỌC PHÍ");
        }

      
        private void btn_SUM_Click(object sender, EventArgs e)
        {
            TinhSotin();
            TinhTongTien();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}







