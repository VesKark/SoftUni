using System;

namespace _08.MathPower_Recursive_
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double raisedNumber = RaisedNumber(number, power);
            Console.WriteLine(raisedNumber);
        }

        static double RaisedNumber(double a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            return a * RaisedNumber(a, b - 1); //with recursion
        }
    }
}
