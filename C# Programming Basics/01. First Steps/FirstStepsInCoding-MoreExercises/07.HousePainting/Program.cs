using System;

namespace _07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input - house dimensions:
            double heightHouse = double.Parse(Console.ReadLine()); //house height == house width
            double lengthHouse = double.Parse(Console.ReadLine());
            double heightRoof = double.Parse(Console.ReadLine());

            // Other dimensions:
            double door = 1.2 * 2.0; //1 door
            double windows = 1.5 * 1.5 * 2; //2 windows

            // House area:
            double walls = 2 * heightHouse * (heightHouse + lengthHouse) - door - windows;
            double roof = 2 * (heightHouse * lengthHouse) + 2 * (heightRoof * heightHouse / 2);

            // Paint quantity:
            double greenPaint = walls / 3.4; //green paint for the walls in Liter
            double redPaint = roof / 4.3; //red paint for the roof in Liter

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
