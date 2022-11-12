using System;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int lines = int.Parse(Console.ReadLine());
            string inputTotal = "";
            bool isUnbalanced = false;

            // Building string of brackets:
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(" || input == ")")
                {
                    inputTotal += input;
                }                
            }

            // Checking if string is balanced or unbalanced:
            for (int i = 0; i < inputTotal.Length - 1; i++)
            {
                if (inputTotal[i] == inputTotal[i + 1])
                {
                    isUnbalanced = true;
                    break;
                }                
            }

            if (inputTotal.Length % 2 != 0)
            {
                isUnbalanced = true;
            }

            // Output:
            if (isUnbalanced)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }
        }
    }
}
