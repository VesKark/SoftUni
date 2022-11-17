using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine(); //"coffee", "coke", "water" or "snacks"
            int quantity = int.Parse(Console.ReadLine());

            OrderPrice(product, quantity);
        }

		static void OrderPrice(string product, int quantity)
		{
			double totalPrice = 0;

			switch (product)
			{
				case "coffee": totalPrice = quantity * 1.50; break;
				case "coke": totalPrice = quantity * 1.40; break;
				case "water": totalPrice = quantity * 1.00; break;
				case "snacks": totalPrice = quantity * 2.00; break;
			}
			Console.WriteLine(string.Format("{0:0.00}", totalPrice));
		}
	}
}
