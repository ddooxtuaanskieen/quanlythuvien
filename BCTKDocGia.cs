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
    public partial class BCTKDocGia : Form
    {
        public BCTKDocGia()
        {
            InitializeComponent();
        }

        private void BCTKDocGia_Load(object sender, EventArgs e)
        {
            dataGridView_DanhSachDen.DataSource = Ham.tv.GETBLACKLIST(Ham.maxLate);
            dataGridView_TopDocGia.DataSource = Ham.tv.GETTOPMEMBER();
        }
    }
}
