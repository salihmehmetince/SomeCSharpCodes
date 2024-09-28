using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTest
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createCaptha()
        {
            Random random = new Random();
            string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            int ran1 = random.Next(0, chars.Length);
            int ran2 = random.Next(0, chars.Length);
            int ran3 = random.Next(0, chars.Length);
            int ran4 = random.Next(0, chars.Length);
            int ran5 = random.Next(0, chars.Length);

            string code = new string(new char[] { chars[ran1], chars[ran2], chars[ran3], chars[ran4], chars[ran5] });
            LblCaptha.Text = code;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            createCaptha();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = TxtUserName.Text;
            string password = TxtPassword.Text;
            string code = TxtCode.Text;
            if(userName == "admin" && password=="123"&&code==LblCaptha.Text)
            {
                Form2 form2 = new Form2();
                form2.Username = userName;
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong user name or password","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        int colorValueRed = 0; 
        int colorValueGreen = 0;
        int colorValueBlue = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            colorValueRed++;
            colorValueGreen += 5;
            colorValueBlue += 12;
            if (colorValueRed >= 255)
            {
                colorValueRed = colorValueRed % 255;
            }
            if (colorValueGreen >= 255)
            {
                colorValueGreen = colorValueGreen % 255;
            }
            if (colorValueBlue >= 255)
            {
                colorValueBlue = colorValueBlue % 255;
            }
            lblLoginFormLabel.BackColor =Color.FromArgb(colorValueRed, colorValueGreen,colorValueBlue);

        }
    }
}
