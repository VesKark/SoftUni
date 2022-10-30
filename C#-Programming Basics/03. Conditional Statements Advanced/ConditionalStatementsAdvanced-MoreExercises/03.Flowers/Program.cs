using System;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int marigold = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine(); // "Spring", "Summer", "Autumn" or "Winter"
            bool holiday = Console.ReadLine() == "Y"; //True - "Y", False - "N"

            // Estimating bouquet price:
            double bouquetPrice = 0;

            if (holiday)
            {                
                switch (season)
                {
                    case "Spring":
                    case "Summer":
                        bouquetPrice = (marigold * 2.00 + roses * 4.10 + tulips * 2.50) * 1.15; //additional charge from 15% because of holiday
                        if (tulips > 7 && season == "Spring")
                        {
                            bouquetPrice *= 0.95; // discount from 5%
                        }
                        break;

                    case "Autumn":
                    case "Winter":
                        bouquetPrice = (marigold * 3.75 + roses * 4.50 + tulips * 4.15) * 1.15; //additional charge from 15% because of holiday
                        if (roses >= 10 && season == "Winter")
                        {
                            bouquetPrice *= 0.90; // discount from 10%
                        }
                        break;
                }   
            }
            else
            {                
                switch (season)
                {
                    case "Spring":
                    case "Summer":
                        bouquetPrice = marigold * 2.00 + roses * 4.10 + tulips * 2.50;
                        if (tulips > 7 && season == "Spring")
                        {
                            bouquetPrice *= 0.95; // discount from 5%
                        }
                        break;

                    case "Autumn":
                    case "Winter":
                        bouquetPrice = marigold * 3.75 + roses * 4.50 + tulips * 4.15;
                        if (roses >= 10 && season == "Winter")
                        {
                            bouquetPrice *= 0.90; // discount from 10%
                        }
                        break;
                }
            }

            if (marigold + roses + tulips > 20)
            {
                bouquetPrice *= 0.80; // additional discount from 20%
            }

            // Output:
            Console.WriteLine($"{bouquetPrice + 2.0:F2}"); // additional 2 lv. for arranging the bouquet
        }
    }
}
