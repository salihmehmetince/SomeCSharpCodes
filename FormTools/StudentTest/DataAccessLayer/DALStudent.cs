using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALStudent
    {
        public static int insertStudent(ELStudent student)
        {
            if (Connection.connection.State != System.Data.ConnectionState.Open)
            {
                Connection.connection.Open();
            }

            SqlCommand commandInsert = new SqlCommand("insert into TblStudent values(@p1,@p2,@p3,@p4)",Connection.connection);
            commandInsert.Parameters.AddWithValue("@p1",student.StudentName);
            commandInsert.Parameters.AddWithValue("@p2",student.StudentSurname);
            commandInsert.Parameters.AddWithValue("@p3",student.StudentNumber);
            commandInsert.Parameters.AddWithValue("@p4",student.StudentDepartment);
            int result = commandInsert.ExecuteNonQuery();

            if (Connection.connection.State == System.Data.ConnectionState.Open)
            {
                Connection.connection.Close();
            }
            return result;
        }

        public static List<ELStudent> getStudentList()
        {
            if (Connection.connection.State != System.Data.ConnectionState.Open)
            {
                Connection.connection.Open();
            }

            SqlCommand commandGetStudent = new SqlCommand("select * from TblStudent",Connection.connection);
            SqlDataReader reader = commandGetStudent.ExecuteReader();
            List<ELStudent> studentList = new List<ELStudent>();
            while(reader.Read())
            {
                ELStudent student = new ELStudent();
                student.StudentId = int.Parse(reader[0].ToString());
                student.StudentName = reader[1].ToString();
                student.StudentSurname = reader[2].ToString();
                student.StudentNumber = reader[3].ToString();
                student.StudentDepartment =reader[4].ToString();
                studentList.Add(student);
            }

            reader.Close();

            if(Connection.connection.State==System.Data.ConnectionState.Open)
            {
                Connection.connection.Close();
            }

            return studentList;
        }

        public static int deleteStudent(int Id)
        {
            if (Connection.connection.State != System.Data.ConnectionState.Open)
            {
                Connection.connection.Open();
            }

            SqlCommand commandDelete = new SqlCommand("delete from TblStudent where studentId=@p1", Connection.connection);
            commandDelete.Parameters.AddWithValue("@p1", Id);
            int result = commandDelete.ExecuteNonQuery();
            if (Connection.connection.State == System.Data.ConnectionState.Open)
            {
                Connection.connection.Close();
            }

            return result;
        }
    }
}
