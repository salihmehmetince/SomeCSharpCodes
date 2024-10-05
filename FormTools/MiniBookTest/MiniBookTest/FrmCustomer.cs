using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBookTest
{
    public partial class FrmCustomer : Form
    {
        DataSet1TableAdapters.TblCustomerTableAdapter tblCustomerTableAdapter = new DataSet1TableAdapters.TblCustomerTableAdapter();

        public FrmCustomer()
        {
            InitializeComponent();
        }
        private void list()
        {
            dataGridView1.DataSource = tblCustomerTableAdapter.getCustomerData();
        }

        private void delete()
        {
            string customerDelete = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            if(customerDelete=="")
            {
                MessageBox.Show("You have to choose a custpmer from datagrid  to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int iCustomerDelete = int.Parse(customerDelete);
            tblCustomerTableAdapter.DeleteCustomer(iCustomerDelete);
            MessageBox.Show("Successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }
        private void insertCustomer()
        {
            string name = TxtName.Text;
            string surname=TxtSurname.Text;
            string city=TxtCity.Text;
            string balance = TxtBalance.Text;

            if(name=="")
            {
                MessageBox.Show("Name cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (surname == "")
            {
                MessageBox.Show("Surname cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (city == "")
            {
                MessageBox.Show("City cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (balance == "")
            {
                MessageBox.Show("balance cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int iBalance = int.Parse(balance);
            tblCustomerTableAdapter.InsertCustomer(name,surname,city,iBalance);
            list();
            MessageBox.Show("Successfully saved", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            list();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            insertCustomer();
        }

        private void TxtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamlara (0-9) ve kontrol karakterlerine (Backspace, Enter vb.) izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  // Geçersiz tuşu iptal et
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isEmpty = dataGridView1.Rows.Count == 0 || (dataGridView1.Rows.Count == 1 && dataGridView1.AllowUserToAddRows && dataGridView1.Rows[0].IsNewRow);
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }
            if (!isEmpty)
            {
                TxtId.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                TxtName.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                TxtSurname.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                TxtCity.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                TxtBalance.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string surname = TxtSurname.Text;
            string city = TxtCity.Text;
            string balance = TxtBalance.Text;
            string customerId=TxtId.Text;
            if (name == "")
            {
                MessageBox.Show("Name cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (surname == "")
            {
                MessageBox.Show("Surname cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (city == "")
            {
                MessageBox.Show("City cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (balance == "")
            {
                MessageBox.Show("balance cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal iBalance = decimal.Parse(balance);
            if (customerId=="")
            {
                MessageBox.Show("balance cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int iCustomerId = int.Parse(customerId);
            tblCustomerTableAdapter.UpdateCustomer(name, surname, city, iBalance, iCustomerId);
            list();
            MessageBox.Show("Successfully updated", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchWord = TxtSearch.Text;
            if (searchWord== "")
            {
                MessageBox.Show("Search word cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (RDBSearchName.Checked==true)
            {
                dataGridView1.DataSource=tblCustomerTableAdapter.getByName(searchWord);
            }
            else if(RDBSearchSurname.Checked==true)
            {
                dataGridView1.DataSource = tblCustomerTableAdapter.getBySurname(searchWord);

            }
            else if(RDBSearchCity.Checked==true)
            {
                dataGridView1.DataSource = tblCustomerTableAdapter.getByCity(searchWord);
            }
        }
    }
}
