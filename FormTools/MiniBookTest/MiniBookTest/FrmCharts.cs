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
    public partial class FrmCharts : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-NA57A1V\SQLEXPRESS;Initial Catalog=DBProductTest;Integrated Security=True");

        public FrmCharts()
        {
            InitializeComponent();
        }

        private void FrmCharts_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commandCategories = new SqlCommand("select cName, COUNT(*) from TblProduct inner join TblCategory on TblProduct.category=TblCategory.Id group by cName", connection);
            SqlDataReader reader = commandCategories.ExecuteReader();
            while(reader.Read())
            {
                chart1.Series["Categories"].Points.AddXY(reader[0], reader[1]);
            }
            connection.Close();
        }
    }
}
