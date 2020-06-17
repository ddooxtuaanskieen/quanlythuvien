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
    public partial class BaoCaoDocGiaMuonNhieu : Form
    {
        public BaoCaoDocGiaMuonNhieu()
        {
            InitializeComponent();
        }

        private void BaoCaoDocGiaMuonNhieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYTHUVIENDataSetDocGiaMuonNhieu.GETTOPMEMBER' table. You can move, or remove it, as needed.
            this.GETTOPMEMBERTableAdapter.Fill(this.QUANLYTHUVIENDataSetDocGiaMuonNhieu.GETTOPMEMBER);

            this.reportViewer1.RefreshReport();
        }
    }
}
