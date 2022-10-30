using System;

namespace _03.MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            bool contractPeriod = Console.ReadLine() == "one"; //period of the cocntract - "one" = TRUE / "two" = FALSE
            string contractType = Console.ReadLine(); //type of the cocntract - "Small", "Middle", "Large" or "ExtraLarge"
            bool mobileInternet = Console.ReadLine() == "yes"; //with/without mobile internet - "yes" = TRUE / "no" = FALSE
            int months = int.Parse(Console.ReadLine());

            // Estimating total costs for the given months:
            double monthlyTaxis = 0;

            if (contractPeriod)
            {
                switch (contractType)
                {
                    case "Small": monthlyTaxis = 9.98; break;
                    case "Middle": monthlyTaxis = 18.99; break;
                    case "Large": monthlyTaxis = 25.98; break;
                    case "ExtraLarge": monthlyTaxis = 35.99; break;
                }
            }
            else
            {
                switch (contractType)
                {
                    case "Small": monthlyTaxis = 8.58; break;
                    case "Middle": monthlyTaxis = 17.09; break;
                    case "Large": monthlyTaxis = 23.59; break;
                    case "ExtraLarge": monthlyTaxis = 31.79; break;
                }
            }

            if (mobileInternet)
            {
                if (monthlyTaxis <= 10)
                {
                    monthlyTaxis += 5.50;
                }
                else if (monthlyTaxis <= 30)
                {
                    monthlyTaxis += 4.35;
                }
                else if (monthlyTaxis > 30)
                {
                    monthlyTaxis += 3.85;
                }
            }

            // Output:
            double totalCosts = months * monthlyTaxis;

            if (!contractPeriod)
            {
                totalCosts *= (100 - 3.75) / 100;
            }

            Console.WriteLine($"{totalCosts:F2} lv.");
        }
    }
}
