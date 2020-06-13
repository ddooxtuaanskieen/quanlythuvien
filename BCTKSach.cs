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
    public partial class BCTKSach : Form
    {
        public BCTKSach()
        {
            InitializeComponent();
        }

        private void BCTKSach_Load(object sender, EventArgs e)
        {
            dataGridView_SachKhaDung.DataSource = Ham.tv.GETAVAILABLEBOOKS();
            dataGridView_TopSach.DataSource = Ham.tv.GETTOPBOOK();
        }
    }
}
