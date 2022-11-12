using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int count = int.Parse(Console.ReadLine());

            // Print "n" small letters:
            for (int i = 97; i < 97 + count; i++)
            {
                for (int j = 97; j < 97 + count; j++)
                {
                    for (int z = 97; z < 97 + count; z++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)z}");
                    }
                }
            }
        }
    }
}
