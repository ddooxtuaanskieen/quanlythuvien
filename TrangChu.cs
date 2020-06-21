using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN.Models;

namespace QUANLYTHUVIEN
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            label_TongNhanVien.Text = Ham.tv.NHANVIENs.Where(x => x.NgayXoa == null).Count().ToString();
            label_TongSoSach.Text = Ham.tv.SACHes.Where(x => x.NgayXoa == null).Count().ToString();
            label_SachHienTai.Text = Ham.tv.GETAVAILABLEBOOKS().Count().ToString();
            label_TongDocGia.Text = Ham.tv.DOCGIAs.Where(x => x.NgayXoa == null).Count().ToString();
            label_TongPhieuMuon.Text = Ham.tv.MUONTRAs.Count().ToString() 
                + @"/"
                + Ham.tv.MUONTRAs.Where(x=> x.NgayTra != null).Count().ToString();
            var allDangKy = Ham.tv.THEDOCGIALATE(600);
            foreach (var item in allDangKy)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView_TheHetHan.Rows[0].Clone();
                row.Cells[0].Value = item.MaDocGia;
                row.Cells[1].Value = Ham.tv.DOCGIAs.Where(x => x.MaDocGia == item.MaDocGia).SingleOrDefault().HoVaTen;
                row.Cells[2].Value = item.HAN <= 0 ? "Hết hạn" : "Còn " + item.HAN + " ngày";
                dataGridView_TheHetHan.Rows.Add(row);
            }

            IEnumerable<MUONTRA> allMuonTra = Ham.tv.MUONTRAs.ToList();
            foreach (var item in allMuonTra)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView_MuonHetHan.Rows[0].Clone();
                row.Cells[0].Value = item.MaMuonTra;
                row.Cells[1].Value = Ham.tv.DOCGIAs.Where(x => x.MaDocGia == item.MaDocGia).SingleOrDefault().HoVaTen;
                if(item.NgayHenTra <= DateTime.Now)
                {
                    row.Cells[2].Value = "Còn " + (int)(DateTime.Now - item.NgayHenTra).TotalDays + " ngày";
                }
                else
                {
                    row.Cells[2].Value = "Hết hạn";
                }
                dataGridView_MuonHetHan.Rows.Add(row);
            }
        }

        private void panel_Quy_Click(object sender, EventArgs e)
        {
            QuanLyQuy qlq = new QuanLyQuy();
            qlq.ShowDialog();
        }

        private void pictureBox_Quy_Click(object sender, EventArgs e)
        {
            QuanLyQuy qlq = new QuanLyQuy();
            qlq.ShowDialog();
        }
    }
}
