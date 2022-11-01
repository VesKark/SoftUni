using System;

namespace _04.InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double factor = 2.54;
            double centimeter = inch * factor;

            Console.WriteLine(centimeter);
        }
    }
}
