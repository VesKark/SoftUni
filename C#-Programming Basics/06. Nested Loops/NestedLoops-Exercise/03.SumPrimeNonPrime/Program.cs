using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string input = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;
            int counter = 0;

            // Checking numbers:
            while (input != "stop")
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                else if (number <= 1)
                {
                    sumNonPrime += number;
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        counter++;
                    }
                }

                if (counter > 2)
                {
                    sumNonPrime += number;                    
                }
                else
                {
                    sumPrime += number;
                }

                counter = 0;
                input = Console.ReadLine();
            }

            // Output:
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
