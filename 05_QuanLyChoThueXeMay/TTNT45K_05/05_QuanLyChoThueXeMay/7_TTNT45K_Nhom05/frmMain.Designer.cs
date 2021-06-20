namespace _7_TTNT45K_Nhom05
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
            this.quanlyKHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyxeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlydonthueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanlyKHToolStripMenuItem,
            this.quanlyxeToolStripMenuItem,
            this.quanlydonthueToolStripMenuItem,
            this.thongkeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(986, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanlyKHToolStripMenuItem
            // 
            this.quanlyKHToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlyKHToolStripMenuItem.Name = "quanlyKHToolStripMenuItem";
            this.quanlyKHToolStripMenuItem.Size = new System.Drawing.Size(138, 21);
            this.quanlyKHToolStripMenuItem.Text = "Quản Lý Khách hàng";
            this.quanlyKHToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // quanlyxeToolStripMenuItem
            // 
            this.quanlyxeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlyxeToolStripMenuItem.Name = "quanlyxeToolStripMenuItem";
            this.quanlyxeToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.quanlyxeToolStripMenuItem.Text = "Quản Lý Xe";
            this.quanlyxeToolStripMenuItem.Click += new System.EventHandler(this.quảnLyToolStripMenuItem_Click);
            // 
            // quanlydonthueToolStripMenuItem
            // 
            this.quanlydonthueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlydonthueToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.quanlydonthueToolStripMenuItem.Name = "quanlydonthueToolStripMenuItem";
            this.quanlydonthueToolStripMenuItem.Size = new System.Drawing.Size(126, 21);
            this.quanlydonthueToolStripMenuItem.Text = "Quản Lý Đơn Thuê";
            this.quanlydonthueToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐơnThuêToolStripMenuItem_Click);
            // 
            // thongkeToolStripMenuItem
            // 
            this.thongkeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongkeToolStripMenuItem.Name = "thongkeToolStripMenuItem";
            this.thongkeToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.thongkeToolStripMenuItem.Text = "Thống kê";
            this.thongkeToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 593);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ DỊCH VỤ THUÊ XE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanlyKHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlyxeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlydonthueToolStripMenuItem;
    }
}

