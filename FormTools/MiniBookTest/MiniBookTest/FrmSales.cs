using MiniBookTest.DataSet1TableAdapters;
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
    public partial class FrmSales : Form
    {
        public FrmSales()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.getSalesNameTableAdapter getSalesTableAdapter = new DataSet1TableAdapters.getSalesNameTableAdapter();
        DataSet1TableAdapters.TblProductTableAdapter getProductTableAdapter = new DataSet1TableAdapters.TblProductTableAdapter();
        DataSet1TableAdapters.TblSalesTableAdapter tblSalesTableAdapter = new DataSet1TableAdapters.TblSalesTableAdapter();
        private void list()
        {
            dataGridView1.DataSource = getSalesTableAdapter.getSalesName();
        }

        private void fillCMBProduct()
        {
            CmbProduct.DataSource=getProductTableAdapter.getProduct();
            CmbProduct.ValueMember = "Id";
            CmbProduct.DisplayMember = "pName";
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            list();
            fillCMBProduct();
        }

        private void saveSale()
        {
            string product = CmbProduct.SelectedValue.ToString();
            string customer = TxtCustomer.Text;
            string piece = TxtPiece.Text;
            string price = TxtPrice.Text;
            string total = TxtTotal.Text;
            string date = MTBSaleDate.Text;

            if (product == "")
            {
                MessageBox.Show("product cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (customer == "")
            {
                MessageBox.Show("customer cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (piece == "")
            {
                MessageBox.Show("piece cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (price == "")
            {
                MessageBox.Show("price cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (total == "")
            {
                MessageBox.Show("total cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (date == "")
            {
                MessageBox.Show("date cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int iProduct = int.Parse(product);
            int iCustomer = int.Parse(customer);
            byte iPiece = byte.Parse(piece);
            decimal iPrice = decimal.Parse(price);
            decimal iTotal = decimal.Parse(total);
            string dDate = DateTime.Parse(date).ToString();
            tblSalesTableAdapter.InsertSale(iProduct, iCustomer, iPiece, iPrice, iTotal, dDate);
            list();
            MessageBox.Show("Successfully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveSale();

        }
    }
}
