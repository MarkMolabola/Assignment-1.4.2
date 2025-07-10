using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._4._2
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public char StudentGrade { get; set; }
        public Student(int studentid, string firstname, string lastname, char grade) //constructor
        {
            StudentId = studentid;
            StudentFirstName = firstname;
            StudentLastName = lastname;
            StudentGrade = grade;
        }

    }
}
