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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void insertStudent()
        {
            ELStudent student = new ELStudent();
            string studentName = TxtStudentName.Text;
            string studentSurname = TxtStudentSurname.Text;
            string studentNumber = MTBStudentNumber.Text;
            string studentDepartment = TxtStudentDepartment.Text;
            student.StudentName= studentName;
            student.StudentSurname= studentSurname;
            student.StudentNumber= studentNumber;
            student.StudentDepartment= studentDepartment;

            int result=BusinessLogicLayer.BLStudent.insertStudent(student);

            if(result==-1)
            {
                MessageBox.Show("An error occured", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Successfully inserted", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            list();

        }

        private void list()
        {
            dataGridView1.DataSource = BLStudent.getStudentList();
        }

        private void delete()
        {
            string Id=TxtStudentId.Text;
            if(Id=="")
            {
                MessageBox.Show("Id cannot be empty", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int iId=int.Parse(Id);

            int result=BLStudent.deleteStudent(iId);

            if(result==-1)
            {
                MessageBox.Show("An error occured", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {
                MessageBox.Show("Successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
            }
        }

        private void BtnStudentInsert_Click(object sender, EventArgs e)
        {
            insertStudent();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            list();
        }

        private void BtnStudentList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void BtnStudentDelete_Click(object sender, EventArgs e)
        {
            delete();
        }
    }
}
