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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DBProductTestEntities dbProductTestEntities = new DBProductTestEntities();
        private void list()
        {
            //dataGridView1.DataSource = dbProductTestEntities.TblCustomer.ToList();
            var table = from x in dbProductTestEntities.TblCustomer
                        select new {x.customerName,x.customerSurname,x.city,x.balance };
            dataGridView1.DataSource= table.ToList();
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
            var row = dbProductTestEntities.TblCustomer.Find(iId);

            if (row == null)
            {
                MessageBox.Show("There is no such a save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string name = TxtName.Text;
            string surname = TxtSurname.Text;
            string city = TxtCity.Text;
            string balance = TxtBalance.Text;

            if (name == "")
            {
                MessageBox.Show("Name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (surname == "")
            {
                MessageBox.Show("Surname cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (city == "")
            {
                MessageBox.Show("City cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (balance == "")
            {
                MessageBox.Show("Balance cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal iBalance = decimal.Parse(balance);
            row.customerName = name;
            row.customerSurname=surname;
            row.city = city;
            row.balance = iBalance;
            dbProductTestEntities.SaveChanges();
            list();
            MessageBox.Show("Successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void save()
        {
            string name=TxtName.Text;
            string surname = TxtSurname.Text;
            string city=TxtCity.Text;
            string balance = TxtBalance.Text;

            if(name=="")
            {
                MessageBox.Show("Name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (surname == "")
            {
                MessageBox.Show("Surname cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (city == "")
            {
                MessageBox.Show("City cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (balance == "")
            {
                MessageBox.Show("Balance cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal iBalance = decimal.Parse(balance);
            TblCustomer customer = new TblCustomer();
            customer.customerName=name; 
            customer.customerSurname=surname;
            customer.city = city;
            customer.balance = iBalance;
            dbProductTestEntities.TblCustomer.Add(customer);
            dbProductTestEntities.SaveChanges();
            list();
            MessageBox.Show("Successfully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void delete()
        {
            string id = TxtId.Text;
            if(id=="")
            {
                MessageBox.Show("Id cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int iId = int.Parse(id);
            var row = dbProductTestEntities.TblCustomer.Find(iId);

            if(row==null)
            {
                MessageBox.Show("There is no such a save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbProductTestEntities.TblCustomer.Remove(row);
            dbProductTestEntities.SaveChanges();
            list();
            MessageBox.Show("Successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            list();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
