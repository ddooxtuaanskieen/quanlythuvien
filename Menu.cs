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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public void hideSubMenu()
        {
            panel_LeftSubMenu.Visible = false;
            button_LeftSubMenu1.Visible = false;
            button_LeftSubMenu2.Visible = false;
            button_LeftSubMenu3.Visible = false;
            button_LeftSubMenu4.Visible = false;
        }
        
        private void Menu_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            NHANVIEN nv = Ham.tv.NHANVIENs.Where(x => x.MaNhanVien == Ham.currentUser).SingleOrDefault();
            if(nv == null)
            {
                label_MaNhanVien.Text = "Khách";
                label_HoVaTen.Text = "Khách";
            }
            else
            {
                label_MaNhanVien.Text = nv.MaNhanVien;
                label_HoVaTen.Text = nv.HoVaTen;
                pictureBox_Anh.ImageLocation = nv.Anh == null? Ham.defaultNVImage : nv.Anh;
            }
            Ham.openFormInPanel(new TrangChu(), panel_Content);

            
            if(DateTime.Now.Day == Ham.lastDaySendReminder.Day && DateTime.Now.Month == Ham.lastDaySendReminder.Month)
            {

            }
            else
            {
                IEnumerable<MUONTRA> allMuon = Ham.tv.MUONTRAs.ToList();
                foreach (var item in allMuon)
                {
                    if ((int)(DateTime.Now - (DateTime)item.NgayHenTra).TotalDays == 7 || (int)(DateTime.Now - (DateTime)item.NgayHenTra).TotalDays == 3 || (int)(DateTime.Now - (DateTime)item.NgayHenTra).TotalDays == 1)
                    {
                        Ham.sendEmailRemindMuon(item.MaMuonTra);
                    }
                }
                var allLastestTDG = Ham.tv.THEDOCGIAs
                .GroupBy(x => x.MaDocGia)
                .Select(g => new { MaDocGia = g.Key, HanMoi = g.Max(x => x.HanMoi) })
                .ToList();
                foreach (var item in allLastestTDG)
                {
                    if ((int)(DateTime.Now - (DateTime)item.HanMoi).TotalDays == 7 || (int)(DateTime.Now - (DateTime)item.HanMoi).TotalDays == 3 || (int)(DateTime.Now - (DateTime)item.HanMoi).TotalDays == 1)
                    {
                        Ham.sendEmailRemindTheDocGia(item.MaDocGia);
                    }
                }
                Ham.lastDaySendReminder = DateTime.Now;
            }
        }
        
        private void button_TrangChu_Click(object sender, EventArgs e)
        {
            Ham.openFormInPanel(new TrangChu(), panel_Content);
        }
        private void button_NhanVien_Click(object sender, EventArgs e)
        {
            if (panel_LeftSubMenu.Visible == false)
            {
                panel_LeftSubMenu.Visible = true;
                button_LeftSubMenu1.Text = "Tra cứu nhân viên";
                button_LeftSubMenu1.Visible = true;
                button_LeftSubMenu1.Click += button_NhanVien_Click;
                button_LeftSubMenu2.Text = "Quản lý nhân viên";
                button_LeftSubMenu2.Visible = true;
                button_LeftSubMenu3.Visible = false;
                button_LeftSubMenu4.Visible = false;
            }
            else
            {
                hideSubMenu();
            }
        }

        private void button_MuonTra_Click(object sender, EventArgs e)
        {
            if (panel_LeftSubMenu.Visible == false)
            {
                panel_LeftSubMenu.Visible = true;
                button_LeftSubMenu1.Text = "Tra cứu mượn/trả";
                button_LeftSubMenu1.Visible = true;
                button_LeftSubMenu2.Text = "Đăng ký mượn";
                button_LeftSubMenu2.Visible = true;
                button_LeftSubMenu3.Text = "Đăng ký trả";
                button_LeftSubMenu3.Visible = true;
                button_LeftSubMenu4.Visible = false;
            }
            else
            {
                hideSubMenu();
            }
        }

        private void button_DocGia_Click(object sender, EventArgs e)
        {
            if (panel_LeftSubMenu.Visible == false)
            {
                panel_LeftSubMenu.Visible = true;
                button_LeftSubMenu1.Text = "Tra cứu độc giả";
                button_LeftSubMenu1.Visible = true;
                button_LeftSubMenu2.Text = "Quản lý độc giả";
                button_LeftSubMenu2.Visible = true;
                button_LeftSubMenu3.Text = "Gia hạn thẻ độc giả";
                button_LeftSubMenu3.Visible = true;
                button_LeftSubMenu3.Text = "Thống kê độc giả";
                button_LeftSubMenu3.Visible = true;
            }
            else
            {
                hideSubMenu();
            }
        }

        private void button_Sach_Click(object sender, EventArgs e)
        {
            if (panel_LeftSubMenu.Visible == false)
            {
                panel_LeftSubMenu.Visible = true;
                button_LeftSubMenu1.Text = "Tra cứu sách";
                button_LeftSubMenu1.Visible = true;
                button_LeftSubMenu2.Text = "Quản lý sách";
                button_LeftSubMenu2.Visible = true;
                button_LeftSubMenu3.Text = "Thống kê sách";
                button_LeftSubMenu3.Visible = true;
                button_LeftSubMenu4.Visible = false;
            }
            else
            {
                hideSubMenu();
            }
        }

        private void button_LeftSubMenu1_Click(object sender, EventArgs e)
        {
            if (button_LeftSubMenu1.Text == "Tra cứu nhân viên") Ham.openFormInPanel(new NhanVien(), panel_Content);
            if (button_LeftSubMenu1.Text == "Tra cứu độc giả") Ham.openFormInPanel(new DocGia(), panel_Content);
            if (button_LeftSubMenu1.Text == "Tra cứu sách") Ham.openFormInPanel(new Sach(), panel_Content);
            if (button_LeftSubMenu1.Text == "Tra cứu mượn/trả") Ham.openFormInPanel(new MuonTra(), panel_Content);
            hideSubMenu();
        }

        private void button_LeftSubMenu2_Click(object sender, EventArgs e)
        {
            if (button_LeftSubMenu2.Text == "Quản lý nhân viên") Ham.openFormInPanel(new NhanVien(), panel_Content);
            if (button_LeftSubMenu2.Text == "Quản lý độc giả") Ham.openFormInPanel(new DocGia(), panel_Content);
            if (button_LeftSubMenu2.Text == "Quản lý sách") Ham.openFormInPanel(new Sach(), panel_Content);
            if (button_LeftSubMenu2.Text == "Đăng ký mượn") Ham.openFormInPanel(new MuonTra(), panel_Content);
            hideSubMenu();
        }

        private void button_LeftSubMenu3_Click(object sender, EventArgs e)
        {
            if (button_LeftSubMenu3.Text == "Thống kê độc giả") Ham.openFormInPanel(new DocGiaBCTK(), panel_Content);
            if (button_LeftSubMenu3.Text == "Thống kê sách") Ham.openFormInPanel(new SachBCTK(), panel_Content); 
            if (button_LeftSubMenu3.Text == "Đăng ký trả") Ham.openFormInPanel(new MuonTra(), panel_Content);
            hideSubMenu();
        }

        private void button_LeftSubMenu4_Click(object sender, EventArgs e)
        {
            //if (button_LeftSubMenu4.Text == "Gia hạn thẻ độc giả") Ham.openFormInPanel(new DocGiaBCTK(), panel_Content);
            hideSubMenu();
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
                this.Hide();
                DangNhap dn = new DangNhap();
                dn.ShowDialog();
                Ham.currentUser = null;
        }
    }
}
