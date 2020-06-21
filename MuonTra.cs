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
                string memberName = Ham.tv.DOCGIAs.Where(x => x.MaDocGia == textBox_MaDocGia.Text).SingleOrDefault().HoVaTen;
                string bookName = Ham.tv.SACHes.Where(x => x.MaSach == textBox_MaSach.Text).SingleOrDefault().TieuDe;
                double costRent = Ham.percentPricePerRent * Ham.tv.SACHes.Where(x => x.MaSach == textBox_MaSach.Text).SingleOrDefault().Gia;
                string rentConfirm = "Độc giả: " + memberName + "\n"
                    + "Sách: " + bookName + "\n"
                    + "Giá đặt cọc: " + costRent.ToString() + "\n"
                    + "Xác nhận mượn?";
                if (MessageBox.Show(rentConfirm, "Thêm mượn", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
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
                    MessageBox.Show("Thêm lượt mượn thành công");
                }
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
                string memberName = Ham.tv.DOCGIAs.Where(x => x.MaDocGia == mt.MaDocGia).SingleOrDefault().HoVaTen;
                string bookName = Ham.tv.SACHes.Where(x => x.MaSach == mt.MaSach).SingleOrDefault().TieuDe;
                var coc = Ham.tv.SACHes.Where(x => x.MaSach == mt.MaSach).SingleOrDefault().Gia * 0.8;
                var costRent = Ham.getCostRent(maMuonTra);
                var costFine = Ham.getFine(maMuonTra);
                var action = (double)(coc - costRent - costFine) > 0 ? "Hoàn trả độc giả: " : "Thu thêm độc giả: ";
                string backConfirm = "Độc giả: " + memberName + "\n"
                    + "Sách: " + bookName + "\n"
                    + "Trả đặt cọc: " + coc.ToString() + "\n"
                    + "Phí mượn: " + costRent.ToString() + "\n"
                    + "Phí trễ: " + costFine.ToString() + "\n"
                    + action + (Math.Abs((double)(-coc + costRent + costFine))).ToString() + "\n"
                    + "Xác nhận trả?";
                if (MessageBox.Show(backConfirm, "Thêm trả", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    mt.NgayTra = DateTime.Now;
                    mt.NguoiNhanTra = Ham.currentUser;
                    mt.Phi = costRent;
                    mt.Phat = (int)costFine;
                    Ham.tv.SaveChanges();
                    MessageBox.Show("Trả sách thành công");
                    dataGridView_MuonTra.DataSource = Ham.getData("MT", textBox_TimKiemMuonTra.Text);
                }
            }
        }
    }


}
