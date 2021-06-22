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

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KHACH";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv1.DataSource = table;
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
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into KHACH values('" + txtSDT.Text + "','" + txtTen.Text + "','" + txtDiachi.Text + "')";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm!", "Thông báo");
            }
            loaddata();       
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from KHACH where SoDT='" + txtSDT.Text + "'";
            command.ExecuteNonQuery();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình xóa!", "Thông báo");

            }
            loaddata();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update KHACH set Ten=N'" + txtTen.Text + "',DiaChi='" + txtDiachi.Text + "'where SoDT='" + txtSDT.Text + "'";
            command.ExecuteNonQuery();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật!", "Thông báo");
            }
            loaddata();
        }

        private void btnTimkiemKH_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM KHACH WHERE SoDT LIKE N'%" + txtSDT + "%'", connection);
            DataSet ds = new DataSet();
            adapter.Fill(table);
            if (ds.Tables["KHACH"].Rows.Count > 0)
            {
                dgv1.DataSource = ds.Tables["KHACH"];
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng có thông tin phù hợp!", "Thông báo");
                txtTimkiem.Text = "";
            }
            loaddata();
            connection.Close();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSDT.Enabled = false;
            txtSDT.Text = dgv1.Rows[e.RowIndex].Cells["SoDT"].Value.ToString();
            txtTen.Text = dgv1.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
            txtDiachi.Text = dgv1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
        }

        private void btnXemlai_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            txtSDT.Enabled = true;

        }




       }
}
