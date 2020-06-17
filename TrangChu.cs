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
        }
    }
}
