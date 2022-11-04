using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            double sum = 0;

            while (money != "NoMoreMoney")
            {
                double deposition = double.Parse(money);

                if (deposition < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += deposition;
                Console.WriteLine($"Increase: {deposition:F2}");
                money = Console.ReadLine();
            }

            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
