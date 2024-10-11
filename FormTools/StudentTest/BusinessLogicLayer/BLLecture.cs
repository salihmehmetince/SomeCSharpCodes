using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLLecture
    {
        public static int insertLecture(ELLecture lecture)
        {
            if(lecture.LectureName!=null && lecture.LectureName.Length>=3 && lecture.LectureName.Length<=30)
            {
                int result=DALLecture.insertLecture(lecture);
                return result;
            }
            else
            {
                return -1;
            }

        }
    }
}
