using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_1._1._4
{

    //Write a class: “Student” with private data members: StudentId(int), StudentFname(string), StudentLname(string ), StudentGrade(char )
    //and public properties for each data member.Instantiate the class and assign data to properties.Display the data back on console.

    internal class Program
    {
        struct Student
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
        static void Main(string[] args)
        {
            Student student = new Student(10141, "Mark", "Molabola", 'A');
            Console.WriteLine("Student Details:");
            Console.WriteLine("Student Id: " + student.StudentId);
            Console.WriteLine("Student FirstName: " + student.StudentFirstName);
            Console.WriteLine("Student Lastname: " + student.StudentLastName);
            Console.WriteLine("Student Grade: " + student.StudentGrade);

        }
    }
}
