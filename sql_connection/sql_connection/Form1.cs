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

namespace sql_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = "data SOUCE=.; DATABASE=QUANLYNHANVIEN " + "intergrated security=SSPI";
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from " + "sales.customers", conn);
            try
            {
                conn.Open();
                MessageBox.Show("thanh cong");
                SqlDataReader sdr = cmd.ExecuteReader();
                BindingSource sourcece = new BindingSource();
                sourcece.DataSource = sdr;
                dataGridView1.DataSource = sourcece;
            }
            catch
            {
                MessageBox.Show("k thanh cong");
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
