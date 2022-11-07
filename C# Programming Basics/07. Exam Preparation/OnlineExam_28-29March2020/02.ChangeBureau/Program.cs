using System;

namespace _02.ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int coinsBitcoin = int.Parse(Console.ReadLine());
            double coinsYuan= double.Parse(Console.ReadLine());
            double comission= double.Parse(Console.ReadLine());

            // Changing currency to euro:
            double leva = coinsBitcoin * 1168 + coinsYuan * 0.15 * 1.76;
            double euro = leva / 1.95;
            double euroFianl = euro * (1 - comission / 100);

            // Output:
            Console.WriteLine($"{euroFianl:F2}");
        }
    }
}
