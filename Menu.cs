using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUVIEN
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button_NhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.ShowDialog();
        }

        private void button_MuonTra_Click(object sender, EventArgs e)
        {
            MuonTra mt = new MuonTra();
            mt.ShowDialog();
        }

        private void button_DocGia_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();
            dg.ShowDialog();
        }

        private void button_Sach_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            s.ShowDialog();
        }

        private void button_PhanQuyen_Click(object sender, EventArgs e)
        {
            PhanQuyen pq = new PhanQuyen();
            pq.ShowDialog();
        }
    }
}
