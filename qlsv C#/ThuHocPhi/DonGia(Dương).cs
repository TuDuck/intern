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
    public partial class DonGia : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=CORZPOVVER3KA\\SQLEXPRESS;Initial Catalog=btl_9;Integrated Security=True");
        private void loadgrv()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            String sql = "Select mamh, tenmh, sotin, giatin from monhoc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            conn.Close();
            grvDongia.DataSource = tb;
            grvDongia.Refresh();
        }
        private bool Kiemtraso(String Text)
        {
            int kq;
            return int.TryParse(Text, out kq);
        }
        private int ChecktrungMaMH(String mamh)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("ChecktrungMaMH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mamh", SqlDbType.NVarChar, 50).Value = mamh;
            SqlParameter kq = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add(kq).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            int p_kq = (int)kq.Value;
            return p_kq;
        }

        public DonGia()
        {
            InitializeComponent();
        }

        private void DonGia_Load(object sender, EventArgs e)
        {
            loadgrv();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            string tenmh = txttenmh.Text.Trim();
            string mamh = txtmamh.Text.Trim();
            string sotin = txtsotin.Text.Trim();
            string giatin = txtgiatin.Text.Trim();
            if (ChecktrungMaMH(txtmamh.Text) == 0)
            {
                txtmamh.Focus();
                MessageBox.Show("Mã môn học không tồn tại!");
                return;
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }


            string sua = "update monhoc set sotin=@sotin, giatin=@giatin where tenmh =@tenmh AND mamh =@mamh";
            SqlCommand cmd = new SqlCommand(sua, conn);
            cmd.Parameters.AddWithValue("@mamh", txtmamh.Text);
            cmd.Parameters.AddWithValue("@tenmh", txttenmh.Text);
            cmd.Parameters.AddWithValue("@sotin", txtsotin.Text);
            cmd.Parameters.AddWithValue("@giatin", txtgiatin.Text);
            cmd.ExecuteNonQuery();
            loadgrv();
            MessageBox.Show("Sửa thành công!");

            txtmamh.Text = "";
            txttenmh.Text = "";
            txtsotin.Text = "";         
            txtgiatin.Text = "";
        }

        private void grvDongia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i > -1)
            {
                txtmamh.Text = grvDongia.Rows[i].Cells["mamh"].Value.ToString();
                txttenmh.Text = grvDongia.Rows[i].Cells["tenmh"].Value.ToString();
                txtsotin.Text = grvDongia.Rows[i].Cells["sotin"].Value.ToString();             
                txtgiatin.Text = grvDongia.Rows[i].Cells["giatin"].Value.ToString();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtmamh.Text == "")
            {
                txtmamh.Focus();
                MessageBox.Show("Vui Lòng chọn mã môn học cần xóa");
                return;
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String xoa = "delete monhoc where mamh=@mamh";
            SqlCommand cmd = new SqlCommand(xoa, conn);
            cmd.Parameters.AddWithValue("@mamh", txtmamh.Text);
            cmd.Parameters.AddWithValue("@tenmh", txttenmh.Text);
            cmd.Parameters.AddWithValue("@sotin", txtsotin.Text);        
            cmd.Parameters.AddWithValue("@giatin", txtgiatin.Text);
            cmd.ExecuteNonQuery();
            loadgrv();
            MessageBox.Show("Xóa thành công!");
            txtmamh.Text = "";
            txttenmh.Text = "";
            txtsotin.Text = "";            
            txtgiatin.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            head.Value2 = "DANH SÁCH ĐƠN GIÁ";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ MÔN HỌC";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN MÔN HỌC";

            cl2.ColumnWidth = 30.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "SỐ TÍN";
            cl3.ColumnWidth = 40.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "GIÁ TÍN";
            cl4.ColumnWidth = 20.0;
           

            e_excel.Range rowHead = oSheet.get_Range("A3", "D3");
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
            tb = grvDongia.DataSource as DataTable;
            //b6: goi phuong thuc ExportExcel
            ExportExcel(tb, "DSKhoanno");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String mamh = txtFind.Text.Trim();
            if (mtenmh == "")
            {
                txtFind .Focus();
                MessageBox.Show("Chưa nhập ten môn học");
                loadgrv();
                return;
            }
            SqlCommand cmd = new SqlCommand("Dongia_find", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tenmh", SqlDbType.NVarChar, 50);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            conn.Close();
            grvDongia.DataSource = dt;
            txtFind.Text = "";
            txtmamh.Text = "";
            txttenmh.Text = "";
            txtsotin.Text = "";
            txtgiatin.Text = "";

        }
    }
}
