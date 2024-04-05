using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menyu.task
{
    internal class Student
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public double Point { get; set; }
        public Student(string id,string fullname,double point)
        {
            Id= id;
            FullName= fullname;
            Point= point;
        }
    }
}
