using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_connectionName
{
    public partial class SingUp : Form
    {
        DbAccess dbAccess = new DbAccess();
        public SingUp()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void SingUp_Load(object sender, EventArgs e)
        {

        }

        private void ButtonDangKy_Click(object sender, EventArgs e)
        {
            string userName = textBoxName.Text;
            string userEmail = textBoxEmail.Text;
            string userPassword = textBoxPassword.Text;
            string userCountry = comboBoxCountry.Text;

            SqlCommand insertCommand = new SqlCommand("insert into " +
                "Users(Name, Email, Password, Country) " +
                "values(@userName, @userEmail, @userPassword, @userCountry)");
            insertCommand.Parameters.AddWithValue("@userName", userName);
            insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
            insertCommand.Parameters.AddWithValue("@userPassword", userPassword);
            insertCommand.Parameters.AddWithValue("@userCountry", userCountry);

            int row = dbAccess.executeQuery(insertCommand);
            if (row == 1)
            {
                MessageBox.Show("Successfully Signed Up");
                Hide();
                //FormHomePage home Page = new FormHomePage();
                //homePage.Show();
            }
        }
    }
}
