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
            cmn.Open();
            cmd.ExecuteNonQuery();
            cmn.Close();
        }

        public frmQuanLyDonThue()
        {
            InitializeComponent();
            loaddata();
            setcbbSDT();
            setcbbLoaiXe();
        }
        public void loaddata()
        {
            string query = "select * from Thue";
            dgvHD.DataSource = GetRecords(query);
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
            cbbMaXe.Items.Clear();
            string query = "select distinct MaX from Xe where Loai = '" + cbbLoaiXe.SelectedItem.ToString() + "'";
            List<string> MaXe = new List<string>();
            foreach (DataRow i in GetRecords(query).Rows)
            {
                MaXe.Add(i["MaX"].ToString());
            }
            foreach (string i in MaXe)
            {
                cbbMaXe.Items.Add(i.ToString());
            }
            string queue = "select * from Thue ";
            if (cbbLoaiXe.SelectedItem.ToString() == "Xe Đap") queue += "where MaX Like 'D%'";
            else if (cbbLoaiXe.SelectedItem.ToString() == "Xe Máy") queue += "where MaX Like 'M%'";
            dgvHD.DataSource = GetRecords(queue);
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
            if (cbbSDT.SelectedItem == null || cbbMaXe.SelectedItem == null || cbbDamBao.SelectedItem == null || txtGioThue.Text == "")
            {
                MessageBox.Show("Vui long dien du thong tin");
            }
            else
            {
                string SDT = cbbSDT.SelectedItem.ToString();
                string MaX = cbbMaXe.SelectedItem.ToString();
                string DamBao = cbbDamBao.SelectedItem.ToString();
                DateTime NgayThue = Convert.ToDateTime(dtNgayThue.Value);
                string GioThue = txtGioThue.Text;
                string query = "Insert into Thue values ('";
                query = query + SDT + "' , '" + MaX + "' , '" + DamBao
                    + "' ,'" + NgayThue.ToShortDateString() + "' , '" + GioThue
                    + "', NULL, NULL, NULL, NULL)";
                ExcuteDB(query);
            }
            loaddata();
        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            if (txtDonGiaThue.Text == "")
            {
                MessageBox.Show("Vui long dien du thong tin");
            }
            else
            {
                int Total = Convert.ToInt32(txtDonGiaThue.Text) * TGThue();
                txtThanhTien.Text = Total.ToString();
            }
        }

        private int TGThue()
        {
            DateTime a = Convert.ToDateTime(dtNgayThue.Value);
            DateTime b = Convert.ToDateTime(dtNgayTra.Value);
            TimeSpan c = b.Subtract(a);
            return Convert.ToInt32(c.TotalDays) + 1;
        }



        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtGioTra.Text == "" || txtDonGiaThue.Text == "")
            {
                MessageBox.Show("Vui long dien du thong tin");
            }
            else
            {
                int MaHD = Convert.ToInt32(dgvHD.CurrentRow.Cells["MaHD"].Value);
                DateTime NgayTra = Convert.ToDateTime(dtNgayTra.Value);
                string GioTra = txtGioTra.Text;
                int ThoiGianThue = TGThue();
                int ThanhTien = Convert.ToInt32(txtDonGiaThue.Text) * TGThue();
                string query = "update Thue set NgayTra = '" + NgayTra.ToShortDateString()
                + "' , GioTra = '" + GioTra.ToString() + "', ThoiGianThue = " + ThoiGianThue
                + ", ThanhTien = " + ThanhTien + "where MaHD = " + MaHD;
                ExcuteDB(query);
            }
            loaddata();
        }

        private void dgvHD_MouseClick(object sender, MouseEventArgs e)
        {
            string MaX = "";
            int MaHD = Convert.ToInt32(dgvHD.CurrentRow.Cells["MaHD"].Value);
            string query = "select * from Thue where MaHD = " + MaHD;
            foreach (DataRow i in GetRecords(query).Rows)
            {
                cbbSDT.Text = i["SoDT"].ToString();
                cbbMaXe.Text = i["MaX"].ToString();
                cbbDamBao.Text = i["DamBao"].ToString();
                txtMaHoaDon.Text = i["MaHD"].ToString();
                dtNgayThue.Value = Convert.ToDateTime(i["NgayThue"].ToString());
                txtGioThue.Text = i["GioThue"].ToString();
                if (i["NgayTra"].ToString() == "")
                {
                    dtNgayTra.Value = DateTime.Now;
                    txtGioTra.Text = "";
                    txtThanhTien.Text = "";
                }
                else
                {
                    dtNgayTra.Value = Convert.ToDateTime(i["NgayTra"].ToString());
                    txtGioTra.Text = i["GioTra"].ToString();
                    txtThanhTien.Text = i["ThanhTien"].ToString();
                }
                query = "select Loai, DonGiaThue from Xe where MaX = '" + i["MaX"].ToString() + "'";
                foreach (DataRow j in GetRecords(query).Rows)
                {
                    cbbLoaiXe.Text = j["Loai"].ToString();
                    txtDonGiaThue.Text = j["DonGiaThue"].ToString();
                }
            }
        }

        private void bntSuaDT_Click(object sender, EventArgs e)
        {
            int MaHD = Convert.ToInt32(dgvHD.CurrentRow.Cells["MaHD"].Value);
            string SDT = cbbSDT.SelectedItem.ToString();
            string MaX = cbbMaXe.SelectedItem.ToString();
            string DamBao = cbbDamBao.SelectedItem.ToString();
            DateTime NgayThue = Convert.ToDateTime(dtNgayThue.Value);
            string GioThue = txtGioThue.Text;
            string query = "update Thue set SoDT = '" + SDT + "', MaX = '" + MaX + "', DamBao = '"
                + DamBao + "', NgayThue = '" + NgayThue.ToShortDateString() + "', GioThue = '"
                + GioThue.ToString() + "' where MaHD = " + MaHD;
            ExcuteDB(query);
            loaddata();
        }

        private void cbbSDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from Thue where SoDT = '" + cbbSDT.SelectedItem.ToString() + "'";
            dgvHD.DataSource = GetRecords(query);
        }

        private void cbbMaXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from Thue where MaX = '" + cbbMaXe.SelectedItem.ToString() + "'";
            dgvHD.DataSource = GetRecords(query);
        }

        private void btnTimKiemDT_Click(object sender, EventArgs e)
        {
            string query = "select * from Thue where MaHD = '" + txtMaHoaDon.Text + "'";
            dgvHD.DataSource = GetRecords(query);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        
        

       


        
    }
}

    



        

        

        

   