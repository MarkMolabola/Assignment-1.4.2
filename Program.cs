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
            //Student student0 = new Student(10141, "Mark", "Molabola", 'A'); //assign using constructor
            Student student0 = new ();
            //Assigning values to properties
            student0.StudentId = 10141;
            student0.StudentFirstName = "Mark";
            student0.StudentLastName = "Molabola";
            student0.StudentGrade = 'A';
           
            Console.WriteLine("Student Details:");
            Console.WriteLine("Student Id: " + student0.StudentId);
            Console.WriteLine("Student FirstName: " + student0.StudentFirstName);
            Console.WriteLine("Student Lastname: " + student0.StudentLastName);
            Console.WriteLine("Student Grade: " + student0.StudentGrade);
            Console.WriteLine("--------------------------------------------");

            //Student[] students = new Student[5];




        }

    }
}
