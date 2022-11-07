using System;

namespace _09.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int paintedEggs = int.Parse(Console.ReadLine());

            // Estimating count of eggs colors:
            int countRed = 0;
            int countOrange = 0;
            int countBlue = 0;
            int countGreen = 0;
            int maxEggs = int.MinValue;
            string maxColor = " ";

            for (int i = 0; i < paintedEggs; i++)
            {
                string eggColor = Console.ReadLine(); //"red", "orange", "blue" or "green"

                switch (eggColor)
                {
                    case "red": countRed++; break;
                    case "orange": countOrange++; break;
                    case "blue": countBlue++; break;
                    case "green": countGreen++; break;
                }
            }

            // Estimating max eggs of a color:
            if (countRed > maxEggs)
            {
                maxEggs = countRed;
                maxColor = "red";
            }
            if (countOrange > maxEggs)
            {
                maxEggs = countOrange;
                maxColor = "ornage";
            }
            if (countBlue > maxEggs)
            {
                maxEggs = countBlue;
                maxColor = "blue";
            }
            if (countGreen > maxEggs)
            {
                maxEggs = countGreen;
                maxColor = "green";
            }

            // Output:
            Console.WriteLine($"Red eggs: {countRed}");
            Console.WriteLine($"Orange eggs: {countOrange}");
            Console.WriteLine($"Blue eggs: {countBlue}");
            Console.WriteLine($"Green eggs: {countGreen}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {maxColor}");
        }
    }
}
