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
    public partial class frmThongKe : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string sThongKe = "Data Source=NGBATRUONG;Initial Catalog=ChoThueXe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from XE";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbTinhTrangXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            SqlConnection ThongKe = new SqlConnection(sThongKe);
            try
            {
                ThongKe.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }

            string sQuery = "select SoDT, TinhTrang,NgayThue,NgayTra from THUE inner join XE on THUE.MaX=XE.MaX";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, ThongKe);
            
            DataSet ds = new DataSet();

            adapter.Fill(ds, "XE");

            dataGridView1.DataSource = ds.Tables["XE"];

            ThongKe.Close();
            


        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btnThongKe_Click(object sender, EventArgs e)
        {    
            SqlConnection ThongKe = new SqlConnection(sThongKe);
            try
            {
                ThongKe.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sTimKiem = "Select SoDT, TinhTrang, NgayThue, NgayTra from XE inner join THUE on XE.MaX=THUE.MaX";
            SqlCommand cmd = new SqlCommand(sTimKiem, ThongKe);
            cmd.Parameters.AddWithValue("SoDT", cbTinhTrangXe.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;



        }

        
    }
}
