using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ELLecture
    {
        private byte lectureId;
        private string lectureName;

        public byte LectureId { get { return lectureId; } set { lectureId = value; } }
        public string LectureName { get { return lectureName; } set { lectureName = value; } }
    }
}
