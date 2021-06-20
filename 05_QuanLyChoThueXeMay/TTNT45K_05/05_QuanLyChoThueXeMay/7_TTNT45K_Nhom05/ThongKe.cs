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
        string str = "Data Source=NGBATRUONG;Initial Catalog=ChoThueXe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from XE";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv2.DataSource = table;
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
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
