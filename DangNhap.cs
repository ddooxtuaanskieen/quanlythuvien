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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button_QuenMatKhau_Click(object sender, EventArgs e)
        {
            QuenMatKhau qmk = new QuenMatKhau();
            qmk.ShowDialog();
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = Ham.tv.NHANVIENs
                .Where(x => x.MaNhanVien == textBox_MaNhanVien.Text)
                .SingleOrDefault();
            if (nv == null)
            {
                MessageBox.Show("Đăng nhập thất bại. Thông tin đăng nhập không đúng.");
            }
            else
            {
                if (Ham.getMD5(textBox_MatKhau.Text) != nv.MatKhau)
                {
                    MessageBox.Show("Đăng nhập thất bại. Thông tin đăng nhập không đúng.");
                }
                else
                {
                    Ham.currentUser = nv.MaNhanVien;
                    MessageBox.Show("Đăng nhập thành công.");
                    Menu m = new Menu();
                    m.ShowDialog();
                }
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            
        }
    }
}
