using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_TTNT45K_Nhom05
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void quảnLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyXe khach = new frmQuanLyXe();
            khach.MdiParent = this;
            khach.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKH khach = new frmQuanLyKH();
            khach.MdiParent = this;
            khach.Show();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe khach = new frmThongKe();
            khach.MdiParent = this;
            khach.Show();
        }

        private void quảnLýĐơnThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDonThue khach = new frmQuanLyDonThue();
            khach.MdiParent = this;
            khach.Show();
        }

        private void choThuêXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thanhToánToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
