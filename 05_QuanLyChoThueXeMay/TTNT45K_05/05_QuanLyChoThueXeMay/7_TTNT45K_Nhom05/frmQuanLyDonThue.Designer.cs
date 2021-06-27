namespace _7_TTNT45K_Nhom05
{
    partial class frmQuanLyDonThue
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDonThue));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGioThue = new System.Windows.Forms.TextBox();
            this.cbDamBao = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayThue = new System.Windows.Forms.DateTimePicker();
            this.btnThemDT = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.Mahd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dambao1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaythue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giothue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giotra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgthue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThanhTien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbMaXe = new System.Windows.Forms.ComboBox();
            this.cbbSDT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbLoaiXe = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtGioTra = new System.Windows.Forms.TextBox();
            this.txtDonGiaThue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CHO THUÊ XE";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.cbDamBao);
            this.groupBox2.Controls.Add(this.txtGioThue);
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtNgayThue);
            this.groupBox2.Controls.Add(this.btnThemDT);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(50, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 283);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đăng ký Thuê";
            // 
            // txtGioThue
            // 
            this.txtGioThue.Location = new System.Drawing.Point(168, 106);
            this.txtGioThue.Name = "txtGioThue";
            this.txtGioThue.Size = new System.Drawing.Size(265, 31);
            this.txtGioThue.TabIndex = 4;
            // 
            // cbDamBao
            // 
            this.cbDamBao.FormattingEnabled = true;
            this.cbDamBao.Items.AddRange(new object[] {
            "CMT",
            "The can cuoc",
            "Tien mat"});
            this.cbDamBao.Location = new System.Drawing.Point(168, 172);
            this.cbDamBao.Name = "cbDamBao";
            this.cbDamBao.Size = new System.Drawing.Size(265, 33);
            this.cbDamBao.TabIndex = 5;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShow.BackgroundImage = global::_7_TTNT45K_Nhom05.Properties.Resources.stop_2;
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnShow.Location = new System.Drawing.Point(256, 226);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(83, 38);
            this.btnShow.TabIndex = 7;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnHuyDT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(35, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Đảm bảo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(35, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giờ thuê";
            // 
            // dtNgayThue
            // 
            this.dtNgayThue.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtNgayThue.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtNgayThue.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtNgayThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayThue.Location = new System.Drawing.Point(168, 43);
            this.dtNgayThue.Name = "dtNgayThue";
            this.dtNgayThue.Size = new System.Drawing.Size(265, 29);
            this.dtNgayThue.TabIndex = 3;
            // 
            // btnThemDT
            // 
            this.btnThemDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThemDT.BackgroundImage = global::_7_TTNT45K_Nhom05.Properties.Resources.add_folder;
            this.btnThemDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemDT.Location = new System.Drawing.Point(147, 226);
            this.btnThemDT.Name = "btnThemDT";
            this.btnThemDT.Size = new System.Drawing.Size(80, 37);
            this.btnThemDT.TabIndex = 6;
            this.btnThemDT.UseVisualStyleBackColor = false;
            this.btnThemDT.Click += new System.EventHandler(this.btnThemDT_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(35, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ngày thuê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(501, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã xe";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtThanhTien.Location = new System.Drawing.Point(156, 233);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(144, 31);
            this.txtThanhTien.TabIndex = 9;
            this.txtThanhTien.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.dgvHD);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(50, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(943, 296);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đơn thuê";
            // 
            // dgvHD
            // 
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahd1,
            this.sdt,
            this.Max1,
            this.dambao1,
            this.Ngaythue1,
            this.Giothue1,
            this.ngaytra1,
            this.Giotra1,
            this.tgthue1,
            this.thanhtien1});
            this.dgvHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvHD.Location = new System.Drawing.Point(19, 42);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.Size = new System.Drawing.Size(909, 248);
            this.dgvHD.TabIndex = 0;
            this.dgvHD.TabStop = false;
            this.dgvHD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvHD_MouseClick);
            // 
            // Mahd1
            // 
            this.Mahd1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Mahd1.DataPropertyName = "MaHD";
            this.Mahd1.HeaderText = "Mã HĐ";
            this.Mahd1.Name = "Mahd1";
            this.Mahd1.Width = 103;
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sdt.DataPropertyName = "SoDT";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.Width = 106;
            // 
            // Max1
            // 
            this.Max1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Max1.DataPropertyName = "MaX";
            this.Max1.HeaderText = "Mã Xe";
            this.Max1.Name = "Max1";
            this.Max1.Width = 68;
            // 
            // dambao1
            // 
            this.dambao1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dambao1.DataPropertyName = "DamBao";
            this.dambao1.HeaderText = "Đảm bảo";
            this.dambao1.Name = "dambao1";
            // 
            // Ngaythue1
            // 
            this.Ngaythue1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngaythue1.DataPropertyName = "NgayThue";
            this.Ngaythue1.HeaderText = "Ngày thuê";
            this.Ngaythue1.Name = "Ngaythue1";
            // 
            // Giothue1
            // 
            this.Giothue1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Giothue1.DataPropertyName = "GioThue";
            this.Giothue1.HeaderText = "Giờ thuê";
            this.Giothue1.Name = "Giothue1";
            this.Giothue1.Width = 108;
            // 
            // ngaytra1
            // 
            this.ngaytra1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaytra1.DataPropertyName = "NgayTra";
            this.ngaytra1.HeaderText = "Ngày trả";
            this.ngaytra1.Name = "ngaytra1";
            // 
            // Giotra1
            // 
            this.Giotra1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Giotra1.DataPropertyName = "GioTra";
            this.Giotra1.HeaderText = "Giờ trả";
            this.Giotra1.Name = "Giotra1";
            this.Giotra1.Width = 70;
            // 
            // tgthue1
            // 
            this.tgthue1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tgthue1.DataPropertyName = "ThoiGianThue";
            this.tgthue1.HeaderText = "Thời gian thuê";
            this.tgthue1.Name = "tgthue1";
            // 
            // thanhtien1
            // 
            this.thanhtien1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhtien1.DataPropertyName = "ThanhTien";
            this.thanhtien1.HeaderText = "Thành tiền";
            this.thanhtien1.Name = "thanhtien1";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThanhToan.BackgroundImage = global::_7_TTNT45K_Nhom05.Properties.Resources.payment;
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThanhToan.Location = new System.Drawing.Point(305, 226);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(124, 38);
            this.btnThanhToan.TabIndex = 11;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThanhTien
            // 
            this.btnThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThanhTien.Location = new System.Drawing.Point(37, 226);
            this.btnThanhTien.Name = "btnThanhTien";
            this.btnThanhTien.Size = new System.Drawing.Size(113, 38);
            this.btnThanhTien.TabIndex = 10;
            this.btnThanhTien.Text = "Thành tiền";
            this.btnThanhTien.UseVisualStyleBackColor = false;
            this.btnThanhTien.Click += new System.EventHandler(this.btnThanhTien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.txtMahoadon);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbbMaXe);
            this.groupBox1.Controls.Add(this.cbbSDT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbLoaiXe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(50, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtMahoadon.Location = new System.Drawing.Point(200, 83);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.Size = new System.Drawing.Size(233, 31);
            this.txtMahoadon.TabIndex = 20;
            this.txtMahoadon.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(41, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Mã hóa đơn";
            // 
            // cbbMaXe
            // 
            this.cbbMaXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbbMaXe.FormattingEnabled = true;
            this.cbbMaXe.Location = new System.Drawing.Point(601, 75);
            this.cbbMaXe.Name = "cbbMaXe";
            this.cbbMaXe.Size = new System.Drawing.Size(252, 33);
            this.cbbMaXe.TabIndex = 2;
            this.cbbMaXe.SelectedIndexChanged += new System.EventHandler(this.cbbMaXe_SelectedIndexChanged);
            // 
            // cbbSDT
            // 
            this.cbbSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbbSDT.FormattingEnabled = true;
            this.cbbSDT.Location = new System.Drawing.Point(200, 33);
            this.cbbSDT.Name = "cbbSDT";
            this.cbbSDT.Size = new System.Drawing.Size(233, 33);
            this.cbbSDT.TabIndex = 0;
            this.cbbSDT.SelectedIndexChanged += new System.EventHandler(this.cbbSDT_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(41, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(503, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Loại xe";
            // 
            // cbbLoaiXe
            // 
            this.cbbLoaiXe.BackColor = System.Drawing.SystemColors.Window;
            this.cbbLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbbLoaiXe.FormattingEnabled = true;
            this.cbbLoaiXe.Location = new System.Drawing.Point(601, 30);
            this.cbbLoaiXe.Name = "cbbLoaiXe";
            this.cbbLoaiXe.Size = new System.Drawing.Size(254, 33);
            this.cbbLoaiXe.TabIndex = 1;
            this.cbbLoaiXe.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiXe_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox4.Controls.Add(this.txtGioTra);
            this.groupBox4.Controls.Add(this.btnThanhToan);
            this.groupBox4.Controls.Add(this.btnThanhTien);
            this.groupBox4.Controls.Add(this.txtDonGiaThue);
            this.groupBox4.Controls.Add(this.txtThanhTien);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.dtNgayTra);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(520, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 283);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trả xe";
            // 
            // txtGioTra
            // 
            this.txtGioTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtGioTra.Location = new System.Drawing.Point(172, 103);
            this.txtGioTra.Name = "txtGioTra";
            this.txtGioTra.Size = new System.Drawing.Size(258, 31);
            this.txtGioTra.TabIndex = 9;
            // 
            // txtDonGiaThue
            // 
            this.txtDonGiaThue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDonGiaThue.Location = new System.Drawing.Point(172, 166);
            this.txtDonGiaThue.Name = "txtDonGiaThue";
            this.txtDonGiaThue.Size = new System.Drawing.Size(258, 31);
            this.txtDonGiaThue.TabIndex = 9;
            this.txtDonGiaThue.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(32, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Đơn giá thuê";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(34, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Giờ trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(34, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ngày trả";
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtNgayTra.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtNgayTra.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayTra.Location = new System.Drawing.Point(171, 35);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(259, 29);
            this.dtNgayTra.TabIndex = 8;
            // 
            // frmQuanLyDonThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = global::_7_TTNT45K_Nhom05.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 785);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmQuanLyDonThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Đơn thuê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtNgayThue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnThemDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.ComboBox cbDamBao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDonGiaThue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.Button btnThanhTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbMaXe;
        private System.Windows.Forms.ComboBox cbbSDT;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbLoaiXe;
        private System.Windows.Forms.TextBox txtGioThue;
        private System.Windows.Forms.TextBox txtGioTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dambao1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaythue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giothue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giotra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgthue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien1;
    }
}