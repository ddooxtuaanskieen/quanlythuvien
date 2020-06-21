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
    public partial class QuanLyQuy : Form
    {
        public QuanLyQuy()
        {
            InitializeComponent();
        }
        private void getAllBienDong()
        {
            IEnumerable<THEDOCGIA> allTheDocGia = Ham.tv.THEDOCGIAs.ToList();
            foreach (var item in allTheDocGia)
            {
                //Quỹ biến động do: Thẻ độc giả (Tham gia/Gia hạn), Cọc mượn sách, Trả cọc, Thu phí mượn, Thu phí trễ
                DataGridViewRow row = (DataGridViewRow)dataGridView_Quy.Rows[0].Clone();
                row.Cells[0].Value = item.MaDocGia;
                row.Cells[1].Value = item.NgayGiaHan;
                row.Cells[2].Value = Ham.joinFare;
                row.Cells[3].Value = "Phí gia hạn thẻ độc giả";
                dataGridView_Quy.Rows.Add(row);
            }

            IEnumerable<MUONTRA> allMuon = Ham.tv.MUONTRAs.ToList();
            foreach (var item in allMuon)
            {
                DataGridViewRow rowcoc = (DataGridViewRow)dataGridView_Quy.Rows[0].Clone();
                rowcoc.Cells[0].Value = item.MaMuonTra;
                rowcoc.Cells[1].Value = item.NgayMuon;
                rowcoc.Cells[2].Value = (Ham.tv.SACHes.Where(x => x.MaSach == item.MaSach).SingleOrDefault().Gia * Ham.percentPricePerRent).ToString();
                rowcoc.Cells[3].Value = "Tiền cọc mượn sách";
                dataGridView_Quy.Rows.Add(rowcoc);
                if (item.NgayTra != null)
                {
                    DataGridViewRow rowtra = (DataGridViewRow)dataGridView_Quy.Rows[0].Clone();
                    rowtra.Cells[0].Value = item.MaMuonTra;
                    rowtra.Cells[1].Value = item.NgayTra;
                    rowtra.Cells[2].Value = (Ham.tv.SACHes.Where(x => x.MaSach == item.MaSach).SingleOrDefault().Gia * Ham.percentPricePerRent * -1).ToString();
                    rowtra.Cells[3].Value = "Trả tiền cọc mượn sách";
                    dataGridView_Quy.Rows.Add(rowtra);

                    DataGridViewRow rowphi = (DataGridViewRow)dataGridView_Quy.Rows[0].Clone();
                    rowphi.Cells[0].Value = item.MaMuonTra;
                    rowphi.Cells[1].Value = item.NgayTra;
                    rowphi.Cells[2].Value = item.Phi;
                    rowphi.Cells[3].Value = "Trả tiền phí mượn sách";
                    dataGridView_Quy.Rows.Add(rowphi);
                    
                    if (item.Phat != 0)
                    {
                        DataGridViewRow rowphat = (DataGridViewRow)dataGridView_Quy.Rows[0].Clone();
                        rowphat.Cells[0].Value = item.MaMuonTra;
                        rowphat.Cells[1].Value = item.NgayTra;
                        rowphat.Cells[2].Value = item.Phat;
                        rowphat.Cells[3].Value = "Trả tiền phí trả muộn";
                        dataGridView_Quy.Rows.Add(rowphat);
                    }
                }
            }
            dataGridView_Quy.Sort(dataGridView_Quy.Columns["Ngay"], ListSortDirection.Ascending);
        }

        private void QuanLyQuy_Load(object sender, EventArgs e)
        {
            dateTimePicker_DenNgay.Value = DateTime.Now;
            getAllBienDong();
            int sum = 0;
            for (int k = 0; k < dataGridView_Quy.Rows.Count; ++k)
            {
                sum += Convert.ToInt32(dataGridView_Quy.Rows[0].Cells[2].Value);
            }
            label_BienDong.Text = sum.ToString();
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            if(dateTimePicker_TuNgay.Value >= dateTimePicker_DenNgay.Value)
            {
                MessageBox.Show("Kiểm tra lại ngày bắt đầu và kết thúc");
                dateTimePicker_TuNgay.Value = new DateTime(2019, 12, 31);
                dateTimePicker_DenNgay.Value = DateTime.Now;
            }
            else
            {
                getAllBienDong();
                foreach (DataGridViewRow row in dataGridView_Quy.Rows)
                {
                    //if ((DateTime)row.Cells[1].Value < dateTimePicker_TuNgay.Value || (DateTime)row.Cells[1].Value > dateTimePicker_DenNgay.Value)
                        dataGridView_Quy.Rows.Remove(row);
                }
            }
        }
    }
}
