using System;

namespace _04.CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            // Generating car numbers:
            bool condition1 = true;
            bool condition2 = true;

            for (int one = start; one <= end; one++)
            {
                for (int two = start; two <= end; two++)
                {
                    for (int three = start; three <= end; three++)
                    {
                        for (int four = start; four <= end; four++)
                        {
                            if (one > four && (two + three) % 2 == 0)
                            {
                                condition1 = one % 2 == 0 && four % 2 != 0;
                                condition2 = one % 2 != 0 && four % 2 == 0;
                                if (condition1 || condition2)
                                {
                                    Console.Write($"{one}{two}{three}{four} ");
                                }                                
                            }
                        }
                    }
                }
            }
        }
    }
}
