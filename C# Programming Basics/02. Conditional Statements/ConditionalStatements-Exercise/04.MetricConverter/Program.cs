using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double length = double.Parse(Console.ReadLine()); //length
            string unit = Console.ReadLine(); //input unit for length
            string unitConverted = Console.ReadLine(); //converted unit for length

            if (unit == unitConverted)
            {
                Console.WriteLine($"{length:F3}");
            }

            else if (unit == "m")
            {
                if (unitConverted == "cm")
                {
                    Console.WriteLine($"{length * 100:F3}");
                }
                else if (unitConverted == "mm")
                {
                    Console.WriteLine($"{length * 1000:F3}");
                }
            }

            else if (unit == "cm")
            {
                if (unitConverted == "m")
                {
                    Console.WriteLine($"{length / 100:F3}");
                }
                else if (unitConverted == "mm")
                {
                    Console.WriteLine($"{length * 10:F3}");
                }
            }

            else if (unit == "mm")
            {
                if (unitConverted == "m")
                {
                    Console.WriteLine($"{length / 1000:F3}");
                }
                else if (unitConverted == "cm")
                {
                    Console.WriteLine($"{length / 10:F3}");
                }
            }
        }
    }
}
