using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipherTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            string data=TxtData.Text;

            char[] characters=data.ToCharArray();
            string encryptedData = "";
            foreach (char c in characters)
            {
                encryptedData+=((char)(c+3)).ToString();
            }
            TxtEncryptedData.Text = encryptedData;
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedData=TxtEncryptedData.Text;
            char[] characters=encryptedData.ToCharArray();
            string data = "";
            foreach(char c in characters)
            {
                data+=((char)(c-3)).ToString();
            }
            TxtData.Text = data;
        }
    }
}
