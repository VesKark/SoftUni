using System;

namespace _02.RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine()); // radians
            double deg = rad * 180 / Math.PI; // degrees

            Console.WriteLine(Math.Round(deg));
        }
    }
}
