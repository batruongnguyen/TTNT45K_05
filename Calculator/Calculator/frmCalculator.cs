using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 + dSo2;
            txtKQ.Text = dKQ.ToString();


        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 - dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 * dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 / dSo2;
            txtKQ.Text = dKQ.ToString();
        }
    }
}
