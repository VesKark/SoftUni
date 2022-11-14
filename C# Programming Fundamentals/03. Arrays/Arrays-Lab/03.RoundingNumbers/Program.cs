using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and creat array of double numbers:
            string input = Console.ReadLine();
            double[] numbersToRound = input.Split().Select(double.Parse).ToArray();

            // Round numbers away from zero:
            foreach (double item in numbersToRound)
            {
                int roundedNumber = (int)Math.Round(item, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{item} => {roundedNumber}");
            }
        }
    }
}
