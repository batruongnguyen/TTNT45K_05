using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueXeMay_TTNT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void xeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sửaThôngTinXeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXe xe = new frmXe();
            xe.MdiParent = this;
            xe.Show();
        }

        private void thôngTinKHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void KHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKH khach = new frmKH();
            khach.MdiParent = this;
            khach.Show();
        }
    }
}
