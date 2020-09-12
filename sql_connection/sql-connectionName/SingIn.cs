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
using System.Data;

namespace sql_connectionName
{
    public partial class SingIn : Form
    {
        HomePaste homepaset = new HomePaste();
        public static string id, nam, password, country;
        public SingIn()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDangNhap_Click(object sender, EventArgs e)
        {
            string userEmail = textBoxEmail.Text;
            string userPassword = textBoxPassword.Text;

            string query = "select* from Users Name= " + userName + " ";
           
            homepaset.Show();
        }

        private void SingIn_Load(object sender, EventArgs e)
        {

        }
    }
}
