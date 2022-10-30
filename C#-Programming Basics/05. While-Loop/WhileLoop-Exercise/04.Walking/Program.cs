using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps = "";
            int stepsSum = 0;

            while (stepsSum < 10000)
            {
                steps = Console.ReadLine();
                if (steps == "Going home")
                {
                    stepsSum += int.Parse(Console.ReadLine());
                    break;
                }
                else
                {
                    stepsSum += int.Parse(steps);
                }                
            }

            if (stepsSum < 10000)
            {
                Console.WriteLine($"{10000 - stepsSum} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsSum - 10000} steps over the goal!");
            }
        }
    }
}
