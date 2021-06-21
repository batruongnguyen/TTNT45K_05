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
    public partial class frmQuanLyKH : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NGBATRUONG;Initial Catalog=ChoThueXe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        
        public frmQuanLyKH()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmQuanLyKH_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(SCon);
            try
            {
                Con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sQuery = "select *from KHACH";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, Con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "KhachHang");

            dgv1.DataSource = ds.Tables["KhachHang"];

            Con.Close();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            SqlConnection KH = new SqlConnection(sKH);
            try
            {
                KH.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông Báo", "Xảy ra lỗi trong quá trình kết nối DB");
            }

            string sSDT = txtSDT.Text;
            string sTen = txtTen.Text;
            string sDiaChi = txtDiachi.Text;

            string sQuery = "insert into KHACH values (@SoDT,@Ten,@DiaChi)";
            SqlCommand cmd = new SqlCommand(sQuery, KH);
            cmd.Parameters.AddWithValue("@SoDT", sSDT);
            cmd.Parameters.AddWithValue("@Ten", sTen);
            cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thông Báo", "Thêm mới thành công!");
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Thông Báo", "Xảy ra lỗi trong quá trình thêm mới!");
            }
            KH.Close();


           
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            SqlConnection KH = new SqlConnection(sKH);
            try
            {
                KH.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông Báo", "Xảy ra lỗi trong quá trình kết nối DB");
            }
            command = connection.CreateCommand();
            command.CommandText = "delete from KHACH where SoDT='" + txtSDT.Text + "'";
            command.ExecuteNonQuery();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Thông Báo", "Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông Báo", "Xảy ra lỗi trong quá trình xóa!");

            }
            KH.Close();

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            SqlConnection KH = new SqlConnection(sKH);
            try
            {
                KH.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông Báo", "Xảy ra lỗi trong quá trình kết nối DB");
            }
            command = connection.CreateCommand();
            command.CommandText = "update KHACH set Ten=N'" + txtTen.Text + "',DiaChi='" + txtDiachi.Text + "'where SoDT='"+txtSDT.Text+"'";
            command.ExecuteNonQuery();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Thông Báo", "Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông Báo", "Xảy ra lỗi trong quá trình cập nhật!");

            }
            KH.Close();

        }

        private void btnTimkiemKH_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM KHACH WHERE SoDT LIKE N'%" + txtSDT + "%'", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"KHACH");
            if (ds.Tables["KHACH"].Rows.Count > 0)
            {
                dgv1.DataSource = ds.Tables["KHACH"];
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng có thông tin phù hợp!");
                txtTimkiem.Text = "";
            }
            loaddata();
            connection.Close();

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSDT.Text = dgv1.Rows[e.RowIndex].Cells["SoDT"].Value.ToString();
            txtTen.Text = dgv1.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
            txtDiachi.Text = dgv1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
        }

        private void btnXemlai_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";

        }




       }
}
