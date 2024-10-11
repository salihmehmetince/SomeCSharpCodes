using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ELGrade
    {
        private int gradeId;
        private int studentId;
        private byte lectureId;
        private byte gradeValue;


        public int GradeId
        {
            get { return gradeId; }
            set { gradeId = value; }
        }

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public byte LectureId
        {
            get { return lectureId; }
            set {   lectureId = value; }
        }

        public byte GradeValue
        {
            get { return gradeValue; }
            set { gradeValue = value; }
        }

    }
}
