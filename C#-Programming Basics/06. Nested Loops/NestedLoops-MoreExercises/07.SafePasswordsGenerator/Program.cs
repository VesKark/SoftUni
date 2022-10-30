using System;

namespace _07.SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int passwords = int.Parse(Console.ReadLine()); //number of passwords to generate

            // Generating passwords:

            for (int i = 35; i <= 55; i++)
            {
                for (int j = 64; j <= 96; j++)
                {
                    for (int k = 1; k <= a; k++)
                    {
                        for (int l = 1; l <= b; l++)
                        {
                            Console.Write($"{(char)i}{(char)j}{k}{l}{(char)j}{(char)i}|");
                            passwords--;

                            if (passwords == 0)
                            {
                                return;
                            }

                            i++;
                            if (i > 55)
                            {
                                i = 35;
                            }
                            j++;
                            if (j > 96)
                            {
                                j = 64;
                            }

                            if (k == a && l == b)
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
