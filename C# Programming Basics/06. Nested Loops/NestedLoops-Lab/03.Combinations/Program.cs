using System;

namespace _03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i <= num; i++)
            {
                for (int j = 0; j <= num; j++)
                {
                    for (int z = 0; z <= num; z++)
                    {
                        if (i + j + z == num)
                        {
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
