using System;

namespace _02.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            char letterStart = char.Parse(Console.ReadLine());
            char letterEnd = char.Parse(Console.ReadLine());
            char letterSkip = char.Parse(Console.ReadLine());

            // Generating and printing letter combinations:
            int counter = 0;

            for (int i = letterStart; i <= letterEnd; i++)
            {
                if (i == letterSkip)
                {
                    continue;
                }

                for (int j = letterStart; j <= letterEnd; j++)
                {
                    if (j == letterSkip)
                    {
                        continue;
                    }

                    for (int z = letterStart; z <= letterEnd; z++)
                    {
                        if (z == letterSkip)
                        {
                            continue;
                        }

                        Console.Write($"{(char)i}{(char)j}{(char)z} ");
                        counter++;
                    }
                }                
            }
            Console.WriteLine(counter);
        }
    }
}
