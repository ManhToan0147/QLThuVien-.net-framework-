namespace QL_ThuVien.Main_UC.QLTacGia
{
    partial class UC_TacGiaSach
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTacGiaSach = new System.Windows.Forms.Label();
            this.cboTruong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboMode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbDauSach = new System.Windows.Forms.GroupBox();
            this.grbTacGia = new System.Windows.Forms.GroupBox();
            this.grbDSTG = new System.Windows.Forms.GroupBox();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnChuyen = new Guna.UI2.WinForms.Guna2Button();
            this.dgvDauSach = new System.Windows.Forms.DataGridView();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.dgvDSTG = new System.Windows.Forms.DataGridView();
            this.MaDauSach2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTacGia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.MaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDauSach.SuspendLayout();
            this.grbTacGia.SuspendLayout();
            this.grbDSTG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTacGiaSach
            // 
            this.lblTacGiaSach.AutoSize = true;
            this.lblTacGiaSach.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGiaSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            this.lblTacGiaSach.Location = new System.Drawing.Point(684, 41);
            this.lblTacGiaSach.Name = "lblTacGiaSach";
            this.lblTacGiaSach.Size = new System.Drawing.Size(666, 74);
            this.lblTacGiaSach.TabIndex = 7;
            this.lblTacGiaSach.Text = "QUẢN LÝ TÁC GIẢ SÁCH";
            // 
            // cboTruong
            // 
            this.cboTruong.BackColor = System.Drawing.Color.Transparent;
            this.cboTruong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTruong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTruong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTruong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTruong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTruong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTruong.ItemHeight = 67;
            this.cboTruong.Items.AddRange(new object[] {
            "Đầu sách",
            "Tác giả"});
            this.cboTruong.Location = new System.Drawing.Point(126, 201);
            this.cboTruong.Name = "cboTruong";
            this.cboTruong.Size = new System.Drawing.Size(219, 73);
            this.cboTruong.TabIndex = 9;
            this.cboTruong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboTruong.SelectedIndexChanged += new System.EventHandler(this.cboTruong_SelectedIndexChanged);
            // 
            // cboMode
            // 
            this.cboMode.BackColor = System.Drawing.Color.Transparent;
            this.cboMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMode.ItemHeight = 67;
            this.cboMode.Items.AddRange(new object[] {
            "Xem",
            "Sửa"});
            this.cboMode.Location = new System.Drawing.Point(1692, 201);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(219, 73);
            this.cboMode.TabIndex = 10;
            this.cboMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboMode.SelectedIndexChanged += new System.EventHandler(this.cboMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên trường";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1696, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Chế độ";
            // 
            // grbDauSach
            // 
            this.grbDauSach.Controls.Add(this.dgvDauSach);
            this.grbDauSach.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDauSach.ForeColor = System.Drawing.Color.Black;
            this.grbDauSach.Location = new System.Drawing.Point(126, 335);
            this.grbDauSach.Name = "grbDauSach";
            this.grbDauSach.Size = new System.Drawing.Size(639, 751);
            this.grbDauSach.TabIndex = 13;
            this.grbDauSach.TabStop = false;
            this.grbDauSach.Text = "Đầu sách";
            // 
            // grbTacGia
            // 
            this.grbTacGia.Controls.Add(this.dgvTacGia);
            this.grbTacGia.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTacGia.ForeColor = System.Drawing.Color.Black;
            this.grbTacGia.Location = new System.Drawing.Point(789, 335);
            this.grbTacGia.Name = "grbTacGia";
            this.grbTacGia.Size = new System.Drawing.Size(572, 751);
            this.grbTacGia.TabIndex = 14;
            this.grbTacGia.TabStop = false;
            this.grbTacGia.Text = "Tác giả";
            // 
            // grbDSTG
            // 
            this.grbDSTG.Controls.Add(this.dgvDSTG);
            this.grbDSTG.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDSTG.ForeColor = System.Drawing.Color.Black;
            this.grbDSTG.Location = new System.Drawing.Point(1481, 335);
            this.grbDSTG.Name = "grbDSTG";
            this.grbDSTG.Size = new System.Drawing.Size(430, 751);
            this.grbDSTG.TabIndex = 15;
            this.grbDSTG.TabStop = false;
            this.grbDSTG.Text = "Đầu sách - Tác giả";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderThickness = 2;
            this.btnXoa.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnXoa.Location = new System.Drawing.Point(1481, 1130);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(430, 79);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChuyen.BorderColor = System.Drawing.Color.Transparent;
            this.btnChuyen.BorderThickness = 2;
            this.btnChuyen.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnChuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnChuyen.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyen.ForeColor = System.Drawing.Color.White;
            this.btnChuyen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnChuyen.HoverState.FillColor = System.Drawing.Color.White;
            this.btnChuyen.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnChuyen.Location = new System.Drawing.Point(1367, 667);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(108, 57);
            this.btnChuyen.TabIndex = 17;
            this.btnChuyen.Text = ">>";
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // dgvDauSach
            // 
            this.dgvDauSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDauSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDauSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDauSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDauSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDauSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDauSach.ColumnHeadersHeight = 50;
            this.dgvDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach,
            this.TenDauSach});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDauSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDauSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDauSach.EnableHeadersVisualStyles = false;
            this.dgvDauSach.GridColor = System.Drawing.Color.Black;
            this.dgvDauSach.Location = new System.Drawing.Point(3, 34);
            this.dgvDauSach.Name = "dgvDauSach";
            this.dgvDauSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDauSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDauSach.RowHeadersWidth = 72;
            this.dgvDauSach.RowTemplate.Height = 50;
            this.dgvDauSach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDauSach.Size = new System.Drawing.Size(633, 714);
            this.dgvDauSach.TabIndex = 3;
            this.dgvDauSach.SelectionChanged += new System.EventHandler(this.dgvDauSach_SelectionChanged);
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTacGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTacGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTacGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTacGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTacGia.ColumnHeadersHeight = 50;
            this.dgvTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTG,
            this.TenTG});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTacGia.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTacGia.EnableHeadersVisualStyles = false;
            this.dgvTacGia.GridColor = System.Drawing.Color.Black;
            this.dgvTacGia.Location = new System.Drawing.Point(3, 34);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTacGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTacGia.RowHeadersWidth = 72;
            this.dgvTacGia.RowTemplate.Height = 50;
            this.dgvTacGia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTacGia.Size = new System.Drawing.Size(566, 714);
            this.dgvTacGia.TabIndex = 3;
            this.dgvTacGia.SelectionChanged += new System.EventHandler(this.dgvTacGia_SelectionChanged);
            // 
            // dgvDSTG
            // 
            this.dgvDSTG.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDSTG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDSTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSTG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDSTG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDSTG.ColumnHeadersHeight = 50;
            this.dgvDSTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach2,
            this.MaTacGia2});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSTG.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDSTG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTG.EnableHeadersVisualStyles = false;
            this.dgvDSTG.GridColor = System.Drawing.Color.Black;
            this.dgvDSTG.Location = new System.Drawing.Point(3, 34);
            this.dgvDSTG.Name = "dgvDSTG";
            this.dgvDSTG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSTG.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDSTG.RowHeadersWidth = 72;
            this.dgvDSTG.RowTemplate.Height = 50;
            this.dgvDSTG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDSTG.Size = new System.Drawing.Size(424, 714);
            this.dgvDSTG.TabIndex = 3;
            // 
            // MaDauSach2
            // 
            this.MaDauSach2.DataPropertyName = "MaDauSach";
            this.MaDauSach2.HeaderText = "Mã đầu sách";
            this.MaDauSach2.MinimumWidth = 9;
            this.MaDauSach2.Name = "MaDauSach2";
            // 
            // MaTacGia2
            // 
            this.MaTacGia2.DataPropertyName = "MaTG";
            this.MaTacGia2.HeaderText = "Mã tác giả";
            this.MaTacGia2.MinimumWidth = 9;
            this.MaTacGia2.Name = "MaTacGia2";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::QL_ThuVien.Properties.Resources.search;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtSearch.Location = new System.Drawing.Point(354, 201);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Nhập để tìm kiếm tên tác giả";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(1329, 73);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // MaTG
            // 
            this.MaTG.DataPropertyName = "MaTG";
            this.MaTG.HeaderText = "Mã tác giả";
            this.MaTG.MinimumWidth = 9;
            this.MaTG.Name = "MaTG";
            this.MaTG.Width = 150;
            // 
            // TenTG
            // 
            this.TenTG.DataPropertyName = "TenTG";
            this.TenTG.HeaderText = "Tên tác giả";
            this.TenTG.MinimumWidth = 9;
            this.TenTG.Name = "TenTG";
            this.TenTG.Width = 344;
            // 
            // MaDauSach
            // 
            this.MaDauSach.DataPropertyName = "MaDauSach";
            this.MaDauSach.HeaderText = "Mã đầu sách";
            this.MaDauSach.MinimumWidth = 9;
            this.MaDauSach.Name = "MaDauSach";
            this.MaDauSach.Width = 150;
            // 
            // TenDauSach
            // 
            this.TenDauSach.DataPropertyName = "TenDauSach";
            this.TenDauSach.HeaderText = "Tên đầu sách";
            this.TenDauSach.MinimumWidth = 9;
            this.TenDauSach.Name = "TenDauSach";
            this.TenDauSach.Width = 385;
            // 
            // UC_TacGiaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grbDSTG);
            this.Controls.Add(this.grbTacGia);
            this.Controls.Add(this.grbDauSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMode);
            this.Controls.Add(this.cboTruong);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTacGiaSach);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_TacGiaSach";
            this.Size = new System.Drawing.Size(2035, 1277);
            this.Load += new System.EventHandler(this.UC_TacGiaSach_Load);
            this.grbDauSach.ResumeLayout(false);
            this.grbTacGia.ResumeLayout(false);
            this.grbDSTG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTacGiaSach;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cboTruong;
        private Guna.UI2.WinForms.Guna2ComboBox cboMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbDauSach;
        private System.Windows.Forms.GroupBox grbTacGia;
        private System.Windows.Forms.GroupBox grbDSTG;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnChuyen;
        private System.Windows.Forms.DataGridView dgvDauSach;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private System.Windows.Forms.DataGridView dgvDSTG;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTacGia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTG;
    }
}
