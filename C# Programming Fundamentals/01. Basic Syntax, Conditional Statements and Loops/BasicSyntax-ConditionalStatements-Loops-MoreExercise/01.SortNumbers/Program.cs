using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input three numbers:
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());
            double numC = double.Parse(Console.ReadLine());

            // Sorting numbers:
            if (numA > numB && numA > numC)
            {
                Console.WriteLine(numA);
                if (numB > numC)
                {
                    Console.WriteLine(numB);
                    Console.WriteLine(numC);
                }
                else
                {
                    Console.WriteLine(numC);
                    Console.WriteLine(numB);
                }
            }
            else if (numB > numA && numB > numC)
            {
                Console.WriteLine(numB);
                if (numA > numC)
                {
                    Console.WriteLine(numA);
                    Console.WriteLine(numC);
                }
                else
                {
                    Console.WriteLine(numC);
                    Console.WriteLine(numA);
                }
            }
            else if (numC > numA && numC > numB)
            {
                Console.WriteLine(numC);
                if (numA > numB)
                {
                    Console.WriteLine(numA);
                    Console.WriteLine(numB);
                }
                else
                {
                    Console.WriteLine(numB);
                    Console.WriteLine(numA);
                }
            }
        }
    }
}
