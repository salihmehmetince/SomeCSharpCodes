using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLStudent
    {
        public static int insertStudent(ELStudent student)
        {
            if(student.StudentName=="" && student.StudentName.Length<2&&student.StudentName.Length>30)
            {
                return -1;
            }

            if (student.StudentSurname == "" && student.StudentSurname.Length < 2 && student.StudentSurname.Length > 30)
            {
                return -1;
            }

            if (student.StudentNumber == "" && student.StudentName.Length!=5)
            {
                return -1;
            }

            if (student.StudentDepartment == "" && student.StudentDepartment.Length < 2 && student.StudentDepartment.Length > 30)
            {
                return -1;
            }

            int result=DALStudent.insertStudent(student);
            return result;
        }

        public static List<ELStudent> getStudentList()
        {
            return DALStudent.getStudentList();
        }

        public static int deleteStudent(int Id)
        {
            if(Id>=1)
            {
                return DALStudent.deleteStudent(Id);
            }
            else
            {
                return -1;
            }
        }

        public static int updateStudent(ELStudent student)
        {
            if (student.StudentId<1)
            {
                return -1;
            }
            if (student.StudentName == "" && student.StudentName.Length < 2 && student.StudentName.Length > 30)
            {
                return -1;
            }

            if (student.StudentSurname == "" && student.StudentSurname.Length < 2 && student.StudentSurname.Length > 30)
            {
                return -1;
            }

            if (student.StudentNumber == "" && student.StudentName.Length != 5)
            {
                return -1;
            }

            if (student.StudentDepartment == "" && student.StudentDepartment.Length < 2 && student.StudentDepartment.Length > 30)
            {
                return -1;
            }
            int result = DALStudent.updateStudent(student);
            return result;
        }
    }
}
