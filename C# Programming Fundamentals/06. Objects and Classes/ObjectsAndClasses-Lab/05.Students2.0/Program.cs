using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.Students2._0
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
                string currStudentFirstName = newStudent[0];
                string currStudentLastName = newStudent[1];
                int currStudentAge = int.Parse(newStudent[2]);
                string currStudentHometown = newStudent[3];

                Student currStudent = new Student(currStudentFirstName, currStudentLastName, currStudentAge, currStudentHometown);
                bool changeStudentAgeAndHometown = false;

                foreach (Student student in allStudents)
                {
                    if (student.FirstName == currStudent.FirstName && student.LastName == currStudent.LastName)
                    {
                        student.Age = currStudent.Age;
                        student.Hometown = currStudent.Hometown;
                        changeStudentAgeAndHometown = true;
                        break;
                    }
                }

                if (!changeStudentAgeAndHometown)
                {
                    allStudents.Add(currStudent);
                }    

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

        public Student(string firstName, string lastName, int age, string hometown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Hometown = hometown;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}