using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductTrackingTest
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        DBProductTestEntities dbProductTestEntities = new DBProductTestEntities();
        private void customerCount()
        {
            LblCustomerCount.Text = dbProductTestEntities.TblCustomer.Count().ToString();
        }

        private void productCount()
        {
            LblProductCount.Text = dbProductTestEntities.TblProduct.Count().ToString();
        }

        private void categoryCount()
        {
            LblCategoryCount.Text = dbProductTestEntities.TblCategory.Count().ToString();
        }

        private void whiteGoodsCount()
        {
            LblWhiteGoodsCount.Text = dbProductTestEntities.TblProduct.Count(x=>x.category==1).ToString();
        }

        private void totalStockCount()
        {
            LblTotalStockCount.Text = dbProductTestEntities.TblProduct.Sum(x => x.stock).ToString();
        }

        private void todaysTotalSaleCount()
        {
            DateTime today = DateTime.Today;
            LblTodaysSaleCount.Text = dbProductTestEntities.TblSales.Count(x=>x.saleDate==today).ToString();
        }

        private void safeTotal()
        {
            LblSafeTotal.Text = dbProductTestEntities.TblSales.Sum(x=>x.total).ToString();
        }

        private void todaysSafeTotal()
        {
            DateTime today = DateTime.Today;
            LblTodaysSafeTotal.Text = dbProductTestEntities.TblSales.Where(x => x.saleDate == today).Sum(y => y.total).ToString();
        }

        private void mostExpensiveProduct()
        {
            /*var maxPrice = dbProductTestEntities.TblProduct.Max(y => y.sellingPrice);
            var mostExpensiveProduct = dbProductTestEntities.TblProduct.FirstOrDefault(x => x.sellingPrice == maxPrice);
            LblMostExpensiveProduct.Text = mostExpensiveProduct.pName; // Ürünün adı*/
            LblMostExpensiveProduct.Text=(from x in dbProductTestEntities.TblProduct
                                          orderby x.sellingPrice descending
                                          select x.pName).FirstOrDefault(); 

        }

        private void cheapestProduct()
        {
            LblCheapestProduct.Text=(from x in dbProductTestEntities.TblProduct orderby x.sellingPrice ascending
                                     select x.pName).FirstOrDefault();

        }

        private void mostStockedProduct()
        {
            LblMostStockedProduct.Text=(from x in dbProductTestEntities.TblProduct orderby x.stock descending
                                        select x.pName).FirstOrDefault().ToString();

        }

        private void leastStockedProduct()
        {
            LblLeastStockedProduct.Text=(from x in dbProductTestEntities.TblProduct orderby x.stock ascending
                                        select x.pName).FirstOrDefault().ToString();
        }
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            customerCount();
            categoryCount();
            productCount();
            whiteGoodsCount();
            totalStockCount();
            todaysTotalSaleCount();
            safeTotal();
            todaysSafeTotal();
            mostExpensiveProduct();
            cheapestProduct();
            mostStockedProduct();
            leastStockedProduct();
        }
    }
}
