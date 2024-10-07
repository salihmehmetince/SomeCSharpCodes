using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProductTrackingTest
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        DBProductTestEntities dB = new DBProductTestEntities();
        private void list()
        {
            var table = from product in dB.TblProduct
                        join category in dB.TblCategory
                        on product.category equals category.Id
                        select new { product.Id,product.pName, product.stock, product.buyingPrice, product.sellingPrice, category.cName};
            dataGridView1.DataSource = table.ToList();
        }

        private void fillCMBCategories()
        {
            CmbCategory.DataSource = dB.TblCategory.ToList();
            CmbCategory.ValueMember = "Id";
            CmbCategory.DisplayMember = "cName";
        }

        private void save()
        {
            string name = TxtProductName.Text;
            string stock = TxtStock.Text;
            string buyingPrice = TxtBuyingPrice.Text;
            string sellingPrice = TxtSellingPrice.Text;
            string category = CmbCategory.SelectedValue.ToString();

            if (name == "")
            {
                MessageBox.Show("Name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (stock == "")
            {
                MessageBox.Show("Stock cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (buyingPrice == "")
            {
                MessageBox.Show("BuyingPrice cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sellingPrice == "")
            {
                MessageBox.Show("SellingPrice cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (category == "")
            {
                MessageBox.Show("Category cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            short sStock = short.Parse(stock);
            decimal dBuyingPrice=decimal.Parse(buyingPrice);
            decimal dSellingPrice=decimal.Parse(sellingPrice);
            int iCategory=int.Parse(category);




            TblProduct product = new TblProduct();
            product.pName = name;
            product.stock = sStock;
            product.buyingPrice = dBuyingPrice;
            product.sellingPrice = dSellingPrice;
            product.category= iCategory;
            dB.TblProduct.Add(product);
            dB.SaveChanges();
            list();
            clear();
            MessageBox.Show("Successfully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void avoidCharacter(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void delete()
        {
            string id = TxtId.Text;

            if (id == "")
            {
                MessageBox.Show("Id cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int iId = int.Parse(id);
            var product =dB.TblProduct.Find(iId);
            if(product == null)
            {
                MessageBox.Show("There is no such a record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dB.TblProduct.Remove(product);
            dB.SaveChanges();
            list();
            MessageBox.Show("Successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void update()
        {
            string id = TxtId.Text;

            if (id == "")
            {
                MessageBox.Show("Id cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int iId = int.Parse(id);
            var product = dB.TblProduct.Find(iId);
            if (product == null)
            {
                MessageBox.Show("There is no such a record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = TxtProductName.Text;
            string stock = TxtStock.Text;
            string buyingPrice = TxtBuyingPrice.Text;
            string sellingPrice = TxtSellingPrice.Text;
            string category = CmbCategory.SelectedValue.ToString();

            if (name == "")
            {
                MessageBox.Show("Name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (stock == "")
            {
                MessageBox.Show("Stock cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (buyingPrice == "")
            {
                MessageBox.Show("BuyingPrice cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sellingPrice == "")
            {
                MessageBox.Show("SellingPrice cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (category == "")
            {
                MessageBox.Show("Category cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            short sStock = short.Parse(stock);
            decimal dBuyingPrice = decimal.Parse(buyingPrice);
            decimal dSellingPrice = decimal.Parse(sellingPrice);
            int iCategory = int.Parse(category);
            product.pName = name;
            product.stock = sStock;
            product.buyingPrice = dBuyingPrice;
            product.sellingPrice = dSellingPrice;
            product.category=iCategory;
            dB.SaveChanges();
            list();
            clear();
            MessageBox.Show("Successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clear()
        {
            TxtId.Clear();
            TxtProductName.Clear();
            TxtStock.Clear();
            TxtBuyingPrice.Clear();
            TxtSellingPrice.Clear();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            list();
            fillCMBCategories();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            avoidCharacter(e);
        }

        private void TxtBuyingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            avoidCharacter(e);
        }

        private void TxtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            avoidCharacter(e);
        }

        private void CmbCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            avoidCharacter(e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Geçerli bir satır kontrolü
            {
                TxtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtProductName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtStock.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtBuyingPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtSellingPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();



                string categoryName = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                var category = dB.TblCategory.FirstOrDefault(c => c.cName == categoryName);

                if (category != null)
                {
                    CmbCategory.SelectedValue = category.Id;
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
