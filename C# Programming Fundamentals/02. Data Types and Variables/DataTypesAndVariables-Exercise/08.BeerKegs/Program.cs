using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input number of beer keg:
            int kegCount = int.Parse(Console.ReadLine());

            // Estimating volume of n-kegs:
            double kegMaxVolume = double.MinValue;
            string kegBiggest = "";

            for (int i = 0; i < kegCount; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;

                if (kegVolume > kegMaxVolume)
                {
                    kegMaxVolume = kegVolume;
                    kegBiggest = kegModel;
                }
            }

            // Output biggest keg:
            Console.WriteLine(kegBiggest);
        }
    }
}
