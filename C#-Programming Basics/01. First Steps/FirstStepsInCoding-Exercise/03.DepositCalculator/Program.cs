using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interestPerYear = double.Parse(Console.ReadLine());

            double moneyTotal = deposit + months * (deposit * interestPerYear / 100 / 12);
            Console.WriteLine(moneyTotal);
        }
    }
}
