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
    public partial class DocGiaBCTK : Form
    {
        public DocGiaBCTK()
        {
            InitializeComponent();
        }

        private void DocGiaBCTK_Load(object sender, EventArgs e)
        {
            dataGridView_DanhSachDen.DataSource = Ham.tv.GETBLACKLIST(Ham.maxLate);
            dataGridView_TopDocGia.DataSource = Ham.tv.GETTOPMEMBER();
        }

        private void textBox_DanhSachDen_TextChanged(object sender, EventArgs e)
        {
            if (textBox_DanhSachDen.Text == "")
            {
                dataGridView_DanhSachDen.DataSource = Ham.tv.GETBLACKLIST(Ham.maxLate);
            }
            else
            {
                //dataGridView_DanhSachDen.DataSource = Ham.tv.GETBLACKLIST(Ham.maxLate)
                //.Where(x => x.MaDocGia == textBox_DanhSachDen.Text
                //|| x.HoVaTen == textBox_DanhSachDen.Text)
                //.ToList();
            }
        }

        private void textBox_DocGiaMuonNhieu_TextChanged(object sender, EventArgs e)
        {
            if (textBox_DocGiaMuonNhieu.Text == "")
            {
                dataGridView_TopDocGia.DataSource = Ham.tv.GETTOPMEMBER();
            }
            else
            {
                //dataGridView_DanhSachDen.DataSource = Ham.tv.GETBLACKLIST(Ham.maxLate)
                //.Where(x => x.MaDocGia == textBox_DanhSachDen.Text
                //|| x.HoVaTen == textBox_DanhSachDen.Text)
                //.ToList();
            }
        }

        private void button_DocGiaMuonNhieu_Click(object sender, EventArgs e)
        {
            BaoCaoDocGiaMuonNhieu bc = new BaoCaoDocGiaMuonNhieu();
            bc.ShowDialog();
        }
    }
}
