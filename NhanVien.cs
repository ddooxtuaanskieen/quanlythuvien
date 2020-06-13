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
    public partial class NhanVien : Form
    {
        public string maNhanVien = null;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dataGridView_NhanVien.DataSource = Ham.getData("NV", textBox_TimKiem.Text);
        }

        private void dataGridView_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox_NhanVien.Image = null;
            maNhanVien = dataGridView_NhanVien.CurrentRow.Cells[0].Value.ToString();
            NHANVIEN nv = Ham.tv.NHANVIENs.Where(x => x.MaNhanVien == maNhanVien).SingleOrDefault();
            textBox_HoVaTen.Text = nv.HoVaTen;
            textBox_SoCMT.Text = nv.SoCMT;
            dateTimePicker_NgaySinh.Value = nv.NgaySinh;
            textBox_DiaChi.Text = nv.DiaChi;
            textBox_SoDienThoai.Text = nv.SoDienThoai;
            textBox_Email.Text = nv.Email;
            textBox_Anh.Text = nv.Anh;
            pictureBox_NhanVien.ImageLocation = nv.Anh == null ?
                Ham.defaultNVImage :
                nv.Anh;
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView_NhanVien.DataSource = Ham.getData("NV", textBox_TimKiem.Text);
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            maNhanVien = null;
            textBox_HoVaTen.Text
                = textBox_SoCMT.Text
                = textBox_DiaChi.Text
                = textBox_SoDienThoai.Text
                = textBox_Email.Text
                = textBox_MatKhau.Text
                = textBox_Anh.Text
                = "";
            pictureBox_NhanVien.InitialImage = null;
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
                NHANVIEN nv = new NHANVIEN();
                nv.MaNhanVien = Ham.generateID("NV");
                nv.HoVaTen = textBox_HoVaTen.Text;
                nv.SoCMT = textBox_SoCMT.Text;
                nv.NgaySinh = dateTimePicker_NgaySinh.Value;
                nv.DiaChi = textBox_DiaChi.Text;
                nv.SoDienThoai = textBox_SoDienThoai.Text;
                nv.Email = textBox_Email.Text;
                nv.MatKhau = textBox_MatKhau.Text == "" ? Ham.getMD5(Ham.defaultPassword) : Ham.getMD5(textBox_MatKhau.Text);
                nv.NguoiLap = Ham.currentUser;
                nv.Anh = textBox_Anh.Text;
                nv.NgayLap = DateTime.Now;
                Ham.tv.NHANVIENs.Add(nv);
                Ham.tv.SaveChanges();

                maNhanVien = null;
                textBox_HoVaTen.Text
                    = textBox_SoCMT.Text
                    = textBox_DiaChi.Text
                    = textBox_SoDienThoai.Text
                    = textBox_Email.Text
                    = textBox_MatKhau.Text
                    = "";
                dataGridView_NhanVien.DataSource = Ham.getData("NV", textBox_TimKiem.Text);
                MessageBox.Show("Thêm đối tượng thành công.");
            }
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            if (maNhanVien == null || maNhanVien == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần chỉnh sửa.");
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
                    NHANVIEN nv = Ham.tv.NHANVIENs.Where(x => x.MaNhanVien == maNhanVien).SingleOrDefault();
                    nv.HoVaTen = textBox_HoVaTen.Text;
                    nv.SoCMT = textBox_SoCMT.Text;
                    nv.NgaySinh = dateTimePicker_NgaySinh.Value;
                    nv.DiaChi = textBox_DiaChi.Text;
                    nv.SoDienThoai = textBox_SoDienThoai.Text;
                    nv.Email = textBox_Email.Text;
                    nv.MatKhau = textBox_MatKhau.Text == "" ? nv.MatKhau : Ham.getMD5(textBox_MatKhau.Text);
                    Ham.tv.SaveChanges();
                    dataGridView_NhanVien.DataSource = Ham.getData("NV", textBox_TimKiem.Text);
                    maNhanVien = null;
                    MessageBox.Show("Chỉnh sửa đối tượng thành công.");
                }
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            Ham.deleteData("NV", maNhanVien);
            dataGridView_NhanVien.DataSource = Ham.getData("NV", textBox_TimKiem.Text);
            maNhanVien = null;
        }

        private void textBox_Anh_TextChanged(object sender, EventArgs e)
        {
            pictureBox_NhanVien.ImageLocation = textBox_Anh.Text;
        }
    }
}
