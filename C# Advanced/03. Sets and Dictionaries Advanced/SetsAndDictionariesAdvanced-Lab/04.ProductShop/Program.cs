using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        var shopsProductInfo = new SortedDictionary<string, Dictionary<string, double>>();
        string command = string.Empty;

        while ((command = Console.ReadLine()) != "Revision")
        {
            string[] inputShopInfo = command.Split(", ");
            string shop = inputShopInfo[0];
            string product = inputShopInfo[1];
            double price = double.Parse(inputShopInfo[2]);

            if (!shopsProductInfo.ContainsKey(shop))
            {
                shopsProductInfo[shop] = new Dictionary<string, double>();
            }
            
            shopsProductInfo[shop][product] = price;            
        }

        foreach (var shop in shopsProductInfo)
        {
            Console.WriteLine($"{shop.Key}->");

            foreach (var product in shop.Value)
            {
                Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }
        }
    }
}