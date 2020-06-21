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
    public partial class SachBCTK : Form
    {
        public SachBCTK()
        {
            InitializeComponent();
        }

        private void SachBCTK_Load(object sender, EventArgs e)
        {
            dataGridView_SachKhaDung.DataSource = Ham.tv.GETAVAILABLEBOOKS()
                .Select(x => new { x.MaSach, x.TieuDe })
                .ToList();
            dataGridView_TopSach.DataSource = Ham.tv.GETTOPBOOK();
        }

        private void textBox_SachHienTai_TextChanged(object sender, EventArgs e)
        {
            if (textBox_SachHienTai.Text == "")
            {
                dataGridView_SachKhaDung.DataSource = Ham.tv.GETAVAILABLEBOOKS()
                .Select(x => new { x.MaSach, x.TieuDe })
                .ToList();
            }
            else
            {
                //dataGridView_DanhSachDen.DataSource = Ham.tv.GETBLACKLIST(Ham.maxLate)
                //.Where(x => x.MaDocGia == textBox_DanhSachDen.Text
                //|| x.HoVaTen == textBox_DanhSachDen.Text)
                //.ToList();
            }
        }

        private void textBox_SachMuonNhieu_TextChanged(object sender, EventArgs e)
        {
            if (textBox_SachMuonNhieu.Text == "")
            {
                dataGridView_TopSach.DataSource = Ham.tv.GETTOPBOOK();
            }
            else
            {
                //dataGridView_DanhSachDen.DataSource = Ham.tv.GETBLACKLIST(Ham.maxLate)
                //.Where(x => x.MaDocGia == textBox_DanhSachDen.Text
                //|| x.HoVaTen == textBox_DanhSachDen.Text)
                //.ToList();
            }
        }

        private void button_SachMuonNhieu_Click(object sender, EventArgs e)
        {
            BaoCaoSachMuonNhieu bc = new BaoCaoSachMuonNhieu();
            bc.ShowDialog();
        }
    }
}
