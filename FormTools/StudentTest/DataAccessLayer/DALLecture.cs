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

        public static List<ELLecture> getlecture()
        {
            List<ELLecture> lectureList=new List<ELLecture>();
            SqlCommand commandGetLecture = new SqlCommand("select * from TblLecture",Connection.connection);
            if (Connection.connection.State != System.Data.ConnectionState.Open)
            {
                Connection.connection.Open();
            }

            SqlDataReader reader=commandGetLecture.ExecuteReader();
            while (reader.Read())
            {
                ELLecture lecture = new ELLecture();
                lecture.LectureId = byte.Parse(reader["lectureId"].ToString());
                lecture.LectureName = reader["lectureName"].ToString();
                lectureList.Add(lecture);
            }

            reader.Close();

            if (Connection.connection.State == System.Data.ConnectionState.Open)
            {
                Connection.connection.Close();
            }
            return lectureList;
        }

        public static int deleteLecture(byte Id)
        {
            if (Connection.connection.State != System.Data.ConnectionState.Open)
            {
                Connection.connection.Open();
            }

            SqlCommand commandDelete = new SqlCommand("delete from TblLecture where lectureId=@p1", Connection.connection);
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
