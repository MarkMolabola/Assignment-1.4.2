using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._4._2
{
    internal class Student
    {
      
            private int studentId;
            private string studentFirstName;
            private string studentLastName;
            private char studentGrade;

            public Student(int studentid, string firstname, string lastname, char grade) //constructor
            {
                studentId = studentid;
                studentFirstName = firstname;
                studentLastName = lastname;
                studentGrade = grade;
            }
            public int StudentId
            {
                get { return studentId; }
                set { studentId = value; }
            }
            public string StudentFirstName
            {
                get { return studentFirstName; }
                set { studentFirstName = value; }
            }
            public string StudentLastName
            {
                get { return studentLastName; }
                set { studentLastName = value; }
            }
            public char StudentGrade
            {
                get { return studentGrade; }
                set { studentGrade = value; }
            }
        
    }
}
