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
        public static string maPhieuMuon = null;
        public MuonTra()
        {
            InitializeComponent();
        }

        private void Muon_Load(object sender, EventArgs e)
        {
            dataGridView_Sach.DataSource = Ham.tv.GETAVAILABLEBOOKS();
            dataGridView_DocGia.DataSource = Ham.tv.GETAVALIDMEMBER(Ham.maxBookHold);
            dataGridView_MuonTra.DataSource = Ham.tv.MUONTRAs.ToList();
            dateTimePicker_NgayHenTra.Value = DateTime.Now.AddDays(1);
        }

        private void textBox_TimKiemSach_TextChanged(object sender, EventArgs e)
        {
            if (textBox_TimKiemSach.Text == "")
            {
                dataGridView_Sach.DataSource = Ham.tv.GETAVAILABLEBOOKS();
            }
            else
            {
                dataGridView_Sach.DataSource = Ham.tv.GETAVAILABLEBOOKS()
                    .Where(x => x.MaSach.ToLower().IndexOf(textBox_TimKiemSach.Text.ToLower()) != -1
                    || x.TieuDe.ToLower().IndexOf(textBox_TimKiemSach.Text.ToLower()) != -1)
                    .ToList();
            }
        }

        private void textBox_TimKiemDocGia_TextChanged(object sender, EventArgs e)
        {
            if (textBox_TimKiemDocGia.Text == "")
            {
                dataGridView_DocGia.DataSource = Ham.tv.GETAVALIDMEMBER(Ham.maxBookHold);
            }
            else
            {
                dataGridView_DocGia.DataSource = Ham.tv.GETAVALIDMEMBER(Ham.maxBookHold)
                    .Where(x => x.MaDocGia.ToLower().IndexOf(textBox_TimKiemDocGia.Text.ToLower()) != -1
                    || x.HoVaTen.ToLower().IndexOf(textBox_TimKiemDocGia.Text.ToLower()) != -1)
                    .ToList();
            }
        }

        private void textBox_TimKiemMuonTra_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_MuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maPhieuMuon = dataGridView_MuonTra.CurrentRow.Cells[0].Value.ToString();
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
            Ham.deleteData("MT", maPhieuMuon);
            //Cho nay load lai datagrid
            maPhieuMuon = null;
        }

        private void button_TraSach_Click(object sender, EventArgs e)
        {
            if(maPhieuMuon == null || maPhieuMuon == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn");
            }
            else
            {
                MUONTRA mt = Ham.tv.MUONTRAs.Where(x => x.MaMuonTra == maPhieuMuon).SingleOrDefault();
                mt.NgayTra = DateTime.Now;
                mt.NguoiNhanTra = Ham.currentUser;
                MessageBox.Show(Ham.getFine(maPhieuMuon).ToString());
            }
        }
    }


}
