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
    public partial class UC_PhieuMuon : UserControl
    {
        public UC_PhieuMuon()
        {
            InitializeComponent();
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            var f = new frmNhapSach();
            f.ShowDialog();
        }
    }
}
