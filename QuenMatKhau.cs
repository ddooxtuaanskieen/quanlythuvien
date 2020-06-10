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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void button_DoiMatKhau_Click(object sender, EventArgs e)
        {
            if (textBox_MaNhanVien.Text == ""
                || textBox_SoCMT.Text == ""
                || textBox_Email.Text == ""
                || textBox_MatKhauMoi.Text == ""
                || textBox_NhapLaiMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng điền các thông tin cần thiết.");
            }
            else
            {
                NHANVIEN nv = Ham.tv.NHANVIENs
                    .Where(x => x.MaNhanVien == textBox_MaNhanVien.Text && x.SoCMT == textBox_SoCMT.Text && x.Email == textBox_Email.Text).SingleOrDefault();
                if (nv == null)
                {
                    MessageBox.Show("Thông tin sai. Vui lòng kiểm tra lại.");
                }
                else
                {
                    if (textBox_MatKhauMoi.Text != textBox_NhapLaiMatKhau.Text)
                    {
                        MessageBox.Show("Thất bại. Kiểm tra dữ liệu mật khẩu mới.");
                    }
                    else
                    {
                        nv.MatKhau = Ham.getMD5(textBox_MatKhauMoi.Text);
                        Ham.tv.SaveChanges();
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                }
            }
        }
    }
}
