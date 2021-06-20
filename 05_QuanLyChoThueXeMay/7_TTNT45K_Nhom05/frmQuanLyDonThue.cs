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
        string sCon = "Data Source=DESKTOP-KMNS09Q\\SQLEXPRESS;Initial Catalog=ChoThueXe;Integrated Security=True";
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
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string Squery = "select*from THUE";
            SqlDataAdapter adapter = new SqlDataAdapter(Squery, con);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sHoTen = txtTen.Text;
            string sMaDT = txtMaDT.Text;
            string sTenXe = txtTenXe.Text;
            string sMaXe = txtMaXe.Text;
            string sNgayThue = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            string sQuery = "update cho_thue_xe set TenKH = @TenKH, MaDT = @MaDT, " + "TenXe = @TenXe, NgayThue = @NgayThue" + "where MaXe=@MaXe";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@TenKH", sHoTen);
            cmd.Parameters.AddWithValue("@MaDT", sMaDT);
            cmd.Parameters.AddWithValue("@TenXe", sTenXe);
            cmd.Parameters.AddWithValue("@MaXe", sNgayThue);
            cmd.Parameters.AddWithValue("@NgayThue", sNgayThue);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhập thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhập!");
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sHoTen = txtTen.Text;
            string sMaDT = txtMaDT.Text;
            string sTenXe = txtTenXe.Text;
            string sMaXe = txtMaXe.Text;
            string sNgayThue = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            string sQuery = "insert into QUAN_LY_CHO_THUE_XE values(@TenKH, @MaDT, @TenXe, @MaXe, @NgayThue)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@TenKH", sHoTen);
            cmd.Parameters.AddWithValue("@MaDT", sMaDT);
            cmd.Parameters.AddWithValue("@TenXe", sTenXe);
            cmd.Parameters.AddWithValue("@MaXe", sNgayThue);
            cmd.Parameters.AddWithValue("@NgayThue", sNgayThue);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới!");
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTen.Text = dataGridView1.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
            txtMaDT.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDT"].Value.ToString();
            txtTenXe.Text = dataGridView1.Rows[e.RowIndex].Cells["TenXe"].Value.ToString();
            txtMaXe.Text = dataGridView1.Rows[e.RowIndex].Cells["MaXe"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayThue"].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sHoTen = txtTen.Text;
            string sMaDT = txtMaDT.Text;
            string sTenXe = txtTenXe.Text;
            string sMaXe = txtMaXe.Text;
            string sNgayThue = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            string sQuery = "delete cho_thue_xe where MaXe = @MaXe";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@TenKH", sHoTen);
            cmd.Parameters.AddWithValue("@MaDT", sMaDT);
            cmd.Parameters.AddWithValue("@TenXe", sTenXe);
            cmd.Parameters.AddWithValue("@MaXe", sNgayThue);
            cmd.Parameters.AddWithValue("@NgayThue", sNgayThue);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình xoá!");
                con.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string Squery = "select*from KHACH where Ten like N'%" + txtTimKiem.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Squery, con);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds, "THUE");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dataGridView1.DataSource = ds.Tables["THUE"];
            con.Close();
        }

        
    }
}

