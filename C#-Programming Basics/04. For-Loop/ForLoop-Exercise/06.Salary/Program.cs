using System;

namespace _06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int tabs = int.Parse(Console.ReadLine()); //number of open browser-tabs
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < tabs; i++)
            {
                string webpage = Console.ReadLine();
                switch (webpage)
                {
                    case "Facebook": salary -= 150.00; break;
                    case "Instagram": salary -= 100.00; break;
                    case "Reddit": salary -= 50.00; break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }

            // Output:
            Console.WriteLine($"{salary:F0}");
        }
    }
}
