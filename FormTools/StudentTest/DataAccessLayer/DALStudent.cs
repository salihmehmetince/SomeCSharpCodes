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
    }
}
