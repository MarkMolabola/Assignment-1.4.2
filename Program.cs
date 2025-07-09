using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Assignment_1._4._2
{

    //Write a class: “Student” with private data members: StudentId(int), StudentFname(string), StudentLname(string ), StudentGrade(char )
    //and public properties for each data member.Instantiate the class and assign data to properties.Display the data back on console.

    internal class Program
    {
       
        static void Main(string[] args)
        {
            Student student = new Student(10141, "Mark", "Molabola", 'A');
            Console.WriteLine("Student Details:");
            Console.WriteLine("Student Id: " + student.StudentId);
            Console.WriteLine("Student FirstName: " + student.StudentFirstName);
            Console.WriteLine("Student Lastname: " + student.StudentLastName);
            Console.WriteLine("Student Grade: " + student.StudentGrade);
            Console.WriteLine("--------------------------------------------");
        }

    }
}
