using System;

namespace _10.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int coinsLv1 = int.Parse(Console.ReadLine()); //number of 1 leva conins
            int coinsLv2 = int.Parse(Console.ReadLine()); //number of 2 leva conins
            int billsLv5 = int.Parse(Console.ReadLine()); //number of 5 leva bills
            int sum = int.Parse(Console.ReadLine()); //total sum to be payed off

            // Generating sum combinations:
            for (int a = 0; a <= coinsLv1; a++)
            {
                for (int b = 0; b <= coinsLv2; b++)
                {
                    for (int c = 0; c <= billsLv5; c++)
                    {
                        if (a * 1 + b * 2 + c * 5 == sum)
                        {
                            Console.WriteLine($"{a} * 1 lv. + {b} * 2 lv. + {c} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
