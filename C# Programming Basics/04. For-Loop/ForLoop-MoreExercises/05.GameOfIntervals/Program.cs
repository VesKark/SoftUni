using System;

namespace _05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int moves = int.Parse(Console.ReadLine());

            // Calculating points:
            double finalResult = 0;

            double percent0To9 = 0;
            double percent10To19 = 0;
            double percent20To29 = 0;
            double percent30To39 = 0;
            double percent40To50 = 0;
            double percentInvalid = 0;

            for (int i = 0; i < moves; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0 || number > 50)
                {
                    finalResult /= 2;
                    percentInvalid++;
                }
                else if (number < 10)
                {
                    finalResult += number * 0.20;
                    percent0To9++;
                }
                else if (number < 20)
                {
                    finalResult += number * 0.30;
                    percent10To19++;
                }
                else if (number < 30)
                {
                    finalResult += number * 0.40;
                    percent20To29++;
                }
                else if (number < 40)
                {
                    finalResult += 50;
                    percent30To39++;
                }
                else if (number <= 50)
                {
                    finalResult += 100;
                    percent40To50++;
                }
            }

            // Output:
            Console.WriteLine($"{finalResult:F2}");
            Console.WriteLine($"From 0 to 9: {percent0To9 * 100 / moves:F2}%");
            Console.WriteLine($"From 10 to 19: {percent10To19 * 100 / moves:F2}%");
            Console.WriteLine($"From 20 to 29: {percent20To29 * 100 / moves:F2}%");
            Console.WriteLine($"From 30 to 39: {percent30To39 * 100 / moves:F2}%");
            Console.WriteLine($"From 40 to 50: {percent40To50 * 100 / moves:F2}%");
            Console.WriteLine($"Invalid numbers: {percentInvalid * 100 / moves:F2}%");
        }
    }
}
