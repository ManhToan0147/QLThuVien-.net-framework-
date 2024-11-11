﻿using System;
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
    public partial class UC_QLSach_Ribbon : UserControl
    {
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public UC_QLSach_Ribbon()
        {
            InitializeComponent();
        }

        private void UC_QLSach_Ribbon_Load(object sender, EventArgs e)
        {
            btnChiTietSach.Checked = true;
        }
    }
}
