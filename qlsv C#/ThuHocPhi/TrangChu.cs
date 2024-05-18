using btcuoiki;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thuhocphi;
using static System.Collections.Specialized.BitVector32;
using static System.Net.WebRequestMethods;

namespace ThuHocPhi
{
    public partial class TrangChu : Form
    {
       
        public TrangChu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }


        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaiKhoan s = new TaiKhoan();
            this.Hide();
            
            s.ShowDialog();
            this.Show();
           
        }

        private void thôngTinLiênLạcToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien();
            this.Hide();
            sv.ShowDialog();
            this.Show();
        }

        private void họcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void họcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
           
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKi dk = new DangKi();
            this.Hide();
            
            dk.ShowDialog();
            this.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau mk = new DoiMatKhau();
            this.Hide();

            mk.ShowDialog();
            this.Show();
        }

        private void thôngTinSinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void thôngTinLiênLạcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHocPhan hp = new FormHocPhan();
            this.Hide();
            hp.ShowDialog();
            this.Show();
        }

        private void thêmHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemHocPhan thp = new FormThemHocPhan();
            this.Hide();
            thp.ShowDialog();
            this.Show();
        }

        private void sửaHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void thuHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThuHocPhi thuHocPhi = new FormThuHocPhi();
            this.Hide();
            thuHocPhi.ShowDialog();
            this.Show();
        }

        private void thốngKêNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongkeno tkn = new FormThongkeno();
            this.Hide();
            tkn.ShowDialog();
            this.Show();
        }

        private void đơnGiáTínCHỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonGia dg = new DonGia();
            this.Hide();
            dg.ShowDialog();
            this.Show();
        }

        private void thêmHọcPhầnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormThemHocPhan themhp = new FormThemHocPhan();
            this.Hide();
            themhp.ShowDialog();
            this.Show();
        }

        private void sửaHọcPhầnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void cậpNhậtLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatLop cnl = new CapNhatLop();
            this.Hide();
            cnl.ShowDialog();
            this.Show();
        }

        private void quảnLýHọcPhầnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormHocPhan fhp = new FormHocPhan();
            this.Hide();
            fhp.ShowDialog(); 
            this.Show();
        }

        private void cậpNhậtNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CNnganhh nganh = new CNnganhh();
            this.Hide();
            nganh.ShowDialog();
            this.Show();
        }
    }
}
