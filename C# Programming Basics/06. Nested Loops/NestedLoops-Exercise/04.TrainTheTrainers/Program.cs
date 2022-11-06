using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int jury = int.Parse(Console.ReadLine()); //number of people in the jury
            string presentation = Console.ReadLine();

            // Estimating average grades:
            double averageForStudent = 0;
            double averageForAll = 0;
            int countPresentations = 0;
            double grades = 0;

            while (presentation != "Finish")
            {
                for (int i = 0; i < jury; i++)
                {
                    grades = double.Parse(Console.ReadLine());
                    averageForStudent += grades;
                }
                Console.WriteLine($"{presentation} - {averageForStudent / jury:F2}.");
                averageForAll += averageForStudent / jury;
                countPresentations++;

                averageForStudent = 0;
                presentation = Console.ReadLine();
            }

            // Output:
            Console.WriteLine($"Student's final assessment is {averageForAll / countPresentations:F2}.");
        }
    }
}
