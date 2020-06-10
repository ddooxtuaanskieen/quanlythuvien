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
        public string MaNhanVien = "";
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dataGridView_NhanVien.DataSource = Ham.getAllData("NV");
        }

        private void dataGridView_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaNhanVien = dataGridView_NhanVien.CurrentRow.Cells[0].Value.ToString();
            textBox_HoVaTen.Text = dataGridView_NhanVien.CurrentRow.Cells[1].Value.ToString();
            textBox_SoCMT.Text = dataGridView_NhanVien.CurrentRow.Cells[2].Value.ToString();
            //dateTimePicker_NgaySinh.Value = (DateTime)dataGridView.CurrentRow.Cells[0].Value;
            textBox_DiaChi.Text = dataGridView_NhanVien.CurrentRow.Cells[4].Value.ToString();
            textBox_SoDienThoai.Text = dataGridView_NhanVien.CurrentRow.Cells[5].Value.ToString();
            textBox_Email.Text = dataGridView_NhanVien.CurrentRow.Cells[6].Value.ToString();
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (textBox_TimKiem.Text == "")
            {
                dataGridView_NhanVien.DataSource = Ham.getAllData("NV");
            }
            else
            {
                dataGridView_NhanVien.DataSource = Ham.getData("NV", textBox_TimKiem.Text);
            }
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            MaNhanVien = "";
            textBox_HoVaTen.Text
                = textBox_SoCMT.Text
                = textBox_DiaChi.Text
                = textBox_SoDienThoai.Text
                = textBox_Email.Text
                = textBox_MatKhau.Text
                = "";
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            if (textBox_HoVaTen.Text == "" || textBox_SoCMT.Text == "" || textBox_DiaChi.Text == "" || textBox_SoDienThoai.Text == "" || textBox_Email.Text == "")
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
                nv.MatKhau = textBox_MatKhau.Text == "" ? Ham.getMD5("00000000") : Ham.getMD5(textBox_MatKhau.Text);
                nv.NguoiLap = Ham.currentUser;
                nv.NgayLap = DateTime.Now;
                Ham.tv.NHANVIENs.Add(nv);
                Ham.tv.SaveChanges();

                MaNhanVien = "";
                textBox_HoVaTen.Text
                    = textBox_SoCMT.Text
                    = textBox_DiaChi.Text
                    = textBox_SoDienThoai.Text
                    = textBox_Email.Text
                    = textBox_MatKhau.Text
                    = "";

                if (textBox_TimKiem.Text == "")
                {
                    dataGridView_NhanVien.DataSource = Ham.getAllData("NV");
                }
                else
                {
                    dataGridView_NhanVien.DataSource = Ham.getData("NV", textBox_TimKiem.Text);
                }
            }
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            if (MaNhanVien == "")
            {
                MessageBox.Show("Vui lòng chọn Nhân viên cần chỉnh sửa.");
            }
            else
            {
                if (textBox_HoVaTen.Text == "" || textBox_SoCMT.Text == "" || textBox_DiaChi.Text == "" || textBox_SoDienThoai.Text == "" || textBox_Email.Text == "")
                {
                    MessageBox.Show("Vui lòng điền những thông tin cần thiết.");
                }
                else
                {
                    NHANVIEN nv = Ham.tv.NHANVIENs.Where(x => x.MaNhanVien == MaNhanVien).SingleOrDefault();
                    nv.HoVaTen = textBox_HoVaTen.Text;
                    nv.SoCMT = textBox_SoCMT.Text;
                    nv.NgaySinh = dateTimePicker_NgaySinh.Value;
                    nv.DiaChi = textBox_DiaChi.Text;
                    nv.SoDienThoai = textBox_SoDienThoai.Text;
                    nv.Email = textBox_Email.Text;
                    nv.MatKhau = textBox_MatKhau.Text == "" ? nv.MatKhau : Ham.getMD5(textBox_MatKhau.Text);
                    Ham.tv.SaveChanges();
                }
                if (textBox_TimKiem.Text == "")
                {
                    dataGridView_NhanVien.DataSource = Ham.getAllData("NV");
                }
                else
                {
                    dataGridView_NhanVien.DataSource = Ham.getData("NV", textBox_TimKiem.Text);
                }
                MaNhanVien = "";
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            Ham.deleteData("NV", MaNhanVien);
            if (textBox_TimKiem.Text == "")
            {
                dataGridView_NhanVien.DataSource = Ham.getAllData("NV");
            }
            else
            {
                dataGridView_NhanVien.DataSource = Ham.getData("NV", textBox_TimKiem.Text);
            }
            MaNhanVien = "";
        }
    }
}
