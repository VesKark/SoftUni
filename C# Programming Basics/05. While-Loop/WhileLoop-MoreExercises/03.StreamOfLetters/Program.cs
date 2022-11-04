using System;

namespace _03.StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string input = Console.ReadLine();
            char symbol = ' ';
            string output = "";

            int countC = 0;
            int countO = 0;
            int countN = 0;


            // Checking and printing message:
            while (input != "End")
            {
                symbol = char.Parse(input);
                bool charIsLetter = Char.IsLetter(symbol);

                if (!charIsLetter)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (symbol == 'c')
                {
                    countC++;
                    if (countC > 1)
                    {
                        output += symbol;
                    }
                }
                else if (symbol == 'o')
                {
                    countO++;
                    if (countO > 1)
                    {
                        output += symbol;
                    }
                }
                else if (symbol == 'n')
                {
                    countN++;
                    if (countN > 1)
                    {
                        output += symbol;
                    }
                }
                else
                {
                    output += symbol;
                }

                bool printing = countC >= 1 && countO >= 1 && countN >= 1;
                if (printing)
                {
                    Console.Write(output + " ");
                    output = "";
                    countC = 0;
                    countO = 0;
                    countN = 0;
                }

                input = Console.ReadLine();
            }
        }
    }
}
