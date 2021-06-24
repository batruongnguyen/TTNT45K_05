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
        string sThongKe = @"Data Source=DESKTOP-BL56DFD\SQLEXPRESS01;Initial Catalog=ChoThueXe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            
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

            string sQuery = "select XE.MaX, TinhTrang,NgayThue,NgayTra from THUE right join XE on THUE.MaX=XE.MaX";
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
            cbTinhTrangXe.Text = dataGridView1.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayThue"].Value);
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayTra"].Value);
            //Xử lý trường hợp nếu Ngày thuê ngày trả không có dữ liệu thì sao

            /* Code ngày chọn mục không có ngày thuê, ngày trả
             if(dateTimePicker1.Value!=null)
            {
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayThue"].Value);

            }
            else
            {
                dateTimePicker1.Value = new DateTime(06, 20, 2021);
                MessageBox.Show("Thông báo", "Xe này chưa được thuê!");
            }
            if (dateTimePicker2.Value != null)
            {
                dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayTra"].Value);
            }
            else
            {
                dateTimePicker2.Value = new DateTime(06, 20, 2021);
                MessageBox.Show("Thông báo", "Xe này chưa được thuê!");
            }*/

            cbTinhTrangXe.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            txtDoanhThu.Enabled = false;

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

            
            string sQuery = "select XE.MaX, TinhTrang,NgayThue,NgayTra from THUE right join XE on THUE.MaX=XE.MaX where TinhTrang like '%" + cbTinhTrangXe.Text + "%' ";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, ThongKe);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ThongKe");
            dataGridView1.DataSource = ds.Tables["ThongKe"];

            ThongKe.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemLai_Click(object sender, EventArgs e)
        {
            cbTinhTrangXe.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            txtDoanhThu.Text = "";
            cbTinhTrangXe.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            txtDoanhThu.Enabled = true;
        }



        public DateTime datetime1 { get; set; }

        public DateTime datetime2 { get; set; }

        private void txtDoanhThu_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
