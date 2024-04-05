using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menyu.task
{
    internal class Group
    {
        public string GroupNo { get; set; }
        public int _studentlimit;
        private int StudentLimit
        {
            get
            {
                return _studentlimit;
            } set
            {
                if (value > 5 && value < 18)
                {
                    StudentLimit = value;
                }
            }
        }
        public Group(string groupNo, int studentlimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentlimit;
        }
        private Student[] student = new Student[0] { };
        private object[] Students;

        public bool CheckGroupNo(string groupNo)
        {
            if( groupNo.Length == 5 && Char.IsUpper(groupNo[0]) && Char.IsUpper(groupNo[1]) && Char.IsDigit(groupNo[2]) && Char.IsDigit(groupNo[3]) && Char.IsDigit(groupNo[4]))
            {
                return true;
            }else

            {
                return false;
            };

        }
         public bool AddStudent(Student student)
        {
            if (Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
                return true;
            }
            else
            {
                return false;
            }

        }
        public Student[] GetAllStudents()
        {
            return (Student[])Students;
        }

    }
}

 
