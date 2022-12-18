using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string expression = Console.ReadLine();
        Stack<int> indexBrackets = new Stack<int>();

        for (int i = 0; i < expression.Length; i++)
        {
            char curr = expression[i];
            string brackExpression = string.Empty;
            if (curr == '(')
            {
                indexBrackets.Push(i);
            }
            else if (curr == ')')
            {
                int startIndex = indexBrackets.Pop();
                brackExpression = expression.Substring(startIndex, i - startIndex + 1);
                Console.WriteLine(brackExpression);
            }
        }
    }
}