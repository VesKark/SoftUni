using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> allStudents = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] inputStudent = Console.ReadLine().Split();
                string firstName = inputStudent[0];
                string lastName = inputStudent[1]; 
                double grade = double.Parse(inputStudent[2]);

                Student newStudent = new Student(firstName, lastName, grade);
                allStudents.Add(newStudent);
            }

            allStudents = allStudents.OrderByDescending(x => x.Grade).ToList();

            foreach (Student student in allStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
