using System;

namespace _12.TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int checker = int.Parse(Console.ReadLine()); //check value in the range [4 - 144]

            // Generating combinations, where:
            // a < b
            // c > d
            // a * b + c * d = check value
            int countTo4 = 0;
            string checker4 = "";

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 2; b <= 9; b++)
                {
                    for (int c = 2; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a < b && c > d && a * b + c * d == checker)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                countTo4++;

                                if (countTo4 == 4)
                                {
                                    checker4 = $"{a}{b}{c}{d}";
                                }
                            }
                        }
                    }
                }
            }

            if (checker4 != "")
            {
                Console.WriteLine($"\nPassword: {checker4}");
            }
            if (countTo4 == 0 || checker4 == "")
            {
                Console.WriteLine("\nNo!");
            }
        }
    }
}
