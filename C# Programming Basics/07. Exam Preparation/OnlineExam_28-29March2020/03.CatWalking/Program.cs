using System;

namespace _03.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int walkMin = int.Parse(Console.ReadLine()); //minutes of walk per day
            int walkNr = int.Parse(Console.ReadLine()); //number of walks per day
            int caloryEat = int.Parse(Console.ReadLine()); //eaten calories per day

            // Estimating if the walking time was enough or not:
            int caloryWalk = walkNr * walkMin * 5; //5 calories per minute walk

            if (caloryWalk >= caloryEat * 0.50)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloryWalk}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloryWalk}.");
            }
        }
    }
}
