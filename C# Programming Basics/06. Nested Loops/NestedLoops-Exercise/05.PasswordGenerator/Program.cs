using System;

namespace _05.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            // Generating password:
            for (int one = 1; one <= n; one++)
            {
                for (int two = 1; two <= n; two++)
                {
                    for (int three = 97; three < 97 + l; three++)
                    {
                        for (int four = 97; four < 97 + l; four++)
                        {
                            for (int five = 1; five <= n; five++)
                            {
                                if (five > one && five > two)
                                {
                                    Console.Write($"{one}{two}{(char)(three)}{(char)(four)}{five} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
