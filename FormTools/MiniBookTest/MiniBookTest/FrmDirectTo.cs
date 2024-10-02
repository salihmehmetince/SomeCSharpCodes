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
    public partial class FrmDirectTo : Form
    {
        public FrmDirectTo()
        {
            InitializeComponent();
        }

        private void FrmDirectTo_Load(object sender, EventArgs e)
        {

        }

        private void BtnProductTransactions_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct();
            frmProduct.Show();
        }

        private void BtnCategoryTransactions_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            FrmStatistics frmStatistics = new FrmStatistics();
            frmStatistics.Show();
        }

        private void BtnCharts_Click(object sender, EventArgs e)
        {
            FrmCharts frmCharts = new FrmCharts();
            frmCharts.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin =new FrmAdmin();
            frmAdmin.Show();
            this.Hide();
        }
    }
}
