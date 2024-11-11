﻿using QL_ThuVien.Ribbon;
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
        }

        private void btnSignIn_Out_Click(object sender, EventArgs e)
        {
            var f = new frmSignIn();
            f.ShowDialog();
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
    }
}
