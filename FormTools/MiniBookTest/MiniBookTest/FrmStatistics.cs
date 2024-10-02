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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-NA57A1V\SQLEXPRESS;Initial Catalog=DBProductTest;Integrated Security=True");

        private void findCategoryCount()
        {
            connection.Open();
            SqlCommand commandCategoryCount = new SqlCommand("select count(*) from TblCategory", connection);
            SqlDataReader reader = commandCategoryCount.ExecuteReader();
            while(reader.Read())
            {
                LblCategoryCount.Text = reader[0].ToString();
            }
            connection.Close();
        }

        private void findProductCount()
        {
            connection.Open();
            SqlCommand commandCategoryCount = new SqlCommand("select count(*) from TblProduct", connection);
            SqlDataReader reader = commandCategoryCount.ExecuteReader();
            while (reader.Read())
            {
                LblProductAmount.Text = reader[0].ToString();
            }
            connection.Close();
        }

        private void findMaxStockCount()
        {
            connection.Open();
            SqlCommand commandMaxStockCount = new SqlCommand("select pName from TblProduct where stock=(select max(stock) from TblProduct)", connection);
            SqlDataReader reader = commandMaxStockCount.ExecuteReader();
            while (reader.Read())
            {
                LblMaxCountProduct.Text = reader[0].ToString();
            }
            connection.Close();
        }

        private void findMinStockCount()
        {
            connection.Open();
            SqlCommand commandMinStockCount = new SqlCommand("select pName from TblProduct where stock=(select min(stock) from TblProduct)", connection);
            SqlDataReader reader = commandMinStockCount.ExecuteReader();
            while (reader.Read())
            {
                LblMinStockproduct.Text = reader[0].ToString();
            }
            connection.Close();
        }

        private void findWhiteGoodsCount()
        {
            connection.Open();
            SqlCommand commandWhiteGoods = new SqlCommand("select count(*) from TblProduct where category=(select Id from TblCategory where cName='White Goods')", connection);
            SqlDataReader reader = commandWhiteGoods.ExecuteReader();
            while (reader.Read())
            {
                LblWhiteGoodsCount.Text = reader[0].ToString();
            }
            connection.Close();
        }

        private void findSmallHouseHoldAppliencesCount()
        {
            connection.Open();
            SqlCommand commandSmallHHA = new SqlCommand("select count(*) from TblProduct where category=(select Id from TblCategory where cName='Small Household Appliances')", connection);
            SqlDataReader reader = commandSmallHHA.ExecuteReader();
            while (reader.Read())
            {
                LblSmallHHA.Text = reader[0].ToString();
            }
            connection.Close();
        }

        private void findLaptopProfit()
        {
            connection.Open();
            SqlCommand commandLaptopProfit = new SqlCommand("select stock*(sellingPrice-buyingPrice) from TblProduct where pName='Laptop'", connection);
            SqlDataReader reader = commandLaptopProfit.ExecuteReader();
            while (reader.Read())
            {
                LblLaptopProfit.Text = reader[0].ToString();
            }
            connection.Close();
        }

        private void findWhiteGoodsProfit()
        {
            connection.Open();
            SqlCommand commandWhiteGoodsProfit = new SqlCommand("select sum(stock*(sellingprice-buyingPrice)) from TblProduct where category=(select Id from TblCategory where cName='White Goods')", connection);
            SqlDataReader reader = commandWhiteGoodsProfit.ExecuteReader();
            while (reader.Read())
            {
                LblWhiteGoodsProfit.Text = reader[0].ToString();
            }
            connection.Close();
        }
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            findCategoryCount();
            findProductCount();
            findMaxStockCount();
            findMinStockCount();
            findWhiteGoodsCount();
            findSmallHouseHoldAppliencesCount();
            findLaptopProfit();
            findWhiteGoodsProfit();
        }
    }
}
