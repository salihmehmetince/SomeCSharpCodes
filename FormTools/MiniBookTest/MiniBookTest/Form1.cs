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

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-NA57A1V\SQLEXPRESS;Initial Catalog=DBProductTest;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void list()
        {
            SqlCommand commandList = new SqlCommand("select * from TblCategory", connection);
            SqlDataAdapter listCommandAdapter = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            listCommandAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(TxtCategoryName.Text!="")
            {
                connection.Open();
                SqlCommand commandSave = new SqlCommand("insert into TblCategory values (@p1)", connection);
                commandSave.Parameters.AddWithValue("@p1", TxtCategoryName.Text);
                commandSave.ExecuteNonQuery();
                connection.Close();
                list();
                MessageBox.Show("Successfully saved","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Category cannot be empty", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string valueToDelete = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            if(valueToDelete =="")
            {
                MessageBox.Show("You have to choose a category from datagrid to delete ","information",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int deleteValue = int.Parse(valueToDelete);

            connection.Open();
            SqlCommand commandDelete = new SqlCommand("delete from TblCategory where Id=@p1",connection);
            commandDelete.Parameters.AddWithValue("@p1", deleteValue);
            commandDelete.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfully deleted", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string idToUpdate = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            if (idToUpdate == "")
            {
                MessageBox.Show("You have to choose a category from datagrid to update ", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int updateId = int.Parse(idToUpdate);

            string valueToUpdate = TxtCategoryName.Text;
            if (valueToUpdate == "")
            {
                MessageBox.Show("Category name cannot be empty", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Open();
            SqlCommand commandUpdate = new SqlCommand("update TblCategory set cName=@p1 where Id=@p2", connection);
            commandUpdate.Parameters.AddWithValue("@p1", valueToUpdate);
            commandUpdate.Parameters.AddWithValue("@p2", updateId);
            commandUpdate.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfully updated", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = TxtCategoryName.Text;
            if(searchValue=="")
            {
                return;
            }
            else
            {
                SqlCommand commandSearch = new SqlCommand("SELECT * FROM TblCategory WHERE cName LIKE @p1", connection);
                commandSearch.Parameters.AddWithValue("@p1", "%" + searchValue + "%");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commandSearch);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource=dataTable;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
