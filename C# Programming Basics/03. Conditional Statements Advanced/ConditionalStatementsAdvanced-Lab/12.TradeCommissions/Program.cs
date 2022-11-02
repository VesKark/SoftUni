using System;

namespace _12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0;

            // Output:
            if (sales >= 0 && sales <= 500)
            {
                switch (city)
                {
                    case "Sofia": commission = sales * 0.05; break;
                    case "Varna": commission = sales * 0.045; break;
                    case "Plovdiv": commission = sales * 0.055; break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                switch (city)
                {
                    case "Sofia": commission = sales * 0.07; break;
                    case "Varna": commission = sales * 0.075; break;
                    case "Plovdiv": commission = sales * 0.08; break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                switch (city)
                {
                    case "Sofia": commission = sales * 0.08; break;
                    case "Varna": commission = sales * 0.10; break;
                    case "Plovdiv": commission = sales * 0.12; break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (sales > 10000)
            {
                switch (city)
                {
                    case "Sofia": commission = sales * 0.12; break;
                    case "Varna": commission = sales * 0.13; break;
                    case "Plovdiv": commission = sales * 0.145; break;
                    default: Console.WriteLine("error"); break;
                }                
            }
            else
            {
                Console.WriteLine("error");
            }

            if (commission != 0)
            {
                Console.WriteLine($"{commission:F2}");
            }
        }
    }
}
