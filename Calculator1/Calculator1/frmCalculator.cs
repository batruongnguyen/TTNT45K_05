using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbSo1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);

            String sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);

            decimal dKQ = dSo1 + dSo2;

            txtKQ.Text = dKQ.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            String sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);

            String sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);

            decimal dKQ = dSo1 - dSo2;

            txtKQ.Text = dKQ.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            String sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);

            String sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);

            decimal dKQ = dSo1 * dSo2;

            txtKQ.Text = dKQ.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            String sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);

            String sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);

            decimal dKQ = dSo1 / dSo2;

            txtKQ.Text = dKQ.ToString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
