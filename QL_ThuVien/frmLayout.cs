using QL_ThuVien.Main_UC.CaiDat;
using QL_ThuVien.Main_UC.QLDocGia;
using QL_ThuVien.Main_UC.TrangChu;
using QL_ThuVien.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThuVien
{
    public partial class frmLayout : Form
    {
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public frmLayout()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            staThoiGian.Text = System.DateTime.Now.ToString();
        }

        private void frmLayout_Load(object sender, EventArgs e)
        {
            btnHome.Checked = true;
            var uc = new UC_TrangChu();
            addUserControl(uc);
        }

        private void btnSignIn_Out_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất khỏi hệ thống không", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
                var f = new frmSignIn();
                f.ShowDialog();
            }
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            var uc = new UC_QLSach_Ribbon();
            addUserControl(uc);
        }

        private void btnQLTacGia_Click(object sender, EventArgs e)
        {
            var uc = new UC_QLTacGia_Ribbon();
            addUserControl(uc);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var uc = new UC_TrangChu();
            addUserControl(uc); 
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            var uc = new UC_SaoLuu_PhucHoi();
            addUserControl(uc);
        }

        private void btnQLDocGia_Click(object sender, EventArgs e)
        {
            var uc = new UC_QLDocGia();
            addUserControl(uc);
        }

        private void btnQLMuonTra_Click(object sender, EventArgs e)
        {
            var uc = new UC_QLMuonTra_Ribbon();
            addUserControl(uc);
        }
    }
}
