using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] newStudent = input.Split();

                Student currStudent = new Student();
                currStudent.FirstName = newStudent[0];
                currStudent.LastName = newStudent[1];
                currStudent.Age = int.Parse(newStudent[2]);
                currStudent.Hometown = newStudent[3];

                allStudents.Add(currStudent);
            }

            string cityName = Console.ReadLine();

            List<Student> studentsSorted = allStudents.Where(x => x.Hometown == cityName).ToList();

            foreach (Student student in studentsSorted)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
