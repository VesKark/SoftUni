using System;

namespace _08.SecretDoor_sLock
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int upperA = int.Parse(Console.ReadLine());
            int upperB = int.Parse(Console.ReadLine());
            int upperC = int.Parse(Console.ReadLine());

            // Generating combinations:
            bool isPrime = true;
            for (int a = 1; a <= upperA; a++)
            {
                for (int b = 2; b <= upperB; b++)
                {
                    for (int c = 1; c <= upperC; c++)
                    {
                        isPrime = b == 2 || b == 3 || b == 5 || b == 7;

                        if (a % 2 == 0 && c % 2 == 0 && isPrime)
                        {
                            Console.WriteLine($"{a} {b} {c}");
                        }
                    }
                }
            }
        }
    }
}
