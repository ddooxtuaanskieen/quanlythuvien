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
    public partial class Sach : Form
    {
        public string maSach = null;
        public Sach()
        {
            InitializeComponent();
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            dataGridView_Sach.DataSource = Ham.getData("S", textBox_TimKiem.Text);
        }

        private void dataGridView_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox_Sach.Image = null;
            maSach = dataGridView_Sach.CurrentRow.Cells[0].Value.ToString();
            SACH s = Ham.tv.SACHes.Where(x => x.MaSach == maSach).SingleOrDefault();
            textBox_TieuDe.Text = s.TieuDe;
            textBox_NhaXuatBan.Text = s.NhaXuatBan;
            textBox_NgonNgu.Text = s.NgonNgu;
            textBox_MoTa.Text = s.Mota;
            textBox_Gia.Text = s.Gia.ToString();
            textBox_Anh.Text = s.Anh;
            pictureBox_Sach.ImageLocation = s.Anh == null ?
                Ham.defaultNVImage :
                s.Anh;
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView_Sach.DataSource = Ham.getData("S", textBox_TimKiem.Text);
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            maSach = null;
            textBox_TieuDe.Text
                = textBox_NhaXuatBan.Text
                = textBox_NgonNgu.Text
                = textBox_MoTa.Text
                = textBox_Gia.Text
                = textBox_Anh.Text
                = "";
            pictureBox_Sach.InitialImage = null;
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            if (textBox_TieuDe.Text == ""
                || textBox_Gia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần thiết.");
            }
            else
            {
                SACH s = new SACH();
                s.MaSach = Ham.generateID("NV");
                s.TieuDe = textBox_TieuDe.Text;
                s.NhaXuatBan = textBox_NhaXuatBan.Text;
                s.NgonNgu = textBox_NgonNgu.Text;
                s.Mota = textBox_MoTa.Text;
                s.Gia = Int32.TryParse(textBox_Gia.Text, out int y) ? Int32.Parse(textBox_Gia.Text) : 0; s.NguoiLap = Ham.currentUser;
                s.Anh = textBox_Anh.Text;
                s.NgayLap = DateTime.Now;
                Ham.tv.SACHes.Add(s);
                Ham.tv.SaveChanges();

                maSach = null;
                textBox_TieuDe.Text
                    = textBox_NhaXuatBan.Text
                    = textBox_NgonNgu.Text
                    = textBox_MoTa.Text
                    = textBox_Gia.Text
                    = textBox_Anh.Text
                    = "";
                pictureBox_Sach.InitialImage = null;
                dataGridView_Sach.DataSource = Ham.getData("S", textBox_TimKiem.Text);
                MessageBox.Show("Thêm đối tượng thành công.");
            }
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            if (maSach == null || maSach == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng cần chỉnh sửa.");
            }
            else
            {
                if (textBox_TieuDe.Text == ""
                    || textBox_Gia.Text == "")
                {
                    MessageBox.Show("Vui lòng điền những thông tin cần thiết.");
                }
                else
                {
                    SACH s = Ham.tv.SACHes.Where(x => x.MaSach == maSach).SingleOrDefault();
                    s.TieuDe = textBox_TieuDe.Text;
                    s.NhaXuatBan = textBox_NhaXuatBan.Text;
                    s.NgonNgu = textBox_NgonNgu.Text;
                    s.Mota = textBox_MoTa.Text;
                    s.Gia = Int32.TryParse(textBox_Gia.Text, out int y) ? Int32.Parse(textBox_Gia.Text) : 0;
                    Ham.tv.SaveChanges();
                    dataGridView_Sach.DataSource = Ham.getData("S", textBox_TimKiem.Text);
                    maSach = null;
                    MessageBox.Show("Chỉnh sửa đối tượng thành công.");
                }
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            Ham.deleteData("S", maSach);
            dataGridView_Sach.DataSource = Ham.getData("S", textBox_TimKiem.Text);
            maSach = null;
        }

        private void textBox_Anh_TextChanged(object sender, EventArgs e)
        {
            pictureBox_Sach.ImageLocation = textBox_Anh.Text;
        }
    }
}
