using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThuVien.Main_UC.QLMuonTra
{
    public partial class UC_PhieuTra : UserControl
    {
        public UC_PhieuTra()
        {
            InitializeComponent();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            var f = new frmTraSach();
            f.ShowDialog();
        }
    }
}
