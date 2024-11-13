namespace QL_ThuVien.Main_UC.QLDocGia
{
    partial class UC_QLDocGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblQLDocGia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTruong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.grbTTDG = new System.Windows.Forms.GroupBox();
            this.btnXoaAnh = new Guna.UI2.WinForms.Guna2Button();
            this.dateNgayHan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateNgayCap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgheNghiep = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaTheMuon = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.MaTheMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.NgheNghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCapThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHanThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaoMoi = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbTTDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLDocGia
            // 
            this.lblQLDocGia.AutoSize = true;
            this.lblQLDocGia.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLDocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            this.lblQLDocGia.Location = new System.Drawing.Point(759, 33);
            this.lblQLDocGia.Name = "lblQLDocGia";
            this.lblQLDocGia.Size = new System.Drawing.Size(517, 74);
            this.lblQLDocGia.TabIndex = 6;
            this.lblQLDocGia.Text = "QUẢN LÝ ĐỘC GIẢ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên trường";
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
            "Độc giả",
            "Mã thẻ mượn"});
            this.cboTruong.Location = new System.Drawing.Point(115, 143);
            this.cboTruong.Name = "cboTruong";
            this.cboTruong.Size = new System.Drawing.Size(219, 73);
            this.cboTruong.TabIndex = 13;
            this.cboTruong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboTruong.SelectedIndexChanged += new System.EventHandler(this.cboTruong_SelectedIndexChanged);
            // 
            // grbTTDG
            // 
            this.grbTTDG.Controls.Add(this.btnXoaAnh);
            this.grbTTDG.Controls.Add(this.dateNgayHan);
            this.grbTTDG.Controls.Add(this.label6);
            this.grbTTDG.Controls.Add(this.dateNgayCap);
            this.grbTTDG.Controls.Add(this.label5);
            this.grbTTDG.Controls.Add(this.txtNgheNghiep);
            this.grbTTDG.Controls.Add(this.label4);
            this.grbTTDG.Controls.Add(this.txtHoTen);
            this.grbTTDG.Controls.Add(this.label3);
            this.grbTTDG.Controls.Add(this.txtMaTheMuon);
            this.grbTTDG.Controls.Add(this.label2);
            this.grbTTDG.Controls.Add(this.btnBrowse);
            this.grbTTDG.Controls.Add(this.picAvatar);
            this.grbTTDG.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTDG.Location = new System.Drawing.Point(115, 236);
            this.grbTTDG.Name = "grbTTDG";
            this.grbTTDG.Size = new System.Drawing.Size(1803, 423);
            this.grbTTDG.TabIndex = 15;
            this.grbTTDG.TabStop = false;
            this.grbTTDG.Text = "Thông tin độc giả";
            // 
            // btnXoaAnh
            // 
            this.btnXoaAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaAnh.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaAnh.BorderThickness = 1;
            this.btnXoaAnh.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnXoaAnh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaAnh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaAnh.FillColor = System.Drawing.Color.Red;
            this.btnXoaAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaAnh.ForeColor = System.Drawing.Color.White;
            this.btnXoaAnh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnXoaAnh.HoverState.FillColor = System.Drawing.Color.White;
            this.btnXoaAnh.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnXoaAnh.Location = new System.Drawing.Point(466, 32);
            this.btnXoaAnh.Name = "btnXoaAnh";
            this.btnXoaAnh.Size = new System.Drawing.Size(42, 42);
            this.btnXoaAnh.TabIndex = 20;
            this.btnXoaAnh.Text = "X";
            this.btnXoaAnh.Click += new System.EventHandler(this.btnXoaAnh_Click);
            // 
            // dateNgayHan
            // 
            this.dateNgayHan.BackColor = System.Drawing.Color.White;
            this.dateNgayHan.Checked = true;
            this.dateNgayHan.CustomFormat = "dd/MM/yyyy";
            this.dateNgayHan.FillColor = System.Drawing.Color.White;
            this.dateNgayHan.FocusedColor = System.Drawing.Color.White;
            this.dateNgayHan.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayHan.Location = new System.Drawing.Point(988, 344);
            this.dateNgayHan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayHan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayHan.Name = "dateNgayHan";
            this.dateNgayHan.Size = new System.Drawing.Size(350, 55);
            this.dateNgayHan.TabIndex = 4;
            this.dateNgayHan.Value = new System.DateTime(2024, 11, 12, 13, 17, 6, 634);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(752, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ngày hạn thẻ";
            // 
            // dateNgayCap
            // 
            this.dateNgayCap.BackColor = System.Drawing.Color.White;
            this.dateNgayCap.Checked = true;
            this.dateNgayCap.CustomFormat = "dd/MM/yyyy";
            this.dateNgayCap.FillColor = System.Drawing.Color.White;
            this.dateNgayCap.FocusedColor = System.Drawing.Color.White;
            this.dateNgayCap.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayCap.Location = new System.Drawing.Point(988, 264);
            this.dateNgayCap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayCap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayCap.Name = "dateNgayCap";
            this.dateNgayCap.Size = new System.Drawing.Size(350, 55);
            this.dateNgayCap.TabIndex = 3;
            this.dateNgayCap.Value = new System.DateTime(2024, 11, 12, 13, 17, 6, 634);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(752, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ngày cấp thẻ";
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgheNghiep.DefaultText = "";
            this.txtNgheNghiep.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNgheNghiep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNgheNghiep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgheNghiep.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgheNghiep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgheNghiep.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgheNghiep.ForeColor = System.Drawing.Color.Black;
            this.txtNgheNghiep.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgheNghiep.Location = new System.Drawing.Point(988, 184);
            this.txtNgheNghiep.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.PasswordChar = '\0';
            this.txtNgheNghiep.PlaceholderText = "";
            this.txtNgheNghiep.SelectedText = "";
            this.txtNgheNghiep.Size = new System.Drawing.Size(550, 55);
            this.txtNgheNghiep.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(752, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nghề nghiệp";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(988, 104);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(550, 55);
            this.txtHoTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(752, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Họ tên";
            // 
            // txtMaTheMuon
            // 
            this.txtMaTheMuon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTheMuon.DefaultText = "";
            this.txtMaTheMuon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaTheMuon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaTheMuon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTheMuon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTheMuon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTheMuon.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTheMuon.ForeColor = System.Drawing.Color.Black;
            this.txtMaTheMuon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTheMuon.Location = new System.Drawing.Point(988, 24);
            this.txtMaTheMuon.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMaTheMuon.Name = "txtMaTheMuon";
            this.txtMaTheMuon.PasswordChar = '\0';
            this.txtMaTheMuon.PlaceholderText = "";
            this.txtMaTheMuon.SelectedText = "";
            this.txtMaTheMuon.Size = new System.Drawing.Size(550, 55);
            this.txtMaTheMuon.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(752, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã thẻ mượn";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrowse.BorderColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BorderThickness = 2;
            this.btnBrowse.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnBrowse.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBrowse.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnBrowse.Location = new System.Drawing.Point(265, 368);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(243, 53);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Image = global::QL_ThuVien.Properties.Resources.avatar_default;
            this.picAvatar.Location = new System.Drawing.Point(265, 32);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(243, 324);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.dgvDocGia);
            this.panelContainer.Location = new System.Drawing.Point(115, 681);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1803, 558);
            this.panelContainer.TabIndex = 16;
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AllowUserToAddRows = false;
            this.dgvDocGia.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDocGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDocGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDocGia.ColumnHeadersHeight = 50;
            this.dgvDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTheMuon,
            this.HoTen,
            this.HinhAnh,
            this.NgheNghiep,
            this.NgayCapThe,
            this.NgayHanThe});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocGia.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocGia.EnableHeadersVisualStyles = false;
            this.dgvDocGia.GridColor = System.Drawing.Color.Black;
            this.dgvDocGia.Location = new System.Drawing.Point(0, 0);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDocGia.RowHeadersWidth = 72;
            this.dgvDocGia.RowTemplate.Height = 100;
            this.dgvDocGia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDocGia.Size = new System.Drawing.Size(1803, 558);
            this.dgvDocGia.TabIndex = 3;
            this.dgvDocGia.SelectionChanged += new System.EventHandler(this.dgvDocGia_SelectionChanged);
            // 
            // MaTheMuon
            // 
            this.MaTheMuon.DataPropertyName = "MaTheMuon";
            this.MaTheMuon.HeaderText = "Mã thẻ mượn";
            this.MaTheMuon.MinimumWidth = 9;
            this.MaTheMuon.Name = "MaTheMuon";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 9;
            this.HoTen.Name = "HoTen";
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình ảnh";
            this.HinhAnh.MinimumWidth = 9;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HinhAnh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NgheNghiep
            // 
            this.NgheNghiep.DataPropertyName = "NgheNghiep";
            this.NgheNghiep.HeaderText = "Nghề nghiệp";
            this.NgheNghiep.MinimumWidth = 9;
            this.NgheNghiep.Name = "NgheNghiep";
            // 
            // NgayCapThe
            // 
            this.NgayCapThe.DataPropertyName = "NgayCapThe";
            dataGridViewCellStyle9.Format = "dd/MM/yyyy";
            dataGridViewCellStyle9.NullValue = null;
            this.NgayCapThe.DefaultCellStyle = dataGridViewCellStyle9;
            this.NgayCapThe.HeaderText = "Ngày cấp thẻ";
            this.NgayCapThe.MinimumWidth = 9;
            this.NgayCapThe.Name = "NgayCapThe";
            // 
            // NgayHanThe
            // 
            this.NgayHanThe.DataPropertyName = "NgayHanThe";
            dataGridViewCellStyle10.Format = "dd/MM/yyyy";
            dataGridViewCellStyle10.NullValue = null;
            this.NgayHanThe.DefaultCellStyle = dataGridViewCellStyle10;
            this.NgayHanThe.HeaderText = "Ngày hạn thẻ";
            this.NgayHanThe.MinimumWidth = 9;
            this.NgayHanThe.Name = "NgayHanThe";
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
            this.btnXoa.Location = new System.Drawing.Point(1045, 1269);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(263, 79);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BorderColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderThickness = 2;
            this.btnSua.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnSua.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSua.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnSua.Location = new System.Drawing.Point(1363, 1269);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(263, 79);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BorderColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderThickness = 2;
            this.btnThem.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnThem.HoverState.FillColor = System.Drawing.Color.White;
            this.btnThem.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnThem.Location = new System.Drawing.Point(727, 1269);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(263, 79);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTaoMoi.BorderColor = System.Drawing.Color.Transparent;
            this.btnTaoMoi.BorderThickness = 2;
            this.btnTaoMoi.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTaoMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaoMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaoMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnTaoMoi.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.ForeColor = System.Drawing.Color.White;
            this.btnTaoMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnTaoMoi.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTaoMoi.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnTaoMoi.Location = new System.Drawing.Point(409, 1269);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(263, 79);
            this.btnTaoMoi.TabIndex = 20;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(343, 143);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Nhập tên độc giả để tìm kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(1576, 74);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // UC_QLDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.grbTTDG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTruong);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblQLDocGia);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_QLDocGia";
            this.Size = new System.Drawing.Size(2035, 1379);
            this.Load += new System.EventHandler(this.UC_QLDocGia_Load);
            this.grbTTDG.ResumeLayout(false);
            this.grbTTDG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLDocGia;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cboTruong;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.GroupBox grbTTDG;
        private System.Windows.Forms.PictureBox picAvatar;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgayCap;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtNgheNghiep;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTheMuon;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgayHan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnTaoMoi;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private Guna.UI2.WinForms.Guna2Button btnXoaAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgheNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCapThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHanThe;
    }
}
