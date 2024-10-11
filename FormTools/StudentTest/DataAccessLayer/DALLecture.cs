using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALLecture
    {
        public static int insertLecture(ELLecture lecture)
        {
            if (Connection.connection.State != System.Data.ConnectionState.Open)
            {
                Connection.connection.Open();
            }

            SqlCommand commandInsert = new SqlCommand("insert into TblLecture values(@p1)",Connection.connection);
            commandInsert.Parameters.AddWithValue("@p1", lecture.LectureName);
            int result=commandInsert.ExecuteNonQuery();

            if (Connection.connection.State == System.Data.ConnectionState.Open)
            {
                Connection.connection.Close();
            }
            return result;
        }
    }
}
