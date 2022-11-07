using System;

namespace _03.CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double packageWeight = double.Parse(Console.ReadLine());
            string deliveryType = Console.ReadLine(); //"standard" or "express"
            double distance = double.Parse(Console.ReadLine()); //distance in km

            // Assigning delivery prices:
            double priceDelivery = 0;

            if (packageWeight < 1)
            {
                switch (deliveryType)
                {
                    case "standard": priceDelivery = 0.03 * distance; break;
                    case "express": priceDelivery = 0.03 * distance + packageWeight * 0.80 * (0.03 * distance); break;
                }
            }
            else if (packageWeight < 10)
            {
                switch (deliveryType)
                {
                    case "standard": priceDelivery = 0.05 * distance; break;
                    case "express": priceDelivery = 0.05 * distance * (1 + packageWeight * 0.40); break;
                }
            }
            else if (packageWeight < 40)
            {
                switch (deliveryType)
                {
                    case "standard": priceDelivery = 0.10 * distance; break;
                    case "express": priceDelivery = 0.10 * distance * (1 + packageWeight * 0.05); break;
                }
            }
            else if (packageWeight < 90)
            {
                switch (deliveryType)
                {
                    case "standard": priceDelivery = 0.15 * distance; break;
                    case "express": priceDelivery = 0.15 * distance * (1 + packageWeight * 0.02); break;
                }
            }
            else if (packageWeight < 150)
            {
                switch (deliveryType)
                {
                    case "standard": priceDelivery = 0.20 * distance; break;
                    case "express": priceDelivery = 0.20 * distance * (1 + packageWeight * 0.01); break;
                }
            }

            // Output:
            Console.WriteLine($"The delivery of your shipment with weight of {packageWeight:F3} kg. would cost {priceDelivery:F2} lv.");
        }   
    }
}

