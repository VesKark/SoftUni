using System;

namespace _08.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int judgesCount = int.Parse(Console.ReadLine());

            string judgeName = string.Empty;
            double judgePoint = 0;
            double result = academyPoints;

            // Estimating points:
            for (int i = 0; i < judgesCount; i++)
            {
                judgeName = Console.ReadLine();
                judgePoint = double.Parse(Console.ReadLine());

                result += judgeName.Length * judgePoint / 2;
                if (result > 1250.5)
                {
                    break;
                }
            }

            // Output result:
            if (result > 1250.5)        
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {result:F1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - result:F1} more!");
            }
        }
    }
}
