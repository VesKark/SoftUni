using System;

namespace _07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int stadium = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());

            // Estimating fans per sectors:
            int fansA = 0;
            int fansB = 0;
            int fansV = 0;
            int fansG = 0;

            for (int i = 0; i < fans; i++)
            {
                char sector = char.Parse(Console.ReadLine()); //'A', 'B', 'V' and 'G'

                switch (sector)
                {
                    case 'A': fansA++; break;
                    case 'B': fansB++; break;
                    case 'V': fansV++; break;
                    case 'G': fansG++; break;
                }
            }

            // Output:
            Console.WriteLine($"{fansA * 100.00 / fans:F2}%");
            Console.WriteLine($"{fansB * 100.00 / fans:F2}%");
            Console.WriteLine($"{fansV * 100.00 / fans:F2}%");
            Console.WriteLine($"{fansG * 100.00 / fans:F2}%");
            Console.WriteLine($"{fans * 100.00 / stadium:F2}%");
        }
    }
}
