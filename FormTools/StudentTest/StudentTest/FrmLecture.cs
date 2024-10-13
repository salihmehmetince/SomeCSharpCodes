using BusinessLogicLayer;
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

        private void list()
        {
            List<ELLecture> lectureList=BLLecture.getLectureList();
            dataGridView1.DataSource = lectureList;
        }

        private void delete()
        {
            string Id = TxtLectureId.Text;
            if (Id == "")
            {
                MessageBox.Show("Id cannot be empty", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte bId = Byte.Parse(Id);
            int result = BLLecture.deleteLecture(bId);
            if (result != -1)
            {
                MessageBox.Show("Successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Id cannot be negative", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            list();
        }

        private void update()
        {
            string lectureId = TxtLectureId.Text;
            string lectureName = TxtLectureName.Text;

            if(lectureId=="")
            {
                MessageBox.Show("Id cannot be empty", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lectureName == "")
            {
                MessageBox.Show("Lecture name cannot be empty", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte bLectureId=byte.Parse(lectureId);
            ELLecture lecture = new ELLecture();
            lecture.LectureId = bLectureId;
            lecture.LectureName=lectureName;
            int result=BLLecture.updateLecture(lecture);

            if(result==-1)
            {
                MessageBox.Show("An error occurred", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                MessageBox.Show("Successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
            }
        }

        private void colorDatagridview()
        {
            dataGridView1.DefaultCellStyle.BackColor = Color.Green;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
        }
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            insertLecture();
        }

        private void FrmLecture_Load(object sender, EventArgs e)
        {
            list();
            colorDatagridview();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
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
