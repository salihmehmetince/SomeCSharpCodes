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
            SqlCommand commandList = new SqlCommand("SELECT TblProduct.Id, TblProduct.pName, TblProduct.stock, TblProduct.buyingPrice, TblProduct.sellingPrice,TblProduct.category, TblCategory.cName  FROM TblProduct INNER JOIN TblCategory ON TblProduct.category = TblCategory.Id", connection);
            SqlDataAdapter listCommandAdapter = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            listCommandAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[5].Visible = false;
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string sDeleteValue = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            if(sDeleteValue=="")
            {
                MessageBox.Show("You have to choose a category from datagrid to delete ", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int deleteValue = int.Parse(sDeleteValue);
            
            connection.Open();
            SqlCommand commandDelete = new SqlCommand("delete from TblProduct where Id=@p1", connection);
            commandDelete.Parameters.AddWithValue("@p1", deleteValue);
            commandDelete.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfully deleted ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtProductName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            NUDStock.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            TxtBuyingPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtSellingPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            CmbCategory.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commandUpdate = new SqlCommand("update TblProduct set pName=@p1,stock=@p2,buyingPrice=@p3,sellingPrice=@p4,category=@p5 where Id=@p6",connection);

            string pName = TxtProductName.Text;
            int stock = (int)NUDStock.Value;
            string buyingPrice = TxtBuyingPrice.Text;
            string sellingPrice = TxtSellingPrice.Text;
            int category = int.Parse(CmbCategory.SelectedValue.ToString());

            if (pName == "")
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
            decimal iBuyingPrice = Decimal.Parse(buyingPrice);
            decimal iSellingPrice = Decimal.Parse(sellingPrice);

            if (iBuyingPrice <= 0)
            {
                MessageBox.Show("Not valid product buying price", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (iSellingPrice <= 0)
            {
                MessageBox.Show("Not valid product selling price", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            commandUpdate.Parameters.AddWithValue("@p1",pName);
            commandUpdate.Parameters.AddWithValue("@p2",stock);
            commandUpdate.Parameters.AddWithValue("@p3",iBuyingPrice);
            commandUpdate.Parameters.AddWithValue("@p4",iSellingPrice);
            commandUpdate.Parameters.AddWithValue("@p5",category);

            string sUpdateValue = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            if (sUpdateValue == "")
            {
                MessageBox.Show("You have to choose a category from datagrid to delete ", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int updateValue = int.Parse(sUpdateValue);
            commandUpdate.Parameters.AddWithValue("@p6", updateValue);
            commandUpdate.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfully updated", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }
    }
}
