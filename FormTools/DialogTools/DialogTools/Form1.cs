using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFBD_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                LblFBD.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BtnOFD_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LblOFD.Text = openFileDialog1.FileName;
            }
        }

        private void BtnSFD_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void BtnChooseLocation_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                LblFolderPath.Text=folderBrowserDialog1.SelectedPath;
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string fileName = LblFolderPath.Text + "\\" + TxtFileName.Text + ".txt";
            StreamWriter streamWriter = File.CreateText(fileName);
            MessageBox.Show("The file created", "information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);

                string text=streamReader.ReadToEnd();
                listBox1.Items.Add(text);
            }
        }

        private void BtnWriteFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File |*.txt| Word File |*.docx";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                streamWriter.Write(richTextBox1.Text);
                MessageBox.Show("The Data saved", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                streamWriter.Close();
            }
        }
    }
}
