using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace QRTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnQrCreate_Click(object sender, EventArgs e)
        {
            string data=TxtData.Text;
            if(data=="")
            {
                MessageBox.Show("Data cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QRCodeEncoder encoder = new QRCodeEncoder();
            pictureBox1.Image=encoder.Encode(data);
        }

        private void BtnDecode_Click(object sender, EventArgs e)
        {
            string data = "";
            if(pictureBox1.Image!=null)
            {
                QRCodeDecoder decoder = new QRCodeDecoder();
                data = decoder.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
            }
            else
            {
                MessageBox.Show("Picture cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TxtData.Text=data;
        }
    }
}
