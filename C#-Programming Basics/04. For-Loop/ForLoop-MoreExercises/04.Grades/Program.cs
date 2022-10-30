using System;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int students = int.Parse(Console.ReadLine()); //number of students at the exam

            // Estimating the average grade and range:
            double totalGrade = 0;

            double percentTopStudents = 0;
            double percent4to5 = 0;
            double percent3to4 = 0;
            double percent2to3 = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine()); //grade at the exam
                totalGrade += grade;

                if (grade >= 2.00 && grade <= 2.99)
                {
                    percent2to3++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    percent3to4++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    percent4to5 ++;
                }
                else if (grade >= 5.00)
                {
                    percentTopStudents++;
                }
            }

            // Output:
            Console.WriteLine($"Top students: {percentTopStudents * 100 / students:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percent4to5 * 100 / students:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percent3to4 * 100 / students:F2}%");
            Console.WriteLine($"Fail: {percent2to3 * 100 / students:F2}%");
            Console.WriteLine($"Average: {totalGrade / students:F2}");
        }
    }
}
