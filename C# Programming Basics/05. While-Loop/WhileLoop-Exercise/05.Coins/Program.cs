using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            change *= 100;
            int countCoins = 0;

            while (change >= 1)
            {
                if (change >= 200)
                {
                    countCoins++;
                    change -= 200;
                }
                else if (change >= 100)
                {
                    countCoins++;
                    change -= 100; 
                }
                else if (change >= 50)
                {
                    countCoins++;
                    change -= 50;
                }
                else if (change >= 20)
                {
                    countCoins++;
                    change -= 20;
                }
                else if (change >= 10)
                {
                    countCoins++;
                    change -= 10;
                }
                else if (change >= 5)
                {
                    countCoins++;
                    change -= 5;
                }
                else if (change >= 2)
                {
                    countCoins++;
                    change -= 2;
                }
                else if (change >= 1)
                {
                    countCoins++;
                    change -= 1;
                }
            }

            Console.WriteLine(countCoins);
        }
    }
}
