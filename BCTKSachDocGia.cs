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
    public partial class BCTKSachDocGia : Form
    {
        public BCTKSachDocGia()
        {
            InitializeComponent();
        }

        private void BCTKSachDocGia_Load(object sender, EventArgs e)
        {
            dataGridView_DanhSachDen.DataSource = Ham.tv.GETBLACKLIST(Ham.maxLate);
            dataGridView_TopDocGia.DataSource = Ham.tv.GETTOPMEMBER();
            dataGridView_SachKhaDung.DataSource = Ham.tv.GETAVAILABLEBOOKS()
                .Select(x=>new {x.MaSach, x.TieuDe })
                .ToList();
            dataGridView_TopSach.DataSource = Ham.tv.GETTOPBOOK();
        }

        private void button_DocGiaMuonNhieu_Click_1(object sender, EventArgs e)
        {
            BaoCaoDocGiaMuonNhieu bc = new BaoCaoDocGiaMuonNhieu();
            bc.ShowDialog();
        }

        private void button_SachMuonNhieu_Click(object sender, EventArgs e)
        {
            BaoCaoSachMuonNhieu bc = new BaoCaoSachMuonNhieu();
            bc.ShowDialog();
        }

        private void textBox_DanhSachDen_TextChanged(object sender, EventArgs e)
        {
            if(textBox_DanhSachDen.Text == "")
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


        private void textBox_SachHienTai_TextChanged(object sender, EventArgs e)
        {
            if (textBox_SachHienTai.Text == "")
            {
                dataGridView_SachKhaDung.DataSource = Ham.tv.GETAVAILABLEBOOKS()
                    ;
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
                dataGridView_TopSach.DataSource = Ham.tv.GETTOPBOOK()
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

        
    }
}
