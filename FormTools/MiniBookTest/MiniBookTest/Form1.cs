using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MiniBookTest
{
    public partial class Form1 : Form
    {
        //Data Source=DESKTOP-NA57A1V\SQLEXPRESS;Initial Catalog=DBProductTest;Integrated Security=True
        //for connection
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-NA57A1V\SQLEXPRESS;Initial Catalog=DBProductTest;Integrated Security=True");
            SqlCommand commandList = new SqlCommand("select * from TblCategory",connection);
            SqlDataAdapter listCommandAdapter = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            listCommandAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
