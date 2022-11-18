using System;
using System.Collections.Generic;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
			int productsCount = int.Parse(Console.ReadLine());
			List<string> products = new List<string>();

			for (int i = 0; i < productsCount; i++)
			{
				string currentProduct = Console.ReadLine();
				products.Add(currentProduct);
			}
			products.Sort();

			for (int i = 1; i <= productsCount; i++)
			{
				Console.WriteLine("{0}.{1}", i, products[i - 1]);
			}
		}
    }
}
