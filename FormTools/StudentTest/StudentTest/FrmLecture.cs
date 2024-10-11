using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTest
{
    public partial class FrmLecture : Form
    {
        public FrmLecture()
        {
            InitializeComponent();
        }

        private void insertLecture()
        {
            ELLecture lecture = new ELLecture();

            string lectureName = TxtLectureName.Text;
            if(lectureName=="")
            {
                MessageBox.Show("Lecture name cannot be empty","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            lecture.LectureName = TxtLectureName.Text;

            int result=BusinessLogicLayer.BLLecture.insertLecture(lecture);

            if(result==-1)
            {
                MessageBox.Show("Lecture lenght must be between 3-40", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Lecture successfully inserted","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            insertLecture();
        }
    }
}
