using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _7_TTNT45K_Nhom05
{
    public partial class frmQuanLyDonThue : Form
    {
        string sCon = "Data Source=NGBATRUONG;Initial Catalog=ChoThueXe;Integrated Security=True";

        public frmQuanLyDonThue()
        {
            InitializeComponent();
        }

        private void frmQuanLyDonThue_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }    
            catch(Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB! ", "Thông báo");
            }
            string sQuery = "select*from THUE";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "THUE");
            dataGridView1.DataSource = ds.Tables["THUE"];
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiemDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
