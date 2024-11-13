using QL_ThuVien.Main_UC.QLMuonTra;
using QL_ThuVien.Main_UC.QLSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThuVien.Ribbon
{
    public partial class UC_QLMuonTra_Ribbon : UserControl
    {
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public UC_QLMuonTra_Ribbon()
        {
            InitializeComponent();
        }

        private void UC_QLMuonTra_Ribbon_Load(object sender, EventArgs e)
        {
            btnThuThu.Checked = true;
            var uc = new UC_QLThuThu();
            addUserControl(uc);

        }

        private void btnThuThu_Click(object sender, EventArgs e)
        {
            var uc = new UC_QLThuThu();
            addUserControl(uc);
        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            
        }
    }
}
