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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-NA57A1V\SQLEXPRESS;Initial Catalog=DBProductTest;Integrated Security=True");

        private void list()
        {
            SqlCommand commandList = new SqlCommand("select * from TblProduct", connection);
            SqlDataAdapter listCommandAdapter = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            listCommandAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void fillCombobox()
        {
            SqlCommand commandFill = new SqlCommand("select * from TblCategory", connection);
            SqlDataAdapter fillCommandAdapter = new SqlDataAdapter(commandFill);
            DataTable dt = new DataTable();
            fillCommandAdapter.Fill(dt);
            CmbCategory.DataSource = dt;
            CmbCategory.DisplayMember = "cName";
            CmbCategory.ValueMember = "Id";
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            list();
            fillCombobox();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string pName = TxtProductName.Text;
            int stock = (int)NUDStock.Value;
            string buyingPrice = TxtBuyingPrice.Text;
            string sellingPrice = TxtSellingPrice.Text;
            int category = int.Parse(CmbCategory.SelectedValue.ToString());

            if(pName=="")
            {
                MessageBox.Show("Not valid product name", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (buyingPrice == "")
            {
                MessageBox.Show("Not valid product buying price", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sellingPrice == "")
            {
                MessageBox.Show("Not valid product selling price", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int iBuyingPrice = int.Parse(buyingPrice);
            int iSellingPrice = int.Parse(sellingPrice);

            if(iBuyingPrice <=0)
            {
                MessageBox.Show("Not valid product buying price", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(iSellingPrice <=0)
            {
                MessageBox.Show("Not valid product selling price", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Open();

            SqlCommand commandSave = new SqlCommand("insert into TblProduct values(@p1,@p2,@p3,@p4,@p5)",connection);
            commandSave.Parameters.AddWithValue("@p1",pName);
            commandSave.Parameters.AddWithValue("@p2", stock);
            commandSave.Parameters.AddWithValue("@p3", iBuyingPrice);
            commandSave.Parameters.AddWithValue("@p4", iSellingPrice);
            commandSave.Parameters.AddWithValue("@p5", category);
            commandSave.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfully saved", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();

        }

        private void TxtBuyingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Eğer sayı değilse işlemi engelle
            }
        }

        private void TxtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Eğer sayı değilse işlemi engelle
            }
        }
    }
}
