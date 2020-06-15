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
    public partial class MuonTra : Form
    {
        public static string maMuonTra = null;
        public MuonTra()
        {
            InitializeComponent();
        }

        private void Muon_Load(object sender, EventArgs e)
        {
            dataGridView_Sach.DataSource = Ham.tv.GETAVAILABLEBOOKS()
                .Select(x => new { x.MaSach, x.TieuDe})
                .ToList();
            dataGridView_DocGia.DataSource = Ham.tv.GETAVALIDMEMBER(Ham.maxBookHold)
                .Select(x => new {x.MaDocGia, x.HoVaTen })
                .ToList();
            dataGridView_MuonTra.DataSource = Ham.getData("MT", textBox_TimKiemMuonTra.Text);
            dateTimePicker_NgayHenTra.Value = DateTime.Now.AddDays(1);
        }

        private void textBox_TimKiemSach_TextChanged(object sender, EventArgs e)
        {
            dataGridView_Sach.DataSource = Ham.tv.GETAVAILABLEBOOKS()
                .Where(x => x.MaSach.ToLower().IndexOf(textBox_TimKiemSach.Text.ToLower()) != -1
                || x.TieuDe.ToLower().IndexOf(textBox_TimKiemSach.Text.ToLower()) != -1)
                .Select(x => new {x.MaSach, x.TieuDe })
                .ToList();
        }

        private void textBox_TimKiemDocGia_TextChanged(object sender, EventArgs e)
        {
            dataGridView_DocGia.DataSource = Ham.tv.GETAVALIDMEMBER(Ham.maxBookHold)
                .Where(x => x.MaDocGia.ToLower().IndexOf(textBox_TimKiemDocGia.Text.ToLower()) != -1
                || x.HoVaTen.ToLower().IndexOf(textBox_TimKiemDocGia.Text.ToLower()) != -1)
                .Select(x => new {x.MaDocGia, x.HoVaTen })
                .ToList();
        }

        private void textBox_TimKiemMuonTra_TextChanged(object sender, EventArgs e)
        {
            dataGridView_MuonTra.DataSource = Ham.getData("MT", textBox_TimKiemMuonTra.Text);
        }

        private void dataGridView_MuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maMuonTra = dataGridView_MuonTra.CurrentRow.Cells[0].Value.ToString();
        }
        private void dataGridView_DocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaDocGia.Text = dataGridView_DocGia.CurrentRow.Cells[0].Value.ToString();
        }
        private void dataGridView_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaSach.Text = dataGridView_Sach.CurrentRow.Cells[0].Value.ToString();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            if (textBox_MaDocGia.Text == "" || textBox_MaSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn độc giả và sách.");
            }
            else
            {
                MUONTRA mt = new MUONTRA();
                mt.MaMuonTra = Ham.generateID("MT");
                mt.MaDocGia = textBox_MaDocGia.Text;
                mt.MaSach = textBox_MaSach.Text;
                mt.NguoiChoMuon = Ham.currentUser;
                mt.NgayMuon = DateTime.Now;
                mt.NgayHenTra = dateTimePicker_NgayHenTra.Value;
                Ham.tv.MUONTRAs.Add(mt);
                Ham.tv.SaveChanges();
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            Ham.deleteData("MT", maMuonTra);
            dataGridView_MuonTra.DataSource = Ham.getData("MT", textBox_TimKiemMuonTra.Text);
            maMuonTra = null;
        }

        private void button_TraSach_Click(object sender, EventArgs e)
        {
            if(maMuonTra == null || maMuonTra == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn");
            }
            else
            {
                MUONTRA mt = Ham.tv.MUONTRAs.Where(x => x.MaMuonTra == maMuonTra).SingleOrDefault();
                mt.NgayTra = DateTime.Now;
                mt.NguoiNhanTra = Ham.currentUser;
                int lateDay = mt.NgayTra > mt.NgayHenTra ? (int)((DateTime)mt.NgayTra - mt.NgayHenTra).TotalDays : 0;
                Ham.tv.SaveChanges();
                dataGridView_MuonTra.DataSource = Ham.getData("MT", textBox_TimKiemMuonTra.Text);
                MessageBox.Show("Số ngày muộn: " + lateDay.ToString() + "\n" + "Tiền phạt: " + Ham.getFine(maMuonTra));
            }
        }
    }


}
