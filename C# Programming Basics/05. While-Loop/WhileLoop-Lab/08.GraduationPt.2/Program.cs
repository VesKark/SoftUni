using System;

namespace _08.GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int finishedClasses = 0;
            int countFailedClasses = 0;
            double sumGrades = 0;

            while (finishedClasses != 12)
            {
                finishedClasses++;
                double yearGrade = double.Parse(Console.ReadLine());

                if (yearGrade < 4)
                {
                    countFailedClasses++;
                    if (countFailedClasses == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {finishedClasses - 1} grade");
                        break;
                    }
                }
                else
                {
                    sumGrades += yearGrade;
                }
            }

            if (finishedClasses == 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sumGrades / 12:F2}");
            }
        }
    }
}
