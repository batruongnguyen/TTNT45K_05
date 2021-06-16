namespace QuanLyThueXeMay_TTNT
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.KHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DonThueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KHToolStripMenuItem,
            this.xeToolStripMenuItem,
            this.thanhToánToolStripMenuItem,
            this.DonThueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // KHToolStripMenuItem
            // 
            this.KHToolStripMenuItem.Name = "KHToolStripMenuItem";
            this.KHToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.KHToolStripMenuItem.Text = "Quản Lý Khách Hàng";
            this.KHToolStripMenuItem.Click += new System.EventHandler(this.KHToolStripMenuItem_Click);
            // 
            // xeToolStripMenuItem
            // 
            this.xeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmToolStripMenuItem,
            this.thêmToolStripMenuItem,
            this.sửaThôngTinXeToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.xeToolStripMenuItem.Name = "xeToolStripMenuItem";
            this.xeToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.xeToolStripMenuItem.Text = "Quản Lý Xe ";
            this.xeToolStripMenuItem.Click += new System.EventHandler(this.xeToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thêmToolStripMenuItem.Text = "Thêm mới";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sửaThôngTinXeToolStripMenuItem
            // 
            this.sửaThôngTinXeToolStripMenuItem.Name = "sửaThôngTinXeToolStripMenuItem";
            this.sửaThôngTinXeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sửaThôngTinXeToolStripMenuItem.Text = "Chỉnh sửa";
            this.sửaThôngTinXeToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinXeToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xóaToolStripMenuItem.Text = "Xóa ";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            // 
            // DonThueToolStripMenuItem
            // 
            this.DonThueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớiToolStripMenuItem});
            this.DonThueToolStripMenuItem.Name = "DonThueToolStripMenuItem";
            this.DonThueToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.DonThueToolStripMenuItem.Text = "Quản Lý Đơn Thuê ";
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thêmMớiToolStripMenuItem.Text = "Thêm mới";
            this.thêmMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 560);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DonThueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;
    }
}