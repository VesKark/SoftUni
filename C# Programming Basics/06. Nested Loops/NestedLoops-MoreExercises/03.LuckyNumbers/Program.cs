using System;

namespace _03.LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int number = int.Parse(Console.ReadLine());
            int oneTwo = 0;
            int threeFour = 0;

            // Generating lucky numbers [1111 to 9999]:
            for (int one = 1; one <= 9; one++)
            {
                for (int two = 1; two <= 9; two++)
                {
                    for (int three = 1; three <= 9; three++)
                    {
                        for (int four = 1; four <= 9; four++)
                        {
                            oneTwo = one + two;
                            threeFour = three + four;
                            if (oneTwo == threeFour && number % oneTwo == 0)
                            {
                                Console.Write($"{one}{two}{three}{four} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
