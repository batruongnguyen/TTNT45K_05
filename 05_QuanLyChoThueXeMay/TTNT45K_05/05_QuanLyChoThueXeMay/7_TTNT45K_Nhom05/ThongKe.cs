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
        SqlCommand cmd;
        string sThongKe = @"Data Source=NGBATRUONG;Initial Catalog=ChoThueXe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

      
        public frmThongKe()
        {
            InitializeComponent();  
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            SqlConnection ThongKe = new SqlConnection(sThongKe);
            //Dữ liệu load 

            //Load dữ liệu từ database vào combobox mã xe
            cbMaXe.Items.Clear();
            ThongKe.Open();
            cmd = ThongKe.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MaX from XE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cbMaXe.Items.Add(dr["MaX"].ToString());
            }
            ThongKe.Close();
            txtDoanhThu.Enabled = false;
  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string TinhTrangdgv;
            TinhTrangdgv = dataGridView1.CurrentCell.Value.ToString();
            if (TinhTrangdgv == "Dang cho thue" || TinhTrangdgv == "San co" || TinhTrangdgv == "Hong")
            {
                cbTinhTrangXe.Text = dataGridView1.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString();
            }
            cbMaXe.Text = dataGridView1.Rows[e.RowIndex].Cells["MaX"].Value.ToString();
            
            

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
            cbMaXe.Enabled = false;
            cbTinhTrangXe.Enabled = false;

        }
        
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            //Tim Kiem theo tinh trang xe
            if(cbTinhTrangXe.Text =="Dang cho thue")
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

                string sQuery = "select XE.MaX, MoTa, Loai, NgayThue, GioThue from THUE right join XE on THUE.MaX=XE.MaX where TinhTrang='Dang cho thue'";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, ThongKe);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "ThongKe");

                dataGridView1.DataSource = ds.Tables["ThongKe"];
                ThongKe.Close();
            }
            else if (cbTinhTrangXe.Text == "Hong")
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

                string sQuery = "select XE.MaX, MoTa, Loai from XE  where TinhTrang='Hong'";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, ThongKe);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "ThongKe");

                dataGridView1.DataSource = ds.Tables["ThongKe"];
                ThongKe.Close();
            }
            else if (cbTinhTrangXe.Text == "San co")
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

                string sQuery = "select XE.MaX, MoTa, Loai from XE  where TinhTrang='San co'";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, ThongKe);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "ThongKe");

                dataGridView1.DataSource = ds.Tables["ThongKe"];
                ThongKe.Close();
            }
            //Tim kiem theo Ma Xe
            if (cbMaXe.Text != "")
            {
                SqlConnection ThongKe1 = new SqlConnection(sThongKe);
                try
                {
                    ThongKe1.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                }
                

                string sQuery1 = "select XE.MaX,  MoTa, Loai, TinhTrang from THUE right join XE on THUE.MaX=XE.MaX where XE.MaX like'%" + cbMaXe.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sQuery1, ThongKe1);

                DataSet ds1 = new DataSet();

                da.Fill(ds1, "ThongKe");

                dataGridView1.DataSource = ds1.Tables["ThongKe"];
                ThongKe1.Close();
            }
            //Tim kiem theo Ngay Thue
        }


        private void btnXemLai_Click(object sender, EventArgs e)
        {
            cbTinhTrangXe.Text = "";
            txtDoanhThu.Text = "";
            cbMaXe.Text = "";
            cbMaXe.Enabled = true;
            cbTinhTrangXe.Enabled = true;
            dataGridView1.DataSource = null;      
        }

        private void cbMaXe_Click(object sender, EventArgs e)
        {
            cbTinhTrangXe.Enabled = false;
            
        }

        private void cbTinhTrangXe_Click(object sender, EventArgs e)
        {
            cbMaXe.Enabled = false;
        }

       

        

    }
}
