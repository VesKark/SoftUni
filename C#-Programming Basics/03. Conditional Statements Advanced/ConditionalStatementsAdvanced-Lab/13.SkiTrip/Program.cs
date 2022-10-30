using System;

namespace _13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int days = int.Parse(Console.ReadLine()); //number of vacation days
            string room = Console.ReadLine(); //room type -> "room for one person", "apartment" or "president apartment"
            bool feedback = Console.ReadLine() == "positive"; //"positive" or "negative"

            // Calculatin total price of stay (!!! EXAMPLE: 11 days = 10 hotel nights):
            double totalPrice = 0;

            if (days < 10)
            {
                switch (room)
                {
                    case "room for one person": totalPrice = 18.00 * (days - 1); break;
                    case "apartment": totalPrice = 25.00 * (days - 1) * 0.70; break; //30% discount
                    case "president apartment": totalPrice = 35.00 * (days - 1) * 0.90; break; //10% discount
                }
            }
            else if (days <= 15)
            {
                switch (room)
                {
                    case "room for one person": totalPrice = 18.00 * (days - 1); break;
                    case "apartment": totalPrice = 25.00 * (days - 1) * 0.65; break; //35% discount
                    case "president apartment": totalPrice = 35.00 * (days - 1) * 0.85; break; //15% discount
                }
            }
            else if (days <= 365)
            {
                switch (room)
                {
                    case "room for one person": totalPrice = 18.00 * (days - 1); break;
                    case "apartment": totalPrice = 25.00 * (days - 1) * 0.50; break; //50% discount
                    case "president apartment": totalPrice = 35.00 * (days - 1) * 0.80; break; //20% discount
                }
            }

            // Output:
            if (feedback)
            {
                totalPrice *= 1.25; //additional charge from 25%
            }
            else
            {
                totalPrice *= 0.90; //additional discount from 10%
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
