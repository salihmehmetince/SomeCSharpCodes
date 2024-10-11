using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        private int studentId;
        private string studentName;
        private string studentSurname;
        private string studentNumber;
        private string studentDepartment;

        public int StudentId { 
            get { return studentId; } 
            set { studentId = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public string StudentSurname
        {
            get { return studentSurname; }
            set { studentSurname = value; }
        }

        public string StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }

        public string StudentDepartment
        {
            get { return studentDepartment; }
            set { studentDepartment = value; }
        }

    }
}
