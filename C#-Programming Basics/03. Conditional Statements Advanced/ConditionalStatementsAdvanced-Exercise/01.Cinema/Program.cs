using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string filmshow = Console.ReadLine(); //type of film show -> "Premiere", "Normal" or "Discount"
            int row = int.Parse(Console.ReadLine()); //number of rows
            int col = int.Parse(Console.ReadLine()); //number of columns

            // Calculating cinema income if the hall is full:
            double income = 0;

            switch (filmshow)
            {
                case "Premiere":
                    income = row * col * 12.00; break;
                case "Normal":
                    income = row * col * 7.50; break;
                case "Discount":
                    income = row * col * 5.00; break;
            }

            Console.WriteLine("{0:F2} leva", income);
        }
    }
}
