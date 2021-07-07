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

        SqlConnection cmn = new SqlConnection(@"Data Source=NGBATRUONG;Initial Catalog=ChoThueXe;Integrated Security=True");

        

        public DataTable GetRecords(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, cmn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmn.Open();
            da.Fill(dt);
            cmn.Close();
            return dt;
        }

        public void ExcuteDB(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cmn);
            try
            {
                cmn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu!", "Thông báo");
            }
            cmn.Close();
        }

        public frmQuanLyDonThue()
        {
            InitializeComponent();
            btnThanhToan.Enabled = false;
            loaddata();
            setcbbSDT();
            setcbbLoaiXe();
            
        }
        public void loaddata()
        {
            string query = "select MaHD, SoDT, MaX,Thoigianthue, ThanhTien, TinhTrang from Thue";
            dgvHD.DataSource = GetRecords(query);
            txtMahoadon.Enabled = false;
        }

        public void setcbbSDT()
        {
            string query = "select SoDT from Khach";
            List<string> SDT = new List<string>();
            foreach (DataRow i in GetRecords(query).Rows)
            {
                SDT.Add(i["SoDT"].ToString());
            }
            foreach (string i in SDT)
            {
                cbbSDT.Items.Add(i.ToString());
            }
        }

        private void cbbLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load cbb Mã Xe
            cbbMaXe.Items.Clear();
            string querry1 = "select distinct MaX from Xe where TinhTrang = N'Sẵn có' and Loai = N'" + cbbLoaiXe.SelectedItem.ToString() + "'";
            List<string> MaXe = new List<string>();
            foreach (DataRow i in GetRecords(querry1).Rows)
            {
                MaXe.Add(i["MaX"].ToString());
            }
            foreach (string i in MaXe)
            {
                cbbMaXe.Items.Add(i.ToString());
            }

            //phân loại Mã xe theo từng Loại Xe 
            string querry2 = "select * from Thue ";
            if (cbbLoaiXe.SelectedItem.ToString() == "Xe Đạp") querry2 += "where MaX Like 'D%'";
            else if (cbbLoaiXe.SelectedItem.ToString() == "Xe Máy") querry2 += "where MaX Like 'M%'";          
        }

        public void setcbbLoaiXe()
        {
            string query = "select distinct Loai from Xe";
            List<string> Loai = new List<string>();
            foreach (DataRow i in GetRecords(query).Rows)
            {
                Loai.Add(i["Loai"].ToString());
            }
            foreach (string i in Loai)
            {
                cbbLoaiXe.Items.Add(i.ToString());
            }
        }

        private void btnThemDT_Click(object sender, EventArgs e)
        {
            //Nhập thông tin vào dgv
            if (cbbSDT.SelectedItem == null || cbbMaXe.SelectedItem == null || cbDamBao.SelectedItem == null || dtGioThue.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ!", "Thông báo");
            }
            else
            {
                string SDT = cbbSDT.SelectedItem.ToString();
                string MaX = cbbMaXe.SelectedItem.ToString();
                string DamBao = cbDamBao.SelectedItem.ToString();
                DateTime NgayThue = Convert.ToDateTime(dtNgayThue.Value);
                DateTime GioThue = Convert.ToDateTime(dtGioThue.Value);
                string query = "Insert into Thue values ('";
                query = query + SDT + "' , '" + MaX + "' , N'" + DamBao
                    + "' ,'" + NgayThue.ToString("yyyy-MM-dd") + "' , '" + GioThue.ToString("HH:mm:ss")
                    + "', NULL, NULL, NULL, NULL,0)";
                ExcuteDB(query);
                loaddata();
                MessageBox.Show("Đã thêm thành công!", "Thông báo");
            }         
        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = true;
            if (txtDonGiaThue.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ!", "Thông báo");
            }
            else
            {
                int Total = Convert.ToInt32(txtDonGiaThue.Text) * TGThue();
                txtThanhTien.Text = Total.ToString();

                int MaHD = Convert.ToInt32(dgvHD.CurrentRow.Cells[0].Value);
                DateTime NgayTra = Convert.ToDateTime(dtNgayTra.Value);
                DateTime GioTra = Convert.ToDateTime(dtGioTra.Value);

                int ThoiGianThue = TGThue();
                string query1 = "update Thue set NgayTra = '" + NgayTra.ToString("yyyy-MM-dd")
                    + "' , GioTra = '" + GioTra.ToString("HH:mm:ss") + "', ThoiGianThue = " + ThoiGianThue
                    + ", ThanhTien = " + Total + "where MaHD = " + MaHD;
                ExcuteDB(query1);
                loaddata();
            }
            dtGioTra.Enabled = false;
            dtNgayTra.Enabled = false;
        }

        private int TGThue()
        {
            DateTime a = Convert.ToDateTime(dtNgayThue.Value);
            DateTime b = Convert.ToDateTime(dtNgayTra.Value);
            DateTime d = Convert.ToDateTime(dtGioThue.Value);
            DateTime f = Convert.ToDateTime(dtGioTra.Value);

            TimeSpan span = b.Subtract(a);
            TimeSpan span1 = f.Subtract(d);

            double TotalDays1 = span.TotalDays;
            double TotalMinutes1 = span1.TotalMinutes;


            if (TotalDays1 == 0)
            {
                if (TotalMinutes1 > 0)
                {
                    return Convert.ToInt32(span.TotalDays) + 1;
                }
                else
                {
                    return Convert.ToInt32(span.TotalDays);
                }
            }
            else if (TotalDays1 > 0)
            {
                if (TotalMinutes1 > 0)
                {
                    return Convert.ToInt32(span.TotalDays) + 1;
                }
                else
                {
                    return Convert.ToInt32(span.TotalDays);
                }
            } else
            {
                MessageBox.Show("Mời nhập lại ngày thuê hoặc ngày trả!", "Thông báo");
                return 0;
            }
        }                      
        


        
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            if (dtGioTra.Text == "" || txtDonGiaThue.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ", "Thông báo");
            }
            else
            {
                if (bool.Parse(dgvHD.CurrentRow.Cells[5].Value.ToString()) == false)
                {
                    int MaHD = Convert.ToInt32(dgvHD.CurrentRow.Cells[0].Value);
                    string query = "update Thue set TinhTrang = 1" + "where MaHD = " + MaHD;
                    ExcuteDB(query);
                    MessageBox.Show("Thanh toán thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đơn xe này đã được thanh toán!", "Lỗi");
                }
            }
            loaddata();
        }

        

        private void cbbSDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from Thue where SoDT = '" + cbbSDT.SelectedItem.ToString() + "'";

        }

        private void cbbMaXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from Thue where Max = N'" + cbbMaXe.SelectedItem.ToString() + "'";

            //load thanh tien vao textbox
            cmn.Open();
            string querry3 = "select distinct DonGiaThue from Xe where MaX = N'" + cbbMaXe.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(querry3, cmn);
            txtDonGiaThue.Text = cmd.ExecuteScalar().ToString();
            txtThanhTien.Enabled = false;
            txtDonGiaThue.Enabled = false;
            cmd.Dispose();
            cmn.Close();
        }

        private void btnHuyDT_Click(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = true;
            cbbLoaiXe.Enabled = true;
            cbbSDT.Enabled = true;
            cbbMaXe.Enabled = true;
            dtGioThue.Enabled = true;
            dtNgayThue.Enabled = true;       
            cbDamBao.Enabled = true;
            dtNgayTra.Enabled = true;
            dtGioTra.Enabled = true;
            loaddata();
            dtGioThue.Text = "";
            dtNgayThue.Text = "";
            cbDamBao.Text = "";
            txtMahoadon.Text = "";
            cbbSDT.Text = "";
            cbbLoaiXe.Text = "";
            cbbMaXe.Text = "";
            dtNgayTra.Text = "";
            dtGioTra.Text = "";
            txtDonGiaThue.Text = "";
            txtThanhTien.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (flag == true)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    try
                    {
                        if (dgvHD.CurrentCell != null)
                        {
                            int MaHD = Convert.ToInt32(dgvHD.CurrentRow.Cells[0].Value);
                            string query = "delete from Thue where MaHD = " + MaHD;
                            ExcuteDB(query);
                            loaddata();
                        }
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xảy ra lỗi trong quá trình xóa!", "Thông báo");
                    }
                    loaddata();
                }
            }
        }        

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtThanhTien.Text == "")
            {
                btnThanhToan.Enabled = false;
            }
            else
            {
                btnThanhToan.Enabled = true;
            }
            
            string MaX = "";
            int MaHD = Convert.ToInt32(dgvHD.CurrentRow.Cells[0].Value);
            string query = "select * from Thue where MaHD = ' " + MaHD + "'";
            foreach (DataRow i in GetRecords(query).Rows)
            {
                cbbSDT.Text = i["SoDT"].ToString();
                cbbMaXe.Text = i["MaX"].ToString();
                cbDamBao.Text = i["DamBao"].ToString();
                txtMahoadon.Text = i["MaHD"].ToString();
                dtNgayThue.Value = Convert.ToDateTime(i["NgayThue"].ToString());
                dtGioThue.Value = Convert.ToDateTime(i["GioThue"].ToString());
                if (i["NgayTra"].ToString() == "")
                {
                    dtNgayTra.Value = DateTime.Now;
                    dtGioTra.Value = DateTime.Now;
                    txtThanhTien.Text = "";
                }
                else
                {
                    dtNgayTra.Value = Convert.ToDateTime(i["NgayTra"].ToString());
                    dtGioTra.Value = Convert.ToDateTime(i["GioTra"].ToString());
                    txtThanhTien.Text = i["ThanhTien"].ToString();
                }
                query = "select Loai, DonGiaThue from Xe where MaX = '" + i["MaX"].ToString() + "'";
                foreach (DataRow j in GetRecords(query).Rows)
                {
                    cbbLoaiXe.Text = j["Loai"].ToString();
                    txtDonGiaThue.Text = j["DonGiaThue"].ToString();
                }
            }
            cbbLoaiXe.Enabled = false;
            cbbSDT.Enabled = false;
            cbbMaXe.Enabled = false;
            dtGioThue.Enabled = false;
            dtNgayThue.Enabled = false;
            cbDamBao.Enabled = false;
            dtNgayTra.Enabled = true;
            dtGioTra.Enabled = true;
        }           
    }
}

    



        

        

        

   