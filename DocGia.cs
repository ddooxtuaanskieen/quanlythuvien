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
    public partial class DocGia : Form
    {
        public string maDocGia = null;
        public void clearDGInput()
        {
            textBox_HoVaTen.Text
                = textBox_SoCMT.Text
                = textBox_DiaChi.Text
                = textBox_SoDienThoai.Text
                = textBox_Email.Text
                = textBox_Anh.Text
                = "";
            pictureBox_DocGia.Image = null;
        }
        public DocGia()
        {
            InitializeComponent();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            dataGridView_Docgia.DataSource = Ham.getData("DG", textBox_TimKiem.Text);
        }

        private void dataGridView_Docgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox_DocGia.Image = null;
            maDocGia = dataGridView_Docgia.CurrentRow.Cells[0].Value.ToString();
            DOCGIA dg = Ham.tv.DOCGIAs.Where(x => x.MaDocGia == maDocGia).SingleOrDefault();
            textBox_HoVaTen.Text = dg.HoVaTen;
            textBox_SoCMT.Text = dg.SoCMT;
            dateTimePicker_NgaySinh.Value = dg.NgaySinh;
            textBox_DiaChi.Text = dg.DiaChi;
            textBox_SoDienThoai.Text = dg.SoDienThoai;
            textBox_Email.Text = dg.Email;
            textBox_Anh.Text = dg.Anh;
            pictureBox_DocGia.ImageLocation = dg.Anh == null ?
                Ham.defaultNVImage :
                dg.Anh;
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView_Docgia.DataSource = Ham.getData("DG", textBox_TimKiem.Text);
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            maDocGia = null;
            clearDGInput();
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            if (textBox_HoVaTen.Text == ""
                || textBox_SoCMT.Text == ""
                || textBox_DiaChi.Text == ""
                || textBox_SoDienThoai.Text == ""
                || textBox_Email.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần thiết.");
            }
            else
            {
                DOCGIA dg = new DOCGIA();
                dg.MaDocGia = Ham.generateID("DG");
                dg.HoVaTen = textBox_HoVaTen.Text;
                dg.SoCMT = textBox_SoCMT.Text;
                dg.NgaySinh = dateTimePicker_NgaySinh.Value;
                dg.DiaChi = textBox_DiaChi.Text;
                dg.SoDienThoai = textBox_SoDienThoai.Text;
                dg.Email = textBox_Email.Text;
                dg.NguoiLap = Ham.currentUser;
                dg.Anh = textBox_Anh.Text;
                dg.NgayLap = DateTime.Now;
                Ham.tv.DOCGIAs.Add(dg);
                Ham.tv.SaveChanges();

                maDocGia = null;
                clearDGInput();
                dataGridView_Docgia.DataSource = Ham.getData("DG", textBox_TimKiem.Text);
                MessageBox.Show("Thêm đối tượng thành công.");
            }
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            if (maDocGia == null || maDocGia == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng cần chỉnh sửa.");
            }
            else
            {
                if (textBox_HoVaTen.Text == ""
                    || textBox_SoCMT.Text == ""
                    || textBox_DiaChi.Text == ""
                    || textBox_SoDienThoai.Text == ""
                    || textBox_Email.Text == "")
                {
                    MessageBox.Show("Vui lòng điền những thông tin cần thiết.");
                }
                else
                {
                    DOCGIA dg = Ham.tv.DOCGIAs.Where(x => x.MaDocGia == maDocGia).SingleOrDefault();
                    dg.HoVaTen = textBox_HoVaTen.Text;
                    dg.SoCMT = textBox_SoCMT.Text;
                    dg.NgaySinh = dateTimePicker_NgaySinh.Value;
                    dg.DiaChi = textBox_DiaChi.Text;
                    dg.SoDienThoai = textBox_SoDienThoai.Text;
                    dg.Email = textBox_Email.Text;
                    Ham.tv.SaveChanges();

                    maDocGia = null;
                    clearDGInput();
                    dataGridView_Docgia.DataSource = Ham.getData("DG", textBox_TimKiem.Text);
                    MessageBox.Show("Chỉnh sửa đối tượng thành công.");
                }
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            Ham.deleteData("DG", maDocGia);

            maDocGia = null;
            clearDGInput();
            dataGridView_Docgia.DataSource = Ham.getData("DG", textBox_TimKiem.Text);
        }

        private void textBox_Anh_TextChanged(object sender, EventArgs e)
        {
            pictureBox_DocGia.ImageLocation = textBox_Anh.Text;
        }
    }
}
