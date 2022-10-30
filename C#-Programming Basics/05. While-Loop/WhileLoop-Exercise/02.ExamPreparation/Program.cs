using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int lowGrades = int.Parse(Console.ReadLine()); //number of allowed low grades

            int countLowGrades = 0;
            string task = Console.ReadLine();
            string lastTask = "";
            double grade = 0;
            double gradeSum = 0;
            int countGrades = 0;            

            // Checking grades:
            while (task != "Enough")
            {
                grade = double.Parse(Console.ReadLine());
                gradeSum += grade;
                countGrades++;                

                if (grade <= 4)
                {
                    countLowGrades++;
                    if (countLowGrades == lowGrades)
                    {
                        break;
                    }
                }
                lastTask = task;
                task = Console.ReadLine();                
            }

            // Output:
            if (task == "Enough")
            {
                Console.WriteLine($"Average score: {gradeSum / countGrades:F2}");
                Console.WriteLine($"Number of problems: {countGrades}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
            else
            {
                Console.WriteLine($"You need a break, {lowGrades} poor grades.");
            }

        }
    }
}
