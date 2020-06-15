using QUANLYTHUVIEN.Models;
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
            Ham.openFormInPanel(new NhanVien(), panel_Content);
        }

        private void button_MuonTra_Click(object sender, EventArgs e)
        {
            Ham.openFormInPanel(new MuonTra(), panel_Content);
        }

        private void button_DocGia_Click(object sender, EventArgs e)
        {
            Ham.openFormInPanel(new DocGia(), panel_Content);
        }

        private void button_Sach_Click(object sender, EventArgs e)
        {
            Ham.openFormInPanel(new Sach(), panel_Content);
        }

        private void button_PhanQuyen_Click(object sender, EventArgs e)
        {
            PhanQuyen pq = new PhanQuyen();
            pq.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ham.openFormInPanel(new NhanVien(), panel_Content);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            NHANVIEN nv = Ham.tv.NHANVIENs.Where(x => x.MaNhanVien == Ham.currentUser).SingleOrDefault();
            if(nv == null)
            {
                label_MaNhanVien.Text = "Khách";
                label_HoVaTen.Text = "Khách";
            }
            else
            {
                label_MaNhanVien.Text = nv.MaNhanVien;
                label_HoVaTen.Text = nv.HoVaTen;
                pictureBox_Anh.ImageLocation = nv.Anh == null? Ham.defaultNVImage : nv.Anh;
            }
        }
    }
}
