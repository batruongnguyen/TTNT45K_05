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
        string con = @"Data Source=NGBATRUONG;Initial Catalog=ChoThueXe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            SqlConnection ThongKe = new SqlConnection(con);
            //Dữ liệu load 

            //Load dữ liệu từ database vào combobox loại xe
            cbbLoaiXe.Items.Clear();
            ThongKe.Open();
            cmd = ThongKe.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select distinct Loai from XE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbbLoaiXe.Items.Add(dr["Loai"].ToString());
            }
            ThongKe.Close();
            txtDoanhThu.Enabled = false;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            bool flag = false;

            //Bảng theo loại xe
            string sql = "select XE.MaX as 'Mã Xe', MoTa as 'Mô tả',  sum(ThanhTien) as 'Doanh thu'  from Thue right join Xe on Thue.MaX = Xe.MaX where ";
            // Bảng cho xe đang cho thuê
            string sql2 = "select Xe.MaX as 'Mã xe', MoTa as 'Mô tả', Loai as 'Loại', NgayThue as 'Ngày thuê' from Thue right join Xe on Thue.MaX = Xe.MaX where ";
            //Bảng cho xe hỏng, sẵn có
            string sql3 = "select MaX as 'Mã xe', MoTa as 'Mô tả', Loai as 'Loại' from XE where ";


            if (cbTinhTrangXe.Enabled == false)
            {
                if (cbbLoaiXe.SelectedIndex != -1)
                {
                    sql += "Loai =N'" + cbbLoaiXe.SelectedItem.ToString() + "'group by XE.MaX, mota";
                    flag = true;
                }
            }
            else if (cbbLoaiXe.Enabled == false)
            {
                if (cbTinhTrangXe.SelectedIndex != -1)
                {
                    if (cbTinhTrangXe.SelectedIndex == 0)
                    {
                        sql2 += "Xe.TinhTrang =N'" + cbTinhTrangXe.SelectedItem.ToString() + "'";
                        sql = sql2;
                    }
                    else
                    {
                        sql3 += "Xe.TinhTrang =N'" + cbTinhTrangXe.SelectedItem.ToString() + "'";
                        sql = sql3;
                    }
                }
            }

            try
            {
                SqlConnection cmn = new SqlConnection(con);
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(sql, cmn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                cmn.Open();
                da.Fill(dt);
                cmn.Close();

                dataGridView1.DataSource = dt;
                if (flag)
                {
                    try
                    {
                        string querry = "select [dbo].TimDoanhThu(N'" + cbbLoaiXe.SelectedItem.ToString() + "')";
                        SqlCommand cmd2 = new SqlCommand(querry, cmn);
                        cmn.Open();
                        if (cmd2.ExecuteScalar().ToString() != "")
                            txtDoanhThu.Text = cmd2.ExecuteScalar().ToString();
                        else
                            txtDoanhThu.Text = "0";
                        cmd2.Dispose();
                        cmn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnXemLai_Click(object sender, EventArgs e)
        {
            cbTinhTrangXe.Text = "";
            txtDoanhThu.Text = "";
            cbbLoaiXe.Text = "";
            cbbLoaiXe.Enabled = true;
            cbTinhTrangXe.Enabled = true;
            dataGridView1.DataSource = null;
        }

        
        private void cbTinhTrangXe_Click(object sender, EventArgs e)
        {
            cbbLoaiXe.Enabled = false;
        }

        private void cbbLoaiXe_Click(object sender, EventArgs e)
        {
            cbTinhTrangXe.Enabled = false;
        }

        private void cbTinhTrangXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTinhTrangXe.Text != "Đang cho thuê" || cbbLoaiXe.Text == "")
            {
                txtDoanhThu.Text = "";
            }
        }

       

        

        

        

        

        

        

    }

}
