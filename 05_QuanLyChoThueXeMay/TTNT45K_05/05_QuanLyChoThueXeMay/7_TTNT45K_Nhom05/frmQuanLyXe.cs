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
    public partial class frmQuanLyXe : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NGBATRUONG;Initial Catalog=ChoThueXe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        

        public frmQuanLyXe()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from XE";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        private void MaXe_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Chung_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void cbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmQuanLyXe_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Insert into XE values('" + txtMaXe.Text + "','" + cbTinhTrang.Text + "','" + txtMoTa.Text + "','" + cbLoaiXe.Text + "','" + txtDonGia.Text + "')";   
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from XE where MaX='" + txtMaXe.Text + "'";
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update XE set TinhTrang=N'" + cbTinhTrang.Text + "',MoTa=N'" + txtMoTa.Text + "',Loai=N'" + cbLoaiXe.Text + "',DonGiaThue='" + txtDonGia.Text + "' where MaX='" + txtMaXe.Text + "'";   
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaXe.Enabled = false;
            int i;
            i = dgv.CurrentRow.Index;
            txtMaXe.Text = dgv.Rows[i].Cells[0].Value.ToString();
            cbTinhTrang.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtMoTa.Text = dgv.Rows[i].Cells[2].Value.ToString();
            cbLoaiXe.Text = dgv.Rows[i].Cells[3].Value.ToString();
            txtDonGia.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemLai_Click(object sender, EventArgs e)
        {
            txtMaXe.Text = "";
            txtDonGia.Text = "";
            txtMoTa.Text = "";
            cbLoaiXe.Text = "";
            cbTinhTrang.Text = "";
            txtMaXe.Enabled = true;
        }
    }
}
