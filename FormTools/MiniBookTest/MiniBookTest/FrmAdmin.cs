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

namespace MiniBookTest
{
    public partial class FrmAdmin : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-NA57A1V\SQLEXPRESS;Initial Catalog=DBProductTest;Integrated Security=True");

        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string userName=TxtUserName.Text;
            string password=TxtPassword.Text;
            if(userName=="")
            {
                MessageBox.Show("Username cannot be empty", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password == "")
            {
                MessageBox.Show("password cannot be empty", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Open();
            SqlCommand commandLogin = new SqlCommand("select * from AdminTable Where aName=@p1 and aPassword=@p2",connection);
            commandLogin.Parameters.AddWithValue("@p1",userName);
            commandLogin.Parameters.AddWithValue("@p2",password);
            SqlDataReader dataReader=commandLogin.ExecuteReader();
            if(dataReader.Read())
            {
                FrmDirectTo frmDirectTo = new FrmDirectTo();
                frmDirectTo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connection.Close();
        }
    }
}
